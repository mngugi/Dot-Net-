### Welcome to the Dot-Net- wiki!

# Dot-Net-
This Repo is about running .Net on Fedora as well as Dot Net development. 
Install the .NET 7 Software Development Kit (SDK) using this command:

`sudo dnf install -y dotnet-sdk-7.0`
Create a new .NET 7 project in the C# language:

`dotnet new console -o HelloWorldConsole`
Switch to the project directory:

`cd HelloWorldConsole`

Build and run your the application:

`dotnet run`

---
**Example HelloWorld!**
```C#
cat Program.cs 
// Hello World! code
Console.WriteLine("Hello, World!");
```
**Output:**
`Hello, World!`

### Alterntively 
- Use the standard C# Coding procedure.
```C#
using System;
class Hello
{
  static void Main(string[] args)
  {
      Console.WriteLine("Hello Hello World");
  }
}

```
This is a C# code that outputs "Hello Hello World" on the console. The code defines a class named "Hello" with a Main method. The Main method uses the Console.WriteLine method to display the string "Hello Hello World".


---
### Mono Complete

- Mono is an open-source implementation of the .NET framework and can be installed using the following code.
  `sudo apt install mono-complete`
  Compile the program by using the following steps:
  `mcs filename.cs`
  and call
  `mono filename.exe`


---
### challenge1.cs

```c#
//https://learn.microsoft.com/en-us/training/modules/csharp-write-first/4-challenge
//Write code in the .NET Editor to display two messages
//This is the first line.
//This is the second line.
//
//
using System;
class challenge1
{
  static void Main(string[] args)
  {
      Console.WriteLine("This is the first line.");
      Console.WriteLine("This is the second line.");
  }
}


```

This is a C# code that outputs two messages on the console: "This is the first line." and "This is the second line.". The code defines a class named "challenge1" with a Main method. The Main method uses the Console.WriteLine method to display the two messages on separate lines.

---

### challenge2.cs
**Code:**

```C#
/*
C# program where user enters a value for the variable, in this case variable i
Console.ReadLine() function takes an input typed by the user.
Console.WriteLine() function prints the value of i and prints it on the console or terminal
*/
using System;
class read_line
{
  static void Main(string[] args)
  {
	string i;
	i = Console.ReadLine();
	Console.WriteLine(i);
  }
	
}

```
This is a C# program that takes an input from the user and displays it on the console.

The program declares a string variable i and assigns its value to the input received from the user using the Console.ReadLine method. The value received from the user is then printed to the console using the Console.WriteLine method.

When executed, the program will prompt the user to enter a value, and the value entered by the user will be stored in the i variable. The value of i will then be printed to the console.

---

### C_SharpTypes.cs
**Code:**

```C#
/*
 a c# program that displays keywords 
*/

using System ; 
class keywords {
    static void Main(String[] args) {
    /*int    a = 4;
    double b = 3.14567 ;
    float  c = 3.2e ;
    char   d = 'K' ;
    bool   e = true ;
    uint   f =  54;
    short  g = 6 ;
    ushort h =  16;
    long   i =  1924;
    ulong  j = 1986 ;
    
     */
    int a = 4;
  float b = 2.2f;
  double c = 2.54;
  char d = 'a';
  bool e = true;
  uint f = 43;
  short g = 2;
  ushort h = 19;
  long i = 123;
  ulong j = 34;

  Console.WriteLine(a);
  Console.WriteLine(b);
  Console.WriteLine(c);
  Console.WriteLine(d);
  Console.WriteLine(e);
  Console.WriteLine(f);
  Console.WriteLine(g);
  Console.WriteLine(h);
  Console.WriteLine(i);
  Console.WriteLine(j);
    
    
    } 

}


```

This program is written in C# and declares a class called "keywords" with a Main method. The Main method declares several variables of different data types (int, float, double, char, bool, uint, short, ushort, long, and ulong), assigns values to them, and writes their values to the console using Console.WriteLine().

---
