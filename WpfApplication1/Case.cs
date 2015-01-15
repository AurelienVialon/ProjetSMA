using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApplication1
{
    public class Case : Label
    {
        public Entité _contenu;
        public Entité contenu
        {
            get { return _contenu; }
            set
            {
                Dispatcher.Invoke(
                    new Action(() =>
                    {
                        Content = value != null ? value.affichage() : "";
                        _contenu = value;
                        if(value != null)
                        Background =
                            new SolidColorBrush(value.affichage() == "A"
                                ? Colors.Blue
                                : value.affichage() == "B"
                                    ? Colors.Red
                                    : value.affichage() == "Agent" ? Colors.Green : Colors.White);
                        else
                        {
                            Background = new SolidColorBrush(Colors.White);
                        }
                    }));
            }
        }

        public Case()
        {
            //BorderBrush = new SolidColorBrush(Colors.Black);
            //BorderThickness = new Thickness(0.5);
            
        }

    }
}
