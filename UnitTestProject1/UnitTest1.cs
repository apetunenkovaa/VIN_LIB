using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VIN_LIB;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckVIN_correctLetters_true()
        {
            string vin = "SCFAB22311K301756";
            Assert.IsTrue(Class1.CheckVIN(vin));
        }

        [TestMethod]
        public void GetVINCountry_correctCountryAfrica_true()
        {
            string vin = "AFTCR15T4GPB29162";
            string except = "Африка";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(except, actual);
        }

        [TestMethod]
        public void GetVINCountry_correctCountryOceania_true()
        {
            string vin = "6FTCR15T4GPB29162";
            string except = "Океания";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(except, actual);
        }

        [TestMethod]
        public void GetVINCountry_correctCountry_false()
        {
            string vin = "Z2V8L2W2OQ1KD5CRT";
            string except = "Северная Америка";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreNotEqual(except, actual);
        }

        [TestMethod]
        public void CheckVIN_correctLength_false()
        {
            string vin = "1";
            Assert.IsFalse(Class1.CheckVIN(vin));
        }

        [TestMethod]
        public void CheckVIN_correctLength_true()
        {
            string vin = "12345678910111213141";
            Assert.IsFalse(Class1.CheckVIN(vin));
        }

        [TestMethod]
        public void GetVINCountry_returnedBoolVar_true()
        {
            string vin = "A2V8L2W2OQ1KD5CRT";
            Assert.IsInstanceOfType(Class1.CheckVIN(vin), typeof(bool));
        }


        [TestMethod]
        public void GetVINCountry_returnedStringVar_true()
        {
            string vin = "Z2V8L2W2OQ1KD5CRT";
            Assert.IsInstanceOfType(Class1.GetVINCountry(vin), typeof(string));
        }

        [TestMethod]
        public void GetVINCountry_returnedNullVar_true()
        {
            string vin = "-2V8L2W2OQ1KD5CRT";
            Assert.IsNull(Class1.GetVINCountry(vin));
        }

        [TestMethod]
        public void GetVINCountry_returnedStringVar_false()
        {
            string vin = null;
            Assert.IsNotInstanceOfType(Class1.GetVINCountry(vin), typeof(string));
        }

        //сложные

        [TestMethod]
        public void CheckVIN_for_invalid_characters()
        {
            string vin = "IQ345678901234567";
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => Class1.CheckVIN(vin)));
        }

        [TestMethod]
        public void GetVINCountry_for_invalid_characters()
        {
            string vin = "IQ345678901234567";
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => Class1.GetVINCountry(vin)));
        }

    }
}
