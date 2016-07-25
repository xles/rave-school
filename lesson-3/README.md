Lesson 3
========

Topics covered:

* Arrays.
* The while loop.
* Iterators.
* The increment operator.

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

        i = 0;
        while (i < words.length) {
            Console.WriteLine( words[i] );
            i++;
        }
    }
}
```

Exercise:
---------


Create a version that prints the array in reverse
