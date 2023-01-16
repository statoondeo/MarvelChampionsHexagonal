using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SelectVillainIdentityCommand : ICommand
{
	private readonly IPlayer Player;
	public SelectVillainIdentityCommand(IPlayer player) => Player = player;
	public void Execute()
	{
		//ICardService cardService = ServiceLocator.Instance.Get<ICardService>();
		//Player.InitIdentity(new Identity("Rhino I", 14, 0));
		//ICard identityCard = cardService.Register(
		//	new CardBuilder("Rhino", TypeEnum.Villain, ClassificationEnum.Identity)
		//	.WithLocation(LocationEnum.Battlefield)
		//	.Build());
		//cardService.Register(
		//	new CardBuilder("The Break-in", TypeEnum.MainScheme, ClassificationEnum.Identity)
		//	.WithLocation(LocationEnum.MainScheme)
		//	.Build());
		//cardService.Register(
		//	new CardBuilder("Charge", TypeEnum.Attachment, ClassificationEnum.Identity)
		//	.Build());
		//cardService.Register(
		//	new CardBuilder("I'm Tough!", TypeEnum.Treachery, ClassificationEnum.Identity)
		//	.Build());
		//Player.Identity!.SetCard(identityCard);
	}
}
