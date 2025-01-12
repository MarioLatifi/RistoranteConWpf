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
using System.Windows.Shapes;

namespace EsempioWpf
{
    /// <summary>
    /// Logica di interazione per Ristorante.xaml
    /// </summary>
    public partial class RistoranteWpf : Window
    {
        Ristorante Ristorante;
        public RistoranteWpf(Ristorante r)
        {
            Ristorante = r;
            InitializeComponent();
            lblNomeRisto.Content = "Il nome del ristorante é: " + Ristorante;
            lblCopertiLiberi.Content = "Il numero di coperti disponibili é: " + Ristorante.CopertiDisponibili();
            lblTavoliLiberi.Content = "Tavoli Liberi: " + Ristorante.TavoliLiberi;
            lblTavoliPrenotati.Content = "Tavoli prenotati : " + Ristorante.TavoliPrenotati();
        }

        private void ClickPrenota(object sender, RoutedEventArgs e)
        {
            if(sender is Button) {
                try
                {
                    int numPersone = int.Parse(txtNumClienti.Text.ToString());
                    if (Ristorante.Prenota(txtNomeCliente.Text.ToString(), numPersone))//se riesco a prenotare
                    {
                        lblStato.Content = "Prenotazione\navvenuta con Successo!";
                        InitializeComponent();
                        lblNomeRisto.Content = "Il nome del ristorante é: " + Ristorante;
                        lblCopertiLiberi.Content = "Il numero di coperti disponibili é: " + Ristorante.CopertiDisponibili();
                        lblTavoliLiberi.Content = "Tavoli Liberi: " + Ristorante.TavoliLiberi;
                        lblTavoliPrenotati.Content = "Tavoli prenotati : " + Ristorante.TavoliPrenotati();
                    }
                    else
                    {
                        lblStato.Content = "Prenotazione Fallita\nsiamo spiacenti";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore nella creazione della prenotazione! verificare i dati inseriti"+ex.Message);
                }
                
            }
        }

        private void CleanTxt(object sender, RoutedEventArgs e)
        {
            if(sender is TextBox)
            {
                TextBox txt = (TextBox)sender;
                txt.Text = "";
            }
        }
    }
}
