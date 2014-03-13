using System;
namespace CSharpOptions
{
    public interface Option<out T>
    {
        bool HasValue { get; }

        T Value { get; }
    }


    struct Some<T> : Option<T>, IEquatable<Option<T>>
    {
        public Some(T value) : this()
        {
            Value = value;
            HasValue = true;
        }

        public bool HasValue { get; private set; }
        public T Value { get; private set; }

        public bool Equals(Option<T> other)
        {
            return other.HasValue && other.Value.Equals(Value);
        }
    }

    struct None<T> : Option<T>, IEquatable<Option<T>>
    {
        public bool HasValue { get { return false; } }
        public T Value { get { throw new Exception("No value"); } }

        public bool Equals(Option<T> other)
        {
            return !other.HasValue;
        }
    }
}
