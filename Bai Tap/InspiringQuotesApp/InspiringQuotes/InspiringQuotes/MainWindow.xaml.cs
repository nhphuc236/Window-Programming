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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InspiringQuotes
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

        List<string> _quotes;
        List<string> _images;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadData();
            createQuote();
        }

        private void createQuote()
        {
            int i = new Random().Next(0, _quotes.Count());
            quotesLabel.Content = _quotes[i];

            // backGroundPicture.Source = new BitmapImage(new Uri(_images[i], UriKind.Relative));
            
            this.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), _images[i])));
        }

        private void loadData()
        {
            _quotes = new List<string> {
                "It always seems imposible\n         until it's done",
                " Every day may not be good\n             but there is\nSomething good in every day",
                "Be the reason someone smiles today",
                "               Don't wait\nThe time will never be just right\n\n       One day or Day one ?",
                "Mistakes are proof that you are trying",
                "Stars can't shine without darkness",
                "    Fear is a reaction\nCourage is a decision",
                "We cannot become what we want\n      by remaining what we are",
                "If you can dream it\n    You can do it",
                "       If it was easy\nEveryone would do it"
            };

            _images = new List<string> {
                "/images/Image1.png",
                "/images/Image2.png",
                "/images/Image3.png",
                "/images/Image4.png",
                "/images/Image5.png",
                "/images/Image6.png",
                "/images/Image7.png",
                "/images/Image8.png",
                "/images/Image9.png",
                "/images/Image10.png"
            };
        }

        private void nextQuoteButton_Click(object sender, RoutedEventArgs e)
        {
            createQuote();
        }

      
    }
}
