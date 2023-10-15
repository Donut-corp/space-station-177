// Bluedge

using Content.Shared.DoAfter;
using Robust.Shared.Serialization;

namespace Content.Shared.SS220.Cart;

[Serializable, NetSerializable]
public sealed partial class CartDeattachDoAfterEvent : SimpleDoAfterEvent
{
    /// <summary>
    /// Cart puller to deattach from
    /// </summary>
    [NonSerialized]
    [DataField("target", required: true)]
    public EntityUid DeattachTarget;

    public CartDeattachDoAfterEvent(EntityUid target)
    {
        DeattachTarget = target;
    }
}
