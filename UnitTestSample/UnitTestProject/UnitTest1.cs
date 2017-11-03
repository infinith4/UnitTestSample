using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestSample;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program p = new Program();
            int x = 1;
            int y = 2;

            int expected = 3;
            //答えとして期待する値 

            int actual = p.AddNumber(x, y);
            //実際の値 

            Assert.AreEqual(expected, actual);
            //期待値と実際の値が同一であるかを検証します。同一である場合にはテストが成功し、そうでない場合には失敗を返します。 
        }
    }
}
