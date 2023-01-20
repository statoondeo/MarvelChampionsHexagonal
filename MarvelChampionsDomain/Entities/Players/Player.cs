using MarvelChampionsDomain.Basics;
using MarvelChampionsDomain.Tools;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Players;

public sealed class Player : BaseEntity, IHeroPlayer
{
	public Player(string nickname) : base(EntityId.Create()) => Nickname = nickname;
	public string Nickname { get; }
	public int Life { get; private set; }
	public EntityId? Identity { get; private set; }
	public EntityId? DeckCardSetId { get; private set; }
	public void InitIdentity(EntityId identity)
	{
		ArgumentNullException.ThrowIfNull(identity);
		Identity = identity;
		Logger.Log($"Player.InitIdentity -> {this}");
	}
	public void InitLife()
	{
		ArgumentNullException.ThrowIfNull(Identity);
		Life = ServiceLocator.Instance.Get<IHeroIdentityRepository>().GetById(Identity!).StartingLife;
		Logger.Log($"Player.InitLife -> {this}");
	}
	public void SetDeckCardSetId(EntityId deckCardSetId)
	{
		ArgumentNullException.ThrowIfNull(deckCardSetId);
		DeckCardSetId = deckCardSetId;
	}

	public override string ToString() => $"Player[{Nickname}, {Life}, {Identity}]";
}
