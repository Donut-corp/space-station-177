// Bluedge

using Content.Shared.DoAfter;
using Robust.Shared.Serialization;

namespace Content.Shared.SS220.Cart;

[Serializable, NetSerializable]
public sealed partial class CartAttachDoAfterEvent : SimpleDoAfterEvent
{
    /// <summary>
    /// Cart puller to attach to
    /// </summary>
    [NonSerialized]
    [DataField("target", required: true)]
    public EntityUid AttachTarget;

    public CartAttachDoAfterEvent(EntityUid target)
    {
        AttachTarget = target;
    }
}
