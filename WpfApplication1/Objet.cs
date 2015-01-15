using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Objet : Entité
    {
        private string nom;

        public Objet(string n)
        {
            nom = n;
        }
        public override string affichage()
        {
            return nom;
        }
    }
}
