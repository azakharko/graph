using System.Collections.Generic;

namespace Sandbox
{
    // we may need it if we don't have an access to Rib struct
    public class RibCompaprer : IEqualityComparer<Rib>
    {
        public bool Equals(Rib x, Rib y)
        {
            bool result =
                    (x.BottomVertex == y.BottomVertex && x.TopVertex == y.TopVertex) ||
                    (x.BottomVertex == y.TopVertex && x.TopVertex == y.BottomVertex);

            return result;
        }

        public int GetHashCode(Rib x)
        {
            unchecked
            {
                int hash = 29;
                hash = hash * 31 + x.BottomVertex.GetHashCode();
                hash = hash * 23 + x.TopVertex.GetHashCode();
                return hash;
            }
        }
    }
}
