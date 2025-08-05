namespace FAHVTYPE
{
    partial class InputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.txtInputText = new System.Windows.Forms.TextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInputText
            // 
            this.txtInputText.BackColor = System.Drawing.Color.Silver;
            this.txtInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputText.Location = new System.Drawing.Point(42, 88);
            this.txtInputText.Multiline = true;
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.Size = new System.Drawing.Size(869, 408);
            this.txtInputText.TabIndex = 0;
            // 
            // OKbutton
            // 
            this.OKbutton.BackColor = System.Drawing.Color.Lime;
            this.OKbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKbutton.Location = new System.Drawing.Point(42, 523);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(88, 40);
            this.OKbutton.TabIndex = 1;
            this.OKbutton.Text = "Edit";
            this.OKbutton.UseVisualStyleBackColor = false;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Custom Text ~";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(951, 584);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.txtInputText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputText;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Label label1;
    }
}