using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataAnalysis.Models
{
    public class KeyWordDto
    {
        public int Id { get; set; }
        [Required] [DisplayName("Ключевое слово")] public string KeyWord { get; set; }
        [DisplayName("Является категорией")] public bool IsCategory { get; set; }
    }
}