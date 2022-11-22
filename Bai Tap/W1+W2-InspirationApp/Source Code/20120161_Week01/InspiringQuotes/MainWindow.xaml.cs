using System;
using System.Collections.Generic;
using System.IO;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        class Quote
        {
            public string Content { get; set; }
            public string ImageUri { get; set; }

            public Quote()
            {
                Content = "";
                ImageUri = "";
            }
        }

        List<Quote> Quotes = new List<Quote>();

        private void loadData()
        {
            string filename = "data.txt";
            string[] lines = File.ReadAllLines(filename);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] tokens = lines[i].Split(new string[] { " - " }, StringSplitOptions.None);

                string content = tokens[0];
                string imageuri = tokens[1];

                var quote = new Quote()
                {
                    Content = content,
                    ImageUri = imageuri
                };

                Quotes.Add(quote);
            }
        }

        private void setButtonImage()
        {
            string baseUri = AppDomain.CurrentDomain.BaseDirectory;
            Image img = new Image();
            img.Source = new BitmapImage(new Uri($"{baseUri}/images/next.png", UriKind.Absolute));
            img.Height = 60;
            img.Width = 86;
            img.RenderTransformOrigin = new Point(0.544, 1.142);
            img.HorizontalAlignment = HorizontalAlignment.Center;
            img.VerticalAlignment = VerticalAlignment.Center;
            img.Stretch = Stretch.Uniform;
            img.Opacity = 0.7;

            StackPanel stackPnl = new StackPanel();
            stackPnl.Orientation = Orientation.Horizontal;
            stackPnl.HorizontalAlignment = HorizontalAlignment.Center;
            stackPnl.VerticalAlignment = VerticalAlignment.Center;
            stackPnl.Children.Add(img);

            nextQuoteButton.Content = stackPnl;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadData();
            setButtonImage();
            createQuote();
        }

        private void createQuote()
        { 
            int i = new Random().Next(0, Quotes.Count());

            quotesLabel.Content = string.Format(Quotes[i].Content,Environment.NewLine);

            // backGroundPicture.Source = new BitmapImage(new Uri(_images[i], UriKind.Relative));
            //this.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), Quotes[i].ImageUri)));
            
            string baseUri = AppDomain.CurrentDomain.BaseDirectory;
            string imageUri = Quotes[i].ImageUri;
            string uri = $"{baseUri}{imageUri}";
            this.Background = new ImageBrush(new BitmapImage(new Uri(uri, UriKind.Absolute)));
        }

        private void nextQuoteButton_Click(object sender, RoutedEventArgs e)
        {
            createQuote();
        }


    }
}
