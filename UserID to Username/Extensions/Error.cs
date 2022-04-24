using System;
using System.Text;
using System.Drawing;
using Console = Colorful.Console;

namespace UserID_to_Username.Extensions
{
    public class Error
    {
        public void _Error()
        {
            Console.WriteLine("[-] Not a Valid UserID or Maybe Account Deleted?", Color.Red);
        }
    }
}
