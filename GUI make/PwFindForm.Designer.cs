namespace GUI_make
{
    partial class PwFindForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PwFindForm));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.HintTypeBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ReturnLogin = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(17, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Answer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(18, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "Password Hint";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(18, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "User ID";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Location = new System.Drawing.Point(17, 179);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 2);
            this.panel5.TabIndex = 48;
            // 
            // IdBox
            // 
            this.IdBox.BackColor = System.Drawing.Color.White;
            this.IdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdBox.Location = new System.Drawing.Point(18, 162);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(270, 14);
            this.IdBox.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Location = new System.Drawing.Point(17, 279);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 2);
            this.panel6.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(17, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 2);
            this.panel3.TabIndex = 45;
            // 
            // AnswerBox
            // 
            this.AnswerBox.BackColor = System.Drawing.Color.White;
            this.AnswerBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnswerBox.Location = new System.Drawing.Point(17, 261);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(270, 14);
            this.AnswerBox.TabIndex = 3;
            // 
            // HintTypeBox
            // 
            this.HintTypeBox.BackColor = System.Drawing.Color.White;
            this.HintTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HintTypeBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HintTypeBox.FormattingEnabled = true;
            this.HintTypeBox.Items.AddRange(new object[] {
            "어릴적 별명은 무엇입니까?",
            "태어난 고향은 어디입니까?",
            "출신초등학교 이름은 무엇입니까?",
            "좋아하는 색깔은 무엇입니까?",
            "가장 좋아하는 영화는 무엇입니까?"});
            this.HintTypeBox.Location = new System.Drawing.Point(17, 205);
            this.HintTypeBox.Name = "HintTypeBox";
            this.HintTypeBox.Size = new System.Drawing.Size(270, 27);
            this.HintTypeBox.TabIndex = 2;
            this.HintTypeBox.Text = "질문을  선택해 주십시오.";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(11, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 49);
            this.textBox1.TabIndex = 66;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "비밀번호가 기억나지 않는 경우 아이디와 비밀번호 힌트를 통해 찾을 수 있습니다.";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.SkyBlue;
            this.textBox3.Location = new System.Drawing.Point(10, 22);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 49);
            this.textBox3.TabIndex = 65;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "비밀번호  찾기";
            // 
            // ReturnLogin
            // 
            this.ReturnLogin.BackColor = System.Drawing.Color.SkyBlue;
            this.ReturnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ReturnLogin.Location = new System.Drawing.Point(83, 326);
            this.ReturnLogin.Name = "ReturnLogin";
            this.ReturnLogin.Size = new System.Drawing.Size(140, 35);
            this.ReturnLogin.TabIndex = 5;
            this.ReturnLogin.Text = "Login 하러가기";
            this.ReturnLogin.UseVisualStyleBackColor = false;
            this.ReturnLogin.Click += new System.EventHandler(this.ReturnLogin_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBtn.BackgroundImage")));
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(262, 253);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(25, 25);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // PwFindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(303, 401);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ReturnLogin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.HintTypeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PwFindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PwFindForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.ComboBox HintTypeBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button ReturnLogin;
        private System.Windows.Forms.Button SearchBtn;
    }
}