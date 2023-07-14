using BEAMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEAMSTests
{
    [TestClass]
    public class ExtensionTests
    {
        [TestMethod]
        public void ConfirmDeliminate()
        {
            var expected1 = "999";
            var result1 = Extension.Deliminate(999);
            Assert.AreEqual(expected1, result1);

            var expected2 = "1,000";
            var result2 = Extension.Deliminate(1000);
            Assert.AreEqual(expected2, result2);
        }
    }
}
