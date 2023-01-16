using MarvelChampionsDomain.Entities.Commands;
using MarvelChampionsDomain.Enums;

namespace MarvelChampionsDomain.Entities.Cards;

public sealed class CardBuilder
{
	private readonly string Title;
	private string? SubTitle;
	private readonly TypeEnum Type;
	private LocationEnum Location;
	private readonly ClassificationEnum Classification;
	private ICommand SetupCommand;
	private ICommand WhenRevealedCommand;
	public CardBuilder(string title, TypeEnum type, ClassificationEnum classification)
	{
		if (string.IsNullOrWhiteSpace(title)) throw new ArgumentNullException(nameof(title));
		Title = title;
		Type = type;
		Classification = classification;
		Location = LocationEnum.None;
		SetupCommand = new NullCommand();
		WhenRevealedCommand = new NullCommand();
	}
	public CardBuilder WithSubTitle(string subTitle)
	{
		if (string.IsNullOrWhiteSpace(subTitle)) throw new ArgumentNullException(nameof(subTitle));
		SubTitle = subTitle;
		return this;
	}
	public CardBuilder WithLocation(LocationEnum location)
	{
		Location = location ?? throw new ArgumentNullException(nameof(location));
		return this;
	}
	public CardBuilder WithSetupCommand(ICommand setupCommand)
	{
		ArgumentNullException.ThrowIfNull(setupCommand);
		SetupCommand = setupCommand;
		return this;
	}
	public CardBuilder WithWhenRevealedCommand(ICommand whenRevealedCommand)
	{
		ArgumentNullException.ThrowIfNull(whenRevealedCommand);
		WhenRevealedCommand = whenRevealedCommand;
		return this;
	}
	public ICard Build() => new Card(Title, SubTitle, Type, Location, Classification, SetupCommand, WhenRevealedCommand);
}