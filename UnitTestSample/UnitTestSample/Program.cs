using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSample
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public int AddNumber(int x, int y)
        {
            return x + y;
        }
        public int SubNumber(int x, int y)
        {
            return x - y;
        }
        private string GetHoge(string value)
        {
            return $"{value}Hoge";
        }
    }
}
