using System.Collections;
using System.Collections.Generic;

namespace EnumeratorUtils {
    public static class Library {
        public static IEnumerable<T> Cast<T>(this IEnumerator data) {
            while (data.MoveNext()) {
                yield return (T)data.Current;
            }
        }
    }
}