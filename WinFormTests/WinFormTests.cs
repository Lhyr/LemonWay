using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Tests
{
    [TestClass()]
    public class WinFormTests
    {
        [TestMethod()]
        public void WinFormTest()
        {
            WinForm wf = new WinForm();
            wf.btnFibonacci.PerformClick();

            Assert.Fail();
        }
    }
}