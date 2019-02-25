namespace DataAnalysis.Models
{
    public class KeyWordDto
    {
        public int Id { get; set; }
        //todo not null
        public string KeyWord { get; set; }
        public bool? IsCategory { get; set; }
    }
}