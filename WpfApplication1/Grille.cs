using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApplication1
{
    class Grille : Grid
    {
        private int hauteur, largeur;
        public Case[][] map;
        public Grille(int h, int l, int nbA, int nbB, int nbAgents, double kplus, double kmoins)
        {
            map = new Case[l][];
            for (int j = 0; j < l; j++)
            {
                this.ColumnDefinitions.Add(new ColumnDefinition());
                map[j] = new Case[h];
            }
            for (int i = 0; i < h; i++)
            {
                this.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    Case c = new Case();
                    map[j][i] = c;
                    Children.Add(c);
                    Grid.SetColumn(c, j);
                    Grid.SetRow(c, i);
                }
            }
            try
            {
                for (int i = 0; i < nbA; i++)
                {
                    Random r = new Random();
                    int? x = null;
                    int? y = null;
                    do
                    {
                        x = r.Next()%l;
                        y = r.Next()%h;
                    } while (map[(int) x][(int) y].contenu != null);
                    map[(int) x][(int) y].contenu = new Objet("A");
                }
            }
            catch(Exception e)
            {
                
            }
            for (int i = 0; i < nbB; i++)
            {
                Random r = new Random();
                int? x = null;
                int? y = null;
                do
                {
                    x = r.Next() % l;
                    y = r.Next() % h;
                } while (map[(int)x][(int)y].contenu != null);
                map[(int)x][(int)y].contenu = new Objet("B");
            }
            for (int i = 0; i < nbAgents; i++)
            {
                Random r = new Random();
                int? x = null;
                int? y = null;
                do
                {
                    x = r.Next() % l;
                    y = r.Next() % h;
                } while (map[(int)x][(int)y].contenu != null);
                map[(int)x][(int)y].contenu = new Agent();
            }
        }

    }
}
