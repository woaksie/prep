using System;
using prep.utility.filtering;

namespace prep.collections
{
    public class Where<ItemToFilter>
    {
        public static Func<Movie, ProductionStudio> has_a(Func<Movie, ProductionStudio> func)
        {
            return func;
        }
    }

    public static class FilterExtention
    {
        public static IMatchAn<Movie> equal_to(this  Func<Movie, ProductionStudio> projection, ProductionStudio studio)
        {
            return new ConditionalMatch<Movie>(c => projection(c) == studio);
        }
    }
}