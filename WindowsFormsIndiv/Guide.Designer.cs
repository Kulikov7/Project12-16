namespace WindowsFormsIndiv
{
    partial class FormInformathion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformathion));
            this.label1 = new System.Windows.Forms.Label();
            this.Encoder = new System.Windows.Forms.Label();
            this.Decoder = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация";
            // 
            // Encoder
            // 
            this.Encoder.AutoSize = true;
            this.Encoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encoder.Location = new System.Drawing.Point(33, 49);
            this.Encoder.Name = "Encoder";
            this.Encoder.Size = new System.Drawing.Size(332, 105);
            this.Encoder.TabIndex = 1;
            this.Encoder.Text = resources.GetString("Encoder.Text");
            // 
            // Decoder
            // 
            this.Decoder.AutoSize = true;
            this.Decoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decoder.Location = new System.Drawing.Point(33, 175);
            this.Decoder.Name = "Decoder";
            this.Decoder.Size = new System.Drawing.Size(312, 105);
            this.Decoder.TabIndex = 2;
            this.Decoder.Text = "Дешифратор - комбинационное устройство, \r\nпреобразующее n-разрядный двоичный код " +
    "\r\nв логический сигнал, появляющийся на том выходе, \r\nдесятичный номер которого с" +
    "оответствует \r\nдвоичному коду. \r\n\r\n\r\n";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.SystemColors.Window;
            this.Close.Location = new System.Drawing.Point(137, 298);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(110, 36);
            this.Close.TabIndex = 4;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormInformathion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(377, 346);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Decoder);
            this.Controls.Add(this.Encoder);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInformathion";
            this.Text = "О приложении";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Encoder;
        private System.Windows.Forms.Label Decoder;
        private System.Windows.Forms.Button Close;
    }
}