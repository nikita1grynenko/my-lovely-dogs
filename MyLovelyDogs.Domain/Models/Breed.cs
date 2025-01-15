namespace MyLovelyDogs.Domain.Models;

public class Breed
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string BredFor { get; set; }
    public string BreedGroup { get; set; }
    public string ReferenceImageId { get; set; }
    public string Temperament { get; set; }
    public string Origin { get; set; }
    public string CountryCodes { get; set; }
    public string CountryCode { get; set; }
    public string LifeSpan { get; set; }
    public string WikipediaUrl { get; set; }
    public Weight Weight { get; set; }
    public Height Height { get; set; }
}