using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XFBootstrapper.Business;

namespace XFBootstrapper.Business.Tests
{
    [TestClass]
    public class PluginLoaderTests
    {
        [TestMethod]
        public void TestDefaultPluginDirectory()
        {
            PluginLoader loader = new PluginLoader();
            Assert.IsNotNull(loader);
        }
    }
}
