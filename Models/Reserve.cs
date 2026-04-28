namespace CSostenido.Models;

public class Reserve
{
    public int ReserveId { get; set; }
    public string Date { get; set; } = string.Empty;
    public DateTime TimeStart { get; set; }
    public DateTime EndTime { get; set; }
    public int UserId { get; set; }
    public int SportSectionId { get; set; }
    public string Status { get; set; } = string.Empty;
    public List<User> User { get; set; } = new();
    public List<SportSection> SportAction {get;set;}= new();

}