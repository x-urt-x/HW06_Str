using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrGeneratorNS
{

    static public class StrGenerator
    {
        static readonly Char[] Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!#$%&()*+,—./0123456789:;<=>?@[]^_{|}~".ToCharArray();
        static Random rand = new Random();
        static public void GenText(string patern, int len, int quan)
        {
            StringBuilder sb = new StringBuilder(len);
            for (int i = 0; i < quan; i++)
            {
                Console.WriteLine(patern.Replace("|i|", i.ToString()).Replace("|text|", RandomStr(sb, len)));
            }
        }
        static string RandomStr(StringBuilder sb, int len)
        {
            sb.Clear();
            for (int i = 0; i < len; i++)
            {
                sb.Append(Letters[rand.Next(0, Letters.Length - 1)]);
            }
            return sb.ToString();
        }
        static public void GenSum(string patern, int quan)
        {
            for (int i = 0; i < quan; i++)
            {
                Console.Write(patern.Replace("|i|", i.ToString()));
            }
        }

    }
}
