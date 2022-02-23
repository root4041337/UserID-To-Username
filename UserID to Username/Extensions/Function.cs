using Leaf.xNet;
using Newtonsoft.Json;
using System;
using System.Text;
using Console = Colorful.Console;

namespace UserID_to_Username.Extensions
{
    public static class Function
    {
        public static string _F()
        {
            string Value = null;
            string Token;
            string UserID;

            Console.Write("Token: ");
            Token = Console.ReadLine();
            Console.Write("UserID: ");
            UserID = Console.ReadLine();
            Console.OutputEncoding = Encoding.UTF8;

            var R = new HttpRequest();
            R.AddHeader("Authorization", Token);
            R.AddHeader("Content-Type", "application/json");

            var Get = R.Get(config.URL + UserID + config.URL2);
            string Infos = Get.ToString();

            dynamic Strukt = JsonConvert.DeserializeObject(Infos);

            Console.WriteLine();
            Console.WriteLine("//////////////////////////", System.Drawing.Color.Red);
            Console.Write("");
            Console.WriteLine("User Data: " + Strukt.user, System.Drawing.Color.FromArgb(100, 0, 255, 0));
            Console.WriteLine("============================", System.Drawing.Color.Red);
            Console.WriteLine("Connected Accounts: " + Strukt.connected_accounts, System.Drawing.Color.FromArgb(100,0,255,0));
            Console.WriteLine("============================", System.Drawing.Color.Red);
            Console.Write("");
            Console.WriteLine("//////////////////////////", System.Drawing.Color.Red);
            Console.WriteLine();

            Console.WriteLine("Made by root-404", System.Drawing.Color.Gold);

            //Console.WriteLine("DEBUG " + Infos);



            return Value;
        }
    }
}
