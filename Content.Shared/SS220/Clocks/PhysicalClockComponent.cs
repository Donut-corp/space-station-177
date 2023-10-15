// Bluedge

namespace Content.Shared.SS220.Clocks;

/// <summary>
/// Allows to check station time by examining the entity with this component.
/// </summary>
[RegisterComponent]
public sealed partial class PhysicalClockComponent : Component
{
    [DataField("enabled"), ViewVariables(VVAccess.ReadWrite)]
    public bool Enabled = true;
}
