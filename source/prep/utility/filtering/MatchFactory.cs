using System;
using System.Linq;

namespace prep.utility.filtering
{
  public class MatchFactory<ItemToFilter, TProperty>
  {
    PropertyAccessor<ItemToFilter, TProperty> accessor;

    public MatchFactory(PropertyAccessor<ItemToFilter, TProperty> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchAn<ItemToFilter> equal_to(TProperty value)
    {
      return new ConditionalMatch<ItemToFilter>(item => accessor(item).Equals(value));
    }

    public IMatchAn<ItemToFilter> equal_to_any(params TProperty[] values)
    {
        return new ConditionalMatch<ItemToFilter>(item =>
            {
                foreach (var value in values)
                {
                    if (accessor(item).Equals(value))
                        return true;
                }
                return false;
            });
    }
  }
}