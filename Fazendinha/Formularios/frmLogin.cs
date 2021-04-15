using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fazendinha
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // ABRIR OUTRO FORM
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            gunaGradient2Panel2.Controls.Add(childForm);
            gunaGradient2Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            openChildForm(new Formularios.frmCadastro());
        }
    }
}
