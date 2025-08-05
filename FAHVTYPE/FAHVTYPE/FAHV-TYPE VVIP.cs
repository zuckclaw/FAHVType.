using FAHVTYPE.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FAHVTYPE
{
    public partial class Form1 : Form
    {
        private bool isTypingTestActive = false;



        int time = 30; //30 seconds
        int time2 = 30; //30 seconds
        int wordCount = 0;
        int errorCount = 0;
        int characterCount = 0;

        bool wasError = false;

        string currentChar;
        string pressedChar;
        string text = "this is a test text that was made to see how fast can you type there is a lot hello car here there are five sticks shirt I really love what is good faded short keyboard walking circling playing computer what should elephant four lightning can drink face shirt pants dad likes me appreciates togetherness above hello car here there are five sticks shirt I really love what is good faded short keyboard walking circling playing computer what should elephant four lightning can drink face shirt pants dad likes me appreciates togetherness above hello car here there are five sticks shirt I really love what is good faded short keyboard walking circling playing computer what should elephant four lightning can drink face shirt pants dad likes me appreciates togetherness above hello car here there are five sticks shirt I really love what is good faded short keyboard walking circling playing computer what should elephant four lightning can drink face shirt pants dad likes me appreciates togetherness above hello car here there are five sticks shirt I really love what is good faded short keyboard walking circling playing computer what should elephant four lightning can drink face shirt pants dad likes me appreciates togetherness above hello car here there are five sticks shirt I really love what is good faded short keyboard walking circling playing computer what should elephant four lightning can drink face shirt pants dad likes me appreciates togetherness above hello car here there are five sticks shirt I really love what is good faded short keyboard walking circling playing computer what should elephant four lightning can drink face shirt pants dad likes me appreciates togetherness above hello car here there are five sticks shirt I really love what is good faded short ke";
        string text2 = "this is a test text that was made to see how fast can you type\nthere is a lot of words that are longer than five characters\nthis was designed and coded very proffesionaly trust me\nthis is a test text that was made to see how fast can you type\nthere is a lot of words that are longer than five characters this\nwas designed and coded very proffesionaly trust me";

        Color BackgroundColor = Color.FromArgb(0, 106, 103);
        Color TextColor = Color.White;
        Color ErrorColor = Color.FromArgb(231, 64, 64);
        Color TypedTextColor = Color.FromArgb(87, 171, 219);
        Color Biru = Color.Black;

        private Dictionary<string, string> translations = new Dictionary<string, string>
        {
            { "ENGLISH", "this is a test text that was made to see how fast can you type there is a lot hello car here there are five sticks shirt I really love what is good faded short keyboard walking circling playing computer what should elephant four lightning can drink face shirt pants dad likes me appreciates togetherness above hello car here there are five sticks shirt I really love what is good faded short keyboard walking circling playing computer what should elephant four lightning can drink face shirt pants dad likes me appreciates togetherness above hello car here there are five sticks shirt I really love what is good faded short keyboard walking circling playing computer what should elephant four lightning can drink face shirt pants dad likes me appreciates togetherness above hello car here there are five sticks shirt I really love what is good faded short keyboard walking circling playing computer what should elephant four lightning can drink face shirt pants dad likes me appreciates togetherness above hello car here there are five sticks shirt I really love what is good faded short keyboard walking circling playing computer what should elephant four lightning can drink face shirt pants dad likes me appreciates togetherness above hello car here there are five sticks shirt I really love what is good faded short keyboard walking circling playing computer what should elephant four lightning can drink face shirt pants dad likes me appreciates togetherness above hello car here there are five sticks shirt I really love what is good faded short keyboard walking circling playing computer what should elephant four lightning can drink face shirt pants dad likes me appreciates togetherness above hello car here there are five sticks shirt I really love what is good faded short ke" },
            { "INDONESIAN", "ini adalah teks tes yang dibuat untuk melihat seberapa cepat kamu bisa mengetik ada banyak halo mobil di sini ada lima tongkat kemeja Saya sangat suka apa yang bagus memudar keyboard pendek berjalan berputar-putar bermain komputer apa yang harus gajah empat petir bisa minum baju muka celana ayah suka saya menghargai kebersamaan di atas halo mobil di sini ada lima tongkat baju saya sangat suka apa yang bagus keyboard pendek memudar berjalan berputar-putar bermain komputer apa yang harus gajah empat petir bisa minum baju muka celana ayah suka saya menghargai kebersamaan di atas halo mobil di sini ada lima tongkat baju saya sangat suka apa yang baik keyboard pendek pudar berjalan berputar-putar bermain komputer apa yang harusnya gajah empat petir bisa minum baju muka celana ayah suka aku menghargai kebersamaan di atas halo mobil di sini ada lima tongkat baju Aku sangat suka apa yang bagus keyboard pendek pudar berjalan berputar-putar bermain komputer apa yang harus gajah empat petir bisa minum baju muka celana ayah menyukaiku menghargai kebersamaan di atas halo mobil di sini ada lima batang baju aku sangat suka apa yang bagus keyboard pendek pudar berjalan berputar-putar bermain komputer apa yang harus gajah empat petir bisa minum baju muka celana ayah suka aku menghargai kebersamaan di atas halo mobil di sini ada lima tongkat baju Aku sangat suka apa yang baik memudar keyboard pendek berjalan berputar-putar bermain komputer apa yang harus gajah empat petir bisa minum baju muka celana ayah menyukaiku menghargai kebersamaan di atas halo mobil di sini ada lima tongkat kemeja Aku sangat suka apa yang baik memudar keyboard pendek berjalan berputar-putar bermain komputer apa yang harus gajah empat petir bisa minum baju muka celana ayah suka aku menghargai kebersamaan di atas halo mobil di sini ada lima tongkat baju aku sangat suka apa yang bagus memudar pendek ke" },
            { "GERMANY", "Dies ist ein Testtext, der erstellt wurde, um zu sehen, wie schnell du tippen kannst. Es gibt viele Hallo-Autos hier, es gibt fünf Stöcke, Hemden. Ich liebe wirklich, was gut ist, verblasste, kurze Tastatur, zu Fuß kreisen, Computer spielen, was sollte Elefant vier Blitze trinken, Gesicht, Hemd, Hose. Papa mag mich, schätzt Zusammengehörigkeit darüber hinaus. Hallo-Auto, hier sind fünf Stöcke, Hemd, ich liebe wirklich, was gut ist, verblasste, kurze Tastatur, zu Fuß kreisen, Computer spielen, was sollte Elefant vier Blitze trinken, Gesicht, Hemd, Hose. Papa mag mich, schätzt Zusammengehörigkeit darüber hinaus. Hallo-Auto, hier sind fünf Stöcke, Hemd, ich liebe wirklich, was gut ist, verblasste, kurze Tastatur, zu Fuß kreisen, Computer spielen, was sollte Elefant vier Blitze trinken, Gesicht, Hemd, Hose. Papa mag mich, schätzt Zusammengehörigkeit darüber hinaus. Hallo-Auto, hier sind fünf Stöcke, Hemd, ich liebe wirklich, was gut ist, verblasste, kurze Tastatur, zu Fuß kreisen, Computer spielen, was sollte Elefant vier Blitze trinken, Gesicht, Hemd, Hose. Papa mag mich, schätzt Zusammengehörigkeit darüber hinaus. Hallo-Auto, hier sind fünf Stöcke, Hemd, ich liebe wirklich, was gut ist, verblasste, kurze Tastatur, zu Fuß kreisen, Computer spielen, was sollte Elefant vier Blitze trinken, Gesicht, Hemd, Hose. Papa mag mich, schätzt Zusammengehörigkeit darüber hinaus. Hallo-Auto, hier sind fünf Stöcke, Hemd, ich liebe wirklich, was gut ist, verblasste, kurze Tastatur, zu Fuß kreisen, Computer spielen, was sollte Elefant vier Blitze trinken, Gesicht, Hemd, Hose. Papa mag mich, schätzt Zusammengehörigkeit darüber hinaus. Hallo-Auto, hier sind fünf Stöcke, Hemd, ich liebe wirklich, was gut ist, verblasste, kurze Tastatur, zu Fuß kreisen, Computer spielen, was sollte Elefant vier Blitze trinken, Gesicht, Hemd, Hose. Papa mag mich, schätzt Zusammengehörigkeit darüber hinaus." },
            { "ITALIAN", "Questo è un testo di prova che è stato creato per vedere quanto velocemente puoi digitare. Ci sono molte macchine ciao qui ci sono cinque bastoni, camicia. Amo davvero ciò che è buono, tastiera sbiadita, corta, camminare circolare, giocare al computer, cosa dovrebbe elefante quattro lampi bere, viso, camicia, pantaloni. Papà mi piace, apprezza l'unione oltre. Ciao macchina, qui ci sono cinque bastoni, camicia, amo davvero ciò che è buono, tastiera sbiadita, corta, camminare circolare, giocare al computer, cosa dovrebbe elefante quattro lampi bere, viso, camicia, pantaloni. Papà mi piace, apprezza l'unione oltre. Ciao macchina, qui ci sono cinque bastoni, camicia, amo davvero ciò che è buono, tastiera sbiadita, corta, camminare circolare, giocare al computer, cosa dovrebbe elefante quattro lampi bere, viso, camicia, pantaloni. Papà mi piace, apprezza l'unione oltre. Ciao macchina, qui ci sono cinque bastoni, camicia, amo davvero ciò che è buono, tastiera sbiadita, corta, camminare circolare, giocare al computer, cosa dovrebbe elefante quattro lampi bere, viso, camicia, pantaloni. Papà mi piace, apprezza l'unione oltre. Ciao macchina, qui ci sono cinque bastoni, camicia, amo davvero ciò che è buono, tastiera sbiadita, corta, camminare circolare, giocare al computer, cosa dovrebbe elefante quattro lampi bere, viso, camicia, pantaloni. Papà mi piace, apprezza l'unione oltre. Ciao macchina, qui ci sono cinque bastoni, camicia, amo davvero ciò che è buono, tastiera sbiadita, corta, camminare circolare, giocare al computer, cosa dovrebbe elefante quattro lampi bere, viso, camicia, pantaloni. Papà mi piace, apprezza l'unione oltre. Ciao macchina, qui ci sono cinque bastoni, camicia, amo davvero ciò che è buono, tastiera sbiadita, corta, camminare circolare, giocare al computer, cosa dovrebbe elefante quattro lampi bere, viso, camicia, pantaloni. Papà mi piace, apprezza l'unione oltre." },
            { "SPANISH", "Este es un texto de prueba que se hizo para ver qué tan rápido puedes escribir. Hay muchos coches hola aquí hay cinco palos, camisa. Realmente me encanta lo que es bueno, teclado descolorido, corto, caminar en círculos, jugar a la computadora, ¿qué debería hacer el elefante cuatro relámpagos beber, cara, camisa, pantalones? Papá me gusta, aprecia la unión por encima. Hola coche, aquí hay cinco palos, camisa, realmente me encanta lo que es bueno, teclado descolorido, corto, caminar en círculos, jugar a la computadora, ¿qué debería hacer el elefante cuatro relámpagos beber, cara, camisa, pantalones? Papá me gusta, aprecia la unión por encima. Hola coche, aquí hay cinco palos, camisa, realmente me encanta lo que es bueno, teclado descolorido, corto, caminar en círculos, jugar a la computadora, ¿qué debería hacer el elefante cuatro relámpagos beber, cara, camisa, pantalones? Papá me gusta, aprecia la unión por encima. Hola coche, aquí hay cinco palos, camisa, realmente me encanta lo que es bueno, teclado descolorido, corto, caminar en círculos, jugar a la computadora, ¿qué debería hacer el elefante cuatro relámpagos beber, cara, camisa, pantalones? Papá me gusta, aprecia la unión por encima. Hola coche, aquí hay cinco palos, camisa, realmente me encanta lo que es bueno, teclado descolorido, corto, caminar en círculos, jugar a la computadora, ¿qué debería hacer el elefante cuatro relámpagos beber, cara, camisa, pantalones? Papá me gusta, aprecia la unión por encima. Hola coche, aquí hay cinco palos, camisa, realmente me encanta lo que es bueno, teclado descolorido, corto, caminar en círculos, jugar a la computadora, ¿qué debería hacer el elefante cuatro relámpagos beber, cara, camisa, pantalones? Papá me gusta, aprecia la unión por encima. Hola coche, aquí hay cinco palos, camisa, realmente me encanta lo que es bueno, teclado descolorido, corto, caminar en círculos, jugar a la computadora, ¿qué debería hacer el elefante cuatro relámpagos beber, cara, camisa, pantalones? Papá me gusta, aprecia la unión por encima." }
        };

        public Form1()
        {
            this.KeyPreview = true;
            InitializeComponent();
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

                label6.Text = wordCount * (60 / time2) + " Raw WPM";
                label4.Text = (wordCount * (60 / time2)) - (int)(0.5 * errorCount) + " WPM"; //Temporary WPM reduction for errors
                //label6.Text = (CountWords(text2) - CountWords(text)) * 2 + " Raw WPM";
                //label4.Text = ((CountWords(text2) - CountWords(text)) * 2) - (errorCount * 0.5) + " WPM"; //Temporary WPM reduction for errors
                if ((wordCount * 2) - (int)(0.5 * errorCount) <= 0)
                {
                    label4.Text = "0 WPM";
                }
                label7.Text = "0 Errors";
                ResetTest();

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
                TextTypedLabel.Font = new Font("Consolas", 18, FontStyle.Regular);
                TextTypedLabel.ForeColor = Color.White;
                UpdateUiFont(characterCount);
                UpdateCurrentCharacterFont(characterCount);
                wasError = false;

            }

            if (currentChar.ToUpper() != pressedChar && wasError == false) //error ygy
            {
                errorCount++;
                label7.Text = errorCount + " Errors";
                UpdateErrorFont(characterCount);
                wasError = true;
            }


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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.ActiveControl = null; //removes the error sound from typing :D
            timer1.Start();
            comboBox1.Visible = false;

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

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void label8_Click(object sender, EventArgs e)
        {
            ResetTest();

        }

        private void ResetTest()
        {
            isTypingTestActive = false; // Pastikan tes tidak aktif setelah reset

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
            comboBox1.Visible = true;

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


            labelUsername.Text = "Login sebagai: " + FormLogin.NamaPenggunaSaatIni;

            string connectionString = @"Data Source=LAPTOP-MB0EJNF3\SQLEXPRESS;Initial Catalog=typing_test;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT type, ExpiredDate FROM Login WHERE username = @username";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", FormLogin.NamaPenggunaSaatIni);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string userType = reader["type"].ToString();
                            object expiredDateObj = reader["ExpiredDate"];

                            if (userType == "VVIP")
                            {
                                if (expiredDateObj == DBNull.Value)
                                {
                                    lblVVIPExpire.Text = "VVIP belum memiliki tanggal kedaluwarsa!";
                                }
                                else if (DateTime.TryParse(expiredDateObj.ToString(), out DateTime expiredDate))
                                {
                                    if (expiredDate < DateTime.Now)
                                    {
                                        lblVVIPExpire.Text = "VVIP telah kedaluwarsa!";
                                    }
                                    else
                                    {
                                        lblVVIPExpire.Text = "VVIP berlaku hingga: " + expiredDate.ToString("dd MMM yyyy");
                                    }
                                }
                            }
                            else
                            {
                                lblVVIPExpire.Text = "Anda bukan VVIP";
                            }
                        }
                        else
                        {
                            lblVVIPExpire.Text = "User tidak ditemukan";
                        }
                    }
                }
            }
            //LoadExpiredDate();

            // Tambahkan opsi waktu ke ComboBox
            comboBox1.Items.Add("15");
            comboBox1.Items.Add("30");
            comboBox1.Items.Add("60");
            comboBox1.Items.Add("900");


            // Set default ke 30 detik
            comboBox1.SelectedItem = "30";

            // Event handler saat nilai ComboBox berubah
            comboBox1.SelectedIndexChanged += comboBoxTime_SelectedIndexChanged;
           


            LoadTheme();

            //menambah bahasa ke ComboBox
            comboBoxLanguage.Items.Add("ENGLISH");
            comboBoxLanguage.Items.Add("INDONESIAN");
            comboBoxLanguage.Items.Add("GERMANY");
            comboBoxLanguage.Items.Add("ITALIAN");
            comboBoxLanguage.Items.Add("SPANISH");
            comboBoxLanguage.Items.Add("MANDARIN");


            //bhs default
            comboBoxLanguage.SelectedIndex = 1;

            //set teks default atuau awalnya
            text = translations["INDONESIAN"];
            TextTypedLabel.Text = text;
        }

        private void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {     
            time = int.Parse(comboBox1.SelectedItem.ToString());
            time2 = time; // Update default waktu
            label3.Text = time.ToString(); // Update tampilan waktu di UI
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

        private void btnChange_Click(object sender, EventArgs e)
        {
            // Dapatkan bahasa yang dipilih dari ComboBox
            string selectedLanguage = comboBoxLanguage.SelectedItem.ToString();

            // Perbarui teks berdasarkan bahasa yang dipilih
            if (translations.ContainsKey(selectedLanguage))
            {
                text = translations[selectedLanguage];
                text2 = translations[selectedLanguage]; 
                TextTypedLabel.Text = text;
                ResetTest();
            }
            else
            {
                MessageBox.Show("Language not supported in your device!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void SetTextButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SetTextButton_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void StartTestButton_Click(object sender, EventArgs e)
        {
            
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
