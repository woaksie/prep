using System;

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
      throw new NotImplementedException();
    }
  }
}