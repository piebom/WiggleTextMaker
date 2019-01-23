using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace wiggle
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string wiggletekst = "";
            Console.WriteLine("Give a word!");

            string word = Console.ReadLine();
            Console.WriteLine("Give a lenght!");

            string lengte = Console.ReadLine();
            int aantalspaties = 0;
            bool richting = false;
            string spaties = "";
            Console.Write(Environment.NewLine);
            Console.Write("----------------------------------------------------------------------------------------------------------------------");
            Console.Write(Environment.NewLine);
            for (int i = 0; i<Convert.ToInt32(lengte);i++)
            {
                spaties = "";
                for (int x = 0; x<= aantalspaties;x++)
                {

                    spaties += " ";
                }
                if(aantalspaties/7 == 1)
                {
                    richting = true;
                    Console.Write(spaties + word + Environment.NewLine);
                    Console.Write(spaties + word + Environment.NewLine);
                    wiggletekst += spaties + word + Environment.NewLine;
                    wiggletekst += spaties + word + Environment.NewLine;
                }
                else if( aantalspaties == 0)
                {
                    richting = false;
                    Console.Write(spaties + word + Environment.NewLine);
                    Console.Write(spaties + word + Environment.NewLine);
                    wiggletekst += spaties + word + Environment.NewLine;
                    wiggletekst += spaties + word + Environment.NewLine;
                }
                if (richting == true)
                {
                    aantalspaties -= 1;
                }
                else
                {
                    aantalspaties += 1;
                }
                Console.Write(spaties + word +Environment.NewLine);
                wiggletekst += spaties + word + Environment.NewLine;
            }
            Clipboard.SetText(wiggletekst);
            Console.Write(Environment.NewLine);
            Console.Write("Text copied to clipboard! HAVE FUN");
            Console.Read();
        }
    }
}
