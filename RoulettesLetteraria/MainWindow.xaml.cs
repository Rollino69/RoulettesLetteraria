using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Schema;

namespace RoulettesLetteraria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        


        private async void btn_stampa_Click(object sender, RoutedEventArgs e)
        {
            
            while(true)
            {
                lbl_stampa.Content = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "Z" }[new Random().Next(0, 21)];
                await Task.Delay(100);
            }

        }


        private void btn_change_function_Click(object sender, RoutedEventArgs e)
        {
            if(btn_stampa.Content.ToString() == "Inizia")
            {
                btn_stampa.Content = "Stampa";

            }
            else
            {
                lst_parole.Items.Add(new ListBoxItem() { Content = lbl_stampa.Content.ToString() });
            }
        }


        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}