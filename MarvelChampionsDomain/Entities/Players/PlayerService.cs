﻿using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Players;

public sealed class PlayerService : IPlayerService
{
	private readonly ISet<IPlayer> PlayersAtlas;
	private int FirstPlayerIndex;
	public IReadOnlyList<IPlayer> Players => PlayersAtlas.ToList().AsReadOnly();
	public IPlayer First => PlayersAtlas.Skip(FirstPlayerIndex % PlayersAtlas.Count).First();
	public PlayerService() => PlayersAtlas = new HashSet<IPlayer>();
	public void NextPlayerSetToFirst()
	{
		FirstPlayerIndex = (FirstPlayerIndex + 1) % PlayersAtlas.Count;
		Logger.Log($"PlayerService.NextPlayerSetToFirst -> {First}");
	}
	public IPlayer Register(IPlayer player)
	{
		PlayersAtlas.Add(player ?? throw new ArgumentNullException(nameof(player)));
		Logger.Log($"PlayerService.Register -> {player}");
		return player;
	}
	public void Unregister(IPlayer player)
	{
		PlayersAtlas.Remove(player ?? throw new ArgumentNullException(nameof(player)));
		Logger.Log($"PlayerService.Unregister -> {First}");
	}
	public void SetFirst(int playerIndex)
	{
		FirstPlayerIndex = playerIndex % PlayersAtlas.Count;
		Logger.Log($"PlayerService.SetFirst -> {First}");
	}
	public IPlayer GetById(EntityId id) => PlayersAtlas.Single(player => player.Id.Equals(id));
}