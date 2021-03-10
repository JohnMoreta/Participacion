using System;
namespace Participacion
{
    class Cli
    {
        private string nomb;
        private int mon;

        public Cli(string nom)
        {
            nomb = nom;
            mon = 0;
        }

        public void Depo(int j)
        {
            mon = mon + j;
        }

        public void Ext(int j)
        {
            mon = mon - j;
        }

        public int RetMon()
        {
            return mon;
        }

        public void Imp()
        {
            Console.WriteLine(nomb + " Tiene depositados: " + mon);
        }
    }

    class Banco
    {
        private Cli cli1, cli2, cli3;

        public Banco()
        {
            cli1 = new Cli("John");
            cli2 = new Cli("Miguel");
            cli3 = new Cli("Uriel");
        }

        public void Operar()
        {
            cli1.Depo(5000);
            cli2.Depo(4500);
            cli3.Depo(1500);
            cli3.Ext(700);
        }

        public void DepoTot()
        {
            int a = cli1.RetMon() +
                    cli2.RetMon() +
                    cli3.RetMon();
            Console.WriteLine("El Dinero Total del Banco es:" + a);
            cli1.Imp();
            cli2.Imp();
            cli3.Imp();
        }

        static void Main(string[] args)
        {
            Banco banco1 = new Banco();
            banco1.Operar();
            banco1.DepoTot();
            Console.ReadKey();
        }
    }
}