namespace CSostenido.Models;

public class SportSection
{
    public string Name { get; set; } = string.Empty;
    public int SportSectionId { get; set; }
    public string TypeSection { get; set; } = string.Empty;
    public int Capacity { get; set; }
    public List<Reserve> Reserve { get; set; }= new();
}