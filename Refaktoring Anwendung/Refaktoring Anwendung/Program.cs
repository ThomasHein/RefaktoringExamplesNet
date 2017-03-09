using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using soft.thein.de.refaktoring.datastore;

namespace soft.thein.de.refaktoring
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MySingleSuperClass superclass = new MySingleSuperClass();

                String[] answers = new String[] { "a", "b", "d" };
                DateTime today = DateTime.Now;


                Console.WriteLine("Master GUI: Bitte machen Sie ihre Eingabe für die Lotterie (3STück):");
                Console.Write("Email: ");
                String email = Console.ReadLine();
                Console.Write("Message:");
                String message = Console.ReadLine();
                Console.Write("CreditCar: ");
                String creditCardNumber = Console.ReadLine();

                int luckyNumber = new Random().Next() % 30;

                String result = superclass.getBestProgrammer(new DataStore().getProgrammers(), "Chef", answers, today, email, message, creditCardNumber, luckyNumber);
                Console.Write("Und der Gewinner ist " + result);
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ups " + ex.Message);
            }
        }
    }
}
