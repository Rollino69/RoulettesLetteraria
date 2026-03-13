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

        public void InseireLunghezza()
        {
            MessageBox.Show("inserire la lunghezza dderata della parola");

        }
            


        private async void btn_stampa_Click(object sender, RoutedEventArgs e)
        {
            if(btn_stampa.Content.ToString() == "Inizia")
            {
                btn_stampa.Content = "Stampa";
            

                while (true)
                {
                    lbl_stampa.Content = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "Z" }[new Random().Next(0, 21)];
                    await Task.Delay(100);
                }
            }
            if else(lsb_parole.Items.Count < )
            {
                
                
                lsb_parole.Items.Add(new ListBoxItem() { Content = lbl_stampa.Content.ToString() });
                
            }
        }
    }
}