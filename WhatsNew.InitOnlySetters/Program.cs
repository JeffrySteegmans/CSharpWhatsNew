// var licensePlate = new AccessDevice
// { 
//     CountryCode = "be", 
//     Type = AccessDeviceType.ANPR, 
//     Value = "1CGK123", 
// };

using WhatsNew.InitOnlySetters.Enums;

var licensePlate = new AccessDevice("be", AccessDeviceType.ANPR, "1CGK123");

class AccessDevice
{
    public string CountryCode { get; init; }
    public AccessDeviceType Type  { get; init; }
    public string Value { get; init; }

    public AccessDevice(string countryCode, AccessDeviceType type, string value)
    {
      CountryCode = countryCode;
      Type = type;
      Value = value;
    }
}

