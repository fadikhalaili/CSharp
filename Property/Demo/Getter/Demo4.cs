namespace CSharpCourse.Property.DemoGetter
{
    public class Demo4
    {
        // Smidigare att bara använda en pil

        public class Phone
        {
            private string? _color;

            public string Color
            {
                get => _color;
                set
                {
                    if (!(value == "red" || value == "yellow"))
                    {
                        throw new Exception("Ogiltig färg");
                    }
                    _color = value;
                }
            }



            public decimal Price { get; set; }
            public decimal VAT => Price * 0.25M;
            public decimal TotalPrice => Price + VAT;
        }

        public static void Run()
        {
            var telefon = new Phone
            {
                Price = 1000
            };

            telefon.Color = "red";
            //telefon.Color = "ddddd"; // Kommer ge exception

            Console.WriteLine($"Momsen för telefonen är {telefon.VAT}kr");
            Console.WriteLine($"Total kostnad för telefonen är {telefon.TotalPrice}kr");
        }
    }
}
