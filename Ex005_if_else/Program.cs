﻿Console.WriteLine("Введите ваше имя: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
Console.WriteLine("Привет, красавица " + username);
}
else{
    Console.WriteLine("Привет, просто " + username);
}
