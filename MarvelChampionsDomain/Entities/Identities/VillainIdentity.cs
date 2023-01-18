using MarvelChampionsDomain.Basics;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Identities;

public sealed class VillainIdentity : BaseEntity, IVillainIdentity
{
	public EntityId CardSetId { get; }
	public EntityId IdentityCardSetId { get; }
	public EntityId SchemeCardSetId { get; }
	public EntityId StandardCardSetId { get; }
	public string Title { get; }
	public int StartingLife { get; }
	public VillainIdentity(
			EntityId cardSetId, 
			EntityId identityCardSetId,
			EntityId schemeCardSetId,
			EntityId standardCardSetId,
			string title, 
			int startingLife)
		: base(EntityId.Create())
	{
		ArgumentNullException.ThrowIfNull(cardSetId);
		ArgumentNullException.ThrowIfNull(cardSetId);
		ArgumentNullException.ThrowIfNull(identityCardSetId);
		ArgumentNullException.ThrowIfNull(schemeCardSetId);
		ArgumentNullException.ThrowIfNull(standardCardSetId);

		if (string.IsNullOrWhiteSpace(title)) throw new ArgumentNullException(nameof(title));
		if (startingLife <= 0) throw new ArgumentOutOfRangeException(nameof(startingLife));
		CardSetId = cardSetId;
		IdentityCardSetId = identityCardSetId;
		SchemeCardSetId = schemeCardSetId;
		StandardCardSetId = standardCardSetId;
		Title = title;
		StartingLife = startingLife;
	}
	public override string ToString() => $"Villain[{Title}, {StartingLife}]";
}