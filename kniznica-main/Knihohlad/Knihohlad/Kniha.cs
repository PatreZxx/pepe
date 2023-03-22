namespace Knihohlad
{
    public class Kniha
    {
        public int Id { get; set; }
        public string nazov { get; set; }
        public string autor { get; set; }
        public string vydavatelstvo { get; set; }
        public string kategoria { get; set; }
        public string informacie { get; set; }
        public decimal cena { get; set; }
        public string obrazky { get; set; }
    }

}