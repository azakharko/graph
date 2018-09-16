using System;
using System.Collections.Generic;

namespace Sandbox
{
    // non-cyclic closed graph
    public class ClosedGrapch : AbstractGrapch
    {
        public ClosedGrapch(List<int> vertexes, HashSet<Rib> ribs)
            : base(vertexes, ribs)
        {
            Validate();
        }

        public override void Validate()
        {
            //Console.WriteLine("validate called from closed graph ctor");

            // 0. check duplications (exclude cycles in the graph (ribs like Rib(a, b) and Rib(b, a) should not exist
            // done but in a bit ugly way

            // 1. check if all the ribs are build of pair of vertextes
            foreach (var x in Ribs)
            {
                if (!Vertexes.Contains(x.TopVertex))
                {
                    throw new Exception("this is not an open graph");
                }

                if (!Vertexes.Contains(x.BottomVertex))
                {
                    throw new Exception("this is not an open graph");
                }
            }
        }
    }
}
