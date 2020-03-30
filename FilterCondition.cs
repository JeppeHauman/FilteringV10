namespace FilteringV10
{
    public class FilterCondition : IFilterCondition
    {
        public bool Condition(int value, int value2)
        {
            return value > 20 && value2 < 40;
        }
    }
}