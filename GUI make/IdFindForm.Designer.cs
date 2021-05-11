namespace GUI_make
{
    partial class IdFindForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdFindForm));
            this.button1 = new System.Windows.Forms.Button();
            this.PwFind = new System.Windows.Forms.Button();
            this.ReturnLogin = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.idBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(263, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PwFind
            // 
            this.PwFind.BackColor = System.Drawing.Color.SteelBlue;
            this.PwFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PwFind.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwFind.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PwFind.Location = new System.Drawing.Point(150, 285);
            this.PwFind.Name = "PwFind";
            this.PwFind.Size = new System.Drawing.Size(138, 35);
            this.PwFind.TabIndex = 4;
            this.PwFind.Text = "PW 찾기";
            this.PwFind.UseVisualStyleBackColor = false;
            this.PwFind.Click += new System.EventHandler(this.PwFind_Click);
            // 
            // ReturnLogin
            // 
            this.ReturnLogin.BackColor = System.Drawing.Color.SkyBlue;
            this.ReturnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ReturnLogin.Location = new System.Drawing.Point(21, 285);
            this.ReturnLogin.Name = "ReturnLogin";
            this.ReturnLogin.Size = new System.Drawing.Size(140, 35);
            this.ReturnLogin.TabIndex = 3;
            this.ReturnLogin.Text = "Login 하러가기";
            this.ReturnLogin.UseVisualStyleBackColor = false;
            this.ReturnLogin.Click += new System.EventHandler(this.ReturnLogin_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.Location = new System.Drawing.Point(14, 78);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 49);
            this.textBox2.TabIndex = 64;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "아이디가 기억나지 않을 경우 이메일 주소를 통해 찾을 수 있습니다.";
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_button.BackgroundImage")));
            this.exit_button.Location = new System.Drawing.Point(297, -1);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(23, 23);
            this.exit_button.TabIndex = 5;
            this.exit_button.TabStop = false;
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.SkyBlue;
            this.textBox1.Location = new System.Drawing.Point(14, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 49);
            this.textBox1.TabIndex = 62;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "아이디  찾기";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(20, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "E-mail";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(18, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 2);
            this.panel2.TabIndex = 60;
            // 
            // idBox1
            // 
            this.idBox1.BackColor = System.Drawing.Color.White;
            this.idBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox1.Location = new System.Drawing.Point(19, 167);
            this.idBox1.Name = "idBox1";
            this.idBox1.Size = new System.Drawing.Size(269, 19);
            this.idBox1.TabIndex = 1;
            // 
            // IdFindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PwFind);
            this.Controls.Add(this.ReturnLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.idBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IdFindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IdFindForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PwFind;
        private System.Windows.Forms.Button ReturnLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox idBox1;
    }
}