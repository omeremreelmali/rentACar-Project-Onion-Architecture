namespace Domain.Entities;

public class Transmission : BaseEntity<Guid>
{
    public string Name { get; set; }
    
    public virtual ICollection<Model> Models { get; set; }

    public Transmission()
    {
        Models = new HashSet<Model>();
    }

    public Transmission(Guid id, string name) : this()
    {
        Id = id;
        Name = name;
    }
}