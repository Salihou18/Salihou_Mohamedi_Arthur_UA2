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

namespace Salihou_Mohamedi_Arthur_UA2
{
    /// <summary>
    /// Logique d'interaction pour CreationCompte.xaml
    /// </summary>
    public partial class CreationCompte : Window
    {
        public CreationCompte()
        {
            InitializeComponent();
        }
        /// <summary>
        /// fonctions pour gerer l'affichage des placeholder dans les textbox de la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Tapez votre nom ici")
            {
                textBox.Text = "";  //efface le texte d'espace réservé lorsque l'utilisateur clique sur le textbox
                textBox.Foreground = Brushes.Black;  // Change la couleur du texte
            }
        }

        private void AddText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Tapez votre nom ici";  //remet le placeholder dans le textbox dans le cas ou l'utilisateur ne saisi rien
                textBox.Foreground = Brushes.Gray;  //Change la couleur pour indiquer un espace réservé
            }

        }

        private void soumettre(object sender, RoutedEventArgs e)
        {
            // Réinitialiser le message d'erreur
            erreur.Content = string.Empty;

            // Vérifier si tous les champs obligatoires sont remplis
            if (string.IsNullOrWhiteSpace(nomUser.Text) || nomUser.Text == "Tapez votre nom ici" ||
                string.IsNullOrWhiteSpace(prenomUser.Text) ||
                string.IsNullOrWhiteSpace(mdp.Password) ||
                string.IsNullOrWhiteSpace(mdpRessaisi.Password))
            {
                erreur.Content = "Tous les champs marqués d'un * doivent être remplis.";
                return; // Sortir de la méthode si les champs ne sont pas remplis
            }

            // Vérifier si les mots de passe correspondent
            if (mdp.Password != mdpRessaisi.Password)
            {
                erreur.Content = "Les mots de passe ne correspondent pas.";
                return; // Sortir de la méthode si les mots de passe ne correspondent pas
            }

            // Si toutes les vérifications passent, continuez avec le traitement de soumission
            // ... Votre logique pour traiter la soumission
            MessageBox.Show("Compte créé avec succès !");
        }

        private void nomUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
