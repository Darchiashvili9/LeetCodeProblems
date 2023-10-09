using Foo;
using LINQ_Proj1;

namespace LINQ_Proj1
{
    /// <summary>
    /// Classes and structs that are not nested within other classes or structs can be either public or internal. A type declared as public is accessible by any other type. 
    /// A type declared as internal is only accessible by types within the same assembly. Classes and structs are declared as internal by default unless the keyword public is added to the class definition.
    /// </summary>
    internal class Program
    {
        public const string SomeConstant = "Put an end to those hundreds of Visual Studio Console projects cluttering your source folder!";
        public static string SomeMethod(string input) => input.ToUpper();


        static void Main(string[] args)
        {

            new MyClass().GetHelloMessage();

            Console.WriteLine(new Bar().GetHelloMessage());

            Console.WriteLine("Hello, World!");
        }


    }
    /// <summary>
    /// You cannot have a private class unless it is nested
    /// </summary>
    class MyClass
    {
        // We can access SomeConstant and SomeMethod here:
        public string GetHelloMessage() => Program.SomeMethod(Program.SomeConstant);
    }
}


namespace Foo
{
    class Bar
    {


        public string GetHelloMessage() => Program.SomeMethod(Program.SomeConstant);

        // You can also access SomeConstant and SomeMethod here
    }
}