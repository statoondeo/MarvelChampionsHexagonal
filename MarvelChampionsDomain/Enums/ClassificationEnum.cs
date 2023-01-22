namespace MarvelChampionsDomain.Enums;

public sealed class ClassificationEnum : BaseEnum<ClassificationEnum>
{
	public static readonly ClassificationEnum None = new(0, "None");
	public static readonly ClassificationEnum Identity = new(1, "Identity");
	public static readonly ClassificationEnum Nemesis = new(2, "Nemesis");
	public static readonly ClassificationEnum Aggression = new(3, "Aggression");
	public static readonly ClassificationEnum Justice = new(4, "Justice");
	public static readonly ClassificationEnum Leadership = new(5, "Leadership");
	public static readonly ClassificationEnum Protection = new(6, "Protection");
	public static readonly ClassificationEnum Basic = new(7, "Basic");
	public static readonly ClassificationEnum Modular = new(8, "Modular");
	public static readonly ClassificationEnum Standard = new(8, "Standard");

	private ClassificationEnum(int value, string name) : base(value, name) { }
	public override string ToString() => $"SetEnum[{base.ToString()}]";
}