using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection_Calculator.types
{
    public class BracketFX
    {
        public float x { get; set; }
        public float fx { get; set; }
    }

    public class BracketJSON
    {
        public float x0 { get; set; }
        public float x1 { get; set; }
    }

    public class ResultJSON
    {
        public float x0 { get; set; }
        public float x1 { get; set; }
        public float x2 { get; set; }
        public float fx2 { get; set; }
        public float Ea { get; set; }
    }

    public class BracketResult
    {
        public BracketJSON bracket { get; set; }
        public ResultJSON[] results { get; set; }
    }

    public class BisectionPostResponse
    {
        public BracketFX[] fx_limit_values { get; set; }
        public BracketJSON[] possible_brackets { get; set; }
        public BracketResult[] bracket_results { get; set; }
        public string error { get; set; }
    }
}
