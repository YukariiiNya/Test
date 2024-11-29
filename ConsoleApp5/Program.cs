using System;
using InspectorLib;

namespace IvanovTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var insp = new FunctionInsp();

            Console.WriteLine("Тестирование библиотеки InspectorLib\n");

            // 1. Получение главного инспектора
            Console.WriteLine("Главный инспектор: " + insp.GetInspector());

            // 2. Получение названия автоинспекции
            Console.WriteLine("Название автоинспекции: " + insp.GetCarInspection());

            // 3. Смена главного инспектора
            Console.WriteLine("Попытка сменить главного инспектора на 'Миронов А.В.': " +
                              (insp.SetInspector("Миронов А.В.") ? "Успех" : "Неудача"));
            Console.WriteLine("Главный инспектор после смены: " + insp.GetInspector());

            // 4. Генерация госномера
            string generatedNumber = insp.GenerateNumber("123", "A", "75");
            Console.WriteLine("Сгенерированный номер: " + generatedNumber);

            // 5. Список сотрудников
            Console.WriteLine("Список сотрудников:");
            foreach (var worker in insp.GetWorker())
            {
                Console.WriteLine(worker);
            }

            // 6. Добавление нового сотрудника
            insp.AddWorker("Петров П.П.");
            Console.WriteLine("Список сотрудников после добавления:");
            foreach (var worker in insp.GetWorker())
            {
                Console.WriteLine(worker);
            }
        }
    }
}
