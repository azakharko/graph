using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //new Rib(5,1).Equals(new Rib(1,5)).Dump();
            var ribList = new List<Rib>()
            {
                new Rib(1,2,3),
                new Rib(2,3,1),
                new Rib(3,4,4),
                new Rib(4,5,2),
                new Rib(5,1,5),
                new Rib(1,5,1), // this element should be ignored (duplicate - (5,1) already exists)
		        new Rib(2,5,3),
                new Rib(2,5,6), // this element should be ignored (duplicate - (2,5) already exists)
	        };

            var v = new List<int>() { 1, 2, 3, 4, 5 };
            //var r = new HashSet<Rib>(ribList, new RibCompaprer());
            var r = new HashSet<Rib>();

            //ribList.ForEach(x => { if(!r.Contains(x, new RibCompaprer())) r.Add(x); });
            ribList.ForEach(x => { if (!r.Any(c => c.Equals(x))) r.Add(x); });

            ClosedGrapch g = new ClosedGrapch(v, r);

            Assert.AreEqual(5, g.Vertexes.Count);
            Assert.AreEqual(6, g.Ribs.Count);
        }
    }
}
