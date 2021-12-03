using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenJigWare;

namespace Fype
{
    public partial class GamepadMod : Form
    {
        public GamepadMod()
        {
            InitializeComponent();
            this.TransparencyKey = BackColor;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }


        private void GamepadMod_Load(object sender, EventArgs e)
        {
            joystickHook.Enabled = true;
        }
        private Ojw.CJoystick m_CJoy = new Ojw.CJoystick(Ojw.CJoystick._ID_0);
        private Ojw.CTimer m_CTmr_Joystick = new Ojw.CTimer();

        //joystick bağlantısını kontrol ediyoruz
        private void JoystickCheckAlive()
        {
            Color colorAlive = Color.Green;
            Color colorDeath = Color.Gray;
            if (m_CJoy.IsValid == false)
            {
                if (lbJoystick.ForeColor != colorDeath)
                {
                    lbJoystick.Text = "Joystick (No Connected)";
                    lbJoystick.ForeColor = colorDeath;
                    buttonTimer.Enabled = false;
                    mouseTimer.Enabled = false;
                }
                if (m_CTmr_Joystick.Get() > 3000)
                {
                    Ojw.CMessage.Write("Joystick Check again");
                    m_CJoy = new Ojw.CJoystick(Ojw.CJoystick._ID_0);

                    if (m_CJoy.IsValid == false)
                    {
                        Ojw.CMessage.Write("But we can't find a joystick device in here. Check your joystick device");
                        m_CTmr_Joystick.Set();
                    }
                    else Ojw.CMessage.Write("Joystick is Connected");
                }
            }
            else
            {
                if (lbJoystick.ForeColor != colorAlive)
                {
                    lbJoystick.Text = "Joystick (Connected)";
                    lbJoystick.ForeColor = colorAlive;
                }
                mouseTimer.Enabled = true;
                buttonTimer.Enabled = true;
            }
        }

        string labelDegeri = "";

        int firstStep = 5;
        int secondStep = 9;
        string upOrLow = "low";//büyük küçük harf seçici
        //küçük harf kümesi
        string[,] keyPad = new string[5, 8] {
            {"a","b","c","d","e","f","g","h"},
            {"i","j","k","l","m","n","o","p"},
            {"q","r","s","t","u","v","w","x"},
            {"y","z","1","2","3","4","5","6"},
            {"7","8","9","0",".",",","!","?"}
        };
        //büyük harf kümesi
        private void WriteFirstStepToLbl()
        {
            if (firstStep != 5)//buton hareket etse bile bir değer atandı mı emin oluyorum
            {
                if (upOrLow == "low")//büyük küçük harf kümesini seçiyorum
                {
                    rightLbl0.Text = keyPad[firstStep, 0];
                    rightLbl1.Text = keyPad[firstStep, 1];
                    rightLbl2.Text = keyPad[firstStep, 2];
                    rightLbl3.Text = keyPad[firstStep, 3];
                    rightLbl4.Text = keyPad[firstStep, 4];
                    rightLbl5.Text = keyPad[firstStep, 5];
                    rightLbl6.Text = keyPad[firstStep, 6];
                    rightLbl7.Text = keyPad[firstStep, 7];
                }
                else
                {
                    rightLbl0.Text = keyPad[firstStep, 0].ToUpper();
                    rightLbl1.Text = keyPad[firstStep, 1].ToUpper();
                    rightLbl2.Text = keyPad[firstStep, 2].ToUpper();
                    rightLbl3.Text = keyPad[firstStep, 3].ToUpper();
                    rightLbl4.Text = keyPad[firstStep, 4].ToUpper();
                    rightLbl5.Text = keyPad[firstStep, 5].ToUpper();
                    rightLbl6.Text = keyPad[firstStep, 6].ToUpper();
                    rightLbl7.Text = keyPad[firstStep, 7].ToUpper();
                }
            }
        }

        bool show = true;
        bool mouseMod = false;
        bool mouseLeftClicked = true;
        bool mouseRightClicked = true;
        //mouse codes
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern void mouse_event(uint flag, uint _x, uint _y, uint btn, uint exInfo);
        private const int MOUSEEVENT_LEFTDOWN = 0x02;//Left click pressed
        private const int MOUSEEVENT_LEFTUP = 0x04;//Left click released
        private const int MOUSEEVENT_RIGHTDOWN = 0x08; //Right click pressed
        private const int MOUSEEVENT_RIGHTUP = 0x10; //Right click released
        //keyboard volume-up-down
        [DllImport("user32.dll")]
        public static extern void SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        private void Moder()
        {
            if (mouseMod == false)
            {
                mouseMod = true;
            }
            else if (mouseMod == true)
            {
                mouseMod = false;
            }
        }
        private void Visibility()
        {
            if (show == true)
            {
                this.Hide();
                show = false;
            }
            else if (show == false)
            {
                this.Show();
                show = true;
            }
        }

        private void JoystickCheckButton()
        {
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button9) == true)
            {
                labelDegeri = "select";
                Moder();
            }
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button10) == true)
            {
                labelDegeri = "start";
                Visibility();
            }
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.POVLeft) == true)
            {
                labelDegeri = "← ";
                SendKeys.Send("{LEFT}");
            }
            else if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.POVRight) == true)
            {
                labelDegeri = "→ ";
                SendKeys.Send("{RIGHT}");
            }
            else
            {
                labelDegeri = "";
            }

            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.POVUp) == true)
            {
                labelDegeri += "↑";
                SendKeys.Send("{UP}");
            }
            else if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.POVDown) == true)
            {
                labelDegeri += "↓";
                SendKeys.Send("{DOWN}");
            }

            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button4) == true)
            {
                labelDegeri = "Y";
                SendKeys.Send("%{LEFT}");//alt-left, undo
            }
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button3) == true)
            {
                labelDegeri = "X";
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
                //vol-down

            }
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button2) == true)
            {
                labelDegeri = "B";
                SendKeys.Send("%{RIGHT}");//alt-right, redo
            }
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button1) == true)
            {
                labelDegeri = "A";
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
                //vol-up
            }

            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button5) == true)
            {
                labelDegeri = "L1";
                SendKeys.Send("{TAB}");
            }
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button6) == true)
            {
                labelDegeri = "R1";
                SendKeys.Send("{ENTER}");
            }
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button7) == true)
            {
                labelDegeri = "L2";
                SendKeys.Send("{ESC}");
            }
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button8) == true)
            {
                labelDegeri = "R2";
                SendKeys.Send("{ENTER}");
            }

            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button11) == true)
            {
                movingPartLeft.BackColor = Color.WhiteSmoke;
            }
            if (m_CJoy.IsUp(Ojw.CJoystick.PadKey.Button11) == true)
            {
                movingPartLeft.BackColor = Color.White;
            }
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button12) == true)
            {
                movingPartRight.BackColor = Color.WhiteSmoke;
            }
            if (m_CJoy.IsUp(Ojw.CJoystick.PadKey.Button12) == true)
            {
                movingPartRight.BackColor = Color.White;
            }

            label1.Text = labelDegeri;
            //100 ile çarp virgülü yok et
            int leftThumbX = (int)(m_CJoy.GetPos0 * 100);
            int leftThumbY = (int)(m_CJoy.GetPos1 * 100);
            int rightThumbX = (int)(m_CJoy.GetPos2 * 100);
            int rightThumbY = (int)(m_CJoy.GetPos3 * 100);

            movingPartLeft.Location = new Point((int)(300 * m_CJoy.GetPos0), (int)(300 * m_CJoy.GetPos1));
            movingPartRight.Location = new Point((int)(300 * m_CJoy.GetPos2), (int)(300 * m_CJoy.GetPos3));
            if (mouseMod == true)
            {
                if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button11) == true)
                {
                    if (mouseLeftClicked == true)
                    {
                        mouse_event(MOUSEEVENT_LEFTDOWN, 0, 0, 0, 0);
                        mouseLeftClicked = false;
                    }
                }
                if (m_CJoy.IsUp(Ojw.CJoystick.PadKey.Button11) == true)
                {
                    if (mouseLeftClicked == false)
                    {
                        mouse_event(MOUSEEVENT_LEFTUP, 0, 0, 0, 0);
                        mouseLeftClicked = true;
                    }
                }
                if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button12) == true)
                {
                    if (mouseRightClicked == true)
                    {
                        mouse_event(MOUSEEVENT_RIGHTDOWN, 0, 0, 0, 0);
                        mouseRightClicked = false;
                    }
                }
                if (m_CJoy.IsUp(Ojw.CJoystick.PadKey.Button12) == true)
                {
                    if (mouseRightClicked == false)
                    {
                        mouse_event(MOUSEEVENT_RIGHTUP, 0, 0, 0, 0);
                        mouseRightClicked = true;
                    }
                }
            }
            if (mouseMod == false)
            {
                //clicking
                if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button11) == true)
                {
                    firstStep = 4;
                }
                if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button12) == true)
                {
                    //radiobutton2
                }

                //left side
                if (leftThumbY <= 25 && leftThumbX > 25 && leftThumbX < 75)
                {
                    firstStep = 0;
                }
                else if (leftThumbY >= 75 && leftThumbX > 25 && leftThumbX < 75)
                {
                    firstStep = 2;
                }
                else if (leftThumbX <= 25 && leftThumbY > 25 && leftThumbY < 75)
                {
                    firstStep = 3;
                }
                else if (leftThumbX >= 75 && leftThumbY > 25 && leftThumbY < 75)
                {
                    firstStep = 1;
                }
                else if (leftThumbY <= 25 && leftThumbX >= 75)
                {
                    //backspace
                    SendKeys.Send("{BS}");
                }
                else if (leftThumbY >= 75 && leftThumbX >= 75)
                {
                    //enter
                    SendKeys.Send("{ENTER}");
                }
                else if (leftThumbX <= 25 && leftThumbY >= 75)
                {
                    if (upOrLow == "low")
                    {
                        upOrLow = "up";
                    }
                    else
                    {
                        upOrLow = "low";
                    }
                }
                else if (leftThumbX <= 25 && leftThumbY <= 25)
                {
                    //space
                    SendKeys.Send(" ");
                }
                WriteFirstStepToLbl();

                //right side
                if (rightThumbY <= 25 && rightThumbX > 25 && rightThumbX < 75)
                {
                    secondStep = 0;
                }
                else if (rightThumbY >= 75 && rightThumbX > 25 && rightThumbX < 75)
                {
                    secondStep = 4;
                }
                else if (rightThumbX <= 25 && rightThumbY > 25 && rightThumbY < 75)
                {
                    secondStep = 6;
                }
                else if (rightThumbX >= 75 && rightThumbY > 25 && rightThumbY < 75)
                {
                    secondStep = 2;
                }
                else if (rightThumbY <= 25 && rightThumbX >= 75)
                {
                    secondStep = 1;
                }
                else if (rightThumbY >= 75 && rightThumbX >= 75)
                {
                    secondStep = 3;
                }
                else if (rightThumbX <= 25 && rightThumbY >= 75)
                {
                    secondStep = 5;
                }
                else if (rightThumbX <= 25 && rightThumbY <= 25)
                {
                    secondStep = 7;

                }
                if (secondStep != 9 && firstStep != 5)
                {
                    if (rightThumbX > 30 && rightThumbX < 70 && rightThumbY > 30 && rightThumbY < 70)
                    {

                        if (upOrLow == "low")
                        {
                            SendKeys.Send(keyPad[firstStep, secondStep]);//klavye girdisi gönderiliyor
                            movingPartRight.Text = keyPad[firstStep, secondStep];//seçilen karakter hafızada buton değeri olarak tutuluyor
                        }
                        else
                        {
                            SendKeys.Send(keyPad[firstStep, secondStep].ToUpper());
                            movingPartRight.Text = keyPad[firstStep, secondStep].ToUpper();
                        }

                        secondStep = 9;
                    }
                }
            }
        }
        private void JoystickCheckMouse()
        {
            if (mouseMod == true)
            {
                //100 ile çarp virgülü yok et
                int leftThumbX = (int)(m_CJoy.GetPos0 * 100);
                int leftThumbY = (int)(m_CJoy.GetPos1 * 100);
                int rightThumbX = (int)(m_CJoy.GetPos2 * 100);
                int rightThumbY = (int)(m_CJoy.GetPos3 * 100);
                movingPartLeft.Location = new Point((int)(300 * m_CJoy.GetPos0), (int)(300 * m_CJoy.GetPos1));
                movingPartRight.Location = new Point((int)(300 * m_CJoy.GetPos2), (int)(300 * m_CJoy.GetPos3));
                MouseMoveLeft(leftThumbX - 49, leftThumbY - 49);
                MouseMoveRight(rightThumbX - 50, rightThumbY - 50);
            }
        }

        public void MouseMoveLeft(int posx, int posy)
        {
            Cursor.Position = new Point(Cursor.Position.X + posx, Cursor.Position.Y + posy);
            //Cursor.Clip = new Rectangle(Screen.PrimaryScreen.WorkingArea.Location, Screen.PrimaryScreen.WorkingArea.Size);
        }
        public void MouseMoveRight(int posx, int posy)
        {
            Cursor.Position = new Point(Cursor.Position.X + posx / 7, Cursor.Position.Y + posy / 7);
            //Cursor.Clip = new Rectangle(Screen.PrimaryScreen.WorkingArea.Location, Screen.PrimaryScreen.WorkingArea.Size);
        }

        private void joystickHook_Tick(object sender, EventArgs e)
        {
            JoystickCheckAlive();
        }

        private void buttonTimer_Tick(object sender, EventArgs e)
        {
            JoystickCheckButton();
        }

        private void mouseTimer_Tick(object sender, EventArgs e)
        {
            m_CJoy.Update();
            JoystickCheckMouse();
        }
    }
}
