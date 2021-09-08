namespace WindowsFormsIndiv
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.FormH = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormH
            // 
            this.FormH.AutoSize = true;
            this.FormH.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FormH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormH.Location = new System.Drawing.Point(12, 31);
            this.FormH.Name = "FormH";
            this.FormH.Size = new System.Drawing.Size(410, 288);
            this.FormH.TabIndex = 0;
            this.FormH.Text = resources.GetString("FormH.Text");
            this.FormH.Click += new System.EventHandler(this.label1_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.SystemColors.Window;
            this.Close.Location = new System.Drawing.Point(140, 343);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(110, 36);
            this.Close.TabIndex = 1;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(421, 408);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.FormH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHelp";
            this.Text = "Справка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormH;
        private System.Windows.Forms.Button Close;
    }
}