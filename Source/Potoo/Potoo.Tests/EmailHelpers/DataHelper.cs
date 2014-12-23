using System.Collections.Generic;

namespace Potoo.Tests.EmailHelpers
{
    public static class DataHelper
    {
        public static List<string> CommonValidEmails()
        {
            return new List<string>
            {
                "bob@bob.com",
                "bob+google@bob.com",
                "bob@bob.to",
                "bob@bob.uk.com",
                "bob94@bob.com",
                "123bob456@bob.com",
                "bob@bob.solutions"           
            };           
        }


        public static List<string> CommonInvalidEmails()
        {
            return new List<string> //TODO: maybe try some wierd unicode characters? research common problems?
            {
                "",
                "@",
                "bob",
                "bob@",
                "bob@.com",
                "bob jones@.com",
                " bob@.com",
                "bob @bob.com",
                "bob@bob .com",
                "bob@bob. com",
                "bob@bob",
                "@bob",
                "@bob.com" 
            };
        } 

    }
}
