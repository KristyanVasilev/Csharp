using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephone
{
    public class Smartphone : ICallable, IBrowserable
    {
        private const string InvalidNumberException = "Invalid number!";
        private const string InvalidUrlException = "Invalid URL!";

        public string Browse(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                throw new ArgumentException(InvalidUrlException);
            }

            return $"Browsing: {url}!";
        }

        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(x => char.IsDigit(x)))
            {
                throw new ArgumentException(InvalidNumberException);
            }

            return phoneNumber.Length > 7 ? $"Calling... {phoneNumber}" : $"Dialing... {phoneNumber}";
        }
    }
}
