﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    class ContactInformationTests: AuthTestBase
    {
        [Test]
        public void TestContactInformation()
        {
            //action
            ContactData fromTable = app.Contacts.GetContactInformationFromTable(0);
            ContactData fromFrom = app.Contacts.GetContactInformationFromEditForm(0);

            //verification
            Assert.AreEqual(fromTable, fromFrom);
            Assert.AreEqual(fromTable.Address, fromFrom.Address);
            Assert.AreEqual(fromTable.AllPhones, fromFrom.AllPhones);
            Console.WriteLine(fromTable.AllEmails);
            Console.WriteLine(fromFrom.AllEmails);
            Assert.AreEqual(fromTable.AllEmails, fromFrom.AllEmails);
        }

    }
}
