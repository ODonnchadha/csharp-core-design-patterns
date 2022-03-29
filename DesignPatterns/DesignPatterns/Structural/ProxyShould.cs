using NUnit.Framework;

namespace DesignPatterns.Structural
{
    public class ProxyShould
    {
        private string FILE_NAME = "document.pdf";
        private string DISPLAY_TEXT = "DOCUMENT Lorem ipsum.";

        [SetUp()]
        public void SetUp() { }

        [TearDown()]
        public void TearDown() { }

        [Test()]
        public void VirtualDisplay()
        {
            var document = new Proxy.Proxies.Virtual.DocumentProxy(FILE_NAME);

            Assert.AreEqual(document.DisplayDocument(), DISPLAY_TEXT);
        }

        [Test()]
        public void ProtectedDisplay()
        {
            var document = new Proxy.Proxies.Protected.DocumentProxy(FILE_NAME, "Admin");

            Assert.AreEqual(document.DisplayDocument(), DISPLAY_TEXT);
        }
    }
}
