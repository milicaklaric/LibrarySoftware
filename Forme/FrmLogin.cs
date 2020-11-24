using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FrmLogin : Form
    {
        private KontrolerKI kki = new KontrolerKI();

        public FrmLogin()
        {
            InitializeComponent();
            lblConnect.Hide();
        }
        
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtKorisnickoIme_Click(object sender, EventArgs e)
        {
            if (txtKorisnickoIme.Text == "Username")
                txtKorisnickoIme.Text = "";
        }

        private void txtSifra_Click(object sender, EventArgs e)
        {
            if (txtSifra.Text == "Password")
                txtSifra.Text = "";
        }

        private void txtKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
            epUsername.Dispose();
        }

        private void txtSifra_TextChanged(object sender, EventArgs e)
        {
            epPassword.Dispose();
        }



        private void FrmLogin_Load(object sender, EventArgs e)
        {
            kki.PoveziSeNaServer(btnLogin, lblConnect);
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            kki = new KontrolerKI(this);
            kki.Login(txtKorisnickoIme, txtSifra, epUsername, epPassword, lblConnect);
        }

        private void lblConnect_Click(object sender, EventArgs e)
        {
            kki.PoveziSeNaServer(btnLogin, lblConnect);
        }

        private void lblConnect_MouseHover(object sender, EventArgs e)
        {
            lblConnect.ForeColor = Color.FromArgb(64,0,0);
        }

        private void lblConnect_MouseLeave(object sender, EventArgs e)
        {
            lblConnect.ForeColor = System.Drawing.Color.White;
        }
    }
}
