# AlibreX API — PDM, Repository & File Operations

> Part of the split AlibreX reference. See `00_index.md` for the full map.

**Sections in this file:** 446

---


# IADPDMTemplate.Delete Method

Deletes this Temaplate item.

#### Syntax

```
void Delete()
```



# IADPDMClass.RemoveDefaultProperty Method

Removes a default property from the Class item.

#### Syntax

```
void RemoveDefaultProperty(
	IADPDMPropertyDefinition definition
)
```

#### Parameters

definition  IADPDMPropertyDefinition



# IADPDMFileItem.Parent Property

The folder which contains this file item.

#### Syntax

```
IADPDMFolder Parent { get; }
```

#### Property Value

IADPDMFolder



# IADFolder.ClearPermission Method

Makes this folder completely inaccessible to the specified collection of users, teams and roles on a secure object type basis

#### Syntax

```
void ClearPermission(
	ADSecureObjectType secureObjectType,
	IObjectCollector pUsers,
	IObjectCollector pTeams,
	IObjectCollector pRoles,
	bool applyToAllSubFolders,
	bool applyToAllItems,
	bool unPublishingRepository
)
```

#### Parameters

secureObjectType  ADSecureObjectType

pUsers  IObjectCollector

pTeams  IObjectCollector

pRoles  IObjectCollector

applyToAllSubFolders  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

applyToAllItems  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

unPublishingRepository  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMProperties Properties

The IADPDMProperties type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of properties in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Safe | Returns the Safe. |



# IADPDMFileItem.IsLocked Property

Returns whether this file item is locked or not.

#### Syntax

```
bool IsLocked { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADFolderItem.CheckIn Method

Marks this folder-item as not checked-out by the current user

#### Syntax

```
void CheckIn(
	string comment
)
```

#### Parameters

comment  [String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMTemplateLevel Interface

IADPDMTemplateLevel provides access to a level item in a template.

#### Syntax

```
public interface IADPDMTemplateLevel
```

The IADPDMTemplateLevel type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ClassItem | Returns the class item corresponding to this level. |
|  | Name | Returns the name of the Template Level item. |
|  | Safe | Returns the Safe. |
|  | Template | Returns the Template of this level item. |



# IADFolderItem.IsCheckedIn Method

Determines the check-out status of this folder-item

#### Syntax

```
bool IsCheckedIn()
```

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMSafes.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADPDMFolder.Folders Property

Returns the next level folders under this folder.

#### Syntax

```
IADPDMFolders Folders { get; }
```

#### Property Value

IADPDMFolders



# IADPDMTemplate.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADPDMPropertyDefinition.SetSVGIcon Method

Sets the given SVG icon to the Property Definition.

#### Syntax

```
void SetSVGIcon(
	string svgImagePath
)
```

#### Parameters

svgImagePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   A windows file path for the SVG icon.



# IADPDMFolder Interface

IADPDMFolder provides access to a folder.

#### Syntax

```
public interface IADPDMFolder
```

The IADPDMFolder type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FileItems | Returns the file items in this folder. |
|  | Folders | Returns the next level folders under this folder. |
|  | IsDeleted | Returns whether this folder has been deleted and is inside Recycle Bin or not. |
|  | IsTemplateFolder | Returns whether this folder is based on a Template Level item or not. |
|  | Name | Returns the name of the folder. |
|  | Parent | Returns the parent folder of this folder. |
|  | Properties | Returns the properties of this folder. |
|  | Reference | Returns a unique reference to identify the folder. |
|  | Safe | Returns the Safe. |
|  | SubFolderTemplateLevel | Returns the Template Level item of the next level folders (sub folders), if any. |
|  | TemplateLevel | Returns the Template Level item of this folder, if any. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CancelCheckIn | Cancels the check-in operation, if possible. |
|  | CreateFolder | Creates a new sub folder. |
|  | CreateTemplateFolder | Creates a new sub folder based on the Class defined in the level. |
|  | Delete | Deletes this folder. |
|  | Purge | Deletes this folder permanently from the Server as well. This cannot be undone. |
|  | RemoveProperty | Removes the given property from this folder. |
|  | Rename | Renames this folder. |
|  | Restore | Restores this folder from Recycle Bin to its original location. |
|  | SetProperty | Sets the given property to this folder. |
|  | UploadDocuments | Uploads non native file items to this folder. |



# IADPDMFileItem.IsDeleted Property

Returns whether this file item has been deleted and is inside Recycle Bin or not.

#### Syntax

```
bool IsDeleted { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# INotificationSelector.CheckIn Property

Sets/resets flag indicating whether to receive notification upon check-in.

#### Syntax

```
bool CheckIn { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# INotificationSelector.Delete Property

Sets/resets flag indicating whether to receive notification upon delete.

#### Syntax

```
bool Delete { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMClassDataItem Properties

The IADPDMClassDataItem type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ClassItem | Returns the class item owning this data item. |
|  | Name | Returns the name of the Class data item. |
|  | Properties | Returns the properties of this data item. |
|  | Safe | Returns the Safe. |



# IPermissionSelector Properties

The IPermissionSelector type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Administrate | Sets/resets flag indicating right to administrate. |
|  | Delete | Sets/resets flag indicating right to delete. |
|  | Read | Sets/resets flag indicating right to read. |
|  | ViewOnly | Sets/resets flag indicating right to check-in and check-out. This property is obsolete. |
|  | Write | Sets/resets flag indicating right to edit. |



# IADPDMFileItems Interface

IADPDMFileItems provides access to a collecion of file items.

#### Syntax

```
public interface IADPDMFileItems
```

The IADPDMFileItems type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of file items in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Safe | Returns the Safe. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | GetFileItemByName | Returns an file item for the given name. |
|  | Item | Given a name or index, into the collection, returns the corresponding file item. |



# IADPDMClass.RemoveDataItem Method

Removes the data item.

#### Syntax

```
void RemoveDataItem(
	IADPDMClassDataItem dataItem
)
```

#### Parameters

dataItem  IADPDMClassDataItem



# IADFolderItems Methods

The IADFolderItems type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a repository folder-item's name or index, returns its interface |



# IADPDMPropertyDefinitions.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADPDMTemplates Interface

IADPDMTemplates provides access to the template items.

#### Syntax

```
public interface IADPDMTemplates
```

The IADPDMTemplates type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of templates in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Safe | Returns the Safe. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateTemplateByName | Creates a new template item. |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | GetTemplateByName | Returns the template for a given name. |
|  | Item | Given a numerical index into the collection, returns the corresponding Template. |



# IADPDMTemplates.CreateTemplateByName Method

Creates a new template item.

#### Syntax

```
IADPDMTemplate CreateTemplateByName(
	string name,
	IADPDMClass classItem
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

classItem  IADPDMClass
:   The class item to be associated for the first level.

#### Return Value

IADPDMTemplate  
IADPDMTemplate



# IADRepositories.Count Property

Returns the number of repositories in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADFolderItems Interface

IADFolderItems Interface. This interface is obsolete as of V11 of Alibre Design.

#### Syntax

```
public interface IADFolderItems
```

The IADFolderItems type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of repository folder-items in this collection |
|  | Enum | Returns an enumerator for the collection |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a repository folder-item's name or index, returns its interface |



# IADPDMPropertyDefinition.UnSetSVGIcon Method

Unsets any SVG icon from the Property Definition.

#### Syntax

```
void UnSetSVGIcon()
```



# IADPDMVersionFileItem Methods

The IADPDMVersionFileItem type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddRevision | Make this version as a Revision item. |
|  | OpenNonNativeFileItemReadOnly | Opens this non native item as read only. |
|  | OpenReadOnly | Opens this native item as read only. |
|  | PurgeVersion | Purge this version. |
|  | RemoveRevision | Removes the Revision. |
|  | RestoreVersion | Make this version as the latest version. |
|  | UpdateRevision | Updates the Revision text. |
|  | UpdateVersionComment | Updates the version comment. |



# IPermissionSelector.Read Property

Sets/resets flag indicating right to read.

#### Syntax

```
bool Read { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMTemplates.Item Method

Given a numerical index into the collection, returns the corresponding Template.

#### Syntax

```
IADPDMTemplate Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The numerical index of the Template.

#### Return Value

IADPDMTemplate  
Returns IADPDMTemplate



# INotificationSelector.Write Property

Sets/resets flag indicating whether to receive notification upon edit.

#### Syntax

```
bool Write { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMSafeProjects.Count Property

Returns the number of projects in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

The count property for the Projects object held by automation clients will
not get updated automatically when a Project is added or deleted. Get the current
Projects collection by querying the Safe.



# IADPDMSafeLibraries.Reference Property

Returns a unique Reference for the Libraries item.

#### Syntax

```
string Reference { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMClass.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADRepository Methods

The IADRepository type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | IsPublished | Determines if the repository is accessible to anyone other than the owner |
|  | IsPublishedToRole | Determines if the repository is accessible to the specified Role |
|  | IsPublishedToTeam | Determines if the repository is accessible to the specified Team |
|  | IsPublishedToUser | Determines if the repository is accessible to the specified User |
|  | Publish | Makes the entire repository accessible to specified users, teams and roles |
|  | UnPublish | Makes the entire repository inaccessible to specified users, teams and roles |
|  | UnPublishToAll | Makes the entire repository inaccessible to All, other than the owner |



# IADPDMSafeLibraries Properties

The IADPDMSafeLibraries type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of libraries in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Name | Returns the name of the Libraries item. |
|  | Reference | Returns a unique Reference for the Libraries item. |
|  | Safe | Returns the Safe. |



# IADPDMFileItem.CheckIn Method

Push this file item into the PDM Server asynchronously.

#### Syntax

```
void CheckIn(
	string versionComment,
	IADPDMTaskCallback callback
)
```

#### Parameters

versionComment  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Add version comment property to this file item.

callback  IADPDMTaskCallback
:   Provides a callback when the check in operation completes.



# IADPDMFolder.Parent Property

Returns the parent folder of this folder.

#### Syntax

```
IADPDMFolder Parent { get; }
```

#### Property Value

IADPDMFolder



# IADFolders.Enum Property

Returns an enumerator for the collection

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADPDMClass.DefaultProperties Property

Returns the default properties of the Class item.

#### Syntax

```
IADPDMProperties DefaultProperties { get; }
```

#### Property Value

IADPDMProperties



# IADPDMVersionFileItem Properties

The IADPDMVersionFileItem type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CheckedInAt | Returns when this version was checked in. |
|  | CheckedInBy | Returns who checked in this version. |
|  | IsConsumed | Returns whether this version has been consumed or not. |
|  | ItemType | Returns the type of this item. |
|  | Name | Returns the name of this item. |
|  | PreviewImage | Returns the preview image of this version item. |
|  | Revision | Returns the Revision text. |
|  | Safe | Returns the Safe. |
|  | Version | Returns the version number of this item. |
|  | VersionComment | Returns the version comment. |



# IADPDMVersionFileItem.PreviewImage Property

Returns the preview image of this version item.

#### Syntax

```
byte[] PreviewImage { get; }
```

#### Property Value

[Byte](https://learn.microsoft.com/dotnet/api/system.byte)



# IADPDMSafeRecycleBin Methods

The IADPDMSafeRecycleBin type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | EmptyBin | Empties the RecycleBin folder. |
|  | GetEnumerator | Returns an enumerator for the collection |
|  | Item | Given a name or index, into the collection, returns the corresponding file item. |



# IADPDMFileItem.UnShelve Method

UnShelve the given file item.

#### Syntax

```
void UnShelve(
	string filePath
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   A Windows file path of the Shelve file.



# IADFolder.Delete Method

Deletes this folder and its contents from the repository.

#### Syntax

```
void Delete()
```



# IADPDMTaskCallback.OnTaskCompleted Method

Notifies Task completion.

#### Syntax

```
void OnTaskCompleted()
```



# IADPDMClasses Properties

The IADPDMClasses type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of classes in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Safe | Returns the Safe. |



# IADPDMSafeLibraries.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADFolder Methods

The IADFolder type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | ClearNotification | Makes this folder completely unnotified to the specified collection of users, teams and roles on a secure object type basis |
|  | ClearNotificationToAll | Makes this folder completely unnotified to all, other than the owner on a secure object type basis |
|  | ClearPermission | Makes this folder completely inaccessible to the specified collection of users, teams and roles on a secure object type basis |
|  | ClearPermissionToAll | Makes this folder completely inaccessible to all, other than the owner on a secure object type basis |
|  | Copy | Copies this folder and contents to the input destination parent folder and returns the copy. |
|  | CreateSubFolder | Creates a new sub-folder with the given name under this folder and returns its interface. |
|  | Delete | Deletes this folder and its contents from the repository. |
|  | Deposit | Deposits the given file as an unknown item in this folder. |
|  | IsAccessibleToRole | Checks if this folder is accessible to the specified Role and if so, returns the present access rights and notification settings for this Role |
|  | IsAccessibleToTeam | Determines if this folder's contents are accessible to the specified team and if so, returns the present access rights and notification settings for this team |
|  | IsAccessibleToUser | Checks if this folder is accessible to the specified user and if so, returns the present access rights and notification settings for this user |
|  | IsRecycleBin | Determines if this folder corresponds to the recycle bin. |
|  | Move | Moves this folder and contents to the input destination parent folder and returns the new folder. |
|  | Rename | Renames this folder to the input name. |
|  | setNotification | Sets the notification of this folder for the specified collection of users, teams and roles on a secure object type basis |
|  | setPermission | Sets the access permissions of this folder for the specified collection of users, teams and roles on a secure object type basis. |



# IADPDMTemplate.IsConsumed Property

Returns whether the Template is consumed by any project or not.

#### Syntax

```
bool IsConsumed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMPropertyDefinition.UpdateDefinition Method

#### Overload List

|  | Name | Description |
| --- | --- | --- |
|  | UpdateDefinition(ADPDMPropertyValueType) | Updates the Property Definition. |
|  | UpdateDefinition(IADPDMClass, Boolean, Boolean) | Updates the Property Definition. |



# IADPDMTemplateLevels.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADPDMTemplateLevel Properties

The IADPDMTemplateLevel type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ClassItem | Returns the class item corresponding to this level. |
|  | Name | Returns the name of the Template Level item. |
|  | Safe | Returns the Safe. |
|  | Template | Returns the Template of this level item. |



# IADPDMPropertyDefinition Interface

IADPDMPropertyDefinition provides access to a Property Definition.

#### Syntax

```
public interface IADPDMPropertyDefinition
```

The IADPDMPropertyDefinition type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | AllowValuesOnTheFly | Returns whether the values can be added on the fly for a Class type definition. |
|  | ClassItem | Returns the Class Item of the Property Definition if the definition type is a Class. |
|  | DisplayName | Returns the display name of the Property Definition. |
|  | IsBuiltInPropertyDefinition | Returns whether the Property Definition is a built in or a custom PDM property. |
|  | IsConsumed | Returns whether the Property Definition is consumed by any item. |
|  | Name | Returns the name of the Property Definition. |
|  | PropertyValueType | Returns the Value Type of the Property Definition if the definition is a User Input type. |
|  | Safe | Returns the Safe. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes the Property Definition. |
|  | Rename | Renames the Property Definition. |
|  | SetSVGIcon | Sets the given SVG icon to the Property Definition. |
|  | UnSetSVGIcon | Unsets any SVG icon from the Property Definition. |
|  | UpdateDefinition(ADPDMPropertyValueType) | Updates the Property Definition. |
|  | UpdateDefinition(IADPDMClass, Boolean, Boolean) | Updates the Property Definition. |



# IADPDMSafeLibraries.Name Property

Returns the name of the Libraries item.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMSafeProjects.CreateProject Method

Create a new project using the given template.

#### Syntax

```
IADPDMSafeProject CreateProject(
	string name,
	IADPDMTemplate templateToUse
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

templateToUse  IADPDMTemplate

#### Return Value

IADPDMSafeProject



# IObjectCollector.Clear Method

Removes all objects from the collection.

#### Syntax

```
void Clear()
```



# IADPDMSafeLibraries.Item Method

Given a numerical index into the collection, returns the corresponding Library.

#### Syntax

```
IADPDMSafeLibrary Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The numerical index of the Library.

#### Return Value

IADPDMSafeLibrary  
Returns IADPDMSafeLibrary



# IADPDMFolder.Restore Method

Restores this folder from Recycle Bin to its original location.

#### Syntax

```
void Restore()
```



# IADRepository.UnPublish Method

Makes the entire repository inaccessible to specified users, teams and roles

#### Syntax

```
void UnPublish(
	IObjectCollector pUsers,
	IObjectCollector pTeams,
	IObjectCollector pRoles
)
```

#### Parameters

pUsers  IObjectCollector

pTeams  IObjectCollector

pRoles  IObjectCollector



# IADFolderItem.ParentFolder Property

Returns interface to this folder-item's parent folder

#### Syntax

```
IADFolder ParentFolder { get; }
```

#### Property Value

IADFolder



# IADPDMFileItem.Name Property

The name of the file item without the extension.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMTemplate.AddLevel Method

Adds a new level to the template.

#### Syntax

```
void AddLevel(
	IADPDMClass classItem
)
```

#### Parameters

classItem  IADPDMClass



# IADPDMClassDataItems.Count Property

Returns the number of class data items in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

The count property for the ClassDataItems object held by automation clients will
not get updated automatically when a ClassDataItem is added or deleted. Get the current
ClassDataItems collection by querying the Class.



# IADPDMTemplateLevels Interface

IADPDMTemplateLevels provides access to the template levels.

#### Syntax

```
public interface IADPDMTemplateLevels
```

The IADPDMTemplateLevels type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of template levels in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Safe | Returns the Safe. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | GetLevelByName | Returns the level for a given name. |
|  | Item | Given a numerical index into the collection, returns the corresponding Template Level. |



# IADPDMProperties.GetEnumerator Method

Returns an enumerator for the collection.

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADPDMFolder.Properties Property

Returns the properties of this folder.

#### Syntax

```
IADPDMProperties Properties { get; }
```

#### Property Value

IADPDMProperties



# IADFolderItem.Withdraw Method

If the item-type is UNKNOWNITEM, then, this method transfers it to the Windows file system at the specified location

#### Syntax

```
void Withdraw(
	string destPath,
	bool checkOutFlag
)
```

#### Parameters

destPath  [String](https://learn.microsoft.com/dotnet/api/system.string)

checkOutFlag  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMFileItem.UnLock Method

Unlocks this file item.

#### Syntax

```
void UnLock(
	bool includeConstituents
)
```

#### Parameters

includeConstituents  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   A value of TRUE includes all the constituents of this file item for unlocking.



# IADPDMTemplateLevels.Count Property

Returns the number of template levels in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

The count property for the TemplateLevels object held by automation clients will
not get updated automatically when a TemplateLevel is added or deleted. Get the current
TemplateLevels collection by querying the Template.



# IADPDMFolder.RemoveProperty Method

Removes the given property from this folder.

#### Syntax

```
void RemoveProperty(
	IADPDMProperty property
)
```

#### Parameters

property  IADPDMProperty
:   The property item to be removed from this folder.



# IADFolderItem.IsAccessibleToUser Method

Checks if this folder-item is accessible to the specified user and if so, returns the present access rights and notification settings for this user

#### Syntax

```
bool IsAccessibleToUser(
	IADUser pUser,
	out IPermissionSelector ppPermissions,
	out INotificationSelector ppNotifications
)
```

#### Parameters

pUser  IADUser

ppPermissions  IPermissionSelector

ppNotifications  INotificationSelector

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADFolderItem.ItemType Property

Returns a pre-defined constant that identifies whether this folder-item represents a part or assembly or drawing etc.

#### Syntax

```
ADObjectSubType ItemType { get; }
```

#### Property Value

ADObjectSubType



# IADFolderItem.IsAccessibleToTeam Method

Determines if this folder-items contents are accessible to the specified team and if so, returns the present access rights and notification settings for this team

#### Syntax

```
bool IsAccessibleToTeam(
	IADTeam pTeam,
	out IPermissionSelector ppPermissions,
	out INotificationSelector ppNotifications
)
```

#### Parameters

pTeam  IADTeam

ppPermissions  IPermissionSelector

ppNotifications  INotificationSelector

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADFolderItem.AddNote Method

Creates a new note for this folder-item

#### Syntax

```
void AddNote(
	string subject,
	string noteDescription
)
```

#### Parameters

subject  [String](https://learn.microsoft.com/dotnet/api/system.string)

noteDescription  [String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMClass.IsCoreClass Property

Returns whether the Class is a Core or a custom Class item.

#### Syntax

```
bool IsCoreClass { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMSafeLibrary Interface

IADPDMSafeLibrary represents an library item in the PDM Safe.

#### Syntax

```
public interface IADPDMSafeLibrary : IADPDMFolder
```

The IADPDMSafeLibrary type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FileItems | Returns the file items in this folder.  (Inherited from IADPDMFolder) |
|  | Folders | Returns the next level folders under this folder.  (Inherited from IADPDMFolder) |
|  | IsDeleted | Returns whether this folder has been deleted and is inside Recycle Bin or not.  (Inherited from IADPDMFolder) |
|  | IsTemplateFolder | Returns whether this folder is based on a Template Level item or not.  (Inherited from IADPDMFolder) |
|  | Name | Returns the name of the folder.  (Inherited from IADPDMFolder) |
|  | Parent | Returns the libraries item which contains this library item. |
|  | Properties | Returns the properties of this folder.  (Inherited from IADPDMFolder) |
|  | Reference | Returns a unique reference to identify the folder.  (Inherited from IADPDMFolder) |
|  | Safe | Returns the Safe.  (Inherited from IADPDMFolder) |
|  | SubFolderTemplateLevel | Returns the Template Level item of the next level folders (sub folders), if any.  (Inherited from IADPDMFolder) |
|  | TemplateLevel | Returns the Template Level item of this folder, if any.  (Inherited from IADPDMFolder) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CancelCheckIn | Cancels the check-in operation, if possible.  (Inherited from IADPDMFolder) |
|  | CreateFolder | Creates a new sub folder.  (Inherited from IADPDMFolder) |
|  | CreateTemplateFolder | Creates a new sub folder based on the Class defined in the level.  (Inherited from IADPDMFolder) |
|  | Delete | Deletes this folder.  (Inherited from IADPDMFolder) |
|  | Purge | Deletes this folder permanently from the Server as well. This cannot be undone.  (Inherited from IADPDMFolder) |
|  | RemoveProperty | Removes the given property from this folder.  (Inherited from IADPDMFolder) |
|  | Rename | Renames this folder.  (Inherited from IADPDMFolder) |
|  | Restore | Restores this folder from Recycle Bin to its original location.  (Inherited from IADPDMFolder) |
|  | SetProperty | Sets the given property to this folder.  (Inherited from IADPDMFolder) |
|  | UploadDocuments | Uploads non native file items to this folder.  (Inherited from IADPDMFolder) |



# IADPDMTemplateLevel.ClassItem Property

Returns the class item corresponding to this level.

#### Syntax

```
IADPDMClass ClassItem { get; }
```

#### Property Value

IADPDMClass



# IADPDMSafeRecycleBin.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADPDMClass.Rename Method

Renames the Class item.

#### Syntax

```
void Rename(
	string newName
)
```

#### Parameters

newName  [String](https://learn.microsoft.com/dotnet/api/system.string)



# IADFolder.Root Property

Returns the automation root.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADPDMClasses.GetEnumerator Method

Returns an enumerator for the collection

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADPDMFolders Interface

IADPDMFolders provides access to the collection of folder items.

#### Syntax

```
public interface IADPDMFolders
```

The IADPDMFolders type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of folders in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Safe | Returns the Safe. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection |
|  | GetFolderByName | Returns a folder item for a given name. |
|  | Item | Given a name or index, into the collection, returns the corresponding folder item. |



# IADPDMFileItem.History Property

Returns the older versions of this file item.

#### Syntax

```
IADPDMVersionFileItems History { get; }
```

#### Property Value

IADPDMVersionFileItems



# IADPDMServerConnection.IsOnline Property

Returns whether the server is online or not.

#### Syntax

```
bool IsOnline { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMFileItems.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADRepository.IsPublishedToUser Method

Determines if the repository is accessible to the specified User

#### Syntax

```
bool IsPublishedToUser(
	IADUser pUser
)
```

#### Parameters

pUser  IADUser

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADFolderItem.Move Method

Moves this folder-item to the input destination parent folder and returns the new folder-item

#### Syntax

```
IADFolderItem Move(
	IADFolder pDestination,
	string newName
)
```

#### Parameters

pDestination  IADFolder

newName  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADFolderItem



# IADPDMSafeLibraries.GetEnumerator Method

Returns an enumerator for the collection.

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADFolderItem.Share Method

Shares this folder-item to the specified destination folder. This method is obsolete.

#### Syntax

```
void Share(
	IADFolder pDestination,
	string newName
)
```

#### Parameters

pDestination  IADFolder

newName  [String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMSafe Properties

The IADPDMSafe type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Classes | Returns the Class items in the Safe. |
|  | Libraries | Returns the Libraries item in the Safe. |
|  | Name | Returns the name of the Safe. |
|  | Projects | Returns the Projects item in the Safe. |
|  | PropertyDefinitions | Returns the Property Definition items in the Safe. |
|  | RecycleBin | Returns the Recycle Bin item in the Safe. |
|  | Reference | Returns the unique Reference of the Safe Root item. |
|  | ServerConnection | Returns the server connection object. |
|  | Templates | Returns the Template items in the Safe. |



# IADPDMFileItem.LockFrom Property

Returns the client machine name from which this file was locked from.

#### Syntax

```
string LockFrom { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMServerConnection.UserName Property

Returns the user name.

#### Syntax

```
string UserName { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMTemplates.Count Property

Returns the number of templates in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

The count property for the Templates object held by automation clients will
not get updated automatically when a Template is added or deleted. Get the current
Templates collection by querying the Safe.



# IADPDMFolder.SetProperty Method

Sets the given property to this folder.

#### Syntax

```
void SetProperty(
	IADPDMProperty property
)
```

#### Parameters

property  IADPDMProperty
:   The property item to be set in this folder.



# IADPDMSafeLibraries.CreateLibrary Method

Create a new library.

#### Syntax

```
IADPDMSafeLibrary CreateLibrary(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADPDMSafeLibrary



# IADPDMFolders.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADPDMPropertyDefinitions.CreateDefinitionByUserInput Method

Creates a new Property Definition for a given user input type.

#### Syntax

```
IADPDMPropertyDefinition CreateDefinitionByUserInput(
	string name,
	ADPDMPropertyValueType type
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the property definition.

type  ADPDMPropertyValueType
:   The value type of the property definition.

#### Return Value

IADPDMPropertyDefinition



# IADPDMFileItem Interface

IADPDMFileItem provides access to a file item.

#### Syntax

```
public interface IADPDMFileItem
```

The IADPDMFileItem type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Cached | Returns whether this file item is cached or not. |
|  | CurrentVersionID | Returns the latest version of this file item. |
|  | Extension | Returns the extension of this file item. |
|  | FileSize | Returns the file size as number of bytes. |
|  | History | Returns the older versions of this file item. |
|  | IsConsumed | Returns whether this file item has been consumed by any other file item (for native files). |
|  | IsDeleted | Returns whether this file item has been deleted and is inside Recycle Bin or not. |
|  | IsLocked | Returns whether this file item is locked or not. |
|  | ItemType | The type of the file item based on the extension. |
|  | LocallyModified | Returns whether this file item is modified locally or not. |
|  | LockFrom | Returns the client machine name from which this file was locked from. |
|  | LockUser | Returns the user who has locked this file. |
|  | ModifiedVersion | Returns the modified version of this file item. |
|  | Name | The name of the file item without the extension. |
|  | NewFile | Returns whether the file item is a New one or a checked in one. |
|  | Parent | The folder which contains this file item. |
|  | PreviewImage | Returns the preview image of this file item as byte array. |
|  | Properties | Returns the properties of this file item. |
|  | Reference | The unique string to identify the file item. |
|  | Safe | Returns the Safe. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CancelCheckIn | Cancels the check-in operation, if possible. |
|  | CheckIn | Push this file item into the PDM Server asynchronously. |
|  | Copy | Copies this file item to a given location. |
|  | CopyWithConstituents | Copies this file item and its constituents (for native files) to a given location. |
|  | Delete | Deletes this file item. |
|  | Lock | Locks this file item. |
|  | Move | Moves this files item to a given location. |
|  | MoveWithConstituents | Moves this file item and its constituents (for native files) to a given location. |
|  | Open | Opens the native file item. |
|  | OpenNonNativeFileItem | Opens an non native file item like STEP, SAT, etc. |
|  | Purge | Deletes this file item permanently from the Server as well. This cannot be undone. |
|  | PurgeWithConstituents | Deletes this file item and its constituents (for native files) permanently. This cannot be undone. |
|  | RemoveProperty | Removes the given property from this file item. |
|  | Rename | Rename this file item. |
|  | Restore | Restores this file item from Recycle Bin to its original location. |
|  | Revert | Reverts the local changes of this file item. |
|  | SetProperty | Sets the given property to this file item. |
|  | Shelve | Shelve this file item. |
|  | UnLock | Unlocks this file item. |
|  | UnShelve | UnShelve the given file item. |



# IADPDMClasses.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADPDMSafeProject Properties

The IADPDMSafeProject type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FileItems | Returns the file items in this folder.  (Inherited from IADPDMFolder) |
|  | Folders | Returns the next level folders under this folder.  (Inherited from IADPDMFolder) |
|  | IsDeleted | Returns whether this folder has been deleted and is inside Recycle Bin or not.  (Inherited from IADPDMFolder) |
|  | IsTemplateFolder | Returns whether this folder is based on a Template Level item or not.  (Inherited from IADPDMFolder) |
|  | Name | Returns the name of the folder.  (Inherited from IADPDMFolder) |
|  | Parent | Returns the projects item which contains this project item. |
|  | Properties | Returns the properties of this folder.  (Inherited from IADPDMFolder) |
|  | Reference | Returns a unique reference to identify the folder.  (Inherited from IADPDMFolder) |
|  | Safe | Returns the Safe.  (Inherited from IADPDMFolder) |
|  | SubFolderTemplateLevel | Returns the Template Level item of the next level folders (sub folders), if any.  (Inherited from IADPDMFolder) |
|  | TemplateLevel | Returns the Template Level item of this folder, if any.  (Inherited from IADPDMFolder) |



# IADFolderItem Properties

The IADFolderItem type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CurrentVersionID | Returns the current version number of this folder-item |
|  | ItemType | Returns a pre-defined constant that identifies whether this folder-item represents a part or assembly or drawing etc. |
|  | Name | Returns this repository folder-item's name. |
|  | ParentFolder | Returns interface to this folder-item's parent folder |
|  | Reference | Returns a unique, persistent reference-string for this folder-item |
|  | Repository | Returns interface to repository in which this folder-item exists |
|  | Root | Returns the automation root |
|  | Type | Returns a pre-defined constant that identifies the type of this object. |



# IADPDMClasses.CreateClass Method

Creates a new Class item.

#### Syntax

```
IADPDMClass CreateClass(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the Class item.

#### Return Value

IADPDMClass  
IADPDMClass



# IADPDMSafe Interface

IADPDMSafe provides access to various items in the PDM Safe.

#### Syntax

```
public interface IADPDMSafe
```

The IADPDMSafe type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Classes | Returns the Class items in the Safe. |
|  | Libraries | Returns the Libraries item in the Safe. |
|  | Name | Returns the name of the Safe. |
|  | Projects | Returns the Projects item in the Safe. |
|  | PropertyDefinitions | Returns the Property Definition items in the Safe. |
|  | RecycleBin | Returns the Recycle Bin item in the Safe. |
|  | Reference | Returns the unique Reference of the Safe Root item. |
|  | ServerConnection | Returns the server connection object. |
|  | Templates | Returns the Template items in the Safe. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreatePropertyInstance | Returns a property instance using the given Property Definition and a Value. |



# IADPDMClass.AddDefaultProperty Method

Adds a default property to the Class item.

#### Syntax

```
void AddDefaultProperty(
	IADPDMPropertyDefinition definition
)
```

#### Parameters

definition  IADPDMPropertyDefinition



# IADPDMPropertyDefinitions.Count Property

Returns the number of property definitions in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

The count property for the Property Definitions object held by automation clients will
not get updated automatically when a Property Definition is added or deleted. Get the current
Property Definitions collection by querying the Safe.



# IObjectCollector Interface

The IObjectCollector interface represents a collection object. Several Methods in the
Alibre Automation Type Library take a list of values or elements as collections, and several
Properties return such lists. A new collection can be created by calling
IADRoot.NewObjectCollector, and adding the desired
elements to the newly created collection. Then that collection can be passed to Methods.

#### Syntax

```
public interface IObjectCollector
```

The IObjectCollector type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of objects in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | ObjectType | Returns the type of the objects in the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Add | Adds an object to the collection. |
|  | Clear | Removes all objects from the collection. |
|  | Item | Given a numerical index into the collection, returns the corresponding element. |
|  | Remove | Removes an object from the collection. |



# IADPDMTemplates.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADPDMClasses.Item Method

Given a numerical index into the collection, returns the corresponding Class item.

#### Syntax

```
IADPDMClass Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The numerical index of the Class item.

#### Return Value

IADPDMClass  
IADPDMClass



# IADPDMClassDataItems Methods

The IADPDMClassDataItems type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetClassDataItemByName | Returns a class data item for a given name. |
|  | GetEnumerator | Returns an enumerator for the collection |
|  | Item | Given a numerical index into the collection, returns the corresponding Class Data Item. |



# IADPDMProperty.IntValue Property

Returns a value if the actual value is of integer type.

#### Syntax

```
int IntValue { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADPDMSafe.Classes Property

Returns the Class items in the Safe.

#### Syntax

```
IADPDMClasses Classes { get; }
```

#### Property Value

IADPDMClasses



# IADFolder.ParentFolder Property

Returns interface to this folder's parent folder.

#### Syntax

```
IADFolder ParentFolder { get; }
```

#### Property Value

IADFolder



# IADPDMSafes.ServerConnection Property

Returns the Server Connection.

#### Syntax

```
IADPDMServerConnection ServerConnection { get; }
```

#### Property Value

IADPDMServerConnection



# IADPDMPropertyDefinition.Delete Method

Deletes the Property Definition.

#### Syntax

```
void Delete()
```



# IADPDMSafeLibrary Properties

The IADPDMSafeLibrary type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FileItems | Returns the file items in this folder.  (Inherited from IADPDMFolder) |
|  | Folders | Returns the next level folders under this folder.  (Inherited from IADPDMFolder) |
|  | IsDeleted | Returns whether this folder has been deleted and is inside Recycle Bin or not.  (Inherited from IADPDMFolder) |
|  | IsTemplateFolder | Returns whether this folder is based on a Template Level item or not.  (Inherited from IADPDMFolder) |
|  | Name | Returns the name of the folder.  (Inherited from IADPDMFolder) |
|  | Parent | Returns the libraries item which contains this library item. |
|  | Properties | Returns the properties of this folder.  (Inherited from IADPDMFolder) |
|  | Reference | Returns a unique reference to identify the folder.  (Inherited from IADPDMFolder) |
|  | Safe | Returns the Safe.  (Inherited from IADPDMFolder) |
|  | SubFolderTemplateLevel | Returns the Template Level item of the next level folders (sub folders), if any.  (Inherited from IADPDMFolder) |
|  | TemplateLevel | Returns the Template Level item of this folder, if any.  (Inherited from IADPDMFolder) |



# IADFolder.CreateSubFolder Method

Creates a new sub-folder with the given name under this folder and returns its interface.

#### Syntax

```
IADFolder CreateSubFolder(
	string folderName
)
```

#### Parameters

folderName  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADFolder



# IADPDMSafeProjects.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADPDMFolders.GetFolderByName Method

Returns a folder item for a given name.

#### Syntax

```
IADPDMFolder GetFolderByName(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADPDMFolder



# IADPDMVersionFileItems.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADPDMFileItem.MoveWithConstituents Method

Moves this file item and its constituents (for native files) to a given location.

#### Syntax

```
IADPDMFileItem MoveWithConstituents(
	IADPDMFolder pDestination
)
```

#### Parameters

pDestination  IADPDMFolder
:   The destination folder for this operation.

#### Return Value

IADPDMFileItem



# IADPDMSafeProjects.GetProjectByName Method

Returns a project item by name.

#### Syntax

```
IADPDMSafeProject GetProjectByName(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADPDMSafeProject



# IADPDMPropertyDefinition.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADPDMClassDataItems Properties

The IADPDMClassDataItems type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of class data items in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Safe | Returns the Safe. |



# IADPDMPropertyDefinitions.GetDefinitionByName Method

Returns the Property Definition for a given name.

#### Syntax

```
IADPDMPropertyDefinition GetDefinitionByName(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADPDMPropertyDefinition



# IADPDMSafeProjects.Name Property

Returns the Name of the Projects item.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMVersionFileItems Properties

The IADPDMVersionFileItems type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of versions in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Safe | Returns the Safe. |



# IADPDMTaskCallback Methods

The IADPDMTaskCallback type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | OnTaskCompleted | Notifies Task completion. |



# IADPDMPropertyDefinition.DisplayName Property

Returns the display name of the Property Definition.

#### Syntax

```
string DisplayName { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMSafe.Name Property

Returns the name of the Safe.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMServerConnection Properties

The IADPDMServerConnection type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Domain | Returns the domain name. |
|  | IsOnline | Returns whether the server is online or not. |
|  | Root | Returns the API root. |
|  | Safes | Returns the list of available 'Active' Safes. |
|  | URL | Returns the Server URL. |
|  | UserName | Returns the user name. |



# IADRepository Interface

IADRepository interface. This interface is obsolete as of V11 of Alibre Design.

#### Syntax

```
public interface IADRepository
```

The IADRepository type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Name | Returns the repository's name |
|  | Root | Returns the automation root |
|  | RootFolder | Returns interface to the repository's top most folder |
|  | Type | Returns a pre-defined constant that identifies the type of this object |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | IsPublished | Determines if the repository is accessible to anyone other than the owner |
|  | IsPublishedToRole | Determines if the repository is accessible to the specified Role |
|  | IsPublishedToTeam | Determines if the repository is accessible to the specified Team |
|  | IsPublishedToUser | Determines if the repository is accessible to the specified User |
|  | Publish | Makes the entire repository accessible to specified users, teams and roles |
|  | UnPublish | Makes the entire repository inaccessible to specified users, teams and roles |
|  | UnPublishToAll | Makes the entire repository inaccessible to All, other than the owner |



# IADPDMPropertyDefinitions Methods

The IADPDMPropertyDefinitions type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateDefinitionByClass | Creates a new Property Definition for a given Class item. |
|  | CreateDefinitionByUserInput | Creates a new Property Definition for a given user input type. |
|  | GetDefinitionByName | Returns the Property Definition for a given name. |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given a numerical index into the collection, returns the corresponding Property Definition. |



# IADPDMFolder.Reference Property

Returns a unique reference to identify the folder.

#### Syntax

```
string Reference { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMPropertyDefinitions.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADPDMFileItem.Shelve Method

Shelve this file item.

#### Syntax

```
void Shelve(
	string folderPath
)
```

#### Parameters

folderPath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   A Windows folder path to export the Shelve file.



# IADPDMVersionFileItem Interface

IADPDMVersionFileItem provides access to a particular version of an file item.

#### Syntax

```
public interface IADPDMVersionFileItem
```

The IADPDMVersionFileItem type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CheckedInAt | Returns when this version was checked in. |
|  | CheckedInBy | Returns who checked in this version. |
|  | IsConsumed | Returns whether this version has been consumed or not. |
|  | ItemType | Returns the type of this item. |
|  | Name | Returns the name of this item. |
|  | PreviewImage | Returns the preview image of this version item. |
|  | Revision | Returns the Revision text. |
|  | Safe | Returns the Safe. |
|  | Version | Returns the version number of this item. |
|  | VersionComment | Returns the version comment. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddRevision | Make this version as a Revision item. |
|  | OpenNonNativeFileItemReadOnly | Opens this non native item as read only. |
|  | OpenReadOnly | Opens this native item as read only. |
|  | PurgeVersion | Purge this version. |
|  | RemoveRevision | Removes the Revision. |
|  | RestoreVersion | Make this version as the latest version. |
|  | UpdateRevision | Updates the Revision text. |
|  | UpdateVersionComment | Updates the version comment. |



# IADPDMProperties Interface

IADPDMProperties provides access to the item properties.

#### Syntax

```
public interface IADPDMProperties
```

The IADPDMProperties type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of properties in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Safe | Returns the Safe. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | GetPropertyByName | Returns an Property item for a given name. |
|  | Item | Given a name or index, into the collection, returns the corresponding property. |



# IADPDMSafeRecycleBin.GetEnumerator Method

Returns an enumerator for the collection

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADPDMTemplate Methods

The IADPDMTemplate type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddLevel | Adds a new level to the template. |
|  | Delete | Deletes this Temaplate item. |
|  | RemoveLevel | Removes the level from the template. |



# IADPDMVersionFileItem.CheckedInBy Property

Returns who checked in this version.

#### Syntax

```
string CheckedInBy { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMPropertyDefinition.IsConsumed Property

Returns whether the Property Definition is consumed by any item.

#### Syntax

```
bool IsConsumed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMVersionFileItems.Count Property

Returns the number of versions in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

The count property for the versions held by automation clients will
not get updated automatically when a version is added or deleted. Get the current
versions collection by querying the File.



# IADPDMVersionFileItems.GetEnumerator Method

Returns an enumerator for the collection.

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADPDMFileItems.Item Method

Given a name or index, into the collection, returns the corresponding file item.

#### Syntax

```
IADPDMFileItem Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or index of the file item.

#### Return Value

IADPDMFileItem  
IADPDMFileItem



# IADPDMProperty.DisplayName Property

Returns the display name of the Property.

#### Syntax

```
string DisplayName { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMFileItem.Delete Method

Deletes this file item.

#### Syntax

```
void Delete(
	bool includeConstituents
)
```

#### Parameters

includeConstituents  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   A value of TRUE includes all the constituents of this file item for deleting.



# IADFolder.Reference Property

Returns a unique, persistent reference-string for this folder.

#### Syntax

```
string Reference { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMClassDataItems.Item Method

Given a numerical index into the collection, returns the corresponding Class Data Item.

#### Syntax

```
IADPDMClassDataItem Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The numerical index of the Class Data Item.

#### Return Value

IADPDMClassDataItem  
IADPDMClassDataItem



# IADPDMTemplateLevel.Template Property

Returns the Template of this level item.

#### Syntax

```
IADPDMTemplate Template { get; }
```

#### Property Value

IADPDMTemplate



# IADPDMFileItem.SetProperty Method

Sets the given property to this file item.

#### Syntax

```
void SetProperty(
	IADPDMProperty property
)
```

#### Parameters

property  IADPDMProperty
:   The property item to be set in this file item.



# IADPDMProperty Interface

IADPDMProperty provides access to a property item.

#### Syntax

```
public interface IADPDMProperty
```

The IADPDMProperty type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DateTimeValue | Returns a value if the actual value is of date time type. |
|  | DisplayName | Returns the display name of the Property. |
|  | DoubleValue | Returns a value if the actual value is of real type. |
|  | HasValue | Returns whether the value is a non NULL value or not. |
|  | IntValue | Returns a value if the actual value is of integer type. |
|  | MultilineTextValue | Returns a value if the actual value is of multiline text type. |
|  | MultiSelectValue | Returns a value if the actual value is of multi select type. |
|  | PropertyDefinition | Returns the Property Definition associated with this property. |
|  | Safe | Returns the Safe. |
|  | SelectValue | Returns a value if the actual value is of single select type. |
|  | TextValue | Returns a value if the actual value is of text type. |
|  | Type | Returns the value type this object. |
|  | Value | Returns the value as a string. |



# IADPDMTemplate Properties

The IADPDMTemplate type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | IsConsumed | Returns whether the Template is consumed by any project or not. |
|  | Levels | Returns the Template Levels. |
|  | Name | Returns the name of the Template item. |
|  | Safe | Returns the Safe. |



# IADPDMFileItem Properties

The IADPDMFileItem type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Cached | Returns whether this file item is cached or not. |
|  | CurrentVersionID | Returns the latest version of this file item. |
|  | Extension | Returns the extension of this file item. |
|  | FileSize | Returns the file size as number of bytes. |
|  | History | Returns the older versions of this file item. |
|  | IsConsumed | Returns whether this file item has been consumed by any other file item (for native files). |
|  | IsDeleted | Returns whether this file item has been deleted and is inside Recycle Bin or not. |
|  | IsLocked | Returns whether this file item is locked or not. |
|  | ItemType | The type of the file item based on the extension. |
|  | LocallyModified | Returns whether this file item is modified locally or not. |
|  | LockFrom | Returns the client machine name from which this file was locked from. |
|  | LockUser | Returns the user who has locked this file. |
|  | ModifiedVersion | Returns the modified version of this file item. |
|  | Name | The name of the file item without the extension. |
|  | NewFile | Returns whether the file item is a New one or a checked in one. |
|  | Parent | The folder which contains this file item. |
|  | PreviewImage | Returns the preview image of this file item as byte array. |
|  | Properties | Returns the properties of this file item. |
|  | Reference | The unique string to identify the file item. |
|  | Safe | Returns the Safe. |



# IObjectCollector.Item Method

Given a numerical index into the collection, returns the corresponding element.

#### Syntax

```
Object Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Numerical index into the collection.

#### Return Value

[Object](https://learn.microsoft.com/dotnet/api/system.object)



# IADPDMFolder.CancelCheckIn Method

Cancels the check-in operation, if possible.

#### Syntax

```
void CancelCheckIn()
```



# IADPDMVersionFileItem.OpenReadOnly Method

Opens this native item as read only.

#### Syntax

```
IADSession OpenReadOnly(
	bool openEditor
)
```

#### Parameters

openEditor  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Return Value

IADSession



# IADFolder.Deposit Method

Deposits the given file as an unknown item in this folder.

#### Syntax

```
void Deposit(
	string fileName,
	bool checkInFlag
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)

checkInFlag  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMFileItem.LockUser Property

Returns the user who has locked this file.

#### Syntax

```
string LockUser { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADFolders Properties

The IADFolders type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of repository folders in this collection |
|  | Enum | Returns an enumerator for the collection |



# IADPDMSafe.Reference Property

Returns the unique Reference of the Safe Root item.

#### Syntax

```
string Reference { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IObjectCollector Methods

The IObjectCollector type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Add | Adds an object to the collection. |
|  | Clear | Removes all objects from the collection. |
|  | Item | Given a numerical index into the collection, returns the corresponding element. |
|  | Remove | Removes an object from the collection. |



# IADPDMFileItem.Restore Method

Restores this file item from Recycle Bin to its original location.

#### Syntax

```
void Restore()
```



# IObjectCollector.ObjectType Property

Returns the type of the objects in the collection.

#### Syntax

```
ADObjectType ObjectType { get; }
```

#### Property Value

ADObjectType

#### Remarks

It is not always guaranteed that ObjectType returns the correct type
of the objects in the collection.



# IADPDMServerConnection.URL Property

Returns the Server URL.

#### Syntax

```
string URL { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMPropertyDefinition.UpdateDefinition(ADPDMPropertyValueType) Method

Updates the Property Definition.

#### Syntax

```
void UpdateDefinition(
	ADPDMPropertyValueType type
)
```

#### Parameters

type  ADPDMPropertyValueType
:   The value type of this property definition.



# IADPDMProperties Methods

The IADPDMProperties type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | GetPropertyByName | Returns an Property item for a given name. |
|  | Item | Given a name or index, into the collection, returns the corresponding property. |



# IADPDMPropertyDefinitions.Item Method

Given a numerical index into the collection, returns the corresponding Property Definition.

#### Syntax

```
IADPDMPropertyDefinition Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The numerical index of the Property Definition.

#### Return Value

IADPDMPropertyDefinition  
IADPDMPropertyDefinition



# IADPDMSafes Properties

The IADPDMSafes type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of Safes in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | ServerConnection | Returns the Server Connection. |



# IADPDMPropertyDefinition.PropertyValueType Property

Returns the Value Type of the Property Definition if the definition is a User Input type.

#### Syntax

```
ADPDMPropertyValueType PropertyValueType { get; }
```

#### Property Value

ADPDMPropertyValueType



# IADFolder.ClearPermissionToAll Method

Makes this folder completely inaccessible to all, other than the owner on a secure object type basis

#### Syntax

```
void ClearPermissionToAll(
	ADSecureObjectType secureObjectType,
	bool applyToAllSubFolders,
	bool applyToAllItems,
	bool unPublishingRepository
)
```

#### Parameters

secureObjectType  ADSecureObjectType

applyToAllSubFolders  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

applyToAllItems  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

unPublishingRepository  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADFolderItem.Rename Method

Renames this folder-item to the input name

#### Syntax

```
void Rename(
	string newName
)
```

#### Parameters

newName  [String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMVersionFileItem.RestoreVersion Method

Make this version as the latest version.

#### Syntax

```
void RestoreVersion(
	bool includeConstituents
)
```

#### Parameters

includeConstituents  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Optionally, apply this operation for all the constituents as well.



# IADPDMSafes Interface

IADPDMSafes represents the Active Safes in the PDM Server.

#### Syntax

```
public interface IADPDMSafes
```

The IADPDMSafes type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of Safes in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | ServerConnection | Returns the Server Connection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | GetSafeByName | Returns a Safe for a given Safe name. |
|  | Item | Given a name or index, into the collection, returns the corresponding Safe. |



# IObjectCollector.Add Method

Adds an object to the collection.

#### Syntax

```
void Add(
	Object pObject
)
```

#### Parameters

pObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Object to be added to the collection.

#### Example

The following sample code shows how to create a new Collection and add two existing Sketch objects to it. This collection can now be passed as pPathSketch in AddSweptBoss to create a Swept Boss Feature.

```
Dim objCollector As AlibreX.IObjectCollector
Set objCollector = m_objAlibreRoot.NewObjectCollector

objCollector.Add objSketch1
objCollector.Add objSketch2
```



# IADPDMFileItems.GetFileItemByName Method

Returns an file item for the given name.

#### Syntax

```
IADPDMFileItem GetFileItemByName(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADPDMFileItem



# IADPDMClassDataItem.Name Property

Returns the name of the Class data item.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMClass.DataItems Property

Returns the data items of the Class item.

#### Syntax

```
IADPDMClassDataItems DataItems { get; }
```

#### Property Value

IADPDMClassDataItems



# IADPDMFileItem.OpenNonNativeFileItem Method

Opens an non native file item like STEP, SAT, etc.

#### Syntax

```
IADSession OpenNonNativeFileItem(
	bool applyImportOptions,
	bool openEditor
)
```

#### Parameters

applyImportOptions  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Specifies whether to apply the import options or not.

openEditor  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Specifies whether to open the UI browser or not.

#### Return Value

IADSession



# IADPDMClassDataItems.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADPDMSafeRecycleBin.Name Property

Returns the name of the RecycleBin item.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADFolder.IsAccessibleToTeam Method

Determines if this folder's contents are accessible to the specified team and if so, returns the present access rights and notification settings for this team

#### Syntax

```
bool IsAccessibleToTeam(
	IADTeam pTeam,
	out IPermissionSelector ppPermissions,
	out INotificationSelector ppNotifications
)
```

#### Parameters

pTeam  IADTeam

ppPermissions  IPermissionSelector

ppNotifications  INotificationSelector

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMClass.UnSetSVGIcon Method

Unsets any SVG icon from the Class item.

#### Syntax

```
void UnSetSVGIcon()
```



# IADPDMFileItems.Count Property

Returns the number of file items in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADPDMVersionFileItems Interface

IADPDMVersionFileItems provides access to the older versions of file items.

#### Syntax

```
public interface IADPDMVersionFileItems
```

The IADPDMVersionFileItems type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of versions in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Safe | Returns the Safe. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given a numerical index into the collection, returns the corresponding file version item. |



# IADPDMSafe.ServerConnection Property

Returns the server connection object.

#### Syntax

```
IADPDMServerConnection ServerConnection { get; }
```

#### Property Value

IADPDMServerConnection



# IADPDMProperties.Count Property

Returns the number of properties in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADPDMFileItem.RemoveProperty Method

Removes the given property from this file item.

#### Syntax

```
void RemoveProperty(
	IADPDMProperty property
)
```

#### Parameters

property  IADPDMProperty
:   The property item to be removed from this file item.



# IADPDMFileItem.Move Method

Moves this files item to a given location.

#### Syntax

```
IADPDMFileItem Move(
	IADPDMFolder pDestination
)
```

#### Parameters

pDestination  IADPDMFolder
:   The destination folder for this operation.

#### Return Value

IADPDMFileItem



# IADPDMVersionFileItem.RemoveRevision Method

Removes the Revision.

#### Syntax

```
void RemoveRevision(
	bool includeConstituents
)
```

#### Parameters

includeConstituents  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Optionally remove the Revision from its constituents items.



# IADPDMTemplateLevels.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADPDMProperty.DateTimeValue Property

Returns a value if the actual value is of date time type.

#### Syntax

```
DateTime DateTimeValue { get; }
```

#### Property Value

[DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)



# IADPDMTemplateLevel.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADPDMVersionFileItem.IsConsumed Property

Returns whether this version has been consumed or not.

#### Syntax

```
bool IsConsumed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMProperties.GetPropertyByName Method

Returns an Property item for a given name.

#### Syntax

```
IADPDMProperty GetPropertyByName(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADPDMProperty



# IADPDMClassDataItem.Properties Property

Returns the properties of this data item.

#### Syntax

```
IADPDMProperties Properties { get; }
```

#### Property Value

IADPDMProperties



# IADRepositories.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADPDMVersionFileItem.AddRevision Method

Make this version as a Revision item.

#### Syntax

```
void AddRevision(
	string revision,
	bool includeConstituents
)
```

#### Parameters

revision  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The Revision text.

includeConstituents  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Optionally make its constituents versions as Revision items.



# IADFolderItems Properties

The IADFolderItems type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of repository folder-items in this collection |
|  | Enum | Returns an enumerator for the collection |



# IADPDMSafeRecycleBin.Reference Property

Returns a unique Reference for the RecycleBin item.

#### Syntax

```
string Reference { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADFolderItem.Label Method

Creates a new labeled version of this folder-item

#### Syntax

```
void Label(
	string label
)
```

#### Parameters

label  [String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMSafes.Count Property

Returns the number of Safes in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADPDMClass.IsConsumed Property

Returns whether the Class item is consumed by any item.

#### Syntax

```
bool IsConsumed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADFolderItems.Item Method

Given a repository folder-item's name or index, returns its interface

#### Syntax

```
IADFolderItem Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)

#### Return Value

IADFolderItem



# IADFolders.Item Method

Given a repository folder's name or index, returns its interface

#### Syntax

```
IADFolder Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)

#### Return Value

IADFolder



# IADFolderItems.Enum Property

Returns an enumerator for the collection

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADPDMTaskCallback Interface

IADPDMTaskCallback provides callback for a Task.

#### Syntax

```
public interface IADPDMTaskCallback
```

The IADPDMTaskCallback type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | OnTaskCompleted | Notifies Task completion. |



# IADPDMFolder.FileItems Property

Returns the file items in this folder.

#### Syntax

```
IADPDMFileItems FileItems { get; }
```

#### Property Value

IADPDMFileItems



# IADPDMFileItem.CopyWithConstituents Method

Copies this file item and its constituents (for native files) to a given location.

#### Syntax

```
IADPDMFileItem CopyWithConstituents(
	IADPDMFolder pDestination
)
```

#### Parameters

pDestination  IADPDMFolder
:   The destination folder for this operation.

#### Return Value

IADPDMFileItem



# IADPDMTemplateLevels Methods

The IADPDMTemplateLevels type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | GetLevelByName | Returns the level for a given name. |
|  | Item | Given a numerical index into the collection, returns the corresponding Template Level. |



# IADPDMFolder.CreateFolder Method

Creates a new sub folder.

#### Syntax

```
IADPDMFolder CreateFolder(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new sub folder to be created.

#### Return Value

IADPDMFolder



# IADPDMFolder Properties

The IADPDMFolder type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FileItems | Returns the file items in this folder. |
|  | Folders | Returns the next level folders under this folder. |
|  | IsDeleted | Returns whether this folder has been deleted and is inside Recycle Bin or not. |
|  | IsTemplateFolder | Returns whether this folder is based on a Template Level item or not. |
|  | Name | Returns the name of the folder. |
|  | Parent | Returns the parent folder of this folder. |
|  | Properties | Returns the properties of this folder. |
|  | Reference | Returns a unique reference to identify the folder. |
|  | Safe | Returns the Safe. |
|  | SubFolderTemplateLevel | Returns the Template Level item of the next level folders (sub folders), if any. |
|  | TemplateLevel | Returns the Template Level item of this folder, if any. |



# IADFolderItem.Copy Method

Copies this folder-item to the input destination parent folder and returns the copy

#### Syntax

```
IADFolderItem Copy(
	IADFolder pDestination,
	[OptionalAttribute] string newName
)
```

#### Parameters

pDestination  IADFolder

newName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)

#### Return Value

IADFolderItem



# IObjectCollector.Count Property

Returns the number of objects in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADPDMVersionFileItem.OpenNonNativeFileItemReadOnly Method

Opens this non native item as read only.

#### Syntax

```
IADSession OpenNonNativeFileItemReadOnly(
	bool applyImportOptions,
	bool openEditor
)
```

#### Parameters

applyImportOptions  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

openEditor  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Return Value

IADSession



# IADPDMFolders Properties

The IADPDMFolders type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of folders in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Safe | Returns the Safe. |



# IADPDMPropertyDefinition.AllowValuesOnTheFly Property

Returns whether the values can be added on the fly for a Class type definition.

#### Syntax

```
bool AllowValuesOnTheFly { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMPropertyDefinition.Name Property

Returns the name of the Property Definition.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMServerConnection Interface

This interface provides access to various Safes in a PDM Server.

#### Syntax

```
public interface IADPDMServerConnection
```

The IADPDMServerConnection type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Domain | Returns the domain name. |
|  | IsOnline | Returns whether the server is online or not. |
|  | Root | Returns the API root. |
|  | Safes | Returns the list of available 'Active' Safes. |
|  | URL | Returns the Server URL. |
|  | UserName | Returns the user name. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Logout | Disconnect or release this connection. |



# IADPDMFolder Methods

The IADPDMFolder type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CancelCheckIn | Cancels the check-in operation, if possible. |
|  | CreateFolder | Creates a new sub folder. |
|  | CreateTemplateFolder | Creates a new sub folder based on the Class defined in the level. |
|  | Delete | Deletes this folder. |
|  | Purge | Deletes this folder permanently from the Server as well. This cannot be undone. |
|  | RemoveProperty | Removes the given property from this folder. |
|  | Rename | Renames this folder. |
|  | Restore | Restores this folder from Recycle Bin to its original location. |
|  | SetProperty | Sets the given property to this folder. |
|  | UploadDocuments | Uploads non native file items to this folder. |



# IADPDMClass Interface

IADPDMClass provides access to an Class item.

#### Syntax

```
public interface IADPDMClass
```

The IADPDMClass type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DataItems | Returns the data items of the Class item. |
|  | DefaultProperties | Returns the default properties of the Class item. |
|  | IsConsumed | Returns whether the Class item is consumed by any item. |
|  | IsCoreClass | Returns whether the Class is a Core or a custom Class item. |
|  | Name | Returns the name of the Class item. |
|  | Safe | Returns the Safe. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddDataItem(IADPDMProperty) | Adds a new data item if the display name property is a Single Select property. |
|  | AddDataItem(String) | Adds a new data item if there is no display name property or if the display name is a Text property. |
|  | AddDefaultProperty | Adds a default property to the Class item. |
|  | Delete | Deletes the Class item. |
|  | RemoveDataItem | Removes the data item. |
|  | RemoveDefaultProperty | Removes a default property from the Class item. |
|  | Rename | Renames the Class item. |
|  | SetSVGIcon | Sets the given SVG icon to the Class item. |
|  | UnSetSVGIcon | Unsets any SVG icon from the Class item. |



# IADPDMTemplateLevels.Item Method

Given a numerical index into the collection, returns the corresponding Template Level.

#### Syntax

```
IADPDMTemplateLevel Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The numerical index of the Template Level.

#### Return Value

IADPDMTemplateLevel  
IADPDMTemplateLevel



# IADPDMServerConnection.Safes Property

Returns the list of available 'Active' Safes.

#### Syntax

```
IADPDMSafes Safes { get; }
```

#### Property Value

IADPDMSafes



# IObjectCollector.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum

#### Example

This Visual Basic sample shows how to iterate through the objects in the collection.

```
Dim objSourceObjects As AlibreX.IObjectCollector
Set objSourceObjects = objPlane.SourceObjects

Dim objEnum As AlibreX.DIEnum
Set objEnum = objSourceObjects.Enum

Dim objElement As Object
While objEnum.HasMoreElements
    Set objElement = objEnum.NextElement

    ' Do something with the objElement

Wend
```

Alternative way of traversing the same collection is shown below.

```
For Each objElement In objSourceObjects

    ' Do something with the objElement

Next
```



# IPermissionSelector.ViewOnly Property

Sets/resets flag indicating right to check-in and check-out. This property is obsolete.

#### Syntax

```
bool ViewOnly { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMSafe Methods

The IADPDMSafe type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreatePropertyInstance | Returns a property instance using the given Property Definition and a Value. |



# IADFolderItem.EnumConstituents Method

Returns a collection of folder-items that are the first-level constituents of this folder-item

#### Syntax

```
IADFolderItems EnumConstituents()
```

#### Return Value

IADFolderItems



# IADFolderItem.Delete Method

Deletes this folder-item from the repository

#### Syntax

```
void Delete()
```



# IADPDMClasses.GetClassByName Method

Returns a Class item for a given name.

#### Syntax

```
IADPDMClass GetClassByName(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADPDMClass



# IADPDMProperty.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADPDMVersionFileItem.UpdateVersionComment Method

Updates the version comment.

#### Syntax

```
void UpdateVersionComment(
	string versionComment
)
```

#### Parameters

versionComment  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The version comment.



# IADPDMTemplateLevels Properties

The IADPDMTemplateLevels type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of template levels in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Safe | Returns the Safe. |



# IADPDMPropertyDefinition.IsBuiltInPropertyDefinition Property

Returns whether the Property Definition is a built in or a custom PDM property.

#### Syntax

```
bool IsBuiltInPropertyDefinition { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMVersionFileItem.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADPDMFileItem.NewFile Property

Returns whether the file item is a New one or a checked in one.

#### Syntax

```
bool NewFile { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMPropertyDefinition.UpdateDefinition(IADPDMClass, Boolean, Boolean) Method

Updates the Property Definition.

#### Syntax

```
void UpdateDefinition(
	IADPDMClass classItem,
	bool multiSelect,
	bool allowValuesOnTheFly
)
```

#### Parameters

classItem  IADPDMClass
:   The Class item of this property definition item.

multiSelect  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Denotes whether this property definition allows multi select values.

allowValuesOnTheFly  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Denoted whether this property definition allows values to be created on the fly (in the GUI).



# IADFolder.ClearNotificationToAll Method

Makes this folder completely unnotified to all, other than the owner on a secure object type basis

#### Syntax

```
void ClearNotificationToAll(
	ADSecureObjectType secureObjectType,
	bool applyToAllSubFolders,
	bool applyToAllItems
)
```

#### Parameters

secureObjectType  ADSecureObjectType

applyToAllSubFolders  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

applyToAllItems  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADFolderItem.Open Method

Loads this folder-item and its constituents, if any, and returns the created session

#### Syntax

```
IADSession Open()
```

#### Return Value

IADSession



# IADPDMTemplates Methods

The IADPDMTemplates type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateTemplateByName | Creates a new template item. |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | GetTemplateByName | Returns the template for a given name. |
|  | Item | Given a numerical index into the collection, returns the corresponding Template. |



# IADPDMClasses.Count Property

Returns the number of classes in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

The count property for the Classes object held by automation clients will
not get updated automatically when a Class is added or deleted. Get the current
Classes collection by querying the Safe.



# IADPDMSafeLibrary Methods

The IADPDMSafeLibrary type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CancelCheckIn | Cancels the check-in operation, if possible.  (Inherited from IADPDMFolder) |
|  | CreateFolder | Creates a new sub folder.  (Inherited from IADPDMFolder) |
|  | CreateTemplateFolder | Creates a new sub folder based on the Class defined in the level.  (Inherited from IADPDMFolder) |
|  | Delete | Deletes this folder.  (Inherited from IADPDMFolder) |
|  | Purge | Deletes this folder permanently from the Server as well. This cannot be undone.  (Inherited from IADPDMFolder) |
|  | RemoveProperty | Removes the given property from this folder.  (Inherited from IADPDMFolder) |
|  | Rename | Renames this folder.  (Inherited from IADPDMFolder) |
|  | Restore | Restores this folder from Recycle Bin to its original location.  (Inherited from IADPDMFolder) |
|  | SetProperty | Sets the given property to this folder.  (Inherited from IADPDMFolder) |
|  | UploadDocuments | Uploads non native file items to this folder.  (Inherited from IADPDMFolder) |



# IADFolderItem.setNotification Method

Sets the notification of this folder-item for the specified collection of users, teams and roles

#### Syntax

```
void setNotification(
	IObjectCollector pUsers,
	IObjectCollector pTeams,
	IObjectCollector pRoles,
	INotificationSelector pNotification
)
```

#### Parameters

pUsers  IObjectCollector

pTeams  IObjectCollector

pRoles  IObjectCollector

pNotification  INotificationSelector



# IADPDMPropertyDefinitions.CreateDefinitionByClass Method

Creates a new Property Definition for a given Class item.

#### Syntax

```
IADPDMPropertyDefinition CreateDefinitionByClass(
	string name,
	IADPDMClass classItem,
	bool multiSelect,
	bool allowValuesOnTheFly
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the property definition.

classItem  IADPDMClass
:   The class item to be used for the value type.

multiSelect  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Denotes whether the property definition allows multi select values.

allowValuesOnTheFly  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Denoted whether the property definition allows values to be created on the fly (in GUI).

#### Return Value

IADPDMPropertyDefinition



# IADPDMProperty Properties

The IADPDMProperty type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DateTimeValue | Returns a value if the actual value is of date time type. |
|  | DisplayName | Returns the display name of the Property. |
|  | DoubleValue | Returns a value if the actual value is of real type. |
|  | HasValue | Returns whether the value is a non NULL value or not. |
|  | IntValue | Returns a value if the actual value is of integer type. |
|  | MultilineTextValue | Returns a value if the actual value is of multiline text type. |
|  | MultiSelectValue | Returns a value if the actual value is of multi select type. |
|  | PropertyDefinition | Returns the Property Definition associated with this property. |
|  | Safe | Returns the Safe. |
|  | SelectValue | Returns a value if the actual value is of single select type. |
|  | TextValue | Returns a value if the actual value is of text type. |
|  | Type | Returns the value type this object. |
|  | Value | Returns the value as a string. |



# IADPDMVersionFileItem.CheckedInAt Property

Returns when this version was checked in.

#### Syntax

```
DateTime CheckedInAt { get; }
```

#### Property Value

[DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)



# IADPDMServerConnection.Domain Property

Returns the domain name.

#### Syntax

```
string Domain { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADFolder.Name Property

Returns this repository folder's name.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMClasses.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADPDMFolder.Rename Method

Renames this folder.

#### Syntax

```
void Rename(
	string newName
)
```

#### Parameters

newName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The new name to be used for the rename.



# IADPDMFileItem.Reference Property

The unique string to identify the file item.

#### Syntax

```
string Reference { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMSafeLibraries Interface

IADPDMSafeLibraries represents the libraries item in the PDM Safe.

#### Syntax

```
public interface IADPDMSafeLibraries
```

The IADPDMSafeLibraries type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of libraries in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Name | Returns the name of the Libraries item. |
|  | Reference | Returns a unique Reference for the Libraries item. |
|  | Safe | Returns the Safe. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateLibrary | Create a new library. |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | GetLibraryByName | Returns the library item for a given name. |
|  | Item | Given a numerical index into the collection, returns the corresponding Library. |



# IADPDMProperty.Type Property

Returns the value type this object.

#### Syntax

```
ADPDMPropertyValueType Type { get; }
```

#### Property Value

ADPDMPropertyValueType



# IADPDMTemplate.Name Property

Returns the name of the Template item.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMFolder.SubFolderTemplateLevel Property

Returns the Template Level item of the next level folders (sub folders), if any.

#### Syntax

```
IADPDMTemplateLevel SubFolderTemplateLevel { get; }
```

#### Property Value

IADPDMTemplateLevel



# IADPDMVersionFileItem.UpdateRevision Method

Updates the Revision text.

#### Syntax

```
void UpdateRevision(
	string revision
)
```

#### Parameters

revision  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The Revision text.



# IADPDMSafeLibraries.GetLibraryByName Method

Returns the library item for a given name.

#### Syntax

```
IADPDMSafeLibrary GetLibraryByName(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADPDMSafeLibrary



# IADPDMClass.Name Property

Returns the name of the Class item.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMSafeRecycleBin.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADPDMClass Properties

The IADPDMClass type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DataItems | Returns the data items of the Class item. |
|  | DefaultProperties | Returns the default properties of the Class item. |
|  | IsConsumed | Returns whether the Class item is consumed by any item. |
|  | IsCoreClass | Returns whether the Class is a Core or a custom Class item. |
|  | Name | Returns the name of the Class item. |
|  | Safe | Returns the Safe. |



# IADPDMFolders.Count Property

Returns the number of folders in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADPDMClassDataItem Methods

The IADPDMClassDataItem type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | RemoveProperty | Removes the given property from this data item. |
|  | SetProperty | Sets the given property to this data item. |



# IADPDMFileItem.Rename Method

Rename this file item.

#### Syntax

```
void Rename(
	string newName
)
```

#### Parameters

newName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The new name to be used for the rename.



# IADPDMSafeProjects.Item Method

Given a numerical index into the collection, returns the corresponding Project.

#### Syntax

```
IADPDMSafeProject Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The numerical index of the Project.

#### Return Value

IADPDMSafeProject  
Returns IADPDMSafeProject



# IADFolder.IsAccessibleToUser Method

Checks if this folder is accessible to the specified user and if so, returns the present access rights and notification settings for this user

#### Syntax

```
bool IsAccessibleToUser(
	IADUser pUser,
	out IPermissionSelector ppPermissions,
	out INotificationSelector ppNotifications
)
```

#### Parameters

pUser  IADUser

ppPermissions  IPermissionSelector

ppNotifications  INotificationSelector

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMClassDataItems.GetClassDataItemByName Method

Returns a class data item for a given name.

#### Syntax

```
IADPDMClassDataItem GetClassDataItemByName(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADPDMClassDataItem



# IADPDMVersionFileItem.VersionComment Property

Returns the version comment.

#### Syntax

```
string VersionComment { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADFolder.IsAccessibleToRole Method

Checks if this folder is accessible to the specified Role and if so, returns the present access rights and notification settings for this Role

#### Syntax

```
bool IsAccessibleToRole(
	IADTeamRole pRole,
	out IPermissionSelector ppPermissions,
	out INotificationSelector ppNotifications
)
```

#### Parameters

pRole  IADTeamRole

ppPermissions  IPermissionSelector

ppNotifications  INotificationSelector

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMServerConnection.Logout Method

Disconnect or release this connection.

#### Syntax

```
void Logout()
```



# IADPDMSafeRecycleBin Properties

The IADPDMSafeRecycleBin type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of file items in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Name | Returns the name of the RecycleBin item. |
|  | Reference | Returns a unique Reference for the RecycleBin item. |
|  | Safe | Returns the Safe. |



# IADPDMPropertyDefinitions Interface

IADPDMPropertyDefinitions provides access to the Property Definition items.

#### Syntax

```
public interface IADPDMPropertyDefinitions
```

The IADPDMPropertyDefinitions type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of property definitions in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Safe | Returns the Safe. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateDefinitionByClass | Creates a new Property Definition for a given Class item. |
|  | CreateDefinitionByUserInput | Creates a new Property Definition for a given user input type. |
|  | GetDefinitionByName | Returns the Property Definition for a given name. |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given a numerical index into the collection, returns the corresponding Property Definition. |



# IADPDMSafes Methods

The IADPDMSafes type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | GetSafeByName | Returns a Safe for a given Safe name. |
|  | Item | Given a name or index, into the collection, returns the corresponding Safe. |



# IADPDMClasses Methods

The IADPDMClasses type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateClass | Creates a new Class item. |
|  | GetClassByName | Returns a Class item for a given name. |
|  | GetEnumerator | Returns an enumerator for the collection |
|  | Item | Given a numerical index into the collection, returns the corresponding Class item. |



# IADRepositories Interface

IADRepositories Interface. This interface is obsolete as of V11 of Alibre Design.

#### Syntax

```
public interface IADRepositories
```

The IADRepositories type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of repositories in this collection. |
|  | Enum | Returns an enumerator for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a repository name or index, returns the repository's interface. |



# IADPDMServerConnection Methods

The IADPDMServerConnection type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Logout | Disconnect or release this connection. |



# IADPDMFileItem.Extension Property

Returns the extension of this file item.

#### Syntax

```
string Extension { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMFileItem.Purge Method

Deletes this file item permanently from the Server as well. This cannot be undone.

#### Syntax

```
void Purge()
```



# IADFolder.FolderItems Property

Returns a collection containing this folder's folder items.

#### Syntax

```
IADFolderItems FolderItems { get; }
```

#### Property Value

IADFolderItems



# IADRepository.IsPublishedToTeam Method

Determines if the repository is accessible to the specified Team

#### Syntax

```
bool IsPublishedToTeam(
	IADTeam pTeam
)
```

#### Parameters

pTeam  IADTeam

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMFolders.Item Method

Given a name or index, into the collection, returns the corresponding folder item.

#### Syntax

```
IADPDMFolder Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or index of the folder item.

#### Return Value

IADPDMFolder  
IADPDMFolder



# IADPDMVersionFileItem.Revision Property

Returns the Revision text.

#### Syntax

```
string Revision { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMFileItem Methods

The IADPDMFileItem type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CancelCheckIn | Cancels the check-in operation, if possible. |
|  | CheckIn | Push this file item into the PDM Server asynchronously. |
|  | Copy | Copies this file item to a given location. |
|  | CopyWithConstituents | Copies this file item and its constituents (for native files) to a given location. |
|  | Delete | Deletes this file item. |
|  | Lock | Locks this file item. |
|  | Move | Moves this files item to a given location. |
|  | MoveWithConstituents | Moves this file item and its constituents (for native files) to a given location. |
|  | Open | Opens the native file item. |
|  | OpenNonNativeFileItem | Opens an non native file item like STEP, SAT, etc. |
|  | Purge | Deletes this file item permanently from the Server as well. This cannot be undone. |
|  | PurgeWithConstituents | Deletes this file item and its constituents (for native files) permanently. This cannot be undone. |
|  | RemoveProperty | Removes the given property from this file item. |
|  | Rename | Rename this file item. |
|  | Restore | Restores this file item from Recycle Bin to its original location. |
|  | Revert | Reverts the local changes of this file item. |
|  | SetProperty | Sets the given property to this file item. |
|  | Shelve | Shelve this file item. |
|  | UnLock | Unlocks this file item. |
|  | UnShelve | UnShelve the given file item. |



# IADPDMFileItems.GetEnumerator Method

Returns an enumerator for the collection.

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADPDMClass Methods

The IADPDMClass type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddDataItem(IADPDMProperty) | Adds a new data item if the display name property is a Single Select property. |
|  | AddDataItem(String) | Adds a new data item if there is no display name property or if the display name is a Text property. |
|  | AddDefaultProperty | Adds a default property to the Class item. |
|  | Delete | Deletes the Class item. |
|  | RemoveDataItem | Removes the data item. |
|  | RemoveDefaultProperty | Removes a default property from the Class item. |
|  | Rename | Renames the Class item. |
|  | SetSVGIcon | Sets the given SVG icon to the Class item. |
|  | UnSetSVGIcon | Unsets any SVG icon from the Class item. |



# IADFolderItem.IsAccessibleToRole Method

Checks if this folder-item is accessible to the specified Role and if so, returns the present access rights and notification settings for this Role

#### Syntax

```
bool IsAccessibleToRole(
	IADTeamRole pRole,
	out IPermissionSelector ppPermissions,
	out INotificationSelector ppNotifications
)
```

#### Parameters

pRole  IADTeamRole

ppPermissions  IPermissionSelector

ppNotifications  INotificationSelector

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADFolderItem.setPermission Method

Sets the access permissions of this folder-item for the specified collection of users, teams and roles

#### Syntax

```
void setPermission(
	IObjectCollector pUsers,
	IObjectCollector pTeams,
	IObjectCollector pRoles,
	IPermissionSelector pPermission,
	bool publishingRepository
)
```

#### Parameters

pUsers  IObjectCollector

pTeams  IObjectCollector

pRoles  IObjectCollector

pPermission  IPermissionSelector

publishingRepository  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMClassDataItems Interface

IADPDMClassDataItems provides access to the Class Data items.

#### Syntax

```
public interface IADPDMClassDataItems
```

The IADPDMClassDataItems type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of class data items in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Safe | Returns the Safe. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetClassDataItemByName | Returns a class data item for a given name. |
|  | GetEnumerator | Returns an enumerator for the collection |
|  | Item | Given a numerical index into the collection, returns the corresponding Class Data Item. |



# IADFolder.Type Property

Returns a pre-defined constant that identifies the type of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADPDMClassDataItems.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADPDMClass.Delete Method

Deletes the Class item.

#### Syntax

```
void Delete()
```



# IPermissionSelector.Delete Property

Sets/resets flag indicating right to delete.

#### Syntax

```
bool Delete { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMSafeRecycleBin.Count Property

Returns the number of file items in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADPDMFileItem.ModifiedVersion Property

Returns the modified version of this file item.

#### Syntax

```
int ModifiedVersion { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADPDMSafe.Templates Property

Returns the Template items in the Safe.

#### Syntax

```
IADPDMTemplates Templates { get; }
```

#### Property Value

IADPDMTemplates



# IADPDMFolder.Delete Method

Deletes this folder.

#### Syntax

```
void Delete()
```



# IADFolder.ClearNotification Method

Makes this folder completely unnotified to the specified collection of users, teams and roles on a secure object type basis

#### Syntax

```
void ClearNotification(
	ADSecureObjectType secureObjectType,
	IObjectCollector pUsers,
	IObjectCollector pTeams,
	IObjectCollector pRoles,
	bool applyToAllSubFolders,
	bool applyToAllItems
)
```

#### Parameters

secureObjectType  ADSecureObjectType

pUsers  IObjectCollector

pTeams  IObjectCollector

pRoles  IObjectCollector

applyToAllSubFolders  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

applyToAllItems  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMSafeProjects Methods

The IADPDMSafeProjects type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateProject | Create a new project using the given template. |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | GetProjectByName | Returns a project item by name. |
|  | Item | Given a numerical index into the collection, returns the corresponding Project. |



# IADPDMPropertyDefinitions Properties

The IADPDMPropertyDefinitions type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of property definitions in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Safe | Returns the Safe. |



# IADPDMFileItem.Properties Property

Returns the properties of this file item.

#### Syntax

```
IADPDMProperties Properties { get; }
```

#### Property Value

IADPDMProperties



# IADPDMPropertyDefinition Properties

The IADPDMPropertyDefinition type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | AllowValuesOnTheFly | Returns whether the values can be added on the fly for a Class type definition. |
|  | ClassItem | Returns the Class Item of the Property Definition if the definition type is a Class. |
|  | DisplayName | Returns the display name of the Property Definition. |
|  | IsBuiltInPropertyDefinition | Returns whether the Property Definition is a built in or a custom PDM property. |
|  | IsConsumed | Returns whether the Property Definition is consumed by any item. |
|  | Name | Returns the name of the Property Definition. |
|  | PropertyValueType | Returns the Value Type of the Property Definition if the definition is a User Input type. |
|  | Safe | Returns the Safe. |



# IADPDMFileItems.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADPDMProperty.MultiSelectValue Property

Returns a value if the actual value is of multi select type.

#### Syntax

```
string[] MultiSelectValue { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMClass.AddDataItem(String) Method

Adds a new data item if there is no display name property or if the display name is a Text property.

#### Syntax

```
IADPDMClassDataItem AddDataItem(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new data item instance.

#### Return Value

IADPDMClassDataItem



# IADFolderItem.Type Property

Returns a pre-defined constant that identifies the type of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADPDMFileItems Properties

The IADPDMFileItems type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of file items in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Safe | Returns the Safe. |



# IADPDMTemplateLevels.GetEnumerator Method

Returns an enumerator for the collection.

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADPDMFileItem.Cached Property

Returns whether this file item is cached or not.

#### Syntax

```
bool Cached { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMSafeLibraries.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# ADPDMPropertyValueType Enumeration

This enumeration describes the different types of user input in the Property Definition.

#### Syntax

```
public enum ADPDMPropertyValueType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_PDM\_INTEGER | 1 | Integer data type |
| AD\_PDM\_REAL | 2 | Floating point data type |
| AD\_PDM\_TEXT | 3 | Single line text data type |
| AD\_PDM\_DATETIME | 4 | DateTime data type |
| AD\_PDM\_SINGLE\_SELECT | 5 | Single select value data type |
| AD\_PDM\_MULTI\_SELECT | 6 | Multi select value data type |
| AD\_PDM\_MULTILINE\_TEXT | 7 | Multi line text data type |



# IADPDMTemplates.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADRepository Properties

The IADRepository type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Name | Returns the repository's name |
|  | Root | Returns the automation root |
|  | RootFolder | Returns interface to the repository's top most folder |
|  | Type | Returns a pre-defined constant that identifies the type of this object |



# IADFolder Properties

The IADFolder type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FolderItems | Returns a collection containing this folder's folder items. |
|  | Name | Returns this repository folder's name. |
|  | ParentFolder | Returns interface to this folder's parent folder. |
|  | Reference | Returns a unique, persistent reference-string for this folder. |
|  | Repository | Returns interface to repository in which this folder exists. |
|  | Root | Returns the automation root. |
|  | SubFolders | Returns a collection containing this folder's sub-folders. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. |



# IADFolder.SubFolders Property

Returns a collection containing this folder's sub-folders.

#### Syntax

```
IADFolders SubFolders { get; }
```

#### Property Value

IADFolders



# IADPDMSafeRecycleBin.EmptyBin Method

Empties the RecycleBin folder.

#### Syntax

```
void EmptyBin()
```



# IADPDMClassDataItem.ClassItem Property

Returns the class item owning this data item.

#### Syntax

```
IADPDMClass ClassItem { get; }
```

#### Property Value

IADPDMClass



# IADPDMFolder.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IObjectCollector.Remove Method

Removes an object from the collection.

#### Syntax

```
void Remove(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Numerical index into the collection.



# IADPDMFolder.IsDeleted Property

Returns whether this folder has been deleted and is inside Recycle Bin or not.

#### Syntax

```
bool IsDeleted { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADFolderItem.UndoCheckOut Method

Resets this folder-item's status to checked-in

#### Syntax

```
void UndoCheckOut()
```



# IADPDMFileItem.LocallyModified Property

Returns whether this file item is modified locally or not.

#### Syntax

```
bool LocallyModified { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMVersionFileItems.Item Method

Given a numerical index into the collection, returns the corresponding file version item.

#### Syntax

```
IADPDMVersionFileItem Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The numerical index of the Class item.

#### Return Value

IADPDMVersionFileItem  
IADPDMClass



# IADPDMSafeRecycleBin.Item Method

Given a name or index, into the collection, returns the corresponding file item.

#### Syntax

```
Object Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or index of the file or folder item.

#### Return Value

[Object](https://learn.microsoft.com/dotnet/api/system.object)  
IADPDMFileItem or IADPDMFolder



# IADPDMProperty.PropertyDefinition Property

Returns the Property Definition associated with this property.

#### Syntax

```
IADPDMPropertyDefinition PropertyDefinition { get; }
```

#### Property Value

IADPDMPropertyDefinition



# IADFolderItem.Repository Property

Returns interface to repository in which this folder-item exists

#### Syntax

```
IADRepository Repository { get; }
```

#### Property Value

IADRepository



# IADPDMClass.AddDataItem(IADPDMProperty) Method

Adds a new data item if the display name property is a Single Select property.

#### Syntax

```
IADPDMClassDataItem AddDataItem(
	IADPDMProperty property
)
```

#### Parameters

property  IADPDMProperty
:   The property

#### Return Value

IADPDMClassDataItem



# IADPDMFolder.Name Property

Returns the name of the folder.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMPropertyDefinition.Rename Method

Renames the Property Definition.

#### Syntax

```
void Rename(
	string newName
)
```

#### Parameters

newName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The new name toi be used for the rename operation.



# IADPDMVersionFileItem.Name Property

Returns the name of this item.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADRepository.Name Property

Returns the repository's name

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMTemplateLevel.Name Property

Returns the name of the Template Level item.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADRepositories Properties

The IADRepositories type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of repositories in this collection. |
|  | Enum | Returns an enumerator for the collection. |



# IADPDMClassDataItem.SetProperty Method

Sets the given property to this data item.

#### Syntax

```
void SetProperty(
	IADPDMProperty property
)
```

#### Parameters

property  IADPDMProperty
:   The property item to be set in this data item.



# IADPDMFileItems Methods

The IADPDMFileItems type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | GetFileItemByName | Returns an file item for the given name. |
|  | Item | Given a name or index, into the collection, returns the corresponding file item. |



# IADPDMPropertyDefinition.ClassItem Property

Returns the Class Item of the Property Definition if the definition type is a Class.

#### Syntax

```
IADPDMClass ClassItem { get; }
```

#### Property Value

IADPDMClass



# IADFolder.Move Method

Moves this folder and contents to the input destination parent folder and returns the new folder.

#### Syntax

```
IADFolder Move(
	IADFolder pDestination,
	string newName
)
```

#### Parameters

pDestination  IADFolder

newName  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADFolder



# IADFolder Interface

IADFolder interface. This interface is obsolete as of V11 of Alibre Design.

#### Syntax

```
public interface IADFolder
```

The IADFolder type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FolderItems | Returns a collection containing this folder's folder items. |
|  | Name | Returns this repository folder's name. |
|  | ParentFolder | Returns interface to this folder's parent folder. |
|  | Reference | Returns a unique, persistent reference-string for this folder. |
|  | Repository | Returns interface to repository in which this folder exists. |
|  | Root | Returns the automation root. |
|  | SubFolders | Returns a collection containing this folder's sub-folders. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | ClearNotification | Makes this folder completely unnotified to the specified collection of users, teams and roles on a secure object type basis |
|  | ClearNotificationToAll | Makes this folder completely unnotified to all, other than the owner on a secure object type basis |
|  | ClearPermission | Makes this folder completely inaccessible to the specified collection of users, teams and roles on a secure object type basis |
|  | ClearPermissionToAll | Makes this folder completely inaccessible to all, other than the owner on a secure object type basis |
|  | Copy | Copies this folder and contents to the input destination parent folder and returns the copy. |
|  | CreateSubFolder | Creates a new sub-folder with the given name under this folder and returns its interface. |
|  | Delete | Deletes this folder and its contents from the repository. |
|  | Deposit | Deposits the given file as an unknown item in this folder. |
|  | IsAccessibleToRole | Checks if this folder is accessible to the specified Role and if so, returns the present access rights and notification settings for this Role |
|  | IsAccessibleToTeam | Determines if this folder's contents are accessible to the specified team and if so, returns the present access rights and notification settings for this team |
|  | IsAccessibleToUser | Checks if this folder is accessible to the specified user and if so, returns the present access rights and notification settings for this user |
|  | IsRecycleBin | Determines if this folder corresponds to the recycle bin. |
|  | Move | Moves this folder and contents to the input destination parent folder and returns the new folder. |
|  | Rename | Renames this folder to the input name. |
|  | setNotification | Sets the notification of this folder for the specified collection of users, teams and roles on a secure object type basis |
|  | setPermission | Sets the access permissions of this folder for the specified collection of users, teams and roles on a secure object type basis. |



# IADPDMSafe.PropertyDefinitions Property

Returns the Property Definition items in the Safe.

#### Syntax

```
IADPDMPropertyDefinitions PropertyDefinitions { get; }
```

#### Property Value

IADPDMPropertyDefinitions



# IADPDMClassDataItem.RemoveProperty Method

Removes the given property from this data item.

#### Syntax

```
void RemoveProperty(
	IADPDMProperty property
)
```

#### Parameters

property  IADPDMProperty
:   The property item to be removed from this data item.



# IADPDMSafes.GetEnumerator Method

Returns an enumerator for the collection.

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADPDMProperty.TextValue Property

Returns a value if the actual value is of text type.

#### Syntax

```
string TextValue { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADRepository.Root Property

Returns the automation root

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADPDMClassDataItem.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADRepository.IsPublishedToRole Method

Determines if the repository is accessible to the specified Role

#### Syntax

```
bool IsPublishedToRole(
	IADTeamRole pRole
)
```

#### Parameters

pRole  IADTeamRole

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMFileItem.IsConsumed Property

Returns whether this file item has been consumed by any other file item (for native files).

#### Syntax

```
bool IsConsumed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMProperty.MultilineTextValue Property

Returns a value if the actual value is of multiline text type.

#### Syntax

```
string MultilineTextValue { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADFolder.Copy Method

Copies this folder and contents to the input destination parent folder and returns the copy.

#### Syntax

```
IADFolder Copy(
	IADFolder pDestination,
	[OptionalAttribute] string newName
)
```

#### Parameters

pDestination  IADFolder

newName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)

#### Return Value

IADFolder



# IADFolderItem.Root Property

Returns the automation root

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADFolderItem.CheckOut Method

Marks this folder-item as checked-out by the current user if not already checked out by any other user

#### Syntax

```
void CheckOut()
```



# IADPDMFolder.CreateTemplateFolder Method

Creates a new sub folder based on the Class defined in the level.

#### Syntax

```
IADPDMFolder CreateTemplateFolder(
	IADPDMClassDataItem classDataItem
)
```

#### Parameters

classDataItem  IADPDMClassDataItem
:   The Class Data Item to be used for the folder name.

#### Return Value

IADPDMFolder



# IADPDMFileItem.PurgeWithConstituents Method

Deletes this file item and its constituents (for native files) permanently. This cannot be undone.

#### Syntax

```
void PurgeWithConstituents()
```



# IADFolderItems.Count Property

Returns the number of repository folder-items in this collection

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADPDMSafeProjects.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADPDMSafeLibrary.Parent Property

Returns the libraries item which contains this library item.

#### Syntax

```
IADPDMSafeLibraries Parent { get; }
```

#### Property Value

IADPDMSafeLibraries



# IADPDMSafeProjects.GetEnumerator Method

Returns an enumerator for the collection.

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADPDMProperties.Item Method

Given a name or index, into the collection, returns the corresponding property.

#### Syntax

```
IADPDMProperty Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or index of the property.

#### Return Value

IADPDMProperty  
IADPDMProperty



# IADPDMTemplates Properties

The IADPDMTemplates type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of templates in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Safe | Returns the Safe. |



# IADPDMTemplate Interface

IADPDMTemplate provides access to an template item.

#### Syntax

```
public interface IADPDMTemplate
```

The IADPDMTemplate type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | IsConsumed | Returns whether the Template is consumed by any project or not. |
|  | Levels | Returns the Template Levels. |
|  | Name | Returns the name of the Template item. |
|  | Safe | Returns the Safe. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddLevel | Adds a new level to the template. |
|  | Delete | Deletes this Temaplate item. |
|  | RemoveLevel | Removes the level from the template. |



# IADFolderItem.CurrentVersionID Property

Returns the current version number of this folder-item

#### Syntax

```
int CurrentVersionID { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADPDMVersionFileItem.ItemType Property

Returns the type of this item.

#### Syntax

```
ADObjectSubType ItemType { get; }
```

#### Property Value

ADObjectSubType



# IPermissionSelector.Administrate Property

Sets/resets flag indicating right to administrate.

#### Syntax

```
bool Administrate { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADFolders.Count Property

Returns the number of repository folders in this collection

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADPDMFileItem.Copy Method

Copies this file item to a given location.

#### Syntax

```
IADPDMFileItem Copy(
	IADPDMFolder pDestination
)
```

#### Parameters

pDestination  IADPDMFolder
:   The destination folder for this operation.

#### Return Value

IADPDMFileItem



# IADPDMSafeProject Methods

The IADPDMSafeProject type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CancelCheckIn | Cancels the check-in operation, if possible.  (Inherited from IADPDMFolder) |
|  | CreateFolder | Creates a new sub folder.  (Inherited from IADPDMFolder) |
|  | CreateTemplateFolder | Creates a new sub folder based on the Class defined in the level.  (Inherited from IADPDMFolder) |
|  | Delete | Deletes this folder.  (Inherited from IADPDMFolder) |
|  | Purge | Deletes this folder permanently from the Server as well. This cannot be undone.  (Inherited from IADPDMFolder) |
|  | RemoveProperty | Removes the given property from this folder.  (Inherited from IADPDMFolder) |
|  | Rename | Renames this folder.  (Inherited from IADPDMFolder) |
|  | Restore | Restores this folder from Recycle Bin to its original location.  (Inherited from IADPDMFolder) |
|  | SetProperty | Sets the given property to this folder.  (Inherited from IADPDMFolder) |
|  | UploadDocuments | Uploads non native file items to this folder.  (Inherited from IADPDMFolder) |



# IADPDMProperties.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADPDMSafe.Projects Property

Returns the Projects item in the Safe.

#### Syntax

```
IADPDMSafeProjects Projects { get; }
```

#### Property Value

IADPDMSafeProjects



# IADFolder.Repository Property

Returns interface to repository in which this folder exists.

#### Syntax

```
IADRepository Repository { get; }
```

#### Property Value

IADRepository



# IADPDMSafeRecycleBin Interface

IADPDMSafeRecycleBin provides access to the items under the Recycle Bin.

#### Syntax

```
public interface IADPDMSafeRecycleBin
```

The IADPDMSafeRecycleBin type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of file items in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Name | Returns the name of the RecycleBin item. |
|  | Reference | Returns a unique Reference for the RecycleBin item. |
|  | Safe | Returns the Safe. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | EmptyBin | Empties the RecycleBin folder. |
|  | GetEnumerator | Returns an enumerator for the collection |
|  | Item | Given a name or index, into the collection, returns the corresponding file item. |



# IADPDMProperty.HasValue Property

Returns whether the value is a non NULL value or not.

#### Syntax

```
bool HasValue { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMServerConnection.Root Property

Returns the API root.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADPDMSafeProjects Properties

The IADPDMSafeProjects type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of projects in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Name | Returns the Name of the Projects item. |
|  | Reference | Returns a unique Reference for the Projects item. |
|  | Safe | Returns the Safe. |



# IADPDMSafeLibraries Methods

The IADPDMSafeLibraries type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateLibrary | Create a new library. |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | GetLibraryByName | Returns the library item for a given name. |
|  | Item | Given a numerical index into the collection, returns the corresponding Library. |



# IADPDMSafeProject Interface

IADPDMSafeProject represents an project item in the PDM Safe.

#### Syntax

```
public interface IADPDMSafeProject : IADPDMFolder
```

The IADPDMSafeProject type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FileItems | Returns the file items in this folder.  (Inherited from IADPDMFolder) |
|  | Folders | Returns the next level folders under this folder.  (Inherited from IADPDMFolder) |
|  | IsDeleted | Returns whether this folder has been deleted and is inside Recycle Bin or not.  (Inherited from IADPDMFolder) |
|  | IsTemplateFolder | Returns whether this folder is based on a Template Level item or not.  (Inherited from IADPDMFolder) |
|  | Name | Returns the name of the folder.  (Inherited from IADPDMFolder) |
|  | Parent | Returns the projects item which contains this project item. |
|  | Properties | Returns the properties of this folder.  (Inherited from IADPDMFolder) |
|  | Reference | Returns a unique reference to identify the folder.  (Inherited from IADPDMFolder) |
|  | Safe | Returns the Safe.  (Inherited from IADPDMFolder) |
|  | SubFolderTemplateLevel | Returns the Template Level item of the next level folders (sub folders), if any.  (Inherited from IADPDMFolder) |
|  | TemplateLevel | Returns the Template Level item of this folder, if any.  (Inherited from IADPDMFolder) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CancelCheckIn | Cancels the check-in operation, if possible.  (Inherited from IADPDMFolder) |
|  | CreateFolder | Creates a new sub folder.  (Inherited from IADPDMFolder) |
|  | CreateTemplateFolder | Creates a new sub folder based on the Class defined in the level.  (Inherited from IADPDMFolder) |
|  | Delete | Deletes this folder.  (Inherited from IADPDMFolder) |
|  | Purge | Deletes this folder permanently from the Server as well. This cannot be undone.  (Inherited from IADPDMFolder) |
|  | RemoveProperty | Removes the given property from this folder.  (Inherited from IADPDMFolder) |
|  | Rename | Renames this folder.  (Inherited from IADPDMFolder) |
|  | Restore | Restores this folder from Recycle Bin to its original location.  (Inherited from IADPDMFolder) |
|  | SetProperty | Sets the given property to this folder.  (Inherited from IADPDMFolder) |
|  | UploadDocuments | Uploads non native file items to this folder.  (Inherited from IADPDMFolder) |



# IADPDMTemplate.Levels Property

Returns the Template Levels.

#### Syntax

```
IADPDMTemplateLevels Levels { get; }
```

#### Property Value

IADPDMTemplateLevels



# INotificationSelector Properties

The INotificationSelector type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Administrate | Sets/resets flag indicating whether to receive notification upon administrative changes. |
|  | CheckIn | Sets/resets flag indicating whether to receive notification upon check-in. |
|  | CheckOut | Sets/resets flag indicating whether to receive notification upon check-out. |
|  | Delete | Sets/resets flag indicating whether to receive notification upon delete. |
|  | Write | Sets/resets flag indicating whether to receive notification upon edit. |



# IADFolderItem Interface

IADFolderItem interface. This interface is obsolete as of V11 of Alibre Design.

#### Syntax

```
public interface IADFolderItem
```

The IADFolderItem type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CurrentVersionID | Returns the current version number of this folder-item |
|  | ItemType | Returns a pre-defined constant that identifies whether this folder-item represents a part or assembly or drawing etc. |
|  | Name | Returns this repository folder-item's name. |
|  | ParentFolder | Returns interface to this folder-item's parent folder |
|  | Reference | Returns a unique, persistent reference-string for this folder-item |
|  | Repository | Returns interface to repository in which this folder-item exists |
|  | Root | Returns the automation root |
|  | Type | Returns a pre-defined constant that identifies the type of this object. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddNote | Creates a new note for this folder-item |
|  | CheckIn | Marks this folder-item as not checked-out by the current user |
|  | CheckOut | Marks this folder-item as checked-out by the current user if not already checked out by any other user |
|  | ClearNotification | Makes this folder-item completely unnotified to the specified collection of users, teams and roles |
|  | ClearNotificationToAll | Makes this folder-item completely unnotified to all, other than the owner |
|  | ClearPermission | Makes this folder-item completely inaccessible to the specified collection of users, teams and roles |
|  | ClearPermissionToAll | Makes this folder-item completely inaccessible to all, other than the owner |
|  | Copy | Copies this folder-item to the input destination parent folder and returns the copy |
|  | Delete | Deletes this folder-item from the repository |
|  | EnumConstituents | Returns a collection of folder-items that are the first-level constituents of this folder-item |
|  | IsAccessibleToRole | Checks if this folder-item is accessible to the specified Role and if so, returns the present access rights and notification settings for this Role |
|  | IsAccessibleToTeam | Determines if this folder-items contents are accessible to the specified team and if so, returns the present access rights and notification settings for this team |
|  | IsAccessibleToUser | Checks if this folder-item is accessible to the specified user and if so, returns the present access rights and notification settings for this user |
|  | IsCheckedIn | Determines the check-out status of this folder-item |
|  | Label | Creates a new labeled version of this folder-item |
|  | Move | Moves this folder-item to the input destination parent folder and returns the new folder-item |
|  | Open | Loads this folder-item and its constituents, if any, and returns the created session |
|  | Rename | Renames this folder-item to the input name |
|  | setNotification | Sets the notification of this folder-item for the specified collection of users, teams and roles |
|  | setPermission | Sets the access permissions of this folder-item for the specified collection of users, teams and roles |
|  | Share | Shares this folder-item to the specified destination folder. This method is obsolete. |
|  | UndoCheckOut | Resets this folder-item's status to checked-in |
|  | Withdraw | If the item-type is UNKNOWNITEM, then, this method transfers it to the Windows file system at the specified location |



# IADPDMPropertyDefinition Methods

The IADPDMPropertyDefinition type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes the Property Definition. |
|  | Rename | Renames the Property Definition. |
|  | SetSVGIcon | Sets the given SVG icon to the Property Definition. |
|  | UnSetSVGIcon | Unsets any SVG icon from the Property Definition. |
|  | UpdateDefinition(ADPDMPropertyValueType) | Updates the Property Definition. |
|  | UpdateDefinition(IADPDMClass, Boolean, Boolean) | Updates the Property Definition. |



# IADFolder.Rename Method

Renames this folder to the input name.

#### Syntax

```
void Rename(
	string folderName
)
```

#### Parameters

folderName  [String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMFolder.Purge Method

Deletes this folder permanently from the Server as well. This cannot be undone.

#### Syntax

```
void Purge()
```



# IADPDMSafeProject.Parent Property

Returns the projects item which contains this project item.

#### Syntax

```
IADPDMSafeProjects Parent { get; }
```

#### Property Value

IADPDMSafeProjects



# IADFolderItem.ClearNotification Method

Makes this folder-item completely unnotified to the specified collection of users, teams and roles

#### Syntax

```
void ClearNotification(
	IObjectCollector pUsers,
	IObjectCollector pTeams,
	IObjectCollector pRoles
)
```

#### Parameters

pUsers  IObjectCollector

pTeams  IObjectCollector

pRoles  IObjectCollector



# IADPDMProperties.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADPDMFileItem.Lock Method

Locks this file item.

#### Syntax

```
void Lock(
	bool includeConstituents
)
```

#### Parameters

includeConstituents  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   A value of TRUE includes all the constituents of this file item for locking.



# IADFolders Interface

IADFolders Interface. This interface is obsolete as of V11 of Alibre Design.

#### Syntax

```
public interface IADFolders
```

The IADFolders type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of repository folders in this collection |
|  | Enum | Returns an enumerator for the collection |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a repository folder's name or index, returns its interface |



# IADPDMVersionFileItems.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADPDMSafes.GetSafeByName Method

Returns a Safe for a given Safe name.

#### Syntax

```
IADPDMSafe GetSafeByName(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADPDMSafe



# IADPDMFileItem.CurrentVersionID Property

Returns the latest version of this file item.

#### Syntax

```
int CurrentVersionID { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADPDMClassDataItem Interface

IADPDMClassDataItem provides access to an Class Data item.

#### Syntax

```
public interface IADPDMClassDataItem
```

The IADPDMClassDataItem type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ClassItem | Returns the class item owning this data item. |
|  | Name | Returns the name of the Class data item. |
|  | Properties | Returns the properties of this data item. |
|  | Safe | Returns the Safe. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | RemoveProperty | Removes the given property from this data item. |
|  | SetProperty | Sets the given property to this data item. |



# IADPDMVersionFileItems Methods

The IADPDMVersionFileItems type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given a numerical index into the collection, returns the corresponding file version item. |



# IPermissionSelector.Write Property

Sets/resets flag indicating right to edit.

#### Syntax

```
bool Write { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMClass.AddDataItem Method

#### Overload List

|  | Name | Description |
| --- | --- | --- |
|  | AddDataItem(IADPDMProperty) | Adds a new data item if the display name property is a Single Select property. |
|  | AddDataItem(String) | Adds a new data item if there is no display name property or if the display name is a Text property. |



# IADPDMVersionFileItem.PurgeVersion Method

Purge this version.

#### Syntax

```
void PurgeVersion()
```



# INotificationSelector.Administrate Property

Sets/resets flag indicating whether to receive notification upon administrative changes.

#### Syntax

```
bool Administrate { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMClassDataItems.GetEnumerator Method

Returns an enumerator for the collection

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADPDMFileItem.PreviewImage Property

Returns the preview image of this file item as byte array.

#### Syntax

```
byte[] PreviewImage { get; }
```

#### Property Value

[Byte](https://learn.microsoft.com/dotnet/api/system.byte)



# IADPDMSafe.Libraries Property

Returns the Libraries item in the Safe.

#### Syntax

```
IADPDMSafeLibraries Libraries { get; }
```

#### Property Value

IADPDMSafeLibraries



# IADPDMTemplateLevels.GetLevelByName Method

Returns the level for a given name.

#### Syntax

```
IADPDMTemplateLevel GetLevelByName(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADPDMTemplateLevel



# IADPDMFolders.GetEnumerator Method

Returns an enumerator for the collection

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADRepository.Type Property

Returns a pre-defined constant that identifies the type of this object

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# INotificationSelector Interface

INotificationSelector interface. This interface is obsolete as of V11 of Alibre Design.

#### Syntax

```
public interface INotificationSelector
```

The INotificationSelector type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Administrate | Sets/resets flag indicating whether to receive notification upon administrative changes. |
|  | CheckIn | Sets/resets flag indicating whether to receive notification upon check-in. |
|  | CheckOut | Sets/resets flag indicating whether to receive notification upon check-out. |
|  | Delete | Sets/resets flag indicating whether to receive notification upon delete. |
|  | Write | Sets/resets flag indicating whether to receive notification upon edit. |



# IADPDMFolders.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADPDMSafeProjects Interface

IADPDMSafeProjects represents the projects item in the PDM Safe.

#### Syntax

```
public interface IADPDMSafeProjects
```

The IADPDMSafeProjects type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of projects in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Name | Returns the Name of the Projects item. |
|  | Reference | Returns a unique Reference for the Projects item. |
|  | Safe | Returns the Safe. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateProject | Create a new project using the given template. |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | GetProjectByName | Returns a project item by name. |
|  | Item | Given a numerical index into the collection, returns the corresponding Project. |



# IADFolder.setPermission Method

Sets the access permissions of this folder for the specified collection of users, teams and roles on a secure object type basis.

#### Syntax

```
void setPermission(
	ADSecureObjectType secureObjectType,
	IObjectCollector pUsers,
	IObjectCollector pTeams,
	IObjectCollector pRoles,
	IPermissionSelector pPermissions,
	bool applyToAllSubFolders,
	bool applyToAllItems,
	bool publishingRepository
)
```

#### Parameters

secureObjectType  ADSecureObjectType

pUsers  IObjectCollector

pTeams  IObjectCollector

pRoles  IObjectCollector

pPermissions  IPermissionSelector

applyToAllSubFolders  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

applyToAllItems  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

publishingRepository  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMSafeProjects.Reference Property

Returns a unique Reference for the Projects item.

#### Syntax

```
string Reference { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADFolder.IsRecycleBin Method

Determines if this folder corresponds to the recycle bin.

#### Syntax

```
bool IsRecycleBin()
```

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADRepositories Methods

The IADRepositories type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a repository name or index, returns the repository's interface. |



# IADPDMProperty.DoubleValue Property

Returns a value if the actual value is of real type.

#### Syntax

```
double DoubleValue { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADPDMVersionFileItem.Version Property

Returns the version number of this item.

#### Syntax

```
int Version { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADRepository.Publish Method

Makes the entire repository accessible to specified users, teams and roles

#### Syntax

```
void Publish(
	IObjectCollector pUsers,
	IObjectCollector pTeams,
	IObjectCollector pRoles
)
```

#### Parameters

pUsers  IObjectCollector

pTeams  IObjectCollector

pRoles  IObjectCollector



# INotificationSelector.CheckOut Property

Sets/resets flag indicating whether to receive notification upon check-out.

#### Syntax

```
bool CheckOut { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADFolders Methods

The IADFolders type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a repository folder's name or index, returns its interface |



# IADPDMFileItem.Open Method

Opens the native file item.

#### Syntax

```
IADSession Open(
	bool openEditor
)
```

#### Parameters

openEditor  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Specifies whether to open the UI browser or not.

#### Return Value

IADSession



# IADFolderItem.ClearNotificationToAll Method

Makes this folder-item completely unnotified to all, other than the owner

#### Syntax

```
void ClearNotificationToAll()
```



# IADFolderItem.ClearPermissionToAll Method

Makes this folder-item completely inaccessible to all, other than the owner

#### Syntax

```
void ClearPermissionToAll(
	bool unPublishingRepository
)
```

#### Parameters

unPublishingRepository  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPDMSafe.CreatePropertyInstance Method

Returns a property instance using the given Property Definition and a Value.

#### Syntax

```
IADPDMProperty CreatePropertyInstance(
	IADPDMPropertyDefinition definition,
	Object propValue
)
```

#### Parameters

definition  IADPDMPropertyDefinition
:   The property definition of the instance.

propValue  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The value for the property instance.

#### Return Value

IADPDMProperty  

#### Remarks

The propValue expects the values to be in the following formats.

1. An Integer if PropertyValueType is AD\_PDM\_INTEGER

2. Double if PropertyValueType is AD\_PDM\_REAL

3. DateTime if PropertyValueType is AD\_PDM\_DATETIME

4. String if PropertyValueType is AD\_PDM\_TEXT or AD\_PDM\_MULTILINE\_TEXT

5. IADPDMClassDataItem if PropertyValueType is AD\_PDM\_SINGLE\_SELECT

6. IADPDMClassDataItem[] if PropertyValueType is AD\_PDM\_MULTI\_SELECT



# IADPDMTemplate.RemoveLevel Method

Removes the level from the template.

#### Syntax

```
void RemoveLevel(
	IADPDMTemplateLevel level
)
```

#### Parameters

level  IADPDMTemplateLevel



# IADPDMClasses Interface

IADPDMClasses provides access to the Class items.

#### Syntax

```
public interface IADPDMClasses
```

The IADPDMClasses type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of classes in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Safe | Returns the Safe. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateClass | Creates a new Class item. |
|  | GetClassByName | Returns a Class item for a given name. |
|  | GetEnumerator | Returns an enumerator for the collection |
|  | Item | Given a numerical index into the collection, returns the corresponding Class item. |



# IADPDMTemplates.GetTemplateByName Method

Returns the template for a given name.

#### Syntax

```
IADPDMTemplate GetTemplateByName(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADPDMTemplate  
IADPDMTemplate



# IADFolderItem.Name Property

Returns this repository folder-item's name.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADRepositories.Item Method

Given a repository name or index, returns the repository's interface.

#### Syntax

```
IADRepository Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)

#### Return Value

IADRepository



# IADPDMFileItem.Safe Property

Returns the Safe.

#### Syntax

```
IADPDMSafe Safe { get; }
```

#### Property Value

IADPDMSafe



# IADFolderItem Methods

The IADFolderItem type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddNote | Creates a new note for this folder-item |
|  | CheckIn | Marks this folder-item as not checked-out by the current user |
|  | CheckOut | Marks this folder-item as checked-out by the current user if not already checked out by any other user |
|  | ClearNotification | Makes this folder-item completely unnotified to the specified collection of users, teams and roles |
|  | ClearNotificationToAll | Makes this folder-item completely unnotified to all, other than the owner |
|  | ClearPermission | Makes this folder-item completely inaccessible to the specified collection of users, teams and roles |
|  | ClearPermissionToAll | Makes this folder-item completely inaccessible to all, other than the owner |
|  | Copy | Copies this folder-item to the input destination parent folder and returns the copy |
|  | Delete | Deletes this folder-item from the repository |
|  | EnumConstituents | Returns a collection of folder-items that are the first-level constituents of this folder-item |
|  | IsAccessibleToRole | Checks if this folder-item is accessible to the specified Role and if so, returns the present access rights and notification settings for this Role |
|  | IsAccessibleToTeam | Determines if this folder-items contents are accessible to the specified team and if so, returns the present access rights and notification settings for this team |
|  | IsAccessibleToUser | Checks if this folder-item is accessible to the specified user and if so, returns the present access rights and notification settings for this user |
|  | IsCheckedIn | Determines the check-out status of this folder-item |
|  | Label | Creates a new labeled version of this folder-item |
|  | Move | Moves this folder-item to the input destination parent folder and returns the new folder-item |
|  | Open | Loads this folder-item and its constituents, if any, and returns the created session |
|  | Rename | Renames this folder-item to the input name |
|  | setNotification | Sets the notification of this folder-item for the specified collection of users, teams and roles |
|  | setPermission | Sets the access permissions of this folder-item for the specified collection of users, teams and roles |
|  | Share | Shares this folder-item to the specified destination folder. This method is obsolete. |
|  | UndoCheckOut | Resets this folder-item's status to checked-in |
|  | Withdraw | If the item-type is UNKNOWNITEM, then, this method transfers it to the Windows file system at the specified location |



# IADPDMFolder.UploadDocuments Method

Uploads non native file items to this folder.

#### Syntax

```
void UploadDocuments(
	string[] filePaths,
	bool checkIn,
	IADPDMTaskCallback callback
)
```

#### Parameters

filePaths  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The Windows file paths of the files to be uploaded.

checkIn  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Optionally check in these files into the PDM Server.

callback  IADPDMTaskCallback
:   Provides a callback when the check in operation completes.



# IADPDMFileItem.FileSize Property

Returns the file size as number of bytes.

#### Syntax

```
long FileSize { get; }
```

#### Property Value

[Int64](https://learn.microsoft.com/dotnet/api/system.int64)



# IADPDMTemplates.GetEnumerator Method

Returns an enumerator for the collection.

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADPDMFileItem.Revert Method

Reverts the local changes of this file item.

#### Syntax

```
void Revert(
	bool includeConstituents
)
```

#### Parameters

includeConstituents  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   A value of TRUE includes all the constituents of this file item for reverting.



# IADPDMProperty.SelectValue Property

Returns a value if the actual value is of single select type.

#### Syntax

```
string SelectValue { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADRepository.RootFolder Property

Returns interface to the repository's top most folder

#### Syntax

```
IADFolder RootFolder { get; }
```

#### Property Value

IADFolder



# IADPDMFolder.IsTemplateFolder Property

Returns whether this folder is based on a Template Level item or not.

#### Syntax

```
bool IsTemplateFolder { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADFolderItem.Reference Property

Returns a unique, persistent reference-string for this folder-item

#### Syntax

```
string Reference { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADFolder.setNotification Method

Sets the notification of this folder for the specified collection of users, teams and roles on a secure object type basis

#### Syntax

```
void setNotification(
	ADSecureObjectType secureObjectType,
	IObjectCollector pUsers,
	IObjectCollector pTeams,
	IObjectCollector pRoles,
	INotificationSelector pNotification,
	bool applyToAllSubFolders,
	bool applyToAllItems
)
```

#### Parameters

secureObjectType  ADSecureObjectType

pUsers  IObjectCollector

pTeams  IObjectCollector

pRoles  IObjectCollector

pNotification  INotificationSelector

applyToAllSubFolders  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

applyToAllItems  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IObjectCollector Properties

The IObjectCollector type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of objects in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | ObjectType | Returns the type of the objects in the collection. |



# IADPDMClass.SetSVGIcon Method

Sets the given SVG icon to the Class item.

#### Syntax

```
void SetSVGIcon(
	string svgImagePath
)
```

#### Parameters

svgImagePath  [String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMFolder.TemplateLevel Property

Returns the Template Level item of this folder, if any.

#### Syntax

```
IADPDMTemplateLevel TemplateLevel { get; }
```

#### Property Value

IADPDMTemplateLevel



# IADPDMSafeLibraries.Count Property

Returns the number of libraries in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

The count property for the Libraries object held by automation clients will
not get updated automatically when a Library is added or deleted. Get the current
Libraries collection by querying the Safe.



# IADPDMSafes.Item Method

Given a name or index, into the collection, returns the corresponding Safe.

#### Syntax

```
IADPDMSafe Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or index of the Safe.

#### Return Value

IADPDMSafe  
IADPDMSafe



# IADPDMFolders Methods

The IADPDMFolders type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection |
|  | GetFolderByName | Returns a folder item for a given name. |
|  | Item | Given a name or index, into the collection, returns the corresponding folder item. |



# IPermissionSelector Interface

IPermissionSelector interface. This interface is obsolete as of V11 of Alibre Design.

#### Syntax

```
public interface IPermissionSelector
```

The IPermissionSelector type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Administrate | Sets/resets flag indicating right to administrate. |
|  | Delete | Sets/resets flag indicating right to delete. |
|  | Read | Sets/resets flag indicating right to read. |
|  | ViewOnly | Sets/resets flag indicating right to check-in and check-out. This property is obsolete. |
|  | Write | Sets/resets flag indicating right to edit. |



# IADPDMSafe.RecycleBin Property

Returns the Recycle Bin item in the Safe.

#### Syntax

```
IADPDMSafeRecycleBin RecycleBin { get; }
```

#### Property Value

IADPDMSafeRecycleBin



# IADFolderItem.ClearPermission Method

Makes this folder-item completely inaccessible to the specified collection of users, teams and roles

#### Syntax

```
void ClearPermission(
	IObjectCollector pUsers,
	IObjectCollector pTeams,
	IObjectCollector pRoles,
	bool unPublishingRepository
)
```

#### Parameters

pUsers  IObjectCollector

pTeams  IObjectCollector

pRoles  IObjectCollector

unPublishingRepository  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADRepository.UnPublishToAll Method

Makes the entire repository inaccessible to All, other than the owner

#### Syntax

```
void UnPublishToAll()
```



# IADPDMFileItem.ItemType Property

The type of the file item based on the extension.

#### Syntax

```
ADObjectSubType ItemType { get; }
```

#### Property Value

ADObjectSubType



# IADPDMPropertyDefinitions.GetEnumerator Method

Returns an enumerator for the collection.

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADPDMProperty.Value Property

Returns the value as a string.

#### Syntax

```
string Value { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPDMFileItem.CancelCheckIn Method

Cancels the check-in operation, if possible.

#### Syntax

```
void CancelCheckIn()
```



# IADRepository.IsPublished Method

Determines if the repository is accessible to anyone other than the owner

#### Syntax

```
bool IsPublished()
```

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

# IADPDMVersionFileItem.IsRevision Property

Returns true if this is a Revision item.

#### Syntax

```
bool IsRevision { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
