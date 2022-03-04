using System;
using System.Collections.Generic;
using System.Text;

namespace Telephone
{
    public interface ICallable
    {
        string Call(string phoneNumber);
    }
}
