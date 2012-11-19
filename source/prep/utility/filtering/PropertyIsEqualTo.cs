namespace prep.utility.filtering
{
	public class PropertyIsEqualTo<ItemToFilter, TProperty>
	{
		readonly PropertyAccessor<ItemToFilter, TProperty> _accessor;

		public PropertyIsEqualTo(PropertyAccessor<ItemToFilter, TProperty> accessor)
		{
			_accessor = accessor;
		}

		public ConditionalMatch<ItemToFilter> equal_to(TProperty value)
		{
			return new ConditionalMatch<ItemToFilter>(item => _accessor(item).Equals(value));
		}
	}
}