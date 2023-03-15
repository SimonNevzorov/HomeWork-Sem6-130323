// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел:");
Console.WriteLine();
int num = Convert.ToInt32(Console.ReadLine());

int [] array = new int [num];

void FillArray ( int num)
{
     for (int i =0; i<num; i++)
     {Console.WriteLine($"Введите {i+1} число");
     array[i] = Convert.ToInt32(Console.ReadLine());
     }

     Console.WriteLine(String.Join(",", array));
}

int Count (int [] array)
{int a =0;
for (int i=0; i<array.Length; i++)
    {   
    if (array[i] > 0)
        a=a+1;
    }
return a;
 
}
FillArray(num);

Console.WriteLine("Количество введенных чисел, больше нуля равно " + Count(array));









    
