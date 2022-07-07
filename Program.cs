 // This is a comment character/symbol
﻿// See https://aka.ms/new-console-template for more information

// Console.WriteLine is from the system library and allows us access to write a line of text to the console.
// (__) parameters. These say we are sending Console.WriteLine whtever is insisde the ().
// "" denote a string literal.
// ; Endline character.

using System;
public class program {
    public static void Main() {
        Console.WriteLine("Hello");
        Console.Write(); //Writes to the console, but it does not automatically end the line
        Console.ReadLine(); //Reads from the console.
    }
}

// EVERYTHING IS AN OBJECT

// An object is ...
// a real world entity with state and behaviour.


namespace CSharpConcepts {

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World");

                        // Data Types

            int x = 5; //integer
            float y = 5.5;
            double z = 5.5;
            long a = 5;
            short b = 5;

            int newint = 4;

            switch(newint) {
                case 1: // if (newint == 1)
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            // for loops, while loops

            for (int i = 0; i < newint; i++) {
                Console.WriteLine(i);
            }

            while (newint < 10) {
                Console.WriteLine(newint);
                newint++;
            }

            // do while - will run at least once even if the condition is false

            do {
                Console.WriteLine(newint);
                newint++;
            } while (false);

            private int AddValues (int a, int b)
            {
                int answer = a + b;
                return answer;
            }

            int addedValues = AddValues(newint, 2);

            // OOP Principles
            // Encapsulation - Rich's bad gumball machine; limits access to outside parties (users, other systems, other
                // classes) to only the parts they need to know about.
            // Abstraction - Hiding the details of how something works.
            // Inheritance - creating new classes from existing classes. Can be described as an "Is-A" relationship.
                // a child/sub/derived class "is a" parent/super/base class. a dog "is an" animal.
                // inherited classes will receive all the members (fields and methods) of the parent class.
                // C# cannot do TRUE multiple inheritance, but it can fake it.

            // Polymorphism - taking on many forms, through method overloading and overriding
                // overloading - same method name, but different parameters
                    // example: AddValues(int a, int b)
                    // example: AddValues(int a, int b, int c)
                    // example: AddValues(double a, int b)
                // overriding - same method as parent, but different functionality

        }
    }
}