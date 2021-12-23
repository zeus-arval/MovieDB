using System;

namespace Domain.Common.Aids
{
    /// <summary>
    /// Class for safely providing actions and functions
    /// </summary>
    public static class Safe
    {
        public static void Run(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                LogException(e);
            }
        }
        public static void LogException(Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
