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
    public partial class UCObrisiClana : UserControl
    {
        BindingList<Clan> clanovi = new BindingList<Clan>();
        KontrolerKI kki = new KontrolerKI();

        public UCObrisiClana()
        {
            InitializeComponent();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            dgvClanoviBrisanje.DataSource = clanovi;
            dgvClanoviBrisanje.Columns[0].HeaderText = "Članska karta";
            dgvClanoviBrisanje.Columns[6].HeaderText = "Važi do";
            dgvClanoviBrisanje.Columns[4].HeaderText = "Broj telefona";

            clanovi = kki.PretraziClanove(rbClKarta, rbIme, rbPrezime, txtClan, dgvClanoviBrisanje, clanovi);          
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            kki.ObrisiClanove(dgvClanoviBrisanje, clanovi);
            
        }
    }
}
