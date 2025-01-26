using Microsoft.EntityFrameworkCore;
using ParkingLotDetectionWebApp.Models;

namespace ParkingLotDetectionWebApp.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options)
        {

        }

        // public DbSet<ParkingLot> ParkingLots { get; set; }
    }
}
