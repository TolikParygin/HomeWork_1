//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Введите два числа:");
int nomber1 = int.Parse(Console.ReadLine());
int nomber2 = int.Parse(Console.ReadLine());
if(nomber1>=nomber2)
    Console.WriteLine("max "+ nomber1);
else
    Console.WriteLine("max "+ nomber2);
