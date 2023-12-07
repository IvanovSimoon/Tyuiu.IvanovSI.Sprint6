using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint6.Task6.V10.Lib;
using System.IO;
namespace Tyuiu.IvanovSI.Sprint6.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string resStr = "www dsdsdw ww";
            string line = "www dsdsdw dsdsdsd ww";
            string[] words = line.Split(' ');
            string res = "";
             
            foreach (string word in words)
            {
                if (word.Contains("w"))
                {
                    res += word + " ";
                }
            }
            res = res.TrimEnd();
            Assert.AreEqual(resStr, res);
        }
    }
}
