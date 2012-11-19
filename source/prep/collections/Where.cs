using prep.utility.filtering;

namespace prep.collections
{
	public class Where<ItemToFilter>
	{
		public static PropertyIsEqualTo<ItemToFilter, TProperty> has_a<TProperty>(PropertyAccessor<ItemToFilter, TProperty> accessor)
		{
			return new PropertyIsEqualTo<ItemToFilter, TProperty>(accessor);
		}
	}
}