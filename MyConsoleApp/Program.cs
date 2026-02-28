// Exibindo mensagens simples no console
Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);

// Exibindo múltiplas mensagens e controlando espaços manualmente
Console.WriteLine("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first line of code in C#!");

// Diferença entre WriteLine (quebra linha) e Write (não quebra linha)
Console.WriteLine("This is the first line.");
Console.Write("This is the second line.");

// Declaração, atribuição e exibição de variável string
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);

//Reatribuir o valor de uma variável
string firstName;
firstName = "Anderson";
Console.WriteLine(firstName);
firstName = "Alex";
Console.WriteLine(firstName);
firstName = "Eduardo";
Console.WriteLine(firstName);
firstName = "ericles";
Console.WriteLine(firstName);

//Declaração e atribuição de uma variável em uma única linha
string firstName = "Anderson";
Console.WriteLine(firstName);


//variável local tipada implicitamente.
Você não escreveu o tipo, mas o C# descobre automaticamente.
var message = "Hello world!";
Console.WriteLine(message);


//Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.
var firstName = "Anderson";
var message = 3;
var temp = 34.4;
Console.WriteLine("Hello, " + firstName + "!" + " You have " + message + " messages in your inbox." + " The temperature is " + temp + " Celsius.");

//Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.
string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");

