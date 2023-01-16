﻿using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SetAsidePlayerObligationsCommand : ICommand
{
	private readonly IPlayer Player;
	public SetAsidePlayerObligationsCommand(IPlayer player) => Player = player;
	public void Execute()
	{
		List<ICard> cards = ServiceLocator.Instance.Get<ICardService>()
			.GetCards(card => card.Owner!.Equals(Player) && card.Type.Equals(TypeEnum.Obligation)).ToList();
		cards.ForEach(card => card.SetLocation(LocationEnum.Exil));
	}
}
