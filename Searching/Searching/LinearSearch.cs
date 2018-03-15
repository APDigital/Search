using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Searching
{
    public class LinearSearch
    {
        public string SearchLinear(string searchItem, List<string> lines)
        {
            string result = null;
            Regex regex = new Regex(searchItem, RegexOptions.IgnoreCase);
            foreach (var word in lines)
            {
                Match match = regex.Match(word);
                while (match.Success)
                {
                    Console.WriteLine("'{0}' found at index {1}", match.Value, match.Index);
                    match = match.NextMatch();

                    result = string.Format("'{0}' found at index {1}", match.Value, match.Index);
                }
            }
            return result;
        }
    }
}
