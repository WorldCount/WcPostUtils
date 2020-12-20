using System;

namespace WcApi.Finance
{
    public class Nds
    {
        private readonly double _nds;

        public Nds(int nds)
        {
            _nds = (double) nds / 100 + 1;
        }

        public double Plus(double sum)
        {
            return Math.Round(sum * _nds, 2);
        }

        public double Plus(int sum)
        {
            return Math.Round(sum * _nds, 2);
        }

        public double Minus(double sum)
        {
            return Math.Round(sum / _nds);
        }

        public double Minus(int sum)
        {
            return Math.Round(sum / _nds);
        }
    }
}
