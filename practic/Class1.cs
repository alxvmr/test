using System;
using System.Collections.Generic;
using System.Text;

namespace practic
{
    class Calc
    {
        public double add(double a, double b)
        {
            return a + b;
        }

        public double subtract(double a, double b)
        {
            return a - b;
        }

        public double multiply(double a, double b)
        {
            return a * b;
        }

        public double divice(double a, double b)
        {
            return a / b;
        }
    }

    class Ticket
    {
        public bool lucky_ticket(string s)
        {
            if (s.Length != 6)
                throw new Exception("Invalid ticket");
            return (((s[0] - '0') + (s[1] - '0') + (s[2] - '0')) == ((s[3] - '0') + (s[4] - '0') + (s[5] - '0')));
        }
    }
}
