namespace Sandbox
{
    public struct Rib
    {
        private int _topVertex;
        private int _bottomVertex;
        private int _weight;

        public Rib(int top, int bottom, int weight)
        {
            _topVertex = top;
            _bottomVertex = bottom;
            _weight = weight;
        }

        public int TopVertex => _topVertex;
        public int BottomVertex => _bottomVertex;
        public int Weight => _weight;

        public bool Equals(Rib x)
        {
            bool result =
                    (x.BottomVertex == this.BottomVertex && x.TopVertex == this.TopVertex) ||
                    (x.BottomVertex == this.TopVertex && x.TopVertex == this.BottomVertex);
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
    };
}
