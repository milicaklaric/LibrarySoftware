using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;

namespace Forme
{
    public partial class UCUnosKnjige : UserControl
    {
        List<Zanr> zanrovi = new List<Zanr>() { Zanr.Drama, Zanr.Horor, Zanr.Istorijski, Zanr.Klasika, Zanr.Romansa, Zanr.Triler, Zanr.Naučna_fantastika, Zanr.Fantazija};
        Knjiga knjiga;
        List<Izdavac> izdavaci = new List<Izdavac>();
        List<Autor> autori = new List<Autor>();
        KontrolerKI kki = new KontrolerKI();

        public UCUnosKnjige()
        {
            InitializeComponent();
            kki.PopuniCMBUnosKnjige(cmbZanr, cmbIzdavac, cmbAutor, zanrovi, izdavaci, autori, btnSacuvaj);
            OcistiFormu();
        }

        private void UCUnosKnjige_Load(object sender, EventArgs e)
        {
            knjiga = new Knjiga();
        }
        
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            dgvPrimerci.DataSource = knjiga.Primerci;
            dgvPrimerci.Columns["primerakID"].ReadOnly = true;
            dgvPrimerci.Columns[0].HeaderText = "ID";
            dgvPrimerci.Columns[1].HeaderText = "Dostupan";
            dgvPrimerci.Columns[2].Visible = false;

            knjiga = kki.DodajPrimerakKnjige(knjiga);

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!Validacija())
            {
                return;
            }
            kki.SacuvajKnjigu(knjiga, txtISBN, txtNaziv, txtGodIzanja, txtBrStrana, txtPovez, cmbZanr, cmbIzdavac, cmbAutor);
            OcistiFormu();
        }

        private void OcistiFormu()
        {
            try
            {
                knjiga = new Knjiga();
                txtISBN.Clear();
                txtNaziv.Clear();
                txtPovez.Clear();
                txtBrStrana.Clear();
                txtGodIzanja.Clear();
                cmbIzdavac.SelectedIndex = 0;
                cmbZanr.SelectedIndex = 0;
                cmbAutor.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                //new FrmMessage("Prazan combobox." + e.Message).ShowDialog();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            
                try
                {
                    Primerak p = dgvPrimerci.CurrentRow.DataBoundItem as Primerak;
                    knjiga.Primerci.Remove(p);
                }
                catch (Exception)
                {

                }
            
            
        }


        private bool Validacija()
        {
            if (string.IsNullOrEmpty(txtISBN.Text))
            {
                epISBN.SetError(txtISBN, "Unesite ISBN");
                return false;
            }
            else
            {
                try
                {
                    long.Parse(txtISBN.Text);
                }
                catch (Exception)
                {
                    epISBN.SetError(txtISBN, "Unesite ISBN u ispravnom obliku");
                    return false;
                }
            }

            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                epNaziv.SetError(txtNaziv, "Unesite naziv knjige");
                return false;
            }

            if (string.IsNullOrEmpty(txtPovez.Text))
            {
                epNaziv.SetError(txtPovez, "Unesite tip poveza");
                return false;
            }

            if (string.IsNullOrEmpty(txtBrStrana.Text))
            {
                epBrStr.SetError(txtBrStrana, "Unesite broj strana knjige");
                return false;
            }
            else
            {
                try
                {
                    int.Parse(txtBrStrana.Text);
                }
                catch (Exception)
                {
                    epISBN.SetError(txtISBN, "Unesite broj strana u ispravnom obliku");
                    return false;
                }
            }

            if (string.IsNullOrEmpty(txtGodIzanja.Text))
            {
                epGodIzdanja.SetError(txtGodIzanja, "Unesite godinu izdavanja");
                return false;
            }
            else
            {
                try
                {
                    int.Parse(txtGodIzanja.Text);
                }
                catch (Exception)
                {
                    epISBN.SetError(txtISBN, "Unesite godinu izdavanja u ispravnom obliku");
                    return false;
                }
            }

            if (knjiga.Primerci.Count == 0)
            {
                new FrmMessage("Morate uneti primerke").Show();
                return false;
            }

            return true;
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            epISBN.Dispose();
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            epNaziv.Dispose();
        }

        private void txtBrStrana_TextChanged(object sender, EventArgs e)
        {
            epBrStr.Dispose();
        }

        private void txtGodIzanja_TextChanged(object sender, EventArgs e)
        {
            epGodIzdanja.Dispose();
        }

        private void txtPovez_TextChanged(object sender, EventArgs e)
        {
            epPovez.Dispose();
        }
    }
}
