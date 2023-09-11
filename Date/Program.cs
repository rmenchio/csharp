DateTime data1 = new DateTime(2000, 10, 10, 2, 15, 10);
DateTime data2 = new DateTime(2001, 10, 10, 10, 10, 10);

bool compDatas = data1 < data2;

//Console.WriteLine("Data 1 é menor que data 2: {0}", compDatas);


bool compHoras = data1.TimeOfDay < data2.TimeOfDay;

//Console.WriteLine("Hora 1 é menor que hora 2: {0}", compHoras);

Console.WriteLine(data1.AddHours(-3).TimeOfDay);
Console.ReadLine();