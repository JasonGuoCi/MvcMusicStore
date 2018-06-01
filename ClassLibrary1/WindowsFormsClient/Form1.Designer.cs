namespace WindowsFormsClient
{
    partial class Form1
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
            this.txtStr1 = new System.Windows.Forms.TextBox();
            this.txtStr2 = new System.Windows.Forms.TextBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStr1
            // 
            this.txtStr1.Location = new System.Drawing.Point(74, 60);
            this.txtStr1.Name = "txtStr1";
            this.txtStr1.Size = new System.Drawing.Size(304, 25);
            this.txtStr1.TabIndex = 0;
            // 
            // txtStr2
            // 
            this.txtStr2.Location = new System.Drawing.Point(74, 252);
            this.txtStr2.Name = "txtStr2";
            this.txtStr2.Size = new System.Drawing.Size(304, 25);
            this.txtStr2.TabIndex = 1;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(74, 149);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(304, 23);
            this.btnReverse.TabIndex = 2;
            this.btnReverse.Text = "字符串反转";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 492);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.txtStr2);
            this.Controls.Add(this.txtStr1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStr1;
        private System.Windows.Forms.TextBox txtStr2;
        private System.Windows.Forms.Button btnReverse;
    }
}

