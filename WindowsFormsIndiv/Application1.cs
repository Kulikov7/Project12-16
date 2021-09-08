using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsIndiv
{
    public partial class ProgramForm : Form

    {
        public ProgramForm()
        {
            InitializeComponent(); 
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            bool ValidCharFound(string str)//функция проверки наличия символов на кириллице и арабских цифр

            {
                bool valid = true;// возвращаемый результат
                foreach (char c in str) // искать символ c в строке str
                {
                    string bfr = c.ToString();// конвертировать с в строку
                    if (Regex.IsMatch(bfr, @"[001,]"))//если в строке только
                    {
                        valid = true;//то результат=истина
                    }
                    else
                    {
                        valid = false;//иначе ложь
                        break;
                    }
                }
                return valid;
            }
            if (KeyBox.Text != null && KeyBox.Text != "")
            {
                if (ValidCharFound(KeyBox.Text))    //проверка на правильность 
                                                      
                { }
                else
                    MessageBox.Show("Введите ключ шифрования: 001", "Ошибка", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); //кнопка выхода из программы
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)  //Диалоговое окно с загрузкой данных
            {
                Name = openFileDialog1.FileName;
                EncryptionBox.Clear();
                EncryptionBox.Text = File.ReadAllText(Name);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Удаление данных
            MessageBox.Show("Данные были удалены", "Удаление данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            EncryptionBox.Text = "";
            DecryptionBox.Text = "";
            KeyBox.Text = "";
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)  //Диалоговое окно с сохранением данных
            {
                Name = saveFileDialog1.FileName;
                File.WriteAllText(Name, DecryptionBox.Text);
            }
        }

        static string ABC = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789?!()-"; 

        private void button3_Click(object sender, EventArgs e)
        {

            DecryptionBox.Text = ooo(EncryptionBox.Text);
        }
        public string ooo(string inp)
        {
            StringBuilder cipher = new StringBuilder();

            string a = EncryptionBox.Text;          //Шифрование кода
            int b = 1;

            for (int i = 0; i < a.Length; i++)
                for (int e = 0; e < ABC.Length; e++)
                    if (a[i] == ABC[e]) cipher.Append(ABC[(e + b + ABC.Length) % ABC.Length]);
            EncryptionBox.Clear();
            return cipher.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                EncryptionBox.Text = ooo0(DecryptionBox.Text);
            }
             string ooo0(string inp)
            {

                StringBuilder code = new StringBuilder();

                string a = DecryptionBox.Text;
                int b = 1;
                for (int i = 0; i < a.Length; i++)
                    for (int x=0; x < ABC.Length; x++)
                        if (a[i] == ABC[x]) code.Append(ABC[(x - b + ABC.Length) % ABC.Length]);

                DecryptionBox.Clear();
                return code.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        { 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHelp f2 = new FormHelp();        //Возможность нажимать на кнопки с выводом доп.окон
            f2.Show();
        }


        private void button9_Click(object sender, EventArgs e)
        {
            FormInformathion f4 = new FormInformathion();  //Возможность нажимать на кнопки с выводом доп.окон
            f4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}