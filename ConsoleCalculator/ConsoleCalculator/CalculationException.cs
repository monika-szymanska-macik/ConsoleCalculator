﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    class CalculationException : Exception
    {
        private static readonly string DefaultMessage =
            "An error occured during calculation. Ensure that the oparator is supported " +
            "and that the values are within the valid ranges for the requested operation.";
        public CalculationException() : base(DefaultMessage)
        {

        }

        public CalculationException(string message) : base(message)
        {

        }

        public CalculationException(Exception innerException) : base(DefaultMessage, innerException)
        {

        }

        public CalculationException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
