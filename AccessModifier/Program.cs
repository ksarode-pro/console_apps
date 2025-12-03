using System;

/*
List of Access Modifiers:
| Modifier               | Scope / Visibility Description                                           | Accessible From                                               |
| ---------------------- | ------------------------------------------------------------------------ | ------------------------------------------------------------- |
| **public**             | No restriction                                                           | Any class in any assembly                                     |
| **private**            | Only within the containing class                                         | Same class only                                               |
| **protected**          | Containing class + derived classes                                       | Same class and all subclasses (including in other assemblies) |
| **internal**           | Only within the same assembly                                            | Any code in the same project/assembly                         |
| **protected internal** | *Union*: protected **OR** internal (whichever allows access)             | Same assembly OR any subclass in any assembly                 |
| **private protected**  | *Intersection*: private **AND** protected (both conditions must be true) | Accessible only to subclasses **within the same assembly**    |


*/


//Only public and internal are allowed for top-level types (like class, interface at namespace level).
//Default is internal if no modifier is specified.
namespace AccessModifier
{
    //Only public and internal are allowed for top-level types (like class, interface at namespace level).
    //Default is internal if no modifier is specified.
    class Program
    {
        public static void Main(string[] args)
        {
            A a = new();
            a.Show();
            B b = new();
            b.ShowB();
            C c = new();
            c.ShowC();
        }
    }

    class A
    {
        private int number = 10;
        protected int number2 = 20;
        //What is the default access modifier for a class?
        //internal for top-level classes, private for class members.
        int number3 = 30;
        public void Show()
        {
            System.Console.WriteLine("Number = " + number);
            System.Console.WriteLine("Number2 = " + number2);
            System.Console.WriteLine("Number3 = " + number3);
        }
    }

    class B : A
    {
        public void ShowB()
        {
            System.Console.WriteLine("Number2 in B = " + number2);
            //System.Console.WriteLine("number3 in B = " + number3);
            //'A.number3' is inaccessible due to its protection level
        }
    }

    class C : B
    {
        public void ShowC()
        {
            System.Console.WriteLine("Number2 in C = " + number2);
            //runtime error - 'A.number' is inaccessible due to its protection level
            //System.Console.WriteLine("Number in C = " + number);
        }
    }



}