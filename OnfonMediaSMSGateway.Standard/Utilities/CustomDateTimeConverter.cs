using Newtonsoft.Json.Converters;

namespace OnfonMediaSMSGateway.Standard.Utilities
{
    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}