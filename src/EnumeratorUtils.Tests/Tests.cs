using System;
using Xunit;

using EnumeratorUtils;

namespace EnumeratorUtils.Tests {
    public class Tests {
        [Fact]
        public void Test1() {
            var array = new[] { 1, 2, 3, 4, 5 };
            var e = array.GetEnumerator();
            var ge = e.Cast<int>();
        }
    }
}
