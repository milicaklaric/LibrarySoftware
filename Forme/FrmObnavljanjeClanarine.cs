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
    public partial class FrmObnavljanjeClanarine : Form
    {
        KontrolerKI kki;


        Clan clan;
        public FrmObnavljanjeClanarine()
        {
            InitializeComponent();
        }

        public FrmObnavljanjeClanarine(Clan c)
        {
            InitializeComponent();
            clan = c;
            txtBrClKarte.Text = clan.BrClanskeKarte.ToString();
            txtImePrezime.Text = clan.ToString();
            dtpVaziDo.Value = DateTime.Now.AddYears(1);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            kki = new KontrolerKI(this);
            kki.ObnavljanjeClanarine(clan, dtpVaziDo);
            
        }
    }
}
