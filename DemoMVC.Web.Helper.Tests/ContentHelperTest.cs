using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoMVC.Web.Helper.Tests
{
    [TestClass]
    public class ContentHelperTest
    {
        [TestMethod]
        public void ApplicationNameContainsTheWordDemo()
        {
            StringAssert.Contains(ContentHelper.ApplicationName.ToLower(), "demo");
        }
    }
}
