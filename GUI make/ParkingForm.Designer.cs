namespace GUI_make
{
    partial class ParkingForm
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
            this.parking_ground = new System.Windows.Forms.PictureBox();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.parking_ground)).BeginInit();
            this.SuspendLayout();
            // 
            // parking_ground
            // 
            this.parking_ground.BackColor = System.Drawing.Color.ForestGreen;
            this.parking_ground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parking_ground.Location = new System.Drawing.Point(0, 0);
            this.parking_ground.Name = "parking_ground";
            this.parking_ground.Size = new System.Drawing.Size(320, 290);
            this.parking_ground.TabIndex = 0;
            this.parking_ground.TabStop = false;
            this.parking_ground.Paint += new System.Windows.Forms.PaintEventHandler(this.Parking_Ground_Paint);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // ParkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(320, 290);
            this.Controls.Add(this.parking_ground);
            this.Name = "ParkingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParkingForm";
            ((System.ComponentModel.ISupportInitialize)(this.parking_ground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox parking_ground;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
    }
}