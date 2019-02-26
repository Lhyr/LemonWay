using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebService_testUnitaire
{
    [TestClass]
    public class SwXmlToJsonTst
    {
        [TestMethod]
        public void XmlToJsonChaineSimple()
        {
            string valeur = new SwXmlToJson.SwXmlToJson().XmlToJson("<foo>bar</foo>");
            Assert.AreEqual("{\"foo\":\"bar\"}", valeur);
        }
        [TestMethod]
        public void XmlToJsonChaineSimpleFausse()
        {
            string valeur = new SwXmlToJson.SwXmlToJson().XmlToJson("<foo>hello</bar>");
            Assert.AreEqual("Bad Xml format", valeur);
        }
        [TestMethod]
        public void XmlToJsonChaineLongueJuste()
        {
            string valeur = new SwXmlToJson.SwXmlToJson().XmlToJson("<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>");
            Assert.AreEqual("{\"TRANS\":{\"HPAY\":{\"ID\":\"103\",\"STATUS\":\"3\",\"EXTRA\":{\"IS3DS\":\"0\",\"AUTH\":\"031183\"},\"MLABEL\":\"501767XXXXXX6700\",\"MTOKEN\":\"project01\"}}}", valeur);
        }
    }
}
