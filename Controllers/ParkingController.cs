using Microsoft.AspNetCore.Mvc;

namespace ParkingLotDetectionWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParkingController : Controller
    {
        public class ParkingSpot
        {
            public int Id { get; set; }
            public bool Occupied { get; set; }
        }

        [HttpPost("update")]
        public IActionResult UpdateParkingSpots([FromBody] List<ParkingSpot> parkingSpots)
        {
            if (parkingSpots == null || parkingSpots.Count == 0)
            {
                return BadRequest("The parking spots list cannot be null or empty.");
            }

            // Process the parking spots (e.g., save to a database or update some logic)
            foreach (var spot in parkingSpots)
            {
                // Example logic: just output the status for now
                System.Console.WriteLine($"Parking Spot ID: {spot.Id}, Occupied: {spot.Occupied}");
            }

            // Return a success response
            return Ok(new { message = "Parking spots updated successfully.", updatedCount = parkingSpots.Count });
        }
    }
}
