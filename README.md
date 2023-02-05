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
### C# Operators and Operands
**Code:**

```C#
/*Arithmetic Operators are the type of operators which take numerical 
*values as their operands and return a single numerical value
*/
using System;

class Arithmetic_operators {

static void Main (string[] args){

	int i=14, j=5;
	int a = 8, b=2, c=7, d=9;
	Console.WriteLine(" --------------------------------");
	Console.WriteLine("Arithmetic Operators:\n");
	Console.WriteLine("Adds Operands: " +(i+j));
	Console.WriteLine("Subtract Operands: " +(i-j));
	Console.WriteLine("Multiplication Operands: " +(i*j));
	Console.WriteLine("Division Operands: " +(i/j));
	Console.WriteLine(" --------------------------------\n");
	Console.WriteLine("Relational and Equality Operators:\n");
	Console.WriteLine("Equal to Operands ==: " +(i==j));
	Console.WriteLine("Not equal to Operands !=: " +(i!=j));
	Console.WriteLine("Greater than Operands: " +(i>j));
	Console.WriteLine("Less than Operands: < " +(i<j));
	Console.WriteLine("Greater than or equal to Operands  >=: " +(i>=j));
	Console.WriteLine("Less than or equal to Operands: < " +(i<=j));
	Console.WriteLine(" --------------------------------");
	Console.WriteLine("Logical Operators");
	Console.WriteLine("&& Logical AND If both the operands are non-zero, then the condition becomes true (i && j) is true");
	
	Console.WriteLine("(a>b) && (b==a) = " + ((a>b) && (b==a)));
	Console.WriteLine("|| Logical OR. If any one or both the operands are non-zero, then the condition becomes true (a || b) is true");
  	Console.WriteLine("(a>b) || (b==a) = " + ((a>b) || (b==a)));
  	Console.WriteLine("! Logical NOT. It is used to reverse the condition. So, if a condition is true, ! makes it false and vice versa.(!(false)) is true");
  	Console.WriteLine("!(a > b) = " + !(a > b));
  	
  	Console.WriteLine(" --------------------------------");
  	
  	string  k = "= Assigns value of right operand to left operand C = A+B is same as C = A + B\n+= Adds the value of right operand to left operand and assigns the final value to the left operand C += A is same as C = C + A\n-= Subtracts the value of right operand from left operand and assigns the final value to the left operand C -= A is same as C = C - A\n*= Multiplies the value right operand to left operand and assigns the final value to the left operand C *= A is same as C = C * A\n/= Divides the value of left operand from right operand and assigns the final value to the left operand C /= A is same as C = C / A\n%= Takes modulus using two operands and assigns the result to the left operand C %= A is same as C = C % A ";
  	
  	Console.WriteLine("Assignment Operators\n " +(k));
  	Console.WriteLine(" --------------------------------\n");
  	string l = " ++ and -- are called increment and decrement operators respectively.\n++ adds 1 to the operand whereas -- subtracts 1 from the operand.\na++ increases the value of a variable a by 1 and a-- decreases the value of a by 1.Similarly, ++a increases the value of a by 1 and\n --a decreases the value of a by 1.\nIn a++ and a--, ++ and -- are used as postfix whereas in ++a and --a, ++ and -- are used as prefix.\nFor example, suppose the value of a is 5, then a++ and ++a changes the value of a to 6. Similarly, a-- and --a changes the value of a to 4. ";
  	
  	Console.WriteLine("Increment and Decrement Operators" +(l));
  	Console.WriteLine(" --------------------------------\n");
  	
  	Console.WriteLine("Difference between Prefix and Postfix ");
  	
  	Console.WriteLine("a++:  Value of a: " + (a++));
  	Console.WriteLine("++b: Value of a: " + (++b));
  	Console.WriteLine("c--: Value of a: " + (c--));
  	Console.WriteLine("--d: Value of a: " + (--d));
	Console.WriteLine("---------------------------------\n");
	Console.WriteLine("sizeof() operator to get the size of data type");
	Console.WriteLine("size of int : " + sizeof(int));
  	Console.WriteLine("size of long : " + sizeof(long));
 	Console.WriteLine("size of unsigned int : " + sizeof(uint));
	Console.WriteLine("size of boolean : " + sizeof(bool));
	Console.WriteLine("size of short : " + sizeof(short));
	Console.WriteLine("size of unsigned short : " + sizeof(ushort));
	Console.WriteLine("size of double : " + sizeof(double));
	Console.WriteLine("size of char: " + sizeof(char));
	Console.WriteLine("---------------------------------\n");
	Console.WriteLine("typeof() operator to get the size of data type");
	Console.WriteLine("size of int : " + typeof(int));
  	Console.WriteLine("size of long : " + typeof(long));
 	Console.WriteLine("size of unsigned int : " + typeof(uint));
  	Console.WriteLine("size of boolean : " + typeof(bool));
  	Console.WriteLine("size of short : " + typeof(short));
  	Console.WriteLine("size of unsigned short : " + typeof(ushort));
  	Console.WriteLine("size of double : " + typeof(double));
  	Console.WriteLine("size of char: " + typeof(char));
  	
  	Console.WriteLine("---------------------------------\n");
  	Console.WriteLine("Math Class\n");
  	Console.WriteLine(Math.Sin(Math.PI));
  	Console.WriteLine(Math.Cos(Math.PI));
  	Console.WriteLine(Math.Abs(-1));
  	Console.WriteLine(Math.Floor(3.4));
  	Console.WriteLine(Math.Ceiling(3.4));
  	Console.WriteLine(Math.Pow(4, 2));
 	Console.WriteLine(Math.Log10(100));
  	Console.WriteLine(Math.Sqrt(4));
  	
  	Console.WriteLine("End ...");
	
  }

}


```
This C# program demonstrates the use of various arithmetic, relational and equality, logical, assignment, increment and decrement operators in C#. The program outputs the result of operations performed using these operators. The output includes adding, subtracting, multiplying, and dividing operands, checking equality and relational operations, logical operations (AND, OR, NOT), assignment operations, increment and decrement operations, and finding the size of data types using the sizeof() operator.
