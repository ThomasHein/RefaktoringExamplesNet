using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using soft.thein.de.refaktoring;
using soft.thein.de.refaktoring.datastore;

namespace soft.thein.de.refactoring.tests
{
    [TestClass]
    public class MySingleSuperClassTest
    {

       
        [TestMethod]

        public void GetInternalProgrammer1()
        {
            DataStore store = new DataStore();
            DateTime date = new DateTime(2003, 11, 1, 1, 1, 30);
            String email = "myEmail.com";
            String name = "Hans";
            String[] answers = new String[] {"a", "b"};
            int resultSize = store.getProgrammers().Count;
            String message = "Hallo";
            int luckyNumber = 3;
            String creditCard = "234";
            String result = new MySingleSuperClass().getInternalBestProgrammer(store.getProgrammers(), name, answers,
                date, email, message, creditCard, luckyNumber);
            Assert.AreEqual("", result);
        }

        [TestMethod]

        public void GetInternalProgrammer2()
        {
            DataStore store = new DataStore();
            DateTime date = new DateTime(2003, 11, 1, 1, 1, 30);
            String email = "my@Email.com";
            String name = "Hans";
            String[] answers = new String[] {"a", "b"};
            int resultSize = store.getProgrammers().Count;
            String message = "Hallo";
            int luckyNumber = 3;
            String creditCard = "234";
            String result = new MySingleSuperClass().getInternalBestProgrammer(store.getProgrammers(), name, answers,
                date, email, message, creditCard, luckyNumber);
            Assert.AreEqual("Akkurat", result);
        }

        [TestMethod]

        public void GetInternalProgrammer3()
        {
            DataStore store = new DataStore();
            DateTime date = new DateTime(2003, 11, 1, 1, 1, 30);
            String email = "my@Email.com";
            String name = "Hans";
            String[] answers = new String[] {"a", "b"};
            int resultSize = store.getProgrammers().Count;
            String message = "Hallo";
            int luckyNumber = 3;
            String creditCard = "234-111-111-111";
            String result = new MySingleSuperClass().getInternalBestProgrammer(store.getProgrammers(), name, answers,
                date, email, message, creditCard, luckyNumber);
            Assert.AreEqual("Akkurat", result);
        }

        [TestMethod]

        public void GetInternalProgrammer4()
        {
            DataStore store = new DataStore();
            DateTime date = new DateTime(2003, 11, 1, 1, 1, 30);
            String email = "my@Email.com";
            String name = "Hans";
            String[] answers = new String[] {"a", "b"};
            int resultSize = store.getProgrammers().Count;
            String message = "Hallo";
            int luckyNumber = 3;
            String creditCard = "";
            String result = new MySingleSuperClass().getInternalBestProgrammer(store.getProgrammers(), name, answers,
                date, email, message, creditCard, luckyNumber);
            Assert.AreEqual("nieemand", result);
        }

        [TestMethod]

        public void GetInternalProgrammer5()
        {
            DataStore store = new DataStore();
            DateTime date = new DateTime(2003, 11, 1, 1, 1, 30);
            String email = "my@Email.com";
            String name = "Hans";
            String[] answers = new String[] {"a", "b"};
            int resultSize = store.getProgrammers().Count;
            String message = "Hallo";
            int luckyNumber = 2;
            String creditCard = "1-2-3-4";
            String result = new MySingleSuperClass().getInternalBestProgrammer(store.getProgrammers(), name, answers,
                date, email, message, creditCard, luckyNumber);
            Assert.AreEqual("Friedhelm", result);
        }

        [TestMethod]

        public void GetInternalProgrammer6()
        {
            DataStore store = new DataStore();
            DateTime date = new DateTime(2003, 11, 1, 1, 1, 30);
            String email = "my@Email.com";
            String name = "Hans";
            String[] answers = new String[] {"a", "b"};
            int resultSize = store.getProgrammers().Count;
            String message = "Hallo";
            int luckyNumber = 19;
            String creditCard = "1-2-3-4";
            String result = new MySingleSuperClass().getInternalBestProgrammer(store.getProgrammers(), name, answers,
                date, email, message, creditCard, luckyNumber);
            Assert.AreEqual("Fuschie", result);
        }

        [TestMethod]

        public void GetInternalProgrammer7()
        {
            DataStore store = new DataStore();
            DateTime date = new DateTime(2003, 11, 1, 1, 1, 30);
            String email = "admin@Email.com";
            String name = "Hans";
            String[] answers = new String[] {"a", "b"};
            int resultSize = store.getProgrammers().Count;
            String message = "Nummer 3 soll gewinnen";
            int luckyNumber = 19;
            String creditCard = "1-2-3-4";
            String result = new MySingleSuperClass().getInternalBestProgrammer(null, name, answers, date, email, message,
                creditCard, luckyNumber);
            Assert.AreEqual("", result);
        }

        [TestMethod]

        public void GetInternalProgrammer8()
        {
            DataStore store = new DataStore();
            DateTime date = new DateTime(2003, 11, 1, 1, 1, 30);
            String email = "admin@Email.com";
            String name = "Hans";
            String[] answers = new String[] {"a", "b"};
            int resultSize = store.getProgrammers().Count;
            String message = "Nummer 3 soll gewinnen";
            int luckyNumber = 19;
            String creditCard = "1-2-3-4";
            String result = new MySingleSuperClass().getInternalBestProgrammer(store.getProgrammers(), name, answers,
                date, email, message, creditCard, luckyNumber);
            Assert.AreEqual("DER CHEF", result);
        }

        [TestMethod]

        public void GetInternalProgrammer9()
        {
            DataStore store = new DataStore();
            DateTime date = new DateTime(2003, 11, 1, 1, 1, 30);
            String email = "admin@Email.com";
            String name = "Hans";
            String[] answers = new String[] {};
            int resultSize = store.getProgrammers().Count;
            String message = "Nummer 5 soll gewinnen";
            int luckyNumber = 19;
            String creditCard = "1-2-3-4";
            String result = new MySingleSuperClass().getInternalBestProgrammer(store.getProgrammers(), name, answers,
                date, email, message, creditCard, luckyNumber);
            Assert.AreEqual("Fuschie", result);
        }

        [TestMethod]

        public void GetInternalProgrammer10()
        {
            DataStore store = new DataStore();
            DateTime date = new DateTime(2003, 11, 1, 1, 1, 30);
            String email = "admin@Email.com";
            String name = "Hans";
            String[] answers = new String[] {"a"};
            int resultSize = store.getProgrammers().Count;
            String message = "Nummer 5 soll gewinnen";
            int luckyNumber = 19;
            String creditCard = "1-2-3-4";
            String result = new MySingleSuperClass().getInternalBestProgrammer(store.getProgrammers(), name, answers,
                date, email, message, creditCard, luckyNumber);
            Assert.AreEqual("Fuschie", result);
        }

        [TestMethod]

        public void GetWorstProgrammer1()
        {
            DataStore store = new DataStore();
            DateTime date = new DateTime(2003, 11, 1, 1, 1, 30);
            String email = "my@Email.com";
            String name = "Hans";
            int resultSize = store.getProgrammers().Count;
            Programmer result = new MySingleSuperClass().GetWorstProgrammer(store.getProgrammers(), date, email, name);

            Assert.AreEqual(store.getProgrammers().Count, resultSize);

        }

        [TestMethod]

        public void GetWorstProgrammer2()
        {
            DataStore store = new DataStore();
            DateTime date = new DateTime(2000, 11, 1, 1, 1, 30);
            String email = "myEmail.com";
            String name = "Hans";
            int resultSize = store.getProgrammers().Count;
            Programmer result = new MySingleSuperClass().GetWorstProgrammer(store.getProgrammers(), date, email, name);

            Assert.AreEqual(store.getProgrammers().Count, resultSize + 5);

        }

        [TestMethod]

        public void GetWorstProgrammer3()
        {
            DataStore store = new DataStore();
            DateTime date = new DateTime(2002, 11, 22, 1, 1, 30);
            String email = "myEmail.com";
            String name = "Hans";
            int resultSize = store.getProgrammers().Count;
            Programmer result = new MySingleSuperClass().GetWorstProgrammer(store.getProgrammers(), date, email, name);

            Assert.AreEqual(result.getLastname(), "Dieter");

        }

        [TestMethod]

        public void GetWorstProgrammer4()
        {
            DataStore store = new DataStore();
            DateTime date = new DateTime(2002, 11, 1, 1, 1, 56);
            String email = "myEmail.com";
            String name = "Hans";
            Programmer result = new MySingleSuperClass().GetWorstProgrammer(store.getProgrammers(), date, email, name);

            Assert.AreEqual(result.getLastname(), "Klaus");

        }

        [TestMethod]

        public void GetWorstProgrammer5()
        {
            DataStore store = new DataStore();
            DateTime date = new DateTime(2002, 11, 1, 1, 1, 20);
            String email = "myEmail.com";
            String name = "Hans";
            Programmer result = new MySingleSuperClass().GetWorstProgrammer(store.getProgrammers(), date, email, name);

        }

    }
}