using System;

namespace Dinaf.Sismo.Domain.Common.Exceptions
{
    public class InvalidValueObjectException : Exception
    {
        public InvalidValueObjectException(string message) : base(message)
        {

        }
    }
}