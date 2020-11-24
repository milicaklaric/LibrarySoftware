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
    public partial class UCPozajmljivanjeKnjige : UserControl
    {
        KontrolerKI kki = new KontrolerKI();
        BindingList<Pozajmljivanje> pozajmljivanja = new BindingList<Pozajmljivanje>();
        Zaposleni prijavljeni = null;
        BindingList<Primerak> list = new BindingList<Primerak>();
        BindingList<Clan> clanovi = new BindingList<Clan>();
        List<Knjiga> knjige = new List<Knjiga>();

        public UCPozajmljivanjeKnjige()
        {
            InitializeComponent();
            prijavljeni = Sesija.Instance.Zaposleni;
            PopuniCMB();
            dgvPozajmljivanja.Hide();
            btnSacuvajSve.Enabled = false;
        }

        public void PopuniCMB()
        {
            kki.PopuniCMBPozKnjige(cmbClanovi, cmbKnjige, cmbPrimerci, clanovi, knjige, btnDodaj, btnSacuvajSve);
        }
        

        private void cmbClanovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            pozajmljivanja = new BindingList<Pozajmljivanje>();
            dgvPozajmljivanja.DataSource = pozajmljivanja;
        }

        private void cmbKnjige_SelectedIndexChanged(object sender, EventArgs e)
        {
            kki.PopuniCMBPrimerci(btnDodaj, cmbKnjige, cmbPrimerci, list, clanovi);
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            dgvPozajmljivanja.Show();
            dgvPozajmljivanja.DataSource = pozajmljivanja;
            dgvPozajmljivanja.Columns[0].HeaderText = "Član";
            dgvPozajmljivanja.Columns[3].HeaderText = "Datum";
            dgvPozajmljivanja.Columns[4].HeaderText = "Rok za vraćanje";
            dgvPozajmljivanja.Columns[5].Visible = false;
            pozajmljivanja = kki.DodajPrimerakZaPozajmljivanje(cmbClanovi, cmbKnjige, cmbPrimerci, prijavljeni, pozajmljivanja);
            if (pozajmljivanja.Count != 0)
                btnSacuvajSve.Enabled = true;
        }

        //ovde ili u KKI?
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                Pozajmljivanje p = dgvPozajmljivanja.CurrentRow.DataBoundItem as Pozajmljivanje;
                pozajmljivanja.Remove(p);
                dgvPozajmljivanja.DataSource = pozajmljivanja;

                if (pozajmljivanja.Count == 0)
                    btnSacuvajSve.Enabled = false;
            }
            catch (Exception)
            {

            }
        }

        private void btnSacuvajSve_Click(object sender, EventArgs e)
        {
            kki.SacuvajPozajmljivanje(cmbClanovi, pozajmljivanja);
            OcistiFormu();
        }

        private void OcistiFormu()
        {
            try
            {
                cmbClanovi.SelectedIndex = 0;
                cmbKnjige.SelectedIndex = 0;
                cmbPrimerci.Sorted = false;
                pozajmljivanja = new BindingList<Pozajmljivanje>();
                dgvPozajmljivanja.DataSource = pozajmljivanja;
            }
            catch (Exception e)
            {
                new FrmMessage("Combo box je prazan").ShowDialog();
                
            }
        }
        
    }
}
