namespace WindowsFormsIndiv
{
    partial class Application
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            this.Encryption = new System.Windows.Forms.Button();
            this.Support = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveText = new System.Windows.Forms.Button();
            this.LoadText = new System.Windows.Forms.Button();
            this.Key = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Decryption = new System.Windows.Forms.Button();
            this.InfoProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Encryption
            // 
            this.Encryption.BackColor = System.Drawing.SystemColors.Window;
            this.Encryption.Location = new System.Drawing.Point(277, 7);
            this.Encryption.Name = "Encryption";
            this.Encryption.Size = new System.Drawing.Size(176, 43);
            this.Encryption.TabIndex = 5;
            this.Encryption.Text = "Зашифровать";
            this.Encryption.UseVisualStyleBackColor = false;
            this.Encryption.Click += new System.EventHandler(this.button3_Click);
            // 
            // Support
            // 
            this.Support.BackColor = System.Drawing.SystemColors.Window;
            this.Support.Location = new System.Drawing.Point(121, 11);
            this.Support.Name = "Support";
            this.Support.Size = new System.Drawing.Size(95, 35);
            this.Support.TabIndex = 4;
            this.Support.Text = "Справка";
            this.Support.UseVisualStyleBackColor = false;
            this.Support.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.Window;
            this.Exit.Location = new System.Drawing.Point(121, 125);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(90, 27);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(121, 224);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(80, 20);
            this.KeyBox.TabIndex = 2;
            this.KeyBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(492, 61);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 257);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(277, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 257);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // SaveText
            // 
            this.SaveText.BackColor = System.Drawing.SystemColors.Window;
            this.SaveText.Location = new System.Drawing.Point(25, 92);
            this.SaveText.Name = "SaveText";
            this.SaveText.Size = new System.Drawing.Size(90, 27);
            this.SaveText.TabIndex = 6;
            this.SaveText.Text = "Сохранить файл";
            this.SaveText.UseVisualStyleBackColor = false;
            this.SaveText.Click += new System.EventHandler(this.button4_Click);
            // 
            // LoadText
            // 
            this.LoadText.BackColor = System.Drawing.SystemColors.Window;
            this.LoadText.Location = new System.Drawing.Point(121, 92);
            this.LoadText.Name = "LoadText";
            this.LoadText.Size = new System.Drawing.Size(90, 27);
            this.LoadText.TabIndex = 7;
            this.LoadText.Text = "Загрузить файл";
            this.LoadText.UseVisualStyleBackColor = false;
            this.LoadText.Click += new System.EventHandler(this.button5_Click);
            // 
            // Key
            // 
            this.Key.AutoSize = true;
            this.Key.Location = new System.Drawing.Point(12, 224);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(103, 13);
            this.Key.TabIndex = 8;
            this.Key.Text = "Ключ шифрования:";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.Window;
            this.Clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Clear.Location = new System.Drawing.Point(25, 125);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(90, 27);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Очистить все";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Decryption
            // 
            this.Decryption.BackColor = System.Drawing.SystemColors.Window;
            this.Decryption.Location = new System.Drawing.Point(492, 7);
            this.Decryption.Name = "Decryption";
            this.Decryption.Size = new System.Drawing.Size(182, 43);
            this.Decryption.TabIndex = 11;
            this.Decryption.Text = "Расшифровать";
            this.Decryption.UseVisualStyleBackColor = false;
            this.Decryption.Click += new System.EventHandler(this.button7_Click);
            // 
            // InfoProgram
            // 
            this.InfoProgram.BackColor = System.Drawing.SystemColors.Window;
            this.InfoProgram.Location = new System.Drawing.Point(20, 10);
            this.InfoProgram.Name = "InfoProgram";
            this.InfoProgram.Size = new System.Drawing.Size(95, 35);
            this.InfoProgram.TabIndex = 14;
            this.InfoProgram.Text = "О приложении";
            this.InfoProgram.UseVisualStyleBackColor = false;
            this.InfoProgram.Click += new System.EventHandler(this.button9_Click);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(689, 331);
            this.Controls.Add(this.InfoProgram);
            this.Controls.Add(this.Decryption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.LoadText);
            this.Controls.Add(this.SaveText);
            this.Controls.Add(this.Encryption);
            this.Controls.Add(this.Support);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Application";
            this.Text = "Шифр";
            this.Load += new System.EventHandler(this.Application_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encryption;
        private System.Windows.Forms.Button Support;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SaveText;
        private System.Windows.Forms.Button LoadText;
        private System.Windows.Forms.Label Key;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Decryption;
        private System.Windows.Forms.Button InfoProgram;
    }
}

