using System;

namespace ReceiptProject.Restaurant
{
    class Program
    {
        public static void Main ( string[ ] args )
        {
            Restaurant obj = new Restaurant ( "Dairy Queen", "123 Main St.", .15, .0725 );

            Console.WriteLine ( "=============={0}==============", DateTime.Now );
            Console.WriteLine ( "=====================CASHIER====================" );

            Console.WriteLine ( "{0}", obj.Name );
            Console.WriteLine ( "{0}", obj.Address );
            Console.WriteLine ( "================================================" );

            obj.GenerateReceipt ( );
            Console.WriteLine ( "==================END RECEIPT===================" );


        }
    }
}
