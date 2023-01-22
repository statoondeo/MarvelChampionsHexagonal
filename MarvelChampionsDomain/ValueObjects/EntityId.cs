namespace MarvelChampionsDomain.ValueObjects;

[Serializable]
public sealed class EntityId : BaseValueObject
{
    public Guid Value { get; }
    private EntityId(Guid value) => Value = value;
    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
	public override string ToString() => $"{Value}";
	public static EntityId Create() => Create(Guid.NewGuid());
	public static EntityId Create(Guid value) => new(value);
	public static EntityId Create(string value) => new(new Guid(value));
}