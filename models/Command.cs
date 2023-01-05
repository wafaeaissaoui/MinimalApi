using System.ComponentModel.DataAnnotations;

namespace SixMinApi.models {
    public class Command{

     [Key]   
     public int Id { get; set; }
     public string? Howto { get; set; }
     public string? Platforme { get; set; }
     public string? CommandLine { get; set; }
     
    }
}