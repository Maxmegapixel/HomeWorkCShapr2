// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. (Если решаете математически максимум берем 100000)
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);
string StNum = Convert.ToString(Num);

if (StNum.Length < 3) Console.WriteLine($" В числе: {Num} третьей цифры нет");
else Console.WriteLine($" В числе: {Num} третья цифра {StNum[2]}");