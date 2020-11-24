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
    public partial class UCUnosClana : UserControl
    {
        private KontrolerKI kki;

        List<Kategorija> kategorije = new List<Kategorija>() { Kategorija.Dete, Kategorija.Student, Kategorija.Zaposlen, Kategorija.Penzioner };

        public UCUnosClana()
        {
            InitializeComponent();

            kki = new KontrolerKI();
            
            kki.PopuniCMBUnosClana(cmbMesto,cmbKategorija,btnSacuvaj,kategorije);
            OcistiFormu();
            
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!Validacija())
            {
                return;
            }

            kki.SacuvajClana( txtIme,  txtPrezime,  txtBrTelefona,  cmbMesto,  cmbKategorija,  dtpVaziDo);
            OcistiFormu();
        }

        private bool Validacija()
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                epIme.SetError(txtIme, "Unesite ime");
                return false;
            }

            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                epPrezime.SetError(txtPrezime, "Unesite prezime");
                return false;
            }
            
            if (string.IsNullOrEmpty(txtBrTelefona.Text))
            {
                epBrTelefonas.SetError(txtBrTelefona, "Unesite broj telefona");
                return false;
            }

            if (dtpVaziDo.Value < DateTime.Now)
            {
                epDatum.SetError(dtpVaziDo, "Izaberite datum u budućnosti");
                return false;
            }

            return true;
        }

        public void OcistiFormu()
        {
            try
            {
                txtBrTelefona.Clear();
                txtIme.Clear();
                txtPrezime.Clear();
                cmbKategorija.SelectedIndex = 0;
                cmbMesto.SelectedIndex = 0;
                dtpVaziDo.Value = DateTime.Now.AddYears(1);
            }
            catch (Exception e)
            {
                //new FrmMessage("Prazan combobox."+e.Message).ShowDialog();
            }
        }
        
        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            epIme.Dispose();
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            epPrezime.Dispose();
        }

        private void txtBrTelefona_TextChanged(object sender, EventArgs e)
        {
            epBrTelefonas.Dispose();
        }        

        private void dtpVaziDo_ValueChanged(object sender, EventArgs e)
        {
            epDatum.Dispose();
        }
        
    }
}
