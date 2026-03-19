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

            //leggo la lunghezza massima impostata dall'utente e faccio un controllo
            int limiteMassimo = 0;
            int.TryParse(txt_lunghezza.Text, out limiteMassimo);

           if (btn_stampa.Content.ToString() == "Inizia")
           {
                btn_stampa.Content = "Stampa";

                //faccio girare il ciclo solo finché il bottone dice "Stampa".
                while (btn_stampa.Content.ToString() == "Stampa")
                {
                    string[] lettere = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
                    lbl_stampa.Content = lettere[new Random().Next(0, lettere.Length)]; //come massimo metto la lunghezz ainserita dall'utente


                    await Task.Delay(100);
                }
           }
            
            else if (lsb_parole.Items.Count < limiteMassimo)
            {
                //aggiungo la lettera alla lista se non ho ancora raggiunto li limite
                lsb_parole.Items.Add(lbl_stampa.Content.ToString());

            }
            else
            {   
                MessageBox.Show($"Lunghezza massima della parola raggiunta!");
            }
        }

        private void btn_pulisci_Click(object sender, RoutedEventArgs e)
        {
        
            //cancello tutte le lettere dalla lista
            lsb_parole.Items.Clear();

            //riscrivo "inizia" anziche "stampa" perche ho riniiziato 
            btn_stampa.Content = "Inizia";
            
        }
    }
}