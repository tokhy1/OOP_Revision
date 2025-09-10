using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*



// 1. What is a constructor?
// A constructor is a special method that runs automatically when an object of the class is created.
// If the constructor has parameters, we must provide arguments when creating the object.
// Constructors can also have no parameters.

// 2. Constructor overloading
// Sometimes we don’t need all the parameters that one constructor requires.
// Constructor overloading allows us to define multiple constructors in the same class
// with the same name but different parameter lists.
// This gives us flexibility when creating objects.


*/
namespace c_.Basic_Concepts
{
    // here we will create pizza class for making our customized pizaa
    // to customize our pizza we need to choose the type, size, toppings, sauce of the pizza
    // and how many of this pizza
    class Pizza
    {
        // make some private fields so objects can't be accessed directly(we will learn about that more in Encapsulation)

        private string type, size, topping, sauce;
        private int quantity;
        public Pizza(string type, string size, string topping, string sauce, int quantity)
        {
            // i am using "this" keyword because because i need the compiler to understand that i need to access the field not the parameter
            this.type = type;
            this.size = size;
            this.topping = topping;
            this.sauce = sauce;
            this.quantity = quantity;
        }
        // here we can that there is customers that wont need the pizza with sauce so we will need to enter sauce
        // argument when we take object from the class but at the same time we must enter values
        // for all the paramters tha the constructor has, so here the constructor overloading role wiil come

        public Pizza(string type, string size, string topping,int quantity)
        //This constructor allows creating a pizza without specifying sauce, since some customers may not want it.
        {
            this.type = type;
            this.size = size;
            this.topping = topping;
            this.quantity = quantity;
        }
        //here is a method for describing our pizza 
        public void Describe()
        {
            Console.WriteLine($"Pizza: {quantity}x {size} {type} with {topping}" +
                              (string.IsNullOrEmpty(sauce) ? "" : $" and {sauce} sauce"));
        }

    }



    class ClassConstructor
    {
        public static void DemoConstructors()
        {
            Pizza pizza1 = new Pizza("pan", "large", "mushrooms", "BBQ", 3); //here we are having
                                                                             //object from the our class and as we explained we must enter arguments for the parameters of the constructor
            pizza1.Describe();
            /////////////////////////////////////

            Pizza pizzaNoSauce = new Pizza("pan", "medium", "beef bacon", 2); //here we will create object for a pizza with no sauce
            pizzaNoSauce.Describe();
        }
    }
}
