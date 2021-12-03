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
using Gma.System.MouseKeyHook;

namespace Fype
{
    public partial class Main : Form
    {


        public Main()
        {
            InitializeComponent();
            Hook.GlobalEvents().MouseClick += async (sender, e) =>
            {
                if (ayarlar.Default.midBut == true)
                {
                    /*
                     * if (e.Button == MouseButtons.Middle)
                    {
                        this.Show();
                        this.WindowState = FormWindowState.Normal;
                        this.Left = Cursor.Position.X;
                        this.Top = Cursor.Position.Y;
                    }
                    else
                    {
                        if (this.WindowState == FormWindowState.Normal)//form minimize değilse çalıştır
                        {//form normal ise burası çalışır, her seferinde çalışmasını engelleyen bir sınırlayıcı
                            //mouse, form kordinatları dışındaysa çalışır
                            if (Cursor.Position.X < this.Left || Cursor.Position.X > (this.Left + this.Width) || Cursor.Position.Y < this.Top || Cursor.Position.Y > (this.Top + this.Height))
                            {
                                this.Hide();
                                this.WindowState = FormWindowState.Minimized;//formu minimize et
                            }
                        }

                    }
                    */
                    if (e.Button == MouseButtons.Middle)
                    {
                        contextMenuStrip1.Show();
                        contextMenuStrip1.Left = Cursor.Position.X;
                        contextMenuStrip1.Top = Cursor.Position.Y;
                    }
                    else
                    {
                        //mouse, form kordinatları dışındaysa çalışır
                        if (Cursor.Position.X < contextMenuStrip1.Left || Cursor.Position.X > (contextMenuStrip1.Left + contextMenuStrip1.Width) || Cursor.Position.Y < contextMenuStrip1.Top || Cursor.Position.Y > (contextMenuStrip1.Top + contextMenuStrip1.Height))
                        {
                            contextMenuStrip1.Hide();
                        }
                    }
                }
            };
        }
        GamepadMod gamepadMod = new GamepadMod();
        private void PasoKeyMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            gamepadMod.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
        }
        private void closeThePasoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            ayarlar.Default.Save();
        }

    }
}
