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

        private readonly bool hasValue;
        private readonly T value;

        public Some(T value) : this()
        {
            this.value = value;
            this.hasValue = true;
        }

        public bool HasValue { get {return hasValue; } }
        public T Value { get { return value;  } }

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
