using MarvelChampionsDomain.Entities.Commands;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Cards;

public sealed class CardBuilder
{
	private readonly EntityId Id;
	private readonly EntityId CardSet;
	private readonly string Title;
	private string? SubTitle;
	private readonly TypeEnum Type;
	private LocationEnum Location;
	private readonly ClassificationEnum Classification;
	private ICommand SetupCommand;
	private ICommand WhenRevealedCommand;
	private EntityId? Owner;
	public CardBuilder(EntityId id, EntityId cardSet, string title, TypeEnum type, ClassificationEnum classification)
	{
		Id = id;
		CardSet = cardSet;
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
	public CardBuilder WithOwner(EntityId owner)
	{
		ArgumentNullException.ThrowIfNull(owner);
		Owner = owner;
		return this;
	}
	public ICard Build()
	{
		Card card = new Card(Id, CardSet, Title, SubTitle, Type, Location, Classification, SetupCommand, WhenRevealedCommand);
		if (Owner is not null) card.SetOwner(Owner);
		return card;
	}
}