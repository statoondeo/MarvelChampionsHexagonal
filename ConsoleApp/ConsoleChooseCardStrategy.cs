using MarvelChampionsDomain.Entities;
using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Tools;

namespace ConsoleApp;

public sealed class ConsoleChooseCardStrategy : IChooseCardStrategy
{
	private IReadOnlyList<ICard>? CardsList;
	private List<ICard> ?CardsToDiscard;
	public IList<ICard> ChooseCards(Func<ICard, bool> amongFilter)
	{
		CardsList = ServiceLocator.Instance.Get<ICardService>().GetCards(amongFilter);
		CardsToDiscard = new List<ICard>();

		ICard? selectedCard = DisplaySelectionMenu();
		while (selectedCard is not null)
		{
			CardsToDiscard.Add(selectedCard);
			selectedCard = DisplaySelectionMenu();
		}
		return CardsToDiscard;
	}
	private ICard? DisplaySelectionMenu()
	{
		IList<ICard> cardsToChooseAmong = CardsList!.Where(card => !CardsToDiscard!.Contains(card)).ToList();
		int selectOption;
		ConsoleKeyInfo key;
		do
		{
			Console.Clear();
			Console.WriteLine("Please pick a card to discard among following cards :");
			Console.WriteLine();
			for (int i = 0; i < cardsToChooseAmong.Count; i++) Console.WriteLine($"\t {i + 1} : {cardsToChooseAmong[i]}");
			Console.WriteLine();
			Console.WriteLine("\t 0 : Finished");
			Console.WriteLine();
			Console.Write("\t Your choice : ");
			key = Console.ReadKey();
		} while (!int.TryParse(key.KeyChar.ToString(), out selectOption) || (selectOption < 0) || (selectOption > cardsToChooseAmong.Count));
		return selectOption == 0 ? null : cardsToChooseAmong[selectOption - 1];
	}
}
