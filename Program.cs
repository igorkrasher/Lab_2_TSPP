namespace TodoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Створюємо об'єкт сервісу (як і радив викладач)
            ItemService service = new ItemService();

            // 2. Додаємо перше завдання
            service.Add("Купити хліб");
            service.Add("Зробити лабу з ТСПП");

            // 3. Виводимо список завдань на екран
            Console.WriteLine("Мій список справ:");
            var allItems = service.GetAll();

            foreach (var item in allItems)
            {
                Console.WriteLine($"[{item.Id}] {item.Title} - Виконано: {item.IsCompleted}");
            }

            // 4. ТА САМА ПАУЗА, щоб консоль не закривалася
            Console.WriteLine("\nНатисніть будь-яку клавішу, щоб вийти...");
            Console.ReadKey();
        }
    }
}
