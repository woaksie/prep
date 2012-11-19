using System.Collections;
using System.Collections.Generic;

namespace prep.collections
{
  public class ReadOnlySet<Item> : IEnumerable<Item>
  {
    IEnumerable<Item> items;

    public ReadOnlySet(IEnumerable<Item> items)
    {
      this.items = items;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    public IEnumerator<Item> GetEnumerator()
    {
      return items.GetEnumerator();
    }
  }
}