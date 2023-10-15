// Bluedge
using Content.Shared.Access.Systems;
using Content.Shared.Interaction;
using Content.Shared.Storage;

namespace Content.Server.SS220.AutoEngrave;

public sealed class EngraveNameOnOpenSystem : EntitySystem
{
    [Dependency] private readonly AccessReaderSystem _accessReader = default!;

    /// <inheritdoc/>
    public override void Initialize()
    {
        SubscribeLocalEvent<EngraveNameOnOpenComponent, ActivateInWorldEvent>(OnActivate);
    }

    private void OnActivate(EntityUid uid, EngraveNameOnOpenComponent component, ActivateInWorldEvent args)
    {
        if (!TryComp<StorageComponent>(uid, out var storageComp))
            return;

        var character = args.User;

        if (!_accessReader.IsAllowed(character, uid))
            return;

        TryEngrave(character, storageComp, component);
    }

    private void TryEngrave(EntityUid user, StorageComponent storageComp, EngraveNameOnOpenComponent engraveComp)
    {
        if (engraveComp.Activated)
            return;

        if (storageComp.Container is null)
            return;

        foreach (var item in storageComp.Container.ContainedEntities)
        {
            var id = MetaData(item).EntityPrototype?.ID;
            if (id is null)
                continue;

            if (!engraveComp.ToEngrave.Contains(id))
                continue;

            var engraving = AddComp<AutoEngravingComponent>(item);
            engraving.AutoEngraveLocKey = engraveComp.AutoEngraveLocKey;
            engraving.EngravedText = MetaData(user).EntityName;

            engraveComp.Activated = true;
        }
    }
}
