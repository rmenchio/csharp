/*
Hello, World!;
My name is Rodrigo Menchio and i will show you some types and variables of C#
*/


/*INTEGER TYPES*/

//sbyte - 8-bit - range: -128 <-> 127
sbyte minSbyte = -128;
sbyte minSbyte2 = sbyte.MinValue;

sbyte maxSbyte = 127;
sbyte maxSbyte2 = sbyte.MaxValue;

Console.WriteLine($"{minSbyte.GetTypeCode()} (sbyte)");
Console.WriteLine($"min value: {minSbyte}");
Console.WriteLine($"max value: {maxSbyte}");
Console.WriteLine($"default value: {default(sbyte)}");
Console.WriteLine();

//byte - 8-bit - range: 0 <-> 255
byte minByte = 0;
byte minByte2 = byte.MinValue;

byte maxByte = 255;
byte maxByte2 = byte.MaxValue;

Console.WriteLine($"{minByte.GetTypeCode()} (byte)");
Console.WriteLine($"min value: {minByte}");
Console.WriteLine($"max value: {maxByte}");
Console.WriteLine($"default value: {default(byte)}");
Console.WriteLine();

//short - 16-bit - range: -32768 <-> 32767
short minShort = -32768;
short minShort2 = short.MinValue;

short maxShort = 32767;
short maxShort2 = short.MaxValue;

Console.WriteLine($"{minShort.GetTypeCode()} (short)");
Console.WriteLine($"min value: {minShort}");
Console.WriteLine($"max value: {maxShort}");
Console.WriteLine($"default value: {default(short)}");
Console.WriteLine();

//ushort - 16-bit - range: 0 <-> 65535
ushort minUshort = 0;
ushort minUshort2 = ushort.MinValue;

ushort maxUshort = 65535;
ushort maxUshort2 = ushort.MaxValue;

Console.WriteLine($"{minUshort.GetTypeCode()} (ushort)");
Console.WriteLine($"min value: {minUshort}");
Console.WriteLine($"max value: {maxUshort}");
Console.WriteLine($"default value: {default(ushort)}");
Console.WriteLine();

//int - 32-bit - range: -2147483648 <-> 2147483647
int minInt = -2147483648;
int minInt2 = int.MinValue;

int maxInt = 2147483647;
int maxInt2 = int.MaxValue;

Console.WriteLine($"{minInt.GetTypeCode()} (int)");
Console.WriteLine($"min value: {minInt}");
Console.WriteLine($"max value: {maxInt}");
Console.WriteLine($"default value: {default(int)}");
Console.WriteLine();

//uint - 32-bit - range: 0 <-> 4294967295
uint minUint = 0;
uint minUint2 = uint.MinValue;

uint maxUint = 4294967295;
uint maxUint2 = uint.MaxValue;

Console.WriteLine($"{minUint.GetTypeCode()} (uint)");
Console.WriteLine($"min value: {minUint}");
Console.WriteLine($"max value: {maxUint}");
Console.WriteLine($"default value: {default(uint)}");
Console.WriteLine();

//long - 64-bit - range: -9223372036854775808 <-> 9223372036854775807
long minLong = -9223372036854775808;
long minLong2 = long.MinValue;

long maxLong = 9223372036854775807;
long maxLong2 = long.MaxValue;

Console.WriteLine($"{minLong.GetTypeCode()} (long)");
Console.WriteLine($"min value: {minLong}");
Console.WriteLine($"max value: {maxLong}");
Console.WriteLine($"default value: {default(long)}");
Console.WriteLine();

//ulong - 64-bit - range: 0 <-> 18446744073709551615
ulong minUlong = 0;
ulong minUlong2 = ulong.MinValue;

ulong maxUlong = 18446744073709551615;
ulong maxUlong2 = ulong.MaxValue;

Console.WriteLine($"{minUlong.GetTypeCode()} (ulong)");
Console.WriteLine($"min value: {minUlong}");
Console.WriteLine($"max value: {maxUlong}");
Console.WriteLine($"default value: {default(ulong)}");
Console.WriteLine();

/*REAL TYPES*/

//float - 32-bit - precision: 7 decimal points
float minFloat = float.MinValue;
float maxFloat = float.MaxValue;
float precisionFloat = 1.12345672f;

Console.WriteLine($"{minFloat.GetTypeCode()} (float)");
Console.WriteLine($"min value: {minFloat} (infinity negative representation)");
Console.WriteLine($"max value: {maxFloat} (infinity positive representation)");
Console.WriteLine($"precision: 7 and round last number -> {precisionFloat}");
Console.WriteLine($"default value: {default(float)}");
Console.WriteLine();

//double - 64-bit - precision: 15 or 16 decimal points
double minDouble = double.MinValue;
double maxDouble = double.MaxValue;
double precisionDouble = 1.12345678912345672;
double epsilon = double.Epsilon; // the closest positive double type to zero.

Console.WriteLine($"{minDouble.GetTypeCode()} (double)");
Console.WriteLine($"min value: {minDouble} (infinity negative representation)");
Console.WriteLine($"max value: {maxDouble} (infinity positive representation)");
Console.WriteLine($"precision: 15 or 16 and round last number -> {precisionDouble}");
Console.WriteLine($"default value: {default(double)}");
Console.WriteLine();

//decimal - 128-bit - precision: 28 or 29 decimal points
decimal minDecimal = decimal.MinValue;
decimal maxDecimal = decimal.MaxValue;
decimal precisionDecimal = 1.123456789123456789123456789123m;

Console.WriteLine($"{minDecimal.GetTypeCode()} (decimal)");
Console.WriteLine($"min value: {minDecimal} (infinity negative representation)");
Console.WriteLine($"max value: {maxDecimal} (infinity positive representation)");
Console.WriteLine($"precision: 28 or 29 and round last number -> {precisionDecimal}");
Console.WriteLine($"default value: {default(decimal)}");
Console.WriteLine();

// OBS: in real types, the last number is only rounded if it is above the maximum precision point

/*BOOLEAN TYPES*/

//bool - true or false
bool boolTrue = true;
bool boolFalse = false;

bool isTrue = 5 > 3;
bool isFalse = 2 < 1;

Console.WriteLine($"{boolTrue.GetTypeCode()} (bool)");
Console.WriteLine("the bool value can be the result of an arithmetic operation");
Console.WriteLine($"5 > 3 => {isTrue}");
Console.WriteLine($"2 < 1 => {isFalse}");
Console.WriteLine($"default value: {default(bool)}");
Console.WriteLine();

/*CHARACTER TYPES*/

//char - 16 bits
//char types have a int representation to each character 

char ch = 'a';

Console.WriteLine($"{ch.GetTypeCode()} (char)");
Console.WriteLine($"the code of '{ch}' is {(int)ch}");
Console.WriteLine($"default value: {default(char)}");
Console.WriteLine();

/*STRING TYPES*/

string myName = "Rodrigo Menchio";

Console.WriteLine($"{myName.GetTypeCode()} (string)");
Console.WriteLine($"default value: {default(string)}");
Console.WriteLine();

/*OBJECT TYPES*/

object alsoMyName = "Rodrigo Menchio";

Console.WriteLine($"{alsoMyName.GetType()} (object)");
Console.WriteLine($"default value: {default(object)}");
Console.WriteLine("object type are universal data containers, identify memory areas");
Console.WriteLine();

/*VARIABLES, VALUE AND REFERENCE TYPES*/

Console.WriteLine("variables are a specific area in memory that contain data and fixed size");
Console.WriteLine("reference types point to the dynamic memory, wherefore they have variable size in memory");
Console.WriteLine("reference types: arrays, objects and string");
Console.ReadLine();