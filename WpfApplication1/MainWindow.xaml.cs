using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
<<<<<<< HEAD
            panel.Children.Add(new Grille(50, 50, 200, 200, 40, 0.1, 0.3, 1,1000));
=======
            panel.Children.Add(new Grille(100, 100, 200, 200, 20, 0.1, 0.3, 1,1000));
>>>>>>> 95eaffdabd0e5abaafdb1f7433823a401342a754
        }
    }
}
