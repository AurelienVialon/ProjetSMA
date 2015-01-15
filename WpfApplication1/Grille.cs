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
        public static Case[][] map;
        public static int pas;
        public static double vitesse;

        public static Random r = new Random();
        public Grille(int h, int l, int nbA, int nbB, int nbAgents, double kplus, double kmoins, int p, double vit)
        {
            vitesse = vit;
            map = new Case[l][];
            pas = p;
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
                int? x = null;
                int? y = null;
                do
                {
                    x = r.Next() % l;
                    y = r.Next() % h;
                } while (map[(int)x][(int)y].contenu != null);
                Agent a = new Agent((int)x, (int)y);
                map[(int) x][(int) y].contenu = a;
                a.Run();
            }
        }

        public static void bouger(int direction, Agent a) 
        {
            // 0 gauche, 1 haut, 2 droite, 3 bas
            try
            {
                switch (direction)
                {
                    case 0:
                        //gauche
                        if ((a.x - pas) >= 0 && map[a.x - pas][a.y].contenu == null)
                        {

                            map[a.x - pas][a.y].contenu = a;
                            map[a.x][a.y].contenu = null;
                            a.x = a.x - pas;
                        }
                        break;
                    case 1:
                        //gauche
                        if ((a.y - pas) >= 0 && map[a.x][a.y-pas].contenu == null)
                        {

                            map[a.x][a.y-pas].contenu = a;
                            map[a.x][a.y].contenu = null;
                            a.y = a.y - pas;
                        }
                        break;
                    case 2:
                        //gauche
                        if ((a.x + pas) < map.Length && map[a.x + pas][a.y].contenu == null)
                        {

                            map[a.x + pas][a.y].contenu = a;
                            map[a.x][a.y].contenu = null;
                            a.x = a.x + pas;
                        }
                        break;
                    case 3:
                        //gauche
                        if ((a.y + pas) < map[a.x].Length && map[a.x][a.y + pas].contenu == null)
                        {

                            map[a.x][a.y + pas].contenu = a;
                            map[a.x][a.y].contenu = null;
                            a.y = a.y + pas;
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

    }
}
