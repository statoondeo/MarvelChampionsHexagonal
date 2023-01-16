﻿namespace MarvelChampionsDomain.Enums;

public sealed class TypeEnum : BaseEnum<TypeEnum>
{
	public static readonly TypeEnum None = new(0, "None");

	public static readonly TypeEnum Hero = new(10, "Hero");
	public static readonly TypeEnum AlterEgo = new(11, "AlterEgo");
	public static readonly TypeEnum Support = new(12, "Support");
	public static readonly TypeEnum Upgrade = new(13, "Upgrade");
	public static readonly TypeEnum Event = new(14, "Event");
	public static readonly TypeEnum Ally = new(15, "Ally");
	public static readonly TypeEnum Resource = new(16, "Resource");

	public static readonly TypeEnum Villain = new(20, "Villain");
	public static readonly TypeEnum MainScheme = new(21, "MainScheme");
	public static readonly TypeEnum SideScheme = new(22, "SideScheme");
	public static readonly TypeEnum Minion = new(23, "Minion");
	public static readonly TypeEnum Attachment = new(24, "Attachment");
	public static readonly TypeEnum Treachery = new(25, "Treachery");
	public static readonly TypeEnum Obligation = new(26, "Obligation");

	private TypeEnum(int value, string name) : base(value, name) { }
	public override string ToString() => $"TypeEnum[{base.ToString()}]";
}
