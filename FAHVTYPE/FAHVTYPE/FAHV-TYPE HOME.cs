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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //FormLogin formLogin = new FormLogin();
            //formLogin.Show();
            //this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form_Register form_Register = new Form_Register();
            form_Register.Show();
            this.Hide();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormLogin formLogin2 = new FormLogin();
            formLogin2.Show();
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

        private void label5_Click(object sender, EventArgs e)
        {
            Contact_Page contact_Page = new Contact_Page();
            contact_Page.Show();
            this.Hide();
        }
    }
}
