using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSample.Models
{
    public class CalculateModel
    {
        public int addnum { get; set; } = 0;
        public int subnum { get; set; } = 0;

        public Result result { get; set; } = new Result();
    }
    public class Result
    {
        public bool isSuccess { get; set; } = false;
    }
}
