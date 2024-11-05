namespace ApiGestaoDeLivraria.Comunication.Request
{
    public class RequestGetBookJson
    {
        public int Id { get; set; }
        public string? Title { get; set; } 
        public string? Author { get; set; }
        public string? Gender { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
    }
}
