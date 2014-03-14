using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaGenerators
{

    class TupleGenerator
    {
        static void Main(string[] args)
        {
            var i = 23;
            var classes =
            Using("using LambdaInternal;\r\n", () =>
                new List<string> {
                    Namespace("LambdaInternal", () =>
                        Enumerable.Range(1, i).Select(x => Interface(x))
                    ),
                    Namespace("Lambda", () =>
                        Enumerable.Range(1, i).Select(x =>
                            Class(x, () =>
                                string.Join("\r\n", 
                                    Fields(x)
                                ) + Constructor(x)
                            )
                       )
                    )
                }
            );

            File.WriteAllText("../../Tuples.cs", classes);
        }

        public static string Interface(int i)
        {
            return "public interface Product" + TypeSignature(i, "out") + " {};";
        }

        public static string Constructor(int i)
        {
            return "\r\npublic Tuple(" + Parameters(i) + ") {\r\n" +
                FieldAttribution(i) + "\r\n}";
        }

        public static string FieldAttribution(int i)
        {
            return string.Join("\r\n", Enumerable.Range(1, i).Select(k =>
                    "this._" + k + " = _" + k + ";"
                ));
        }

        public static string Parameters(int k)
        {
            return string.Join(", ", Enumerable.Range(0, k).Select(i =>
                "T" + i + " _" + (i + 1)
                ));
        }

        public static IEnumerable<string> Fields(int k)
        {
            return Enumerable.Range(1, k).Select(i =>
                "public readonly T" + (i - 1) + " _" + i + ";"
            );
        }

        public static string Class(int i, Func<string> f)
        {
            return "public struct Tuple" + TypeSignature(i) + " : Product" + TypeSignature(i) + "\r\n{\r\n" + f() + "\r\n}\r\n";
        }

        public static string TypeSignature(int i, string prefix = "")
        {
            return "<" + prefix + " " + String.Join(", " + prefix + " ", Types(i).ToArray()) + ">";
        }

        public static IEnumerable<string> Types(int i)
        {
            return Enumerable.Range(0, i).Select(t => "T" + t);
        }

        public static string Namespace(string nameSpace, Func<IEnumerable<string>> f)
        {
            return "namespace " + nameSpace + "\r\n{\r\n" + String.Join("\r\n", f()) + "\r\n}\r\n";
        }

        public static string Using(string others, Func<IEnumerable<string>> f)
        {
            return "using System;\r\n" +
                   "using System.Collections.Generic;\r\n" +
                    "using System.Linq;\r\n" +
                    "using System.Text;\r\n" +
                    "using System.Threading.Tasks;\r\n" +
                    others +
                    "\r\n" +
                    string.Join("\r\n", f());
        }
    }

}
