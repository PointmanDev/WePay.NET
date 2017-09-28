using System;
using System.Collections.Generic;
using System.Reflection;

namespace WePay.Shared
{
    /// <summary>
    /// Utitlties class for building out static classes that store WePay specific values that may need to be referenced in application code
    /// </summary>
    public static class WePayValues
    {
        /// <summary>
        /// Used to iterate through a static class and fill a List of strings with each static member that is a string
        /// </summary>
        /// <param name="type"></param>
        /// <param name="values"></param>
        public static void FillValuesList(Type type,
                                           List<string> values)
        {
            values.Clear();

            foreach (var p in type.GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                var value = p.GetValue(null);

                if (value is string valueAsString)
                {
                    values.Add(valueAsString);
                }
            }
        }
    }
}