using System;
using System.Collections.Generic;
using System.Linq;
using TestNet6.Interfaces;

namespace TestNet6.Services
{
    class ValidateInjection : IValidateInjection
    {
        private Dictionary<string, Shape> _shapes;
        public ValidateInjection(IEnumerable<Shape> shapes)
        {
            _shapes = shapes.ToDictionary(s => s.ClassObjective);
        }

        public void PrintEnumeratedValuesToConsole()
        {
            foreach (KeyValuePair<string, Shape> entry in _shapes)
            {
                Console.WriteLine("Key:" + entry.Key + " \tValue:" + entry.Value);
            }
        }
    }
}
