using System;
using Xunit;

using EnumeratorUtils;

namespace EnumeratorUtils.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var a = new[] { 1, 2, 3, 4, 5 };
            var aa = a.GetEnumerator();
            var ga = aa.Cast<int>();
        }
    }
}
