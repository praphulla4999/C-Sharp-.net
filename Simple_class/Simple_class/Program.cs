using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Declaring new class
public class My_class
{
    private int data=2017;

    public int show_data()
    {
        return data;
    }

};

namespace Simple_class
{
    class Program
    {
        static void Main(string[] args)
        {
            My_class exmaple = new My_class();  // Creating object of My_Class

            Console.WriteLine(exmaple.show_data()); // Using show_data() function using class object
            Console.ReadKey();

        }
    }
}
