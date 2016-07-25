Lesson 4
========

Topics covered:

* The for loop.

Code sample
-----------

`main.cs`:

```C#
using System;

class Program
{
    static void Main()
    {
        int i;
        string[] words = {
            "Breasts",
            "Boobs", 
            "Tits"
        };

        for (i = 0; i < words.length; i++) {
            Console.WriteLine( words[i] );
        }
    }
}

```

Exercise:
---------

Create a version that prints the array in reverse
