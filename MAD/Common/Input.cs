using System;

namespace MAD.Common
{
    public static class CommonInput
    {
        public static T Input<T>(T defaultValue = default(T)) where T : struct
        {
            try
            {
                var inputStr = Console.ReadLine();
                return (T)Convert.ChangeType(inputStr, typeof(T));
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
