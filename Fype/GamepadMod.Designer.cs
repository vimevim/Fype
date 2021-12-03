namespace Fype
{
    partial class GamepadMod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.leftGuide = new System.Windows.Forms.Panel();
            this.movingPartLeft = new Fype.ButtonElipse();
            this.pictureBoxCapsLock = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnter = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackSpace = new System.Windows.Forms.PictureBox();
            this.pictureBoxSpace = new System.Windows.Forms.PictureBox();
            this.leftLbl6 = new System.Windows.Forms.Label();
            this.leftLbl4 = new System.Windows.Forms.Label();
            this.leftLbl2 = new System.Windows.Forms.Label();
            this.leftLbl0 = new System.Windows.Forms.Label();
            this.buttonElipse1 = new Fype.ButtonElipse();
            this.panelGuider = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbJoystick = new System.Windows.Forms.Label();
            this.rightGuide = new System.Windows.Forms.Panel();
            this.movingPartRight = new Fype.ButtonElipse();
            this.rightLbl7 = new System.Windows.Forms.Label();
            this.rightLbl6 = new System.Windows.Forms.Label();
            this.rightLbl5 = new System.Windows.Forms.Label();
            this.rightLbl4 = new System.Windows.Forms.Label();
            this.rightLbl3 = new System.Windows.Forms.Label();
            this.rightLbl2 = new System.Windows.Forms.Label();
            this.rightLbl1 = new System.Windows.Forms.Label();
            this.rightLbl0 = new System.Windows.Forms.Label();
            this.joystickHook = new System.Windows.Forms.Timer(this.components);
            this.buttonTimer = new System.Windows.Forms.Timer(this.components);
            this.mouseTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonElipse11 = new Fype.ButtonElipse();
            this.leftGuide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapsLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpace)).BeginInit();
            this.panelGuider.SuspendLayout();
            this.rightGuide.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftGuide
            // 
            this.leftGuide.BackColor = System.Drawing.Color.Transparent;
            this.leftGuide.BackgroundImage = global::Fype.Properties.Resources.JoystickOutline_fw;
            this.leftGuide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftGuide.Controls.Add(this.movingPartLeft);
            this.leftGuide.Controls.Add(this.pictureBoxCapsLock);
            this.leftGuide.Controls.Add(this.pictureBoxEnter);
            this.leftGuide.Controls.Add(this.pictureBoxBackSpace);
            this.leftGuide.Controls.Add(this.pictureBoxSpace);
            this.leftGuide.Controls.Add(this.leftLbl6);
            this.leftGuide.Controls.Add(this.leftLbl4);
            this.leftGuide.Controls.Add(this.leftLbl2);
            this.leftGuide.Controls.Add(this.leftLbl0);
            this.leftGuide.Controls.Add(this.buttonElipse1);
            this.leftGuide.Enabled = false;
            this.leftGuide.ForeColor = System.Drawing.SystemColors.WindowText;
            this.leftGuide.Location = new System.Drawing.Point(0, 50);
            this.leftGuide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftGuide.Name = "leftGuide";
            this.leftGuide.Size = new System.Drawing.Size(350, 350);
            this.leftGuide.TabIndex = 4;
            // 
            // movingPartLeft
            // 
            this.movingPartLeft.BackColor = System.Drawing.Color.White;
            this.movingPartLeft.Enabled = false;
            this.movingPartLeft.FlatAppearance.BorderSize = 0;
            this.movingPartLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movingPartLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movingPartLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.movingPartLeft.Location = new System.Drawing.Point(150, 150);
            this.movingPartLeft.Name = "movingPartLeft";
            this.movingPartLeft.Size = new System.Drawing.Size(50, 50);
            this.movingPartLeft.TabIndex = 67;
            this.movingPartLeft.Text = "×";
            this.movingPartLeft.UseVisualStyleBackColor = false;
            // 
            // pictureBoxCapsLock
            // 
            this.pictureBoxCapsLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.pictureBoxCapsLock.BackgroundImage = global::Fype.Properties.Resources.caps_lock_white_fw;
            this.pictureBoxCapsLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCapsLock.Enabled = false;
            this.pictureBoxCapsLock.Location = new System.Drawing.Point(81, 221);
            this.pictureBoxCapsLock.Name = "pictureBoxCapsLock";
            this.pictureBoxCapsLock.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxCapsLock.TabIndex = 63;
            this.pictureBoxCapsLock.TabStop = false;
            // 
            // pictureBoxEnter
            // 
            this.pictureBoxEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.pictureBoxEnter.BackgroundImage = global::Fype.Properties.Resources.enter_white_fw;
            this.pictureBoxEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEnter.Enabled = false;
            this.pictureBoxEnter.Location = new System.Drawing.Point(221, 221);
            this.pictureBoxEnter.Name = "pictureBoxEnter";
            this.pictureBoxEnter.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxEnter.TabIndex = 64;
            this.pictureBoxEnter.TabStop = false;
            // 
            // pictureBoxBackSpace
            // 
            this.pictureBoxBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.pictureBoxBackSpace.BackgroundImage = global::Fype.Properties.Resources.backspace_white_fw;
            this.pictureBoxBackSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBackSpace.Enabled = false;
            this.pictureBoxBackSpace.Location = new System.Drawing.Point(221, 81);
            this.pictureBoxBackSpace.Name = "pictureBoxBackSpace";
            this.pictureBoxBackSpace.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxBackSpace.TabIndex = 65;
            this.pictureBoxBackSpace.TabStop = false;
            // 
            // pictureBoxSpace
            // 
            this.pictureBoxSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.pictureBoxSpace.BackgroundImage = global::Fype.Properties.Resources.space_bar_white_fw;
            this.pictureBoxSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSpace.Enabled = false;
            this.pictureBoxSpace.Location = new System.Drawing.Point(81, 81);
            this.pictureBoxSpace.Name = "pictureBoxSpace";
            this.pictureBoxSpace.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxSpace.TabIndex = 66;
            this.pictureBoxSpace.TabStop = false;
            // 
            // leftLbl6
            // 
            this.leftLbl6.AutoSize = true;
            this.leftLbl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.leftLbl6.Enabled = false;
            this.leftLbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.leftLbl6.ForeColor = System.Drawing.Color.White;
            this.leftLbl6.Location = new System.Drawing.Point(51, 151);
            this.leftLbl6.Name = "leftLbl6";
            this.leftLbl6.Size = new System.Drawing.Size(37, 39);
            this.leftLbl6.TabIndex = 59;
            this.leftLbl6.Text = "×";
            // 
            // leftLbl4
            // 
            this.leftLbl4.AutoSize = true;
            this.leftLbl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.leftLbl4.Enabled = false;
            this.leftLbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.leftLbl4.ForeColor = System.Drawing.Color.White;
            this.leftLbl4.Location = new System.Drawing.Point(151, 251);
            this.leftLbl4.Name = "leftLbl4";
            this.leftLbl4.Size = new System.Drawing.Size(37, 39);
            this.leftLbl4.TabIndex = 57;
            this.leftLbl4.Text = "×";
            // 
            // leftLbl2
            // 
            this.leftLbl2.AutoSize = true;
            this.leftLbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.leftLbl2.Enabled = false;
            this.leftLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.leftLbl2.ForeColor = System.Drawing.Color.White;
            this.leftLbl2.Location = new System.Drawing.Point(251, 151);
            this.leftLbl2.Name = "leftLbl2";
            this.leftLbl2.Size = new System.Drawing.Size(37, 39);
            this.leftLbl2.TabIndex = 55;
            this.leftLbl2.Text = "×";
            // 
            // leftLbl0
            // 
            this.leftLbl0.AutoSize = true;
            this.leftLbl0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.leftLbl0.Enabled = false;
            this.leftLbl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.leftLbl0.ForeColor = System.Drawing.Color.White;
            this.leftLbl0.Location = new System.Drawing.Point(151, 51);
            this.leftLbl0.Name = "leftLbl0";
            this.leftLbl0.Size = new System.Drawing.Size(37, 39);
            this.leftLbl0.TabIndex = 54;
            this.leftLbl0.Text = "×";
            // 
            // buttonElipse1
            // 
            this.buttonElipse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.buttonElipse1.Enabled = false;
            this.buttonElipse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElipse1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonElipse1.Location = new System.Drawing.Point(40, 40);
            this.buttonElipse1.Name = "buttonElipse1";
            this.buttonElipse1.Size = new System.Drawing.Size(270, 270);
            this.buttonElipse1.TabIndex = 44;
            this.buttonElipse1.UseVisualStyleBackColor = false;
            // 
            // panelGuider
            // 
            this.panelGuider.BackColor = System.Drawing.Color.Gray;
            this.panelGuider.Controls.Add(this.label1);
            this.panelGuider.Controls.Add(this.lbJoystick);
            this.panelGuider.Enabled = false;
            this.panelGuider.Location = new System.Drawing.Point(0, 0);
            this.panelGuider.Name = "panelGuider";
            this.panelGuider.Size = new System.Drawing.Size(700, 50);
            this.panelGuider.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(367, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 6;
            // 
            // lbJoystick
            // 
            this.lbJoystick.AutoSize = true;
            this.lbJoystick.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbJoystick.Location = new System.Drawing.Point(33, 7);
            this.lbJoystick.Name = "lbJoystick";
            this.lbJoystick.Size = new System.Drawing.Size(0, 32);
            this.lbJoystick.TabIndex = 6;
            // 
            // rightGuide
            // 
            this.rightGuide.BackColor = System.Drawing.Color.Transparent;
            this.rightGuide.BackgroundImage = global::Fype.Properties.Resources.JoystickOutline_fw;
            this.rightGuide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightGuide.Controls.Add(this.movingPartRight);
            this.rightGuide.Controls.Add(this.rightLbl7);
            this.rightGuide.Controls.Add(this.rightLbl6);
            this.rightGuide.Controls.Add(this.rightLbl5);
            this.rightGuide.Controls.Add(this.rightLbl4);
            this.rightGuide.Controls.Add(this.rightLbl3);
            this.rightGuide.Controls.Add(this.rightLbl2);
            this.rightGuide.Controls.Add(this.rightLbl1);
            this.rightGuide.Controls.Add(this.rightLbl0);
            this.rightGuide.Controls.Add(this.buttonElipse11);
            this.rightGuide.Enabled = false;
            this.rightGuide.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rightGuide.Location = new System.Drawing.Point(350, 50);
            this.rightGuide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightGuide.Name = "rightGuide";
            this.rightGuide.Size = new System.Drawing.Size(350, 350);
            this.rightGuide.TabIndex = 4;
            // 
            // movingPartRight
            // 
            this.movingPartRight.BackColor = System.Drawing.Color.White;
            this.movingPartRight.Enabled = false;
            this.movingPartRight.FlatAppearance.BorderSize = 0;
            this.movingPartRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movingPartRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movingPartRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.movingPartRight.Location = new System.Drawing.Point(150, 150);
            this.movingPartRight.Name = "movingPartRight";
            this.movingPartRight.Size = new System.Drawing.Size(50, 50);
            this.movingPartRight.TabIndex = 69;
            this.movingPartRight.Text = "×";
            this.movingPartRight.UseVisualStyleBackColor = false;
            // 
            // rightLbl7
            // 
            this.rightLbl7.AutoSize = true;
            this.rightLbl7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.rightLbl7.Enabled = false;
            this.rightLbl7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightLbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rightLbl7.ForeColor = System.Drawing.Color.White;
            this.rightLbl7.Location = new System.Drawing.Point(81, 81);
            this.rightLbl7.Name = "rightLbl7";
            this.rightLbl7.Size = new System.Drawing.Size(37, 39);
            this.rightLbl7.TabIndex = 68;
            this.rightLbl7.Text = "×";
            // 
            // rightLbl6
            // 
            this.rightLbl6.AutoSize = true;
            this.rightLbl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.rightLbl6.Enabled = false;
            this.rightLbl6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightLbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rightLbl6.ForeColor = System.Drawing.Color.White;
            this.rightLbl6.Location = new System.Drawing.Point(51, 151);
            this.rightLbl6.Name = "rightLbl6";
            this.rightLbl6.Size = new System.Drawing.Size(37, 39);
            this.rightLbl6.TabIndex = 67;
            this.rightLbl6.Text = "×";
            // 
            // rightLbl5
            // 
            this.rightLbl5.AutoSize = true;
            this.rightLbl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.rightLbl5.Enabled = false;
            this.rightLbl5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightLbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rightLbl5.ForeColor = System.Drawing.Color.White;
            this.rightLbl5.Location = new System.Drawing.Point(81, 221);
            this.rightLbl5.Name = "rightLbl5";
            this.rightLbl5.Size = new System.Drawing.Size(37, 39);
            this.rightLbl5.TabIndex = 66;
            this.rightLbl5.Text = "×";
            // 
            // rightLbl4
            // 
            this.rightLbl4.AutoSize = true;
            this.rightLbl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.rightLbl4.Enabled = false;
            this.rightLbl4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightLbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rightLbl4.ForeColor = System.Drawing.Color.White;
            this.rightLbl4.Location = new System.Drawing.Point(151, 251);
            this.rightLbl4.Name = "rightLbl4";
            this.rightLbl4.Size = new System.Drawing.Size(37, 39);
            this.rightLbl4.TabIndex = 65;
            this.rightLbl4.Text = "×";
            // 
            // rightLbl3
            // 
            this.rightLbl3.AutoSize = true;
            this.rightLbl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.rightLbl3.Enabled = false;
            this.rightLbl3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightLbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rightLbl3.ForeColor = System.Drawing.Color.White;
            this.rightLbl3.Location = new System.Drawing.Point(221, 221);
            this.rightLbl3.Name = "rightLbl3";
            this.rightLbl3.Size = new System.Drawing.Size(37, 39);
            this.rightLbl3.TabIndex = 64;
            this.rightLbl3.Text = "×";
            // 
            // rightLbl2
            // 
            this.rightLbl2.AutoSize = true;
            this.rightLbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.rightLbl2.Enabled = false;
            this.rightLbl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rightLbl2.ForeColor = System.Drawing.Color.White;
            this.rightLbl2.Location = new System.Drawing.Point(251, 151);
            this.rightLbl2.Name = "rightLbl2";
            this.rightLbl2.Size = new System.Drawing.Size(37, 39);
            this.rightLbl2.TabIndex = 63;
            this.rightLbl2.Text = "×";
            // 
            // rightLbl1
            // 
            this.rightLbl1.AutoSize = true;
            this.rightLbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.rightLbl1.Enabled = false;
            this.rightLbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rightLbl1.ForeColor = System.Drawing.Color.White;
            this.rightLbl1.Location = new System.Drawing.Point(221, 81);
            this.rightLbl1.Name = "rightLbl1";
            this.rightLbl1.Size = new System.Drawing.Size(37, 39);
            this.rightLbl1.TabIndex = 61;
            this.rightLbl1.Text = "×";
            // 
            // rightLbl0
            // 
            this.rightLbl0.AutoSize = true;
            this.rightLbl0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.rightLbl0.Enabled = false;
            this.rightLbl0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightLbl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rightLbl0.ForeColor = System.Drawing.Color.White;
            this.rightLbl0.Location = new System.Drawing.Point(151, 51);
            this.rightLbl0.Name = "rightLbl0";
            this.rightLbl0.Size = new System.Drawing.Size(37, 39);
            this.rightLbl0.TabIndex = 62;
            this.rightLbl0.Text = "×";
            // 
            // joystickHook
            // 
            this.joystickHook.Tick += new System.EventHandler(this.joystickHook_Tick);
            // 
            // buttonTimer
            // 
            this.buttonTimer.Interval = 120;
            this.buttonTimer.Tick += new System.EventHandler(this.buttonTimer_Tick);
            // 
            // mouseTimer
            // 
            this.mouseTimer.Interval = 10;
            this.mouseTimer.Tick += new System.EventHandler(this.mouseTimer_Tick);
            // 
            // buttonElipse11
            // 
            this.buttonElipse11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.buttonElipse11.Enabled = false;
            this.buttonElipse11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElipse11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonElipse11.Location = new System.Drawing.Point(40, 40);
            this.buttonElipse11.Name = "buttonElipse11";
            this.buttonElipse11.Size = new System.Drawing.Size(270, 270);
            this.buttonElipse11.TabIndex = 44;
            this.buttonElipse11.UseVisualStyleBackColor = false;
            // 
            // GamepadMod
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.panelGuider);
            this.Controls.Add(this.rightGuide);
            this.Controls.Add(this.leftGuide);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GamepadMod";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GamepadMod_Load);
            this.leftGuide.ResumeLayout(false);
            this.leftGuide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapsLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpace)).EndInit();
            this.panelGuider.ResumeLayout(false);
            this.panelGuider.PerformLayout();
            this.rightGuide.ResumeLayout(false);
            this.rightGuide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel leftGuide;
        private System.Windows.Forms.Panel rightGuide;
        private System.Windows.Forms.Label leftLbl0;
        private System.Windows.Forms.Label leftLbl4;
        private System.Windows.Forms.Label leftLbl2;
        private System.Windows.Forms.Label leftLbl6;
        private System.Windows.Forms.Label rightLbl7;
        private System.Windows.Forms.Label rightLbl6;
        private System.Windows.Forms.Label rightLbl5;
        private System.Windows.Forms.Label rightLbl4;
        private System.Windows.Forms.Label rightLbl3;
        private System.Windows.Forms.Label rightLbl2;
        private System.Windows.Forms.Label rightLbl1;
        private System.Windows.Forms.Label rightLbl0;
        private ButtonElipse movingPartRight;
        private ButtonElipse buttonElipse1;
        private System.Windows.Forms.PictureBox pictureBoxCapsLock;
        private System.Windows.Forms.PictureBox pictureBoxEnter;
        private System.Windows.Forms.PictureBox pictureBoxBackSpace;
        private System.Windows.Forms.PictureBox pictureBoxSpace;
        private ButtonElipse movingPartLeft;
        private System.Windows.Forms.Panel panelGuider;
        private System.Windows.Forms.Label lbJoystick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer joystickHook;
        private System.Windows.Forms.Timer buttonTimer;
        private System.Windows.Forms.Timer mouseTimer;
        private ButtonElipse buttonElipse11;
    }
}