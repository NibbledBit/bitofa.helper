using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BitOfA.Helper.Extensions {
    public static class TaskHelper {

        /// <summary>
        /// Runs a TPL Task fire-and-forget style, the right way - in the
        /// background, separate from the current thread, with no risk
        /// of it trying to rejoin the current thread.
        /// </summary>
        public static void RunBg(Func<Task> fn) {
            Task.Run(fn).ConfigureAwait(false);
        }

        /// <summary>
        /// Runs a task fire-and-forget style and notifies the TPL that this
        /// will not need a Thread to resume on for a long time, or that there
        /// are multiple gaps in thread use that may be long.
        /// Use for example when talking to a slow webservice.
        /// </summary>
        public static void RunBgLong(Func<Task> fn) {
            Task.Factory.StartNew(fn, TaskCreationOptions.LongRunning)
                .ConfigureAwait(false);
        }

        public static bool RemoveNew<T>(this BlockingCollection<T> self, T itemToRemove) {
            while (self.TryTake(out T tToRemove)) {
                // Command was not the one we need, re-add
                if (!tToRemove.Equals(itemToRemove)) {
                    self.Add(tToRemove);
                }
                else {
                    // Command has been removed
                    return true;
                }
            }

            return false;
        }

        public static bool Remove<T>(this BlockingCollection<T> self, T itemToRemove) {

            var countBeforeRemove = self.Count;

            lock (self) {
                T comparedItem;
                var itemsList = new List<T>();
                do {
                    var result = self.TryTake(out comparedItem);
                    if (!result)
                        return false;
                    if (!comparedItem.Equals(itemToRemove)) {
                        itemsList.Add(comparedItem);
                    }
                } while (!comparedItem.Equals(itemToRemove));
                Parallel.ForEach(itemsList, t => self.Add(t));
            }

            var countAfterRemove = self.Count;

            if (countBeforeRemove == countAfterRemove)
                throw new Exception("Failed to remove");
            return true;
        }

        /// <summary>
        /// Task helper to run with a timeout
        /// https://stackoverflow.com/a/26006041
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="task"></param>
        /// <param name="timeout">Timeout in milliseconds</param>
        /// <param name="throwOnTimeout">If true, this method will throw when the timeour period is reached and the task is not complete</param>
        /// <returns></returns>
        public static async Task<TResult> WithTimeout<TResult>(this Task<TResult> task, TimeSpan timeout, bool throwOnTimeout = true) {
            if (throwOnTimeout) {
                if (task == await Task.WhenAny(task, Task.Delay(timeout))) {
                    return await task;
                }
                throw new TimeoutException();
            }
            else {
                var timeoutTask = Task.Delay(timeout).ContinueWith(_ => default(TResult), TaskContinuationOptions.ExecuteSynchronously);
                return await Task.WhenAny(task, timeoutTask).Unwrap();
            }
        }

        public static async Task WithTimeout(this Task task, TimeSpan timeout, bool throwOnTimeout = true) {
            if (throwOnTimeout) {
                if (task == await Task.WhenAny(task, Task.Delay(timeout))) {
                    await task;
                }
                else {
                    throw new TimeoutException();
                }
            }
            else {
                var timeoutTask = Task.Delay(timeout);
                await Task.WhenAny(task, timeoutTask).Unwrap();
            }
        }
    }
}
