using System;
using System.Collections.Generic;
using System.Reflection;

namespace WePayApi.Shared
{
    public abstract class WePayValues
    {
        public readonly List<string> Values = new List<string>();

        public int? GetIndexOfWePayValue(string value)
        {
            if (value != null)
            {
                int index = Values.IndexOf(value);

                if (index > -1)
                {
                    return index;
                }
            }

            return null;
        }
    }

    public abstract class WePayValues<T> : WePayValues where T: class
    {
        public string GetWePayValue(int i)
        {
            return Values[i];
        }

        public string GetWePayValue(T choice)
        {
            return Values[Convert.ToInt32(choice)];
        }

        public int ToInt(T choice)
        {
            return Convert.ToInt32(choice);
        }

        public WePayValues()
        {
            Values.Clear();

            foreach (var p in typeof(T).GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                var value = p.GetValue(null);
                Values.Add((string)value);
            }
        }
    }
}