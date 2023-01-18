namespace MarvelChampionsDomain.ValueObjects;

public sealed class EntityId : BaseValueObject
{
    private Guid Value { get; }
    private EntityId(Guid value) => Value = value;
    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
    public override string ToString() => $"{Convert.ToBase64String(Value.ToByteArray())}";
	// Factory methods
	public static EntityId Create() => Create(Guid.NewGuid());
	public static EntityId Create(Guid value) => new(value);
	public static EntityId Create(string value) => new(new Guid(value));
}