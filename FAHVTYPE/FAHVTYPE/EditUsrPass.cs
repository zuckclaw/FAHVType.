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
    public partial class EditUsrPass : Form
    {
        typing_testEntities db = new typing_testEntities();
        Login table = null;
            
        public EditUsrPass()
        {
            InitializeComponent();
            generateUSR();
        }

        private void generateUSR()
        {
            loginBindingSource.ResumeBinding();
            loginBindingSource.ResetBindings(false);
            loginBindingSource.DataSource = db.Logins.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BTADD.Enabled = false;
            BTEDIT.Enabled = false;
            BTDELETE.Enabled = false;
            BTSAVE.Enabled = true;
            BTCANCEL.Enabled = true;

            table = (Login)loginBindingSource.Current;
            loginBindingSource.SuspendBinding();
            usernameTextBox.Text = table.username;
            passwordTextBox.Text = table.password;
            typeTextBox.Text = table.type;
            //expiredDateDateTimePicker.Value = table.ExpiredDate.GetValueOrDefault();
        }


        private void BTDELETE_Click(object sender, EventArgs e)
        {
            if (loginBindingSource.Current != null)
            {
                table = (Login)loginBindingSource.Current;
                db.Logins.Remove(table);
                db.SaveChanges();
                generateUSR();
            }
            else
            {
                MessageBox.Show("No data to delete. The table is empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BTADD_Click(object sender, EventArgs e)
        {
            expiredDateDateTimePicker.Enabled = false;

            BTADD.Enabled = false;
            BTEDIT.Enabled = false;
            BTDELETE.Enabled = false;
            BTSAVE.Enabled = true;

            if (typeTextBox.Text == "ADMIN" || typeTextBox.Text == "VVIP" || typeTextBox.Text == "USER")
            {
                loginBindingSource.SuspendBinding();
                table = null;
            }
            else
            {
                MessageBox.Show("Isi Type dengan ADMIN / VVIP / USER", "Invalid Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Resetting the BTADD to be enabled again
                BTADD.Enabled = true;
                BTEDIT.Enabled = true;
                BTDELETE.Enabled = true;
                BTSAVE.Enabled = false;
            }
        }

        private void BTSAVE_Click(object sender, EventArgs e)
        {
            if (typeTextBox.Text == "ADMIN" || typeTextBox.Text == "VVIP" || typeTextBox.Text == "USER")
            {
                BTADD.Enabled = true;
                BTEDIT.Enabled = true;
                BTDELETE.Enabled = true;
                BTSAVE.Enabled = false;

                DateTime? expiredDate = null;
                if (typeTextBox.Text == "VVIP")
                {
                    expiredDate = expiredDateDateTimePicker.Value;
                }

                if (table == null)
                {
                    Login s = new Login()
                    {
                        username = usernameTextBox.Text,
                        password = passwordTextBox.Text,
                        type = typeTextBox.Text,
                        ExpiredDate = expiredDate,
                    };

                    db.Logins.Add(s);
                }
                else
                {
                    Login s = db.Logins.Find(table.id);
                    s.username = usernameTextBox.Text;
                    s.password = passwordTextBox.Text;
                    s.type = typeTextBox.Text;
                    s.ExpiredDate = expiredDate;
                }

                db.SaveChanges();
                generateUSR();
            }
            else
            {
                MessageBox.Show("Isi Type dengan ADMIN / VVIP / USER", "Invalid Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTCANCEL_Click(object sender, EventArgs e)
        {
            BTADD.Enabled = true;
            BTEDIT.Enabled = true;
            BTDELETE.Enabled = true;

            BTSAVE.Enabled = false;
            BTCANCEL.Enabled = false;

            loginBindingSource.ResumeBinding();

        }

        private void EditUsrPass_Load(object sender, EventArgs e)
        {
            expiredDateDateTimePicker.Checked = false; // Tidak ada tanggal yang dipilih

        }

        private void expiredDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void BTSHOW_Click(object sender, EventArgs e)
        {
            BTCANCEL.Enabled = true;
            expiredDateDateTimePicker.Enabled = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Fitur_Page fitur_Page = new Fitur_Page();
            fitur_Page.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }
    }
}
