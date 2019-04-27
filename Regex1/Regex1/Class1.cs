using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Regex1
{
    class Class1
    {
        public string IsDateTime(string text)
        {
            DateTime dateTime;
           // bool isDateTime = false;

            // Check for empty string.
            if (string.IsNullOrEmpty(text))
            {
                return " ";
            }

           string isDateTime = DateTime.TryParse(text, out dateTime).ToString();

            return isDateTime;
        }
    }
}
