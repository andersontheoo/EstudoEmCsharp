
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


//Sequencia de escape 
Console.WriteLine("Hello\nWorld!"); //exibir quebra de linha
Console.WriteLine("Hello\tWorld!"); //exibir tabulação
Console.WriteLine("Hello \"World\"!"); //exibir aspas duplas
Console.WriteLine("C: \\sources\\repos\\MyConsoleApp"); //exibir barra invertida


//Gerando faturas para o cliente "Contoso Corp" ...
Console.WriteLine("Generating invoices for custumer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");

//Exibindo o caminho do diretório onde os arquivos de fatura foram salvos
Console.WriteLine(@"    c:\source\repos
         (This is where you code goes)");

//Exibindo o caminho do diretório onde os arquivos de fatura foram 
//salvos usando verbatim string literal
Console.Write(@"c:\invoices");


//Para gerar faturas em japonês:
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");


// Concatenando strings usando o operador +
string firstName = "Anderson";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);

// Concatenando strings usando interpolação de string
string firstName = "Anderson";
string greeting = "Hello";
string message = $"{greeting} {firstName}!";
Console.WriteLine(message);

string firstName = "Anderson";
string secondName = "Teotonio da Silva";
String message = $"Hello {firstName} {secondName}!";
Console.WriteLine(message);


// Concatenando strings usando interpolação de stringx
int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);

int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");


//Interpolação de string com expressões
//@ de prefixo literal textual e o símbolo $ de interpolação de cadeia de caracteres juntos.
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

//atividade de interpolação de string com expressões
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

//resultado
string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t{russianLocation}\n");