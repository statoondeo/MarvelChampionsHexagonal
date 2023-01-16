namespace MarvelChampionsDomain.Enums;

public sealed class LocationEnum : BaseEnum<LocationEnum>
{
	public static readonly LocationEnum None = new(0, "None");
	public static readonly LocationEnum Hand = new(1, "Hand");
	public static readonly LocationEnum Deck = new(2, "Deck");
	public static readonly LocationEnum Discard = new(3, "Discard");
	public static readonly LocationEnum Exil = new(4, "Exil");
	public static readonly LocationEnum Battlefield = new(5, "Battlefield");
	public static readonly LocationEnum MainScheme = new(6, "MainScheme");
	public static readonly LocationEnum Stack = new(7, "Stack");
	private LocationEnum(int value, string name) : base(value, name) { }
	public override string ToString() => $"LocationEnum[{base.ToString()}]";
}
