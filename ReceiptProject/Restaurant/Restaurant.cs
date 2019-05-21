using System;
using System.Collections.Generic;
using System.Text;

namespace ReceiptProject.Restaurant
{
    public class Restaurant
    {
        // instance variables ( lowercase for private instance )
        private string name;
        private string address;
        private double gratuityRate;
        private double taxRate;

        // properties for each private field ( capital for public properties )
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public double GratuityRate
        {
            get { return gratuityRate; }
            set
            {
                if (value > 0 ) // protecting against a negative rate
                {
                    gratuityRate = value;
                }
            }
        } 
        public double TaxRate
        {
            get { return taxRate; }
            set
            {
                if(value > 0)
                {
                    taxRate = value;
                }
            }

        }// end of properties

        // constructor
        public Restaurant ( string name, string address, double gratuityRate, double taxRate )
        {
            Name=name;
            Address=address;
            GratuityRate=gratuityRate;
            TaxRate=taxRate;

        } // end of constructor

        // method

        public void GenerateReceipt()
        {
            double price = 0;
            double subtotal = 0;
            double gratuityAmount = 0;
            double taxAmount = 0;
            double grandTotal = 0;
            int people = 0;

            while (price != -1 )
            {
                subtotal = subtotal + price;
                Console.Write ( "Enter price of Food Item: [-1 to quit ] " );
                price = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine ( "How many people in party?" );
            people=Convert.ToInt32 ( Console.ReadLine ( ) );

            if(people >= 6)
            {
                gratuityAmount = subtotal * gratuityRate;
            }

            if ( subtotal > 0 )
            {
                taxAmount = subtotal * taxRate;
            }

            grandTotal = subtotal + gratuityAmount + taxAmount;

            Console.WriteLine ( "Subtotal: {0 :C}", subtotal);
            Console.WriteLine ( "================================================" );
            Console.WriteLine ( "{0:P} Gratuity: {1:C}", gratuityRate, gratuityAmount );
            Console.WriteLine ( "================================================" );
            Console.WriteLine ( "{0:p} Tax: {1:C}", taxRate, taxAmount);
            Console.WriteLine ( "================================================" );
            Console.WriteLine ( "Grand Total: {0:C}", grandTotal );
            
        } 



    } // end of class
}
