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

        //Random rnd = new Random();


        private async void btn_stampa_Click(object sender, RoutedEventArgs e)
         {
             lblStampa.Content=;
            //array con tutte le lettere da stampare randominacemente 
            new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "Z" }[new Random().Next(0, 21)];

            await Task.Delay(100);
         }




        /*private int StampaCasuale()
         {
             return rnd.Next(1, 100);
        }*/



    }
}