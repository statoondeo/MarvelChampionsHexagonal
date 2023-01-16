using MarvelChampionsDomain.Basics;
using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Tools;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Players;

public sealed class Player : BaseEntity, IPlayer
{
	public Player(string nickname) : base(EntityId.Create()) => Nickname = nickname;
	public string Nickname { get; }
	public int Life { get; private set; }
	public IIdentity? Identity { get; private set; }
	public void InitIdentity(IIdentity identity)
	{
		Identity = identity ?? throw new ArgumentNullException(nameof(identity));
		Logger.Log($"Player.InitIdentity -> {this}");
	}
	public void InitLife()
	{
		Life = Identity!.StartingLife;
		Logger.Log($"Player.InitLife -> {this}");
	}
	public override string ToString() => $"Player[{Nickname}, {Life}, {Identity}]";
}
