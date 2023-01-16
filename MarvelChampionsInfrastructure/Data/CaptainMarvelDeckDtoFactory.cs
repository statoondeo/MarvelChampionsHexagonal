using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class CaptainMarvelDeckDtoFactory
{
	public static readonly EntityId IdentityId = EntityId.Create(new Guid("46242446-e278-4e2f-a19e-7add0ff25afa"));
	public static readonly EntityId CardSetId = EntityId.Create(new Guid("27d95ba5-5107-4fc0-863f-742f6328f703"));
	public static ICardSet Create() => new CardSet(true, "Captain Marvel", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = IdentityId, Title = "Captain Marvel" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Spider-Woman" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Crisis Interdiction" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Crisis Interdiction" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Crisis Interdiction" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Photonic Blast" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Photonic Blast" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Energy Absorption" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Energy Absorption" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Alpha Flight Station" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Captain Marvel's Helmet" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Cosmic Flight" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Cosmic Flight" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Energy Channel" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Energy Channel" }
		});
}
