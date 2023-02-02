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
### Mono Complete

- Mono is an open-source implementation of the .NET framework and can be installed using the following code.
  `sudo apt install mono-complete`
  Compile the program by using the following steps:
  `mcs filename.cs`
  and call
  `mono filename.exe`

---
