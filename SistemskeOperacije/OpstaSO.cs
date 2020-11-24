
using BrokerBP;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public abstract class OpstaSO//razlika u dokumentaciji
    {
        protected Broker broker = new Broker();

        public void IzvrsiSO(IDomenskiObjekat odo)
        {
            try
            {
                broker.OtvoriKonekciju();
                broker.PokreniTransakciju();
                Validacija(odo);
                IzvrsiKonkretnuOperaciju(odo);
                broker.Commit();
            }
            catch (Exception e)
            {
                broker.Rollback();
                throw new Exception("Greska pri radu sa bazom:" + e.Message+ "\n");
            }
            finally
            {
                broker.ZatvoriKonekciju();
            }
        }
        
        protected abstract void Validacija(IDomenskiObjekat odo);

        protected abstract void IzvrsiKonkretnuOperaciju(IDomenskiObjekat odo);

        }

}