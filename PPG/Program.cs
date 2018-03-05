using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //The program is self-explanatory
            Console.Write("Decode or Encode[Any/Enter]?: ");
            ConsoleKeyInfo seLfexplanatory = Console.ReadKey();
            if (seLfexplanatory.Key == ConsoleKey.Enter)
            {
                SeLfExplanatory();
            }
            else
            {
                sElFExplanatory();
            }
            return;
        }

        private static void sElFExplanatory()
        {
            Console.Write("\nFile Path: ");
            string selfexplanatory = Console.ReadLine();
            Image selfExplanatory = new Bitmap(1, 1);
            try
            {
                selfExplanatory = Image.FromFile(selfexplanatory);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.Write("File not found.");
                Console.ReadKey();
            }
            catch (ArgumentException)
            {
                Console.Write("No file given");
                Console.ReadKey();
            }
            if (selfExplanatory.Size != new Size(16, 16))
            {
                Console.Write("Image Wrong Size. 16px by 16px only.");
                Console.ReadKey();
            }
            else
            {
                Bitmap SelfExplanatory = selfExplanatory as Bitmap;
                string self_explanatory = "";
                for (int sE = 0; sE < 16; sE++)
                {
                    for (int Se = 0; Se < 16; Se++)
                    {
                        if (SelfExplanatory.GetPixel(Se, sE).R != 0)
                        {
                            self_explanatory += "0";
                        }
                        else
                        {
                            self_explanatory += "1";
                        }
                    }
                }
                Console.WriteLine("Bits: {0}", self_explanatory);
                int seLfExplantory = self_explanatory.Length / 8;
                byte[] selFExplanatory = new byte[seLfExplantory];
                for (int sE = 0; sE < seLfExplantory; ++sE)
                {
                    selFExplanatory[sE] = Convert.ToByte(self_explanatory.Substring(8 * sE, 8), 2);
                }
                self_explanatory = Encoding.ASCII.GetString(selFExplanatory);
                Console.WriteLine("Full String: {0}", self_explanatory);
                Console.ReadKey();
            }
        }


        private static void SeLfExplanatory()
        {
            Console.Write("\nSequence [Max 16-char]: ");
            string selfexplanatory = Console.ReadLine();
            Console.WriteLine("Input: {0}", selfexplanatory);
            Random Self_Explanatory = new Random();
            while (selfexplanatory.Length < 16)
            {
                selfexplanatory += (char)Self_Explanatory.Next(0, 255);
            }
            for(int Es = 0; Es<16;Es+=2)
            {
                selfexplanatory.Insert(Es,(string)((char)Self_Explanatory.Next(0, 255)).ToString());
            }
            if (selfexplanatory.Length > 32)
            {
                selfexplanatory = selfexplanatory.Substring(0, 32);
            }
            Console.WriteLine("Full String: {0}", selfexplanatory);
            byte[] selfExplanatory = Encoding.ASCII.GetBytes(selfexplanatory);
            Console.Write("Bits: ");
            selfExplanatory.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')).ToList().ForEach(Console.Write);
            Bitmap SelfExplanatory = self_Explanatory(selfExplanatory);
            SelfExplanatory.Save(Environment.CurrentDirectory + "/" + DateTime.UtcNow.Ticks.ToString() + ".bmp");
            Console.ReadKey();
        }

        private static Bitmap self_Explanatory(byte[] selfExplanatory)
        {
            Bitmap selfexplanatory = new Bitmap(16, 16);
            string[] self_explanatory = selfExplanatory.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')).ToArray();
            for (int sE = 0; sE < (self_explanatory.Length / 2); sE++)
            {
                byte s_e = 0;
                foreach (char c in self_explanatory[2 * sE])
                {
                    selfexplanatory.SetPixel(s_e++, sE, c == '1' ? Color.Black : Color.White);
                }
                foreach (char c in self_explanatory[2 * sE + 1])
                {
                    selfexplanatory.SetPixel(s_e++, sE, c == '1' ? Color.Black : Color.White);
                }
            }
            return selfexplanatory;
        }
    }
}
