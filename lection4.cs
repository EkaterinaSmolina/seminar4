// лекция 4

// string[,] table = new string[2,5];
// // String.Empty
// // столбцы table [0,1] table [0,2] table [0,3] table [0,4]
// // строка  table [1,0] 

// table[1,2]= "слово";

//     for (int rows = 0; rows < 2; rows++)
//     {
//         for (int columns=0; columns<5; columns++)
//         {
//             Console.WriteLine($"{table[rows,columns]}");
//         }
//     }


// int[,] matrix = new int[3,4];
// // // String.Empty
// // // столбцы table [0,1] table [0,2] table [0,3] 
// // // строка  table [1,0] 

//     for (int i = 0; i < 3; i++)
//     {
//         for (int j=0; j<4; j++)
//         {
//             Console.Write($"{matrix[i,j]} ");
//         }
//     Console.WriteLine();    
// //     }


// int[,] matrix = new int[3,4];

// void PrintArray(int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j=0; j<matr.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i,j]} ");
//         }
//     Console.WriteLine();    
//     }
// }


// //  доп. метод для заполнения таблицы случайными числами 

// // int[,] matrix = new int[3,4];


// void FillArray(int [,] matr)


// for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j=0; j<matr.GetLength(1); j++)
//         {
//            matrix[i,j] = new Random().Next(1,10); // [1,10)
//         }
       
//     }


// int[,] matrix = new int[3,4];

// PrintArray(matrix);

// FillArray(matrix);


// double Factorial(int n)
// {
// if (n==1) return 1;
// else return n*Factorial(n-1);
// }
// for (int i = 0; i < 40; i++)
// {
//     Console.WriteLine(Factorial(i));
// }



// f(1)=1
// f(2)=1
// f(n)=f(n-1)+f(n-2)

// double fibonacci(int n)
// {
//     if (n==1 || n == 2) return 1;
//     else return fibonacci(n-1) + fibonacci(n-2);

// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine(fibonacci(i));
// }


// СЕМИНАР 4


// int GetSum(int number)
// {
//     int sum = 0;
//     for (int i = 0; i <= Math.Abs(number); i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// Console.Clear();
// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine()); 
// Console.WriteLine($"{GetSum(num)}");


// void number(int x )
// {
//     int count = 0;
//     while (x != 0)
//     {
//         x = x / 10;
//         count++;
//     }
//     Console.WriteLine($"Введеное число имеет {count} значений");
// }

// Console.WriteLine(" Введие число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// number(n);








// *ДОМАШНЕЕ ЗАДАНИЕ 4* 

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 


double expon (int x, int y)
{
    double n = Math.Pow (x,y);
    return n;
}

Console.Clear();
Console.WriteLine(" Введие число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введие число B: ");
int B = Convert.ToInt32(Console.ReadLine());

double num = expon(A,B);
Console.WriteLine($"Число {A} в степени {B} = {num}");





//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.



int sum (int value)
{
    if (value < 10)
        return value;
        
    int digit = value % 10;
    int nextValue =value / 10;

    return digit + sum (nextValue);

}

Console.WriteLine(" Введие число А: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = sum (n);  
Console.WriteLine($" сумма всех цифр = {result}");
    

