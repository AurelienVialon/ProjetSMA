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
                _contenu = value;
                Dispatcher.Invoke(
                    new Action(() =>
                    {
                        Content = value != null ? value.affichage() : "";
                    }));
                      
                        if (value != null)
                        {
                            Dispatcher.Invoke(
                    new Action(() =>
                    {
                            Background =
                                new SolidColorBrush(value.affichage() == "A"
                                    ? Colors.Blue
                                    : value.affichage() == "B"
                                        ? Colors.Red
                                        : value.affichage() == "Agent" || value.affichage() == "AgentA" ||
                                          value.affichage() == "AgentB"
                                            ? Colors.Green
                                            : Colors.White);
                    }));
                            if (value.affichage() == "AgentA")
                            {
                                Dispatcher.Invoke(
                    new Action(() =>
                    {
                                BorderBrush = new SolidColorBrush(Colors.Blue);
                                BorderThickness = new Thickness(1);
                    }));
                            }
                            else if (value.affichage() == "AgentA")
                            {
                                Dispatcher.Invoke(
                                new Action(() =>
                    {
                                BorderBrush = new SolidColorBrush(Colors.Red);
                                BorderThickness = new Thickness(1);
                        }));
                            }
                            else
                            {
                                Dispatcher.Invoke(
                    new Action(() =>
                    {
                                BorderBrush = null;
                        }));
                            }
                        }
                        else
                        {
                            Dispatcher.Invoke(
                    new Action(() =>
                    {
                            Background = new SolidColorBrush(Colors.White);
                            BorderBrush = null;
                    }));
                        }
            }
        }

        public void majCouleurs()
        { }

        public Case()
        {
            //BorderBrush = new SolidColorBrush(Colors.Black);
            //BorderThickness = new Thickness(0.5);
            
        }

    }
}
