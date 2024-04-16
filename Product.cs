using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog122_S24_L4_Classes
{
    // In your new class
    // change "internal" to public
    public class Product
    {
        // Fields
        // Fields are variables that are associated with a class object
        // place underscore in front of your field titles (_fieldName)
        public string _title;
        public string _director;
        public string _rating;
        public decimal _price;

        // Constructor
        // new Product() <------ Default
        // A constructor is built like a method
        // BUT
        // - No return type
        // - Same EXACT name as class
        public Product(
            string title, 
            string director, 
            string rating, 
            decimal price)
        {
            _title = title;
            _director = director;
            _rating = rating;
            _price = price;
        }

        // Properties



    } // class

} // namespace
