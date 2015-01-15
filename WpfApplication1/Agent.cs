using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WpfApplication1
{
    class Agent : Entité
    {
        public static int dernierID;
        public int id,x,y;
        public Case c;

        public Agent(int x1, int y1)
        {
            id = dernierID++;
            x = x1;
            y = y1;
        }
        public override string affichage()
        {
            return "Agent";
        }

        public void Run()
        {
            Thread t = new Thread(new ThreadStart(boucle));
            t.Start();
        }
        public void boucle()
        {
            
                Random r = new Random();
                int direction = r.Next()%4;
                
                Grille.bouger(direction, this);
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
