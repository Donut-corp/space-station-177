// Bluedge

using Robust.Shared.Serialization;
namespace Content.Shared.SS220.CryopodSSD;

[Serializable, NetSerializable]
public enum SSDStorageConsoleKey : byte
{
    Key,
}

[Serializable, NetSerializable]
public sealed class SSDStorageConsoleState : BoundUserInterfaceState
{
    public bool HasAccess { get; }
    public List<string> CryopodSSDRecords { get; }

    public SSDStorageConsoleState(bool hasAccess, List<string> cryopodSSDRecords)
    {
        HasAccess = hasAccess;
        CryopodSSDRecords = cryopodSSDRecords;
    }
}
