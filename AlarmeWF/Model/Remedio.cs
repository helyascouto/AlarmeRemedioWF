using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmeWF.Model
{
    internal class Remedio
    {
        public string NomeRemedio { get; set; }
        public string horas { get; set; }
        string texto = "";

        public void AdicionarHoras(string hora)
        {
            horas = "-" + hora;
            texto += horas;
        }
        public string retornaHoras()
        {
            return texto;
        }
    }
}
