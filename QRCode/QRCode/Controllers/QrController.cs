using Microsoft.AspNetCore.Mvc;
using QRCode.Services;

namespace QRCode.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class QrController : ControllerBase
    {
        private readonly QrCodeService _qrService;

        public QrController(QrCodeService qrService)
        {
            _qrService = qrService;
        }

        //[HttpGet]
        //public IActionResult GetLocationQr(double lat, double lng)
        //{
        //    if (lat == 0 || lng == 0)
        //        return BadRequest("Latitude and Longitude are required");

        //    var qrBytes = _qrService.GenerateLocationQr(lat, lng);

        //    return File(qrBytes, "image/png");
        //}

        [HttpGet]
        public IActionResult GetLocationQr()
        {
            var qrBytes = _qrService.GenerateLocationQr();

            return File(qrBytes, "image/png");
        }


    }
}
