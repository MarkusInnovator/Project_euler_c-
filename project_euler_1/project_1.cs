﻿// See https://aka.ms/new-console-template for more information
int count = 0;
for (int i = 0; i < 1000; i++)
{
   if (i % 3 == 0 || i % 5 == 0)
   {
      count += i;
   } 
}
Console.WriteLine(count);
