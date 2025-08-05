using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAHVTYPE
{
    public partial class FormLogin : Form
    {
        typing_testEntities ty = new typing_testEntities();
        Login login = null;

        public static string NamaPenggunaSaatIni;


        public FormLogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
            label2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
            label2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=LAPTOP-MB0EJNF3\SQLEXPRESS;Initial Catalog=typing_test;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Query untuk mendapatkan informasi user
                string query = "SELECT * FROM Login WHERE username = @username AND password = @password AND type = @type";
                NamaPenggunaSaatIni = TBUSERLOGIN.Text.Trim();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", TBUSERLOGIN.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", TBPWLOGIN.Text.Trim());
                    cmd.Parameters.AddWithValue("@type", comboBox2.SelectedItem?.ToString() ?? "");

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            string userType = dt.Rows[0]["type"].ToString();

                            // Cek apakah user adalah VVIP dan apakah sudah expired
                            if (userType == "VVIP")
                            {
                                object expiredDateObj = dt.Rows[0]["ExpiredDate"];
                                if (expiredDateObj == DBNull.Value)
                                {
                                    MessageBox.Show("Akun VVIP Anda belum memiliki tanggal kedaluwarsa! Hubungi admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                else if (DateTime.TryParse(expiredDateObj.ToString(), out DateTime expiredDate))
                                {
                                    if (expiredDate < DateTime.Now)
                                    {
                                        MessageBox.Show("Akun VVIP Anda telah kadaluarsa. Silakan perpanjang!", "Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }


                            }

                            MessageBox.Show($"Login berhasil sebagai {userType}", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (comboBox2.SelectedIndex == 0) // VVIP
                            {
                                Form1 fAHV_TYPE_VVIP = new Form1();
                                fAHV_TYPE_VVIP.Show();
                                

                            }
                            else if (comboBox2.SelectedIndex == 1) // User
                            {
                                FAHV_TYPE fAHV_TYPE_USER = new FAHV_TYPE();
                                fAHV_TYPE_USER.Show();
                            }
                            else if (comboBox2.SelectedIndex == 2) // Admin Page
                            {
                                Admin_Page adminpage = new Admin_Page();
                                adminpage.Show();
                            }
                            else
                            {
                                MessageBox.Show("Tipe akun tidak dikenali.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            this.Hide(); // Menutup form login setelah sukses login
                        }
                        else
                        {
                            string selectedType = comboBox2.SelectedItem?.ToString() ?? "";

                            if (selectedType == "VVIP")
                            {
                                MessageBox.Show("Akun tidak terdaftar, beli VVIP segera!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (selectedType == "USER")
                            {
                                MessageBox.Show("Akun tidak terdaftar, Register terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("Akun tidak terdaftar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TBUSERREGISTER.Text) && !string.IsNullOrWhiteSpace(TBPWREGISTER.Text) && !string.IsNullOrWhiteSpace(CMBROLEREGIS.Text))
            {
                // Pastikan username belum ada di database
                var existingUser = ty.Logins.FirstOrDefault(u => u.username == TBUSERREGISTER.Text);
                if (existingUser != null)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Membuat objek login_user
                    login = new Login()
                    {
                        username = TBUSERREGISTER.Text.Trim(),
                        password = TBPWREGISTER.Text.Trim(),
                        type = CMBROLEREGIS.Text
                    };

                    // Menyimpan data ke database
                    ty.Logins.Add(login);
                    ty.SaveChanges();

                    MessageBox.Show("Success Created Account!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginPanel.Visible = true;

                    // Membersihkan input setelah berhasil
                    TBUSERREGISTER.Clear();
                    TBPWREGISTER.Clear();
                    CMBROLEREGIS.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("You must fill in username, password, and type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Fitur_Page fitur_Page = new Fitur_Page();
            fitur_Page.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            About_Page about_Page = new About_Page();
            about_Page.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form_Register form_Register = new Form_Register();
            form_Register.Show();
            this.Hide();
        }
    }
}
