// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет


int number = Convert.ToInt32(Console.ReadLine());

if ((number == 6) || (number == 7)) {
   Console.Write("да"); 
}
else if  ((number>0) && (number<6)) {
   Console.Write("нет");  
}
else {
    Console.Write("ошибка"); 
}