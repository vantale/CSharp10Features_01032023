namespace ExtendedPropertyPatterns
{
    public class ExtendedPropertyPatterns
    {
        public void Execute()
        {
            var person = new Person();

            if (person is Person { Address: { StreetName: "Warszawska" } })
            {
                Console.Write("Yes!");
            }
            else Console.WriteLine("No!");
        }

        public void Execute2()
        {
            var person = new Person();

            if (person is Person { Address.StreetName: "Warszawska" })
            {
                Console.Write("Yes!");
            }
            else Console.WriteLine("No!");
        }

        public void Execute3()
        {
            var person = new Person();

            var result = person switch
            {
                { FirstName: "Anna", Address.City: "Warszawa" } => "3", // unreacheable if moved further
                { FirstName : "Anna"} => "1",
                { LastName : "Kovalsky"} => "2",
                
                _ => throw new NotImplementedException(),
            };
        }
    }
}
