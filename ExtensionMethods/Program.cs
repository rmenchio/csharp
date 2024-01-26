using ExtensionMethods;

string mensagemLonga = "Lorem ipsum dolor sit amet consectetur adipiscing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

int numeroPalavras = 5;

string mensagemCurta = mensagemLonga.EncurtarMensagem(numeroPalavras);

Console.WriteLine(mensagemCurta);


// Existe a possibilidade de colocar um extension method no namespace System,
// para que não haja a necessidade de utilizar um outro namespace.
// Exemplo:

string primeirasLetras = mensagemCurta.SomentePrimeirasLetras();

Console.WriteLine(primeirasLetras);
Console.ReadLine();