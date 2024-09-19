string firstName = "Weru";
string greeting = "Hello ";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);

int version = 11;
string updateText = "Update to Windows";
string message_1 = $"{updateText} {version}";
Console.WriteLine(message_1);

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

//string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine(russianMessage);