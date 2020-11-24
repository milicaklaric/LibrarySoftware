using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;

namespace Forme
{
    public partial class FrmGlavna : Form
    {
        public Zaposleni prijavljeni;
        KontrolerKI kki;
        
        public FrmGlavna()
        {
            InitializeComponent();
            pSide.Hide();
            this.prijavljeni = Sesija.Instance.Zaposleni;
            lblZaposleni.Text = prijavljeni.ToString();
            pBorder.BackColor = Color.FromArgb(27,27,30);
            ucUnosClana1.Hide();
            ucObnavljanjeClanarine1.Hide();
            ucObrisiClana1.Hide();
            ucUnosKnjige1.Hide();
            ucBrisanjeKnjige1.Hide();
            ucPozajmljivanjeKnjige1.Hide();
            ucVracanjeKnjige1.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUnosClana_Click(object sender, EventArgs e)
        {
            pSide.Show();
            pSide.Height = btnUnosClana.Height;
            pSide.Top = btnUnosClana.Top;
            lblOdabran.Text = "Unos novog člana";
            pBorder.BackColor = Color.FromArgb(255,255,255);
            ucUnosClana1.Show();
            ucUnosClana1.BringToFront();
        }

        private void btnObnovaClanarine_Click(object sender, EventArgs e)
        {
            pSide.Show();
            pSide.Height = btnObnovaClanarine.Height;
            pSide.Top = btnObnovaClanarine.Top;
            lblOdabran.Text = "Obnova članarine";
            pBorder.BackColor = Color.FromArgb(255, 255, 255);
            ucObnavljanjeClanarine1.Show();
            ucObnavljanjeClanarine1.BringToFront();
        }

        private void btnBrisanjeClana_Click(object sender, EventArgs e)
        {
            pSide.Show();
            pSide.Height = btnBrisanjeClana.Height;
            pSide.Top = btnBrisanjeClana.Top;
            lblOdabran.Text = "Brisanje člana";
            pBorder.BackColor = Color.FromArgb(255, 255, 255);
            ucObrisiClana1.Show();
            ucObrisiClana1.BringToFront();
        }

        private void btnUnosKnjige_Click(object sender, EventArgs e)
        {
            pSide.Show();
            pSide.Height = btnUnosKnjige.Height;
            pSide.Top = btnUnosKnjige.Top;
            lblOdabran.Text = "Unos knjige";
            pBorder.BackColor = Color.FromArgb(255, 255, 255);
            ucUnosKnjige1.Show();
            ucUnosKnjige1.BringToFront();
        }

        private void btnBrisanjeKnjige_Click(object sender, EventArgs e)
        {
            pSide.Show();
            pSide.Height = btnBrisanjeKnjige.Height;
            pSide.Top = btnBrisanjeKnjige.Top;
            lblOdabran.Text = "Brisanje knjige";
            pBorder.BackColor = Color.FromArgb(255, 255, 255);
            ucBrisanjeKnjige1.Show();
            ucBrisanjeKnjige1.BringToFront();
        }

        private void btnPozajmljivanjeKnjige_Click(object sender, EventArgs e)
        {
            pSide.Show();
            pSide.Height = btnPozajmljivanjeKnjige.Height;
            pSide.Top = btnPozajmljivanjeKnjige.Top;
            lblOdabran.Text = "Pozajmljivanje knjige";
            pBorder.BackColor = Color.FromArgb(255, 255, 255);
            ucPozajmljivanjeKnjige1.PopuniCMB();
            ucPozajmljivanjeKnjige1.Show();
            ucPozajmljivanjeKnjige1.BringToFront();
        }

        private void btnVracanjeKnjige_Click(object sender, EventArgs e)
        {
            pSide.Show();
            pSide.Height = btnVracanjeKnjige.Height;
            pSide.Top = btnVracanjeKnjige.Top;
            lblOdabran.Text = "Vraćanje knjige";
            pBorder.BackColor = Color.FromArgb(255, 255, 255);
            ucVracanjeKnjige1.PopuniCMB();
            ucVracanjeKnjige1.Show();
            ucVracanjeKnjige1.BringToFront(); 
        }
        
    }
}
