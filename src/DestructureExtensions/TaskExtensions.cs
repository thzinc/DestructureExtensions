using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DestructureExtensions
{
    public static class TaskExtensions
    {
        public static async Task<IEnumerable<T>> WhenAll<T>(this IEnumerable<Task<T>> tasks)
        {
            return await Task.WhenAll(tasks).ContinueWith(ts => ts.Result);
        }

        public static async Task<(T1, T2)> WhenAll<T1, T2>(this (Task<T1>, Task<T2>) tasks)
        {
            var (t1, t2) = tasks;
            return (await t1, await t2);
        }

        public static async Task<(T1, T2, T3)> WhenAll<T1, T2, T3>(this (Task<T1>, Task<T2>, Task<T3>) tasks)
        {
            var (t1, t2, t3) = tasks;
            return (await t1, await t2, await t3);
        }

        public static async Task<(T1, T2, T3, T4)> WhenAll<T1, T2, T3, T4>(this (Task<T1>, Task<T2>, Task<T3>, Task<T4>) tasks)
        {
            var (t1, t2, t3, t4) = tasks;
            return (await t1, await t2, await t3, await t4);
        }

        public static async Task<(T1, T2, T3, T4, T5)> WhenAll<T1, T2, T3, T4, T5>(this (Task<T1>, Task<T2>, Task<T3>, Task<T4>, Task<T5>) tasks)
        {
            var (t1, t2, t3, t4, t5) = tasks;
            return (await t1, await t2, await t3, await t4, await t5);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6)> WhenAll<T1, T2, T3, T4, T5, T6>(this (Task<T1>, Task<T2>, Task<T3>, Task<T4>, Task<T5>, Task<T6>) tasks)
        {
            var (t1, t2, t3, t4, t5, t6) = tasks;
            return (await t1, await t2, await t3, await t4, await t5, await t6);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7)> WhenAll<T1, T2, T3, T4, T5, T6, T7>(this (Task<T1>, Task<T2>, Task<T3>, Task<T4>, Task<T5>, Task<T6>, Task<T7>) tasks)
        {
            var (t1, t2, t3, t4, t5, t6, t7) = tasks;
            return (await t1, await t2, await t3, await t4, await t5, await t6, await t7);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8)> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8>(this (Task<T1>, Task<T2>, Task<T3>, Task<T4>, Task<T5>, Task<T6>, Task<T7>, Task<T8>) tasks)
        {
            var (t1, t2, t3, t4, t5, t6, t7, t8) = tasks;
            return (await t1, await t2, await t3, await t4, await t5, await t6, await t7, await t8);
        }
    }
}
