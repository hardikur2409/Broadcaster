namespace Broadcaster
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_kirim = new System.Windows.Forms.Button();
            this.tb_tujuan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_pesan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_connect = new System.Windows.Forms.Button();
            this.bt_disconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_kirim
            // 
            this.bt_kirim.Location = new System.Drawing.Point(389, 198);
            this.bt_kirim.Name = "bt_kirim";
            this.bt_kirim.Size = new System.Drawing.Size(75, 23);
            this.bt_kirim.TabIndex = 0;
            this.bt_kirim.Text = "Kirim";
            this.bt_kirim.UseVisualStyleBackColor = true;
            this.bt_kirim.Click += new System.EventHandler(this.bt_kirim_Click);
            // 
            // tb_tujuan
            // 
            this.tb_tujuan.Location = new System.Drawing.Point(166, 168);
            this.tb_tujuan.Name = "tb_tujuan";
            this.tb_tujuan.Size = new System.Drawing.Size(190, 23);
            this.tb_tujuan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tujuan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_pesan
            // 
            this.tb_pesan.Location = new System.Drawing.Point(166, 227);
            this.tb_pesan.Name = "tb_pesan";
            this.tb_pesan.Size = new System.Drawing.Size(190, 23);
            this.tb_pesan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(87, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pesan";
            // 
            // bt_connect
            // 
            this.bt_connect.Location = new System.Drawing.Point(486, 168);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(75, 23);
            this.bt_connect.TabIndex = 5;
            this.bt_connect.Text = "Connect";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // bt_disconnect
            // 
            this.bt_disconnect.Location = new System.Drawing.Point(486, 227);
            this.bt_disconnect.Name = "bt_disconnect";
            this.bt_disconnect.Size = new System.Drawing.Size(75, 23);
            this.bt_disconnect.TabIndex = 6;
            this.bt_disconnect.Text = "Disconnect";
            this.bt_disconnect.UseVisualStyleBackColor = true;
            this.bt_disconnect.Click += new System.EventHandler(this.bt_disconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_disconnect);
            this.Controls.Add(this.bt_connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_pesan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tujuan);
            this.Controls.Add(this.bt_kirim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_kirim;
        private TextBox tb_tujuan;
        private Label label1;
        private TextBox tb_pesan;
        private Label label2;
        private Button bt_connect;
        private Button bt_disconnect;
    }
}