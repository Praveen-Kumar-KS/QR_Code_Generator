using QRCoder;

namespace QRCode.Services
{
    public class QrCodeService : IQrCodeService
    {
        public byte[] GenerateLocationQr()
        {
            // Google Maps URL
            //string locationUrl = $"https://www.google.com/maps?q={latitude},{longitude}";
            string locationUrl = "https://maps.app.goo.gl/nWVuVQtf9pev8Jmv7";

            // Generate QR
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(locationUrl, QRCodeGenerator.ECCLevel.Q);

            PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrBytes = qrCode.GetGraphic(20);

            return qrBytes;
        }
    }

    public interface IQrCodeService
    {
        byte[] GenerateLocationQr();
    }
}
