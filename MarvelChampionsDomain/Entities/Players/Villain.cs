using MarvelChampionsDomain.Basics;
using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Tools;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Players;

public sealed class Villain : BaseEntity, IPlayer
{
	public Villain(string nickname) : base(EntityId.Create()) => Nickname = nickname;
	public string Nickname { get; }
	public int Life { get; private set; }
	public IIdentity? Identity { get; private set; }
	public void InitIdentity(IIdentity identity)
	{
		Identity = identity ?? throw new ArgumentNullException(nameof(identity));
		Logger.Log($"Villain.InitIdentity -> {this}");
	}
	public void InitLife()
	{
		Life = Identity!.StartingLife;
		Logger.Log($"Villain.InitLife -> {this}");
	}
	public override string ToString() => $"Villain[{Nickname}, {Life}, {Identity}]";
}