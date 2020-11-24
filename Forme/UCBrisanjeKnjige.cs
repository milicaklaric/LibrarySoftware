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
    public partial class UCBrisanjeKnjige : UserControl
    {
        BindingList<Knjiga> knjige = new BindingList<Knjiga>();
        KontrolerKI kki = new KontrolerKI();

        public UCBrisanjeKnjige()
        {
            InitializeComponent();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            dgvKnjigaObrisi.DataSource = knjige;
            dgvKnjigaObrisi.Columns[1].Visible = false;
            dgvKnjigaObrisi.Columns[3].Visible = false;
            dgvKnjigaObrisi.Columns[4].Visible = false;
            dgvKnjigaObrisi.Columns[5].Visible = false;
            dgvKnjigaObrisi.Columns[6].HeaderText = "Izdavač";

            kki.PretraziKnjige(rbISBN, rbNaziv, rbAutor, txtKnjiga, dgvKnjigaObrisi, knjige);            
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            kki.ObrisiKnjigu(dgvKnjigaObrisi,knjige);
        }
    }
}
