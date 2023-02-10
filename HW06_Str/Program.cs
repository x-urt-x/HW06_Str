using BenchmarkDotNet.Running;
using StrGeneratorNS;
using StingsBenchNS;

namespace HW06_Str
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StrGenerator.GenText("vsStr|i| = \"|text|\",", 5, 100);
            //StrGenerator.GenSum("vsStr|i| + ", 100);
            //StrGenerator.GenText("sStr|i| = \"|text|\",", 200, 200);
            //StrGenerator.GenSum("sStr|i| + ", 200);
            //StrGenerator.GenText("lStr|i| = \"|text|\",", 2000, 200);
            //StrGenerator.GenSum("lStr|i| + ", 200);
            //StrGenerator.GenText("\"|text|\",", 5, 100);
            //StrGenerator.GenText("\"|text|\",", 200, 200);
            //StrGenerator.GenText("\"|text|\",", 2000, 200);
            //StrGenerator.GenSum(".Append(vsStr|i|)", 100);
            //StrGenerator.GenSum(".Append(sStr|i|)", 200);
            //StrGenerator.GenSum(".Append(lStr|i|)", 200);
            //StrGenerator.GenSum(".Concat(vsStr|i|)",100);
            //StrGenerator.GenSum(".Concat(sStr|i|)",200);
            //StrGenerator.GenSum(".Concat(lStr|i|)", 200);


            BenchmarkRunner.Run<StingsBench>();
        }

    }
}