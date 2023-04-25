using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalAssestmentEstebanHidalgo
{
    class LastNameComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            // Split the names into first and last names
            string[] xParts = x.Split(' ');
            string[] yParts = y.Split(' ');

            // Compare the last names
            int result = xParts[xParts.Length - 1].CompareTo(yParts[yParts.Length - 1]);

            // If the last names are the same, compare the first names
            if (result == 0)
            {
                result = xParts[0].CompareTo(yParts[0]);
            }

            return result;
        }
    }
}