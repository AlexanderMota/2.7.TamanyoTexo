using System.Windows;
using System.Windows.Controls;

namespace TamanyoTexo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();
        private void RBoton_Click(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Name)
            {
                case "RBoton1":
                    if (!RBoton1.IsChecked.Value)
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
                    if (!RBoton2.IsChecked.Value)
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
                    if (!RBoton3.IsChecked.Value)
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
                default: break;
            }
        }
    }
}
