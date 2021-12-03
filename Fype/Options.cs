using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Fype
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            if (ayarlar.Default.notifyiIconClick == "FloatingJoystick")
            {
                FloatingJoystick.Checked = true;
            }
            else if (ayarlar.Default.notifyiIconClick == "SingleJoystick")
            {
                SingleJoystick.Checked = true;
            }
            else if (ayarlar.Default.notifyiIconClick == "DoubleJoystick")
            {
                DoubleJoystick.Checked = true;
            }
            else if (ayarlar.Default.notifyiIconClick == "FloatingMarkingMenu")
            {
                FloatingMarkingMenu.Checked = true;
            }
            else if (ayarlar.Default.notifyiIconClick == "FixedMarkingMenu")
            {
                FixedMarkingMenu.Checked = true;
            }

            if (ayarlar.Default.midBut == true)
            {
                middleButtonActivator.Checked = true;
            }
            else if (ayarlar.Default.midBut == false)
            {
                middleButtonActivator.Checked = false;
            }
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                if (key.GetValue("PasoKey").ToString() == "\"" + Application.ExecutablePath + "\"")
                {
                    // If its in regedit, check the checkbox
                    runAtStartUp.Checked = true;
                }
            }
            catch
            {
                runAtStartUp.Checked = false;
            }
        }
        private void runAtStartUp_CheckedChanged(object sender, EventArgs e)
        {
            if (runAtStartUp.Checked)
            { //işaretlendi ise Regedit e açılışta çalıştır olarak ekle
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("PasoKey", "\"" + Application.ExecutablePath + "\"");
            }
            else
            {  //işaret kaldırıldı ise Regeditten açılışta çalıştırılacaklardan kaldır
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue("PasoKey");
            }

        }

        private void middleButtonActivator_CheckedChanged(object sender, EventArgs e)
        {
            if (ayarlar.Default.midBut == false)
            {
                ayarlar.Default.midBut = true;
            }
            else if (ayarlar.Default.midBut == true)
            {
                ayarlar.Default.midBut = false;
            }
            ayarlar.Default.Save();
        }

        private void FloatingJoystick_CheckedChanged(object sender, EventArgs e)
        {
            ayarlar.Default.notifyiIconClick = "FloatingJoystick";
        }

        private void SingleJoystick_CheckedChanged(object sender, EventArgs e)
        {
            ayarlar.Default.notifyiIconClick = "SingleJoystick";
        }

        private void DoubleJoystick_CheckedChanged(object sender, EventArgs e)
        {
            ayarlar.Default.notifyiIconClick = "DoubleJoystick";
        }

        private void FloatingMarkingMenu_CheckedChanged(object sender, EventArgs e)
        {
            ayarlar.Default.notifyiIconClick = "FloatingMarkingMenu";
        }

        private void FixedMarkingMenu_CheckedChanged(object sender, EventArgs e)
        {
            ayarlar.Default.notifyiIconClick = "FixedMarkingMenu";
        }
    }
}
