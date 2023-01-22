using MarvelChampionsDomain.Basics;
using MarvelChampionsDomain.Entities.Commands;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Cards;

public class Card : BaseEntity, ICard
{
	public int Order { get; private set; }
	public EntityId? Owner { get; private set; }
	public EntityId CardSet { get; private set; }
	public string Title { get; }
	public string? SubTitle { get; }
	public TypeEnum Type { get; private set; }
	public LocationEnum Location { get; private set; }
	public ClassificationEnum Classification { get; private set; }
	public ICommand SetupCommand { get; private set; }
	public ICommand WhenRevealedCommand { get; private set; }
	public Card(
		EntityId id,
		EntityId cardSet,
		string title,
		string? subTitle, 
		TypeEnum type, 
		LocationEnum location, 
		ClassificationEnum classification,
		ICommand setupCommand,
		ICommand whenRevealedCommand) 
		: base(id)
    {
		ArgumentNullException.ThrowIfNull(cardSet);
		ArgumentNullException.ThrowIfNull(type);
		ArgumentNullException.ThrowIfNull(location);
		ArgumentNullException.ThrowIfNull(classification);
		ArgumentNullException.ThrowIfNull(setupCommand);
		ArgumentNullException.ThrowIfNull(whenRevealedCommand);

		Order = 0;
		CardSet = cardSet;
		Title = title;
        SubTitle = subTitle;
		Type = type;
		Location = location;
		Classification = classification;
		SetupCommand = setupCommand;
		WhenRevealedCommand = whenRevealedCommand;
	}
	public void SetOwner(EntityId owner)
	{
		ArgumentNullException.ThrowIfNull(owner);
		Owner = owner;
		Logger.Log($"Card.SetOwner -> {this}");
	}
	private void RenumLocationFrom(EntityId owner, LocationEnum location, int fromIndex)
	{
		ServiceLocator.Instance.Get<ICardService>()
			.GetCards(card => owner.Equals(card.Owner) && location.Equals(card.Location) && card.Order > fromIndex)
			.ForEach(card => card.SetOrder(card.Order - 1));
	}
	public void SetLocation(LocationEnum location)
	{
		ArgumentNullException.ThrowIfNull(location);
		if (!LocationEnum.None.Equals(Location)) RenumLocationFrom(Owner!, Location, Order);
		SetOrder(ServiceLocator.Instance.Get<ICardService>()
			.GetCards(card => Owner!.Equals(card.Owner) && location.Equals(card.Location)).Count);
		Location = location;
		Logger.Log($"Card.SetLocation -> {this}");
	}
	public void SetOrder(int order) => Order = order;

	public override string ToString() => $"Card[{Title}, {Order}, {Location}]";
}
