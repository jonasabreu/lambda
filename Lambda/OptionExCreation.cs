namespace CSharpOptions
{
    public static class Option
    {
        public static Option<T> Create<T>(T value)
        {
            if (value == null) return default(None<T>);
            return new Some<T>(value);
        }

        public static Option<T> None<T>()
        {
            return default(None<T>);
        }

        public static Option<T> From<T>(T value)
        {
            return value == null ? None<T>() : new Some<T>(value);
        }

        public static Option<T> ToOption<T>(this T value)
        {
            return From(value);
        }
    }
}