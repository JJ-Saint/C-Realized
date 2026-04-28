using CSostenido.Models;
using Microsoft.EntityFrameworkCore;
using CSostenido.Data;


namespace CSostenido.Services;


public class ReserveService
{
    private readonly AppDbContext _context;

    public ReserveService(AppDbContext context)
    {
        _context = context;
    }

    
    


}