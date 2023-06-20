
/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа */

// Console.WriteLine("Enter a 3 digit number:");
// int num =  Convert.ToInt32(Console.ReadLine());
// if (num > 99 && num < 1000)
//     {
//         num /= 10;
//         Console.WriteLine("The second digit is " + num%10);
//     }   
// else Console.WriteLine("Enter a 3 digit number");

/*Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет*/

// Console.WriteLine("Enter number: ");
// int num =  Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("The number is " + num);
// if (num >= -99 && num <= 99)
//     Console.WriteLine("There's no 3rd digit");
// else
// {
//     num /= 100;
// }
// Console.WriteLine("Третья цифра заданного числа: " + num%10);


/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/

// Console.WriteLine("Enter the number for a week day: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day == 6 || day == 7)
// {
//     Console.WriteLine("It's weekend");g
// } 
// else if (day <= 5 && day >= 1)
// {
//     Console.WriteLine ("It's workday");
// }
// else 
// {
//     Console.WriteLine("Enter a number from 1 to 7");
// }