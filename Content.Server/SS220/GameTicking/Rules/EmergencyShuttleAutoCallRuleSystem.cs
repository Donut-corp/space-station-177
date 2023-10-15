// Bluedge

using Content.Server.GameTicking.Rules;
using Content.Server.GameTicking.Rules.Components;

namespace Content.Server.SS220.GameTicking.Rules;

public sealed class EmergencyShuttleAutoCallRuleSystem : GameRuleSystem<EmergencyShuttleAutoCallRuleComponent>
{
    protected override void Started(EntityUid uid, EmergencyShuttleAutoCallRuleComponent component, GameRuleComponent gameRule, GameRuleStartedEvent args)
    {
        base.Started(uid, component, gameRule, args);
        RaiseLocalEvent(EmergencyShuttleAutoCallStartedEvent.Default);
    }
}

public sealed class EmergencyShuttleAutoCallStartedEvent : EntityEventArgs
{
    public static EmergencyShuttleAutoCallStartedEvent Default { get; } = new();
}
