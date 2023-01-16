namespace MarvelChampionsDomain.Enums;

public sealed class ClassificationEnum : BaseEnum<ClassificationEnum>
{
	public static readonly ClassificationEnum None = new(0, "None");
	public static readonly ClassificationEnum Identity = new(1, "Identity");
	public static readonly ClassificationEnum Nemesis = new(2, "Nemesis");
	public static readonly ClassificationEnum Aggression = new(3, "Aggression");
	public static readonly ClassificationEnum Basic = new(4, "Basic");

	private ClassificationEnum(int value, string name) : base(value, name) { }
	public override string ToString() => $"SetEnum[{base.ToString()}]";
}