using System;

namespace Prime.Services
{
    public class FirstName
    {
        private const int MinLength = 1;
        private const int MaxLength = 50;

        public void ValidateName(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name), "First name cannot be null.");
            }

            int length = name.Length;

            if (length < MinLength || length > MaxLength)
            {
                throw new ArgumentException($"First name length must be between {MinLength} and {MaxLength} characters.", nameof(name));
            }

        }
    }
}