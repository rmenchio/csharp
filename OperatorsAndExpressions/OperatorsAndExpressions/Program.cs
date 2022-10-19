/*
Hello, World!;
My name is Rodrigo Menchio and i will show you some about operators and expressions
*/

Console.WriteLine("Arithmetic operations");
Console.WriteLine("All operations like math");

/* INT/INT */
Console.WriteLine("int / int");
int nine = 9;
int four = 4;
int result = nine / four;

Console.WriteLine($"{nine}/{four} = {result}");
Console.WriteLine();

/* INT/0 */
Console.WriteLine("An integer cannot be divided by zero");
Console.WriteLine();

/* DOUBLE/INT */
Console.WriteLine("double / int or int / double");
double nine2 = 9.0;
int four2 = 4;
double result2 = nine2 / four2;

Console.WriteLine($"{nine2}/{four2} = {result2}");
Console.WriteLine();

/* DOUBLE/0 */
Console.WriteLine("double / 0");
double nine3 = 9.0;
double result3 = nine3 / 0;

Console.WriteLine($"{nine3}/0 = {result3}");
Console.WriteLine();

/* int++ and ++int */
Console.WriteLine("int++ returns value before increase");
Console.WriteLine("++int returns value after increase");
int number1 = 1;

Console.WriteLine(number1++);
Console.WriteLine(++number1);
Console.WriteLine();


Console.WriteLine("Logical operations");
Console.WriteLine("OBS: ^ is exclusive OR");
bool a, b;

Console.WriteLine("Scenery 1: a = true and b = true");
a = true;
b = true;

Console.WriteLine($"!a is {!a}");
Console.WriteLine($"a && b is {a && b}");
Console.WriteLine($"a || b is {a || b}");
Console.WriteLine($"a ^ b is {a ^ b}");
Console.WriteLine();

Console.WriteLine("Scenery 2: a = true and b = false");
a = true;
b = false;

Console.WriteLine($"!a is {!a}");
Console.WriteLine($"a && b is {a && b}");
Console.WriteLine($"a || b is {a || b}");
Console.WriteLine($"a ^ b is {a ^ b}");
Console.WriteLine();

Console.WriteLine("Scenery 3: a = false and b = true");
a = false;
b = true;

Console.WriteLine($"!a is {!a}");
Console.WriteLine($"a && b is {a && b}");
Console.WriteLine($"a || b is {a || b}");
Console.WriteLine($"a ^ b is {a ^ b}");
Console.WriteLine();

Console.WriteLine("Scenery 4: a = false and b = false");
a = false;
b = false;

Console.WriteLine($"!a is {!a}");
Console.WriteLine($"a && b is {a && b}");
Console.WriteLine($"a || b is {a || b}");
Console.WriteLine($"a ^ b is {a ^ b}");
Console.WriteLine();

Console.ReadLine();