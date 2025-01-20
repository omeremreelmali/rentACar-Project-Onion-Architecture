using Domain.Enums;

namespace Domain.Entities;

public class Car : BaseEntity<Guid>
{
    public Guid ModelId { get; set; }
    public int Kilometer { get; set; }
    public decimal ModelYear { get; set; }
    
    public string Plate { get; set; }
    public short MinFindexScore { get; set; }
    public short MaxFindexScore { get; set; }
    public CarState CarState { get; set; }
    
    public virtual Model? Model { get; set; }

    public Car()
    {
        
    }

    public Car(
        Guid id,
        Guid modelId,
        CarState carState,
        int kilometer,
        short modelYear,
        string plate,
        short minFindexScore
    )
        : this()
    {
        Id = id;
        ModelId = modelId;
        CarState = carState;
        Kilometer = kilometer;
        ModelYear = modelYear;
        Plate = plate;
        MinFindexScore = minFindexScore;
    }
}