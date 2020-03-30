using System.Collections.Generic;

namespace FilteringV10
{
    /// <summary>
    /// Class capable on filtering a List of integers.
    /// Current filtering condition:
    /// Include values larger than 10.
    /// </summary>
    public class Filter
    {   
        
        public static List<int> FilterValues(List<int> values, IFilterCondition FilterCondition)
        {
            List<int> filteredValues = new List<int>();

            foreach (var value in values)
            {
                if (FilterCondition.Condition(value, value))
                {
                    filteredValues.Add(value);
                }
            }

            return filteredValues;
        }
        
    }
}