using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOptions
{
    public static class OptionExLinq
    {
        public static Option<B> SelectMany<T, B>(this Option<T> option, Func<T, Option<B>> func)
        {
            return option.FlatMap(func);
        }

        public static Option<B> Select<T, B>(this Option<T> option, Func<T, B> func)
        {
            return option.Map(func);
        }

        public static Option<V> SelectMany<T, U, V>(this Option<T> option, Func<T, Option<U>> func, Func<T, U, V> resultFunc)
        {
            return option.SelectMany(x => func(x).SelectMany(y => Option.Create(resultFunc(x, y))));
        }

        public static Option<T> Where<T>(this Option<T> option, Func<T, Boolean> predicate)
        {
            return option.Filter(predicate);
        }

    }
}