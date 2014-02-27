using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public interface Option<out T>
    {
        T Get();
        bool IsDefined();
    }


    public struct Some<T> : Option<T>
    {
        private readonly T element;
        public Some(T element)
        {
            this.element = element;
        }

        public T Get()
        {
            return element;
        }

        public bool IsDefined() {
            return true;
        }
    }

    public struct None<T> : Option<T>
    {
        public T Get()
        {
            throw new NotSupportedException();
        }
        public bool IsDefined()
        {
            return false;
        }
    }

    public static class Option
    {

        public static Option<T> Of<T>(T element)
        {
            return element.AsOption();
        }

        public static Option<T> AsOption<T>(this T element)
        {
            if (element != null)
                return new Some<T>(element);
            return new None<T>();
        }

        public static Option<V> Map<T, V>(this Option<T> op, Func<T, V> f)
        {
            if (op.IsDefined())
                return new Some<V>(f(op.Get()));
            return new None<V>();
        }
    }

}
