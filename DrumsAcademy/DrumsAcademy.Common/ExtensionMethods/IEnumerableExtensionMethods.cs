using System.Collections.Generic;

using Bytes2you.Validation;

namespace DrumsAcademy.Common.ExtensionMethods
{
    public static class EnumerableExtensionMethods
    {
        public static IEnumerable<T> TakeLast<T>(this IEnumerable<T> source, int takeCount)
        {
            Guard.WhenArgument(source, "source").IsNull().Throw();
            Guard.WhenArgument(takeCount, "takeCount").IsLessThan(0).Throw();

            if (takeCount == 0)
            {
                yield break;
            }

            T[] result = new T[takeCount];
            var i = 0;

            var sourceCount = 0;
            foreach (T element in source)
            {
                result[i] = element;
                i = (i + 1) % takeCount;
                sourceCount++;
            }

            if (sourceCount < takeCount)
            {
                takeCount = sourceCount;
                i = 0;
            }

            for (int j = 0; j < takeCount; ++j)
            {
                yield return result[(i + j) % takeCount];
            }
        }
    }
}