namespace dz20_11_1
{
    internal class Program
    {
        public class Device
        {
            public string Name { get; set; }
            public string Description { get; set; }

            public Device(string name, string description)
            {
                Name = name;
                Description = description;
            }

            public virtual void Sound()
            {
                Console.WriteLine("Це звук бази.");
            }

            public void Show()
            {
                Console.WriteLine($"Назва пристрою: {Name}");
            }

            public void Desc()
            {
                Console.WriteLine($"Опис пристрою: {Description}");
            }
        }

        public class Kettle : Device
        {
            public Kettle() : base("Чайник", "щоб робити вода буль буль.") { }

            public override void Sound()
            {
                Console.WriteLine("буль буль буль");
            }
        }


        public class Microwave : Device
        {
            public Microwave() : base("МИКРОХИЛЬЬОВКА", "Пристрій для розігрівання їжі.") { }

            public override void Sound()
            {
                Console.WriteLine("жух жух жух а потім дзинь");
            }
        }


        public class Car : Device
        {
            public Car() : base("Автомобіль", "ну щоб дріфтувати.") { }

            public override void Sound()
            {
                Console.WriteLine("ну коли тормозиш то скрип, а якщо литиш в іншу машину то ти материшся");
            }
        }


        public class Steamer : Device
        {
            public Steamer() : base("Пароход", "ну кароч титанік на пару.") { }

            public override void Sound()
            {
                Console.WriteLine("Ту-тууууууууууууууууу");
            }
        }
        static void Main(string[] args)
        {
            Device[] devices = {
            new Kettle(),
            new Microwave(),
            new Car(),
            new Steamer()
        };

            foreach (var device in devices)
            {
                device.Show();
                device.Desc();
                device.Sound();
                Console.WriteLine();
            }
        }
    }
}