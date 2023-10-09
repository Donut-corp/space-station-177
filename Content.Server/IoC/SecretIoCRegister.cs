using Content.Server.GameTickerModify;
using Content.Server.GameTicking;
using Content.Server.Roles;
using Content.Server.Spawners.EntitySystems;
using Robust.Shared.IoC;

namespace Content.Server.IoC;

public static class SecretIoCRegister
{
    public static void RegisterIoC()
    {
        IoCManager.RegisterInstance<IStatusResponseProvider>(new StatusResponseProvider());
    }
}
