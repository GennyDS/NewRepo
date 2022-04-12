using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class Acqua : Prodotto
    {
        private const double litriMax = 1.5;
        private double ph;
        private string sorgente;




        public Acqua(string nome, string descrizione, double prezzo, double litri, string sorgente, double ph) : base(nome, descrizione, prezzo)
        {
            this.GetLitriMax();
            this.ph = ph;
            this.sorgente = sorgente;

        }


        protected private double LitriDaBere(double litriAssunti)
        {
            double litriDopoBevuta = litriMax - litriAssunti;

            if (litriAssunti < 0)
            {
                Console.WriteLine("l'acqua non è diminuita ,bevi!!");
                return;


            }


            if (litriDopoBevuta < litriMax)
            {
                litriDopoBevuta = litriMax - litriDopoBevuta;
            }
            else
            {
                Console.WriteLine("hai finito l'acqua");

                return litriDopoBevuta;
            }
            return litriDopoBevuta;
        }



        public double GetLitriMax()
        {
            return litriMax;
        }


        public override void StampaProdottoIntero()
        {
            Console.WriteLine("la bevanda è : " + base.CreaCodiceProdotto + "-" + base.nome + "-" + this.sorgente + "-" + this.ph + "-" + litriMax);
        }



        public double riempi(double litri)
        {
            double bottigliaDopoRiempimento = litriMax + litri;

            if (litri < 0)
            {
                Console.WriteLine("Non posso riempire senza mettere l'acqua");
                return;
            }

            if (bottigliaDopoRiempimento < litriMax)
            {
                double bottiglia = bottigliaDopoRiempimento;
            }
            else
            {
                Console.WriteLine("hai fatto uscire l'acqua,la tua bottiglia è piena");
                bottigliaDopoRiempimento = litriMax;
            }


            public double Svuota()
            {
                double bottigliasvuotata = litriMax - litriMax;
                return bottigliasvuotata;
            }






        }
    }

}
