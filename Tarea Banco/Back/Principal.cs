

namespace Back
{
    public class Principal
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public void AgregarCliente(string nombre, string apellido, int dni)
        {
            Cliente cliente = new Cliente()
            {
                Nombre = nombre,
                Apellido = apellido,
                Dni = dni
            };

            context.Clientes.Add(cliente);
            context.SaveChanges();

        }

        public void CrearCuentaBancaria(int cuentaId, string numeroCuenta, decimal saldo, string tipo)
        {
            CuentaBancaria cuentaBancaria = new CuentaBancaria()
            {
                CuentaId = cuentaId,
                NumeroCuenta = numeroCuenta,
                Saldo = saldo,
                Tipo = tipo
            };

            context.CuentasBancarias.Add(cuentaBancaria);
            context.SaveChanges();

            
        }

        public void EmitirTarjetaCredito(int clienteId, string numeroTarjeta, decimal limiteCredito)
        {
            TarjetaCredito tarjetaCredito = new TarjetaCredito()
            {
                tarjetaId = clienteId,
                NumeroTarjeta = numeroTarjeta,
                LimiteCredito = limiteCredito,
                SaldoDisponible = limiteCredito,
                Estado = "Activa"
            };

            context.TarjetasCredito.Add(tarjetaCredito);
            context.SaveChanges();

           
        }
        public void PausarTarjetaCredito(int tarjetaId)
        {
            TarjetaCredito tarjetaCredito = context.TarjetasCredito.Find(tarjetaId);
            tarjetaCredito.Estado = "Pausada";
            context.SaveChanges();

            
        }

        public void RealizarDeposito(int cuentaId, decimal monto)
        {
            CuentaBancaria cuentaBancaria = context.CuentasBancarias.Find(cuentaId);
            cuentaBancaria.Saldo += monto;
            context.SaveChanges();

            
        }

        public void RealizarExtraccion(int cuentaId, decimal monto)
        {
            CuentaBancaria cuentaBancaria = context.CuentasBancarias.Find(cuentaId);

            if (cuentaBancaria.Saldo < monto)
            {
                throw new Exception("Saldo insuficiente");
            }

            cuentaBancaria.Saldo -= monto;
            context.SaveChanges();

            
        }

    }
}
