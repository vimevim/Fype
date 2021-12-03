namespace Fype
{
    partial class Options
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
        private void InitializeComponent()
        {
            this.runAtStartUp = new MaterialSkin.Controls.MaterialCheckBox();
            this.middleButtonActivator = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FloatingJoystick = new System.Windows.Forms.RadioButton();
            this.SingleJoystick = new System.Windows.Forms.RadioButton();
            this.DoubleJoystick = new System.Windows.Forms.RadioButton();
            this.FixedMarkingMenu = new System.Windows.Forms.RadioButton();
            this.FloatingMarkingMenu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // runAtStartUp
            // 
            this.runAtStartUp.AutoSize = true;
            this.runAtStartUp.Depth = 0;
            this.runAtStartUp.Font = new System.Drawing.Font("Roboto", 10F);
            this.runAtStartUp.Location = new System.Drawing.Point(40, 383);
            this.runAtStartUp.Margin = new System.Windows.Forms.Padding(0);
            this.runAtStartUp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.runAtStartUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.runAtStartUp.Name = "runAtStartUp";
            this.runAtStartUp.Ripple = true;
            this.runAtStartUp.Size = new System.Drawing.Size(143, 30);
            this.runAtStartUp.TabIndex = 1;
            this.runAtStartUp.Text = "Run At Startup";
            this.runAtStartUp.UseVisualStyleBackColor = true;
            this.runAtStartUp.CheckedChanged += new System.EventHandler(this.runAtStartUp_CheckedChanged);
            // 
            // middleButtonActivator
            // 
            this.middleButtonActivator.AutoSize = true;
            this.middleButtonActivator.Depth = 0;
            this.middleButtonActivator.Font = new System.Drawing.Font("Roboto", 10F);
            this.middleButtonActivator.Location = new System.Drawing.Point(40, 339);
            this.middleButtonActivator.Margin = new System.Windows.Forms.Padding(0);
            this.middleButtonActivator.MouseLocation = new System.Drawing.Point(-1, -1);
            this.middleButtonActivator.MouseState = MaterialSkin.MouseState.HOVER;
            this.middleButtonActivator.Name = "middleButtonActivator";
            this.middleButtonActivator.Ripple = true;
            this.middleButtonActivator.Size = new System.Drawing.Size(139, 30);
            this.middleButtonActivator.TabIndex = 2;
            this.middleButtonActivator.Text = "Middle Button";
            this.middleButtonActivator.UseVisualStyleBackColor = true;
            this.middleButtonActivator.CheckedChanged += new System.EventHandler(this.middleButtonActivator_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(36, 277);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(227, 24);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Left Click On System Tray";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(36, 235);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(74, 24);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Opacity";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(36, 192);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(45, 24);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Size";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(36, 9);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(68, 24);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Theme";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fype.Properties.Resources.JoystickOutline_fw;
            this.pictureBox1.Location = new System.Drawing.Point(180, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FloatingJoystick
            // 
            this.FloatingJoystick.AutoSize = true;
            this.FloatingJoystick.Location = new System.Drawing.Point(289, 280);
            this.FloatingJoystick.Name = "FloatingJoystick";
            this.FloatingJoystick.Size = new System.Drawing.Size(133, 21);
            this.FloatingJoystick.TabIndex = 8;
            this.FloatingJoystick.TabStop = true;
            this.FloatingJoystick.Text = "Floating Joystick";
            this.FloatingJoystick.UseVisualStyleBackColor = true;
            this.FloatingJoystick.CheckedChanged += new System.EventHandler(this.FloatingJoystick_CheckedChanged);
            // 
            // SingleJoystick
            // 
            this.SingleJoystick.AutoSize = true;
            this.SingleJoystick.Location = new System.Drawing.Point(289, 317);
            this.SingleJoystick.Name = "SingleJoystick";
            this.SingleJoystick.Size = new System.Drawing.Size(122, 21);
            this.SingleJoystick.TabIndex = 8;
            this.SingleJoystick.TabStop = true;
            this.SingleJoystick.Text = "Single Joystick";
            this.SingleJoystick.UseVisualStyleBackColor = true;
            this.SingleJoystick.CheckedChanged += new System.EventHandler(this.SingleJoystick_CheckedChanged);
            // 
            // DoubleJoystick
            // 
            this.DoubleJoystick.AutoSize = true;
            this.DoubleJoystick.Location = new System.Drawing.Point(289, 348);
            this.DoubleJoystick.Name = "DoubleJoystick";
            this.DoubleJoystick.Size = new System.Drawing.Size(128, 21);
            this.DoubleJoystick.TabIndex = 8;
            this.DoubleJoystick.TabStop = true;
            this.DoubleJoystick.Text = "Double Joystick";
            this.DoubleJoystick.UseVisualStyleBackColor = true;
            this.DoubleJoystick.CheckedChanged += new System.EventHandler(this.DoubleJoystick_CheckedChanged);
            // 
            // FixedMarkingMenu
            // 
            this.FixedMarkingMenu.AutoSize = true;
            this.FixedMarkingMenu.Location = new System.Drawing.Point(289, 410);
            this.FixedMarkingMenu.Name = "FixedMarkingMenu";
            this.FixedMarkingMenu.Size = new System.Drawing.Size(155, 21);
            this.FixedMarkingMenu.TabIndex = 8;
            this.FixedMarkingMenu.TabStop = true;
            this.FixedMarkingMenu.Text = "Fixed Marking Menu";
            this.FixedMarkingMenu.UseVisualStyleBackColor = true;
            this.FixedMarkingMenu.CheckedChanged += new System.EventHandler(this.FixedMarkingMenu_CheckedChanged);
            // 
            // FloatingMarkingMenu
            // 
            this.FloatingMarkingMenu.AutoSize = true;
            this.FloatingMarkingMenu.Location = new System.Drawing.Point(289, 375);
            this.FloatingMarkingMenu.Name = "FloatingMarkingMenu";
            this.FloatingMarkingMenu.Size = new System.Drawing.Size(172, 21);
            this.FloatingMarkingMenu.TabIndex = 8;
            this.FloatingMarkingMenu.TabStop = true;
            this.FloatingMarkingMenu.Text = "Floating Marking Menu";
            this.FloatingMarkingMenu.UseVisualStyleBackColor = true;
            this.FloatingMarkingMenu.CheckedChanged += new System.EventHandler(this.FloatingMarkingMenu_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FloatingMarkingMenu);
            this.Controls.Add(this.FixedMarkingMenu);
            this.Controls.Add(this.DoubleJoystick);
            this.Controls.Add(this.SingleJoystick);
            this.Controls.Add(this.FloatingJoystick);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.middleButtonActivator);
            this.Controls.Add(this.runAtStartUp);
            this.Name = "Options";
            this.Text = "options";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckBox runAtStartUp;
        private MaterialSkin.Controls.MaterialCheckBox middleButtonActivator;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton FloatingJoystick;
        private System.Windows.Forms.RadioButton SingleJoystick;
        private System.Windows.Forms.RadioButton DoubleJoystick;
        private System.Windows.Forms.RadioButton FixedMarkingMenu;
        private System.Windows.Forms.RadioButton FloatingMarkingMenu;
    }
}