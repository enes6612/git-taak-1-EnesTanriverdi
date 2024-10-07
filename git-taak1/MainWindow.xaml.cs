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

namespace git_taak1
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

        private void duneImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string duneTitle = "Dune: Part Two";
            string duneText = "Paul Atreides unites with Chani and the Fremen while seeking revenge against the conspirators who destroyed his family.";

            if (e.ClickCount == 2)
            {
                resultTextBlock.Text = $@"Title: {duneTitle}
Short discription: {duneText}";
            }

        }
        private void substanceImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string substanceTitle = "The Substance";
            string substanceText = "A fading celebrity decides to use a black-market drug, a cell-replicating substance that temporarily creates a younger, better version of herself.";

            if (e.ClickCount == 2)
            {
                resultTextBlock.Text = $@"Title: {substanceTitle}
Short discription: {substanceText}";
            }
        }

        private void furiosaImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string furiosaTitle = "Furiosa: A Mad Max Saga";
            string furiosaText = "The origin story of renegade warrior Furiosa before her encounter and teamup with Mad Max.";


            if (e.ClickCount == 2)
            {
                resultTextBlock.Text = $@"Title: {furiosaTitle}
Short discription: {furiosaText}";
            }
        }
    }
}
