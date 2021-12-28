using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection_Calculator.types
{
    public class BisectionPostRequest
    {
        public string equation { get; set; }
        public string ea { get; set; }
        public float places { get; set; }
        public float range { get; set; }
    }
}
