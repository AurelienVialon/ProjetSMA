using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApplication1
{
    public class Case : Label
    {
        public Entité contenu
        {
          
        }

        public Case()
        {
            //BorderBrush = new SolidColorBrush(Colors.Black);
            //BorderThickness = new Thickness(0.5);
            var binding = new Binding("contenu");
            binding.Source = window1.ListBox;
        }

    }
}
