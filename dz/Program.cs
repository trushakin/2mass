// Урок 5. Двумерные Массивы ДОМАШКА

// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

System.Console.WriteLine("Задайте размер  строки массива ");
int numberMas= Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Задайте размер  столбца массива ");
int numberMas1= Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine("Введите индекс строки массива ");
int num= Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите индекс столбца массива ");
int num1= Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

int [,]array= new int[numberMas,numberMas1];
void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]= new Random().Next(1,10);
        }
    }

}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j]+" ");
        }
    System.Console.WriteLine();
    }  
}

void CheckArray()

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i==num && j ==num1)
                {
                   System.Console.Write("=> "+array[num,num1]); 
                }
        }
    }
    if (num >array.GetLength(0) || num1 >array.GetLength(1) )
        {
            System.Console.WriteLine(" такого элемента нет ");
        }

}



CreateArray();
PrintArray();
CheckArray();
