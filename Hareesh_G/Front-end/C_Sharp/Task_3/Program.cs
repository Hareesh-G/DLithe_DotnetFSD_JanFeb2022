using System;
namespace stringApplication
{
    class program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "Welcome";
            string s3 = "Javascript";
            char[] ch = { 'w', 'e', 'b', 'd', 'e', 'v', 'e', 'l', 'o', 'p', 'm', 'e', 'n', 't' };
            string s4 = new string(ch);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine("---------------------------------------------------------------------");
            //from string literal and string concatenation
            string fname, lname;
            fname = "jhon";
            lname = "seen";
            char[] letters = { 'j', 'a', 'v','a' };
            string[] sarray = { "Hello", "World", "Welcome", "Csharp" };
            string fullname = fname + lname;
            Console.WriteLine("Fullname: {0}", fullname);
            Console.WriteLine("---------------------------------------------------------------------");
            //by using string constructor { 'j', 'a', 'v', 'a' };
            string a = new string(letters);
            Console.WriteLine("Greetings: {0}", a );
            Console.WriteLine("--------------------------------------------------------------------");
            //methods returning string { "Hello", "World", "Welcome", "CSharp" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);
            Console.WriteLine("--------------------------------------------------------------------");
            //formating method to convert a value
            DateTime waiting = new DateTime(2020, 10, 12, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);
            Console.WriteLine("-------------------------------------------------------------------");
            string str1 = "Java";
            string str2 = "Javascript";
            if(string.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + "are not equal.");
            }
            Console.WriteLine("------------------------------------------------------------------");

            string str = "Welcome to Csharp";
            if (str.Contains("C#"))
            {
                Console.WriteLine("The Sequience 'c#' was found.");
            }
            Console.WriteLine("-----------------------------------------------------------------");
            string str3 = "Hello World";
            Console.WriteLine(str3);
            string substr = str3.Substring(5);
            Console.WriteLine(substr);
            Console.WriteLine("----------------------------------------------------------------------");
            string[] starray = new string[]
            {
                "c#",
                "Dotnet",
                "ASP.Net",
                "ADO.Net",
                "WPF" };
            string str4 = string.Join("\n ", starray);
            Console.WriteLine(str4);
            Console.WriteLine("------------------------------------------------------------------------");
            //The c# compareOrdinal() method two specified String objects by evaluating the numeric values of the corresponding char objects in each string.
            //if both strings are equal , it returns 0, if the first string is greater than second string, it returns positive number in difference else it negative number.
            string s11 = "hello";
            string s12 = "hello";
            string s13 = "csharp";
            string s14 = "mello";
            Console.WriteLine(string.CompareOrdinal(s11,s12));
            Console.WriteLine(string.CompareOrdinal(s11, s13));
            Console.WriteLine(string.CompareOrdinal(s11,s14));
            Console.writeLine("---------------------------------------------------------------------------")
                //The C# concat() method is used to concatenate multiple string objects.
                Console.writeLine(string.Concat(s11, s12));
            Console



            
        }
    }
}