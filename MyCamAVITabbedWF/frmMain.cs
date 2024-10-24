using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using MyCamAVIControl;

namespace MyCamAVITabbedWF
{
    public partial class frmMain : Form
    {
        private frmEventBox errorBox;

        // Create storage arrays for Port data:
        private CheckBox[] digiInArray = new CheckBox[16];
        private CheckBox[] digiOutArray = new CheckBox[16];
        private CheckBox[] digiOutDispArray = new CheckBox[16];
        private TextBox[] sensorInArray = new TextBox[8];

        public frmMain()
        {
            InitializeComponent();
            errorBox = new frmEventBox();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Open TABs:
            Init_TABs(this);

            // Fill Font Name dropdowns:
            List<string> lstfonts = new List<string>();
            List<string> lstHifonts = new List<string>();
            List<string> lstLowfonts = new List<string>();
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                lstfonts.Add(font.Name);
                lstHifonts.Add(font.Name);
                lstLowfonts.Add(font.Name);
            }
            cboFont.DataSource = lstfonts;
            cboFont.SelectedIndex = 8;

            // Fill Font Color dropdowns:
            string[] aryColors = Enum.GetNames(typeof(System.Drawing.KnownColor));
            string[] systemEnvironmentColors = new string[(typeof(System.Drawing.SystemColors)).GetProperties().Length];
            List<string> aryMyColors = new List<string>();
            List<string> aryMyHiColors = new List<string>();
            List<string> aryMyLowColors = new List<string>();
            int index = 0;
            foreach (MemberInfo member in (typeof(System.Drawing.SystemColors)).GetProperties())
            {
                systemEnvironmentColors[index++] = member.Name;
            }
            foreach (string color in aryColors)
            {
                if (Array.IndexOf(systemEnvironmentColors, color) < 0)
                {
                    aryMyColors.Add(color);
                    aryMyHiColors.Add(color);
                    aryMyLowColors.Add(color);
                }
            }
            cboFontColor.DataSource = aryMyColors;
            cboFontColor.SelectedIndex = 21;
            cboHiFontColor.DataSource = aryMyHiColors;
            cboHiFontColor.SelectedIndex = 20;
            cboLowFontColor.DataSource = aryMyLowColors;
            cboLowFontColor.SelectedIndex = 20;

            // Set form defaults:
            cboFontSize.SelectedIndex = 5;
            cboHiFontSize.SelectedIndex = 5;
            cboLowFontSize.SelectedIndex = 5;


        }

        private void FillColors(object sender, EventArgs e)
        {

        }

        private void Init_TABs(object sender)
        {

            // Get saved info for tabs:
            try
            {
                string appPath = Path.GetDirectoryName(Application.ExecutablePath);
                //string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                XPathDocument xmlMySettings = new XPathDocument(appPath + @"\Settings.xml");
                XPathNavigator navMySettings = xmlMySettings.CreateNavigator();
                XPathNodeIterator nodeTABs = navMySettings.SelectDescendants("Tab", "", false);

                //lblMessage.Text = appPath + @"\Settings.xml";
                //Application.DoEvents();


                while (nodeTABs.MoveNext())
                {
                    // Navigate through TAB attributes:
                    XPathNavigator navTABs = nodeTABs.Current.Clone();

                    // Create and populate the first tab:
                    TabPage newTabPage = new TabPage();

                    navTABs.MoveToFirstAttribute(); // tabName
                    newTabPage.Name = navTABs.Value;

                    navTABs.MoveToNextAttribute(); // tabTitle
                    newTabPage.Text = navTABs.Value;

                    navTABs.MoveToParent();


                    // Setup user control:
                    navTABs.MoveToFirstChild(); // Move to MyCam node.

                    MyCamManager ctrlMyCAMAVI = new MyCamManager();

                        ctrlMyCAMAVI.Name = "ctrlMyCAMAVI";

                        navTABs.MoveToFirstAttribute(); // Disconnected
                        ctrlMyCAMAVI.Disconnected = Convert.ToBoolean(navTABs.Value);

                        navTABs.MoveToNextAttribute(); // camIndex
                        ctrlMyCAMAVI.SelectedCamera = Convert.ToInt32(navTABs.Value);

                        navTABs.MoveToNextAttribute(); // Period
                        ctrlMyCAMAVI.Period = navTABs.Value;

                        navTABs.MoveToNextAttribute(); // FrameCount
                        ctrlMyCAMAVI.FrameCount = Convert.ToInt32(navTABs.Value);

                        navTABs.MoveToNextAttribute(); // PeriodMultiplier
                        ctrlMyCAMAVI.PeriodMultiplier = Convert.ToInt32(navTABs.Value);

                        navTABs.MoveToNextAttribute(); // NamePrefix
                        ctrlMyCAMAVI.NamePrefix = navTABs.Value;

                        navTABs.MoveToNextAttribute(); // AddFrameCount
                        ctrlMyCAMAVI.AddFrameCount = Convert.ToBoolean(navTABs.Value);

                        navTABs.MoveToNextAttribute(); // AddDateTime
                        ctrlMyCAMAVI.AddDateTime = Convert.ToBoolean(navTABs.Value);

                        navTABs.MoveToNextAttribute(); // SnapshotFormat
                        ctrlMyCAMAVI.SnapshotFormat = Convert.ToInt32(navTABs.Value);

                        navTABs.MoveToNextAttribute(); // SnapshotResolution
                        ctrlMyCAMAVI.SnapshotResolution = Convert.ToInt32(navTABs.Value);

                        navTABs.MoveToNextAttribute(); // SnapshotPath
                        ctrlMyCAMAVI.SnapshotPath = navTABs.Value;

                        navTABs.MoveToNextAttribute(); // EnableAutoCapture
                        ctrlMyCAMAVI.EnableAutoCapture = Convert.ToBoolean(navTABs.Value);

                        navTABs.MoveToNextAttribute(); // EnableDateTimeOverlay
                        ctrlMyCAMAVI.EnableDateTime = Convert.ToBoolean(navTABs.Value);

                        // Populate TAB with user control:
                        newTabPage.Controls.Add(ctrlMyCAMAVI);

                    // OK, now get some Add/Delete buttons and text box for tabPage:
                    csAddTabPageControls(newTabPage, newTabPage.Text);

                }

            }
            catch (Exception e)
            {
                myErrorHandler(this,e);
            }
        }

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            // Create and populate the first tab:
            TabPage newTabPage = new TabPage();
            frmTabText _frmTabText = new frmTabText();

            // Get a tab name:
            DialogResult result = _frmTabText.ShowDialog();
            if (result == DialogResult.OK)
            {
                csAddTabPageControls(newTabPage, _frmTabText.TabText);

                // Populate TAB with user control & Add/Delete buttons:
                MyCamManager ctrlMyCAMAVI = new MyCamAVIControl.MyCamManager();
                ctrlMyCAMAVI.Name = "ctrlMyCAMAVI"; // 'cause we'll reference it by name later.
                newTabPage.Controls.Add(ctrlMyCAMAVI);
            }
            else // Opps, they cancelled, so exit procedure.
            {
                newTabPage.Dispose();
                _frmTabText.Dispose();
                return; 
            }
        }

        private void btnDeleteTab_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount == 1)
            {
                MessageBox.Show("This last tab may not be removed. Add another tab, then delete this one.");
            }
            else
            {
                // disconnect camera connection:
                
                UserControl uc = GetUserControlByName(tabControl1.SelectedTab, "ctrlMyCAMAVI");
                if (uc!=null)
                {
                    MyCamManager ctrlMyCAMAVI = uc as MyCamManager;
                    ctrlMyCAMAVI.Disconnect();
                }
                this.tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
        }

        private void csAddTabPageControls(TabPage newTabPage,string tabText)
        {
            // Create and populate the first tabPage:
            newTabPage.Name = "tab" + (tabControl1.TabCount + 1).ToString();
                //newTabPage.Text = (tabControl1.TabCount + 1).ToString();
            newTabPage.Text = tabText.ToString();


            // btnDeleteTab
            // 
            Button btnDeleteTab = new System.Windows.Forms.Button();
            btnDeleteTab.Location = new System.Drawing.Point(529, 701);
            btnDeleteTab.Name = "btnDeleteTab";
            btnDeleteTab.Size = new System.Drawing.Size(90, 23);
            btnDeleteTab.TabIndex = 3;
            btnDeleteTab.Text = "Delete this Tab";
            btnDeleteTab.UseVisualStyleBackColor = true;
            btnDeleteTab.Click += new System.EventHandler(this.btnDeleteTab_Click);
            btnDeleteTab.Visible = true;
            // Populate TAB with Delete button:
            newTabPage.Controls.Add(btnDeleteTab);
            
            // btnAddTab
            // 
            Button btnAddTab = new System.Windows.Forms.Button();
            btnAddTab.Location = new System.Drawing.Point(26, 701);
            btnAddTab.Name = "btnAddTab";
            btnAddTab.Size = new System.Drawing.Size(90, 23);
            btnAddTab.TabIndex = 2;
            btnAddTab.Text = "Add a Tab";
            btnAddTab.UseVisualStyleBackColor = true;
            btnAddTab.Click += new System.EventHandler(this.btnAddTab_Click);
            // Populate TAB with btnAddTab:
            newTabPage.Controls.Add(btnAddTab);

            // Finally, add tabPage & select it:
            tabControl1.TabPages.Add(newTabPage);
            tabControl1.SelectedTab = newTabPage;
        }


        public void myErrorHandler(object sender, Exception e)
        {
            MessageBox.Show("Whoops! " + Environment.NewLine + e + Environment.NewLine + Environment.NewLine + "...occurred in object:" + Environment.NewLine + sender, "Hugo says...", MessageBoxButtons.OK);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                string appPath = Path.GetDirectoryName(Application.ExecutablePath);
                using (XmlWriter writer = XmlWriter.Create(appPath + @"\Settings.xml"))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Tabs");   // Tabs - START
                    foreach (TabPage tab in this.tabControl1.TabPages)
                    {
                        writer.WriteStartElement("Tab");    // Tab - Start

                        writer.WriteStartAttribute("tabName");
                        writer.WriteValue(tab.Name);
                        writer.WriteEndAttribute();

                        writer.WriteStartAttribute("tabTitle");
                        writer.WriteValue(tab.Text);
                        writer.WriteEndAttribute();

                        // Get settings from MyCam usercontrol in tabpage:
                        writer.WriteStartElement("MyCam");    // MyCam - Start

                        foreach (Control c in tab.Controls)
                        {
                            if (c.Name == "ctrlMyCAMAVI") 
                            {
                                MyCamManager usrctrl = c as MyCamManager;

                                writer.WriteStartAttribute("Disconnected");
                                writer.WriteValue(usrctrl.Disconnected);
                                writer.WriteEndAttribute();

                                writer.WriteStartAttribute("camIndex");
                                writer.WriteValue(usrctrl.SelectedCamera);
                                writer.WriteEndAttribute();

                                writer.WriteStartAttribute("Period");
                                writer.WriteValue(usrctrl.Period);
                                writer.WriteEndAttribute();

                                writer.WriteStartAttribute("FrameCount");
                                writer.WriteValue(usrctrl.FrameCount);
                                writer.WriteEndAttribute();

                                writer.WriteStartAttribute("PeriodMultiplier");
                                writer.WriteValue(usrctrl.PeriodMultiplier);
                                writer.WriteEndAttribute();

                                writer.WriteStartAttribute("NamePrefix");
                                writer.WriteValue(usrctrl.NamePrefix);
                                writer.WriteEndAttribute();

                                writer.WriteStartAttribute("AddFrameCount");
                                writer.WriteValue(usrctrl.AddFrameCount);
                                writer.WriteEndAttribute();

                                writer.WriteStartAttribute("AddDateTime");
                                writer.WriteValue(usrctrl.AddDateTime);
                                writer.WriteEndAttribute();

                                writer.WriteStartAttribute("SnapshotFormat");
                                writer.WriteValue(usrctrl.SnapshotFormat);
                                writer.WriteEndAttribute();

                                writer.WriteStartAttribute("SnapshotResolution");
                                writer.WriteValue(usrctrl.SnapshotResolution);
                                writer.WriteEndAttribute();

                                writer.WriteStartAttribute("SnapshotPath");
                                writer.WriteValue(usrctrl.SnapshotPath);
                                writer.WriteEndAttribute();

                                writer.WriteStartAttribute("EnableAutoCapture");
                                writer.WriteValue(usrctrl.EnableAutoCapture);
                                writer.WriteEndAttribute();

                                writer.WriteStartAttribute("EnableDateTime");
                                writer.WriteValue(usrctrl.EnableDateTime);
                                writer.WriteEndAttribute();

                                writer.WriteEndElement();           // MyCam - End
                            }
                        }

                        writer.WriteEndElement();           // Tab - End
                    }
                    writer.WriteEndElement();           // Tabs - END
                    writer.WriteEndDocument();
                }
            }
            catch (Exception ex)
            {
                myErrorHandler(this, ex);
            }
        }

        private UserControl GetUserControlByName(Control container, string strControlName)
        {

            UserControl ctrlUser = null;

            foreach (Control ctrl in container.Controls)
            {

                if (ctrl is UserControl && ctrl.Name == strControlName)
                {

                    ctrlUser = ctrl as UserControl;

                }

                else
                {

                    ctrlUser = GetUserControlByName(ctrl, strControlName);

                }

                if (ctrlUser != null)
                {

                    break;

                }

            }

            return ctrlUser;

        }

    }
}
