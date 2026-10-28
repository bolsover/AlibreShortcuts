using AlibreX;

namespace AlibrePdmApiSample
{
    // Kinds of PDM objects we can show in the container ListBox.
    public enum ContainerItemKind
    {
        Safe,
        Library,
        Project,
        Folder,
        File
    }

    // A discriminated union-style wrapper around PDM object types
    // seen while navigating Safes.
    public class ContainerItem
    {
        public string Name { get; }
        public ContainerItemKind Kind { get; }
        public object ItemInterface { get; }

        public ContainerItem (IADPDMSafe safe)
        {
            Name = safe.Name;
            Kind = ContainerItemKind.Safe;
            ItemInterface = safe;
        }

        public ContainerItem (IADPDMSafeLibrary library)
        {
            Name = library.Name;
            Kind = ContainerItemKind.Library;
            ItemInterface = library;
        }

        public ContainerItem (IADPDMSafeProject project)
        {
            Name = project.Name;
            Kind = ContainerItemKind.Project;
            ItemInterface = project;
        }

        public ContainerItem (IADPDMFolder folder)
        {
            Name = folder.Name;
            Kind = ContainerItemKind.Folder;
            ItemInterface = folder;
        }

        public ContainerItem (IADPDMFileItem file)
        {
            Name = file.Name;
            if (!string.IsNullOrEmpty(file.Extension))
            {
                Name += file.Extension;
            }
            Kind = ContainerItemKind.File;
            ItemInterface = file;
        }

        public T Get<T> () where T : class
        {
            return ItemInterface as T;
        }

        public void SetProperty (IADPDMProperty property)
        {
            // Properties can be set only on folders and files
            switch (Kind)
            {
                case ContainerItemKind.Folder:
                    IADPDMFolder folder = (IADPDMFolder)ItemInterface;
                    folder.SetProperty (property);
                    break;
                case ContainerItemKind.File:
                    IADPDMFileItem file = (IADPDMFileItem)ItemInterface;
                    file.SetProperty (property);
                    break;
                default:
                    break;
            }
        }

        public override string ToString ()
        {
            return $"[{Kind}]: {Name}";
        }


        public bool IsContainer =>
            Kind == ContainerItemKind.Safe
            || Kind == ContainerItemKind.Library
            || Kind == ContainerItemKind.Project
            || Kind == ContainerItemKind.Folder;
    }
}


