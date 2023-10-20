// Bluedge

using Content.Shared.Actions;

namespace Content.Shared.SS220.GhostRoleCast
{
    [RegisterComponent]
    public sealed partial class GhostRoleCastComponent : Component
    {
        public string GhostRoleName = "";
        public string GhostRoleDesc = "";
        public string GhostRoleRule = "";

        public const string ToggleGhostRoleNameActionId = "ActionToggleGhostRoleName";
        public const string ToggleGhostRoleCastActionId = "ActionToggleGhostRoleCast";
        public const string ToggleGhostRoleRemoveActionId = "ActionToggleGhostRoleRemove";


        [DataField("toggleGhostRoleNameAction")]
        public EntityUid? ToggleGhostRoleNameAction;

        [DataField("toggleGhostRoleCastAction")]
        public EntityUid? ToggleGhostRoleCastAction;

        [DataField("toggleGhostRoleRemoveAction")]
        public EntityUid? ToggleGhostRoleRemoveAction;
    }

    public sealed partial class ToggleGhostRoleCastSettingsEvent : InstantActionEvent { };
    public sealed partial class ToggleGhostRoleCastActionEvent : EntityTargetActionEvent { };
    public sealed partial class ToggleGhostRoleRemoveActionEvent : EntityTargetActionEvent { };

}
