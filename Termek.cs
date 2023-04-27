using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSqlApp1
{
    internal class Termek
    {
        string kategoria;
        string gyarto;
        string nev;
        int ar;
        int garido;

        
        public Termek(string kategoria, string gyarto, string nev, int ar, int garido)
        {
            this.Kategoria = kategoria;
            this.Gyarto = gyarto;
            this.Nev = nev;
            this.Ar = ar;
            this.Garido = garido;
        }

        public String ToCSVString()
        {
            return $"{this.Kategoria};{this.Gyarto};{this.Nev};{this.Ar};{this.Garido}";
        }

        public static String ToCSVString(Termek par)
        {
            return $"{par.Kategoria};{par.Gyarto};{par.Nev};{par.Ar};{par.Garido}";
        }

        public string Kategoria { get => kategoria; set => kategoria = value; }
        public string Gyarto { get => gyarto; set => gyarto = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Ar { get => ar; set => ar = value; }
        public int Garido { get => garido; set => garido = value; }

    }
}
