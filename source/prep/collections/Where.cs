using prep.utility.filtering;

namespace prep.collections
{
  public class Where<ItemToFilter>
  {
    public static  has_a<TProperty>(PropertyAccessor<ItemToFilter,TProperty> accessor)
    {
      return accessor;
    }
  }

}