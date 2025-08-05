namespace FAHVTYPE
{
    partial class FAHV_TYPE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAHV_TYPE));
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TypingPanel = new System.Windows.Forms.Panel();
            this.TextTypedLabel = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.setTextbtn = new System.Windows.Forms.Button();
            this.TypingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Brown;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1013, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "home x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OldLace;
            this.label8.Location = new System.Drawing.Point(493, 547);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "<Restart>";
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // TypingPanel
            // 
            this.TypingPanel.BackColor = System.Drawing.Color.Black;
            this.TypingPanel.Controls.Add(this.TextTypedLabel);
            this.TypingPanel.Location = new System.Drawing.Point(12, 168);
            this.TypingPanel.Name = "TypingPanel";
            this.TypingPanel.Size = new System.Drawing.Size(1106, 277);
            this.TypingPanel.TabIndex = 19;
            // 
            // TextTypedLabel
            // 
            this.TextTypedLabel.BackColor = System.Drawing.Color.Black;
            this.TextTypedLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTypedLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTypedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TextTypedLabel.HideSelection = false;
            this.TextTypedLabel.Location = new System.Drawing.Point(24, 25);
            this.TextTypedLabel.Name = "TextTypedLabel";
            this.TextTypedLabel.ReadOnly = true;
            this.TextTypedLabel.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextTypedLabel.Size = new System.Drawing.Size(1058, 225);
            this.TextTypedLabel.TabIndex = 0;
            this.TextTypedLabel.TabStop = false;
            this.TextTypedLabel.Text = resources.GetString("TextTypedLabel.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OldLace;
            this.label7.Location = new System.Drawing.Point(12, 547);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 43);
            this.label7.TabIndex = 18;
            this.label7.Text = "0 Errors";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OldLace;
            this.label6.Location = new System.Drawing.Point(12, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 43);
            this.label6.TabIndex = 17;
            this.label6.Text = "0 RAW WPM";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(387, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tekan tombol apapun untuk memulai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OldLace;
            this.label4.Location = new System.Drawing.Point(12, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 43);
            this.label4.TabIndex = 15;
            this.label4.Text = "0 WPM";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OldLace;
            this.label3.Location = new System.Drawing.Point(36, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 51);
            this.label3.TabIndex = 14;
            this.label3.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(183)))));
            this.label1.Location = new System.Drawing.Point(428, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "FAHVType.";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FAHVTYPE.Properties.Resources.FAHV2_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(950, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 150);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // setTextbtn
            // 
            this.setTextbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(103)))));
            this.setTextbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setTextbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.setTextbtn.Location = new System.Drawing.Point(964, 545);
            this.setTextbtn.Name = "setTextbtn";
            this.setTextbtn.Size = new System.Drawing.Size(135, 45);
            this.setTextbtn.TabIndex = 25;
            this.setTextbtn.Text = "INPUT TEKS";
            this.setTextbtn.UseVisualStyleBackColor = false;
            this.setTextbtn.Click += new System.EventHandler(this.setTextbtn_Click);
            // 
            // FAHV_TYPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(103)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1136, 608);
            this.Controls.Add(this.setTextbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TypingPanel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAHV_TYPE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAHVType.";
            this.Load += new System.EventHandler(this.FAHV_TYPE_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FAHV_TYPE_KeyDown);
            this.TypingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel TypingPanel;
        private System.Windows.Forms.RichTextBox TextTypedLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button setTextbtn;
    }
}