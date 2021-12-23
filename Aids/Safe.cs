using System;

namespace Domain.Common.Aids
{
    /// <summary>
    /// Class for safely providing actions and functions
    /// </summary>
    public static class Safe
    {
        public static T Run<T>(Func<T> function, T valueOnException)
        {
            try
            {
                return function();
            }
            catch (Exception e)
            {
                LogException(e);
                return valueOnException;
            }
        }
        public static void Run(Action action)
        {
            try
            {

            }
            catch (Exception e)
            {
                LogException(e);
                throw;
            }
        }
        public static void LogException(Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
