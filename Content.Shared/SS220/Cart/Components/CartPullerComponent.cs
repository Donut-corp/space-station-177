// Bluedge

using Robust.Shared.GameStates;

namespace Content.Shared.SS220.Cart.Components;

[AutoGenerateComponentState]
[RegisterComponent, NetworkedComponent]
[Access(typeof(CartPullerSystem))]
public sealed partial class CartPullerComponent : Component
{
    /// <summary>
    /// The currently attached cart
    /// </summary>
    [ViewVariables]
    [AutoNetworkedField]
    public EntityUid? AttachedCart;
}
