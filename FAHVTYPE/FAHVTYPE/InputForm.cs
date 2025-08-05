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
    public partial class InputForm : Form
    {

        public string InputText { get; private set; } // Properti untuk menyimpan teks yang diketik

        public InputForm()
        {
            InitializeComponent();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            InputText = txtInputText.Text; // Simpan teks yang diketik
            this.DialogResult = DialogResult.OK; // Tutup form dengan hasil OK
            this.Close();
        }
    }
}
