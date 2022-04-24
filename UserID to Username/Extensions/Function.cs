using Leaf.xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text;
using Console = Colorful.Console;

namespace UserID_to_Username.Extensions
{
    public static class Function
    {
        public static string _F(string Token, string UserID)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string Value = null;

            /*Console.Write("Token: ");
            Token = Console.ReadLine();
            Console.Write("UserID: ");
            UserID = Console.ReadLine();
            
            */
            //Console.OutputEncoding = Encoding.UTF8;

            try
            {
                var R = new HttpRequest();
                R.AddHeader("Authorization", Token);
                R.AddHeader("Content-Type", "application/json");

                var Get = R.Get(config.URL + $"{UserID}" + config.URL2);
                var Infos = Get.ToString();


                dynamic Strukt = JsonConvert.DeserializeObject(Infos);

                Console.WriteLine(Infos);

                Console.WriteLine();

                Console.WriteLine("//////////////////////////", System.Drawing.Color.Red);

                Console.Write("");

                Console.WriteLine("UserID: " + Strukt.user.id, System.Drawing.Color.FromArgb(100, 0, 255, 0));

                Console.WriteLine("============================", System.Drawing.Color.Red);

                Console.WriteLine("Username & #: " + Strukt.user.username + "#" + Strukt.user.discriminator, System.Drawing.Color.FromArgb(100, 0, 255, 0));

                Console.WriteLine("============================", System.Drawing.Color.Red);

                Console.WriteLine("Biographie: " + Strukt.user.bio, System.Drawing.Color.FromArgb(100, 0, 255, 0));

                Console.WriteLine("============================", System.Drawing.Color.Red);

                Console.WriteLine("Public Flags: " + Strukt.user.public_flags, System.Drawing.Color.FromArgb(100, 0, 255, 0));

                Console.WriteLine("============================", System.Drawing.Color.Red);

                Console.WriteLine("Flags: " + Strukt.user.flags, System.Drawing.Color.FromArgb(100, 0, 255, 0));

                Console.WriteLine("============================", System.Drawing.Color.Red);

                Console.WriteLine("Avatar: " + Strukt.user.avatar, System.Drawing.Color.FromArgb(100, 0, 255, 0));

                Console.WriteLine("============================", System.Drawing.Color.Red);

                Console.WriteLine("Banner: " + Strukt.user.banner, System.Drawing.Color.FromArgb(100, 0, 255, 0));

                Console.WriteLine("============================", System.Drawing.Color.Red);

                Console.WriteLine("Banner Color: " + Strukt.user.banner_color + Strukt.user.discriminator, System.Drawing.Color.FromArgb(100, 0, 255, 0));

                Console.WriteLine("============================", System.Drawing.Color.Red);

                Console.WriteLine("Accent Color: " + Strukt.user.accent_color, System.Drawing.Color.FromArgb(100, 0, 255, 0));

                Console.WriteLine("============================", System.Drawing.Color.Red);

                Console.WriteLine("Flags: " + Strukt.user.flags, System.Drawing.Color.FromArgb(100, 0, 255, 0));

                Console.WriteLine("============================", System.Drawing.Color.Red);

                Console.WriteLine("Connected Accounts: " + Strukt.connected_accounts, System.Drawing.Color.FromArgb(100, 0, 255, 0));

                Console.WriteLine("============================", System.Drawing.Color.Red);

                Console.Write("");

                Console.WriteLine("//////////////////////////", System.Drawing.Color.Red);

                Console.WriteLine();

                Console.WriteLine("Made by root-404", System.Drawing.Color.Gold);

                //Console.WriteLine("DEBUG " + Infos);
            }
            catch (Exception ex) 
            {
                
            }

            return Value;
        }
    }
}
