using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Forme
{
    internal class KontrolerKI
    {
        Form frm;
        
        //Konstruktori
        public KontrolerKI()
        {

        }
        public KontrolerKI(Form form)
        {
            frm = form;
        }
        internal void PoveziSeNaServer(Button btnLogin, Label lblConnect)
        {
            if (!Komunikacija.Instance.PoveziSe())
            {
                btnLogin.Enabled = false; 
                lblConnect.Show();
            }
            else
            {
                btnLogin.Enabled = true;
                lblConnect.Hide();
            }
        }

        internal void PopuniCMBVratiKnjigu(ComboBox cmbClanovi, BindingList<Clan> clanovi, Button btnPretrazi)
        {
            try
            {
                clanovi = (BindingList<Clan>)PosaljiOperaciju(Operacija.VratiClanove, new Clan());
                cmbClanovi.DataSource = clanovi;

                if (clanovi.Count == 0)
                {
                    btnPretrazi.Enabled = false;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(">>>UCVratiKnjigu: Greska pri punjenju cmbCanovi" + e.Message);
                //new FrmMessage("UCVratiKnjigu: Greska pri punjenju cmbCanovi" + e.Message).ShowDialog();
            }
        }

        internal void PopuniCMBUnosKnjige(ComboBox cmbZanr, ComboBox cmbIzdavac, ComboBox cmbAutor, List<Zanr> zanrovi, List<Izdavac> izdavaci, List<Autor> autori, Button btnSacuvaj)
        {
            try
            {
                cmbZanr.DataSource = zanrovi;
                cmbZanr.DisplayMember = zanrovi.ToString();

                izdavaci = (List<Izdavac>)PosaljiOperaciju(Operacija.VratiSveIzdavace, new Izdavac());
                cmbIzdavac.DataSource = izdavaci;
                cmbIzdavac.DisplayMember = "NazivIzdavaca";

                autori = (List<Autor>)PosaljiOperaciju(Operacija.VratiSveAutore, new Autor());
                cmbAutor.DataSource = autori;


                if (izdavaci.Count == 0 || autori.Count == 0)
                {
                    btnSacuvaj.Enabled = false;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(">>>UCUnosKnjige: Greska pri punjenju cmbIzdavaci i cmbAutori" + e.Message);
                //new FrmMessage("UCUnosKnjige: Greska pri punjenju cmbIzdavaci i cmbAutori" + e.Message).ShowDialog();
            }
            
        }

        internal void PopuniCMBPrimerci(Button btnDodaj, ComboBox cmbKnjige, ComboBox cmbPrimerci, BindingList<Primerak> list, BindingList<Clan> clanovi)
        {
            try
            {
                btnDodaj.Enabled = true;
                cmbPrimerci.Sorted = false;
                Knjiga k = cmbKnjige.SelectedItem as Knjiga;
                list = (BindingList<Primerak>)PosaljiOperaciju(Operacija.VratiSvePrimerke, k);
                cmbPrimerci.DataSource = list;
                if (list.Count == 0)
                {
                    btnDodaj.Enabled = false;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(">>>UCPozajmljivanjeKnjige: Greska pri punjenju cmbPrimerci" + e.Message);
                //new FrmMessage("UCPozajmljivanjeKnjige: Greska pri punjenju cmbPrimerci" + e.Message).ShowDialog();
            }
        }

        internal void PopuniCMBPozKnjige(ComboBox cmbClanovi, ComboBox cmbKnjige, ComboBox cmbPrimerci, BindingList<Clan> clanovi, List<Knjiga> knjige, Button btnDodaj, Button btnSacuvajSve)
        {
            try
            {
                clanovi = (BindingList<Clan>)PosaljiOperaciju(Operacija.VratiClanove, new Clan());
                cmbClanovi.DataSource = clanovi;

                knjige = (List<Knjiga>)PosaljiOperaciju(Operacija.VratiSveKnjige, new Knjiga());
                cmbKnjige.DataSource = knjige;

                if (clanovi.Count == 0 || knjige.Count == 0)
                {
                    btnDodaj.Enabled = false;
                    btnSacuvajSve.Enabled = false;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(">>>UCPozajmljivanjeKnjige: Greska pri punjenju cmbCanovi i cmbKnjige" + e.Message);
                //new FrmMessage("UCPozajmljivanjeKnjige: Greska pri punjenju cmbCanovi i cmbKnjige" + e.Message).ShowDialog();
            }
            
        }

        internal void PopuniCMBUnosClana(ComboBox cmbMesto, ComboBox cmbKategorija, Button btnSacuvaj, List<Kategorija> kategorije)
        {
            try
            {
                cmbKategorija.DataSource = kategorije;
                cmbKategorija.DisplayMember = kategorije.ToString();

                List<Mesto> mesta = (List<Mesto>)PosaljiOperaciju(Operacija.VratiSvaMesta, new Mesto());
                cmbMesto.DataSource = mesta;
                cmbMesto.DisplayMember = "Naziv";

                if (mesta.Count == 0)
                {
                    btnSacuvaj.Enabled = false;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(">>>UCUnosClana: Greska pri punjenju cmbMesta" + e.Message);
                //new FrmMessage("UCUnosClana: Greska pri punjenju cmbMesta" + e.Message).ShowDialog();
            }
            
        }

        //Login
        public void Login(TextBox txtKorisnickoIme, TextBox txtSifra, ErrorProvider epUsername, ErrorProvider epPassword, Label lblConnect)
        {
            try
            {
                string username = txtKorisnickoIme.Text;
                string password = txtSifra.Text;

                List<Zaposleni> zap = (List<Zaposleni>)PosaljiOperaciju(Operacija.VratiSveZaposlene, new Zaposleni());

                bool pom = false;
                Zaposleni prijavljeni = null;
                foreach (Zaposleni z in zap)
                {
                    if (z.KorisnickoIme == username)
                    {
                        pom = true;
                        prijavljeni = z;
                    }

                }

                if (pom)
                {
                    if (prijavljeni.Sifra == password)
                    {
                        frm.Hide();
                        PosaljiOperaciju(Operacija.Login, prijavljeni);
                        Sesija.Instance.Zaposleni = prijavljeni;
                        new FrmGlavna().ShowDialog();
                        frm.Close();
                    }
                    else
                    {
                        epPassword.SetError(txtSifra, "Pogrešna šifra");

                        int i = 0;
                        while (i < 70)
                        {
                            txtSifra.Location = new System.Drawing.Point(67, 211);
                            txtSifra.Location = new System.Drawing.Point(66, 211);
                            i++;
                        }
                    }
                }
                else
                {
                    epUsername.SetError(txtKorisnickoIme, "Korisničko ime ne postoji");

                    int i = 0;
                    while (i < 70)
                    {
                        txtKorisnickoIme.Location = new System.Drawing.Point(67, 153);
                        txtKorisnickoIme.Location = new System.Drawing.Point(66, 153);
                        i++;
                    }

                }
            }
            catch (Exception e)
            {
                lblConnect.Show();
                new FrmMessage("Nije moguce ulogovati korisnika" + e.Message).Show();
                
            }
            
        }
        

        //UCVracanjeKnjige
        internal void PretraziPozajmljivanja(ComboBox cmbClanovi, DataGridView dgvPozajmljivanja, BindingList<Pozajmljivanje> lista)
        {
            Clan c = cmbClanovi.SelectedItem as Clan;
            try
            {
                lista = new BindingList<Pozajmljivanje>();
                lista = (BindingList<Pozajmljivanje>)PosaljiOperaciju(Operacija.VratiPozajmljivanja,c);
                dgvPozajmljivanja.DataSource = lista;
                dgvPozajmljivanja.Columns[0].Visible = false;
                dgvPozajmljivanja.Columns[3].HeaderText = "Datum";
                dgvPozajmljivanja.Columns[4].HeaderText = "Rok za vraćanje";

            }
            catch (Exception exe)
            {
                new FrmMessage("KKI\\PretPoz: Greška u radu sa bazom:" + exe.Message).ShowDialog();
            }
        }

        internal void ObrisiPozajmljivanje(DataGridView dgvPozajmljivanja, BindingList<Pozajmljivanje> lista)
        {
            try
            {
                Pozajmljivanje p = (Pozajmljivanje)dgvPozajmljivanja.SelectedRows[0].DataBoundItem;

                try
                {
                    if ((bool)PosaljiOperaciju(Operacija.VracanjeKnjige, p))
                    {
                        lista.Remove(p);
                        dgvPozajmljivanja.DataSource = lista;
                        if (p.RokVracanja < DateTime.Now)
                        {
                            new FrmMessage("Rok za vraćanje je istekao potrebno je da član plati kaznu.").ShowDialog();
                        }
                        else
                        {
                            new FrmMessage("Knjiga je vraćena").ShowDialog();
                        }
                    }
                    else
                    {
                        new FrmMessage("Knjiga nije vraćena.").ShowDialog();
                    }
                }
                catch (Exception e)
                {
                    throw;
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                new FrmMessage("Izaberite knjigu koju član vraća.").ShowDialog();
            }
            catch (Exception ex)
            {
                new FrmMessage("KKI\\ObrisiPoz: Greška u radu sa bazom." + ex.Message).ShowDialog();
            }
        }
        
        //UCPozajmljivanjeKnjige
        internal void SacuvajPozajmljivanje(ComboBox cmbClanovi, BindingList<Pozajmljivanje> pozajmljivanja)
        {
            
            Clan c = cmbClanovi.SelectedItem as Clan;
            if (c.VaziDo > DateTime.Now)
            {
                BindingList<Pozajmljivanje> sacuvano = (BindingList<Pozajmljivanje>)PosaljiOperacijuLista(Operacija.SacuvajPozajmljivanja, pozajmljivanja);

                if (sacuvano != null)
                {
                    new FrmMessage("Uspešno sačuvano!").ShowDialog();

                }
                else
                {
                    new FrmMessage("Nije uspešno sačuvano!").ShowDialog();
                }
            }
            else
            {
                new FrmMessage("Član ne može da pozajmi knjigu jer nije obnovio članarinu").ShowDialog();
            }
        }

        internal BindingList<Pozajmljivanje> DodajPrimerakZaPozajmljivanje(ComboBox cmbClanovi,ComboBox cmbKnjige, ComboBox cmbPrimerci, Zaposleni prijavljeni, BindingList<Pozajmljivanje> pozajmljivanja)
        {
            Pozajmljivanje p = new Pozajmljivanje();

            p.Clan = cmbClanovi.SelectedItem as Clan;
            p.Knjiga = cmbKnjige.SelectedItem as Knjiga;
            p.Primerak = cmbPrimerci.SelectedItem as Primerak;
            p.DatumPozajmljivanja = DateTime.Now;
            p.RokVracanja = DateTime.Now.AddDays(14);
            p.Zaposleni = prijavljeni;

            if (!pozajmljivanja.Contains(p))
                pozajmljivanja.Add(p);

            return pozajmljivanja;
        }

        //UCBrisanjeKnjige
        internal void PretraziKnjige(RadioButton rbISBN, RadioButton rbNaziv,RadioButton rbAutor, TextBox txtKnjiga, DataGridView dgvKnjigaObrisi, BindingList<Knjiga> knjige)
        {
            bool odabran = false;
            Knjiga k = new Knjiga();

            try
            {
                if (rbISBN.Checked)
                {
                    odabran = true;
                    long br = 0;
                    try
                    {
                        br = long.Parse(txtKnjiga.Text);
                    }
                    catch
                    {
                        new FrmMessage("Odabrali ste pretragu prema ISBN. Unesite tekst pretrage!").ShowDialog();
                    }
                    k.Isbn = br;
                    knjige = (BindingList<Knjiga>)PosaljiOperacijuSaKriterijumom(Operacija.PretraziKnjige, k, "isbn");
                    dgvKnjigaObrisi.DataSource = knjige;
                }

                if (rbAutor.Checked)
                {
                    odabran = true;
                    k.Autor = new Autor() { Ime = txtKnjiga.Text };
                    knjige = (BindingList<Knjiga>)PosaljiOperacijuSaKriterijumom(Operacija.PretraziKnjige, k, "autor");
                    dgvKnjigaObrisi.DataSource = knjige;
                }

                if (rbNaziv.Checked)
                {
                    odabran = true;
                    k.Naziv = txtKnjiga.Text;
                    knjige = (BindingList<Knjiga>)PosaljiOperacijuSaKriterijumom(Operacija.PretraziKnjige, k, "naziv");
                    dgvKnjigaObrisi.DataSource = knjige;
                }

                if (!odabran)
                {
                    new FrmMessage("Izaberite kriterijum pretage.").ShowDialog();
                }
            }
            catch (Exception e)
            {
                new FrmMessage("KKI\\PretKnjige: Greska u radu sa bazom: " + e.Message).ShowDialog();
            }
        }

        internal void ObrisiKnjigu(DataGridView dgvKnjigaObrisi, BindingList<Knjiga> knjige)
        {
            try
            {
                Knjiga k = (Knjiga)dgvKnjigaObrisi.SelectedRows[0].DataBoundItem;

                try
                {
                    if (!(bool)PosaljiOperaciju(Operacija.ObrisiKnjigu, k))
                    {
                        new FrmMessage("Knjiga nije obrisana.").ShowDialog();
                    }
                    else
                    {
                        knjige.Remove(k);
                        dgvKnjigaObrisi.DataSource = knjige;
                        new FrmMessage("Knjiga je obrisana.").ShowDialog();
                    }
                }
                catch (Exception e)
                {
                    new FrmMessage("KKI\\ObrisiKnjigu: Greska u radu sa bazom: " + e.Message).ShowDialog();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                new FrmMessage("Izaberite knjigu koju želite da obrišete").ShowDialog();
            }
        }

        //UCUnosKnjige
        internal void SacuvajKnjigu(Knjiga knjiga, TextBox txtISBN, TextBox txtNaziv, TextBox txtGodIzanja, TextBox txtBrStrana, TextBox txtPovez, ComboBox cmbZanr, ComboBox cmbIzdavac, ComboBox cmbAutor)
        {
            try
            {
                knjiga.Isbn = long.Parse(txtISBN.Text);
                knjiga.Naziv = txtNaziv.Text;
                knjiga.GodinaIzdanja = int.Parse(txtGodIzanja.Text);
                knjiga.BrStrana = int.Parse(txtBrStrana.Text);
                knjiga.Povez = txtPovez.Text;
                knjiga.Zanr = (Zanr)cmbZanr.SelectedItem;
                knjiga.Izdavac = (Izdavac)cmbIzdavac.SelectedItem;
                knjiga.Autor = (Autor)cmbAutor.SelectedItem;
                
                Knjiga sacuvana = (Knjiga)PosaljiOperaciju(Operacija.SacuvajKnjigu, knjiga);
                
                if (sacuvana != null)
                {
                    new FrmMessage("Knjiga je uspešno sačuvana!").ShowDialog();
                }
                else
                {
                    new FrmMessage("Knjiga nije uspešno sačuvana!").ShowDialog();
                }

            }
            catch (Exception e)
            {
                new FrmMessage("Pogrešan unos!\n" + e.Message).ShowDialog();
            }
        }

        internal Knjiga DodajPrimerakKnjige(Knjiga knjiga)
        {
            int id = 0;
            Primerak p = new Primerak();

            List<int> listaID = new List<int>();

            foreach (Primerak primerak in knjiga.Primerci)
            {
                if (!listaID.Contains(primerak.PrimerakID))
                    listaID.Add(primerak.PrimerakID);
            }

            for (int i = 0; i < listaID.Count + 1; i++)
            {
                if (!listaID.Contains(i))
                {
                    id = i;
                    break;
                }
                    
            }

            p.PrimerakID = id;
            knjiga.Primerci.Add(p);
            return knjiga;
        }

        //UCObrisiClana
        internal void ObrisiClanove(DataGridView dgvClanoviBrisanje, BindingList<Clan> clanovi)
        {
            try
            {
                Clan c = (Clan)dgvClanoviBrisanje.SelectedRows[0].DataBoundItem;
                string nazivi = "";
                BindingList<Knjiga> nevraceneKnjige = (BindingList<Knjiga>)PosaljiOperacijuSaKriterijumom(Operacija.VratioSveKnjige, c, nazivi);
                if (nevraceneKnjige.Count == 0) 
                {
                    try
                    {
                        if (!(bool)PosaljiOperaciju(Operacija.ObrisiClana, c))
                        {
                            new FrmMessage("Član nije obrisan.").ShowDialog();
                        }
                        else
                        {
                            clanovi.Remove(c);
                            dgvClanoviBrisanje.DataSource = clanovi;
                            new FrmMessage("Član je obrisan.").ShowDialog();
                        }
                    }
                    catch (Exception e)
                    {
                        new FrmMessage("KKI\\ObrisiClanove: Greska u radu sa bazom: " + e.Message).ShowDialog();
                    }
                }
                else
                {
                    foreach (Knjiga k in nevraceneKnjige)
                    {
                        nazivi = k.Naziv + "\n" + nazivi;
                    }
                    new FrmMessage("Brisanje nije moguće, nisu vraćene sledeće knjige: \n" + nazivi).ShowDialog();
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                new FrmMessage("Izaberite člana kog želite da obrišete").ShowDialog();
            }
            catch (Exception ex)
            {
                new FrmMessage("KKI\\ObrisiClanove: Greška u radu sa bazom:" + ex.Message).ShowDialog();
            }
        }

        //UCObnavljanjeClanarine i UCObrisiClana: trazenje clanova po kriterijumu
        internal BindingList<Clan> PretraziClanove(RadioButton rbClKarta, RadioButton rbIme, RadioButton rbPrezime, TextBox txtClan, DataGridView dgvClanovi, BindingList<Clan> clanovi)
        {
            bool odabran = false;
            Clan c = new Clan();

            if (rbClKarta.Checked)
            {
                odabran = true;
                int br = 0;
                try
                {
                    br = Int32.Parse(txtClan.Text);
                    c.BrClanskeKarte = br;
                }
                catch
                {
                    new FrmMessage("Odabrali ste pretragu prema broju članske karte. Unesite tekst pretrage!").ShowDialog();
                }

                clanovi = (BindingList<Clan>)PosaljiOperacijuSaKriterijumom(Operacija.PretraziClanove, c, "brClKarte");

                dgvClanovi.DataSource = clanovi;
            }

            if (rbIme.Checked)
            {
                odabran = true;
                c.Ime = txtClan.Text;
                clanovi = (BindingList<Clan>)PosaljiOperacijuSaKriterijumom(Operacija.PretraziClanove, c, "ime");
                dgvClanovi.DataSource = clanovi;
            }

            if (rbPrezime.Checked)
            {
                odabran = true;
                c.Prezime = txtClan.Text;
                clanovi = (BindingList<Clan>)PosaljiOperacijuSaKriterijumom(Operacija.PretraziClanove, c, "prezime");
                dgvClanovi.DataSource = clanovi;
            }

            if (!odabran)
            {
                new FrmMessage("Izaberite kriterijum pretage.").ShowDialog();
            }

            return clanovi;
        }

        //UCUnosClana
        internal void SacuvajClana(TextBox txtIme, TextBox txtPrezime, TextBox txtBrTelefona, ComboBox cmbMesto, ComboBox cmbKategorija, DateTimePicker dtpVaziDo)
        {
            try
            {
                Clan clan = new Clan();
                clan.Ime = txtIme.Text;
                clan.Prezime = txtPrezime.Text;
                clan.BrTelefona = txtBrTelefona.Text;
                clan.Mesto = (Mesto)cmbMesto.SelectedItem;
                clan.Kategorija = (Kategorija)cmbKategorija.SelectedItem;
                clan.VaziDo = dtpVaziDo.Value;

                Clan sacuvan = (Clan)PosaljiOperaciju(Operacija.SacuvajClana, clan);

                if (sacuvan != null)
                {
                    new FrmMessage("Član je uspešno sačuvan!").ShowDialog();
                }
                else
                {
                    new FrmMessage("Član nije uspešno sačuvan!").ShowDialog();
                }

            }
            catch (Exception e)
            {
                new FrmMessage("Pogrešan unos!\n"+e.Message).ShowDialog();
            }
        }
        
        //FrmObnavljanjeClanarine
        internal void ObnavljanjeClanarine(Clan clan, DateTimePicker dtpVaziDo)
        {
            clan.VaziDo = dtpVaziDo.Value;
            try
            {
                if (!(bool)PosaljiOperaciju(Operacija.IzmeniClana, clan))
                {
                    new FrmMessage("Član nije izmenjen.").ShowDialog();
                }
                new FrmMessage("Članu je produžena članarina.").ShowDialog();
            }
            catch (Exception ex)
            {
                new FrmMessage(ex.Message).ShowDialog();
            }
            frm.Close();
        }
        
        //Opste metode: SELECT, UPDATE, DELETE, INSERT
        internal Object PosaljiOperaciju(Operacija operacija, IDomenskiObjekat ido)
        {
            Zahtev z = new Zahtev
            {
                Operacija = operacija,
                Objekat = ido                
            };

            Komunikacija.Instance.PosaljiZahtev(z);

            Odgovor o = Komunikacija.Instance.ProcitajOdgovor();

            if (o.Signal == Signal.Ok)
            {
                return o.Objekat;
            }
            else
            {
                throw new Exception(o.Poruka);
            }
        }

        internal Object PosaljiOperacijuSaKriterijumom(Operacija operacija, IDomenskiObjekat ido, string kriterijum)
        {
            Zahtev z = new Zahtev
            {
                Operacija = operacija,
                Objekat = ido,
                Kriterijum = kriterijum
            };

            Komunikacija.Instance.PosaljiZahtev(z);

            Odgovor o = Komunikacija.Instance.ProcitajOdgovor();

            if (o.Signal == Signal.Ok)
            {
                return o.Objekat;
            }
            else
            {
                throw new Exception(o.Poruka);
            }
        }

        internal Object PosaljiOperacijuLista(Operacija operacija, BindingList<Pozajmljivanje> ido)
        {
            Zahtev z = new Zahtev
            {
                Operacija = operacija,
                lista = ido
            };

            Komunikacija.Instance.PosaljiZahtev(z);

            Odgovor o = Komunikacija.Instance.ProcitajOdgovor();

            if (o.Signal == Signal.Ok)
            {
                return o.Objekat;
            }
            else
            {
                throw new Exception(o.Poruka);
            }
        }


    }
}
