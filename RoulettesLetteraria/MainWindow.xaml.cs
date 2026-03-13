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

        /* public void InseireLunghezza()
         {
             MessageBox.Show("inserire la lunghezza dderata della parola"); //pag 18 classi terze
             string lunghezza = txt_lunghezza.Text;
              if (int.TryParse(string lunghezza out int result))
              {
                  if (v > 0)
                  {

                      MessageBox.Show($"Lunghezza inserita: {v}");
                  }
                  else
                  {
                      MessageBox.Show("La lunghezza deve essere un numero positivo.");
                  }
              }
              else
              {
                  MessageBox.Show("Per favore, inserisci un numero valido per la lunghezza.");

             }*/




        private async void btn_stampa_Click(object sender, RoutedEventArgs e)
        {
            
            int limiteMassimo = 0;
            int.TryParse(txt_lunghezza.Text, out limiteMassimo);

            
            
            
            
            
            
            
            
            
            
            
            
            if (btn_stampa.Content.ToString() == "Inizia")
            {
                btn_stampa.Content = "Stampa";

                
                while (true)
                {
                    string[] lettere = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "Z" };
                    lbl_stampa.Content = lettere[new Random().Next(0, lettere.Length)]; //come massimo metti la lunghezz ainseritsa
                    
                    
                    await Task.Delay(100);
                }
            }
            
            else if (lsb_parole.Items.Count < limiteMassimo)
            {
                
                
                
                
                lsb_parole.Items.Add(lbl_stampa.Content.ToString());

            
            
            
            
            
            
            
            
            
            
            }
            else
            {
                MessageBox.Show("l max");
            }
        }
    }
}