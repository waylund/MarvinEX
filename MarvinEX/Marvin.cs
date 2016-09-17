using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvinEX
{
    public class Marvin
    {
        public string talk(string statement)
        {
            if (String.IsNullOrWhiteSpace(statement))
                return "Fine. Don't say anything.";
            if (statement.ToUpper().Equals(statement))
                return "No need to yell. I'm right here.";
            if (statement.Substring(statement.Length-1, 1).Equals("?"))
                return "I don't care.";
            return "Whatever.";
        }
    }
}
