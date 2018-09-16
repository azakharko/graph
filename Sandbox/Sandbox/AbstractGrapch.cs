using System.Collections.Generic;

namespace Sandbox
{
    public class AbstractGrapch
    {
        private List<int> _vertexes = new List<int>();
        private HashSet<Rib> _ribs = new HashSet<Rib>();

        public List<int> Vertexes => _vertexes;
        public HashSet<Rib> Ribs => _ribs;

        public AbstractGrapch(List<int> vertexes, HashSet<Rib> ribs)
        {
            _vertexes = vertexes;
            _ribs = ribs;
        }

        public virtual void Validate()
        {
            //Console.WriteLine("validate called from abstract graph ctor");
        }
    }
}
