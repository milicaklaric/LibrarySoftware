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
    public partial class UCObnavljanjeClanarine : UserControl
    {
        BindingList<Clan> clanovi = new BindingList<Clan>();
        KontrolerKI kki;

        public UCObnavljanjeClanarine()
        {
            InitializeComponent();
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            try
            {
                Clan c = (Clan)dgvClanoviIzaberi.SelectedRows[0].DataBoundItem;
                new FrmObnavljanjeClanarine(c).ShowDialog();
                dgvClanoviIzaberi.DataSource = clanovi;
            }
            catch (ArgumentOutOfRangeException)
            {
                new FrmMessage("Izaberite člana koji obnavlja članarinu").ShowDialog();
            }
            
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            dgvClanoviIzaberi.DataSource = clanovi;
            dgvClanoviIzaberi.Columns[0].HeaderText = "Članska karta";
            dgvClanoviIzaberi.Columns[6].HeaderText = "Važi do";
            dgvClanoviIzaberi.Columns[4].HeaderText = "Broj telefona";

            kki = new KontrolerKI();

            clanovi = kki.PretraziClanove(rbClKarta, rbIme, rbPrezime, txtClan, dgvClanoviIzaberi, clanovi);
            
        }
    }
}
