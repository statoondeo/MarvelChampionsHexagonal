namespace MarvelChampionsDomain.ValueObjects;

public abstract class BaseValueObject
{
    public abstract IEnumerable<object> GetAtomicValues();
    private bool ValuesAreEquals(BaseValueObject other) => GetAtomicValues().SequenceEqual(other.GetAtomicValues());
    public override bool Equals(object? obj) => obj is BaseValueObject other && ValuesAreEquals(other);
    public override int GetHashCode() => GetAtomicValues().Aggregate(default(int), HashCode.Combine);
}
