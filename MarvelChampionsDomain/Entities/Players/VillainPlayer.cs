using MarvelChampionsDomain.Basics;
using MarvelChampionsDomain.Tools;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Players;

public sealed class VillainPlayer : BaseEntity, IVillainPlayer
{
	public VillainPlayer() : base(EntityId.Create()) { }
	public int Life { get; private set; }
	public EntityId? Identity { get; private set; }
	public EntityId? ModularCardSetId { get; private set; }
	public void InitIdentity(EntityId identity)
	{
		ArgumentNullException.ThrowIfNull(identity);
		Identity = identity;
		Logger.Log($"Villain.InitIdentity -> {this}");
	}
	public void InitLife()
	{
		Life = ServiceLocator.Instance.Get<IVillainIdentityRepository>().GetById(Identity!).StartingLife;
		Logger.Log($"Villain.InitLife -> {this}");
	}
	public void SetModulatCardSetId(EntityId modularCardSetId)
	{
		ArgumentNullException.ThrowIfNull(modularCardSetId);
		ModularCardSetId = modularCardSetId;
	}
	public override string ToString() => $"Villain[{Life}, {Identity}]";
}