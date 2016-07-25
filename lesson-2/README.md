Lesson 2
========

Topics covered:

* Variables
* Basic data types.
* the `if` statement.

Code sample
-----------

`main.cs`:

```C#
using System;

class Program
{
    static void Main()
    {
        bool hello = true;

        if (hello) {
            Console.WriteLine("Hello, world!");
        } else {
            Console.WriteLine("Goodbye, world!");
        }
    }
}
```

Exercise:
---------

Create a version that switches based on a string type variable,
rather than the boolean variable used in the code sample.
