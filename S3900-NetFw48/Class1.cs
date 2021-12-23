namespace S3900_repro
{
    public static class Class1
    {
        public static string Test(TestClass x)
        {
            var y = x.TestProperty;
            return y;
        }

        public static string Test(string x)
        {
            var y = x.ToString();
            return y;
        }
    }
}