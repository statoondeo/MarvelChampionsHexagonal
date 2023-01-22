using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsApplication.ListVillainIdentities;

public sealed class SelectOneAndOnlyOneCardIO
{
    public List<CollectibleCardDto>? Identities { get; set; }
    public EntityId? SelectedIdentity { get; set; }
}
