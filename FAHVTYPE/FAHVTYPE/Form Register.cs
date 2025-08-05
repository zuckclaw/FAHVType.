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
    public partial class Form_Register : Form
    {
        typing_testEntities ty = new typing_testEntities();
        Login login = null;

        public Form_Register()
        {
            InitializeComponent();
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
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                    this.Hide();
                    

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

        private void label5_Click(object sender, EventArgs e)
        {
            FormLogin formlogin = new FormLogin();
            formlogin.Show();
            this.Hide();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
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
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
    }
}
