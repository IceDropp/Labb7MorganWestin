namespace Labb7MorganWestin
{
    class Program
    {
        static void Main(string[] args)
        {
            Geometri[] shapes = new Geometri[]                              //Här gör jag ett klassanrop skapar en array
            {
            new Rektangel(4, 5),                                            //jag skickar värde här till klasserna
            new Fyrkant(4),                                                 //object reference 
            new Cirkel(5),
            new Parallellogram(4 ,5),
            new Ellips(4,5)
            };

            foreach (var shape in shapes)
            {
                string shapeName = shape.GetType().Name;                    // Hämta namnet på klassen
                Console.WriteLine($"{shapeName} area: {shape.Area()}");     // utskriften av beräkningarna shapename= namnet på formen
            }                                                               // shape.Area gkriver ut värdet på beräkningarna
            Console.ReadLine();
        }
    }
}