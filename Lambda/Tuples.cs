using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdaInternal;

namespace LambdaInternal
{
    public interface Product<out T0> { };
    public interface Product<out T0, out T1> { };
    public interface Product<out T0, out T1, out T2> { };
    public interface Product<out T0, out T1, out T2, out T3> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4, out T5> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4, out T5, out T6> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15, out T16> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15, out T16, out T17> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15, out T16, out T17, out T18> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15, out T16, out T17, out T18, out T19> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15, out T16, out T17, out T18, out T19, out T20> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15, out T16, out T17, out T18, out T19, out T20, out T21> { };
    public interface Product<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15, out T16, out T17, out T18, out T19, out T20, out T21, out T22> { };
}

namespace Lambda
{
    public static class _
    {
        public static Tuple<T0> t<T0>(T0 _1)
        {
            return new Tuple<T0>(_1);
        }
        public static Tuple<T0, T1> t<T0, T1>(T0 _1, T1 _2)
        {
            return new Tuple<T0, T1>(_1, _2);
        }
        public static Tuple<T0, T1, T2> t<T0, T1, T2>(T0 _1, T1 _2, T2 _3)
        {
            return new Tuple<T0, T1, T2>(_1, _2, _3);
        }
        public static Tuple<T0, T1, T2, T3> t<T0, T1, T2, T3>(T0 _1, T1 _2, T2 _3, T3 _4)
        {
            return new Tuple<T0, T1, T2, T3>(_1, _2, _3, _4);
        }
        public static Tuple<T0, T1, T2, T3, T4> t<T0, T1, T2, T3, T4>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5)
        {
            return new Tuple<T0, T1, T2, T3, T4>(_1, _2, _3, _4, _5);
        }
        public static Tuple<T0, T1, T2, T3, T4, T5> t<T0, T1, T2, T3, T4, T5>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6)
        {
            return new Tuple<T0, T1, T2, T3, T4, T5>(_1, _2, _3, _4, _5, _6);
        }
        public static Tuple<T0, T1, T2, T3, T4, T5, T6> t<T0, T1, T2, T3, T4, T5, T6>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7)
        {
            return new Tuple<T0, T1, T2, T3, T4, T5, T6>(_1, _2, _3, _4, _5, _6, _7);
        }
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, T7> t<T0, T1, T2, T3, T4, T5, T6, T7>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8)
        {
            return new Tuple<T0, T1, T2, T3, T4, T5, T6, T7>(_1, _2, _3, _4, _5, _6, _7, _8);
        }
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8> t<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9)
        {
            return new Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8>(_1, _2, _3, _4, _5, _6, _7, _8, _9);
        }
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10)
        {
            return new Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10);
        }
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11)
        {
            return new Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11);
        }
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12)
        {
            return new Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12);
        }
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13)
        {
            return new Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13);
        }
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14)
        {
            return new Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14);
        }
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14, T14 _15)
        {
            return new Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15);
        }
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14, T14 _15, T15 _16)
        {
            return new Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16);
        }
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> t<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14, T14 _15, T15 _16, T16 _17)
        {
            return new Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17);
        }
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> t<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14, T14 _15, T15 _16, T16 _17, T17 _18)
        {
            return new Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18);
        }
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> t<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14, T14 _15, T15 _16, T16 _17, T17 _18, T18 _19)
        {
            return new Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19);
        }
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> t<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14, T14 _15, T15 _16, T16 _17, T17 _18, T18 _19, T19 _20)
        {
            return new Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20);
        }
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> t<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14, T14 _15, T15 _16, T16 _17, T17 _18, T18 _19, T19 _20, T20 _21)
        {
            return new Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21);
        }
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> t<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14, T14 _15, T15 _16, T16 _17, T17 _18, T18 _19, T19 _20, T20 _21, T21 _22)
        {
            return new Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22);
        }
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> t<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14, T14 _15, T15 _16, T16 _17, T17 _18, T18 _19, T19 _20, T20 _21, T21 _22, T22 _23)
        {
            return new Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23);
        }
    }
    public struct Tuple<T0> : Product<T0>
    {
        public readonly T0 _1;
        public Tuple(T0 _1)
        {
            this._1 = _1;
        }
    }

    public struct Tuple<T0, T1> : Product<T0, T1>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public Tuple(T0 _1, T1 _2)
        {
            this._1 = _1;
            this._2 = _2;
        }
    }

    public struct Tuple<T0, T1, T2> : Product<T0, T1, T2>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public Tuple(T0 _1, T1 _2, T2 _3)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
        }
    }

    public struct Tuple<T0, T1, T2, T3> : Product<T0, T1, T2, T3>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4> : Product<T0, T1, T2, T3, T4>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4, T5> : Product<T0, T1, T2, T3, T4, T5>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public readonly T5 _6;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
            this._6 = _6;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4, T5, T6> : Product<T0, T1, T2, T3, T4, T5, T6>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public readonly T5 _6;
        public readonly T6 _7;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
            this._6 = _6;
            this._7 = _7;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4, T5, T6, T7> : Product<T0, T1, T2, T3, T4, T5, T6, T7>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public readonly T5 _6;
        public readonly T6 _7;
        public readonly T7 _8;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
            this._6 = _6;
            this._7 = _7;
            this._8 = _8;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8> : Product<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public readonly T5 _6;
        public readonly T6 _7;
        public readonly T7 _8;
        public readonly T8 _9;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
            this._6 = _6;
            this._7 = _7;
            this._8 = _8;
            this._9 = _9;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : Product<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public readonly T5 _6;
        public readonly T6 _7;
        public readonly T7 _8;
        public readonly T8 _9;
        public readonly T9 _10;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
            this._6 = _6;
            this._7 = _7;
            this._8 = _8;
            this._9 = _9;
            this._10 = _10;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : Product<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public readonly T5 _6;
        public readonly T6 _7;
        public readonly T7 _8;
        public readonly T8 _9;
        public readonly T9 _10;
        public readonly T10 _11;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
            this._6 = _6;
            this._7 = _7;
            this._8 = _8;
            this._9 = _9;
            this._10 = _10;
            this._11 = _11;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : Product<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public readonly T5 _6;
        public readonly T6 _7;
        public readonly T7 _8;
        public readonly T8 _9;
        public readonly T9 _10;
        public readonly T10 _11;
        public readonly T11 _12;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
            this._6 = _6;
            this._7 = _7;
            this._8 = _8;
            this._9 = _9;
            this._10 = _10;
            this._11 = _11;
            this._12 = _12;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : Product<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public readonly T5 _6;
        public readonly T6 _7;
        public readonly T7 _8;
        public readonly T8 _9;
        public readonly T9 _10;
        public readonly T10 _11;
        public readonly T11 _12;
        public readonly T12 _13;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
            this._6 = _6;
            this._7 = _7;
            this._8 = _8;
            this._9 = _9;
            this._10 = _10;
            this._11 = _11;
            this._12 = _12;
            this._13 = _13;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : Product<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public readonly T5 _6;
        public readonly T6 _7;
        public readonly T7 _8;
        public readonly T8 _9;
        public readonly T9 _10;
        public readonly T10 _11;
        public readonly T11 _12;
        public readonly T12 _13;
        public readonly T13 _14;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
            this._6 = _6;
            this._7 = _7;
            this._8 = _8;
            this._9 = _9;
            this._10 = _10;
            this._11 = _11;
            this._12 = _12;
            this._13 = _13;
            this._14 = _14;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : Product<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public readonly T5 _6;
        public readonly T6 _7;
        public readonly T7 _8;
        public readonly T8 _9;
        public readonly T9 _10;
        public readonly T10 _11;
        public readonly T11 _12;
        public readonly T12 _13;
        public readonly T13 _14;
        public readonly T14 _15;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14, T14 _15)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
            this._6 = _6;
            this._7 = _7;
            this._8 = _8;
            this._9 = _9;
            this._10 = _10;
            this._11 = _11;
            this._12 = _12;
            this._13 = _13;
            this._14 = _14;
            this._15 = _15;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : Product<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public readonly T5 _6;
        public readonly T6 _7;
        public readonly T7 _8;
        public readonly T8 _9;
        public readonly T9 _10;
        public readonly T10 _11;
        public readonly T11 _12;
        public readonly T12 _13;
        public readonly T13 _14;
        public readonly T14 _15;
        public readonly T15 _16;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14, T14 _15, T15 _16)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
            this._6 = _6;
            this._7 = _7;
            this._8 = _8;
            this._9 = _9;
            this._10 = _10;
            this._11 = _11;
            this._12 = _12;
            this._13 = _13;
            this._14 = _14;
            this._15 = _15;
            this._16 = _16;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : Product<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public readonly T5 _6;
        public readonly T6 _7;
        public readonly T7 _8;
        public readonly T8 _9;
        public readonly T9 _10;
        public readonly T10 _11;
        public readonly T11 _12;
        public readonly T12 _13;
        public readonly T13 _14;
        public readonly T14 _15;
        public readonly T15 _16;
        public readonly T16 _17;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14, T14 _15, T15 _16, T16 _17)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
            this._6 = _6;
            this._7 = _7;
            this._8 = _8;
            this._9 = _9;
            this._10 = _10;
            this._11 = _11;
            this._12 = _12;
            this._13 = _13;
            this._14 = _14;
            this._15 = _15;
            this._16 = _16;
            this._17 = _17;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> : Product<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public readonly T5 _6;
        public readonly T6 _7;
        public readonly T7 _8;
        public readonly T8 _9;
        public readonly T9 _10;
        public readonly T10 _11;
        public readonly T11 _12;
        public readonly T12 _13;
        public readonly T13 _14;
        public readonly T14 _15;
        public readonly T15 _16;
        public readonly T16 _17;
        public readonly T17 _18;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14, T14 _15, T15 _16, T16 _17, T17 _18)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
            this._6 = _6;
            this._7 = _7;
            this._8 = _8;
            this._9 = _9;
            this._10 = _10;
            this._11 = _11;
            this._12 = _12;
            this._13 = _13;
            this._14 = _14;
            this._15 = _15;
            this._16 = _16;
            this._17 = _17;
            this._18 = _18;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> : Product<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public readonly T5 _6;
        public readonly T6 _7;
        public readonly T7 _8;
        public readonly T8 _9;
        public readonly T9 _10;
        public readonly T10 _11;
        public readonly T11 _12;
        public readonly T12 _13;
        public readonly T13 _14;
        public readonly T14 _15;
        public readonly T15 _16;
        public readonly T16 _17;
        public readonly T17 _18;
        public readonly T18 _19;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14, T14 _15, T15 _16, T16 _17, T17 _18, T18 _19)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
            this._6 = _6;
            this._7 = _7;
            this._8 = _8;
            this._9 = _9;
            this._10 = _10;
            this._11 = _11;
            this._12 = _12;
            this._13 = _13;
            this._14 = _14;
            this._15 = _15;
            this._16 = _16;
            this._17 = _17;
            this._18 = _18;
            this._19 = _19;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> : Product<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public readonly T5 _6;
        public readonly T6 _7;
        public readonly T7 _8;
        public readonly T8 _9;
        public readonly T9 _10;
        public readonly T10 _11;
        public readonly T11 _12;
        public readonly T12 _13;
        public readonly T13 _14;
        public readonly T14 _15;
        public readonly T15 _16;
        public readonly T16 _17;
        public readonly T17 _18;
        public readonly T18 _19;
        public readonly T19 _20;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14, T14 _15, T15 _16, T16 _17, T17 _18, T18 _19, T19 _20)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
            this._6 = _6;
            this._7 = _7;
            this._8 = _8;
            this._9 = _9;
            this._10 = _10;
            this._11 = _11;
            this._12 = _12;
            this._13 = _13;
            this._14 = _14;
            this._15 = _15;
            this._16 = _16;
            this._17 = _17;
            this._18 = _18;
            this._19 = _19;
            this._20 = _20;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> : Product<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public readonly T5 _6;
        public readonly T6 _7;
        public readonly T7 _8;
        public readonly T8 _9;
        public readonly T9 _10;
        public readonly T10 _11;
        public readonly T11 _12;
        public readonly T12 _13;
        public readonly T13 _14;
        public readonly T14 _15;
        public readonly T15 _16;
        public readonly T16 _17;
        public readonly T17 _18;
        public readonly T18 _19;
        public readonly T19 _20;
        public readonly T20 _21;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14, T14 _15, T15 _16, T16 _17, T17 _18, T18 _19, T19 _20, T20 _21)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
            this._6 = _6;
            this._7 = _7;
            this._8 = _8;
            this._9 = _9;
            this._10 = _10;
            this._11 = _11;
            this._12 = _12;
            this._13 = _13;
            this._14 = _14;
            this._15 = _15;
            this._16 = _16;
            this._17 = _17;
            this._18 = _18;
            this._19 = _19;
            this._20 = _20;
            this._21 = _21;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> : Product<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public readonly T5 _6;
        public readonly T6 _7;
        public readonly T7 _8;
        public readonly T8 _9;
        public readonly T9 _10;
        public readonly T10 _11;
        public readonly T11 _12;
        public readonly T12 _13;
        public readonly T13 _14;
        public readonly T14 _15;
        public readonly T15 _16;
        public readonly T16 _17;
        public readonly T17 _18;
        public readonly T18 _19;
        public readonly T19 _20;
        public readonly T20 _21;
        public readonly T21 _22;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14, T14 _15, T15 _16, T16 _17, T17 _18, T18 _19, T19 _20, T20 _21, T21 _22)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
            this._6 = _6;
            this._7 = _7;
            this._8 = _8;
            this._9 = _9;
            this._10 = _10;
            this._11 = _11;
            this._12 = _12;
            this._13 = _13;
            this._14 = _14;
            this._15 = _15;
            this._16 = _16;
            this._17 = _17;
            this._18 = _18;
            this._19 = _19;
            this._20 = _20;
            this._21 = _21;
            this._22 = _22;
        }
    }

    public struct Tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> : Product<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>
    {
        public readonly T0 _1;
        public readonly T1 _2;
        public readonly T2 _3;
        public readonly T3 _4;
        public readonly T4 _5;
        public readonly T5 _6;
        public readonly T6 _7;
        public readonly T7 _8;
        public readonly T8 _9;
        public readonly T9 _10;
        public readonly T10 _11;
        public readonly T11 _12;
        public readonly T12 _13;
        public readonly T13 _14;
        public readonly T14 _15;
        public readonly T15 _16;
        public readonly T16 _17;
        public readonly T17 _18;
        public readonly T18 _19;
        public readonly T19 _20;
        public readonly T20 _21;
        public readonly T21 _22;
        public readonly T22 _23;
        public Tuple(T0 _1, T1 _2, T2 _3, T3 _4, T4 _5, T5 _6, T6 _7, T7 _8, T8 _9, T9 _10, T10 _11, T11 _12, T12 _13, T13 _14, T14 _15, T15 _16, T16 _17, T17 _18, T18 _19, T19 _20, T20 _21, T21 _22, T22 _23)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
            this._5 = _5;
            this._6 = _6;
            this._7 = _7;
            this._8 = _8;
            this._9 = _9;
            this._10 = _10;
            this._11 = _11;
            this._12 = _12;
            this._13 = _13;
            this._14 = _14;
            this._15 = _15;
            this._16 = _16;
            this._17 = _17;
            this._18 = _18;
            this._19 = _19;
            this._20 = _20;
            this._21 = _21;
            this._22 = _22;
            this._23 = _23;
        }
    }

}
