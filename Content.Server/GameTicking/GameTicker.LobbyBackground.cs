using Content.Server.GameTicking.Prototypes;
using Robust.Shared.Random;
using Robust.Shared.Utility;
using System.Linq;

namespace Content.Server.GameTicking;

public sealed partial class GameTicker
{
    [ViewVariables]
    public string? LobbyBackground { get; private set; }

    [ViewVariables]
    private List<string>? _lobbyBackgrounds = new()
    {
        "AspidParallax",
        "FastSpace",
        "Default",
        "BagelStation",
        "KettleStation",
    };

    private static readonly string[] WhitelistedBackgroundExtensions = new string[] {"png", "jpg", "jpeg"};

    private void InitializeLobbyBackground()
    {
        // _lobbyBackgrounds = _prototypeManager.EnumeratePrototypes<LobbyBackgroundPrototype>()
        //     .Select(x => x.Background)
        //     .Where(x => WhitelistedBackgroundExtensions.Contains(x.Extension))
        //     .ToList();

        RandomizeLobbyBackground();
    }

    private void RandomizeLobbyBackground() {
        LobbyBackground = _lobbyBackgrounds!.Any() ? _robustRandom.Pick(_lobbyBackgrounds!) : null;
    }
}
