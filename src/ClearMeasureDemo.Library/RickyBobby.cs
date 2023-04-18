using ClearMeasureDemo.Library.Models;
using System.Text;

namespace ClearMeasureDemo.Library
{
    public class RickyBobby : IRickyBobby
    {
        private IEnumerable<RuleModel> _rules;

        public RickyBobby(IEnumerable<RuleModel> rules)
        {
            _rules = rules;
        }

        public IEnumerable<string> Execute(int upperBound)
        {
            var result = new List<string>();

            for (int i = 1; i <= upperBound; i++)
            {
                var value = ExecuteRules(i);
                result.Add(value);
            }

            return result;
        }

        private string ExecuteRules(int val) 
        {
            var result = new StringBuilder();
            var wasExecuted = false;

            if (_rules != null)
            {
                foreach (var rule in _rules)
                {
                    if (val % rule.Input == 0)
                    {
                        result.Append(rule.Output);
                        wasExecuted = true;
                    }
                }
            }

            if (wasExecuted == false)
            {
                result.Append(val);
            }

            return result.ToString();
        }
    }
}