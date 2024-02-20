
namespace 國泰證券後端試題
{
    public static class StringExtensionMethods
    {
        public static char? GetFirstChar(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return null;

            return str[0];
        }
    }

}
