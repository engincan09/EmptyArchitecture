using Core.Persistence.Repositories;

namespace Core.Security.Entities;

public class OperationClaim : Entity
{
    public int? Id { get; set; }
    public string Name { get; set; }

    public OperationClaim()
    {
    }

    public OperationClaim(int? id, string name) : base()
    {
        Id = id;
        Name = name;
    }
}