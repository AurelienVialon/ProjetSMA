using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Agent : Entité
    {
        public static int dernierID;
        public int id;

        public Agent()
        {
            id = dernierID++;
        }
        public override string affichage()
        {
            return "Agent";
        }
    }
}
