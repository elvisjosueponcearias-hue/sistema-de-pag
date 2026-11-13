using System;

namespace SistemaDePagos
{
    class Pago
    {
        public virtual decimal Calcular(decimal monto)
        {
            return monto;
        }
    }

    class Efectivo : Pago
    {
        public override decimal Calcular(decimal monto)
        {
            return monto;
        }
    }

    class Tarjeta : Pago
    {
        public override decimal Calcular(decimal monto)
        {
            decimal comision = monto * 0.03m;
            return monto + comision;
        }
    }

    // Reto extra
    class Transferencia : Pago
    {
        public override decimal Calcular(decimal monto)
        {
            return monto;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el monto del pago: ");
            decimal monto = Convert.ToDecimal(Console.ReadLine());

            Pago pago1 = new Efectivo();
            Pago pago2 = new Tarjeta();
            Pago pago3 = new Transferencia();

            decimal totalEfectivo = pago1.Calcular(monto);
            decimal totalTarjeta = pago2.Calcular(monto);
            decimal totalTransferencia = pago3.Calcular(monto);

            Console.WriteLine("\n--- SISTEMA DE PAGOS ---");

            Console.WriteLine("Pago en efectivo: RD$" + totalEfectivo);
            Console.WriteLine("Pago con tarjeta: RD$" + totalTarjeta);
            Console.WriteLine("Pago por transferencia: RD$" + totalTransferencia);

            Console.WriteLine("\nPresione una tecla para salir.");
            Console.ReadKey();
        }
    }
}