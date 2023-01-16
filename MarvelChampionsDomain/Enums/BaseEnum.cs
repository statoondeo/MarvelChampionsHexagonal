using System.Reflection;

namespace MarvelChampionsDomain.Enums;

public abstract class BaseEnum<TEnum> : IEquatable<BaseEnum<TEnum>> where TEnum : BaseEnum<TEnum>
{
	protected BaseEnum(int value, string name)
	{
		Value = value;
		Name = name;
	}

	public int Value { get; protected init; }
	public string Name { get; protected init; }

	#region Overrides and Interfaces

	public bool Equals(BaseEnum<TEnum>? other)
	{
		if (other is null) return false;
		return GetType() == other.GetType() &&
			Value == other.Value;
	}
	public override bool Equals(object? obj)
	{
		return obj is BaseEnum<TEnum> enumeration &&
			Equals(enumeration);
	}
	public override int GetHashCode() => Value.GetHashCode();
	public override string ToString() => $"{Value}/{Name}";

	#endregion

	#region Static Behaviors

	public static TEnum? FromValue(int value) => Enumerations.TryGetValue(value, out TEnum? enumeration) ? enumeration : default;
	public static TEnum? FromName(string name) => Enumerations.Values.SingleOrDefault(item => item.Name == name);

	private static readonly IDictionary<int, TEnum> Enumerations = CreateAndInitEnumerations();
	private static IDictionary<int, TEnum> CreateAndInitEnumerations()
	{
		Type typeOfEnumeration = typeof(TEnum);
		IEnumerable<TEnum> fields = typeOfEnumeration
			.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
			.Where(fieldInfo => typeOfEnumeration.IsAssignableFrom(fieldInfo.FieldType))
			.Select(fieldInfo => (TEnum)fieldInfo.GetValue(default)!);
		return fields.ToDictionary(item => item.Value);
	}

	#endregion
}
