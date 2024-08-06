namespace Librerias
{
    public class Banco
    {
        private string titular;
        private string tipoDeCuenta;
        private double saldo;

        public Banco(string titular, string tipoDeCuenta, double saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
            this.tipoDeCuenta = tipoDeCuenta;
        }

        public string GetTitular()
        {
            return titular;
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public string GetTipoDeCuenta()
        {
            return tipoDeCuenta;
        }

        public string CuentaToString()
        {
            return $"Titular: {this.titular} - Saldo: {this.saldo} - Tipo de Cuenta: {this.tipoDeCuenta}";
        }

        public void IngresarDinero(int dinero)
        {
            this.saldo += dinero;
        }

        public void RetirarDinero(int dinero)
        {
            this.saldo -= dinero;
        }
    }
}

