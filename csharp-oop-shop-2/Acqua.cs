using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class Acqua : Prodotto
    {
        private const double litri=1.5;
        private double ph;
        private string sorgente;



      
        public Acqua(int Codice, string nome, string descrizione, double prezzo, double iva, double litri, string sorgente, double ph) : base(Codice, nome, descrizione, prezzo, iva)
        {
            //this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;

        }
   
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
 
   





    }


}  
