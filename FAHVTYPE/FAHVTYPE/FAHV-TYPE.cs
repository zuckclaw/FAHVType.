using FAHVTYPE.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAHVTYPE
{
    public partial class FAHV_TYPE : Form
    {
        int time = 30; //30 seconds
        int time2 = 30; //30 seconds
        int wordCount = 0;
        int errorCount = 0;
        int characterCount = 0;

        bool wasError = false;

        string currentChar;
        string pressedChar;
        string text = "this is a test text that was made to see how fast can you type\nthere is a lot of words that are longer than five characters this\nwas designed and coded very proffesionaly trust me\nthis is a test text that was made to see how fast can you type2\nthere is a lot of words that are longer than five characters this\nwas designed and coded very proffesionaly trust me\n";
        string text2 = "this is a test text that was made to see how fast can you type\nthere is a lot of words that are longer than five characters\nthis was designed and coded very proffesionaly trust me\nthis is a test text that was made to see how fast can you type\nthere is a lot of words that are longer than five characters this\nwas designed and coded very proffesionaly trust me";

        Color BackgroundColor = Color.FromArgb(0, 106, 103);
        Color TextColor = Color.White;
        Color ErrorColor = Color.FromArgb(231, 64, 64);
        Color TypedTextColor = Color.FromArgb(87, 171, 219);
        Color Biru = Color.Black;

        public FAHV_TYPE()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void FAHV_TYPE_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {

                time--;

            }


            else
            {
                timer1.Stop();
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                //label6.Text = wordCount * (60 / time2) + " Raw WPM";
                //label4.Text = (wordCount * (60 / time2)) - (int)(0.5 * errorCount) + " WPM"; //Temporary WPM reduction for errors
                label6.Text = (CountWords(text2) - CountWords(text)) * 2 + " Raw WPM";
                label4.Text = ((CountWords(text2) - CountWords(text)) * 2) - (errorCount * 0.5) + " WPM"; //Temporary WPM reduction for errors
                if ((wordCount * 2) - (int)(0.5 * errorCount) <= 0)
                {
                    label4.Text = "0 WPM";
                }
                label7.Text = "0 Errors";
                ResetTest();
            }
            label3.Text = time.ToString();
        }

        private void CheckTyping()
        {

            Console.WriteLine(currentChar);
            if (time == 0 || text.Length == 0)
            {
                return;
            }


            currentChar = text[0].ToString();

            if (currentChar.ToUpper() == pressedChar) //correct 
            {
                characterCount++;
                text = text.Remove(0, 1);
                //TextTypedLabel.Text = text;
                TextTypedLabel.Font = new Font("Consolas", 18, FontStyle.Regular);
                TextTypedLabel.ForeColor = Color.White;
                UpdateUiFont(characterCount);
                UpdateCurrentCharacterFont(characterCount);
                wasError = false;

            }

            if (currentChar.ToUpper() != pressedChar && wasError == false) //error
            {
                errorCount++;
                label7.Text = errorCount + " Errors";
                UpdateErrorFont(characterCount);
                wasError = true;
            }

            //if (pressedChar.ToLower() == "back" && characterCount != 0) //correcting for error
            //{
            //    TextTypedLabel.Font = new Font("Consolas", 16, FontStyle.Regular);
            //    TextTypedLabel.ForeColor = Color.White;
            //    characterCount--;
            //    UpdateUiFont(characterCount);
            //    UpdateCurrentCharacterFont(characterCount);
            //}


            if (currentChar.ToUpper() == " ")
            {
                wordCount++;
            }

            if (currentChar.ToUpper() == "\n")
            {
                text = text.Remove(0, 1);
                characterCount++;
                characterCount++;
                UpdateUiFont(characterCount);
                errorCount--;
                label7.Text = errorCount + " Errors";
            }
        }

        private void FAHV_TYPE_KeyDown(object sender, KeyEventArgs e)
        {
            this.ActiveControl = null; //removes the error sound from typing :D
            timer1.Start();

            label5.Visible = false; //button tekan tombol apapun 
            label8.Visible = true; //restart button


            //VERY TEMPORARY SOLUTION :D
            switch (e.KeyCode)
            {
                case Keys.Space:
                    pressedChar = " ";
                    break;
                case Keys.A:
                    pressedChar = "A";
                    break;
                case Keys.B:
                    pressedChar = "B";
                    break;
                case Keys.C:
                    pressedChar = "C";
                    break;
                case Keys.D:
                    pressedChar = "D";
                    break;
                case Keys.E:
                    pressedChar = "E";
                    break;
                case Keys.F:
                    pressedChar = "F";
                    break;
                case Keys.G:
                    pressedChar = "G";
                    break;
                case Keys.H:
                    pressedChar = "H";
                    break;
                case Keys.I:
                    pressedChar = "I";
                    break;
                case Keys.J:
                    pressedChar = "J";
                    break;
                case Keys.K:
                    pressedChar = "K";
                    break;
                case Keys.L:
                    pressedChar = "L";
                    break;
                case Keys.M:
                    pressedChar = "M";
                    break;
                case Keys.N:
                    pressedChar = "N";
                    break;
                case Keys.O:
                    pressedChar = "O";
                    break;
                case Keys.P:
                    pressedChar = "P";
                    break;
                case Keys.Q:
                    pressedChar = "Q";
                    break;
                case Keys.R:
                    pressedChar = "R";
                    break;
                case Keys.S:
                    pressedChar = "S";
                    break;
                case Keys.T:
                    pressedChar = "T";
                    break;
                case Keys.U:
                    pressedChar = "U";
                    break;
                case Keys.V:
                    pressedChar = "V";
                    break;
                case Keys.W:
                    pressedChar = "W";
                    break;
                case Keys.X:
                    pressedChar = "X";
                    break;
                case Keys.Y:
                    pressedChar = "Y";
                    break;
                case Keys.Z:
                    pressedChar = "Z";
                    break;
                case Keys.Back:
                    pressedChar = "back";
                    break;
            }

            CheckTyping();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ResetTest();
        }

        private void ResetTest()
        {
            timer1.Stop();
            time = time2;
            errorCount = 0;
            wordCount = 0;
            characterCount = 0;
            text = text2;
            time = time2;
            label3.Text = time2.ToString();

            //TextTypedLabel.Text = text2;
            TextTypedLabel.Text = text;
            label5.Visible = true;
            label8.Visible = false; //restart button

        }

        private void UpdateUiFont(int charChount) //correct type
        {
            TextTypedLabel.Select(0, charChount);
            TextTypedLabel.SelectionFont = new Font("Consolas", 18, FontStyle.Italic);
            TextTypedLabel.SelectionColor = TypedTextColor; //blue
            TextTypedLabel.Select(0, 0);
            this.ActiveControl = null;

        }

        private void UpdateErrorFont(int charChount) //error type
        {
            TextTypedLabel.Select(charChount, 1);
            TextTypedLabel.SelectionFont = new Font("Consolas", 18, FontStyle.Underline);
            TextTypedLabel.SelectionColor = ErrorColor; //red
            TextTypedLabel.Select(0, 0);
            this.ActiveControl = null;

        }

        private void UpdateCurrentCharacterFont(int charChount) //current type
        {
            TextTypedLabel.Select(charChount, 1);
            TextTypedLabel.SelectionFont = new Font("Consolas", 18, FontStyle.Underline);
            TextTypedLabel.SelectionColor = Color.White;
            TextTypedLabel.Select(0, 0);
            this.ActiveControl = null;

        }

        static int CountWords(string text)
        {
            return text.Split(new char[] { ' ', '\t', '\n', }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTheme();
            TextTypedLabel.Text = text;
        }

        private void LoadTheme()
        {
            this.BackgroundColor = Settings.Default.BackgroundColor;
            TextColor = Settings.Default.TextColor;
            ErrorColor = Settings.Default.ErrorColor;
            TypedTextColor = Settings.Default.TypedTextColor;

            //Tema Warna
            this.BackColor = BackgroundColor;

            label8.ForeColor = TextColor;
            TextTypedLabel.BackColor = Biru;
            TypingPanel.BackColor = Biru;

        }

        private void setTextbtn_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // Hentikan timer dulu

            InputForm inputForm = new InputForm(); // Buka form input
            if (inputForm.ShowDialog() == DialogResult.OK) // Cek jika user klik "OK"
            {
                text = inputForm.InputText; // Ambil teks dari form input
                TextTypedLabel.Text = text; // Set teks di area latihan
            }
        }
    }
}
