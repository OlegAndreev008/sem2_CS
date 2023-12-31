﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое произвольное число: ");
int num = Convert.ToInt32(Console.ReadLine()); 
int index = 0;                      //Задаем счетчик цикла

if (num / 100 > 0)                  //Проверяем, является ли число трехзначным
{
    while (num / 1000 > 0)          //Цикл будет работать только до тех пор, пока число не станет 3хзначным
    {
        num = num / 10;             //Каждым счетчиком цикла мы отсекаем последнюю цифру от числа
        index++;
    }
    Console.WriteLine($"Третья цифра вашего числа - {num % 10}");    
}                                   //Остатком от деления на 10 от 3хзначного числа получаем последнюю (искомую) цифру
else
{
    Console.WriteLine("у числа нет третьей цифры");
}