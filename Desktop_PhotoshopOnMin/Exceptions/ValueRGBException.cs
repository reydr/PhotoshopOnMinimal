using System;



namespace Desktop_PhotoshopOnMin.Exceptions
{
    public class ArgumentRGBException : ArgumentException
    {
        public double Value { get; }

        public ArgumentRGBException(string message, double value) 
            : base(message)
        {
            Value = value;
        } 
    }
}
