using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VIN_LIB;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Class1 class1 = new Class1();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(class1.CheckVIN("JHMCM56557C404453"), true);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(class1.CheckVIN("WVGZZZCAZJC520863"), true);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(class1.CheckVIN("JHMCM55557C404453"), true);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(class1.GetVINCountry("JHMCM56557F404453"), "Северная Америка");
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(class1.GetVINCountry("WVGZZZCAZJC520863"), "Северная Америка");
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(class1.GetVINCountry("JHMCM55557C404453"), "Северная Америка");
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(class1.GetVINCountry("JHMCM55557CJ04453"), "Азия");
        }
        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(class1.GetVINCountry("JHMCM55557CA04453"), "Африка");
        }
        [TestMethod]
        public void TestMethod9()
        {
            Assert.AreEqual(class1.GetVINCountry("JHMCM55557C604453"), "Океания");
        }
        [TestMethod]
        public void TestMethod10()
        {
            Assert.AreEqual(class1.GetVINCountry("JHMCM55557C904453"), "Южная Америка");
        }
        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(class1.CheckVIN("JHMCGJPFSJDOSFJPS55557C404453"), false);
        }

        [TestMethod]
        public void TestMethod12()
        {
            Assert.AreEqual(class1.CheckVIN("JDIEM55557I404453"), false);
        }

        [TestMethod]
        public void TestMethod13()
        {
            Assert.AreEqual(class1.CheckVIN("JHMCM55557O404453"), false);
        }

        [TestMethod]
        public void TestMethod14()
        {
            Assert.AreEqual(class1.GetVINCountry("fdfd"), false);
        }

        [TestMethod]
        public void TestMethod15()
        {
            Assert.AreEqual(class1.GetVINCountry("JHMCM55557CU04453"), "Европа");
        }
    }
}
