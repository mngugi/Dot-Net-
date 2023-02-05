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
