using tinder_1.Models;

namespace TinderTests
{
    [TestClass]
    public class UserFieldValidationTests
    {
        //Тесты для поля Name
        private UserProfile user1;
        private User user;

        [TestInitialize]
        public void CreateEvent()
        {
            user1 = new UserProfile();
        }
        [TestMethod]
        public void UserProfile_Name_Test1()
        {
            user1.Name = "123Даша";

            Assert.ThrowsException<ArgumentException>(() => user1.Name);
        }
        [TestMethod]
        public void UserProfile_Name_Test2()
        {
            user1.Name = "даша";

            Assert.ThrowsException<ArgumentException>(() => user1.Name);
        }
        [TestMethod]
        public void UserProfile_Name_Test3()
        {
            user1.Name = "Даша";


            Assert.AreEqual("Даша", user1.Name);
        }
        [TestMethod]
        public void UserProfile_Name_Test4()
        {
            user1.Name = "Даша###";

            Assert.ThrowsException<ArgumentException>(() => user1.Name);
        }
        [TestMethod]
        public void UserProfile_Name_Test5()
        {
            user1.Name = "Dasha";

            Assert.ThrowsException<ArgumentException>(() => user1.Name);
        }


        //Тесты для поля PhoneNumber
        [TestMethod]
        public void UserProfile_PhoneNumber_Test1()
        {
            user1.PhoneNumber = "1234";

            Assert.ThrowsException<ArgumentException>(() => user1.PhoneNumber);
        }
        [TestMethod]
        public void UserProfile_PhoneNumber_Test2()
        {
            user1.PhoneNumber = "1234Арина";

            Assert.ThrowsException<ArgumentException>(() => user1.PhoneNumber);
        }
        [TestMethod]
        public void UserProfile_PhoneNumber_Test3()
        {
            user1.PhoneNumber = "12345678910";
            Assert.AreEqual("12345678910", user1.PhoneNumber);
        }

        //Тесты для поля BirthDate
        [TestMethod]
        public void UserProfile_BirthDate_Test1()
        {

            user1.BirthDate = new DateTime(1996, 09, 23);

            Assert.AreEqual(new DateTime(1996, 09, 23), user1.BirthDate);
        }
        [TestMethod]
        public void UserProfile_BirthDate_Test2()
        {

            user1.BirthDate = new DateTime(2010, 09, 23);
            Assert.ThrowsException<ArgumentException>(() => user1.BirthDate);
        }

        //Тесты для поля Password
        [TestMethod]
        public void User_Password_Test1()
        {
            user = new User { Login = "testUser", Password = "ValidPass1!" };
            Assert.AreEqual("ValidPass1!", user.Password);
        }

        [TestMethod]
        public void User_Password_Test2()
        {
            user = new User { Login = "testUser", Password = "InvalidPass" };

            Assert.ThrowsException<ArgumentException>(() => user.Password);
        }

        [TestMethod]
        public void User_Password_Test3()
        {
            user = new User { Login = "testUser", Password = "invalid1!" };

            Assert.ThrowsException<ArgumentException>(() => user.Password);
        }

        [TestMethod]
        public void User_Password_Test4()
        {
            user = new User { Login = "testUser", Password = "Short1!" };

            Assert.ThrowsException<ArgumentException>(() => user.Password);
        }

        [TestMethod]
        public void User_Password_Test5()
        {
            user = new User { Login = "testUser", Password = "Арина1234!" };

            Assert.ThrowsException<ArgumentException>(() => user.Password);
        }

        [TestMethod]
        public void User_Password_Test6()
        {
            user = new User { Login = "testUser", Password = "" };

            Assert.ThrowsException<ArgumentException>(() => user.Password);
        }
    }
}