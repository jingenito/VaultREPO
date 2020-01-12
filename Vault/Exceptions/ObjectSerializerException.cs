using System;

namespace Vault
{
    class ObjectSerializerException : Exception
    {
        public ObjectSerializerException()
        {

        }

        public ObjectSerializerException(string message) : base(message)
        {

        }

        public ObjectSerializerException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
