using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_TemplateMethodPattern.StrategyPattern
{
    public class Context
    {
        private IStrategy? _strategy;
        
        public Context() {

        }

        // Usually, the Context accepts a strategy through the constructor, but
        // also provides a setter to change it at runtime.
        public Context(IStrategy strategy) {
            _strategy = strategy;
        }
        public void SetStrategy(IStrategy strategy) {
            _strategy = strategy;
        }


        // The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public void ExecuteStrategy(List<string> data) {
            if (_strategy == null)
                return;

            var dataProcessed  = _strategy.execute(data);

            var resultStr = string.Empty;

            foreach (var item in dataProcessed) {
                resultStr += item + ",";
            }

            Console.WriteLine(resultStr);
        }
    }
}
