using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuldKort
{

        public class Konto<T>  // min generiska klass som har kontots meddlemer
    {
           public T[] användareID;  // en lsita metod som har användareId värden och det kvittar vilken typ de är
           public int användaresIdLängd;  // För att deklarear hur många värden ska listan innehålla
           public int Buffert;  // hur stor ska vara buffert

           public string namn; // en egenskap som tar hand om användarens namn
           public string omdårde;  // och om användarens område

            public Konto(string indatanamn, string indataområde)  // en konstruktorer som har två värden (namn och område) som förändras beroende av underklasserna
        {
            användaresIdLängd = 49; // Jag deklarerar listan tillgängliga platser
            Buffert = 8;  // och hur stor värden är

            användareID = new T[användaresIdLängd];
            namn = indatanamn;
            omdårde = indataområde;
            }           
        }

        public class Kort<T> : Konto<T>  // En underklass till konto som har samma metod och två egenskaper
        {
            public T[] kortetsID;  // samma som tidigare
            public int kortetsIdsLängd;
            public int buffert;

            public string belöning;  // En egenskap som ska förändras och få nya värde beroende av vilken underkallas kallas metoden

            public Kort(string indatanamn, string indataområde) : base (indatanamn, indataområde)
            {
               
                kortetsIdsLängd = 49;
                buffert = 10;

                kortetsID = new T[kortetsIdsLängd];
            }       
        
        }


    public class Dunderkatt<T> : Kort<T>  // En under underklass som tillhör till kort-klass vilket ändrar en ärvd egenskap och har två egenskaper från konto-klass
    {
        public Dunderkatt( string indatanamn, string indataområde) : base( indatanamn, indataområde)
            {
             belöning = "Dunderkatt";             
            }

        public override string ToString()  //En override-ToString metod som används vid gratulation och den returnera olika värden.
        {
            return "Grattis " + namn + "!\n" + "Du har vunnit det exklusiva " + belöning + "!\n" + "Du kan hämta det i din lokala spelbutik i " + omdårde;
        }

    }
    public class Kristallhäst<T> : Kort<T>  // samma häller här
    {
        public Kristallhäst(string indatanamn, string indataområde) : base(indatanamn, indataområde)
        {
            belöning = "Kristalhäst";
            
        }
        public override string ToString()  
        {
           
            return "Grattis " + namn + "!\n" + "Du har vunnit det exklusiva " + belöning + "!\n" + "Du kan hämta det i din lokala spelbutik i " + omdårde;
        }
    }
    public class Överpanda<T> : Kort<T>  // samma häller här
    {
        public Överpanda(string indatanamn, string indataområde) : base(indatanamn, indataområde)
        {
            belöning = "Överpanda";
        }
        public override string ToString()  
        {
           return "Grattis " + namn + "!\n" + "Du har vunnit det exklusiva " + belöning + "!\n" + "Du kan hämta det i din lokala spelbutik i " + omdårde;
        }
    }
    public class Eldtomat<T> : Kort<T>   // samma häller här
    {
        public Eldtomat(string indatanamn, string indataområde) : base(indatanamn, indataområde)
        {
            belöning = "Eldtomat";
        }
        public override string ToString()   
        {
            return "Grattis " + namn + "!\n" + "Du har vunnit det exklusiva " + belöning + "!\n" + "Du kan hämta det i din lokala spelbutik i " + omdårde;
        }
    }
}

