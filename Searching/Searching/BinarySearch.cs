using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public class BinarySearch
    {
        public string Binary (string searchItem, List<string> lines)
        {
            int index = lines.BinarySearch(searchItem);
            string result = string.Format("'{0}' found at index {1}", searchItem, index);
            return result;
        }
    }
}
