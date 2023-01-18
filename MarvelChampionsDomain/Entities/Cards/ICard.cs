using MarvelChampionsDomain.Entities.Commands;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Cards;

public interface ICard : IEntity
{
	EntityId? Owner { get; }
	EntityId? CardSet { get; }
	string Title { get; }
	string? SubTitle { get; }
	TypeEnum Type { get; }
	LocationEnum Location { get; }
	ClassificationEnum Classification { get; }
	ICommand SetupCommand { get; }
	ICommand WhenRevealedCommand { get; }

	void SetOwner(EntityId owner);
	void SetLocation(LocationEnum location);
}
