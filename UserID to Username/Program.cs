using System;
using System.Text;
using System.Drawing;
using Console = Colorful.Console;

namespace UserID_to_Username
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "UserID to Username || by root-404";
            Extensions.ASCII.AS();
            Extensions.ASCII.Infos();
            Console.WriteLine("");

            Console.WriteLine("Token: ", Color.Yellow);
            string Token = Console.ReadLine();
            Console.WriteLine("UserID: ", Color.Yellow);
            string UserID = Console.ReadLine();

            Extensions.Function._F(Token, UserID);
            Console.ReadKey();
        }
    }
}
