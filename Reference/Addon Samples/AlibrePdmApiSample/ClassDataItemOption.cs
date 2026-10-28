using AlibreX;
using System;

// Wrapper class around IADPDMClassDataItem
// Used for properties of type AD_PDM_SINGLE_SELECT or AD_PDM_MULTI_SELECT
public class ClassDataItemOption
{
    public string Name { get; }
    public IADPDMClassDataItem DataItem { get; }

    public ClassDataItemOption (IADPDMClassDataItem dataItem)
    {
        DataItem = dataItem ?? throw new ArgumentNullException (nameof (dataItem));
        Name = dataItem.Name;
    }

    public override string ToString () => Name;  // needed to display items in combo-box
}
