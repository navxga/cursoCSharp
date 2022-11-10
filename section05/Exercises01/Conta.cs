using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace section05.Exercises01
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        private double Saldo;


        public Conta() {
        }

        public Conta(int numero, string titular, double depositoInicial)
        {
            Numero = numero;
            Titular = titular;
            Saldo = depositoInicial;
        }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0.0;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }
        public void Saque(double valor)
        {
            Saldo -= valor;
        }


        public override string ToString()
        {
            return $"Conta {Numero}, " +
                $"Titular: {Titular}, " +
                $"Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
