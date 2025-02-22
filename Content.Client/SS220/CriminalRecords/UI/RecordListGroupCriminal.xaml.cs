// Bluedge
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.SS220.CriminalRecords.UI;

[GenerateTypedNameReferences]
public sealed partial class RecordListGroupCriminal : RecordListGroup
{
    public RecordListGroupCriminal() : base()
    {
        RobustXamlLoader.Load(this);
        RecordContainer = RecordsBox;
    }

    public override void SetGroupName(string name)
    {
        base.SetGroupName(name);
    }
}
