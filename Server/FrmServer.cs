using System;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        Server s;
        private Thread nit;

        public FrmServer()
        {
            InitializeComponent();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void S_PrijavljenNov()
        {
            this.Invoke(new Action(() =>
            {
                dgvPrijavljeni.DataSource = null;
                dgvPrijavljeni.DataSource = s.Prijavljeni;
                dgvPrijavljeni.Columns[0].Visible = false;
                dgvPrijavljeni.Columns[3].Visible = false;
                dgvPrijavljeni.Columns[4].Visible = false;
            }));
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            s = new Server();
            s.PrijavljenNov += S_PrijavljenNov;

            if (s.PokreniServer())
            {
                nit = new Thread(s.Osluskuj);
                nit.IsBackground = true;
                nit.Start();
                lblStanje.Text = "Pokrenut";
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
            }
            else
            {
                lblStanje.Text = "Zaustavljen";
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            nit.Interrupt();
            if (s.ZaustaviServer())
            {
                btnPokreni.Enabled = true;
                btnZaustavi.Enabled = false;
                lblStanje.Text = "Zaustavljen";
            }
            dgvPrijavljeni.DataSource = null;
        }
        
    }
}
