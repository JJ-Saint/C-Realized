namespace CSostenido.Models;

public class User
{
    public int UserId { get; set; }
    public int DocumentId { get; set; }
    public string NameUser { get; set; } = string.Empty;
    public int PhoneNumber { get; set; }
    public string Email { get; set; } = string.Empty;
    
    public List<Reserve> Reserve {get;set;}= new();
    
}