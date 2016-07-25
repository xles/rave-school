Lesson 1
========

___The following has been taken straight from [Wikipedia][wikipedia].___

The following is a very simple C# program, a version of the classic "Hello world" example:

```C#
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, world!");
    }
}
```

The effect is to write the following text to the output console:

```
Hello, world!
```

Each line has a purpose:

```C#
using System;
```

The above line of code tells the compiler to use `System` as a candidate prefix for types used in the source code. In this case, when the compiler sees use of the `Console` type later in the source code, it tries to find a type named `Console`, first in the current assembly, followed by all referenced assemblies. In this case the compiler fails to find such a type, since the name of the type is actually `System.Console`. The compiler then attempts to find a type named `System.Console` by using the `System` prefix from the using statement, and this time it succeeds. The using statement allows the programmer to state all candidate prefixes to use during compilation instead of always using full type names.

```C#
class Program
```

Above is a class definition. Everything between the following pair of braces describes `Program`.

```C#
static void Main()
```

This declares the class member method where the program begins execution. The .NET runtime calls the `Main` method. (Note: `Main` may also be called from elsewhere, like any other method, e.g. from another method of `Program`.) The `static` keyword makes the method accessible without an instance of `Program`. Each console application's `Main` entry point must be declared `static`. Otherwise, the program would require an instance, but any instance would require a program. To avoid that irresolvable circular dependency, C# compilers processing console applications (like that above) report an error, if there is no `static Main` method. The `void` keyword declares that `Main` has no return value.

```C#
Console.WriteLine("Hello, world!");
```

This line writes the output. `Console` is a static class in the `System` namespace. It provides an interface to the standard input, output, and error streams for console applications. The program calls the `Console` method `WriteLine`, which displays on the console a line with the argument, the string `"Hello, world!"`.

[wikipedia]: https://en.wikipedia.org/wiki/C_Sharp_(programming_language)#Examples