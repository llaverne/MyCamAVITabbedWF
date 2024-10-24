using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text;
using AForge.Video;
using AForge.Video.DirectShow;
using AviFile;
using System.Diagnostics;

namespace MyIPCamAVIControl
{

    public partial class MyIPCamManager : UserControl
    {
        // **** PUBLIC PROPERTIES HERE:   **************************************************

        /// Camera selection:
        [Category("Data")]
        [Description("Gets or sets: Current camera index. int")]
        private int selectedCamera = 0;
        public int SelectedCamera
        {
            get => cboCameras.SelectedIndex;
            set => selectedCamera = value;
        }

        /// Resolution selection:
        [Category("Data")]
        [Description("Gets or sets: Current resolution index. int")]
        private int snapshotResolution = 0;
        public int SnapshotResolution
        {
            get => cboVideoResolution.SelectedIndex;
            set => snapshotResolution = value;
        }

        /// Capture enabled:
        [Category("Data")]
        [Description("Gets or sets: Enable Autocapture. bool")]
        private bool enableAutoCapture = false;
        public bool EnableAutoCapture
        {
            get => chkEnableAutoCapture.Checked;
            set => chkEnableAutoCapture.Checked = value;
        }

        /// Date & Time overlay enabled:
        [Category("Data")]
        [Description("Gets or sets: Enable DateTime overlay. bool")]
        private bool _enableDateTime = true;
        public bool EnableDateTime
        {
            get => chkDateTime.Checked;
            set => _enableDateTime = value;
        }

        /// Period:
        [Category("Data")]
        [Description("Gets or sets: Snapshot Period. string")]
        private string _Period = "3";
        public string Period
        {
            get => txtPeriod.Text;
            set => _Period = value;
        }

        /// Period Multiplier:
        [Category("Data")]
        [Description("Gets or sets: Period Multiplier index. int")]
        private int _PeriodMultiplier = 1;
        public int PeriodMultiplier
        {
            get => cboPeriod.SelectedIndex;
            set => _PeriodMultiplier = value;
        }


        /// Snapshot Nameing prefix:
        [Category("Data")]
        [Description("Gets or sets: Snapshot name prefix. string")]
        private string _NamePrefix = "Camera 1";
        public string NamePrefix
        {
            get => txtNamePrefix.Text;
            set => _NamePrefix = value;
        }

        /// Add Snapshot Frame Count enabled:
        [Category("Data")]
        [Description("Gets or sets: Enable Snapshot Frame Count. bool")]
        private bool _AddFrameCount = true;
        public bool AddFrameCount
        {
            get => chkAddFrameCount.Checked;
            set => _AddFrameCount = value;
        }

        /// Add Snapshot Date/Time enabled:
        [Category("Data")]
        [Description("Gets or sets: Enable Snapshot Date/Time. bool")]
        private bool _addDateTime = true;
        public bool AddDateTime
        {
            get => chkAddDateTime.Checked;
            set => _addDateTime = value;
        }

        /// Snapshot Format:
        [Category("Data")]
        [Description("Gets or sets: Snapshot Format index. int")]
        private int _SnapshotFormat = 0;
        public int SnapshotFormat
        {
            get => _SnapshotFormat;
            set => _SnapshotFormat = value;
        }

        /// Snapshot Path:
        [Category("Data")]
        [Description("Gets or sets: Snapshot folder path. string")]
        private string _SnapshotPath = @"D:\Videos";
        public string SnapshotPath
        {
            get => lnkPath.Text;
            set => _SnapshotPath = value;
        }

        /// Frame count:
        [Category("Data")]
        [Description("Gets or sets: Snapshot Frame Count. int")]
        private int intFrameCount = 1;
        public int FrameCount
        {
            get => intFrameCount;
            set => intFrameCount = value;
        }

        /// Add data/text labels:
        [Category("Data")]
        [Description("Gets or sets: Data/Text label overlay. array")]
        private string[,] _aryLabels;
        // <Label Input="DateTime" Text="Time" Font="" FontSize="" FontColor="" HorizontalDivision="4" VerticalDivision="1" DisplayMode="" DisplayHighValue=""
        // DisplayLowValue="" DataHighAlertValue="" DataHighAlertFontSize="" DataHighAlertFontColor="" DataLowAlertValue="" DataLowAlertFontSize="" 
        // DataLowAlertFontColor="" Enabled="true" />
        public string[,] aryLabels
        {
            get => aryLabels;
            set => _aryLabels = value;
        }


        /// Invert image checkbox:
        [Category("Data")]
        [Description("Gets or sets: Invert Image. bool")]
        public bool InvertImage
        {
            get => chkInvertImage.Checked;
            set => chkInvertImage.Checked = value;
        }

        /// Check & Close camera connection:
        [Category("Action")]
        [Description("Gets or sets: Disconnect camera if connected. bool")]
        private bool disconnected = true;
        public bool Disconnected
        {
            get
            {
                if (AForgeVideoSourcePlayer.VideoSource == null)
                { return true; }
                else
                { return false; }
            }

            set
            {
                if (value == true)
                {
                    disconnected = true;
                    Disconnect();
                }
                else
                {
                    disconnected = false;
                }

            }
        }

        public MyIPCamManager()
        {
            InitializeComponent();
        }

        // *** Global Variables:  *********************************************************************************************************************

        // DATE/TIME FORMAT FOR CAPTURE FILES:
        private string strDateTimeFormat = "yy-MM-dd hh.mm.ss tt";

        // LAST FRAME OF VIDEO STREAM CONTAINER:
        private Bitmap btmNewFrame;

        // Previous Frame (used if no new frame at time of SAVE)
        private Bitmap btmPreviousFrame;

        // SELECTED IMAGE FORMAT FOR CAPTURE & AVI CREATION:
        private ImageFormat objFormat;

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private VideoCapabilities[] videoCapabilities;
        private VideoCapabilities[] snapshotCapabilities;

        private void ManageCamera_Load(object sender, EventArgs e)
        {
            // SET DEFAULTS:
            txtResetFrameCounter.Text = intFrameCount.ToString();
            cboPeriod.SelectedIndex = _PeriodMultiplier;
            txtPeriod.Text = _Period;
            txtNamePrefix.Text = _NamePrefix;
            lnkPath.Text = _SnapshotPath;
            lblNextSnapshot.Text = "*** DISABLED *** )";
            chkDateTime.Checked = _enableDateTime;
            chkAddDateTime.Checked = _addDateTime;
            chkAddFrameCount.Checked = _AddFrameCount;
            cboFormat.SelectedIndex = _SnapshotFormat;
            chkInvertImage.Checked = InvertImage;

            // Create permanent objects:
            ToolTip1.SetToolTip(this.chkDateTime, "Show snaphot date & time on picture");
            ToolTip1.SetToolTip(this.btnMakeAVI, "Using " + cboFormat.Text + " files, located in " + lnkPath.Text);

            // Get the list of available USB cameras:
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice); // VideoInputDevice is the list of local cams only, generated by Windows.

            // Get the list of available Web (JPEG) cameras: https://stackoverflow.com/questions/36764740/can-sharppcap-be-used-to-find-ip-cameras-in-my-network-in-c-sharp


            // Populate combo box with camera lists:
            if (videoDevices.Count != 0)
            {
                // add all devices to combo
                foreach (FilterInfo device in videoDevices)
                {
                    cboCameras.Items.Add(device.Name);
                }
                cboCameras.SelectedIndex = selectedCamera;

                if (!disconnected)
                    btnStart.PerformClick();
                else
                    EnableConnectionControls(true);


            }
            else
            {
                cboCameras.Items.Add("No cameras found");
            }

        }

        private void ManageCamera_ControlRemoved(object sender, FormClosingEventArgs e)
        {
            Disconnect();

            // Save settings:
            //settings.PutSetting("MainForm/Top", this.Top);
            //settings.PutSetting("MainForm/Left", this.Left);
        }

        // Enable/disable connection related controls:
        private void EnableConnectionControls(bool enable)
        {
            // Camera is NOT running so enable these:
            cboCameras.Enabled = enable;
            cboVideoResolution.Enabled = enable;
            btnStart.Enabled = enable;
            //cboFormat.Enabled = enable;
            // ... however, disable these:
            btnStop.Enabled = !enable;
            btnSave.Enabled = !enable;
            btnConfig.Enabled = !enable;

        }

        // New camera is selected
        private void cboCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboVideoResolution.Items.Clear();

            if (videoDevices.Count != 0)
            {
                cboVideoResolution.Enabled = true;
                videoSource = new VideoCaptureDevice(videoDevices[cboCameras.SelectedIndex].MonikerString);
                EnumeratedSupportedFrameSizes(videoSource);
            }
        }

        // Get supported video sizes
        private void EnumeratedSupportedFrameSizes(VideoCaptureDevice videoDevice)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                videoCapabilities = videoDevice.VideoCapabilities;
                snapshotCapabilities = videoDevice.SnapshotCapabilities;

                foreach (VideoCapabilities capabilty in videoCapabilities)
                {
                    string item = string.Format(
                        "{0} x {1}", capabilty.FrameSize.Width, capabilty.FrameSize.Height);

                    if (!cboVideoResolution.Items.Contains(item))
                    {
                        cboVideoResolution.Items.Add(item);
                    }
                }
            }
            catch (Exception e) { myErrorHandler(this, e); }
            finally { this.Cursor = Cursors.Default; }

            if (cboVideoResolution.Items.Count > 0)
            {
                cboVideoResolution.Enabled = true;
                cboVideoResolution.SelectedIndex = snapshotResolution;
            }
            else
            {
                cboVideoResolution.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (videoSource != null)
            {
                if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
                {
                    videoSource.DesiredFrameSize = videoCapabilities[cboVideoResolution.SelectedIndex].FrameSize;
                    videoSource.NewFrame += new NewFrameEventHandler(videoDevice_NewFrame);

                }

                EnableConnectionControls(false);

                AForgeVideoSourcePlayer.VideoSource = videoSource;
                AForgeVideoSourcePlayer.Start();

                if (enableAutoCapture)
                    chkEnableAutoCapture.Select();
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            chkEnableAutoCapture.Enabled = false;
            Disconnect();
        }

        // Disconnect from video device
        public void Disconnect()
        {
            if (AForgeVideoSourcePlayer.VideoSource != null)
            {
                //Stop timer
                chkEnableAutoCapture.Checked = false;

                // stop video device
                AForgeVideoSourcePlayer.SignalToStop();
                AForgeVideoSourcePlayer.WaitForStop();
                AForgeVideoSourcePlayer.VideoSource = null;

                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource.NewFrame -= new NewFrameEventHandler(videoDevice_NewFrame);

                if (btmNewFrame != null)
                {
                    btmNewFrame.Dispose();
                }

                EnableConnectionControls(true);
            }
        }


        // *** New snapshot frame is available ****************************************************************************
        private void videoDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //This event is fired on each new frame received from video source.
            //The event is fired right after receiving and BEFORE displaying, giving user a chance to perform some image processing on the new frame and/or update it.

            //Note:Users should not keep references of the passed to the event handler image.
            //If user needs to keep the image, it should be cloned, since the original image will be disposed by the control when it is required.

            // https://csharp.hotexamples.com/examples/AForge.Controls/VideoSourcePlayer/-/php-videosourceplayer-class-examples.html
            // Example 4 for URL

            if (btmNewFrame != null)
            {
                if (btmPreviousFrame != null)
                {
                    btmPreviousFrame.Dispose(); //memory leak handler.
                }

                try { btmPreviousFrame = (Bitmap)btmNewFrame.Clone(); }
                catch (Exception ex) { }

                btmNewFrame.Dispose(); //memory leak handler.
            }

            btmNewFrame = (Bitmap)eventArgs.Frame;
            Graphics objCurrentFrame = Graphics.FromImage((Bitmap)eventArgs.Frame);

            // Invert image?
            if (chkInvertImage.Checked)
            {
                btmNewFrame.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }

            // Show date & time on image?
            if (chkDateTime.Checked)
            {
                int intFontSize = 12;
                int intOpacity = 200; // 0-255
                Color objTextColor = Color.FromArgb(intOpacity, Color.Aquamarine);
                int intLabelPadding = 10; // How many pixles to add around label.

                int X = intLabelPadding;  // Text X position
                //int Y = ((((Bitmap)eventArgs.Frame).Height) - intFontSize) - intLabelPadding; // Text Y position
                int Y = ((((Bitmap)eventArgs.Frame).Height) - intFontSize) - intLabelPadding; // Text Y position

                objCurrentFrame.SmoothingMode = SmoothingMode.AntiAlias;

                SolidBrush objTextBrush = new SolidBrush(objTextColor);
                objCurrentFrame.DrawString(DateTime.Now.ToString(), new Font("Arial", intFontSize, FontStyle.Bold), objTextBrush, new Point(X, Y));
                // Draw a circle on it:
                //objCurrentFrame.DrawArc(new Pen(Color.Red, 3), 90, 235, 150, 50, 0, 360); 

            }

            btmNewFrame = (Bitmap)eventArgs.Frame.Clone();
            objCurrentFrame.Dispose();

            //Enable checkbox AFTER video starts to avoid capture exception:
            if (chkEnableAutoCapture.InvokeRequired)
            {
                if (!chkEnableAutoCapture.Enabled)
                {
                    MethodInvoker method = delegate
                    {
                        chkEnableAutoCapture.Enabled = true;
                    };

                    if (InvokeRequired)
                        BeginInvoke(method);
                    else
                        method.Invoke();

                }
            }

        }
        // ****************************************************************************************************************

        // *** Deal with new captures: ************************************************************************************
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Create file path for snapshot:
            string strFile = lnkPath.Text + "\\" + txtNamePrefix.Text;

            // Reset timer:
            double dblNewPeriod = CalculatePeriod();
            timer1.Interval = Convert.ToInt32(dblNewPeriod);

            if (chkAddFrameCount.Checked)
            {

                if (intFrameCount < 10)
                { strFile = strFile + " 000" + intFrameCount; } // add leading '0' for frames 1-9 for sorting later
                else if (intFrameCount < 100)
                { strFile = strFile + " 00" + intFrameCount; }
                else if (intFrameCount < 1000)
                { strFile = strFile + " 0" + intFrameCount; }
                else
                { strFile = strFile + " " + intFrameCount; }
            }

            if (chkAddDateTime.Checked)
            {
                strFile = strFile + " " + DateTime.Now.ToString(strDateTimeFormat);
            }

            strFile = strFile + "." + objFormat.ToString();

            try
            {
                // Get a copy of last snapshot for manipulation & saving:
                Bitmap btmSnapShot;
                if (btmNewFrame != null)
                {
                    btmSnapShot = (Bitmap)btmNewFrame.Clone();
                }
                else
                {
                    btmSnapShot = (Bitmap)btmPreviousFrame.Clone();
                }


                string strCaption = "";

                // check for & ignore dark frames:
                var colors = new List<Color>();
                for (int x = 0; x < btmSnapShot.Size.Width; x += 20)
                {
                    for (int y = 0; y < btmSnapShot.Size.Height; y += 20)
                    {
                        colors.Add(btmSnapShot.GetPixel(x, y));
                    }
                }

                float imageBrightness = colors.Average(color => color.GetBrightness());
                if (imageBrightness < .1)
                {
                    strCaption = "Too dark";
                    btmSnapShot.Dispose();
                }
                else // Image is bright enough to save:
                {
                    lock (this)
                    {
                        btmSnapShot.Save(strFile, objFormat);
                        btmSnapShot.Dispose();

                        // Update Next Snapshot label:
                        string strFrameCount = (intFrameCount + 1).ToString();

                        strCaption = Convert.ToString(DateTime.Now.AddMilliseconds(dblNewPeriod)) + ", Frame# " + strFrameCount + ")";

                        lblNextSnapshot.Text = strCaption;

                        txtResetFrameCounter.Text = strFrameCount;


                        // Increment snapshot counter:
                        intFrameCount++;
                    }
                }
            }
            catch (Exception ex)
            {
                // Rarely, very rarely, a frame is missed and causes an exception.
                // myErrorHandler(this, ex);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // Get a copy of last snapshot for manipulation & saving:
            Bitmap btmThisFrame = (Bitmap)btmNewFrame.Clone();

            using (SaveFileDialog saveFileBox = new SaveFileDialog())
            {
                saveFileBox.InitialDirectory = lnkPath.Text;
                saveFileBox.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|png files (*.png)|*.png|gif files (*.gif)|*.gif|All files (*.*)|*.*";
                saveFileBox.FilterIndex = 2;

                saveFileBox.FileName = txtNamePrefix.Text + " " + DateTime.Now.ToString(strDateTimeFormat); // adds date & time to file name.
                ImageFormat format = ImageFormat.Jpeg;

                if (saveFileBox.ShowDialog() == DialogResult.OK)
                {
                    string ext = Path.GetExtension(saveFileBox.FileName).ToLower();
                    switch (ext)
                    {
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                        case ".gif":
                            format = ImageFormat.Gif;
                            break;
                        case ".ico":
                            format = ImageFormat.Icon;
                            break;
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".jpeg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                        case ".wmf":
                            format = ImageFormat.Wmf;
                            break;
                    }

                    try
                    {
                        lock (this)
                        {
                            btmThisFrame.Save(saveFileBox.FileName, format);
                            btmThisFrame.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        btmThisFrame.Dispose();
                        myErrorHandler(this, ex);
                    }
                }
            }



        }
        // ****************************************************************************************************************


        private void btnConfig_Click(object sender, EventArgs e)
        {
            VideoCaptureDevice videoSource = (VideoCaptureDevice)
            this.AForgeVideoSourcePlayer.VideoSource;
            videoSource.DisplayPropertyPage(IntPtr.Zero);
        }

        private void btnChangePath_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.
            folderBrowserDialog1.SelectedPath = lnkPath.Text;
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                lnkPath.Text = folderBrowserDialog1.SelectedPath;
                _SnapshotPath = folderBrowserDialog1.SelectedPath;
                ToolTip1.SetToolTip(this.btnMakeAVI, "Using " + cboFormat.Text + " files, located in " + _SnapshotPath.ToString());
            }

        }

        private void lnkPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer", "/select," + ((LinkLabel)sender).Text);
        }

        private void chkEnableAutoCapture_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableAutoCapture.Checked)
            {
                timer1.Enabled = true;
                timer1.Interval = 500;
                txtResetFrameCounter.Enabled = false;
            }
            else
            {
                timer1.Enabled = false;
                lblNextSnapshot.Text = "*** DISABLED *** )";
                txtResetFrameCounter.Enabled = true;
            }
        }


        private double CalculatePeriod()
        {
            double dblNewPeriod = Convert.ToDouble(txtPeriod.Text);
            int intMultiplier = 1;
            string strSelected = "";

            Action action = () => strSelected = cboPeriod.Text;
            this.Invoke(action);

            switch (strSelected)
            {
                case "Second(s)":
                    intMultiplier = 1000;
                    break;
                case "Minute(s)":
                    intMultiplier = (1000 * 60);
                    break;
                case "Hour(s)":
                    intMultiplier = (1000 * 60) * 60;
                    break;
            }

            dblNewPeriod = (dblNewPeriod * intMultiplier);

            return dblNewPeriod;
        }

        private void txtPeriod_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPeriod.Text != "")
            {
                if (Convert.ToInt16(txtPeriod.Text) > 200)
                    txtPeriod.Text = "200";
            }
        }


        private void btnMakeAVI_Click(object sender, EventArgs e)
        {
            btnMakeAVI.Enabled = false;
            btnMakeAVI.Text = "Building...";
            IPFrameRateForm dlg = new IPFrameRateForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Make a list of images to include:
                string strExtension = objFormat.ToString();
                strExtension = "*." + strExtension;
                string[] strFiles = Directory.GetFiles(_SnapshotPath.ToString(), strExtension);
                btnMakeAVI.Text = "Sorting..";
                Application.DoEvents();
                Array.Sort(strFiles);

                Bitmap bitmap = (Bitmap)Image.FromFile(strFiles[0]);
                //Begin a new AVI file
                AviManager aviManager;
                aviManager = new AviManager(_SnapshotPath.ToString() + "\\" + txtNamePrefix.Text + " " + DateTime.Now.ToString(strDateTimeFormat) + ".avi", false);
                //add a new video stream and one frame to the new file to initialize it
                VideoStream aviStream;
                aviStream = aviManager.AddVideoStream(false, dlg.Rate, bitmap);

                int intVideoSize = 0; // to determine video size limit

                for (int i = 1; i < strFiles.Length; i++)
                {
                    intVideoSize = intVideoSize + aviStream.FrameSize; //5,760,000

                    if (intVideoSize < 2000000000) //2GB Avi file limit reached?
                    {
                        bitmap = (Bitmap)Bitmap.FromFile(strFiles[i]);

                        // check for & ignore dark frames:
                        var colors = new List<Color>();
                        for (int x = 0; x < bitmap.Size.Width; x += 20)
                        {
                            for (int y = 0; y < bitmap.Size.Height; y += 20)
                            {
                                colors.Add(bitmap.GetPixel(x, y));
                            }
                        }

                        float imageBrightness = colors.Average(color => color.GetBrightness());
                        if (imageBrightness > .1)
                        {
                            btnMakeAVI.Text = "Adding: " + i;
                            aviStream.AddFrame(bitmap);
                            Application.DoEvents();
                        }
                        else
                        {
                            btnMakeAVI.Text = "Too dark: " + i;
                        }
                        bitmap.Dispose();

                    }
                    else
                    {
                        intVideoSize = 0;
                        aviManager.Close();
                        aviManager = new AviManager(_SnapshotPath.ToString() + "\\" + txtNamePrefix.Text + " " + DateTime.Now.ToString(strDateTimeFormat) + ".avi", false);
                        bitmap = (Bitmap)Bitmap.FromFile(strFiles[i]);
                        aviStream = aviManager.AddVideoStream(false, dlg.Rate, bitmap);
                        bitmap.Dispose();
                    }

                }

                if (aviManager != null)
                {
                    aviManager.Close();
                }

                btnMakeAVI.Text = "Make AVI";
                btnMakeAVI.Enabled = true;
            }


        }

        private void cboFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboFormat.Text)
            {
                case "BMP":
                    objFormat = ImageFormat.Bmp;
                    break;
                case "GIF":
                    objFormat = ImageFormat.Gif;
                    break;
                case "ICO":
                    objFormat = ImageFormat.Icon;
                    break;
                case "JPG":
                    objFormat = ImageFormat.Jpeg;
                    break;
                case "PNG":
                    objFormat = ImageFormat.Png;
                    break;
                case "WMF":
                    objFormat = ImageFormat.Wmf;
                    break;
            }
        }

        private void btnMakeAVI_MouseHover(object sender, EventArgs e)
        {
            ToolTip1.SetToolTip(this.btnMakeAVI, "Using " + cboFormat.Text + " files, located in " + lnkPath.Text);
        }

        public void myErrorHandler(object sender, Exception e)
        {
            MessageBox.Show("Whoops! " + Environment.NewLine + e.ToString() + Environment.NewLine + Environment.NewLine + "...occurred in object:" + Environment.NewLine + sender, "Hugo says...", MessageBoxButtons.OK);
        }

        private void txtResetFrameCounter_Leave(object sender, EventArgs e)
        {
            intFrameCount = Convert.ToInt32(txtResetFrameCounter.Text);
        }

        private void chkDateTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddDateTime.Checked)
                EnableDateTime = true;
            else
                EnableDateTime = false;
        }

        private void txtResetFrameCounter_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtResetFrameCounter.Text = "1";
        }
    }
}
