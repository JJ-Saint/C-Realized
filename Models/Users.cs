namespace CSostenido.Models;

public class User
{
    public int UserId { get; set; }
    public string DocumentId { get; set; } = string.Empty;
    public string NameUser { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public List<Reserve> Reserve {get;set;}= new();
    
}