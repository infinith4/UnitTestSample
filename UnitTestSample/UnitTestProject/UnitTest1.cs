using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestSample;
using UnitTestSample.Models;

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
        [TestMethod]
        public void SubstractionTest()
        {
            Program p = new Program();
            int x = 3;
            int y = 1;

            int expected = 2;
            //答えとして期待する値 

            int actual = p.SubNumber(x, y);
            //実際の値 

            Assert.AreEqual(expected, actual);
            //期待値と実際の値が同一であるかを検証します。同一である場合にはテストが成功し、そうでない場合には失敗を返します。 
        }

        [TestMethod]
        public void CalculationTest()
        {
            Program p = new Program();
            int add_x = 3;
            int add_y = 1;

            int add_expected = 4;
            //答えとして期待する値 

            int add_actual = p.AddNumber(add_x, add_y);

            int sub_x = 3;
            int sub_y = 1;

            int sub_expected = 2;

            int sub_actual = p.SubNumber(sub_x, sub_y);
            //実際の値 
            var expected_model = new CalculateModel();
            expected_model.addnum = add_expected;
            expected_model.subnum = sub_expected;
            expected_model.result.isSuccess = true;

            var actual_model = new CalculateModel();
            actual_model.addnum = add_actual;
            actual_model.subnum = sub_actual;
            actual_model.result.isSuccess = true;
            CheckProperty(expected_model, actual_model);
            //期待値と実際の値が同一であるかを検証します。同一である場合にはテストが成功し、そうでない場合には失敗を返します。 
        }

        [TestMethod]
        public void GetHoge_Test()
        {
            var value = "ほげ";
            var privateObj = new PrivateObject(new Program());
            var result = privateObj.Invoke("GetHoge", value);

            Assert.AreEqual(result.ToString(), $"{value}Hoge");
        }

        public void CheckProperty(Object expected_model, Object actual_model, AssertFailedException exception = null)
        {
            foreach (var item in expected_model.GetType().GetProperties())
            {
                // プロパティ名を表示
                var exp = item.GetValue(expected_model);
                var ac = item.GetValue(actual_model);
                try
                {
                    Assert.AreEqual(exp, ac);
                }
                catch (AssertFailedException ex)
                {
                    if (exception == null)
                        CheckProperty(exp, ac, ex);
                    else
                        throw new AssertFailedException();
                }
            }
        }
    }
}
