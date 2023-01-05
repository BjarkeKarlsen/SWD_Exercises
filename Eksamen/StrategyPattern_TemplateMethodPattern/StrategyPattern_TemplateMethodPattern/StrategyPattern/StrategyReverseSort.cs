using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_TemplateMethodPattern.StrategyPattern
{
    public class StrategyReverseSort : IStrategy
    {
        public List<string> execute(List<string> data) {
            data.Sort();
            data.Reverse();

            return data;
        }
    }
}
