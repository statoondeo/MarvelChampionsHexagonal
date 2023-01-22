using MarvelChampionsDomain.Entities.Sets;

namespace MarvelChampionsApplication.CardSelections;

public sealed class SelectAtLeastOneCardIO
{
	public List<CollectibleCardDto>? Identities { get; set; }
	public List<CollectibleCardDto>? SelectedIdentities { get; set; }
}
