using System;
using System.Collections.Generic;
using System.Text;

namespace TurntablTowers
{
    class NobodyHomeException : Exception
    {
        //public NobodyHomeException() { }
        public NobodyHomeException(string message) : base(message) { }
        public NobodyHomeException(string message, Exception innerException) 
            : base(message, innerException){ }
    }
}
