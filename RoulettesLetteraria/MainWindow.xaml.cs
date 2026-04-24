using System;
using System.Threading.Tasks;
using System.Windows;

namespace RoulettesLetteraria
{
    public partial class MainWindow : Window
    {
        // Spostiamo qui le variabili per non ricrearle ogni millisecondo
        private readonly string[] _lettere = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        private readonly Random _generatoreRandom = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btn_stampa_Click(object sender, RoutedEventArgs e)
        {
            // Leggo la lunghezza massima impostata dall'utente
            int limiteMassimo = 0;
            int.TryParse(txt_lunghezza.Text, out limiteMassimo);

            // Se la casella è vuota, contiene lettere invece di numeri, o è uno zero: ERRORE!
            if (limiteMassimo <= 0)
            {
                MessageBox.Show("Errore: devi prima inserire una lunghezza massima valida!");  
                return; // Il comando 'return' fa fermare immediatamente il codice qui, così la roulette non parte.
            }

            if (btn_stampa.Content.ToString() == "Inizia")
            {
                btn_stampa.Content = "Stampa";

                // Faccio girare il ciclo finché il bottone dice "Stampa"
                while (btn_stampa.Content.ToString() == "Stampa")
                {
                    lbl_stampa.Content = _lettere[_generatoreRandom.Next(0, _lettere.Length)];
                    await Task.Delay(100);
                }
            }
            else
            {
                // Controllo per sicurezza che la label non sia vuota prima di catturare
                if (lbl_stampa.Content == null) return;

                string letteraCatturata = lbl_stampa.Content.ToString();

                // LOGICA PER ANDARE A CAPO:
                // Se la lista è vuota oppue l'ultima parola ha raggiunto il limite
                if (lsb_parole.Items.Count == 0 || lsb_parole.Items[lsb_parole.Items.Count - 1].ToString().Length >= limiteMassimo)
                {
                    // creo una nuova parola in una nuova riga
                    lsb_parole.Items.Add(letteraCatturata);
                }
                else
                {
                    // altrimenti, incollo la lettera alla parola che sto completando
                    int indiceUltimaParola = lsb_parole.Items.Count - 1;
                    string parolaCorrente = lsb_parole.Items[indiceUltimaParola].ToString();

                    lsb_parole.Items[indiceUltimaParola] = parolaCorrente + letteraCatturata;
                }
            }
        }

        private void btn_pulisci_Click(object sender, RoutedEventArgs e)
        {
            // Cancello tutte le lettere dalla lista
            lsb_parole.Items.Clear();

            // Riscrivo "Inizia" e svuoto la lavagna
            btn_stampa.Content = "Inizia";
            lbl_stampa.Content = "";
        }
    }
}