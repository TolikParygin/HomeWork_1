//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите три числа:");
int nomber1 = int.Parse(Console.ReadLine());
int nomber2 = int.Parse(Console.ReadLine());
int nomber3 = int.Parse(Console.ReadLine());
int max=nomber1;
if(nomber1>=max)
    max=nomber1;
if(nomber2>=max)
    max=nomber2;
if(nomber3>=max)
    max=nomber3;
Console.Write("max = "+ max);
