using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class ResolveMainSchemeSetupCommand : ICommand
{
	public void Execute()
	{
		static bool Filter(ICard card) => 
			card.Owner!.Equals(ServiceLocator.Instance.Get<IVillainService>().Villain)
			&& card.Location.Equals(LocationEnum.Battlefield);

		ICardService cardService = ServiceLocator.Instance.Get<ICardService>();
		List<ICard> beforeSetup = cardService.GetCards(Filter);
		cardService.GetCards(card => card.Location.Equals(LocationEnum.MainScheme)).ForEach(card => card.SetupCommand.Execute());
		List<ICard> afterSetup = cardService.GetCards(Filter);
		afterSetup.Where(card => !beforeSetup.Contains(card)).ToList().ForEach(card => card.WhenRevealedCommand.Execute());
	}
}
