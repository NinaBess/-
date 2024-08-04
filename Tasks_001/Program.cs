// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// M = 1; N = 5
// M = 4; N = 8

void Main()
{ 
        System.Console.Write("Введите значение M: "); 
        int M = Convert.ToInt32(Console.ReadLine());  
        System.Console.Write("Введите значение N: "); 
        int N = Convert.ToInt32(Console.ReadLine()); 
 
        PrintInterval(M, N); 
        PrintInterval(N, M); 
} 
void PrintInterval(int max, int min)
{
    if (max < min) return;
    PrintInterval(max-1, min);
    System.Console.Write(max + " ");
}

Main();
