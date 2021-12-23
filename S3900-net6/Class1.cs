using System.Diagnostics.CodeAnalysis;

namespace S3900_repro
{
    public static class Class1
    {
        public static string Test(TestClass x)
        {
            var y = x.TestProperty;
            return y;
        }

        public static string Test2([NotNull] TestClass xx)
        {
            var y = xx.TestProperty;
            return y;
        }
    }
}