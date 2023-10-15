// Bluedge

namespace Content.Shared.SS220.Cart;

/// <summary>
/// Raised on an entity when a cart is deattaching from it (after the pulling is already over)
/// </summary>
[ByRefEvent]
public readonly struct CartDeattachEvent
{
    /// <summary>
    /// The entity cart is deattaching from
    /// </summary>
    public readonly EntityUid DettachTarget;

    /// <summary>
    /// Cart that is deattaching
    /// </summary>
    public readonly EntityUid Deattaching;

    public CartDeattachEvent(EntityUid deattachTarget, EntityUid deattaching)
    {
        DettachTarget = deattachTarget;
        Deattaching = deattaching;
    }
}
