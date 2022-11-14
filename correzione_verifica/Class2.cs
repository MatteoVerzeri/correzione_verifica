using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correzione_verifica
{
    internal class cartabancomat
    {
        string id;
        string pin;
        banca conto;
        public cartabancomat(string id, string pin, banca conto)
        {
            this.id = id;
            this.pin = pin;
            this.conto = conto;
        }
        public string getID()
        {
            return id;
        }
        public void deposita(float value, string Pin)
        {
            if (pin == Pin)
            {
                conto.Deposito(value);
            }
            else
            {
                throw new Exception("pin sbagliato");
            }
        }
        public void preleva(float value, string Pin)
        {
            if (pin == Pin)
            {
                conto.Prelievo(value);
            }
            else
            {
                throw new Exception("pin sbagliato");
            }
        }
        public float getSaldo()
        {
            return conto.getSaldo();
        }
        private string getPin()
        {
            return pin;
        }
    }
}
