namespace prep.utility.filtering
{
  public class ConditionalMatch<Item> : IMatchAn<Item>
  {
    Condition<Item> criteria;

    public ConditionalMatch(Condition<Item> criteria)
    {
      this.criteria = criteria;
    }

    public bool matches(Item item)
    {
      return criteria(item);
    }
  }
}