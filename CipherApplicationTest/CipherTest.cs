using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CipherFormsApp;

namespace CipherApplicationTest
{
    [TestClass]
    public class CipherTest
    {
        [TestMethod]
        public void encryptPassTestMethod()
        {
            //assign
            var input = "hElLo";
            var expectedOutput = "kHoOr";

            //act
            var result = ProcessToken.ProcessTokenCode(input, CipherType.Encrypt.ToString());

            //assert
            Assert.AreEqual(expectedOutput, result);

        }
        [TestMethod]
        public void decryptPassTestMethod()
        {
            ////assign
            var input = "KhOOr";
            var expectedOutput = "HeLLo";

            //act
            var result = ProcessToken.ProcessTokenCode(input, CipherType.Decrypt.ToString());

            //assert
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void encryptfailTestMethod()
        {
            //assign
            var input = "khoor";
            var expectedOutput = "hello";

            //act
            var result = ProcessToken.ProcessTokenCode(input, CipherType.Encrypt.ToString());

            //assert
            Assert.AreNotEqual(expectedOutput, result);

        }
        [TestMethod]
        public void decryptfailTestMethod()
        {
            ////assign
            var input = "hello";
            var expectedOutput = "khoor";

            //act
            var result = ProcessToken.ProcessTokenCode(input, CipherType.Decrypt.ToString());

            //assert
            Assert.AreNotEqual(expectedOutput, result);
        }

        
        [TestMethod]
        public void encryptUpperCasePassTestMethod()
        {
            //assign
            var input = "HELLO";
            var expectedOutput = "KHOOR";

            //act
            var result = ProcessToken.ProcessTokenCode(input, CipherType.Encrypt.ToString());

            //assert
            Assert.AreEqual(expectedOutput, result);

        }
        [TestMethod]
        public void decryptUpperCasePassTestMethod()
        {
            ////assign
            var input = "KHOOR";
            var expectedOutput = "HELLO";

            //act
            var result = ProcessToken.ProcessTokenCode(input, CipherType.Decrypt.ToString());

            //assert
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void encryptLowerCasePassTestMethod()
        {
            //assign
            var input = "hello";
            var expectedOutput = "khoor";

            //act
            var result = ProcessToken.ProcessTokenCode(input, CipherType.Encrypt.ToString());

            //assert
            Assert.AreEqual(expectedOutput, result);

        }
        [TestMethod]
        public void decryptLowerCasePassTestMethod()
        {
            ////assign
            var input = "khoor";
            var expectedOutput = "hello";

            //act
            var result = ProcessToken.ProcessTokenCode(input, CipherType.Decrypt.ToString());

            //assert
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void encryptUpperCaseFailTestMethod()
        {
            //assign
            var input = "HELLO";
            var expectedOutput = "khoor";

            //act
            var result = ProcessToken.ProcessTokenCode(input, CipherType.Encrypt.ToString());

            //assert
            Assert.AreNotEqual(expectedOutput, result);

        }
        [TestMethod]
        public void decryptUpperCaseFailTestMethod()
        {
            ////assign
            var input = "KHOOR";
            var expectedOutput = "hello";

            //act
            var result = ProcessToken.ProcessTokenCode(input, CipherType.Decrypt.ToString());

            //assert
            Assert.AreNotEqual(expectedOutput, result);
        }
        [TestMethod]
        public void encryptLowerCaseFailTestMethod()
        {
            //assign
            var input = "hello";
            var expectedOutput = "KHOOR";

            //act
            var result = ProcessToken.ProcessTokenCode(input, CipherType.Encrypt.ToString());

            //assert
            Assert.AreNotEqual(expectedOutput, result);

        }
        [TestMethod]
        public void decryptLowerCaseFailTestMethod()
        {
            ////assign
            var input = "khoor";
            var expectedOutput = "HELLO";

            //act
            var result = ProcessToken.ProcessTokenCode(input, CipherType.Decrypt.ToString());

            //assert
            Assert.AreNotEqual(expectedOutput, result);
        }
    }
}
