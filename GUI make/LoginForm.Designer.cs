namespace GUI_make
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.exit_button = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.idBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pwBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SignUp = new System.Windows.Forms.Button();
            this.IdFindBtn = new System.Windows.Forms.Button();
            this.pwFindBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_button.BackgroundImage")));
            this.exit_button.ForeColor = System.Drawing.Color.Transparent;
            this.exit_button.Location = new System.Drawing.Point(312, -1);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(23, 23);
            this.exit_button.TabIndex = 8;
            this.exit_button.TabStop = false;
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.SkyBlue;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginButton.Location = new System.Drawing.Point(60, 460);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(108, 35);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(66, 432);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 2);
            this.panel2.TabIndex = 8;
            // 
            // idBox1
            // 
            this.idBox1.BackColor = System.Drawing.Color.White;
            this.idBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox1.Location = new System.Drawing.Point(87, 350);
            this.idBox1.Name = "idBox1";
            this.idBox1.Size = new System.Drawing.Size(197, 19);
            this.idBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(62, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(63, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(66, 367);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 2);
            this.panel3.TabIndex = 8;
            // 
            // pwBox
            // 
            this.pwBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pwBox.BackColor = System.Drawing.Color.White;
            this.pwBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwBox.Location = new System.Drawing.Point(87, 412);
            this.pwBox.Name = "pwBox";
            this.pwBox.Size = new System.Drawing.Size(192, 19);
            this.pwBox.TabIndex = 2;
            this.pwBox.UseSystemPasswordChar = true;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Location = new System.Drawing.Point(64, 346);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(24, 21);
            this.panel5.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Location = new System.Drawing.Point(64, 410);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(24, 21);
            this.panel4.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 296);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Location = new System.Drawing.Point(76, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(180, 180);
            this.panel6.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 579);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.SkyBlue;
            this.SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SignUp.Location = new System.Drawing.Point(174, 460);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(108, 35);
            this.SignUp.TabIndex = 4;
            this.SignUp.Text = "SignUp";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // IdFindBtn
            // 
            this.IdFindBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.IdFindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IdFindBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdFindBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IdFindBtn.Location = new System.Drawing.Point(60, 513);
            this.IdFindBtn.Name = "IdFindBtn";
            this.IdFindBtn.Size = new System.Drawing.Size(108, 35);
            this.IdFindBtn.TabIndex = 5;
            this.IdFindBtn.Text = "ID 찾기";
            this.IdFindBtn.UseVisualStyleBackColor = false;
            this.IdFindBtn.Click += new System.EventHandler(this.IdFindBtn_Click);
            // 
            // pwFindBtn
            // 
            this.pwFindBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.pwFindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pwFindBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwFindBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pwFindBtn.Location = new System.Drawing.Point(174, 513);
            this.pwFindBtn.Name = "pwFindBtn";
            this.pwFindBtn.Size = new System.Drawing.Size(108, 35);
            this.pwFindBtn.TabIndex = 6;
            this.pwFindBtn.Text = "PW 찾기";
            this.pwFindBtn.UseVisualStyleBackColor = false;
            this.pwFindBtn.Click += new System.EventHandler(this.pwFindBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 579);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pwFindBtn);
            this.Controls.Add(this.IdFindBtn);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pwBox);
            this.Controls.Add(this.idBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIND";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox idBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox pwBox;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Button IdFindBtn;
        private System.Windows.Forms.Button pwFindBtn;
    }
}

