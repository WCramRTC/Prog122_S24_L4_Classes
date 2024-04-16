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

namespace Prog122_S24_L4_Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Product[] myMovies = new Product[4];

        public MainWindow()
        {
            InitializeComponent();

            // Creating an INSTANCE of our class
            // We have created a variable name "movie1" relating to an EMPTY product object
            Product movie1 = new Product("Paprika", "Satoshi Kon", "R", 27.99m);
            myMovies[0] = movie1;
            //movie1._title = "Paprika";
            //movie1._price = 27.99m;
            //movie1._rating = "R";
            //movie1._director = "Satoshi Kon";

            //Product charlesMovie = new Product();
            Product charlesMovie = new Product("El Darado", "Howard Hawks", "NR", 14.99m);
            myMovies[1] = charlesMovie;
            //charlesMovie._title = "El Darado";
            //charlesMovie._director = "Howard Hawks";
            //charlesMovie._rating = "NR";
            //charlesMovie._price = 14.99m;

            Product rafhaelMovie = new Product("Reel Steel", "Hugh Jackman", "PG-13", 17.99m);
            myMovies[2] = rafhaelMovie;
            // director - satoshi kon
            // price - 27.99
            // rating - r

            myMovies[3] = new Product("Robocop (89)", "Paul Verhoven", "R", 14.00m);

            for(int i = 0; i < myMovies.Length; i++)
            {
                Product selectedMovie = myMovies[i];
                DisplayMovie(selectedMovie);
            }


            //DisplayMovie(charlesMovie);

        }

        public void DisplayMovie(Product movie)
        {
            
            runDisplay.Text += "Title: " + movie._title + "\n";
            runDisplay.Text += $"Director: {movie._director}\n";
            runDisplay.Text += $"Rating: {movie._rating}\n";
            runDisplay.Text += $"Price: {movie._price.ToString("c")}\n";
            runDisplay.Text += "\n";
        }

        // Classes
        // In Objected Oriented Programming are how we define what a collection of data and actions look like to the computer

        // Business Case

    }


}