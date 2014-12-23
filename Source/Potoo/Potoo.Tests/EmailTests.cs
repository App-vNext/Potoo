using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Potoo.Tests.EmailHelpers;

namespace Potoo.Tests
{
    [TestClass]
    public class EmailTests
    {
        [TestMethod]
        public void Inclusive_Should_Match_Valid_Email_List()
        {
            foreach (string email in DataHelper.CommonValidEmails())
                EmailTester.Test(email: email,
                                 pattern: Email.Inclusive,
                                 matchExpected: true);     
        }

        [TestMethod]
        public void Inclusive_Should_Not_Match_Invalid_Email_List()
        {
            foreach (string email in DataHelper.CommonInvalidEmails())
                EmailTester.Test(email: email,
                                 pattern: Email.Inclusive,
                                 matchExpected: false); 
        }

        [TestMethod]
        public void Rfc2822_Should_Match_Valid_Email_List()
        {
            var validEmails = new List<string>(DataHelper.CommonValidEmails())
            {
                @"Name Surname <name.surname@blah.com>", //RFC2822 email address
                @"""b. blah""@blah.co.nz"                //"b. blah"@blah.co.nz
            };

            foreach (string email in validEmails)
                EmailTester.Test(email: email,
                                 pattern: Email.Rfc2822,
                                 matchExpected: true);             
        }

        [TestMethod]
        public void Rfc2822_Should_Not_Match_Invalid_Email_List()
        {
            foreach (string email in DataHelper.CommonInvalidEmails())
                EmailTester.Test(email: email,
                                 pattern: Email.Rfc2822,
                                 matchExpected: false);
        }
    }
}
