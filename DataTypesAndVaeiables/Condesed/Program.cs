﻿using System;
using System.Linq;

namespace Condesed
{
    class Program
    {
        static void Main(string[] args)
        {
            var temps = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            // създавам array който приема данните от входа
            int[] arr = temps.Select(int.Parse).ToArray();
            //тук ги парсвам във друг array и вече имам масив със инт входове
            int[] condensed;
            // създавам масива във който ще пълня сумите от клетките
            do
                //създавам do за да повтаря цикъла вътре за да може постоянно като намалим дължината
                //на масива да се изпълни отново
            {
                condensed= new int[arr.Length-1];
                //задавам дължина на масива във който ще пълним сумите като той винаги трабва да е
                //със едно по малко.
                for (int i = 0; i < arr.Length - 1; i++)
                    //цикъла ще върти със 1 път по малко от дължината на arr
                {
                    condensed[i] = arr[i] + arr[i + 1];
                    //condensed ще се напълни със сумите на [i] и [i+1] докато върти цикъла
                    arr[i] = condensed[i];
                    //присвояваме на i позиция сбора от 0 и 1ва позиция и след това 1 и 2 и т.н
                }
                //тъй като цикъла ще завърти arr-1 пъти и ще можем да напълним 1 condensed със
                //дължина arr-1 а по условие трябва да стигнем до дължина от 1 елемент затова
                // сме във do
                Array.Resize(ref arr, condensed.Length);
                //променям всеки път дължината на оригиналния ни масив  arr да е == на дължината на 
                //condensed който пък всеки път е равен на дължината на arr-1 което ще рече следното
                //в случая 2 10 3 arr има дължина от 3 а condensed дължина от 2
                //след като напълним condensed arr е все още със дължина 3 затова го resize
                //със дължината на condensed и в случая arr ще има дължина 2 и ще има стойности
                //arr{12,13}
                //тъй като отдолу условието няма да е изпълнено защото дължината на condensed e 2 повтаряме 
                //DO и ни връща горе където condensed[arr.Lenght-1] но вече arr е дълъг 2 тоест ще завъртим
                //1 път и ще направи сметката в цикъл 12+13
                // и следователно condensed [arr.Lenght-1(което в случая е 2-1=1)]
                //и се изпълнява условието и излизаме от Do цикъла и принтим само единия елемент

            } while (condensed.Length!=1);
            Console.WriteLine(arr[0]);
        }
    }
}
