using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RetryLogic
{
    //https://stackoverflow.com/questions/1563191/cleanest-way-to-write-retry-logic
    class Retry
    {
        static void Main(string[] args)
        {
            Retry.Do<object>(() => Method1(), TimeSpan.FromSeconds(1));
            //or
            Retry.Do<object>(Retry.Method1, TimeSpan.FromSeconds(1));
            //or
            object result = Retry.Do<object>(Retry.Method1, TimeSpan.FromSeconds(1), 4);
        }

        static object Method1()
        {
            return null;
        }

        public static T Do<T>(Func<T> action, TimeSpan retryInterval, int maxAttemptCount = 3)
        {
            var exceptions = new List<Exception>();

            for (int attempted = 0; attempted < maxAttemptCount; attempted++)
            {
                try
                {
                    if (attempted > 0)
                    {
                        Thread.Sleep(retryInterval);
                    }
                    return action();
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            }
            throw new AggregateException(exceptions);
        }
    }
}
