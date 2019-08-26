using System;



namespace Desktop_PhotoshopOnMin.Exceptions
{
    public class ValueRGBException : ArgumentException
    {
        public double Value { get; }

        public ValueRGBException(string message, double value) 
            : base(message)
        {
            Value = value;
        } 
    }
}
