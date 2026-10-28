using AlibreX;

namespace AlibrePdmApiSample
{
    // Wrapper around property interface exposed by items in PDM
    public class PropertyItem
    {
        public string DisplayName { get; }
        public IADPDMProperty Property { get; }

        public PropertyItem (IADPDMProperty property)
        {
            Property = property;
            DisplayName = property.DisplayName;
        }

        // What shows up in lstProperties
        public override string ToString () => DisplayName;

        public ADPDMPropertyValueType ValueType =>
            Property != null ? Property.Type : 0;

        public string GetValueAsString ()
        {
            return Property?.Value ?? string.Empty;
        }
    }
}
