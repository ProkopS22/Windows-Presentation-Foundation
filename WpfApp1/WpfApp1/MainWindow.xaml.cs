using System.Reflection.Emit;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()

           
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                // Přidat obsah stisknutého tlačítka k obsahu labelu
                label.Content += clickedButton.Content.ToString();
            }


        }
    }
}
