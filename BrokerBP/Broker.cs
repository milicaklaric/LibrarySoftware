using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace BrokerBP
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projekat;Integrated Security=True");
        }

        public void OtvoriKonekciju()
        {
            connection.Open();
        }

        public void PokreniTransakciju()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public void ZatvoriKonekciju()
        {
            connection.Close();
        }
        
        //SELECT
        public List<IDomenskiObjekat> VratiSve(IDomenskiObjekat ido)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"SELECT * FROM {ido.Tabela} {ido.Join}";
            SqlDataReader reader = command.ExecuteReader();
            List<IDomenskiObjekat> rezultat = ido.VratiListu(reader);

            if (reader != null) reader.Close();

            return rezultat;
        }
            
        //UPDATE
        public bool Izmeni(IDomenskiObjekat ido)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"update {ido.Tabela} set {ido.Update} where {ido.Where}";
            int rez = command.ExecuteNonQuery();
            return rez == 1;
        }

        //DELETE
        public bool Obrisi(IDomenskiObjekat ido)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"delete from {ido.Tabela} where {ido.Where}";
            int rez = command.ExecuteNonQuery();

            if(ido is Pozajmljivanje)
            {
                ((Pozajmljivanje)ido).Primerak.Dostupan = false;
                PromeniDostupnost((Pozajmljivanje)ido);
            }

            return rez == 1;
        }

        //INSERT
        public bool Sacuvaj(IDomenskiObjekat ido)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            ido.TesktKomande(command);
            //command.CommandText = $"insert into {ido.Tabela} values {ido.Insert}";

            int rez = command.ExecuteNonQuery();
            
            if (ido is Pozajmljivanje)
            {
                PromeniDostupnost((Pozajmljivanje)ido);
            }

            if(ido is Knjiga)
            {
                foreach (Primerak primerak in ((Knjiga)ido).Primerci)
                {
                    primerak.Isbn = ((Knjiga)ido).Isbn;
                    Sacuvaj(primerak);
                }
            }

            return rez == 1;
        }


        //Pomocne
        public int VratiBrClanskeKarte()
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = "select MAX(BrClanskeKarte) from Clan";
            object rez = command.ExecuteScalar();
            if (rez is DBNull)
                return 1;

            int id = (int)rez;
            return id + 1;
        }

        private void PromeniDostupnost(Pozajmljivanje p)
        {
            int vrednost = 0; 
            switch (p.Primerak.Dostupan)
            {
                case true:
                    vrednost = 0;
                    break;
                case false:
                    vrednost = 1;
                    break;
            }

            try
            {
                SqlCommand command = new SqlCommand("", connection, transaction);
                command.CommandText = $"UPDATE Primerak SET Dostupan = {vrednost} WHERE Primerak.ISBN = {p.Knjiga.Isbn} AND Primerak.PrimerakID = {p.Primerak.PrimerakID}";

                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Greska! Nije moguce promeniti dostupnost primerka!" + e.Message + "\n");
            }
        }

        
    }
}
