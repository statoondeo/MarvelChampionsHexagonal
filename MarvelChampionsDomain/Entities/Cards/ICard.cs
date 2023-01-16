using MarvelChampionsDomain.Entities.Commands;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Enums;

namespace MarvelChampionsDomain.Entities.Cards;

public interface ICard : IEntity
{
	IPlayer? Owner { get; }
	string Title { get; }
	string? SubTitle { get; }
	TypeEnum Type { get; }
	LocationEnum Location { get; }
	ClassificationEnum Classification { get; }
	ICommand SetupCommand { get; }
	ICommand WhenRevealedCommand { get; }

	void SetOwner(IPlayer owner);
	void SetLocation(LocationEnum location);
}
