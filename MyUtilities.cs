using System;

public class Class1
{
    private MethodInvoker del;

    private void ctrlA_EventHandler(object sender, EventArgs e)
    {

        if (del == null)
        {

            Control ctrlCurrent = sender as Control;

            // look for another control by its Name "ctrlB"

            if (ctrlCurrent != null && ctrlCurrent.TopLevelControl != null)
            {

                UserControl ctrlB = GetUserControlByName(ctrlCurrent.TopLevelControl, "ctrlB");

                if (ctrlB != null)
                {

                    del = new MethodInvoker(ctrlB.GetAge);

                    del.Invoke();

                }

            }

        }

        else
        {

            del.Invoke();

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
	public Class1()
	{

	}
}
