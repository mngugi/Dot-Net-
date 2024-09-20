// See https://aka.ms/new-console-template for more information
// mixed data types to force implicit typer coversions.
int firstNum = 23;
int secondNum = 87;
string firstName = "Victor";
int sum = 23 + 87;
int difference = 23 - 87 ;
int product = 23 * 87 ;
int quotient = 23 / 87 ;
decimal decimal_Quotient = 23.0 / 87.0 ;
int modulus = 200 % 5 ;
int modu_lus = 7 % 5 ;



Console.WriteLine(firstNum + secondNum);
Console.WriteLine(firstName + " sold " + firstNum + " books " + secondNum + " pens.");
Console.WriteLine("Total number of items sold is " + (firstNum + secondNum)+ ".");
Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
Console.WriteLine($"Decimal quotient: {decimal_Quotient}");
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");
