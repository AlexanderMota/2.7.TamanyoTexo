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

namespace TamanyoTexo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /*private void RBoton_Checked(object sender, RoutedEventArgs e)
        {
            //((RadioButton)sender).Name

            switch(((RadioButton)sender).Name)
            {
                case "RBoton1":
                    RBoton1.IsChecked = true;
                    this.Texto.FontSize = 36;
                    break;
                case "RBoton2":
                    RBoton1.IsChecked = true;
                    this.Texto.FontSize = 48;
                    break;
                case "RBoton3":
                    RBoton1.IsChecked = true;
                    this.Texto.FontSize = 72;
                    break;
                default:
                    break;

            }
        }

        private void RBoton_Unchecked(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Name)
            {
                case "RBoton1":
                    RBoton1.IsChecked = true;
                    this.Texto.FontSize = 36;
                    break;
                case "RBoton2":
                    RBoton1.IsChecked = true;
                    this.Texto.FontSize = 48;
                    break;
                case "RBoton3":
                    RBoton1.IsChecked = true;
                    this.Texto.FontSize = 72;
                    break;
                default:
                    break;

            }
        }*/

        private void RBoton_Click(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Name)
            {
                case "RBoton1":
                    if (!(bool)RBoton1.IsChecked.Value)
                    {
                        RBoton1.IsChecked = false;
                        this.Texto.FontSize = 12;
                    }
                    else
                    {
                        RBoton1.IsChecked = true;
                        this.Texto.FontSize = 36;
                    }
                    break;
                case "RBoton2":
                    if (!(bool)RBoton2.IsChecked.Value)
                    {
                        RBoton2.IsChecked = false;
                        this.Texto.FontSize = 12;
                    }
                    else
                    {
                        RBoton2.IsChecked = true;
                        this.Texto.FontSize = 48;
                    }
                    break;
                case "RBoton3":
                    if (!(bool)RBoton3.IsChecked.Value)
                    {
                        RBoton3.IsChecked = false;
                        this.Texto.FontSize = 12;
                    }
                    else
                    {
                        RBoton3.IsChecked = true;
                        this.Texto.FontSize = 72;
                    }
                    break;
                default:
                    break;

            }
        }
    }
}
