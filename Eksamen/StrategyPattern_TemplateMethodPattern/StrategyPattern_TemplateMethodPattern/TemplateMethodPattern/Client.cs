using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_TemplateMethodPattern.TemplateMethodPattern
{
    public class Client
    {
        public static void ClientCode(AbstractClass abstractClass) {
            abstractClass.TemplateMethod();
        }
    }
}
