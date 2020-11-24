using System;
using System.ComponentModel;
using System.Windows.Forms;
using Domen;

namespace Forme
{
    public partial class UCVracanjeKnjige : UserControl
    {
        KontrolerKI kki = new KontrolerKI();
        BindingList<Pozajmljivanje> lista = new BindingList<Pozajmljivanje>();
        BindingList<Clan> clanovi = new BindingList<Clan>();

        public UCVracanjeKnjige()
        {
            InitializeComponent();
            kki.PopuniCMBVratiKnjigu(cmbClanovi, clanovi, btnPretrazi);
        }

        public void PopuniCMB()
        {
            kki.PopuniCMBVratiKnjigu(cmbClanovi, clanovi, btnPretrazi);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            kki.PretraziPozajmljivanja(cmbClanovi, dgvPozajmljivanja, lista);
        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            kki.ObrisiPozajmljivanje(dgvPozajmljivanja, lista);
        }
    }
}
