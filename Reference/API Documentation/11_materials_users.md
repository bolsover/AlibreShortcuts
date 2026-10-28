# AlibreX API — Materials, Users, Teams & Misc

> Part of the split AlibreX reference. See `00_index.md` for the full map.

**Sections in this file:** 127

---


# IADPrintabilityCheckResults.InterlockingErrors Property

Returns the number of Interlocking Errors in design

#### Syntax

```
int InterlockingErrors { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADMaterialLibraryFolder.Name Property

Returns the Folder's name

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADUsers Properties

The IADUsers type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of users in this collection. |
|  | Enum | Returns an enumerator for the collection. |



# IADMaterialLibraries Methods

The IADMaterialLibraries type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given numerical index into the collection, returns the corresponding library. |



# IADPrintabilityCheckResults.ManifoldsolidErrors Property

Returns the number of Manifoldsolid errors in design

#### Syntax

```
int ManifoldsolidErrors { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADMaterials.Count Property

Returns the number of materials in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADTeamRole.TeamName Property

Returns this Role's team name

#### Syntax

```
string TeamName { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADMaterial.Density Property

Returns the density of the material

#### Syntax

```
double Density { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADVaultInfo.IsUsingVault Property

Returns true if the user has selected to use the Alibre Vault to save their designs.

#### Syntax

```
bool IsUsingVault { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPrintabilityCheckResults.VoidErrors Property

Returns the number of Void errors in design

#### Syntax

```
int VoidErrors { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADAutoBrepImportSummary Properties

The IADAutoBrepImportSummary type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CADCreationFromGMCADTime |  |
|  | CADExportTime |  |
|  | FailReason |  |
|  | GMCADCreationTime |  |
|  | IsCreatedByFallback |  |
|  | IsMeshHealed |  |
|  | Num\_MeshComponent |  |
|  | PlannarFallbackReason |  |
|  | SegmentationTime |  |



# IADTeamRoles.Item Method

Given role's name or an index into the collection, returns IADTeamRole interface

#### Syntax

```
IADTeamRole Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)

#### Return Value

IADTeamRole



# IADAutoBrepImportSummary.IsCreatedByFallback Property

#### Syntax

```
string IsCreatedByFallback { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADMaterialLibraryFolders Methods

The IADMaterialLibraryFolders type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given numerical index into the collection, returns the corresponding folder. |



# IADTeamRoles Interface

IADTeamRoles interface. This interface is obsolete as of V11 of Alibre Design.

#### Syntax

```
public interface IADTeamRoles
```

The IADTeamRoles type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of IADTeamRole in this collection |
|  | Enum | Returns an enumerator for the collection |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given role's name or an index into the collection, returns IADTeamRole interface |



# IADTeam.IsMember Method

Checks if specified user is a member of this team and if so returns the member's interface

#### Syntax

```
bool IsMember(
	IADUser pUser
)
```

#### Parameters

pUser  IADUser

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDataFont.IsStrikeThrough Property

Returns true if text is StrikeThrough.

#### Syntax

```
bool IsStrikeThrough { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADTeam Properties

The IADTeam type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Name | Returns this team's name |
|  | Roles | Returns a collection of roles in this team |
|  | Root | Returns the automation root |
|  | TeamMembers | Returns a collection of members in this team |
|  | Type | Returns a pre-defined constant that identifies the type of this object |



# IADMaterialLibraryFolder.Materials Property

Returns a collection of materials in the folder.

#### Syntax

```
IADMaterials Materials { get; }
```

#### Property Value

IADMaterials



# IADTeam.AddRole Method

Add a role to this team

#### Syntax

```
IADTeamRole AddRole(
	string roleName
)
```

#### Parameters

roleName  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADTeamRole



# IADPrintabilityCheckResults.BottleneckErrors Property

Returns the number of Bottleneck errors in design

#### Syntax

```
int BottleneckErrors { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADVaultInfo.VaultDriveLetter Property

Gets the drive letter for the Vault.

#### Syntax

```
string VaultDriveLetter { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADTeamRole.Type Property

Returns a pre-defined constant that identifies the type of this object

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADAutoBrepImportSummary.CADExportTime Property

#### Syntax

```
string CADExportTime { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADMaterialLibraryFolder Methods

The IADMaterialLibraryFolder type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | createMaterial | Create a new Material. |
|  | createSubFolder | Create a New Sub Folder. |



# IADMaterialLibraryFolders Interface

IADMaterialLibraryFolders represents the interface for a Collection of Folders in the Material Library.

#### Syntax

```
public interface IADMaterialLibraryFolders
```

The IADMaterialLibraryFolders type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of folders in this collection. |
|  | Enum | Returns an enumerator for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given numerical index into the collection, returns the corresponding folder. |



# IADTeamRoles.Count Property

Returns the number of IADTeamRole in this collection

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADUser Properties

The IADUser type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Name | Returns this user's name. |
|  | Root | Returns the automation root. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. |



# IADDataFont.IsUnderline Property

Returns true if text is underlined.

#### Syntax

```
bool IsUnderline { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADTeam.Remove Method

Removes this team

#### Syntax

```
void Remove()
```



# IADUsers.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADMaterialLibrary.Name Property

Returns the library's name

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADAutoBrepImportSummary.Num_MeshComponent Property

#### Syntax

```
int Num_MeshComponent { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADTeams.Enum Property

Returns an enumerator for the collection

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADMaterialLibraryFolder.Root Property

Returns the automation root

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADTeamRole.Root Property

Returns the automation root

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADMaterialLibraries Properties

The IADMaterialLibraries type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of libraries in this collection. |
|  | Enum | Returns an enumerator for the collection. |



# IADMaterial Methods

The IADMaterial type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | getMaterialPropertyValue | Get material property value for the given property key. |



# IADMaterials Interface

IADMaterials represents the interface for a Collection of Materials in the Material Library.

#### Syntax

```
public interface IADMaterials
```

The IADMaterials type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of materials in this collection. |
|  | Enum | Returns an enumerator for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given a name or numerical index into the collection, returns the corresponding material. |



# IADUsers Methods

The IADUsers type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given an index into the collection, returns the corresponding user's interface. |



# IADMaterialLibraryFolders.GetEnumerator Method

Returns an enumerator for the collection.

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADTeamRole Interface

IADTeamRole interface. This interface is obsolete as of V11 of Alibre Design.

#### Syntax

```
public interface IADTeamRole
```

The IADTeamRole type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | RoleName | Returns this Role's name |
|  | Root | Returns the automation root |
|  | TeamName | Returns this Role's team name |
|  | Type | Returns a pre-defined constant that identifies the type of this object |



# IADTeams.Count Property

Returns the number of teams in this collection

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADDataFont.Size Property

Gets the size of the font.

#### Syntax

```
double Size { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADUser.Root Property

Returns the automation root.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADMaterialLibraries.Item Method

Given numerical index into the collection, returns the corresponding library.

#### Syntax

```
IADMaterialLibrary Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)

#### Return Value

IADMaterialLibrary



# IADTeam.Type Property

Returns a pre-defined constant that identifies the type of this object

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADUsers.Item Method

Given an index into the collection, returns the corresponding user's interface.

#### Syntax

```
IADUser Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)

#### Return Value

IADUser



# IADMaterialLibraryFolder.SubFolders Property

Returns a collection of sub folders.

#### Syntax

```
IADMaterialLibraryFolders SubFolders { get; }
```

#### Property Value

IADMaterialLibraryFolders



# IADTeamRole.RoleName Property

Returns this Role's name

#### Syntax

```
string RoleName { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADTeam Interface

IADTeam interface. This interface is obsolete as of V11 of Alibre Design.

#### Syntax

```
public interface IADTeam
```

The IADTeam type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Name | Returns this team's name |
|  | Roles | Returns a collection of roles in this team |
|  | Root | Returns the automation root |
|  | TeamMembers | Returns a collection of members in this team |
|  | Type | Returns a pre-defined constant that identifies the type of this object |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddMember | Adds speicified user as a new member of this team and returns the member's interface |
|  | AddRole | Add a role to this team |
|  | AssigneRoleToMember | Assign a role to a team member |
|  | IsMember | Checks if specified user is a member of this team and if so returns the member's interface |
|  | Remove | Removes this team |



# IADMaterialLibrary.Materials Property

Returns a collection of materials in the library.

#### Syntax

```
IADMaterials Materials { get; }
```

#### Property Value

IADMaterials



# IADPrintabilityCheckResults.PrinterName Property

Returns the current printer name

#### Syntax

```
string PrinterName { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADAutoBrepImportSummary Interface

#### Syntax

```
public interface IADAutoBrepImportSummary
```

The IADAutoBrepImportSummary type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CADCreationFromGMCADTime |  |
|  | CADExportTime |  |
|  | FailReason |  |
|  | GMCADCreationTime |  |
|  | IsCreatedByFallback |  |
|  | IsMeshHealed |  |
|  | Num\_MeshComponent |  |
|  | PlannarFallbackReason |  |
|  | SegmentationTime |  |



# IADAutoBrepImportSummary.GMCADCreationTime Property

#### Syntax

```
string GMCADCreationTime { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADTeam.Roles Property

Returns a collection of roles in this team

#### Syntax

```
IADTeamRoles Roles { get; }
```

#### Property Value

IADTeamRoles



# IADTeam.AddMember Method

Adds speicified user as a new member of this team and returns the member's interface

#### Syntax

```
void AddMember(
	IADUser pUser
)
```

#### Parameters

pUser  IADUser



# IADMaterialLibraryFolder.Type Property

Returns a pre-defined constant that identifies the type of this object. (AD\_MATERIAL)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADUser Interface

IADUser interface. This interface is obsolete as of V11 of Alibre Design.

#### Syntax

```
public interface IADUser
```

The IADUser type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Name | Returns this user's name. |
|  | Root | Returns the automation root. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. |



# IADVaultInfo Interface

The Alibre Vault information class.

#### Syntax

```
public interface IADVaultInfo
```

The IADVaultInfo type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | IsUsingVault | Returns true if the user has selected to use the Alibre Vault to save their designs. |
|  | Root | Returns the automation root object. |
|  | SelectedVaultName | Gets the name of the active Vault. |
|  | VaultDriveLetter | Gets the drive letter for the Vault. |



# IADTeam.Root Property

Returns the automation root

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADMaterialLibraries.GetEnumerator Method

Returns an enumerator for the collection.

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADMaterialLibraryFolder Properties

The IADMaterialLibraryFolder type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Materials | Returns a collection of materials in the folder. |
|  | Name | Returns the Folder's name |
|  | Root | Returns the automation root |
|  | SubFolders | Returns a collection of sub folders. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_MATERIAL) |



# IADMaterials Methods

The IADMaterials type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given a name or numerical index into the collection, returns the corresponding material. |



# IADMaterial.getMaterialPropertyValue Method

Get material property value for the given property key.

#### Syntax

```
double getMaterialPropertyValue(
	ADMaterialPropertyKey materialAPIPropertyKey
)
```

#### Parameters

materialAPIPropertyKey  ADMaterialPropertyKey

#### Return Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADUser.Name Property

Returns this user's name.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADMaterial.Root Property

Returns the automation root

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADMaterial Properties

The IADMaterial type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Density | Returns the density of the material |
|  | Name | Returns the material's name |
|  | Root | Returns the automation root |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_MATERIAL) |



# IADDataFont Interface

IADDataFont interface

#### Syntax

```
public interface IADDataFont
```

The IADDataFont type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | IsItalic | Returns true if text is in italics. |
|  | IsStrikeThrough | Returns true if text is StrikeThrough. |
|  | IsUnderline | Returns true if text is underlined. |
|  | Name | Gets the name of the font. |
|  | Size | Gets the size of the font. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. |



# IADVaultInfo.SelectedVaultName Property

Gets the name of the active Vault.

#### Syntax

```
string SelectedVaultName { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADMaterialLibrary Properties

The IADMaterialLibrary type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Folders | Returns a collection of folders in the material library. |
|  | Materials | Returns a collection of materials in the library. |
|  | Name | Returns the library's name |
|  | Root | Returns the automation root |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_MATERIAL) |



# IADPrintabilityCheckResults.ModelSizeError Property

Returns model size error in design

#### Syntax

```
int ModelSizeError { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADDataFont.IsItalic Property

Returns true if text is in italics.

#### Syntax

```
bool IsItalic { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADMaterialLibrary.Type Property

Returns a pre-defined constant that identifies the type of this object. (AD\_MATERIAL)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADPrintabilityCheckResults.GapThicknessErrors Property

Returns the number of Gapthickness errors in design

#### Syntax

```
int GapThicknessErrors { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADVaultInfo Properties

The IADVaultInfo type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | IsUsingVault | Returns true if the user has selected to use the Alibre Vault to save their designs. |
|  | Root | Returns the automation root object. |
|  | SelectedVaultName | Gets the name of the active Vault. |
|  | VaultDriveLetter | Gets the drive letter for the Vault. |



# IADAutoBrepImportSummary.CADCreationFromGMCADTime Property

#### Syntax

```
string CADCreationFromGMCADTime { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADAutoBrepImportSummary.PlannarFallbackReason Property

#### Syntax

```
string PlannarFallbackReason { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADMaterialLibrary Interface

IADMaterialLibrary represents the interface for a Library object in the Material library.

#### Syntax

```
public interface IADMaterialLibrary
```

The IADMaterialLibrary type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Folders | Returns a collection of folders in the material library. |
|  | Materials | Returns a collection of materials in the library. |
|  | Name | Returns the library's name |
|  | Root | Returns the automation root |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_MATERIAL) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | createFolder | Create a new folder. |
|  | createMaterial | Create a new Material. |



# IADTeamRoles Methods

The IADTeamRoles type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given role's name or an index into the collection, returns IADTeamRole interface |



# IADMaterialLibraryFolders Properties

The IADMaterialLibraryFolders type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of folders in this collection. |
|  | Enum | Returns an enumerator for the collection. |



# IADTeam.Name Property

Returns this team's name

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADAutoBrepImportSummary.SegmentationTime Property

#### Syntax

```
string SegmentationTime { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPrintabilityCheckResults.WallThicknessErrors Property

Returns the number of Wallthickness errors in design

#### Syntax

```
int WallThicknessErrors { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADMaterial Interface

IADMaterial represents the interface for a Material object in the Material library.

#### Syntax

```
public interface IADMaterial
```

The IADMaterial type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Density | Returns the density of the material |
|  | Name | Returns the material's name |
|  | Root | Returns the automation root |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_MATERIAL) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | getMaterialPropertyValue | Get material property value for the given property key. |



# IADMaterialLibrary.Root Property

Returns the automation root

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADAutoBrepImportSummary.IsMeshHealed Property

#### Syntax

```
bool IsMeshHealed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADTeamRole Properties

The IADTeamRole type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | RoleName | Returns this Role's name |
|  | Root | Returns the automation root |
|  | TeamName | Returns this Role's team name |
|  | Type | Returns a pre-defined constant that identifies the type of this object |



# IADMaterialLibraryFolders.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADMaterialLibrary.Folders Property

Returns a collection of folders in the material library.

#### Syntax

```
IADMaterialLibraryFolders Folders { get; }
```

#### Property Value

IADMaterialLibraryFolders



# IADTeam.AssigneRoleToMember Method

Assign a role to a team member

#### Syntax

```
void AssigneRoleToMember(
	IADUser pUser,
	string roleName
)
```

#### Parameters

pUser  IADUser

roleName  [String](https://learn.microsoft.com/dotnet/api/system.string)



# IADUsers Interface

IADUsers interface. This interface is obsolete as of V11 of Alibre Design.

#### Syntax

```
public interface IADUsers
```

The IADUsers type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of users in this collection. |
|  | Enum | Returns an enumerator for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given an index into the collection, returns the corresponding user's interface. |



# IADMaterialLibraryFolders.Item Method

Given numerical index into the collection, returns the corresponding folder.

#### Syntax

```
IADMaterialLibraryFolder Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)

#### Return Value

IADMaterialLibraryFolder



# IADTeams Methods

The IADTeams type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a team's name or an index into the collection, returns the team interface |



# IADMaterialLibraryFolder.createSubFolder Method

Create a New Sub Folder.

#### Syntax

```
IADMaterialLibraryFolder createSubFolder(
	string folderName
)
```

#### Parameters

folderName  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADMaterialLibraryFolder



# IADDataFont.Name Property

Gets the name of the font.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADMaterials.Item Method

Given a name or numerical index into the collection, returns the corresponding material.

#### Syntax

```
IADMaterial Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)

#### Return Value

IADMaterial



# IADTeams.Item Method

Given a team's name or an index into the collection, returns the team interface

#### Syntax

```
IADTeam Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)

#### Return Value

IADTeam



# IADMaterial.Type Property

Returns a pre-defined constant that identifies the type of this object. (AD\_MATERIAL)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADMaterials.GetEnumerator Method

Returns an enumerator for the collection.

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADMaterial.Name Property

Returns the material's name

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADTeams Interface

IADTeams interface. This interface is obsolete as of V11 of Alibre Design.

#### Syntax

```
public interface IADTeams
```

The IADTeams type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of teams in this collection |
|  | Enum | Returns an enumerator for the collection |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a team's name or an index into the collection, returns the team interface |



# IADMaterialLibrary Methods

The IADMaterialLibrary type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | createFolder | Create a new folder. |
|  | createMaterial | Create a new Material. |



# IADMaterialLibraryFolder.createMaterial Method

Create a new Material.

#### Syntax

```
IADMaterial createMaterial(
	string materialName
)
```

#### Parameters

materialName  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADMaterial



# IADMaterials Properties

The IADMaterials type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of materials in this collection. |
|  | Enum | Returns an enumerator for the collection. |



# IADTeamRoles.Enum Property

Returns an enumerator for the collection

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADMaterialLibraryFolders.Count Property

Returns the number of folders in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADMaterialLibrary.createFolder Method

Create a new folder.

#### Syntax

```
IADMaterialLibraryFolder createFolder(
	string folderName
)
```

#### Parameters

folderName  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADMaterialLibraryFolder



# IADMaterialLibraries Interface

IADMaterialLibraries represents the interface for a Collection of Material Library.

#### Syntax

```
public interface IADMaterialLibraries
```

The IADMaterialLibraries type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of libraries in this collection. |
|  | Enum | Returns an enumerator for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given numerical index into the collection, returns the corresponding library. |



# IADTeams Properties

The IADTeams type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of teams in this collection |
|  | Enum | Returns an enumerator for the collection |



# IADMaterialLibraryFolder Interface

IADMaterialLibraryFolder represents the interface for a Folder in the Material Library.

#### Syntax

```
public interface IADMaterialLibraryFolder
```

The IADMaterialLibraryFolder type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Materials | Returns a collection of materials in the folder. |
|  | Name | Returns the Folder's name |
|  | Root | Returns the automation root |
|  | SubFolders | Returns a collection of sub folders. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_MATERIAL) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | createMaterial | Create a new Material. |
|  | createSubFolder | Create a New Sub Folder. |



# IADVaultInfo.Root Property

Returns the automation root object.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADTeam.TeamMembers Property

Returns a collection of members in this team

#### Syntax

```
IADUsers TeamMembers { get; }
```

#### Property Value

IADUsers



# IADMaterialLibraries.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADMaterialLibrary.createMaterial Method

Create a new Material.

#### Syntax

```
IADMaterial createMaterial(
	string materialName
)
```

#### Parameters

materialName  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADMaterial



# IADUsers.Count Property

Returns the number of users in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADTeamRoles Properties

The IADTeamRoles type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of IADTeamRole in this collection |
|  | Enum | Returns an enumerator for the collection |



# IADTeam Methods

The IADTeam type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddMember | Adds speicified user as a new member of this team and returns the member's interface |
|  | AddRole | Add a role to this team |
|  | AssigneRoleToMember | Assign a role to a team member |
|  | IsMember | Checks if specified user is a member of this team and if so returns the member's interface |
|  | Remove | Removes this team |



# IADPrintabilityCheckResults.OverhangErrors Property

Returns the number of Overhang errors in design

#### Syntax

```
int OverhangErrors { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADDataFont.Type Property

Returns a pre-defined constant that identifies the type of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADUser.Type Property

Returns a pre-defined constant that identifies the type of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADMaterialLibraries.Count Property

Returns the number of libraries in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADAutoBrepImportSummary.FailReason Property

#### Syntax

```
string FailReason { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPrintabilityCheckResults Properties

The IADPrintabilityCheckResults type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BottleneckErrors | Returns the number of Bottleneck errors in design |
|  | GapThicknessErrors | Returns the number of Gapthickness errors in design |
|  | InterlockingErrors | Returns the number of Interlocking Errors in design |
|  | ManifoldsolidErrors | Returns the number of Manifoldsolid errors in design |
|  | ModelSizeError | Returns model size error in design |
|  | OverhangErrors | Returns the number of Overhang errors in design |
|  | PrinterName | Returns the current printer name |
|  | VoidErrors | Returns the number of Void errors in design |
|  | WallThicknessErrors | Returns the number of Wallthickness errors in design |



# IADPrintabilityCheckResults Interface

IADPrintabilityCheckResults is an interface for printability checked result that are associated with the
design.
This interface is obsolete as of v2018.1 of Alibre Design.

#### Syntax

```
public interface IADPrintabilityCheckResults
```

The IADPrintabilityCheckResults type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BottleneckErrors | Returns the number of Bottleneck errors in design |
|  | GapThicknessErrors | Returns the number of Gapthickness errors in design |
|  | InterlockingErrors | Returns the number of Interlocking Errors in design |
|  | ManifoldsolidErrors | Returns the number of Manifoldsolid errors in design |
|  | ModelSizeError | Returns model size error in design |
|  | OverhangErrors | Returns the number of Overhang errors in design |
|  | PrinterName | Returns the current printer name |
|  | VoidErrors | Returns the number of Void errors in design |
|  | WallThicknessErrors | Returns the number of Wallthickness errors in design |



# IADDataFont Properties

The IADDataFont type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | IsItalic | Returns true if text is in italics. |
|  | IsStrikeThrough | Returns true if text is StrikeThrough. |
|  | IsUnderline | Returns true if text is underlined. |
|  | Name | Gets the name of the font. |
|  | Size | Gets the size of the font. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. |



# IADMaterials.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum

