using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correzione_verifica
{
    internal class banca
    {
        string id;
        string cliente;
        string _banca;
        float saldo;
        public banca(string id, string cliente, string banca)
        {
            this.id = id;
            this.cliente = cliente;
            this._banca = banca;
            saldo = 0;
        }
        public string getID()
        {
            return id;
        }
        public string getcliente()
        {
            return id;
        }
        public string getBanca()
        {
            return _banca;
        }
        public float getSaldo()
        {
            return saldo;
        }
        public void Deposito(float value)
        {
            if (value >= 0)
            {
                saldo = saldo + value;
            }
        }
        public void Prelievo(float value)
        {
            float temp = saldo - value;
            if (temp >= 0 && value >= 0)
            {
                saldo = saldo - value;
            }
        }
        public void Bonifico(banca Destinazione, float value)
        {
            float temp = saldo - value;
            if (temp >= 0 && value >= 0)
            {
                saldo = saldo - value;
                Destinazione.Deposito(value);
            }
        }
    }
}
