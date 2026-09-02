using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangoAway
{
    internal class Program
    {
        static string itemlist = "Dango, Mochi, Anmitsu, Dorayaki, Taiyaki, Daifuku, Yokan";
        static string itemDescription = "Dango: A Japanese dumpling made from rice flour, often served on a skewer.\n" +
            "Mochi: A Japanese rice cake made from glutinous rice, often filled with sweet red bean paste.\n" +
            "Anmitsu: A traditional Japanese dessert made with agar jelly, fruits, and sweet syrup.\n" +
            "Dorayaki: A Japanese confection consisting of two small pancake-like patties filled with sweet red bean paste.\n" +
            "Taiyaki: A fish-shaped cake filled with sweet fillings such as red bean paste or custard.\n" +
            "Daifuku: A Japanese confection consisting of a small round mochi stuffed with sweet filling, usually anko (sweetened red bean paste).\n" +
            "Yokan: A thick, jellied dessert made of red bean paste, agar, and sugar.\n";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DangoAway! Here are the items we have available:");
            Console.WriteLine(itemlist);
            Console.WriteLine(itemDescription);

        }
    }
}
