using BenchmarkDotNet.Attributes;
using StringsConcatNS;

namespace StingsBenchNS
{
    public class StingsBench
    {
        [Benchmark]
        public void VsStrSum()
        {
            StringsConcat.VsStrSum();
        }
        [Benchmark]
        public void SStrSum()
        {
            StringsConcat.SStrSum();
        }
        [Benchmark]
        public void LStrSum()
        {
            StringsConcat.LStrSum();
        }
        [Benchmark]
        public void VsStrCyc()
        {
            StringsConcat.VsStrCyc();
        }
        [Benchmark]
        public void SStrCyc()
        {
            StringsConcat.SStrCyc();
        }
        [Benchmark]
        public void LStrCyc()
        {
            StringsConcat.LStrCyc();
        }
        [Benchmark]
        public void VsSB()
        {
            StringsConcat.VsSB();
        }
        [Benchmark]
        public void SSB()
        {
            StringsConcat.SSB();
        }
        [Benchmark]
        public void LSB()
        {
            StringsConcat.LSB();
        }
        [Benchmark]
        public void VsStrConcat()
        {
            StringsConcat.VsStrConcat();
        }
        [Benchmark]
        public void SStrConcat()
        {
            StringsConcat.SStrConcat();
        }
        [Benchmark]
        public void LStrConcat()
        {
            StringsConcat.LStrConcat();
        }
    }
}
