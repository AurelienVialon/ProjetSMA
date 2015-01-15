using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Threading;

namespace WpfApplication1
{
    class Agent : Entité
    {
        public static int dernierID;
        public int id,x,y;
        public Case c;
        public Entité porte = null;
        List<Char> historique = new List<char>();
        public Agent(int x1, int y1)
        {
            id = dernierID++;
            x = x1;
            y = y1;
        }
        public override string affichage()
        {
            if (porte != null)
                return "Agent"+porte.affichage();
            return "Agent";
        }

        public void Run()
        {
            Thread t = new Thread(new ThreadStart(boucle));
            t.Start();
        }
        public void boucle()
        {
            while (true)
            {
                
                int direction =Grille.r.Next() % 4;
                Grille.bouger(direction, this);
                if (porte == null)
                {
                    //reflechir si on prend ou pas
                    for (int i = -1; i < 2; i++)
                    {
                        for (int j = -1; j < 2; j++)
                        {
                            if (x + i >= 0 && x + i < Grille.map.Length && y + j >= 0 && y + y < Grille.map[x].Length &&
                                Grille.map[x + i][y + j].contenu != null &&
                                !Grille.map[x + i][y + j].contenu.affichage().Contains("Agent"))
                            {
                                //on regarde si on prend ou pas
                                double probaprise = 0.5;
                                double chance = (double) Grille.r.Next(1000)/(double) 1000;
                                if (chance < probaprise)
                                {
                                    porte = Grille.map[x + i][y + j].contenu;
                                    break;
                                }
                            }
                        }
                        if (porte != null)
                            break;
                    }
                    if (porte != null)
                        historique.Add(porte.affichage()[0]);
                    if(historique.Count > 10)
                        historique.RemoveAt(0);
                }
                System.Threading.Thread.Sleep((int)(1000/Grille.vitesse));
            }
        }
    }
}
