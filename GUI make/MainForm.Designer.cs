namespace GUI_make
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plus_btn = new System.Windows.Forms.Label();
            this.minus_btn = new System.Windows.Forms.Label();
            this.search_box = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.p_name_text = new System.Windows.Forms.Label();
            this.p_distance_text = new System.Windows.Forms.Label();
            this.p_address_text = new System.Windows.Forms.Label();
            this.now_max = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p_pri_cost = new System.Windows.Forms.Label();
            this.p_10m_cost = new System.Windows.Forms.Label();
            this.open_time = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.close_time = new System.Windows.Forms.Label();
            this.backLabel = new System.Windows.Forms.Label();
            this.previous_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.carNumBox = new System.Windows.Forms.Label();
            this.parked_status = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-7, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // plus_btn
            // 
            this.plus_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.plus_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_btn.ForeColor = System.Drawing.Color.White;
            this.plus_btn.Location = new System.Drawing.Point(297, 274);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(25, 25);
            this.plus_btn.TabIndex = 1;
            this.plus_btn.Text = "+";
            this.plus_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plus_btn.Click += new System.EventHandler(this.plus_btn_Click);
            // 
            // minus_btn
            // 
            this.minus_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.minus_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus_btn.ForeColor = System.Drawing.Color.White;
            this.minus_btn.Location = new System.Drawing.Point(297, 299);
            this.minus_btn.Name = "minus_btn";
            this.minus_btn.Size = new System.Drawing.Size(25, 25);
            this.minus_btn.TabIndex = 2;
            this.minus_btn.Text = "-";
            this.minus_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minus_btn.Click += new System.EventHandler(this.minus_btn_Click);
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(53, 84);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(193, 21);
            this.search_box.TabIndex = 4;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.search_btn.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(246, 84);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(43, 22);
            this.search_btn.TabIndex = 5;
            this.search_btn.Text = "검색";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // p_name_text
            // 
            this.p_name_text.BackColor = System.Drawing.Color.White;
            this.p_name_text.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_name_text.ForeColor = System.Drawing.Color.SteelBlue;
            this.p_name_text.Location = new System.Drawing.Point(16, 489);
            this.p_name_text.Name = "p_name_text";
            this.p_name_text.Size = new System.Drawing.Size(249, 14);
            this.p_name_text.TabIndex = 6;
            this.p_name_text.Text = "주차장";
            this.p_name_text.Click += new System.EventHandler(this.p_name_text_Click);
            // 
            // p_distance_text
            // 
            this.p_distance_text.AutoSize = true;
            this.p_distance_text.BackColor = System.Drawing.Color.White;
            this.p_distance_text.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_distance_text.ForeColor = System.Drawing.Color.SteelBlue;
            this.p_distance_text.Location = new System.Drawing.Point(16, 513);
            this.p_distance_text.Name = "p_distance_text";
            this.p_distance_text.Size = new System.Drawing.Size(33, 15);
            this.p_distance_text.TabIndex = 7;
            this.p_distance_text.Text = "---m";
            // 
            // p_address_text
            // 
            this.p_address_text.AutoSize = true;
            this.p_address_text.BackColor = System.Drawing.Color.White;
            this.p_address_text.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_address_text.ForeColor = System.Drawing.Color.SteelBlue;
            this.p_address_text.Location = new System.Drawing.Point(66, 512);
            this.p_address_text.Name = "p_address_text";
            this.p_address_text.Size = new System.Drawing.Size(31, 15);
            this.p_address_text.TabIndex = 8;
            this.p_address_text.Text = "대구";
            // 
            // now_max
            // 
            this.now_max.AutoSize = true;
            this.now_max.BackColor = System.Drawing.Color.White;
            this.now_max.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.now_max.ForeColor = System.Drawing.Color.SteelBlue;
            this.now_max.Location = new System.Drawing.Point(278, 512);
            this.now_max.Name = "now_max";
            this.now_max.Size = new System.Drawing.Size(40, 15);
            this.now_max.TabIndex = 9;
            this.now_max.Text = "-- / --";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(16, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "기본요금";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(121, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "10분당";
            // 
            // p_pri_cost
            // 
            this.p_pri_cost.AutoSize = true;
            this.p_pri_cost.BackColor = System.Drawing.Color.White;
            this.p_pri_cost.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_pri_cost.ForeColor = System.Drawing.Color.SteelBlue;
            this.p_pri_cost.Location = new System.Drawing.Point(71, 536);
            this.p_pri_cost.Name = "p_pri_cost";
            this.p_pri_cost.Size = new System.Drawing.Size(27, 15);
            this.p_pri_cost.TabIndex = 12;
            this.p_pri_cost.Text = "----";
            // 
            // p_10m_cost
            // 
            this.p_10m_cost.AutoSize = true;
            this.p_10m_cost.BackColor = System.Drawing.Color.White;
            this.p_10m_cost.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_10m_cost.ForeColor = System.Drawing.Color.SteelBlue;
            this.p_10m_cost.Location = new System.Drawing.Point(163, 536);
            this.p_10m_cost.Name = "p_10m_cost";
            this.p_10m_cost.Size = new System.Drawing.Size(22, 15);
            this.p_10m_cost.TabIndex = 13;
            this.p_10m_cost.Text = "---";
            // 
            // open_time
            // 
            this.open_time.AutoSize = true;
            this.open_time.BackColor = System.Drawing.Color.White;
            this.open_time.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.open_time.ForeColor = System.Drawing.Color.SteelBlue;
            this.open_time.Location = new System.Drawing.Point(232, 536);
            this.open_time.Name = "open_time";
            this.open_time.Size = new System.Drawing.Size(30, 15);
            this.open_time.TabIndex = 14;
            this.open_time.Text = "--:--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(270, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "~";
            // 
            // close_time
            // 
            this.close_time.AutoSize = true;
            this.close_time.BackColor = System.Drawing.Color.White;
            this.close_time.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.close_time.ForeColor = System.Drawing.Color.SteelBlue;
            this.close_time.Location = new System.Drawing.Point(286, 536);
            this.close_time.Name = "close_time";
            this.close_time.Size = new System.Drawing.Size(30, 15);
            this.close_time.TabIndex = 14;
            this.close_time.Text = "--:--";
            // 
            // backLabel
            // 
            this.backLabel.BackColor = System.Drawing.Color.White;
            this.backLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.backLabel.Location = new System.Drawing.Point(-7, 466);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(350, 98);
            this.backLabel.TabIndex = 15;
            // 
            // previous_btn
            // 
            this.previous_btn.BackColor = System.Drawing.Color.White;
            this.previous_btn.FlatAppearance.BorderSize = 0;
            this.previous_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous_btn.ForeColor = System.Drawing.Color.SteelBlue;
            this.previous_btn.Location = new System.Drawing.Point(279, 480);
            this.previous_btn.Name = "previous_btn";
            this.previous_btn.Size = new System.Drawing.Size(19, 23);
            this.previous_btn.TabIndex = 16;
            this.previous_btn.Text = "◀";
            this.previous_btn.UseVisualStyleBackColor = false;
            this.previous_btn.Click += new System.EventHandler(this.previous_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.White;
            this.next_btn.FlatAppearance.BorderSize = 0;
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.ForeColor = System.Drawing.Color.SteelBlue;
            this.next_btn.Location = new System.Drawing.Point(300, 480);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(19, 23);
            this.next_btn.TabIndex = 16;
            this.next_btn.Text = "▶";
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(53, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 2);
            this.panel3.TabIndex = 17;
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_button.BackgroundImage")));
            this.exit_button.ForeColor = System.Drawing.Color.Transparent;
            this.exit_button.Location = new System.Drawing.Point(311, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(23, 23);
            this.exit_button.TabIndex = 18;
            this.exit_button.TabStop = false;
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(-7, -17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 98);
            this.label1.TabIndex = 19;
            // 
            // carNumBox
            // 
            this.carNumBox.BackColor = System.Drawing.Color.White;
            this.carNumBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.carNumBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.carNumBox.Location = new System.Drawing.Point(49, 9);
            this.carNumBox.Name = "carNumBox";
            this.carNumBox.Size = new System.Drawing.Size(249, 14);
            this.carNumBox.TabIndex = 20;
            this.carNumBox.Text = "내 자동차 번호 : ";
            this.carNumBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parked_status
            // 
            this.parked_status.BackColor = System.Drawing.Color.White;
            this.parked_status.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.parked_status.ForeColor = System.Drawing.Color.SteelBlue;
            this.parked_status.Location = new System.Drawing.Point(48, 28);
            this.parked_status.Name = "parked_status";
            this.parked_status.Size = new System.Drawing.Size(249, 14);
            this.parked_status.TabIndex = 21;
            this.parked_status.Text = "주차 된 상태가 아닙니다.";
            this.parked_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.parked_status.Click += new System.EventHandler(this.parked_status_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(48, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 14);
            this.label6.TabIndex = 22;
            this.label6.Text = "주차 시간 / 주차 요금";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.parked_status);
            this.Controls.Add(this.carNumBox);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.previous_btn);
            this.Controls.Add(this.close_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.open_time);
            this.Controls.Add(this.p_10m_cost);
            this.Controls.Add(this.p_pri_cost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.now_max);
            this.Controls.Add(this.p_address_text);
            this.Controls.Add(this.p_distance_text);
            this.Controls.Add(this.p_name_text);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.minus_btn);
            this.Controls.Add(this.plus_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label plus_btn;
        private System.Windows.Forms.Label minus_btn;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label p_name_text;
        private System.Windows.Forms.Label p_distance_text;
        private System.Windows.Forms.Label p_address_text;
        private System.Windows.Forms.Label now_max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label p_pri_cost;
        private System.Windows.Forms.Label p_10m_cost;
        private System.Windows.Forms.Label open_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label close_time;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Button previous_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label carNumBox;
        private System.Windows.Forms.Label parked_status;
        private System.Windows.Forms.Label label6;
    }
}