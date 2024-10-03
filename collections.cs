using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a stack of integers
        Stack<int> stack = new Stack<int>();

        // Add (Push) elements onto the stack
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);

        // Print the stack elements
        Console.WriteLine("Stack elements after pushing:");
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }

        // Remove (Pop) elements from the stack
        int poppedElement = stack.Pop();
        Console.WriteLine($"\nPopped element: {poppedElement}");

        // Remove another element
        poppedElement = stack.Pop();
        Console.WriteLine($"Popped element: {poppedElement}");

        // Print the stack elements after popping
        Console.WriteLine("\nStack elements after popping:");
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }

        // Peek at the top element without removing it
        int topElement = stack.Peek();
        Console.WriteLine($"\nTop element (peek): {topElement}");

        // Check the number of elements in the stack
        int count = stack.Count;
        Console.WriteLine($"\nNumber of elements in the stack: {count}");

        // Remove all elements from the stack
        while (stack.Count > 0)
        {
            stack.Pop();
        }
        
        Console.WriteLine($"\nStack count after clearing: {stack.Count}");
    }
}
