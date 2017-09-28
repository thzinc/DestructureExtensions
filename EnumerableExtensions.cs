using System;
using System.Collections.Generic;

namespace DestructureExtensions
{
    public static class EnumerableExtensions
    {
        private static T GetValueOrDefault<T>(IEnumerator<T> enumerator)
        {
            if (enumerator.MoveNext())
            {
                return enumerator.Current;
            }

            return default(T);
        }

        private static IEnumerable<T> GetRemaining<T>(IEnumerator<T> enumerator)
        {
            while (enumerator.MoveNext()) yield return enumerator.Current;
        }

        public static void Deconstruct<T>(this IEnumerable<T> source, out T first, out IEnumerable<T> rest)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            var enumerator = source.GetEnumerator();
            first = GetValueOrDefault(enumerator);
            rest = GetRemaining(enumerator);
        }

        public static void Deconstruct<T>(this IEnumerable<T> source, out T first, out T second, out IEnumerable<T> rest)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            var enumerator = source.GetEnumerator();
            first = GetValueOrDefault(enumerator);
            second = GetValueOrDefault(enumerator);
            rest = GetRemaining(enumerator);
        }

        public static void Deconstruct<T>(this IEnumerable<T> source, out T first, out T second, out T third, out IEnumerable<T> rest)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            var enumerator = source.GetEnumerator();
            first = GetValueOrDefault(enumerator);
            second = GetValueOrDefault(enumerator);
            third = GetValueOrDefault(enumerator);
            rest = GetRemaining(enumerator);
        }

        public static void Deconstruct<T>(this IEnumerable<T> source, out T first, out T second, out T third, out T fourth, out IEnumerable<T> rest)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            var enumerator = source.GetEnumerator();
            first = GetValueOrDefault(enumerator);
            second = GetValueOrDefault(enumerator);
            third = GetValueOrDefault(enumerator);
            fourth = GetValueOrDefault(enumerator);
            rest = GetRemaining(enumerator);
        }

        public static void Deconstruct<T>(this IEnumerable<T> source, out T first, out T second, out T third, out T fourth, out T fifth, out IEnumerable<T> rest)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            var enumerator = source.GetEnumerator();
            first = GetValueOrDefault(enumerator);
            second = GetValueOrDefault(enumerator);
            third = GetValueOrDefault(enumerator);
            fourth = GetValueOrDefault(enumerator);
            fifth = GetValueOrDefault(enumerator);
            rest = GetRemaining(enumerator);
        }

        public static void Deconstruct<T>(this IEnumerable<T> source, out T first, out T second, out T third, out T fourth, out T fifth, out T sixth, out IEnumerable<T> rest)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            var enumerator = source.GetEnumerator();
            first = GetValueOrDefault(enumerator);
            second = GetValueOrDefault(enumerator);
            third = GetValueOrDefault(enumerator);
            fourth = GetValueOrDefault(enumerator);
            fifth = GetValueOrDefault(enumerator);
            sixth = GetValueOrDefault(enumerator);
            rest = GetRemaining(enumerator);
        }

        public static void Deconstruct<T>(this IEnumerable<T> source, out T first, out T second, out T third, out T fourth, out T fifth, out T sixth, out T seventh, out IEnumerable<T> rest)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            var enumerator = source.GetEnumerator();
            first = GetValueOrDefault(enumerator);
            second = GetValueOrDefault(enumerator);
            third = GetValueOrDefault(enumerator);
            fourth = GetValueOrDefault(enumerator);
            fifth = GetValueOrDefault(enumerator);
            sixth = GetValueOrDefault(enumerator);
            seventh = GetValueOrDefault(enumerator);
            rest = GetRemaining(enumerator);
        }

        public static void Deconstruct<T>(this IEnumerable<T> source, out T first, out T second, out T third, out T fourth, out T fifth, out T sixth, out T seventh, out T eighth, out IEnumerable<T> rest)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            var enumerator = source.GetEnumerator();
            first = GetValueOrDefault(enumerator);
            second = GetValueOrDefault(enumerator);
            third = GetValueOrDefault(enumerator);
            fourth = GetValueOrDefault(enumerator);
            fifth = GetValueOrDefault(enumerator);
            sixth = GetValueOrDefault(enumerator);
            seventh = GetValueOrDefault(enumerator);
            eighth = GetValueOrDefault(enumerator);
            rest = GetRemaining(enumerator);
        }
    }
}
