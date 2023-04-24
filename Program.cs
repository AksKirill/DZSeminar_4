// // Задача 25 - вводятся два числа А и В нужно число А возвести в сепень В

// double AstepenB(int A, int B)
// {
//     double resalt =Math.Pow(A,B);
//     return resalt;
// }
// Console.WriteLine("Программа возводит число А в  степень В. Введите число А: ");
// int A=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число B: ");
// int B=Convert.ToInt32(Console.ReadLine());

// double res=AstepenB(A,B);
// Console.WriteLine(res);

////////////////////////////////////////////////
// //Задача 27 Найти сумму цифр, входящих в число
// int SummaZifr(int a)
// {
//     string b=Convert.ToString(a);//превод числа в строку
//      Console.WriteLine("перевод числа в строку" +b);
//      int c=Convert.ToInt32(b.Length);
//     //  Console.WriteLine("длина строки в виде числа" +c);
//      int i=0; int res=0;
    
// for (i=0; i<c; i++)
//     {
//         string e=Convert.ToString(b[i]);
//         // Console.WriteLine("цифра " +e);
//         res=res+Convert.ToInt32(e);
//         // Console.WriteLine(e);
//     }
// return res;
// }
// Console.WriteLine("Программа считает сумму цифр числа. Введите число: ");
//  int a=Convert.ToInt32(Console.ReadLine());

// int res=SummaZifr(a);
// Console.WriteLine("Сумма цифр: " +res);

///////////////////////////////////////////////
// Задача 29 Программа задает массив из случайных чисел

//  Array GetArr(int a)
// {
//     string b=Convert.ToString(a);//превод числа в строку
//      Console.WriteLine("перевод числа в строку" +b);
//      int c=Convert.ToInt32(b.Length);
//     //  Console.WriteLine("длина строки в виде числа" +c);
//      int i=0; int res=0;
    
// for (i=0; i<c; i++)
//     {
//         string e=Convert.ToString(b[i]);
//         // Console.WriteLine("цифра " +e);
//         res=res+Convert.ToInt32(e);
//         // Console.WriteLine(e);
//     }
// return res;
// }
/////////////////////////////////////////////////////
// //Задача ввести 8-числовой массив, вывести их на экран
// Console.WriteLine("Программа задает массив из 8 чисел и выводит их на экран.");
//  int[] numArr=new int[8];
 
//  for (int i=0; i<8; i++)
// {
//     Console.WriteLine("Введите элемент массива номер " +(i+1));
//     numArr[i]=Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine("Элементы массива: " +String.Join("# ",numArr));


// // //////////////////////////////////////////////////////////////






