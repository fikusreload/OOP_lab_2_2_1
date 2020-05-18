using System;

namespace OOP_lab_2_2_1
{
    class Program
    {
        static void Main()
        {
            int someNumber = int.Parse(Console.ReadLine());

            switch (someNumber)
            {
                case 1:
                    Console.WriteLine("{0}. Антiпенко Анна Сергiївна", someNumber);
                    break;
                case 2:
                    Console.WriteLine("{0}. Бакум Павло Iгорович", someNumber);
                    break;
                case 3:
                    Console.WriteLine("{0}. Барабах Роман Тарасович", someNumber);
                    break;
                case 4:
                    Console.WriteLine("{0}. Василюк Iван Петрович", someNumber);
                    break;
                case 5:
                    Console.WriteLine("{0}. Грисюк Ігор Вiталiйович", someNumber);
                    break;
                case 6:
                    Console.WriteLine("{0}. Грушкiвський Богдан Артемович", someNumber);
                    break;
                case 7:
                    Console.WriteLine("{0}. Данилевич Роман Олександрович", someNumber);
                    break;
                case 8:
                    Console.WriteLine("{0}. Журавчак Юрiй Юрiйович", someNumber);
                    break;
                case 9:
                    Console.WriteLine("{0}. Зотов Вадим Павлович", someNumber);
                    break;
                case 10:
                    Console.WriteLine("{0}. Калинюк Дмитро Вiкторович", someNumber);
                    break;
            }
        }
    }
}
