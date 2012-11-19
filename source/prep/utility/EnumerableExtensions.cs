using System.Collections.Generic;

namespace prep.utility
{
  public static class EnumerableExtensions
  {
    public static IEnumerable<TItem> one_at_a_time<TItem>(this IEnumerable<TItem> items)
    {
      foreach (var item in items)
      {
        yield return item;
      }
    }

    public static IEnumerable<TItem> all_items_matching<TItem>(this IEnumerable<TItem> items, Condition<TItem> criteria)
    {
      foreach (var item in items)
        if (criteria(item)) yield return item;
    }
  }
}