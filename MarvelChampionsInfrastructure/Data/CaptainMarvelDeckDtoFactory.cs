using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class CaptainMarvelDeckDtoFactory
{
	public static readonly EntityId IdentityId = EntityId.Create(new Guid("46242446-e278-4e2f-a19e-7add0ff25afa"));
	public static readonly EntityId CardId = EntityId.Create(new Guid("51fb2601-3ab1-4947-80f1-2879beb58426"));
	public static readonly EntityId CardSetId = EntityId.Create(new Guid("27d95ba5-5107-4fc0-863f-742f6328f703"));
	public static readonly EntityId NemesisCardSetId = EntityId.Create(new Guid("3b0375a0-97ea-407b-93f2-ee0b2ebbcede"));

	public static readonly string Title = "Captain Marvel";
	public static readonly int StartingLife = 12;
	public static readonly int HandSize = 6;
	public static ICardSet Create() => new CardSet(CardSetId, true, false, false, "Captain Marvel", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = CardId, Classification = ClassificationEnum.Identity, Type = TypeEnum.Hero, CardSet = CardSetId, Title = "Captain Marvel" },
			new CollectibleCardDto() { Id = EntityId.Create("4d17afb3-28d2-4425-95ce-2a12f09e8209"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Ally, CardSet = CardSetId, Title = "Spider-Woman" },
			new CollectibleCardDto() { Id = EntityId.Create("ccc8be7e-9175-4e30-9b69-4a7ee70faf61"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Event, CardSet = CardSetId, Title = "Crisis Interdiction" },
			new CollectibleCardDto() { Id = EntityId.Create("c5fff9ee-2cc9-4cea-90e1-cc5dedb79258"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Event, CardSet = CardSetId, Title = "Crisis Interdiction" },
			new CollectibleCardDto() { Id = EntityId.Create("0248c1c2-e66f-4c59-8e7e-7ff2f4bdad49"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Event, CardSet = CardSetId, Title = "Crisis Interdiction" },
			new CollectibleCardDto() { Id = EntityId.Create("0686ed0f-190f-451f-9be5-fe9f83f659f8"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Event, CardSet = CardSetId, Title = "Photonic Blast" },
			new CollectibleCardDto() { Id = EntityId.Create("ef6f301b-8ef2-42c2-8ad7-bfce3a464471"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Event, CardSet = CardSetId, Title = "Photonic Blast" },
			new CollectibleCardDto() { Id = EntityId.Create("36515f3f-960b-451f-a923-10b72dffbda9"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Resource, CardSet = CardSetId, Title = "Energy Absorption" },
			new CollectibleCardDto() { Id = EntityId.Create("618d4af5-900b-4cea-8e51-068efbf99ad3"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Resource, CardSet = CardSetId, Title = "Energy Absorption" },
			new CollectibleCardDto() { Id = EntityId.Create("197cb6d1-9b85-490d-8630-6e70a418a65c"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Support, CardSet = CardSetId, Title = "Alpha Flight Station" },
			new CollectibleCardDto() { Id = EntityId.Create("924bff0b-da44-4173-91ec-4e1dbcf5363f"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Captain Marvel's Helmet" },
			new CollectibleCardDto() { Id = EntityId.Create("b6603787-3bdf-4107-812c-15fe5890bc15"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Cosmic Flight" },
			new CollectibleCardDto() { Id = EntityId.Create("183e571d-e001-4768-b025-43776140885f"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Cosmic Flight" },
			new CollectibleCardDto() { Id = EntityId.Create("c1563666-9c22-4e9f-ba82-0835db106349"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Energy Channel" },
			new CollectibleCardDto() { Id = EntityId.Create("361e2793-817d-415b-9820-2326b361c52e"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Energy Channel" },
			new CollectibleCardDto() { Id = EntityId.Create("3f6e753c-316c-4cfe-9664-23bae397503f"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Obligation, CardSet = CardSetId, Title = "Family Emergency" },
		});
	public static ICardSet CreateNemesis() => new CardSet(NemesisCardSetId, true, true, false, "Captain Marvel Nemesis", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("0d226f95-c381-4cc6-ab8e-6846666db22a"), Classification = ClassificationEnum.Nemesis, Type = TypeEnum.SideScheme, CardSet = NemesisCardSetId, Title = "The Psych-Magnitron" },
			new CollectibleCardDto() { Id = EntityId.Create("30a8b813-9a9c-4608-a1f2-7d38c76233bb"), Classification = ClassificationEnum.Nemesis, Type = TypeEnum.Minion, CardSet = NemesisCardSetId, Title = "Yon-Rogg" },
			new CollectibleCardDto() { Id = EntityId.Create("0b34db4b-7203-4ccc-aecf-5951ef57833b"), Classification = ClassificationEnum.Nemesis, Type = TypeEnum.Treachery, CardSet = NemesisCardSetId, Title = "Kree Manipulator" },
			new CollectibleCardDto() { Id = EntityId.Create("ba05e5ac-a0fe-4de4-94b4-d4972772dd54"), Classification = ClassificationEnum.Nemesis, Type = TypeEnum.Treachery, CardSet = NemesisCardSetId, Title = "Kree Manipulator" },
			new CollectibleCardDto() { Id = EntityId.Create("d994a33d-2d80-45bb-8e81-ee4837a52f22"), Classification = ClassificationEnum.Nemesis, Type = TypeEnum.Treachery, CardSet = NemesisCardSetId, Title = "Yon-Rogg's Treason" }
		});
}
