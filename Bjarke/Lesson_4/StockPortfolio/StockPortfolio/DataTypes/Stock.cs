using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockPortfolio.Subject;
using StockPortfolio.Interface;

namespace StockPortfolio.DataTypes
{
    public class Stock
    {

        public Stock()
        {
            Value = 0;
        }
        public Stock(string name, double amount, double value)
        {
            Name = name;
            Amount = amount;
            Value = value;
        }

        public Stock Update()
        {
            Value *= (new Random().NextDouble() * (_maxValue - _minValue) + _minValue);
            return this;
        }

        public void Update(ISubject<Stock> subject)
        {
            subject.SetData(Update());

        }
        private double _minValue = 0.95;
        private double _maxValue = 1.05;
        public string? Name { get; set; }
        public double Amount { get; set; }
        public double? Value { get; set; }


    }


}
