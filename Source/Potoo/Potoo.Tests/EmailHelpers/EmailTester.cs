using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Potoo.Tests.EmailHelpers
{
    public static class EmailTester
    {
        public static void Test(string email, string pattern, bool matchExpected)
        {
            var matched = Regex.IsMatch(email, pattern);

            if (matched == matchExpected)
                Debug.WriteLine("Faild on email: " + email);

            Assert.IsTrue(matched == matchExpected);
        }
    }
}
