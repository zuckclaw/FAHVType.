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
    public partial class Admin_Page : Form
    {
        typing_testEntities ty = new typing_testEntities();
        Login login = null;

        public Admin_Page()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TBUSERREGISTERFORVVIP.Text) &&
             !string.IsNullOrWhiteSpace(TBPWREGISTERFORVVIP.Text) &&
             !string.IsNullOrWhiteSpace(CMBROLEREGISFORVVIP.Text))
            {
                // Pastikan username belum ada di database
                var existingUser = ty.Logins.FirstOrDefault(u => u.username == TBUSERREGISTERFORVVIP.Text);
                if (existingUser != null)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tentukan tanggal expired jika user VVIP
                DateTime? expiredDate = null; // NULL untuk non-VVIP
                if (CMBROLEREGISFORVVIP.Text == "VVIP")
                {
                    expiredDate = DateTime.Now.AddMonths(1); // Set 1 bulan dari hari ini
                }

                // Membuat objek login_user
                login = new Login()
                {
                    username = TBUSERREGISTERFORVVIP.Text.Trim(),
                    password = TBPWREGISTERFORVVIP.Text.Trim(),
                    type = CMBROLEREGISFORVVIP.Text,
                    ExpiredDate = expiredDate // Simpan tanggal expired
                };

                // Menyimpan data ke database
                ty.Logins.Add(login);
                ty.SaveChanges();

                MessageBox.Show("Success Created Account!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Membersihkan input setelah berhasil
                TBUSERREGISTERFORVVIP.Clear();
                TBPWREGISTERFORVVIP.Clear();
                CMBROLEREGISFORVVIP.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("You must fill in username, password, and type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Admin_Page_Load(object sender, EventArgs e)
        {

        }

        private void CMBROLEREGISFORVVIP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TBUSERREGISTERFORVVIP_TextChanged(object sender, EventArgs e)
        {

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form_Register formRegister = new Form_Register();
            formRegister.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Fitur_Page fitur_Page = new Fitur_Page();
            fitur_Page.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            EditUsrPass editUsrPass = new EditUsrPass();
            editUsrPass.Show();
            this.Hide();
        }
    }
}
