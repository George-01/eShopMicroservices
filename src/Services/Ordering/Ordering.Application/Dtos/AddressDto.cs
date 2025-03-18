namespace Ordering.Application.Dtos
{
    public record AddressDto(string FirstName, string LstName, 
        string EmailAddress, string Addressline, string Country, string State, string ZipCode);
}
