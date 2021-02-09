using UnitTestingTwo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingTwo.Tests
{
    [TestClass()]
    public class UserdataTests
    {
        [TestMethod()]
        public void IsPasswordTooShort()
        {
            var user = new Userdata();

            var isPasswordLongEnough = "12345";
            var actual = user.IsPasswordOK(isPasswordLongEnough);
            var expected = false;
            Assert.AreEqual(actual, expected);
        }        
        
        [TestMethod()]
        public void IsPasswordLongEnough()
        {
            var user = new Userdata();
            var actual = user.IsPasswordOK("12345566778");
            Assert.AreEqual(true, actual);
        }        
        
        [TestMethod()]
        public void IsPasswordTooLong()
        {
            var user = new Userdata();
            var actual = user.IsPasswordOK("123455ljjhfjsdhfkjsdhfksjdhfkjsdhfkjsdhfkjsdhfkjsdhfkjsdhfkjsdhfkjsdfhksjdfhsdkjf66778");
            Assert.AreEqual(false, actual);
        }        

        [TestMethod()]
        public void IsPasswordShortEnough()
        {
            var user = new Userdata();
            var actual = user.IsPasswordOK("123455lj66778");
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void IsAtLeastOneUppercaseIncluded()
        {
            var user = new Userdata();
            var actual = user.IsPasswordOK("hjaKkjhakjha");
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void IsAtLeastOneLowercaseIncluded()
        {
            var user = new Userdata();
            var actual = user.IsPasswordOK("JLSDFdfSDJFLKSJDF");
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void IsAtLeastOneSpecialCaseIncluded()
        {
            var user = new Userdata();
            var actual = user.IsPasswordOK("JLSDFdfSDJFLK!JDF");
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void IsEmailOKTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IsPhoneOKTest()
        {
            Assert.Fail();
        }
    }
}