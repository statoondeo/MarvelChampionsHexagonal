using MarvelChampionsDomain.Entities.Sets;

namespace MarvelChampionsApplication.CardSelections;

public sealed class SelectOneAndOnlyOneCardIO
{
	public List<CollectibleCardDto>? Identities { get; set; }
	public CollectibleCardDto? SelectedIdentity { get; set; }
}
