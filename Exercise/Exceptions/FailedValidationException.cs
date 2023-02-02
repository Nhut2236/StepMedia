namespace Exercise.Exceptions
{
    public class FailedValidationException : Exception
    {
        public FailedValidationException(string message) : base(message)
        {
        }
        
        public FailedValidationException(string nameProperty, string message) : base(message)
        {
            NameProperty = nameProperty;
        }
        public string NameProperty { get; }
    }
}

