using LibraryForOfficeEqipement;
using CaptchaGen.NetCore;
using System.Data;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetAvgTime()
        {
            string avgRequest = "61 дн.";
            
            Assert.AreEqual(DataBase.GetAvgTime(DataBase.GetTable()), avgRequest);
        }

        [TestMethod]
        public void TestLogin()
        {
            string login = "логин";
            string password = "пароль";
            Assert.AreEqual(DataBase.Login(login, password), -1);
        }

        [TestMethod]
        public void TestCaptchaLength()
        {
            int length = 6;
            string result = ImageFactory.CreateCode(length);
            Assert.AreEqual(result.Length, length);
        }

        [TestMethod]
        public void TestAddRequest()
        {
            int id = 6;
            string model = "DEXP Atlas H388";
            string problem = "проблема";
            int count = DataBase.GetTable().Rows.Count;
            DataBase.AddRequest(id, model, problem);
            Assert.AreEqual(DataBase.GetTable().Rows.Count, count+1);
        }
        [TestMethod]
        public void TestCaptchaChar()
        {
            int length = 6;
            string result = ImageFactory.CreateCode(length);
            for (int i = 0; i < length; i++)
            {
                Assert.IsTrue(char.IsLetterOrDigit(result[i]));
            }
        }
    }
}