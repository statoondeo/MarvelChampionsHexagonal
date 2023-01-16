using MarvelChampionsDomain.Basics;
using MarvelChampionsDomain.Entities.Commands;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Cards;

public class Card : BaseEntity, ICard
{
	public IPlayer? Owner { get; private set; }
	public string Title { get; }
	public string? SubTitle { get; }
	public TypeEnum Type { get; private set; }
	public LocationEnum Location { get; private set; }
	public ClassificationEnum Classification { get; private set; }
	public ICommand SetupCommand { get; private set; }
	public ICommand WhenRevealedCommand { get; private set; }
	public Card(
		string title, 
		string? subTitle, 
		TypeEnum type, 
		LocationEnum location, 
		ClassificationEnum classification,
		ICommand setupCommand,
		ICommand whenRevealedCommand) 
		: base(EntityId.Create())
    {
		ArgumentNullException.ThrowIfNull(type);
		ArgumentNullException.ThrowIfNull(location);
		ArgumentNullException.ThrowIfNull(classification);
		ArgumentNullException.ThrowIfNull(setupCommand);
		ArgumentNullException.ThrowIfNull(whenRevealedCommand);

		Title = title;
        SubTitle = subTitle;
		Type = type;
		Location = location;
		Classification = classification;
		SetupCommand = setupCommand;
		WhenRevealedCommand = whenRevealedCommand;
	}
	public void SetOwner(IPlayer owner)
	{
		ArgumentNullException.ThrowIfNull(nameof(owner));
		Owner = owner;
		Logger.Log($"Card.SetOwner -> {this}");
	}
	public void SetLocation(LocationEnum location)
	{
		Location = location ?? throw new ArgumentNullException(nameof(location));
		Logger.Log($"Card.SetLocation -> {this}");
	}

	public override string ToString() => $"Card[{Title}, {SubTitle}, {Location}]";
}
