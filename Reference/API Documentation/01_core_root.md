# AlibreX API — Core / Root / Session

> Part of the split AlibreX reference. See `00_index.md` for the full map.

**Sections in this file:** 228

---


# AutomationHook Class

Alibre Design automation hook

#### Inheritance Hierarchy

[SystemObject](https://learn.microsoft.com/dotnet/api/system.object)  
  [SystemMarshalByRefObject](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject)  
    AlibreXAutomationHook  

#### Syntax

```
public class AutomationHook : MarshalByRefObject, 
	IAutomationHook
```

The AutomationHook type exposes the following members.

#### Constructors

|  | Name | Description |
| --- | --- | --- |
|  | AutomationHook | Initialize a new instance of the AutomationHook. |

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Root | Returns the interface to the root object in the Automation hierarchy. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | [CreateObjRef](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject.createobjref) | Creates an object that contains all the relevant information required to generate a proxy used to communicate with a remote object. (Inherited from [MarshalByRefObject](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject)) |
|  | [Equals](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)) | Determines whether the specified object is equal to the current object. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | [Finalize](https://learn.microsoft.com/dotnet/api/system.object.finalize) | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | [GetHashCode](https://learn.microsoft.com/dotnet/api/system.object.gethashcode) | Serves as the default hash function. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | [GetLifetimeService](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject.getlifetimeservice) | Retrieves the current lifetime service object that controls the lifetime policy for this instance. (Inherited from [MarshalByRefObject](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject)) |
|  | [GetType](https://learn.microsoft.com/dotnet/api/system.object.gettype) | Gets the [Type](https://learn.microsoft.com/dotnet/api/system.type) of the current instance. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | Initialize | Initiates a new Alibre Design Automation client in GUI-less mode. |
|  | InitializeDebug | Initiates a new Alibre Design Automation client in Debug mode. |
|  | [MemberwiseClone](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone) | Creates a shallow copy of the current [Object](https://learn.microsoft.com/dotnet/api/system.object). (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | [MemberwiseClone(Boolean)](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject.memberwiseclone#system-marshalbyrefobject-memberwiseclone(system-boolean)) | Creates a shallow copy of the current [MarshalByRefObject](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject) object. (Inherited from [MarshalByRefObject](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject)) |
|  | [ToString](https://learn.microsoft.com/dotnet/api/system.object.tostring) | Returns a string that represents the current object. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |



# IADSession.IsGUIVisible Property

Returns True if the GUI for this session is visible.

#### Syntax

```
bool IsGUIVisible { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADRoot.ImportImages Method

Creates a new drawing session with the image files as sheets.

#### Syntax

```
IADSession ImportImages(
	in Array pFilePaths
)
```

#### Parameters

pFilePaths  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   An array of filepaths of images to import.

#### Return Value

IADSession  
Returns a session containing the imported file.



# IADEventsCallback.OnSessionClose Method

Event notifying that a session has been closed.

#### Syntax

```
void OnSessionClose(
	IADSession pSession
)
```

#### Parameters

pSession  IADSession
:   The session which was closed.



# IADRoot Methods

The IADRoot type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | BindReferenceToObject | Returns the interface to an object given its unique, persistent reference-string. |
|  | ConnectToPDM | Connect to a PDM Server. |
|  | CreateEmptyAssembly | Creates an empty assembly. |
|  | CreateEmptyAssemblyEx | Creates an empty assembly. |
|  | CreateEmptyDrawing | Creates a new empty Drawing. |
|  | CreateEmptyDrawingEx | Creates a new empty Drawing. |
|  | CreateEmptyGlobalParameters | Creates a new empty Global Parameters workspace. |
|  | CreateEmptyGlobalParametersEx | Creates a new empty Global Parameters workspace. |
|  | CreateEmptyPart | Creates a new empty part. |
|  | CreateEmptyPartEx | Creates a new empty part. |
|  | createMaterialLibrary | Create a new Material Library. |
|  | CreateTeam | Creates a new team and automatically adds the owner to it. |
|  | CreateUser | Creates an arbitrary user given a name. |
|  | EncryptPassword | Generates an encrypted password from a plain text one. |
|  | GetActiveServerConnection | Returns the existing PDM Server connection in the UI. |
|  | GetAgentProperty | Obsolete |
|  | GetGuidAndConstituentInformation | Get the item GUID and constituent information (GUIDs, names and relative file paths) for the file specified in the path. |
|  | GetGuidAndTPConstituentsData | Get the item GUID and TP constituents data (GUIDs, names and relative file paths) for the file specified in the path. |
|  | GetRepositoryByName | Returns an interface to the repository identified by name. |
|  | GetRepositoryReference | Returns the repository reference for a given file if it exists in the repository. |
|  | GetTeamByName | Returns interface describing existing team identified by name. |
|  | GetUserByName | Returns an interface describing the existing user identified by name. |
|  | Import3DMFile | Creates a new design session from the contents of the input Open Nurbs (3DM) file. |
|  | ImportDWGFile | Creates a new drawing session from contents of input DWG file. |
|  | ImportDXFFile | Creates a new drawing session from contents of input DXF file. |
|  | ImportIGESFile | Creates a new design session from contents of input IGES file. |
|  | ImportIGESFileEx | Creates a new design or drawing session from contents of the input IGES file. |
|  | ImportImages | Creates a new drawing session with the image files as sheets. |
|  | ImportNonNative3DFile | Creates a new design session from contents of input file. |
|  | ImportSATFile | Creates a new design session from contents of input SAT file. |
|  | ImportSATFileEx | Creates a new design session from contents of the input SAT file. |
|  | ImportSTEPFile | Creates a new design or drawing session from contents of the input STEP file. |
|  | ImportSTEPFileEx | Creates a new design or drawing session from contents of the input STEP file. |
|  | IsMeshTypeFile | Returns boolean value which indicates whether input file is mesh type or not. |
|  | IsOpenedFromRepository | Determines if a file (specified by its full disk path) is opened from the repository. |
|  | NewNotificationSelector | Creates a new notification selector object used for specifying the notifications associated with a repository resource. |
|  | NewObjectCollector | Creates a new empty collection object used for building a collection of objects of a given type. |
|  | NewPermissionSelector | Creates a new permission selector object used for setting access rights to a repository resource. |
|  | OpenFile | Opens a Alibre Design file from the file system. |
|  | OpenFileEx | Opens a Alibre Design file from the file system. |
|  | OpenFileFromSafe | Opens the latest file item from the PDM Safe. |
|  | OpenFileWithUI | Opens a file from the file system when Alibre's UI is running. |
|  | RegisterAgent | Obsolete |
|  | removeMaterialLibrary | Remove Library. |
|  | RestorePackage | Restores a Alibre Package File (.AD\_PKG) to its expanded constituent native Alibre files. |
|  | RunAgent | Obsolete |
|  | SendMessage | Sends a notification message to a collection of teams and/or users. |
|  | SetAgentProperty | Obsolete |
|  | Terminate | Terminates the Automation client. |
|  | TerminateAll | Terminates the Automation client. If Alibre is launched from automation, TerminalAll() will safely terminate the automated process, even if called from a different thread. |



# IADGeometryFactory.CreateVector Method

Creates a 3D vector from the given direction components.

#### Syntax

```
IADVector CreateVector(
	double I,
	double J,
	double K
)
```

#### Parameters

I  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The I component of the vector.

J  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The J component of the vector.

K  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The K component of the vector.

#### Return Value

IADVector  
The created vector.

#### Remarks

The direction components need not define a unit vector.

#### Example

This Visual Basic sample shows how to call the CreateVector method.

```
' Holds Geometry Factory
Dim objADGeometryFactory As AlibreX.IADGeometryFactory

' Get Geometry Factory from Session object
Set objADGeometryFactory = m_objADSession.GeometryFactory

' Holds X Direction Vector
Dim objADXDirVector As AlibreX.IADVector

' Create Vector along X direction
Set objADXDirVector = objADGeometryFactory.CreateVector(1, 0, 0)
```



# IADTransformation.Inverse Method

Returns the inverse transform of this transform. This transform remains unchanged.

#### Syntax

```
IADTransformation Inverse()
```

#### Return Value

IADTransformation  
The inverted transformation.



# IADTransformation.ToString Method

Returns the transform data as a string.

#### Syntax

```
string ToString()
```

#### Return Value

[String](https://learn.microsoft.com/dotnet/api/system.string)  
The transform data as a string.



# ADFaceProcessingType Enumeration

#### Syntax

```
public enum ADFaceProcessingType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_NONE | 0 |  |
| AD\_STITCH\_ADJOINING\_FACES | 1 |  |
| AD\_UNSTITCH\_TO\_STANDALONE\_SURFACES | 2 |  |



# IADVector Interface

IADVector interface represents a vector in 3-dimensional space. This interface
defines a vector by its x, y and z components.

#### Syntax

```
public interface IADVector
```

The IADVector type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Length | Returns the length of the vector. |
|  | X | Gets the X direction component. |
|  | Y | Gets the Y direction component. |
|  | Z | Gets the Z direction component. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | IsEqualTo | Returns whether this vector is equal to the given vector. |
|  | Normalize | Returns the normalized vector. This vector remains unchanged. |



# ADDrawingViewType Enumeration

This enumeration identifies the different drawing view display modes.

#### Syntax

```
public enum ADDrawingViewType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_STANDARD | 0 | Standard views have the most precisely rendered lines and support line pattern layer styles, but require more time to project. |
| AD\_DRAFT | 1 | Draft views have a faster projection speed at the expense of quality. |
| AD\_SHADED | 2 | Shaded views render the design as it is seen in the Part/Assembly workspace. |



# IADTransformation.IsEqualTo Method

Returns whether this transfrom is equal to the given transform.

#### Syntax

```
bool IsEqualTo(
	IADTransformation pTransform
)
```

#### Parameters

pTransform  IADTransformation
:   The transformation to compare to.

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)  
The result of the equality comparison.



# DIEnum.HasMoreElements Method

Returns true if the enumerator has more elements.

#### Syntax

```
bool HasMoreElements()
```

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IAutomationHook.InitializeService Method

Initiates a new Alibre Design Automation client in Service mode

#### Syntax

```
void InitializeService()
```



# IADSession.SelectedObjectsEx Method

Returns all selected entities in the session's browser as a collection of target proxies,
and sets the parameter lastSelectedPoint to last point in the user clicked to make
the selection.

#### Syntax

```
IObjectCollector SelectedObjectsEx(
	out IADPoint lastSelectedPoint
)
```

#### Parameters

lastSelectedPoint  IADPoint
:   The point which was last selected in the GUI by the user.

#### Return Value

IObjectCollector  
A collection of IADTargetProxys.

#### Remarks

Applies only when session is being edited in GUI.



# IADRoot.ConnectToPDM Method

Connect to a PDM Server.

#### Syntax

```
IADPDMServerConnection ConnectToPDM(
	string serverURL,
	string domain,
	string username,
	string password
)
```

#### Parameters

serverURL  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The Server URL where the PDM Server is hosted.

domain  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The domain name where the PDM Server lives in.

username  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The username to login into the PDM Server.

password  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The password to login into the PDM Server.

#### Return Value

IADPDMServerConnection



# IADVector.Normalize Method

Returns the normalized vector. This vector remains unchanged.

#### Syntax

```
IADVector Normalize()
```

#### Return Value

IADVector  
The normalized vector.



# ADTappedThreadType Enumeration

#### Syntax

```
public enum ADTappedThreadType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_UNC | 1 |  |
| AD\_UNF | 2 |  |
| AD\_UNEF | 3 |  |
| AD\_UNS | 4 |  |
| AD\_METRIC\_COARSE | 5 |  |
| AD\_METRIC\_FINE | 6 |  |
| AD\_METRIC\_SPECIAL | 7 |  |
| AD\_NPT | 9 |  |
| AD\_UNKNOWN\_THREAD | -1 |  |
| AD\_GENERIC\_ENGLISH | 1,000 |  |
| AD\_GENERIC\_METRIC | 2,000 |  |



# IADRoot.RegisterAgent Method

Obsolete

#### Syntax

```
void RegisterAgent(
	in Array pAgentBytes
)
```

#### Parameters

pAgentBytes  [Array](https://learn.microsoft.com/dotnet/api/system.array)

#### Remarks

This method is obsolete as of V11 of Alibre Design.



# IADGeometryFactory.Create2DPoint Method

Creates a 2D point from the given coordinates.

#### Syntax

```
IAD2DPoint Create2DPoint(
	double X,
	double Y
)
```

#### Parameters

X  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the point.

Y  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the point.

#### Return Value

IAD2DPoint  
The created point.



# IAutomationHook Interface

IAutomationHook interface

#### Syntax

```
public interface IAutomationHook
```

The IAutomationHook type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Root | Returns the automation root. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Initialize | Initiates a new Alibre Design Automation client in GUI-less mode. |
|  | InitializeDebug | Initiates a new Alibre Design Automation client in Debug mode. |
|  | InitializeService | Initiates a new Alibre Design Automation client in Service mode |



# AutomationHook Properties

The AutomationHook type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Root | Returns the interface to the root object in the Automation hierarchy. |



# IADRoot.GetRepositoryByName Method

Returns an interface to the repository identified by name.

#### Syntax

```
IADRepository GetRepositoryByName(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the repository.

#### Return Value

IADRepository  
Returns IADRepository

#### Remarks

This method is obsolete as of V11 of Alibre Design.



# IADSessions.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# ADDimensionType Enumeration

#### Syntax

```
public enum ADDimensionType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_LINEAR | 1 |  |
| AD\_RADIAL | 2 |  |
| AD\_DIAMETRIC | 3 |  |
| AD\_CIRCULAR | 4 |  |
| AD\_SMART | 5 |  |



# IADRoot.Teams Property

Returns a collection of accessible teams.

#### Syntax

```
IADTeams Teams { get; }
```

#### Property Value

IADTeams

#### Remarks

This method is obsolete as of V11 of Alibre Design.



# IADSession.SaveCurrentViewSnapshot Method

Saves the snapshot of the graphic canvas for current view in the session, at the given location and of the given size.

#### Syntax

```
void SaveCurrentViewSnapshot(
	string fullImagePath,
	int width,
	int height,
	bool bUseCanvasAspectRatio = true,
	bool bUseCanvasWidthAndHeight = false
)
```

#### Parameters

fullImagePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The full filepath describing where the image should be saved.

width  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The width of the saved snapshot; cannot be negative.

height  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The width of the saved snapshot; cannot be negative.

bUseCanvasAspectRatio  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)  (Optional)
:   If true, the greater of the values passed for width/height will be used with the
    aspect ratio of the current display canvas to determine the size of the snapshot.

bUseCanvasWidthAndHeight  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)  (Optional)
:   If true, other parameters are overridden and the current width and height of the
    graphic canvas are used.



# IADPoint.Y Property

Returns the Y coordinate of the 3D point.

#### Syntax

```
double Y { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADRoot Properties

The IADRoot type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | AlibreAddOns | Returns the Add On context which is used to perform add on operation by automation. |
|  | AppTitle | Returns the version number of the application. |
|  | EventManager | Returns the event manager object used for registering event callbacks. |
|  | InstalledDrawingTemplates | Returns an array of the names of installed Drawing Templates. |
|  | LanguageForResources | Returns the language Alibre is currently running on. |
|  | ListedUsers | Returns a collection of users available for collaboration. |
|  | MaterialLibraries | Returns a collection of material library. |
|  | Materials | Returns a collection of materials in the material library. |
|  | Repositories | Returns a collection of accessible repositories. |
|  | Sessions | Returns a collection of open sessions. |
|  | Teams | Returns a collection of accessible teams. |
|  | TopmostSession | Returns an interface to the session whose window is the highest in the Z-order of all Alibre session windows. If no sessions are open, this property will be null. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_ROOT) of this object. |
|  | User | Returns interface describing user who initiated the client. |
|  | VaultInfo | Returns the Vault Information interface. |
|  | Version | Returns the version number of the application. |



# EventManager.SessionCloseHandler Delegate

#### Syntax

```
public delegate void SessionCloseHandler(
	IADSession pSession
)
```

#### Parameters

pSession  IADSession



# IADRoot.GetUserByName Method

Returns an interface describing the existing user identified by name.

#### Syntax

```
IADUser GetUserByName(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the user.

#### Return Value

IADUser  

#### Remarks

This method is obsolete as of V11 of Alibre Design.



# IADRoot.EncryptPassword Method

Generates an encrypted password from a plain text one.

#### Syntax

```
string EncryptPassword(
	string plainTextPassword
)
```

#### Parameters

plainTextPassword  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The unencrypted password.

#### Return Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADSession.BindKeyToItem Method

Given a Persistent Key, returns the corresponding Occurrence/Topology element/Sketch.

#### Syntax

```
Object BindKeyToItem(
	in Array pKey,
	ADObjectType objectType
)
```

#### Parameters

pKey  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   A byte array of the object's persistent key, obtained from their Key property.

objectType  ADObjectType
:   The ADObjectType of the object whose key is being passed in the first parameter.

#### Return Value

[Object](https://learn.microsoft.com/dotnet/api/system.object)  
The object can be an instance of IADOccurrence, a Topology object,
or an IADSketch.



# IADAddOns.ExportFile(String, IADSession) Method

#### Syntax

```
void ExportFile(
	string targetFileName,
	IADSession session
)
```

#### Parameters

targetFileName  [String](https://learn.microsoft.com/dotnet/api/system.string)

session  IADSession



# EventManager Class

Alibre Automation Event Manager

#### Inheritance Hierarchy

[SystemObject](https://learn.microsoft.com/dotnet/api/system.object)  
  AlibreXEventManager  

#### Syntax

```
public class EventManager
```

The EventManager type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | [Equals](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)) | Determines whether the specified object is equal to the current object. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | [Finalize](https://learn.microsoft.com/dotnet/api/system.object.finalize) | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | [GetHashCode](https://learn.microsoft.com/dotnet/api/system.object.gethashcode) | Serves as the default hash function. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | [GetType](https://learn.microsoft.com/dotnet/api/system.object.gettype) | Gets the [Type](https://learn.microsoft.com/dotnet/api/system.type) of the current instance. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | [MemberwiseClone](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone) | Creates a shallow copy of the current [Object](https://learn.microsoft.com/dotnet/api/system.object). (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | [ToString](https://learn.microsoft.com/dotnet/api/system.object.tostring) | Returns a string that represents the current object. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |

#### Events

|  | Name | Description |
| --- | --- | --- |
|  | OnInitialize | Event notifying that Alibre Design has been initialized. |
|  | OnModelLoadComplete | Event notifying that a session has fully loaded. |
|  | OnSessionChange | Event notifying that a session has been modified. |
|  | OnSessionClose | Event notifying that a new top level session has been opened. |
|  | OnSessionOpen | Event notifying that a new top level session has been opened. |
|  | OnTerminate | Event notifying that Alibre Design has been terminated. |



# ADSelectionFilterOption Enumeration

This enumeration describes different options available for selection filters
with more than an on/off setting. It is used by the
Solid and
Surface properties of
IADDesignSelectionFilter.

#### Syntax

```
public enum ADSelectionFilterOption
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_NONE | 0 | None. No objects in this category will be selectable. |
| AD\_VERTICES | 1 | Only vertices of this category will be selectable. This option is not valid for the Solid property of the selection filter when the design is an assembly. |
| AD\_EDGES | 2 | Only edges of this category will be selectable. |
| AD\_FACES | 3 | Only faces of this category will be selectable. |
| AD\_FACES\_EDGES | 4 | Faces and edges of this category will be selectable. |
| AD\_FACES\_EDGES\_VERTICES | 5 | Faces, edges, and vertices of this category will be selectable. This option is not valid for the Solid property of the selection filter when the design is an assembly. |
| AD\_FEATURES | 6 | Whole features will be selectable. This option is only valid for the Solid property of the selection filter for part sessions. |
| AD\_SURFACES | 7 | Whole reference surfaces will be selectable. This option is only valid for the Surface property. |
| AD\_PARTS | 8 | Whole parts will be selectable. This option is only valid for the Solid property of the selection filter for assembly sessions. |
| AD\_COMPONENTS | 9 | Whole subassemblies or parts will be selectable. This option is only valid for the Solid property of the selection filter for assembly sessions. |



# ADHoleDepthCondition Enumeration

An enumeration of possible depth conditions for Hole features,
returned by their DepthConditionType property.
This is also used by the Hole feature creation methods on
IADPartFeatures.

#### Syntax

```
public enum ADHoleDepthCondition
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_HOLE\_TO\_DEPTH | 0 | The "To Depth" depth condition, also known as "Blind." The hole will be cut to the specified depth. |
| AD\_HOLE\_TO\_OFFSET\_FACE | 2 | The "To Offset Face" depth condition, also known as "To Limit Geometry." The hole will be cut until it reaches the specified geometry. |
| AD\_HOLE\_THROUGH\_ALL | 3 | The "Through All" depth condition. The hole will cut all the way through the part. |
| AD\_HOLE\_DEPTH\_CONDITION\_UNKNOWN | -1 | The depth condition is unknown. If this value is returned from the DepthConditionType property, then the feature is probably corrupt. |



# IADTransformation Interface

The IADTransformation interface represents a general 3D affine homogeneous transformation
(e.g. a rotation and a translation). This interface is used for getting the view transformation
of a session, specifying the transformation of a part being inserted into an assembly, getting the
transformation of Occurrences, etc. Internally, the transform is stored as a 4 X 4 matrix.

#### Syntax

```
public interface IADTransformation
```

The IADTransformation type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Apply | Applies this transform on the given transform and returns the resultant transform. |
|  | Array | Returns the elements of the transform as a one-dimensional array containing 16 doubles. This array represents a 4x4 matrix. |
|  | Decompose | Returns the decomposed transform data for this transform. |
|  | Inverse | Returns the inverse transform of this transform. This transform remains unchanged. |
|  | IsEqualTo | Returns whether this transfrom is equal to the given transform. |
|  | ToString | Returns the transform data as a string. |

#### Remarks

A new transformation is created by making a call to
IADGeometryFactory.CreateTransform. IADGeometryFactory
has several other, more specialized methods for creating transformations as well.



# IADRoot.OpenFileFromSafe Method

Opens the latest file item from the PDM Safe.

#### Syntax

```
IADSession OpenFileFromSafe(
	string reference,
	bool openEditor
)
```

#### Parameters

reference  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The unique reference of the file item Reference

openEditor  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Return Value

IADSession



# IADRoot.CreateEmptyGlobalParametersEx Method

Creates a new empty Global Parameters workspace.

#### Syntax

```
IADGlobalParameterSession CreateEmptyGlobalParametersEx(
	string name,
	bool openEditor
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name for the new Global Parameters document.

openEditor  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Flag specifying whether to show the newly created global parameters session in an editor window

#### Return Value

IADGlobalParameterSession  
The interface to the new Global Parameters session.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_CREATE\_GLOBAL\_PARAM\_SESSION\_FAILED | Alibre failed to create the empty global parameters session. |



# IADTransformation.Apply Method

Applies this transform on the given transform and returns the resultant transform.

#### Syntax

```
IADTransformation Apply(
	IADTransformation pTransform
)
```

#### Parameters

pTransform  IADTransformation
:   The transformation to be applied.

#### Return Value

IADTransformation  
The resultant transformation.



# IADRoot.OpenFile Method

Opens a Alibre Design file from the file system.

#### Syntax

```
IADSession OpenFile(
	string filePath
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The full path of the file.

#### Return Value

IADSession  
Returns a session of the opened file.



# IADSession.Highlight Method

Highlights the object in the canvas.

#### Syntax

```
void Highlight(
	Object pTarget
)
```

#### Parameters

pTarget  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Supported object types are IADOccurrence,
    IADTargetProxy, IADAssemblyConstraint,
    IADSketch, IAD3DSketch and all
    topological objects and design geometry objects.
    To deselect pass a null value for pTarget.



# EventManager.OnInitialize Event

Event notifying that Alibre Design has been initialized.

#### Syntax

```
public event EventManagerInitializeHandler OnInitialize
```

#### Value

EventManagerInitializeHandler



# EventManager.OnTerminate Event

Event notifying that Alibre Design has been terminated.

#### Syntax

```
public event EventManagerTerminateHandler OnTerminate
```

#### Value

EventManagerTerminateHandler



# IADSession.SaveNew Method

Saves a new, unsaved session to the specified folder location.

#### Syntax

```
void SaveNew(
	in Object pDestination
)
```

#### Parameters

pDestination  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   A windows folder path string if saving to Windows File System. See Remarks on saving to PDM Safe.

#### Remarks

The input pDestination (can be a Windows folder path string) is used to save a new session
and any of its sub-sessions that are being saved for the first time.

To save to PDM, you will use the same methods as with saving to the file system.
The pDestination can be IADPDMFolder, IADPDMSafeProject or IADPDMSafeLibrary interface objects or
the folder path String which can be extracted by calling the Reference
method on the IADPDMFolder, IADPDMSafeProject or IADPDMSafeLibrary interfaces.

To save to MFiles vaults, you will use the same methods as with saving to the file system.
The filepath should be passed with the following format: [MFiles drive letter]:\[Vault name]
(ie. "M:\MyVault")



# IADVector.IsEqualTo Method

Returns whether this vector is equal to the given vector.

#### Syntax

```
bool IsEqualTo(
	IADVector pVector
)
```

#### Parameters

pVector  IADVector
:   The IADVector to compare this one to.

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)  
The result of the equality comparison.



# ADEventChangeType Enumeration

#### Syntax

```
public enum ADEventChangeType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_UNSPECIFIED | 0 |  |
| AD\_ADD | 1 |  |
| AD\_REMOVE | 2 |  |
| AD\_MODIFY | 3 |  |
| AD\_UNSPECIFIED\_EXPLODED\_VIEW\_CHANGE | 16 |  |
| AD\_ADD\_BEGIN\_SKETCH\_MODE | 17 |  |
| AD\_MODIFY\_BEGIN\_SKETCH\_MODE | 19 |  |
| AD\_UNSPECIFIED\_CHANGE\_ACTIVE\_CONFIGURATION | 32 |  |
| AD\_ADD\_END\_SKETCH\_MODE | 33 |  |
| AD\_MODIFY\_END\_SKETCH\_MODE | 35 |  |
| AD\_UNSPECIFIED\_CHANGE\_TRANSFORM | 48 |  |
| AD\_ADD\_BEGIN\_SKETCH\_3D\_MODE | 49 |  |
| AD\_MODIFY\_BEGIN\_SKETCH\_3D\_MODE | 51 |  |
| AD\_ADD\_END\_SKETCH\_3D\_MODE | 65 |  |
| AD\_MODIFY\_END\_SKETCH\_3D\_MODE | 67 |  |
| AD\_MODIFY\_CHANGE\_EDITING\_CONTEXT | 83 |  |
| AD\_MODIFY\_VISIBILITY | 99 |  |
| AD\_MODIFY\_REFLECTIVITY | 115 |  |
| AD\_MODIFY\_COLOR | 131 |  |
| AD\_MODIFIY\_RENAME | 147 |  |
| AD\_MODIFY\_DESIGN\_BOOLEAN | 259 |  |
| AD\_MODIFY\_SAVE\_DESIGN\_PROPERTIES | 275 |  |
| AD\_MODIFY\_GEOMETRY\_VISIBILITY | 291 |  |
| AD\_MODIFY\_TRANSFORM | 307 |  |
| AD\_MODIFY\_OCCURRENCE\_CONFIGURATION | 323 |  |
| AD\_MODIFY\_RESTORE | 339 |  |



# IADSession.GeometryFactory Property

Returns the Geometry Factory.

#### Syntax

```
IADGeometryFactory GeometryFactory { get; }
```

#### Property Value

IADGeometryFactory



# IADSession.PreviewSnapshot Property

Returns a OLE picture object containing the preview snapshot bitmap for the session.

#### Syntax

```
Object PreviewSnapshot { get; }
```

#### Property Value

[Object](https://learn.microsoft.com/dotnet/api/system.object)



# IADRoot.removeMaterialLibrary Method

Remove Library.

#### Syntax

```
void removeMaterialLibrary(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)



# IADSession.SelectedObjects Property

Returns all selected entities in the session's browser as a collection of target proxies.

#### Syntax

```
IObjectCollector SelectedObjects { get; }
```

#### Property Value

IObjectCollector

#### Remarks

Applies only when session is being edited in GUI.



# IADGeometryFactory.CreateTransform Method

Create a new general 3D affine homogeneous transformation. Typically the user creates
a new transformation to specify the transformation of a part when inserting it into an assembly.

#### Syntax

```
IADTransformation CreateTransform(
	in Array pArray
)
```

#### Parameters

pArray  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   A 4x4 double array of the transformation.

#### Return Value

IADTransformation  
The created transformation object.

#### Remarks

The array passed in must have 16 doubles. The order of elements in the array
should be as shown below.

Vxi Vxj Vxk 0 Vyi Vyj Vyk 0 Vzi Vzj Vzk 0 Tx Ty Tz 1

The array elements 0, 1, 2 represent the X-vector, 4, 5, 6 represent the Y-vector, and
8, 9, 10 represent the Z-vector. And, the array elements 12, 13, 14 represents the translation
along X, Y and Z axes respectively.

Array elements 3, 7, 11 must be always zeroes, while array element 15 must be always 1.

#### Example

This Visual Basic sample shows how to create a transformation that mirrors across X-Axis.

```
' Holds Geometry Factory
Dim objADGeometryFactory As AlibreX.IADGeometryFactory

' Get Geometry Factory from Session object
Set objADGeometryFactory = objADSession.GeometryFactory

' Holds Transformation Array Data
Dim adblArray (15) As Double

adblArray(0) = -1
adblArray(1) = 0
adblArray(2) = 0
adblArray(3) = 0

adblArray(4) = 0
adblArray(5) = 1
adblArray(6) = 0
adblArray(7) = 0

adblArray(8) = 0
adblArray(9) = 0
adblArray(10) = 1
adblArray(11) = 0

adblArray(12) = 0
adblArray(13) = 0
adblArray(14) = 0
adblArray(15) = 1

' Holds Transformation
Dim objADTransformation As AlibreX.IADTransformation

' Create Transformation
Set objADTransformation = objADGeometryFactory.CreateTransform(adblArray())
```



# ADExtendedDesignProperty Enumeration

#### Syntax

```
public enum ADExtendedDesignProperty
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_COMMENT | 0 |  |
| AD\_COST\_CENTER | 1 |  |
| AD\_CREATED\_BY | 2 |  |
| AD\_CREATING\_APPLICATION | 3 |  |
| AD\_CREATED\_DATE | 4 |  |
| AD\_DOCUMENT\_NUMBER | 5 |  |
| AD\_ENG\_APPROVAL\_DATE | 6 |  |
| AD\_ENG\_APPROVED\_BY | 7 |  |
| AD\_ESTIMATED\_COST | 8 |  |
| AD\_KEYWORDS | 9 |  |
| AD\_LAST\_AUTHOR | 10 |  |
| AD\_LAST\_UPDATE\_DATE | 11 |  |
| AD\_MATERIAL | 12 |  |
| AD\_MFG\_APPROVED\_BY | 13 |  |
| AD\_MFG\_APPROVED\_DATE | 14 |  |
| AD\_MODIFIED | 15 |  |
| AD\_PRODUCT | 16 |  |
| AD\_RECEIVED\_FROM | 17 |  |
| AD\_REVISION | 18 |  |
| AD\_STOCK\_SIZE | 19 |  |
| AD\_SUPPLIER | 20 |  |
| AD\_TITLE | 21 |  |
| AD\_VENDOR | 22 |  |
| AD\_WEBLINK | 23 |  |



# IAutomationHook.Root Property

Returns the automation root.

#### Syntax

```
Object Root { get; }
```

#### Property Value

[Object](https://learn.microsoft.com/dotnet/api/system.object)



# IADRoot.IsMeshTypeFile Method

Returns boolean value which indicates whether input file is mesh type or not.

#### Syntax

```
bool IsMeshTypeFile(
	string filePath
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the file.

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)  
Returns boolean value which indicates whether input file is mesh type or not.



# IADRoot.ImportSTEPFileEx Method

Creates a new design or drawing session from contents of the input STEP file.

#### Syntax

```
IADSession ImportSTEPFileEx(
	string filePath,
	bool applyImportOptions,
	bool openEditor
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the STEP file to be imported.

applyImportOptions  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Flag specifying whether to apply file import options present in the user's profile.

openEditor  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Flag specifying whether to show the imported session in an editor window

#### Return Value

IADSession  

#### Remarks

This method can show the import options dialog and the editor only if Alibre's UI is running.



# IADRoot.ImportIGESFile Method

Creates a new design session from contents of input IGES file.

#### Syntax

```
IADSession ImportIGESFile(
	string filePath
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the file to be imported.

#### Return Value

IADSession  
Returns a session containing the imported file.



# IADRoot.Version Property

Returns the version number of the application.

#### Syntax

```
string Version { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IAutomationHook Properties

The IAutomationHook type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Root | Returns the automation root. |



# IAutomationHook Methods

The IAutomationHook type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Initialize | Initiates a new Alibre Design Automation client in GUI-less mode. |
|  | InitializeDebug | Initiates a new Alibre Design Automation client in Debug mode. |
|  | InitializeService | Initiates a new Alibre Design Automation client in Service mode |



# IAD2DPoint.X Property

Returns the X coordinate of the 2D point.

#### Syntax

```
double X { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADEventsCallback.OnTerminate Method

Event notifying that Alibre Design has been terminated.

#### Syntax

```
void OnTerminate()
```



# IADSessions Properties

The IADSessions type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of sessions in this collection. |
|  | Enum | Returns an enumerator for the collection. |



# ADGeometryType Enumeration

#### Syntax

```
public enum ADGeometryType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_LINE | 0 |  |
| AD\_CIRCLE | 1 |  |
| AD\_ELLIPSE | 2 |  |
| AD\_BSPLINE | 3 |  |
| AD\_CIRCULAR\_ARC | 5 |  |
| AD\_ELLIPTICAL\_ARC | 6 |  |
| AD\_PLANE | 7 |  |
| AD\_CYLINDER | 8 |  |
| AD\_CONE | 9 |  |
| AD\_SPHERE | 10 |  |
| AD\_TORUS | 11 |  |
| AD\_POINT | 12 |  |
| AD\_BSURF | 13 |  |
| AD\_SHAPEPATTERN | 14 |  |
| AD\_SKETCHTEXT | 15 |  |



# IADRoot.CreateEmptyAssemblyEx Method

Creates an empty assembly.

#### Syntax

```
IADAssemblySession CreateEmptyAssemblyEx(
	string name,
	bool openEditor
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name for the new assembly.

openEditor  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Flag specifying whether to show the newly created assembly in an editor window

#### Return Value

IADAssemblySession  
The interface to the new assembly.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_ASSEMBLY\_SESSION\_FAILED | Alibre failed to create the empty assembly session. |



# IADAddOns.ExportFile(String, IADSession, String) Method

#### Syntax

```
void ExportFile(
	string targetFileName,
	IADSession session,
	string optionFilePath
)
```

#### Parameters

targetFileName  [String](https://learn.microsoft.com/dotnet/api/system.string)

session  IADSession

optionFilePath  [String](https://learn.microsoft.com/dotnet/api/system.string)



# ADAccuracySetting Enumeration

This enumeration describes different levels of precision which can
be used to calculate the physical properties of a design with the method
PhsyicalProperties.

#### Syntax

```
[SerializableAttribute]
public enum ADAccuracySetting
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_LOW | 0 | One decimal point (0.1) |
| AD\_MEDIUM | 1 | Two decimal points (0.01) |
| AD\_HIGH | 2 | Three decimal points (0.0010) |
| AD\_VERY\_HIGH | 3 | Four decimal points (1.0E-4) |



# AutomationHook.Initialize Method

Initiates a new Alibre Design Automation client in GUI-less mode.

#### Syntax

```
public void Initialize(
	string serverURL,
	string loginID,
	string passwd,
	bool disableSecureMode,
	int unused
)
```

#### Parameters

serverURL  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Obsolete parameter, pass null or an empty string.

loginID  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Obsolete parameter, pass null or an empty string.

passwd  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Obsolete parameter, pass null or an empty string.

disableSecureMode  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   reserved

unused  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   reserved

#### Implements

IAutomationHookInitialize(String, String, String, Boolean, Int32)  

#### Example

This Visual Basic sample shows how to call the Initialize method.

```
' Requires reference to
' Windows Script Host Object Model

Dim objHook As AlibreX.AutomationHook
Set objHook = New AlibreX.AutomationHook
Call objHook.Initialize("", "", "", False, 0)
```



# AutomationHook.InitializeDebug Method

Initiates a new Alibre Design Automation client in Debug mode.

#### Syntax

```
public void InitializeDebug(
	string serverURL,
	string loginID,
	string passwd,
	bool disableSecureMode,
	int unused
)
```

#### Parameters

serverURL  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Obsolete parameter, pass null or an empty string.

loginID  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Obsolete parameter, pass null or an empty string.

passwd  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Obsolete parameter, pass null or an empty string.

disableSecureMode  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   reserved

unused  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   reserved

#### Implements

IAutomationHookInitialize(String, String, String, Boolean, Int32)



# AutomationHook.Root Property

Returns the interface to the root object in the Automation hierarchy.

#### Syntax

```
public Object Root { get; }
```

#### Property Value

[Object](https://learn.microsoft.com/dotnet/api/system.object)

#### Implements

IAutomationHookRoot  

#### Example

This Visual Basic sample shows how to get the Root.

```
' Connect to running Alibre Design client
Dim objHook As AlibreX.AutomationHook
Dim objRoot As AlibreX.IADRoot
Set objHook = GetObject(, "AlibreX.AutomationHook")
Set objRoot = objHook.Root
```



# IADRoot.Repositories Property

Returns a collection of accessible repositories.

#### Syntax

```
IADRepositories Repositories { get; }
```

#### Property Value

IADRepositories

#### Remarks

This method is obsolete as of V11 of Alibre Design.



# IADRoot.RunAgent Method

Obsolete

#### Syntax

```
void RunAgent(
	string className
)
```

#### Parameters

className  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Remarks

This method is obsolete as of V11 of Alibre Design.



# IADRoot.ImportIGESFileEx Method

Creates a new design or drawing session from contents of the input IGES file.

#### Syntax

```
IADSession ImportIGESFileEx(
	string filePath,
	bool applyImportOptions,
	bool openEditor
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the IGES file to be imported.

applyImportOptions  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Flag specifying whether to apply file import options present in the user's profile.

openEditor  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Flag specifying whether to show the imported session in an editor window

#### Return Value

IADSession  

#### Remarks

This method can show the import options dialog and the editor only if Alibre's UI is running.



# IADRoot.OpenFileEx Method

Opens a Alibre Design file from the file system.

#### Syntax

```
IADSession OpenFileEx(
	string filePath,
	bool openEditor
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The full path of the file.

openEditor  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Flag specifying whether to show the opened file in an editor window

#### Return Value

IADSession  
Returns a session of the opened file.



# ADHelixType Enumeration

This enumeration describes the different types of helices which are used to create
Helical Features. The
HelixType determines which parameters
must be queried to find the definition of the helix.

#### Syntax

```
public enum ADHelixType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_Height\_Revolution | 0 | Height and Revolution: A helix is generated by specifying the overall feature height as well as the number of helical revolutions within the specified height. |
| AD\_Height\_Pitch | 1 | Height and Pitch: A helix is generated by specifying the overall feature height as well as pitch. The pitch is defined as the distance from one point on the helix to a corresponding point on the next revolution measured parallel to the axis. |
| AD\_Revolution\_Pitch | 2 | Revolution and Pitch: A helix is generated by specifying the number of revolutions as well the pitch. |
| AD\_Spiral | 3 | Spiral: A flat helix is generated by specifying the number of revolutions as well as pitch. |



# ADAssemblyConstraintParameterRole Enumeration

This enumeration identifies the different roles a parameter may play in an Assembly constraints.
The enum can be use to obtained the parameter which plays the roll for a particular constraint.
ParameterEx property.

#### Syntax

```
public enum ADAssemblyConstraintParameterRole
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_UNKNOWN\_ROLE | 0 | Unknown; generally indicates an error. |
| AD\_EQUALITY\_ROLE | 1 | The constraint uses a single parameter with an equality relationship. |
| AD\_MINIMUM\_ROLE | 2 | The parameter represents a minimum value. |
| AD\_MAXIMUM\_ROLE | 3 | The parameter represents a maximum value. |
| AD\_GEAR\_RATIO\_1\_ROLE | 4 | The parameter corresponds to the first ratio of a gear constraint. |
| AD\_GEAR\_RATIO\_2\_ROLE | 5 | The parameter corresponds to the second ratio of a gear constraint. |



# ADObjectType Enumeration

#### Syntax

```
public enum ADObjectType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_ROOT | 1 |  |
| AD\_REPOSITORY | 2 |  |
| AD\_FOLDER | 3 |  |
| AD\_FOLDER\_ITEM | 4 |  |
| AD\_VERSION | 5 |  |
| AD\_SESSION | 6 |  |
| AD\_TEAM | 7 |  |
| AD\_ROLE | 8 |  |
| AD\_USER | 9 |  |
| AD\_UNKNOWN | -1 |  |
| AD\_PARAMETER | 10 |  |
| AD\_OCCURRENCE | 11 |  |
| AD\_DESIGN\_POINT | 12 |  |
| AD\_DESIGN\_AXIS | 13 |  |
| AD\_DESIGN\_PLANE | 14 |  |
| AD\_TOPOLOGY | 15 |  |
| AD\_SKETCH | 16 |  |
| AD\_SKETCH\_FIGURE | 17 |  |
| AD\_PART\_FEATURE | 18 |  |
| AD\_GEOMETRY | 19 |  |
| AD\_DESIGN\_SURFACE | 20 |  |
| AD\_DIMENSION | 21 |  |
| AD\_3D\_SKETCH | 22 |  |
| AD\_ASSEMBLY\_CONSTRAINT | 23 |  |
| AD\_CONFIGURATION | 24 |  |
| AD\_EXPLODED\_VIEW | 25 |  |
| AD\_EXPLODED\_VIEW\_STEP | 26 |  |
| AD\_SAVED\_VIEW | 27 |  |
| AD\_BOM\_COLUMN | 28 |  |
| AD\_BOM\_ROW | 29 |  |
| AD\_DATA\_FONT | 30 |  |
| AD\_3D\_SKETCH\_FIGURE | 31 |  |
| AD\_SHEET | 32 |  |
| AD\_DRAWING\_VIEW | 33 |  |
| AD\_SKETCH\_CONSTRAINT | 34 |  |
| AD\_DESIGN\_MESH | 35 |  |
| AD\_ASSEMBLY\_FEATURE | 36 |  |
| AD\_MATERIAL | 37 |  |
| AD\_MATERIAL\_LIBRARY\_FOLDER | 38 |  |
| AD\_MATERIAL\_LIBRARY | 39 |  |



# IADSession.Type Property

Returns a pre-defined constant that identifies the type of this object. (AD\_SESSION)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# AutomationHook Constructor

Initialize a new instance of the AutomationHook.

#### Syntax

```
public AutomationHook()
```

#### Remarks

This should only be used when Alibre is not already running.



# IADRoot.Import3DMFile Method

Creates a new design session from the contents of the input Open Nurbs (3DM) file.

#### Syntax

```
IADSession Import3DMFile(
	string filePath
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the file to be imported.

#### Return Value

IADSession  
Returns a session containing the imported file.



# IADRoot.NewObjectCollector Method

Creates a new empty collection object used for building a collection of objects of a given type.

#### Syntax

```
IObjectCollector NewObjectCollector()
```

#### Return Value

IObjectCollector  
An empty IObjectCollector.



# IADEventsCallback Methods

The IADEventsCallback type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | OnInitialize | Event notifying that Alibre Design has been initialized. |
|  | OnModelLoadComplete | Event notifying that model is loaded completely. |
|  | OnSessionChange | Event notifying that a session has been modified |
|  | OnSessionClose | Event notifying that a session has been closed. |
|  | OnSessionOpen | Event notifying that a new top level session has been opened. |
|  | OnTerminate | Event notifying that Alibre Design has been terminated. |



# IADRoot.CreateEmptyPart Method

Creates a new empty part.

#### Syntax

```
IADPartSession CreateEmptyPart(
	string name,
	bool isSheetMetal
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name for the new part.

isSheetMetal  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, a Sheel Metal Part will be created; otherwise,
    a regular Part is created.

#### Return Value

IADPartSession  
The interface to the new part.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_PART\_SESSION\_FAILED | Alibre failed to create the empty part session. |

#### Example

This Visual Basic sample shows how to use the CreateEmptyPart method.

```
' Holds Session object
Dim objADSession As AlibreX.IADSession

' Create a new part using CreateEmptyPart() on Root object.
' Pass IsSheetMetal flag as False to create a Part Session
Set objADSession = m_objADRoot.CreateEmptyPart("NewPart", False)

' Verify Name on the new Session
Debug.Print "Session.Name = " & objADSession.Name
```



# IADRoot Interface

The root object of the automation hierarchy.

#### Syntax

```
public interface IADRoot
```

The IADRoot type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | AlibreAddOns | Returns the Add On context which is used to perform add on operation by automation. |
|  | AppTitle | Returns the version number of the application. |
|  | EventManager | Returns the event manager object used for registering event callbacks. |
|  | InstalledDrawingTemplates | Returns an array of the names of installed Drawing Templates. |
|  | LanguageForResources | Returns the language Alibre is currently running on. |
|  | ListedUsers | Returns a collection of users available for collaboration. |
|  | MaterialLibraries | Returns a collection of material library. |
|  | Materials | Returns a collection of materials in the material library. |
|  | Repositories | Returns a collection of accessible repositories. |
|  | Sessions | Returns a collection of open sessions. |
|  | Teams | Returns a collection of accessible teams. |
|  | TopmostSession | Returns an interface to the session whose window is the highest in the Z-order of all Alibre session windows. If no sessions are open, this property will be null. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_ROOT) of this object. |
|  | User | Returns interface describing user who initiated the client. |
|  | VaultInfo | Returns the Vault Information interface. |
|  | Version | Returns the version number of the application. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | BindReferenceToObject | Returns the interface to an object given its unique, persistent reference-string. |
|  | ConnectToPDM | Connect to a PDM Server. |
|  | CreateEmptyAssembly | Creates an empty assembly. |
|  | CreateEmptyAssemblyEx | Creates an empty assembly. |
|  | CreateEmptyDrawing | Creates a new empty Drawing. |
|  | CreateEmptyDrawingEx | Creates a new empty Drawing. |
|  | CreateEmptyGlobalParameters | Creates a new empty Global Parameters workspace. |
|  | CreateEmptyGlobalParametersEx | Creates a new empty Global Parameters workspace. |
|  | CreateEmptyPart | Creates a new empty part. |
|  | CreateEmptyPartEx | Creates a new empty part. |
|  | createMaterialLibrary | Create a new Material Library. |
|  | CreateTeam | Creates a new team and automatically adds the owner to it. |
|  | CreateUser | Creates an arbitrary user given a name. |
|  | EncryptPassword | Generates an encrypted password from a plain text one. |
|  | GetActiveServerConnection | Returns the existing PDM Server connection in the UI. |
|  | GetAgentProperty | Obsolete |
|  | GetGuidAndConstituentInformation | Get the item GUID and constituent information (GUIDs, names and relative file paths) for the file specified in the path. |
|  | GetGuidAndTPConstituentsData | Get the item GUID and TP constituents data (GUIDs, names and relative file paths) for the file specified in the path. |
|  | GetRepositoryByName | Returns an interface to the repository identified by name. |
|  | GetRepositoryReference | Returns the repository reference for a given file if it exists in the repository. |
|  | GetTeamByName | Returns interface describing existing team identified by name. |
|  | GetUserByName | Returns an interface describing the existing user identified by name. |
|  | Import3DMFile | Creates a new design session from the contents of the input Open Nurbs (3DM) file. |
|  | ImportDWGFile | Creates a new drawing session from contents of input DWG file. |
|  | ImportDXFFile | Creates a new drawing session from contents of input DXF file. |
|  | ImportIGESFile | Creates a new design session from contents of input IGES file. |
|  | ImportIGESFileEx | Creates a new design or drawing session from contents of the input IGES file. |
|  | ImportImages | Creates a new drawing session with the image files as sheets. |
|  | ImportNonNative3DFile | Creates a new design session from contents of input file. |
|  | ImportSATFile | Creates a new design session from contents of input SAT file. |
|  | ImportSATFileEx | Creates a new design session from contents of the input SAT file. |
|  | ImportSTEPFile | Creates a new design or drawing session from contents of the input STEP file. |
|  | ImportSTEPFileEx | Creates a new design or drawing session from contents of the input STEP file. |
|  | IsMeshTypeFile | Returns boolean value which indicates whether input file is mesh type or not. |
|  | IsOpenedFromRepository | Determines if a file (specified by its full disk path) is opened from the repository. |
|  | NewNotificationSelector | Creates a new notification selector object used for specifying the notifications associated with a repository resource. |
|  | NewObjectCollector | Creates a new empty collection object used for building a collection of objects of a given type. |
|  | NewPermissionSelector | Creates a new permission selector object used for setting access rights to a repository resource. |
|  | OpenFile | Opens a Alibre Design file from the file system. |
|  | OpenFileEx | Opens a Alibre Design file from the file system. |
|  | OpenFileFromSafe | Opens the latest file item from the PDM Safe. |
|  | OpenFileWithUI | Opens a file from the file system when Alibre's UI is running. |
|  | RegisterAgent | Obsolete |
|  | removeMaterialLibrary | Remove Library. |
|  | RestorePackage | Restores a Alibre Package File (.AD\_PKG) to its expanded constituent native Alibre files. |
|  | RunAgent | Obsolete |
|  | SendMessage | Sends a notification message to a collection of teams and/or users. |
|  | SetAgentProperty | Obsolete |
|  | Terminate | Terminates the Automation client. |
|  | TerminateAll | Terminates the Automation client. If Alibre is launched from automation, TerminalAll() will safely terminate the automated process, even if called from a different thread. |



# IADRoot.EventManager Property

Returns the event manager object used for registering event callbacks.

#### Syntax

```
Object EventManager { get; }
```

#### Property Value

[Object](https://learn.microsoft.com/dotnet/api/system.object)



# ADConfigurationLockType Enumeration

#### Syntax

```
public enum ADConfigurationLockType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_SUPPRESS\_NEW\_FEATURES | 1 |  |
| AD\_SUPPRESS\_NEW\_COMPONENTS | 2 |  |
| AD\_SUPPRESS\_NEW\_CONSTRAINTS | 4 |  |
| AD\_LOCK\_PARAMETER\_VALUES | 8 |  |
| AD\_LOCK\_PROPERTY\_VALUES | 16 |  |
| AD\_LOCK\_COMPONENT\_CONFIG | 32 |  |
| AD\_HIDE\_NEW\_INCLUSIONS | 64 |  |
| AD\_HIDE\_NEW\_DESIGN\_GEOMETRY | 128 |  |
| AD\_HIDE\_NEW\_ANNOTATIONS | 256 |  |
| AD\_HIDE\_NEW\_SKETCHES | 512 |  |
| AD\_LOCK\_COLOR\_PROPERTIES | 1,024 |  |
| AD\_LOCK\_ACTIVE\_SECTION\_VIEW | 2,048 |  |



# ADDirectionType Enumeration

This enumeration identifies the different possible direction types for creating
extrude boss or
extrude cut features.

#### Syntax

```
public enum ADDirectionType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_ALONG\_NORMAL | 0 | The direction is along the normal of the sketch plane. |
| AD\_ALONG\_AXIS | 1 | The direction is along a specified axis. |
| AD\_ALONG\_EDGE | 2 | The direction is along a specified edge. |



# ADBooleanOperator Enumeration

#### Syntax

```
public enum ADBooleanOperator
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_NULL | 0 |  |
| AD\_UNION | 1 |  |
| AD\_SUBTRACTION | 2 |  |
| AD\_INTERSECTION | 3 |  |



# IADRoot.AlibreAddOns Property

Returns the Add On context which is used to perform add on operation by automation.

#### Syntax

```
IADAddOns AlibreAddOns { get; }
```

#### Property Value

IADAddOns



# IADRoot.ImportSTEPFile Method

Creates a new design or drawing session from contents of the input STEP file.

#### Syntax

```
IADSession ImportSTEPFile(
	string filePath
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the file to be imported.

#### Return Value

IADSession  
Returns a session containing the imported file.



# IADRoot.SetAgentProperty Method

Obsolete

#### Syntax

```
void SetAgentProperty(
	string name,
	string value
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

value  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Remarks

This method is obsolete as of V11 of Alibre Design.



# IADVector.X Property

Gets the X direction component.

#### Syntax

```
double X { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADSession.Save Method

Saves modified session and sub-sessions, if any, to their original folder locations.

#### Syntax

```
void Save()
```

#### Remarks

Any sub-sessions that are being saved for the first time will get saved to this session s folder location.
Use SaveNew if a new session is being saved (i.e., for the first time).



# ADSecureObjectType Enumeration

#### Syntax

```
public enum ADSecureObjectType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_SECURE\_FOLDER | 1 |  |
| AD\_SECURE\_DESIGN | 2 |  |
| AD\_SECURE\_DRAWING | 4 |  |
| AD\_SECURE\_SYMBOL | 8 |  |
| AD\_SECURE\_FEATURE | 16 |  |
| AD\_SECURE\_EXTERNAL | 32 |  |
| AD\_SECURE\_BOMTABLE | 64 |  |



# IADRoot.BindReferenceToObject Method

Returns the interface to an object given its unique, persistent reference-string.

#### Syntax

```
Object BindReferenceToObject(
	string referenceString,
	ADObjectType objectType
)
```

#### Parameters

referenceString  [String](https://learn.microsoft.com/dotnet/api/system.string)

objectType  ADObjectType

#### Return Value

[Object](https://learn.microsoft.com/dotnet/api/system.object)  

#### Remarks

This method is obsolete as of V11 of Alibre Design.



# IADRoot.Sessions Property

Returns a collection of open sessions.

#### Syntax

```
IADSessions Sessions { get; }
```

#### Property Value

IADSessions



# EventManager.OnSessionOpen Event

Event notifying that a new top level session has been opened.

#### Syntax

```
public event EventManagerSessionOpenHandler OnSessionOpen
```

#### Value

EventManagerSessionOpenHandler



# IADRoot.GetGuidAndTPConstituentsData Method

Get the item GUID and TP constituents data (GUIDs, names and relative file paths) for the file specified in the path.

#### Syntax

```
void GetGuidAndTPConstituentsData(
	string filePath,
	out string guid,
	out IObjectCollector constituentGuids,
	out IObjectCollector constituentNames,
	out IObjectCollector constituentAbsoluteTPLocations,
	out IObjectCollector constituentRelativeTPLocations
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)

guid  [String](https://learn.microsoft.com/dotnet/api/system.string)

constituentGuids  IObjectCollector

constituentNames  IObjectCollector

constituentAbsoluteTPLocations  IObjectCollector

constituentRelativeTPLocations  IObjectCollector



# IADVector.Z Property

Gets the Z direction component.

#### Syntax

```
double Z { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADSession.CreatePackage Method

#### Syntax

```
void CreatePackage(
	string filePath
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)



# IADGeometryFactory Interface

IADGeometryFactory allows for the creation of points, vectors, and transformations,
which can be passed as arguments to other methods in the Alibre API.

#### Syntax

```
public interface IADGeometryFactory
```

The IADGeometryFactory type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Create2DPoint | Creates a 2D point from the given coordinates. |
|  | CreateIdentityTransform | Create an identity transformation. |
|  | CreatePoint | Creates a 3D point from the given coordinates. |
|  | CreateRotationTransform | Create a rotation transformation around an axis (position, direction) by a specified angle. |
|  | CreateTransform | Create a new general 3D affine homogeneous transformation. Typically the user creates a new transformation to specify the transformation of a part when inserting it into an assembly. |
|  | CreateTransformByVariantArray | Creates a transformation with 4X4 Variant array. |
|  | CreateTranslationTransformAlongVector | Create a translation transformation using a vector. |
|  | CreateTranslationTransformByXYZ | Create a translation transformation using X, Y, Z direction components. |
|  | CreateUniformScalingTransform | Create a Unifom Scaling Transformation. Scale factor has to be more than or equal to 0.000001 |
|  | CreateVector | Creates a 3D vector from the given direction components. |



# IADRoot.OpenFileWithUI Method

Opens a file from the file system when Alibre's UI is running.

#### Syntax

```
void OpenFileWithUI(
	string filePath
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The full path of the file.

#### Remarks

This method will show the version status page when constituents are out
of date or missing.



# IADEventsCallback.OnSessionOpen Method

Event notifying that a new top level session has been opened.

#### Syntax

```
void OnSessionOpen(
	IADSession pSession
)
```

#### Parameters

pSession  IADSession
:   The session which was opened.



# IADSession.Root Property

Returns the automation root.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADRoot.User Property

Returns interface describing user who initiated the client.

#### Syntax

```
IADUser User { get; }
```

#### Property Value

IADUser

#### Remarks

This method is obsolete as of V11 of Alibre Design.



# IADSession.ConstituentFilePaths Property

Returns file path strings for other Design files that are referenced by this session.

#### Syntax

```
IObjectCollector ConstituentFilePaths { get; }
```

#### Property Value

IObjectCollector



# ADParameterType Enumeration

This enumeration identifies the different types of parameters that an
IADParameter can represent. These types
describe what the value of the parameter represents, and also indicate
what units are possible for the parameter.

#### Syntax

```
public enum ADParameterType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_DISTANCE | 0 | A parameter containing a distance measurement. Valid unit types for this parameter type include AD\_MILLIMETERS, AD\_CENTIMETERS, AD\_METERS, AD\_INCHES, AD\_FEET, and AD\_FEET\_INCHES. |
| AD\_ANGLE | 1 | A paramter containing an angular measurement. Valid unit types for this parameter type include AD\_RADIANS, AD\_DEGREES, AD\_DEGREES\_MINUTES, and AD\_DEGREES\_MINUTES\_SECONDS. |
| AD\_COUNT | 2 | A parameter containing a value describing a quantity. This parameter does not have units (AD\_UNITLESS) and is always a whole number. |
| AD\_SCALE | 3 | A parameter containing a scale factor. This parameter does not have units. (AD\_UNITLESS) |



# IADSession.Name Property

Returns this session's name.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IAD2DPoint Properties

The IAD2DPoint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | X | Returns the X coordinate of the 2D point. |
|  | Y | Returns the Y coordinate of the 2D point. |



# IADAddOns.ImportFile Method

#### Syntax

```
IADSession ImportFile(
	string filePath,
	IADSession session
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)

session  IADSession

#### Return Value

IADSession



# IADSession Methods

The IADSession type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | BindKeyToItem | Given a Persistent Key, returns the corresponding Occurrence/Topology element/Sketch. |
|  | Close | Closes the session and optionally saves before closing. |
|  | CreatePackage |  |
|  | Highlight | Highlights the object in the canvas. |
|  | NewTargetProxy | Creates a new TargetProxy for the given target and the occurrence |
|  | Save | Saves modified session and sub-sessions, if any, to their original folder locations. |
|  | SaveAll | Saves a copy of the session and all sub-sessions to the directory indicated by the destination parameter. |
|  | SaveAs | Saves the session to create a new copy with the given name. |
|  | SaveCurrentViewSnapshot | Saves the snapshot of the graphic canvas for current view in the session, at the given location and of the given size. |
|  | SaveNew | Saves a new, unsaved session to the specified folder location. |
|  | Select | Selects all objects passed in pEntities. |
|  | SelectedObjectsEx | Returns all selected entities in the session's browser as a collection of target proxies, and sets the parameter lastSelectedPoint to last point in the user clicked to make the selection. |
|  | UpdatePreviewSnaphot | Captures the canvas image displayed for this session and silently saves it as the file snapshot property |



# IADRoot.ImportNonNative3DFile Method

Creates a new design session from contents of input file.

#### Syntax

```
IADSession ImportNonNative3DFile(
	string filePath,
	ADUnits unitCodeForMeshFile
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the file to be imported.

unitCodeForMeshFile  ADUnits
:   The unit code for mesh file.

#### Return Value

IADSession  
Returns a session containing the imported file.



# IADTransformation.Decompose Method

Returns the decomposed transform data for this transform.

#### Syntax

```
IDecomposedTransformData Decompose()
```

#### Return Value

IDecomposedTransformData  
Returns IDecomposedTransformData

#### Example

This sample demonstrates using the decomposed transformation to get the components of the transformation without having to work with the matrix directly.

```
// Get an IADTransfromation (in this case, from an IADOccurrence)
IADTransformation transform = occurrence.LocalTransform;
IDecomposedTransformData decomposed = transform.Decompose();
Console.WriteLine("Rotate:    (" + decomposed.RotateX + ", " + 
                  decomposed.RotateY + ", " + decomposed.RotateZ + ")");
Console.WriteLine("Scale:     (" + decomposed.ScaleX + ", " +
                  decomposed.ScaleY + ", " + decomposed.ScaleZ + ")");
Console.WriteLine("Translate: (" + decomposed.TranslateX + ", " +
                  decomposed.TranslateY + ", " + decomposed.TranslateZ + ")");
Console.WriteLine("Shear:     (" + decomposed.ShearXY + ", " +
                  decomposed.ShearYZ + ", " + decomposed.ShearZX + ")");
```



# IADGeometryFactory.CreateIdentityTransform Method

Create an identity transformation.

#### Syntax

```
IADTransformation CreateIdentityTransform()
```

#### Return Value

IADTransformation  
A new identity transformation.



# IADRoot.NewNotificationSelector Method

Creates a new notification selector object used for specifying the notifications associated with a repository resource.

#### Syntax

```
INotificationSelector NewNotificationSelector()
```

#### Return Value

INotificationSelector  

#### Remarks

This method is obsolete as of V11 of Alibre Design.



# IAD2DPoint Interface

IAD2DPoint represents a point in a 2D coordinate system.

#### Syntax

```
public interface IAD2DPoint
```

The IAD2DPoint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | X | Returns the X coordinate of the 2D point. |
|  | Y | Returns the Y coordinate of the 2D point. |



# IADSession.Parameters Property

Returns a collection of parameters for this session.

#### Syntax

```
IADParameters Parameters { get; }
```

#### Property Value

IADParameters



# DIEnum.NextElement Method

Returns the next element of the enumerator.

#### Syntax

```
Object NextElement()
```

#### Return Value

[Object](https://learn.microsoft.com/dotnet/api/system.object)



# ADAssemblyFeatureType Enumeration

This enumeration describes the different types of Features available in an Assembly.
By querying the FeatureType property
of IADAssemblyFeature, you can which derived type to
cast it to, which will have additional methods and properties to query the feature.

#### Syntax

```
public enum ADAssemblyFeatureType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_EXTRUSION\_FEATURE | 0 | IADAssemblyExtrusionFeature |
| AD\_HOLE\_FEATURE | 1 | IADAssemblyHoleFeature |



# ADMaterialPropertyKey Enumeration

This enumeration lists the possible sub types or derived types of a Alibre object.
These types describe the property of the material.
All the Material Properties are represented in SI unit.

#### Syntax

```
public enum ADMaterialPropertyKey
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| DENSITY\_PROPERTY | 0 | Density - Kg/m^3 |
| HARDNESS\_BRINELL\_PROPERTY | 1 | Hardness-Brinell - (No unit) |
| TENSILE\_STRENGTH\_ULTIMATE\_PROPERTY | 2 | Tensile-Strength-Ultimate - MPa |
| TENSILE\_STRENGTH\_YEILD\_PROPERTY | 3 | Tensile-Strength-Yield - MPa |
| MODULUS\_OF\_ELASTICITY\_PROPERTY | 4 | Modulus-of-Elasticity - MPa |
| POISSONS\_PROPERTY | 5 | Poissons - (No unit) |
| SHEARMODULUS\_PROPERTY | 6 | ShearModulus - MPa |
| SHEARSTRENGTH\_PROPERTY | 7 | ShearStrength - MPa |
| RESISTIVITY\_PROPERTY | 8 | Resistivity - ohm-m |
| CTE\_PROPERTY | 9 | CTE - µm/m-°C |
| SPECIFICHEAT\_PROPERTY | 10 | SpecificHeat - J/g-°C |
| THERMALCONDUCTIVITY\_PROPERTY | 11 | ThermalConductivity - W/m-K |



# ADPitchType Enumeration

This enumeration describes the different pitch types available
for Helical Boss/Cut features.

#### Syntax

```
public enum ADPitchType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_Constant | 0 | Constant: A constant distance is used for the Pitch. For this pitch type, the parameters PitchRatio and PitchEnd will not exist. |
| AD\_VariableRatio | 1 | Variable Ratio: The pitch is changed from start to finish in a ratio such that the pitch at the end will be: ratio \* start pitch. For this pitch type, the parameter PitchEnd will not exist. |
| AD\_VariableEnd | 2 | Variable End: The pitch at the start and end of the helix are specified. For this pitch type, the parameter PitchRatio will not exist. |



# IADTransformation Methods

The IADTransformation type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Apply | Applies this transform on the given transform and returns the resultant transform. |
|  | Array | Returns the elements of the transform as a one-dimensional array containing 16 doubles. This array represents a 4x4 matrix. |
|  | Decompose | Returns the decomposed transform data for this transform. |
|  | Inverse | Returns the inverse transform of this transform. This transform remains unchanged. |
|  | IsEqualTo | Returns whether this transfrom is equal to the given transform. |
|  | ToString | Returns the transform data as a string. |



# ADWrapFocusType Enumeration

This enumeration describes the different types of focus used by
Wrap Features. The
FocusType controls
how the sketch is wrapped..

#### Syntax

```
public enum ADWrapFocusType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_NEAREST\_POINT | 0 |  |
| AD\_SKETCH\_CENTER | 1 |  |
| AD\_SKETCH\_PLANE | 2 |  |



# ADAssemblyConstraintBoundType Enumeration

This enumeration identifies the different types of Assembly constraint bounds.

#### Syntax

```
public enum ADAssemblyConstraintBoundType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_UNKNOWN\_TYPE | 0 | Unknown; generally indicates an error. |
| AD\_LOGICAL\_TYPE | 1 | No value or implied value is zero. For example parallel or coincident. |
| AD\_EQUALITY\_TYPE | 2 | Constraint has a value, equal to the Parameter. |
| AD\_GREATER\_THAN\_EQUAL\_TYPE | 3 | Constraint has a value, that is greater than or equal to the Parameter. |
| AD\_LESS\_THAN\_EQUAL\_TYPE | 4 | Constraint has a value, this less than or equal to the Parameter. |
| AD\_BOUNDED\_TYPE | 5 | Constraint has value that is bounded (inclusive) by two Parameters. |



# ADTopologyType Enumeration

The ADTopologyType enumeration contains items for each of the different types
of Topology objects in the Alibre API. Each object whose Type property returns
AD\_TOPOLOGY also has a TopologyType
property which returns a value from this enumeration.

#### Syntax

```
public enum ADTopologyType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_BODY | 0 | IADBody |
| AD\_LUMP | 1 | IADLump |
| AD\_SHELL | 2 | IADShell |
| AD\_FACE | 3 | IADFace |
| AD\_LOOP | 4 | IADLoop |
| AD\_COEDGE | 5 | IADCoedge |
| AD\_EDGE | 6 | IADEdge |
| AD\_VERTEX | 7 | IADVertex |



# IADSession Properties

The IADSession type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ConstituentFilePaths | Returns file path strings for other Design files that are referenced by this session. |
|  | FilePath | Returns the location on disk of where the file was last saved. If unsaved, returns null. |
|  | GeometryFactory | Returns the Geometry Factory. |
|  | Identifier | Returns the session's unique identifier. |
|  | IsGUIVisible | Returns True if the GUI for this session is visible. |
|  | Name | Returns this session's name. |
|  | Parameters | Returns a collection of parameters for this session. |
|  | PreviewSnapshot | Returns a OLE picture object containing the preview snapshot bitmap for the session. |
|  | Root | Returns the automation root. |
|  | SelectedObjects | Returns all selected entities in the session's browser as a collection of target proxies. |
|  | SessionType | Returns a pre-defined constant that identifies whether this session is a part or assembly or drawing session. |
|  | TimeStamp | Returns time stamp of this session; the time stamp changes when changes are saved to the session. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SESSION) |



# IADGeometryFactory.CreateTranslationTransformByXYZ Method

Create a translation transformation using X, Y, Z direction components.

#### Syntax

```
IADTransformation CreateTranslationTransformByXYZ(
	double translationX,
	double translationY,
	double translationZ
)
```

#### Parameters

translationX  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X component of the translation.

translationY  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y component of the translation.

translationZ  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Z component of the translation.

#### Return Value

IADTransformation  
A new translation transformation.

#### Example

This sample demonstrates creating and using a translation transformation.

```
// Get the current transform for a valid IADDesignSurface object.
IADTransformation surfaceTransform = designSurface.Transform;
// Use the geometry factory to create the translation transform that will move 
// the surface 5 cm in the X-direction.
IADTransformation translateTransform = 
      designSession.GeometryFactory.CreateTranslationTransformByXYZ(5, 0, 0);
// Apply the translation transform to the surface's original transform.
surfaceTransform = surfaceTransform.Apply(translateTransform);
// Set the design surface's transfromation to the translated transformation.
designSurface.Transform = surfaceTransform;
```



# IADRoot.GetActiveServerConnection Method

Returns the existing PDM Server connection in the UI.

#### Syntax

```
IADPDMServerConnection GetActiveServerConnection()
```

#### Return Value

IADPDMServerConnection



# IADRoot.ImportSATFile Method

Creates a new design session from contents of input SAT file.

#### Syntax

```
IADSession ImportSATFile(
	string filePath
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the file to be imported.

#### Return Value

IADSession  
Returns a session containing the imported file.



# IAutomationHook.Initialize Method

Initiates a new Alibre Design Automation client in GUI-less mode.

#### Syntax

```
void Initialize(
	string serverURL,
	string loginID,
	string passwd,
	bool disableSecureMode,
	int unused
)
```

#### Parameters

serverURL  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Obsolete parameter, pass null or an empty string.

loginID  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Obsolete parameter, pass null or an empty string.

passwd  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Obsolete parameter, pass null or an empty string.

disableSecureMode  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Reserved

unused  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   Reserved



# IADRoot.CreateEmptyDrawing Method

Creates a new empty Drawing.

#### Syntax

```
IADDrawingSession CreateEmptyDrawing(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name for the new Drawing.

#### Return Value

IADDrawingSession  
The interface to the new Drawing session.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_CREATE\_DRAWING\_SESSION\_FAILED | Alibre failed to create the empty drawing session. |



# IADRoot.InstalledDrawingTemplates Property

Returns an array of the names of installed Drawing Templates.

#### Syntax

```
string[] InstalledDrawingTemplates { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# EventManager.SessionChangeHandler Delegate

#### Syntax

```
public delegate void SessionChangeHandler(
	IADSession pSession,
	ref Array pModifiedItems,
	ref Array changeType
)
```

#### Parameters

pSession  IADSession

pModifiedItems  [Array](https://learn.microsoft.com/dotnet/api/system.array)

changeType  [Array](https://learn.microsoft.com/dotnet/api/system.array)



# EventManager.TerminateHandler Delegate

#### Syntax

```
public delegate void TerminateHandler()
```



# StdError Enumeration

The standard error enumeration.

#### Syntax

```
public enum StdError
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| STD\_E\_INVALIDARG | -2,147,024,809 | One or more arguments are invalid |
| STD\_E\_OUTOFMEMORY | -2,147,024,882 | Ran out of memory |
| STD\_E\_ACCESSDENIED | -2,147,024,891 | General access denied error |
| STD\_DISP\_E\_PARAMNOTOPTIONAL | -2,147,352,561 | Parameter not optional |
| STD\_DISP\_E\_BADPARAMCOUNT | -2,147,352,562 | Invalid number of parameters |
| STD\_DISP\_E\_BADINDEX | -2,147,352,565 | Invalid index |
| STD\_DISP\_E\_OVERFLOW | -2,147,352,566 | Out of present range |
| STD\_DISP\_E\_EXCEPTION | -2,147,352,567 | Exception occurred |
| STD\_DISP\_E\_UNKNOWNNAME | -2,147,352,570 | Unknown name |
| STD\_DISP\_E\_TYPEMISMATCH | -2,147,352,571 | Type mismatch |
| STD\_E\_UNEXPECTED | -2,147,418,113 | Unexpected failure |
| STD\_E\_FAIL | -2,147,467,259 | Unspecified error |
| STD\_E\_ABORT | -2,147,467,260 | Operation aborted |
| STD\_E\_POINTER | -2,147,467,261 | Invalid Pointer |
| STD\_E\_NOTIMPL | -2,147,467,263 | Not implemented |



# IADEventsCallback.OnSessionChange Method

Event notifying that a session has been modified

#### Syntax

```
void OnSessionChange(
	IADSession pSession,
	in Array pModifiedItems,
	in Array changeType
)
```

#### Parameters

pSession  IADSession
:   The session which was changed.

pModifiedItems  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   An array of the items which changed.

changeType  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   An array of change notes describing the changes.
    The change notes are predefined constants defined by ADEventChangeType.



# IADSession.Close Method

Closes the session and optionally saves before closing.

#### Syntax

```
void Close(
	bool saveSession = false
)
```

#### Parameters

saveSession  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)  (Optional)
:   If true, saves the modified session and sub-sessions, if any, to their original folder locations.

#### Remarks

Use SaveNew or SaveAs if this session is being saved for the first time



# IADSession.UpdatePreviewSnaphot Method

Captures the canvas image displayed for this session and silently saves it as the file snapshot property

#### Syntax

```
void UpdatePreviewSnaphot(
	bool overwriteExistingSnapshot
)
```

#### Parameters

overwriteExistingSnapshot  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Indicates whether to overwrite existing snapshot property, if present.



# DIEnum Interface

DIEnum is an enumerator which can be used to get the contents of collection objects.

#### Syntax

```
public interface DIEnum
```

The DIEnum type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | HasMoreElements | Returns true if the enumerator has more elements. |
|  | NextElement | Returns the next element of the enumerator. |

#### Example

This Visual Basic sample shows how to use a DIEnum.

```
Dim objFeatureEnum As AlibreX.DIEnum
Dim objFeature As AlibreX.IADPartFeature
Dim objPart As AlibreX.IADPartSession

' In place of these comments we assume
' there is some code to obtain a part
' workspace and assign it to objPart

Set objFeatureEnum = objPart.Features.Enum
Do While objFeatureEnum.HasMoreElements
    Set objFeature = objFeatureEnum.NextElement
    MsgBox objFeature.Name 
Loop
```



# IADAddOns.ExportFile Method

#### Overload List

|  | Name | Description |
| --- | --- | --- |
|  | ExportFile(String, IADSession) |  |
|  | ExportFile(String, IADSession, String) |  |



# IADSession.SaveAll Method

Saves a copy of the session and all sub-sessions to the directory indicated by the destination parameter.

#### Syntax

```
void SaveAll(
	string destination
)
```

#### Parameters

destination  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The folder path where files will be saved to.

#### Remarks

This method replicates the functionality of the "Save All As..." command in the GUI.

To save to MFiles vaults using the API, you will use the same methods as with the file system.
The filepath should be passed with the following format: [MFiles drive letter]:\[Vault name]
(ie. "M:\MyVault")



# ADObjectSubType Enumeration

This enumeration lists the possible sub types or derived types of a Alibre object.
In particular, this is used for the SessionType
property.

#### Syntax

```
public enum ADObjectSubType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_PART | 1 | IADPartSession |
| AD\_ASSEMBLY | 2 | IADAssemblySession |
| AD\_DRAWING | 3 | IADDrawingSession |
| AD\_SYMBOL | 4 | Obsolete |
| AD\_EXTERNAL | 5 | Obsolete |
| AD\_BOM\_TABLE | 6 | IADBOMTableSession |
| AD\_SHEET\_METAL | 7 | IADPartSession |
| AD\_CATALOG\_FEATURE | 8 | Obsolete |
| AD\_SHEET\_METAL\_CATALOG\_FEATURE | 9 | Obsolete |
| AD\_GLOBAL\_PARAMETERS | 10 |  |



# IADGeometryFactory.CreateTranslationTransformAlongVector Method

Create a translation transformation using a vector.

#### Syntax

```
IADTransformation CreateTranslationTransformAlongVector(
	IADVector translationVector
)
```

#### Parameters

translationVector  IADVector
:   A vector describing the translation which should occur.

#### Return Value

IADTransformation  
A new translation transformation.

#### Example

This sample demonstrates creating and using a translation transformation.

```
// Get the current transform for a valid IADDesignSurface object.
IADTransformation surfaceTransform = designSurface.Transform;
// Create a direction vector to use for the transformation.
// This vector indicates a direction of up one.
IADVector direction = designSession.GeometryFactory.CreateVector(0, 1, 0);
// Use the geometry factory to create the translation transform along the vector
IADTransformation translateTransform = 
      designSession.GeometryFactory.CreateTranslationTransformAlongVector(direction);
// Apply the translation transform to the surface's original transform.
surfaceTransform = surfaceTransform.Apply(translateTransform);
// Set the design surface's transfromation to the translated transformation.
designSurface.Transform = surfaceTransform;
```



# IADGeometryFactory Methods

The IADGeometryFactory type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Create2DPoint | Creates a 2D point from the given coordinates. |
|  | CreateIdentityTransform | Create an identity transformation. |
|  | CreatePoint | Creates a 3D point from the given coordinates. |
|  | CreateRotationTransform | Create a rotation transformation around an axis (position, direction) by a specified angle. |
|  | CreateTransform | Create a new general 3D affine homogeneous transformation. Typically the user creates a new transformation to specify the transformation of a part when inserting it into an assembly. |
|  | CreateTransformByVariantArray | Creates a transformation with 4X4 Variant array. |
|  | CreateTranslationTransformAlongVector | Create a translation transformation using a vector. |
|  | CreateTranslationTransformByXYZ | Create a translation transformation using X, Y, Z direction components. |
|  | CreateUniformScalingTransform | Create a Unifom Scaling Transformation. Scale factor has to be more than or equal to 0.000001 |
|  | CreateVector | Creates a 3D vector from the given direction components. |



# IADPoint Properties

The IADPoint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | X | Returns the X coordinate of the 3D point. |
|  | Y | Returns the Y coordinate of the 3D point. |
|  | Z | Returns the Z coordinate of the 3D point. |



# ADUnits Enumeration

#### Syntax

```
public enum ADUnits
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_UNITLESS | 1 |  |
| AD\_DEGREES | 100 |  |
| AD\_DEGREES\_MINUTES | 101 |  |
| AD\_DEGREES\_MINUTES\_SECONDS | 102 |  |
| AD\_RADIANS | 103 |  |
| AD\_MILLIMETERS | 200 |  |
| AD\_CENTIMETERS | 201 |  |
| AD\_METERS | 202 |  |
| AD\_INCHES | 203 |  |
| AD\_FEET | 204 |  |
| AD\_FEET\_INCHES | 205 |  |
| AD\_KILOGRAMS | 400 |  |
| AD\_GRAMS | 401 |  |
| AD\_POUNDMASS | 402 |  |



# IADRoot.GetGuidAndConstituentInformation Method

Get the item GUID and constituent information (GUIDs, names and relative file paths) for the file specified in the path.

#### Syntax

```
void GetGuidAndConstituentInformation(
	string filePath,
	out string guid,
	out IObjectCollector constituentGuids,
	out IObjectCollector constituentNames,
	out IObjectCollector constituentRelativeFilePaths
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)

guid  [String](https://learn.microsoft.com/dotnet/api/system.string)

constituentGuids  IObjectCollector

constituentNames  IObjectCollector

constituentRelativeFilePaths  IObjectCollector



# IADRoot.ImportDWGFile Method

Creates a new drawing session from contents of input DWG file.

#### Syntax

```
IADSession ImportDWGFile(
	string filePath,
	ADUnits overridingUnit,
	bool maintainProjection
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the file to be imported.

overridingUnit  ADUnits
:   The units specified in the file may be overridden by this parameter.
    The default value is AD\_UNITLESS to not override units.

maintainProjection  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, Alibre will maintain the projection when importing the file.
    The default value is true.

#### Return Value

IADSession  
Returns a session containing the imported file.



# ADHoleType Enumeration

The ADHoleType enumeration identifies the different types of holes which a
Hole Feature can create. You can get this for a hole feature by querying its
HoleType property.

#### Syntax

```
public enum ADHoleType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_COUNTER\_BORED\_DRILLED\_HOLE | 0 | Counter-bored, Drilled Hole |
| AD\_COUNTER\_BORED\_HOLE | 1 | Counter-bored Hole |
| AD\_COUNTER\_DRILLED\_DRILLED\_HOLE | 2 | Counter-drilled, Drilled Hole |
| AD\_COUNTER\_DRILLED\_HOLE | 3 | Counter-drilled Hole |
| AD\_COUNTER\_SUNK\_DRILLED\_HOLE | 4 | Counter-sunk, Drilled Hole |
| AD\_COUNTER\_SUNK\_HOLE | 5 | Counter-sunk Hole |
| AD\_SIMPLE\_DRILLED\_HOLE | 6 | Simple, Drilled Hole |
| AD\_SIMPLE\_HOLE | 7 | Simple Hole |
| AD\_TAPERED\_DRILLED\_HOLE | 8 | Tapered, Drilled Hole |
| AD\_TAPERED\_HOLE | 9 | Tapered Hole |
| AD\_UNKNOWN\_HOLE | -1 | Unknown hole type, this value generally indicates an error. |

#### Remarks

There are five main hole types (Simple, Tapered, Counter-bored, Counter-sunk,
and Counter-drilled) and also a Drilled version of each type. The regular
versions of the holes end in a flat face (if they aren't Through All), and
the drilled versions end with a conical face at a user-specified angle.



# IADRoot.ImportDXFFile Method

Creates a new drawing session from contents of input DXF file.

#### Syntax

```
IADSession ImportDXFFile(
	string filePath,
	ADUnits overridingUnit,
	bool maintainProjection
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the file to be imported.

overridingUnit  ADUnits
:   The units specified in the file may be overridden by this parameter.
    The default value is AD\_UNITLESS to not override units.

maintainProjection  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, Alibre will maintain the projection when importing the file.
    The default value is true.

#### Return Value

IADSession  
Returns a session containing the imported file.



# IADRoot.CreateUser Method

Creates an arbitrary user given a name.

#### Syntax

```
IADUser CreateUser(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADUser  

#### Remarks

This method is obsolete as of V11 of Alibre Design.



# IADSessions.Count Property

Returns the number of sessions in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADSession.SessionType Property

Returns a pre-defined constant that identifies whether this session is a part or assembly or drawing session.

#### Syntax

```
ADObjectSubType SessionType { get; }
```

#### Property Value

ADObjectSubType

#### Remarks

Possible values for this property and their corresponding types include:

- AD\_PART
- AD\_ASSEMBLY
- AD\_DRAWING
- AD\_SHEET\_METAL (Note that Sheet Metal parts also
  use the IADPartSession interface.)
- AD\_BOM\_TABLE

Additionally, AD\_PART, AD\_ASSEMBLY, and AD\_SHEET\_METAL type sessions can
also be cast to IADDesignSession.



# ADDesignGeometryType Enumeration

This enumeration is used to describe how design geometry geometry
(IADDesignPlane, IADDesignAxis,
IADDesignPoint) was created. This information
can be used to determine what parameters
or source objects to query to find
the definition of the design geometry.

#### Syntax

```
public enum ADDesignGeometryType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_POINT\_FROM\_XYZ\_COORDINATES | 0 |  |
| AD\_POINT\_FROM\_CIRCULAR\_EDGE | 1 |  |
| AD\_POINT\_FROM\_OFFSET | 2 |  |
| AD\_POINT\_FROM\_TOROID\_POINT | 3 |  |
| AD\_POINT\_FROM\_TWO\_AXES | 4 |  |
| AD\_POINT\_FROM\_MIDRATIO | 5 |  |
| AD\_POINT\_FROM\_THREE\_PLANES | 6 |  |
| AD\_POINT\_FROM\_PLANE\_AXIS | 7 |  |
| AD\_POINT\_ALONG\_EDGE | 8 |  |
| AD\_POINT\_FROM\_EDGE\_PARAMETER | 9 |  |
| AD\_POINT\_FROM\_PROJECTTED\_PLANE | 10 |  |
| AD\_POINT\_FROM\_SKETCH\_POINT | 11 |  |
| AD\_POINT\_FROM\_TWO\_FIGURE\_SKETCH | 12 |  |
| AD\_AXIS\_FROM\_TWO\_POINTS | 13 |  |
| AD\_AXIS\_FROM\_CYLINDRICAL\_FACE | 14 |  |
| AD\_AXIS\_FROM\_TWO\_PLANES | 15 |  |
| AD\_AXIS\_FROM\_REVOLVED\_FACE | 16 |  |
| AD\_AXIS\_FROM\_EDGE | 17 |  |
| AD\_AXIS\_FROM\_POINT\_PLANE | 18 |  |
| AD\_AXIS\_FROM\_AXIS\_PLANE | 19 |  |
| AD\_AXIS\_FROM\_ONELINE\_SKETCH | 20 |  |
| AD\_AXIS\_FROM\_TWO\_POINT\_SKETCH | 21 |  |
| AD\_AXIS\_FROM\_POINT\_NORMAL\_SKETCH | 22 |  |
| AD\_PLANE\_FROM\_THREE\_POINTS | 23 |  |
| AD\_PLANE\_FROM\_OFFSET\_TO\_PLANE | 24 |  |
| AD\_PLANE\_FROM\_ANGLE\_TO\_PLANE | 25 |  |
| AD\_PLANE\_FROM\_TWO\_AXES | 26 |  |
| AD\_PLANE\_FROM\_OFFSET\_TO\_POINT | 27 |  |
| AD\_PLANE\_FROM\_POINT\_AXIS | 28 |  |
| AD\_PLANE\_FROM\_TANGENT | 29 |  |
| AD\_PLANE\_FROM\_TANGENTSLOPE | 30 |  |
| AD\_PLANE\_FROM\_CATALOG\_FEATURE | 31 |  |
| AD\_PRIMARY\_PLANE | 32 |  |
| AD\_PRIMARY\_AXIS | 33 |  |
| AD\_PRIMARY\_POINT | 34 |  |
| AD\_PLANE\_FROM\_EDGE\_END | 35 |  |



# IADPoint Interface

This interface represents a point in the 3-dimensional space and is obtained by getting the geometry of a vertex.
Note that this point is different from the reference geometry IADDesignPoint. In contrast to the DesignPoint, the
object for this interface cannot be created stand alone and can only be obtained from geometry of a topology.
This interface defines the point by the x, y and z coordinates.

#### Syntax

```
public interface IADPoint
```

The IADPoint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | X | Returns the X coordinate of the 3D point. |
|  | Y | Returns the Y coordinate of the 3D point. |
|  | Z | Returns the Z coordinate of the 3D point. |



# IADEventsCallback Interface

Automation event callback interface for Alibre Design.

#### Syntax

```
public interface IADEventsCallback
```

The IADEventsCallback type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | OnInitialize | Event notifying that Alibre Design has been initialized. |
|  | OnModelLoadComplete | Event notifying that model is loaded completely. |
|  | OnSessionChange | Event notifying that a session has been modified |
|  | OnSessionClose | Event notifying that a session has been closed. |
|  | OnSessionOpen | Event notifying that a new top level session has been opened. |
|  | OnTerminate | Event notifying that Alibre Design has been terminated. |



# IADSessions.Item Method

Given a name or index, into the collection, returns the corresponding session.

#### Syntax

```
IADSession Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or index of the session.

#### Return Value

IADSession  
Returns IADSession

#### Example

This Visual Basic sample shows how to use the Item method.

```
Dim sessionObj As IADSession
Dim assmSessionObj As IADAssemblySession
Dim sessionCount As Long
sessionCount = 0

' rootObj is a valid IADRoot object
Do While sessionCount < rootObj.Sessions.Count
    Set sessionObj = rootObj.Sessions.Item(sessionCount)
    If (objSession.SessionType = ADObjectSubType_AD_ASSEMBLY) Then ' Check if the session is an assembly
        Set assmSessionObj = sessionObj
        ' Do work on the assembly session here
    End If
Loop
```



# IADVector Properties

The IADVector type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Length | Returns the length of the vector. |
|  | X | Gets the X direction component. |
|  | Y | Gets the Y direction component. |
|  | Z | Gets the Z direction component. |



# IADAddOns Interface

#### Syntax

```
public interface IADAddOns
```

The IADAddOns type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | ExportFile(String, IADSession) |  |
|  | ExportFile(String, IADSession, String) |  |
|  | ImportFile |  |



# EventManager.OnSessionClose Event

Event notifying that a new top level session has been opened.

#### Syntax

```
public event EventManagerSessionCloseHandler OnSessionClose
```

#### Value

EventManagerSessionCloseHandler



# ADSketchConstraintType Enumeration

#### Syntax

```
public enum ADSketchConstraintType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_CONSTRAINT\_UNKNOWN | 0 |  |
| AD\_CONSTRAINT\_HORIZONTAL | 1 |  |
| AD\_CONSTRAINT\_VERTICAL | 2 |  |
| AD\_CONSTRAINT\_COLLINEAR | 3 |  |
| AD\_CONSTRAINT\_CORADIAL | 4 |  |
| AD\_CONSTRAINT\_COINCIDENT | 5 |  |
| AD\_CONSTRAINT\_PERPENDICULAR | 6 |  |
| AD\_CONSTRAINT\_PARALLEL | 7 |  |
| AD\_CONSTRAINT\_TANGENT | 8 |  |
| AD\_CONSTRAINT\_EQUAL | 9 |  |
| AD\_CONSTRAINT\_MIDPOINT | 10 |  |
| AD\_CONSTRAINT\_INTERSECTION | 11 |  |
| AD\_CONSTRAINT\_SYMMETRIC | 12 |  |
| AD\_CONSTRAINT\_FIX | 13 |  |
| AD\_CONSTRAINT\_NORMAL | 14 |  |



# IADRoot.GetAgentProperty Method

Obsolete

#### Syntax

```
string GetAgentProperty(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

[String](https://learn.microsoft.com/dotnet/api/system.string)  

#### Remarks

This method is obsolete as of V11 of Alibre Design.



# IADRoot.CreateEmptyPartEx Method

Creates a new empty part.

#### Syntax

```
IADPartSession CreateEmptyPartEx(
	string name,
	bool isSheetMetal,
	bool openEditor
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name for the new part.

isSheetMetal  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, a Sheel Metal Part will be created; otherwise,
    a regular Part is created.

openEditor  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Flag specifying whether to show the newly created part in an editor window

#### Return Value

IADPartSession  
The interface to the new part.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_PART\_SESSION\_FAILED | Alibre failed to create the empty part session. |



# IADRoot.CreateEmptyGlobalParameters Method

Creates a new empty Global Parameters workspace.

#### Syntax

```
IADGlobalParameterSession CreateEmptyGlobalParameters(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name for the new Global Parameters document.

#### Return Value

IADGlobalParameterSession  
The interface to the new Global Parameters session.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_CREATE\_GLOBAL\_PARAM\_SESSION\_FAILED | Alibre failed to create the empty global parameters session. |



# IADSession.TimeStamp Property

Returns time stamp of this session; the time stamp changes when changes are saved to the session.

#### Syntax

```
int TimeStamp { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

This is not a time stamp in the sense of giving the time at which the session was last modified,
but rather an int which can quickly be compared to the previous value to determine if the session has changed.
By using this property, more performance-costly query of the session can be avoided when it is unnecessary.



# IADTransformation.Array Method

Returns the elements of the transform as a one-dimensional array containing 16 doubles.
This array represents a 4x4 matrix.

#### Syntax

```
Array Array()
```

#### Return Value

[Array](https://learn.microsoft.com/dotnet/api/system.array)  
A one-dimensional zero-based double array containing 16 doubles.

#### Remarks

The order of elements is by rows as shown below (Vxi, Vxj, Vxk, 0, Vyi, ...)

|  |  |  |  |
| --- | --- | --- | --- |
| Vxi | Vxj | Vxk | 0 |
| Vyi | Vyj | Vyk | 0 |
| Vzi | Vzj | Vzk | 0 |
| Tx | Ty | Tz | 1 |

- The 3x3 submatrix V represents the rotation
  - Vxi, Vxj, and Vxk represent the X vector.
  - Vyi, Vyj, and Vyk represent the Y vector.
  - Vzi, Vzj, and Vzk represent the Z vector.
- The vector T represents the translation.
  - Tx, Ty, and Tz represent the translation along X, Y, and Z axes respectively.
- The right column always contains 0, 0, 0, 1.

#### Example

This sample demonstrates getting the transformation data in array form.

```
// Get an IADTransfromation (in this case, from an IADOccurrence)
IADTransformation transform = occurrence.LocalTransform;
double[] transArray = (double[])transform.Array();
Console.WriteLine("{{" + transArray[0] + ", " + transArray[1] + ", "
                  + transArray[2] + ", " + transArray[3] + "},");
Console.WriteLine(" {" + transArray[4] + ", " + transArray[5] + ", "
                  + transArray[6] + ", " + transArray[7] + "},");
Console.WriteLine(" {" + transArray[8] + ", " + transArray[9] + ", "
                  + transArray[10] + ", " + transArray[11] + "},");
Console.WriteLine(" {" + transArray[12] + ", " + transArray[13] + ", "
                  + transArray[14] + ", " + transArray[15] + "}}");
```



# IADRoot.TerminateAll Method

Terminates the Automation client. If Alibre is launched from automation, TerminalAll() will safely terminate
the automated process, even if called from a different thread.

#### Syntax

```
void TerminateAll()
```



# IADRoot.IsOpenedFromRepository Method

Determines if a file (specified by its full disk path) is opened from the repository.

#### Syntax

```
bool IsOpenedFromRepository(
	string filePathOnDisk
)
```

#### Parameters

filePathOnDisk  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The full disk path of the file.

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# EventManager.SessionOpenHandler Delegate

#### Syntax

```
public delegate void SessionOpenHandler(
	IADSession pSession
)
```

#### Parameters

pSession  IADSession



# EventManager.InitializeHandler Delegate

#### Syntax

```
public delegate void InitializeHandler()
```



# IADSession.NewTargetProxy Method

Creates a new TargetProxy for the given target and the occurrence

#### Syntax

```
IADTargetProxy NewTargetProxy(
	IADOccurrence poccurrence,
	Object ptarget
)
```

#### Parameters

poccurrence  IADOccurrence
:   The occurrence which contains the target.

ptarget  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The target to create a TargetProxy of.

#### Return Value

IADTargetProxy  
Returns IADTargetProxy

#### Example

This snippet demonstrates creating a Target Proxy using the NewTargetProxy method, and then using the Select method to select the face in the Target Proxy.

```
if (iSession->GetSessionType () == ADObjectSubType_AD_ASSEMBLY)
{
    IADAssemblySessionPtr assySession;
    iSession->QueryInterface (&assySession);
    if(assySession != NULL)
    {
        IObjectCollectorPtr collection;
        collection = theApp.m_pRoot->NewObjectCollector ();
        if (collection == NULL)
        {
            AfxMessageBox("Error in initilizing collection");
            return;
        }

        IADOccurrencesPtr occurrences;
        occurrences = assySession->GetRootOccurrence ()->GetOccurrences ();    

        if (occurrences == NULL && occurrences->GetCount () <= 0)
        {
            AfxMessageBox ("Assembly has no parts");
            return;
        }

        IADOccurrencePtr assyOccur;

        VARIANT occurCounter;
        VariantInit(&occurCounter);
        occurCounter.vt = VT_I4;
        occurCounter.lVal = 0;

        assyOccur = occurrences->GetItem (&occurCounter);
        if (assyOccur == NULL)
        {
            AfxMessageBox ("Error in getting the occurrence");
            return;
        }

        IADDesignSessionPtr dsnSession = assyOccur->GetDesignSession ();
        if (dsnSession == NULL)
        {
            AfxMessageBox ("Error in getting the design session");
            return;
        }

        IADPartSessionPtr partSession;
        dsnSession->QueryInterface (&partSession);
        if (partSession == NULL)
        {
            AfxMessageBox ("Error in getting the part session");
            return;
        }

        IADBodiesPtr assyBodies = partSession->GetBodies ();
        if (assyBodies == NULL || assyBodies->GetCount () <= 0)
        {
            AfxMessageBox ("Error in getting the bodies");
            return;
        }

        IADBodyPtr assyBody = assyBodies->GetItem (0);
        if (assyBody == NULL)
        {
            AfxMessageBox ("Error in getting the first body in the part session");
            return;
        }

        IADFacesPtr assyFaces = assyBody->GetFaces ();
        if (assyFaces == NULL || assyFaces->GetCount () <= 0)
        {
            AfxMessageBox ("Error in getting the faces of the bodies");
            return;
        }

        IADFacePtr assyFace = assyFaces->GetItem (0);
        if (assyFace == NULL)
        {
            AfxMessageBox ("Error in getting the face");
            return;
        }

        IADTargetProxyPtr proxy = iSession->NewTargetProxy (assyOccur, assyFace);
        if (proxy != NULL)
        {
            hr = collection->Add (proxy);        
            if (FAILED(hr))
            {
                AfxMessageBox ("Error while adding to collection");
                return;
            }
            hr = iSession->Select (collection);
            if (FAILED(hr))
            {
                AfxMessageBox ("Error in selecting proxy");
                return;
            }
        }
    }
}
```



# IADRoot.createMaterialLibrary Method

Create a new Material Library.

#### Syntax

```
IADMaterialLibrary createMaterialLibrary(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADMaterialLibrary



# IADEventsCallback.OnModelLoadComplete Method

Event notifying that model is loaded completely.

#### Syntax

```
void OnModelLoadComplete(
	IADSession pSession
)
```

#### Parameters

pSession  IADSession
:   The session whose model has finished loading completely.



# AutomationHook Methods

The AutomationHook type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | [CreateObjRef](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject.createobjref) | Creates an object that contains all the relevant information required to generate a proxy used to communicate with a remote object. (Inherited from [MarshalByRefObject](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject)) |
|  | [Equals](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)) | Determines whether the specified object is equal to the current object. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | [Finalize](https://learn.microsoft.com/dotnet/api/system.object.finalize) | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | [GetHashCode](https://learn.microsoft.com/dotnet/api/system.object.gethashcode) | Serves as the default hash function. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | [GetLifetimeService](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject.getlifetimeservice) | Retrieves the current lifetime service object that controls the lifetime policy for this instance. (Inherited from [MarshalByRefObject](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject)) |
|  | [GetType](https://learn.microsoft.com/dotnet/api/system.object.gettype) | Gets the [Type](https://learn.microsoft.com/dotnet/api/system.type) of the current instance. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | Initialize | Initiates a new Alibre Design Automation client in GUI-less mode. |
|  | InitializeDebug | Initiates a new Alibre Design Automation client in Debug mode. |
|  | [MemberwiseClone](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone) | Creates a shallow copy of the current [Object](https://learn.microsoft.com/dotnet/api/system.object). (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | [MemberwiseClone(Boolean)](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject.memberwiseclone#system-marshalbyrefobject-memberwiseclone(system-boolean)) | Creates a shallow copy of the current [MarshalByRefObject](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject) object. (Inherited from [MarshalByRefObject](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject)) |
|  | [ToString](https://learn.microsoft.com/dotnet/api/system.object.tostring) | Returns a string that represents the current object. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |



# IADSession.Select Method

Selects all objects passed in pEntities.

#### Syntax

```
void Select(
	IObjectCollector pEntities
)
```

#### Parameters

pEntities  IObjectCollector
:   Supported object types are IADOccurrence,
    IADTargetProxy, IADAssemblyConstraint,
    IADSketch, IAD3DSketch and all topological
    and design geometry objects.
    To deselect pass an empty IObjectCollector or NULL.

#### Remarks

New IObjectCollector objects can be created using the
NewObjectCollector method on IADRoot.

#### Example

This snippet demonstrates creating a Target Proxy using the NewTargetProxy method, and then using the Select method to select the face in the Target Proxy.

```
if (iSession->GetSessionType () == ADObjectSubType_AD_ASSEMBLY)
{
    IADAssemblySessionPtr assySession;
    iSession->QueryInterface (&assySession);
    if(assySession != NULL)
    {
        IObjectCollectorPtr collection;
        collection = theApp.m_pRoot->NewObjectCollector ();
        if (collection == NULL)
        {
            AfxMessageBox("Error in initilizing collection");
            return;
        }

        IADOccurrencesPtr occurrences;
        occurrences = assySession->GetRootOccurrence ()->GetOccurrences ();    

        if (occurrences == NULL && occurrences->GetCount () <= 0)
        {
            AfxMessageBox ("Assembly has no parts");
            return;
        }

        IADOccurrencePtr assyOccur;

        VARIANT occurCounter;
        VariantInit(&occurCounter);
        occurCounter.vt = VT_I4;
        occurCounter.lVal = 0;

        assyOccur = occurrences->GetItem (&occurCounter);
        if (assyOccur == NULL)
        {
            AfxMessageBox ("Error in getting the occurrence");
            return;
        }

        IADDesignSessionPtr dsnSession = assyOccur->GetDesignSession ();
        if (dsnSession == NULL)
        {
            AfxMessageBox ("Error in getting the design session");
            return;
        }

        IADPartSessionPtr partSession;
        dsnSession->QueryInterface (&partSession);
        if (partSession == NULL)
        {
            AfxMessageBox ("Error in getting the part session");
            return;
        }

        IADBodiesPtr assyBodies = partSession->GetBodies ();
        if (assyBodies == NULL || assyBodies->GetCount () <= 0)
        {
            AfxMessageBox ("Error in getting the bodies");
            return;
        }

        IADBodyPtr assyBody = assyBodies->GetItem (0);
        if (assyBody == NULL)
        {
            AfxMessageBox ("Error in getting the first body in the part session");
            return;
        }

        IADFacesPtr assyFaces = assyBody->GetFaces ();
        if (assyFaces == NULL || assyFaces->GetCount () <= 0)
        {
            AfxMessageBox ("Error in getting the faces of the bodies");
            return;
        }

        IADFacePtr assyFace = assyFaces->GetItem (0);
        if (assyFace == NULL)
        {
            AfxMessageBox ("Error in getting the face");
            return;
        }

        IADTargetProxyPtr proxy = iSession->NewTargetProxy (assyOccur, assyFace);
        if (proxy != NULL)
        {
            hr = collection->Add (proxy);        
            if (FAILED(hr))
            {
                AfxMessageBox ("Error while adding to collection");
                return;
            }
            hr = iSession->Select (collection);
            if (FAILED(hr))
            {
                AfxMessageBox ("Error in selecting proxy");
                return;
            }
        }
    }
}
```



# ADHelixConditionType Enumeration

This enumeration describes the different start/end condition types available
for Helical Boss/Cut features.

#### Syntax

```
public enum ADHelixConditionType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_Natural | 0 | Natural: There is no special geometry on this end of the helix. |
| AD\_Flat | 1 | Flat: This end of the helix is flat for a specified angle, and then transitions to the regularly specified helix over a specified transition angle. |



# IADSessions Methods

The IADSessions type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a name or index, into the collection, returns the corresponding session. |



# CustomError Enumeration

An enumeration of custom error values that are used in exceptions.

#### Syntax

```
public enum CustomError
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_E\_INVALID\_FEATURE\_OBJECT | -2,147,220,646 | Invalid Feature Object |
| AD\_E\_ALL\_FEATURES\_SUPPRESSED | -2,147,220,645 | Cannot pattern/mirror when all target features are suppressed |
| AD\_E\_PATH\_NOT\_CONNECTED | -2,147,220,644 | The entities making up the path must form a continuous chain |
| AD\_E\_TARGET\_FEATURE\_AND\_PATH\_NOT\_INTERSECTING | -2,147,220,643 | The path does not intersect the seed feature |
| AD\_E\_MORE\_THAN\_ONE\_INTERSECTION | -2,147,220,642 | The seed feature intersects the path in more than one location |
| AD\_E\_PATH\_EDGE\_IS\_NOT\_TANGENT\_CONTINUOUS | -2,147,220,641 | Path is not tangent continuous |
| AD\_E\_TARGET\_FEATURE\_IS\_NOT\_CONSUMING\_PATH | -2,147,220,640 | Target feature is not consuming the path |
| AD\_E\_CANNOT\_INVERT\_NON\_INVERTIBLE\_TRANSFORMATION | -2,147,220,639 | Cannot invert non-invertible transformation |
| AD\_E\_INVALID\_START\_POINT | -2,147,220,638 | Invalid start point |
| AD\_E\_START\_POINT\_NOT\_ON\_PATH | -2,147,220,637 | Start point is not on path |
| AD\_E\_FEATURE\_PATTERNS\_NOT\_ALLOWED | -2,147,220,636 | Feature patterns are not allowed |
| AD\_E\_INVALID\_PLANE\_OBJECT | -2,147,220,635 | Invalid plane object |
| AD\_E\_CANNOT\_MIRROR\_BODY\_WITH\_FEATURE\_PATTERN | -2,147,220,634 | Cannot mirror body with feature pattern |
| AD\_E\_CANNOT\_EXTRUDE\_INTERSECTING\_FIGURES | -2,147,220,633 | Cannot create Extrusion feature with self-intersecting figures |
| AD\_E\_CANNOT\_REVOLVE\_INTERSECTING\_FIGURES | -2,147,220,632 | Cannot create Revolved feature with self-intersecting figures |
| AD\_E\_CANNOT\_SWEEP\_INTERSECTING\_FIGURES | -2,147,220,631 | Cannot create Swept feature with self-intersecting figures |
| AD\_E\_CANNOT\_LOFT\_INTERSECTING\_FIGURES | -2,147,220,630 | Cannot create Loft feature with self-intersecting figures |
| AD\_E\_CANNOT\_THINWALL\_EXTRUDE\_INTERSECTING\_FIGURES | -2,147,220,629 | Cannot create Thin Wall Extrusion feature with self-intersecting figures |
| AD\_E\_CANNOT\_THINWALL\_REVOLVE\_INTERSECTING\_FIGURES | -2,147,220,628 | Cannot create Thin Wall Revolved feature with self-intersecting figures |
| AD\_E\_CANNOT\_THINWALL\_SWEEP\_INTERSECTING\_FIGURES | -2,147,220,627 | Cannot create Thin Wall Swept feature with self-intersecting figures |
| AD\_E\_CANNOT\_HELICAL\_BOSS\_INTERSECTING\_FIGURES | -2,147,220,626 | Cannot create Helical Boss feature with self-intersecting figures |
| AD\_E\_CANNOT\_HELICAL\_CUTOUT\_INTERSECTING\_FIGURES | -2,147,220,625 | Cannot create Helical Cutout feature with self-intersecting figures |
| AD\_E\_UNSUPPORTED\_PARAMETER\_TYPE | -2,147,220,624 | Unsupported parameter type |
| AD\_E\_UNSUPPORTED\_PARAMETER\_UNIT | -2,147,220,623 | Unsupported parameter unit |
| AD\_E\_PARAMETER\_CANNOT\_BE\_EXPRESSED\_AS\_INT | -2,147,220,622 | Parameter value cannot be expressed as an integer |
| AD\_E\_INVALID\_SETBACK\_DISTANCE | -2,147,220,621 | Invalid setback distance |
| AD\_E\_INVALID\_SETBACK\_CORNER\_VERTEX | -2,147,220,620 | Invalid setback corner vertex |
| AD\_E\_INVALID\_SETBACK\_EDGES | -2,147,220,619 | Invalid setback edges |
| AD\_E\_INVALID\_SETBACK\_DATA | -2,147,220,618 | Invalid setback data |
| AD\_E\_INVALID\_LOCATION\_SIZE | -2,147,220,617 | Invalid location size |
| AD\_E\_INVALID\_VALUE\_INVALID\_DEFINITION | -2,147,220,647 | The value is invalid because its definition differs from the one required to create the folder. |
| AD\_E\_INVALID\_PDM\_LICENSE | -2,147,220,648 | Unable to use PDM. Please check your licensing. |
| AD\_E\_INVALID\_OPERATION\_FOR\_VERSION\_ITEM | -2,147,220,649 | This operation is not valid for this version of the item. |
| AD\_E\_INVALID\_CLASS\_FOR\_LEVEL | -2,147,220,650 | Cannot use Core class for a level item. |
| AD\_E\_PROPERTY\_INVALID\_METHOD\_OR\_PROPERTY | -2,147,220,651 | This method or property based is invalid for this property type. |
| AD\_E\_OPERATION\_NOT\_VALID\_TEMPLATE\_FOLDER | -2,147,220,652 | This operation is not valid because this is folder is tied to a Template Level. |
| AD\_E\_OPERATION\_NEEDS\_PROJECT\_OR\_LIBRARY | -2,147,220,653 | This operation needs a Project or a Library item. |
| AD\_E\_CANNOT\_CANCEL\_CHECK\_IN | -2,147,220,654 | Unable to cancel the Check in operation. |
| AD\_E\_CHECK\_IN\_ALREADY\_IN\_PROGRESS | -2,147,220,655 | Check in operation is already in progress. |
| AD\_E\_OPERATION\_NOT\_VALID\_DEFAULT\_PROPERTY | -2,147,220,656 | This operation is not valid as this is a default property for the item. |
| AD\_E\_PROPERTY\_DEFINITION\_DOES\_NOT\_EXIST | -2,147,220,657 | The property definition does not exist. |
| AD\_E\_PATH\_DOES\_NOT\_EXIST | -2,147,220,658 | The given path does not exist. |
| AD\_E\_OPERATION\_VALID\_ON\_LOCALLY\_MODIFIED\_ITEM | -2,147,220,659 | This operation is valid only on Locally Modified items. |
| AD\_E\_OPERATION\_VALID\_ON\_CHECKED\_IN\_ITEM | -2,147,220,660 | This operation is valid only on checked in item. |
| AD\_E\_OPERATION\_VALID\_ON\_NEW\_AND\_LOCALLY\_MODIFIED\_ITEM | -2,147,220,661 | This operation is valid only on New or Locally Modified items. |
| AD\_E\_OPERATION\_VALID\_ON\_DELETED\_ITEM | -2,147,220,662 | This operation is valid only on deleted items. |
| AD\_E\_OPERATION\_NOT\_POSSIBLE\_ITEM\_DELETED | -2,147,220,663 | The item has been deleted, so this operation is not valid. |
| AD\_E\_CANNOT\_DELETE\_CONSUMED\_ITEM | -2,147,220,664 | Cannot delete this item as it is consumed. |
| AD\_E\_BUILT\_IN\_PROPERTY\_DEFINITION\_OPERATION\_NOT\_ALLOWED | -2,147,220,665 | This operation is not applicable for Built In Property Definition items. |
| AD\_E\_CORE\_CLASS\_OPERATION\_NOT\_ALLOWED | -2,147,220,666 | This operation is not applicable for Core Class items. |
| AD\_E\_USE\_OVERLOAD\_METHOD | -2,147,220,667 | Use an alternative overload of this method. |
| AD\_E\_FILE\_LOCKED\_SAVE\_NOT\_ALLOWED | -2,147,220,668 | Cannot save a Locked file. Try opening it stand alone, unlock it and then try again. |
| AD\_E\_MATERIAL\_WRITE\_ACCESS\_DENIED | -2,147,220,669 | Don't have write access for default material library. |
| AD\_E\_MATERIAL\_ALREADY\_EXIST | -2,147,220,670 | Given material name is already exist. |
| AD\_E\_FOLDER\_ALREADY\_EXIST | -2,147,220,671 | Given folder name is already exist. |
| AD\_E\_LIBRARY\_ALREADY\_EXIST | -2,147,220,672 | Given library name is already exist. |
| AD\_E\_MATERIAL\_NOT\_EXIST | -2,147,220,673 | Material does not exist. |
| AD\_E\_MATERIAL\_INVALID | -2,147,220,674 | Invalid Material. |
| AD\_E\_SKETCH\_CREATION\_NOT\_FEASIBLE | -2,147,220,675 | Sketch creation is not feasible with the given points. |
| AD\_E\_CREATE\_GLOBAL\_PARAM\_SESSION\_FAILED | -2,147,220,676 | Failed to create Global Parameters Session. |
| AD\_E\_CREATE\_DRAWING\_SESSION\_FAILED | -2,147,220,677 | Failed to create Drawing Session. |
| AD\_E\_INVALID\_LOFT\_TANGENCY\_ARRAY\_LENGTH | -2,147,220,678 | Invalid array length for one or more of the tangency control arrays. Tangency, TangentMagnitudes, and TangentAngles must all have the same length as CrossSections. |
| AD\_E\_INVALID\_LOFT\_TANGENCY | -2,147,220,679 | Invalid Loft tangency control parameter. Values of Tangency must be boolean. Values of TangentMagnitudes and TangentAngles must be non-negative double values. |
| AD\_E\_INVALID\_LOFT\_GUIDE\_CURVE\_TYPE | -2,147,220,680 | Invalid Guide Curve Type. Must be a valid member of the ADLoftGuideType enum. |
| AD\_E\_INVALID\_LOFT\_GUIDE\_CURVE | -2,147,220,681 | Invalid object type for a guide curve. Guide curves must be IAD3DSketch. |
| AD\_E\_INSUFFICIENT\_LOFT\_CROSS\_SECTIONS | -2,147,220,682 | Not enough cross sections to create a Loft feature. At least 2 are required. |
| AD\_E\_INVALID\_LOFT\_CROSS\_SECTION | -2,147,220,683 | Invalid object type for a Loft cross section. Requires IADSketch, IADFace, or IADDesignPoint. |
| AD\_E\_UNSUPPORTED\_SKETCH\_CONSTRAINT\_TYPE | -2,147,220,684 | Unsupported sketch constraint type |
| AD\_NO\_INSTALLED\_DRAWING\_TEMPLATES | -2,147,220,685 | No installed drawing template files were found on the system. |
| AD\_RESTORE\_PACKAGE\_FAILED | -2,147,220,686 | Restoration of Package File failed |
| AD\_INVALID\_LICENSE\_KEY\_FOR\_DRAWINGS | -2,147,220,687 | License key is not valid to Create/Edit/Save/Export Drawing workspaces |
| AD\_E\_NO\_SKETCH\_POINT\_ID | -2,147,220,688 | Non-node sketch points do not have an ID. |
| AD\_E\_NO\_REFERENCE\_FIGURE\_ID | -2,147,220,689 | Reference figures do not have an ID. |
| AD\_E\_COINCIDENT\_POINTS | -2,147,220,690 | Points being coincident to eachother within this figure is not valid. |
| AD\_E\_INVALID\_INTERPOLATION\_POINT\_ARRAY | -2,147,220,691 | The input array of interpolation points is invalid. The array must be non-null and have at least two points. |
| AD\_E\_LOFT\_CROSS\_SECTIONS\_UNAVAILABLE | -2,147,220,692 | One or more of the Cross Sections for this loft are unavailable, due to it being a face that is not available in the current design state. Set the current feature to immediately before this loft feature to be able to get its Cross Section objects. |
| AD\_E\_INVALID\_SELECTION\_FILTER | -2,147,220,693 | The specified option is not valid for this selection filter. |
| AD\_E\_MULTIPLE\_SAVE\_TARGETS\_NOT\_ALLOWED | -2,147,220,694 | Saving some files in an assembly to the Alibre Vault and some to the Windows File System is not allowed. Use SaveAll to transition from one to the other. |
| AD\_E\_VAULT\_OPERATION\_FAILED | -2,147,220,695 | The attempted operation on the Alibre Vault failed |
| AD\_E\_VAULT\_NOT\_AVAILABLE | -2,147,220,696 | The Alibre Vault is not available |
| AD\_E\_INVALID\_OWNED\_FIGURE\_OPERATION | -2,147,220,697 | Operation not available for sketch figures owned by a shape |
| AD\_INVALID\_TOLERANCE | -2,147,220,698 | Invalid tolerance value passed |
| AD\_NOT\_AVAILABLE\_FOR\_ASSEMBLY\_WITH\_CONSTRAINTS\_OR\_FIXED\_OCCURRENCES | -2,147,220,699 | Not applicable for assembly with constraints or fixed occurrences |
| AD\_ARRAY\_SIZES\_NOT\_MATCHING | -2,147,220,700 | Array sizes not matching |
| AD\_NOT\_MATCHING\_NUMBER\_OF\_RADIUI | -2,147,220,701 | Number of Start/End Radii is not matching with the given number of Topology objects |
| AD\_INVALID\_OBJECT | -2,147,220,702 | Invalid object passed |
| AD\_BROWSER\_NOT\_FOUND | -2,147,220,703 | Browser is not found for this session |
| AD\_INVALID\_LICENSE\_KEY\_FOR\_SHEET\_METAL | -2,147,220,704 | License key is not valid to Create/Edit/Save/Export Sheet Metal workspaces |
| AD\_INVALID\_LICENSE\_KEY | -2,147,220,705 | License key is not found or expired |
| AD\_FEATURE\_HAS\_ERROR | -2,147,220,706 | Feature is created and is available in features list. This feature has an error |
| AD\_NOT\_VALID\_TO\_SPECIFY\_FORMAT | -2,147,220,707 | It is not valid to specify a format, when unit is required |
| AD\_APP\_IS\_TERMINATING\_CANNOT\_INITIALIZE | -2,147,220,708 | Application is terminating. Initialization is not permitted now |
| AD\_APP\_ALREADY\_INITIALIZED | -2,147,220,709 | Application is already initialized. Initialization is not permitted again |
| ERR\_REPO\_FILE\_LOCKED\_BY\_OTHER\_USER | -2,147,220,710 | File is locked by another user |
| AD\_E\_TRANSFORM\_NOT\_INVERTIBLE | -2,147,220,711 | The transform is not invertible |
| AD\_E\_FILE\_ALREADY\_EXISTS | -2,147,220,712 | The file already exists. Cannot overwrite the existing file |
| AD\_E\_UNSUPPORTED\_FILE\_FORMAT | -2,147,220,713 | Unknown or unsupported file format |
| AD\_E\_INVALID\_FILE\_NAME | -2,147,220,714 | Invalid or Null file name. No file name was supplied or the file does not exist |
| AD\_E\_NEXT\_ELEMENT\_UNAVAILABLE | -2,147,220,715 | Next Element does not exist on this DIEnum |
| AD\_E\_CANNOT\_CREATE\_TRANSFORM\_WITH\_ZERO\_VECTOR | -2,147,220,716 | Cannot create Transformation with Zero Vector |
| AD\_E\_CANNOT\_SET\_EQUATION\_ON\_EXTERNALLY\_DRIVEN\_PARAMETER | -2,147,220,717 | Setting Equation is not permitted on Externally Driven parameter |
| AD\_E\_INVALID\_UNIT\_FOR\_SCALE\_OR\_COUNT\_PARAMETER | -2,147,220,718 | Invalid unit given for unitless Scale/Count type parameter |
| AD\_E\_INVALID\_ANGLE\_UNIT\_FOR\_ANGLE\_PARAMETER | -2,147,220,719 | Invalid angle unit given for angle parameter |
| AD\_E\_INVALID\_LENGTH\_UNIT\_FOR\_DISTANCE\_PARAMETER | -2,147,220,720 | Invalid length unit given for distance parameter |
| AD\_E\_NO\_OPEN\_TRANSACTION\_TO\_MODIFY\_PARAMETER | -2,147,220,721 | No opened transaction found. OpenParameterTransaction () should be called prior to any Parameter modifications. Can not modify parameter |
| AD\_E\_NO\_OPEN\_TRANSACTION\_TO\_CLOSE\_OR\_CANCEL | -2,147,220,722 | No opened transaction found to Close or Cancel |
| AD\_E\_SUBASSEMBLY\_TRANSFORM\_UNSUPPORTED | -2,147,220,723 | Transformation of subassemblies is unsupported |
| AD\_E\_UNSUPPORTED\_OCCURRENCE\_PROPERTY | -2,147,220,724 | This property is not supported for root occurrence and part occurences in an assembly |
| AD\_E\_INVALID\_OCCURRENCE\_TRANSFORM | -2,147,220,725 | Occurrence Transform is invalid. It should not have any scale, shear, reflect or perspective component |
| AD\_E\_INVALID\_SCALE\_FACTOR | -2,147,220,726 | Invalid scale factor. Scale factor cannot be less than 0.000001 or a negative value |
| AD\_E\_UNSUPPORTED\_TRANSFORM\_DATA | -2,147,220,727 | Unsupported transform. Only affine transforms are supported. Perspective components and uniform scaling component(last element in array) should be [0 0 0 1]T. Also transform should not lead to zero scaling |
| AD\_E\_CANNOT\_TRANSFORM\_ROOT\_OCCURRENCE | -2,147,220,728 | Cannot apply transform on a root occurrence in an assembly. |
| AD\_E\_OBSOLETE\_FUNCTION | -2,147,220,729 | This function is obsolete. Please do not use this function. |
| AD\_E\_INVALID\_OVERRIDE\_UNIT | -2,147,220,730 | Invalid Override Unit. It has to be a valid length unit |
| AD\_E\_INVALID\_SAVE\_OPERATION | -2,147,220,731 |  |
| AD\_E\_INVALID\_SURFACE\_TRANSFORM | -2,147,220,732 | Surface Transform is invalid. It should not have any scale, shear, reflect or perspective component |
| AD\_E\_COLOR\_PROPERTY\_READ\_UNSUPPORTED | -2,147,220,733 | Color properties read unsupported for an assembly. Color properties (color, transparency & reflectivity) are not meaningful for an assembly occurence |
| AD\_E\_INVALID\_DIRECTION\_OBJECT | -2,147,220,734 | Invalid Direction Object. Direction Object doesn't match the direction type or is an invalid object |
| AD\_E\_INVALID\_DIRECTION | -2,147,220,735 | Invalid Direction. Direction is of Unknown Type |
| AD\_E\_EXTENTS\_QRY\_FAILED | -2,147,220,736 | Extents query failed. Extents cannot be found for a suppressed feature |
| AD\_E\_UNSUPPORTED\_DIMENSION\_TYPE | -2,147,220,737 | Unsupported dimension type |
| ERR\_REPO\_NO\_UPDATE\_CONSTITUENTS | -2,147,220,738 |  |
| ERR\_REPO\_DISK\_IS\_FULL | -2,147,220,739 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_LABEL\_FOLDER\_READ | -2,147,220,740 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_MOVE\_ITEM\_DELETE | -2,147,220,741 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_MOVE\_FOLDER\_DELETE | -2,147,220,742 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_COPY\_ITEM\_READ | -2,147,220,743 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_COPY\_FOLDER\_READ | -2,147,220,744 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_SHARE\_READ | -2,147,220,745 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_LABEL\_ITEM\_READ | -2,147,220,746 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_BRANCH\_READ | -2,147,220,747 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_GET\_NOTES | -2,147,220,748 |  |
| ERR\_REPO\_REF\_BELONGS\_TO\_ANOTHER\_REPO | -2,147,220,749 |  |
| ERR\_REPO\_NO\_WRITE\_FOLDER\_LOCK\_FILE | -2,147,220,750 |  |
| ERR\_REPO\_NO\_RENAME\_ITEM | -2,147,220,751 |  |
| ERR\_REPO\_ITEM\_IS\_NOT\_A\_FILE | -2,147,220,752 |  |
| ERR\_REPO\_ITEM\_DOES\_NOT\_EXIST | -2,147,220,753 |  |
| ERR\_REPO\_INVALID\_ITEM\_NAME | -2,147,220,754 |  |
| ERR\_REPO\_NO\_RENAME\_FOLDER | -2,147,220,755 |  |
| ERR\_REPO\_FOLDER\_REF\_IS\_NOT\_DIRECTORY | -2,147,220,756 |  |
| ERR\_REPO\_INVALID\_FOLDER\_NAME | -2,147,220,757 |  |
| ERR\_REPO\_DEST\_CANNOT\_BE\_SUBFOLDER\_OF\_SOURCE | -2,147,220,758 |  |
| ERR\_REPO\_FOLDER\_ALREADY\_IN\_TARGET | -2,147,220,759 |  |
| ERR\_REPO\_UNKNOWN\_SECURE\_OBJECT\_TYPE | -2,147,220,760 |  |
| ERR\_REPO\_NO\_DELETE\_FOLDER | -2,147,220,761 |  |
| ERR\_REPO\_NO\_DELETE\_FOLDER\_SECURITY\_FILE | -2,147,220,762 |  |
| ERR\_REPO\_NO\_CREATE\_FOLDER | -2,147,220,763 |  |
| ERR\_REPO\_SOURCE\_ITEM\_ALREADY\_IN\_TARGET | -2,147,220,764 |  |
| ERR\_REPO\_NO\_SHARE\_ITEMS\_INTO\_RECYCLEBIN | -2,147,220,765 |  |
| ERR\_REPO\_NO\_SHARE\_ITEMS\_FROM\_RECYCLEBIN | -2,147,220,766 |  |
| ERR\_REPO\_NO\_RENAME\_ROOT\_FOLDER | -2,147,220,767 |  |
| ERR\_REPO\_NO\_RENAME\_RECYCLEBIN | -2,147,220,768 |  |
| ERR\_REPO\_FILEREPO\_DOES\_NOT\_EXIST | -2,147,220,769 |  |
| ERR\_REPO\_NO\_MOVE\_ITEMS\_INTO\_RECYCLEBIN | -2,147,220,770 |  |
| ERR\_REPO\_NO\_MOVE\_ITEMS\_FROM\_RECYCLEBIN | -2,147,220,771 |  |
| ERR\_REPO\_NO\_MOVE\_FOLDERS\_INTO\_RECYCLEBIN | -2,147,220,772 |  |
| ERR\_REPO\_NO\_ACCESS\_TO\_ITEMS\_IN\_RECYCLEBIN | -2,147,220,773 |  |
| ERR\_REPO\_NO\_MOVE\_ROOT\_FOLDER | -2,147,220,774 |  |
| ERR\_REPO\_NO\_MOVE\_RECYCLEBIN | -2,147,220,775 |  |
| ERR\_REPO\_NO\_DELETE\_RECYCLEBIN | -2,147,220,776 |  |
| ERR\_REPO\_RECYCLEBIN\_IS\_RESERVED\_NAME | -2,147,220,777 |  |
| ERR\_REPO\_NO\_COPY\_ITEMS\_INTO\_RECYCLEBIN | -2,147,220,778 |  |
| ERR\_REPO\_NO\_COPY\_ITEMS\_FROM\_RECYCLEBIN | -2,147,220,779 |  |
| ERR\_REPO\_NO\_COPY\_FOLDERS\_INTO\_RECYCLEBIN | -2,147,220,780 |  |
| ERR\_REPO\_NO\_COPY\_RECYCLEBIN | -2,147,220,781 |  |
| ERR\_REPO\_NO\_BRANCHING\_INTO\_RECYCLEBIN | -2,147,220,782 |  |
| ERR\_REPO\_NO\_BRANCHING\_FROM\_RECYCLEBIN | -2,147,220,783 |  |
| ERR\_REPO\_GUID\_NOT\_FOUND | -2,147,220,784 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_UPDATE | -2,147,220,785 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_UNPIN | -2,147,220,786 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_SHARE | -2,147,220,787 |  |
| ERR\_REPO\_NO\_PERMISSION\_AS\_ADMIN\_FOR\_ITEM | -2,147,220,788 |  |
| ERR\_REPO\_NO\_PERMISSION\_AS\_ADMIN\_FOR\_FOLDER | -2,147,220,789 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_ROLLBACK | -2,147,220,790 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_RENAME\_ITEM | -2,147,220,791 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_RENAME\_FOLDER | -2,147,220,792 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_PURGE | -2,147,220,793 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_PIN | -2,147,220,794 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_CHECKOUT | -2,147,220,795 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_IMPORTMOVE\_ITEM | -2,147,220,796 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_IMPORTMOVE\_FOLDER | -2,147,220,797 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_GET\_WRITABLE\_WORKSPACE | -2,147,220,798 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_GET\_READABLE\_WORKSPACE | -2,147,220,799 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_READ\_ITEM | -2,147,220,800 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_READ\_HISTORY | -2,147,220,801 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_MOVE\_FOLDER | -2,147,220,802 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_MOVE\_ITEM | -2,147,220,803 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_EMPTY\_RECYCLEBIN | -2,147,220,804 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_READ\_FOLDER | -2,147,220,805 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_DELETE\_NOTE | -2,147,220,806 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_DELETE\_ITEM | -2,147,220,807 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_DELETE\_FOLDER | -2,147,220,808 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_CREATE\_ITEM | -2,147,220,809 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_CREATE\_FOLDER | -2,147,220,810 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_COPY\_ITEM | -2,147,220,811 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_COPY\_FOLDER | -2,147,220,812 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_BRANCH | -2,147,220,813 |  |
| ERR\_REPO\_NO\_PERMISSION\_TO\_ADD\_NOTE | -2,147,220,814 |  |
| ERR\_REPO\_REPO\_IS\_READONLY | -2,147,220,815 |  |
| ERR\_REPO\_NAME\_CANNOT\_END\_WITH\_PERIOD | -2,147,220,816 |  |
| ERR\_REPO\_NAME\_CANNOT\_BEGIN\_WITH\_PERIOD | -2,147,220,817 |  |
| ERR\_REPO\_NAME\_EXCEEDS\_MAX\_LENGTH | -2,147,220,818 |  |
| ERR\_REPO\_INVALID\_CHAR | -2,147,220,819 |  |
| ERR\_REPO\_INVALID\_CHAR\_TAB | -2,147,220,820 |  |
| ERR\_REPO\_INVALID\_NAME\_LENGTH | -2,147,220,821 |  |
| ERR\_REPO\_INVALID\_COLUMN\_NUMBER | -2,147,220,822 |  |
| ERR\_REPO\_INVALID\_THUMBNAIL\_TYPE | -2,147,220,823 |  |
| ERR\_REPO\_NOT\_REMOVE\_NODE | -2,147,220,824 |  |
| ERR\_REPO\_NODE\_ALREADY\_EXISTS | -2,147,220,825 |  |
| ERR\_REPO\_NO\_REPO\_SELECTED | -2,147,220,826 |  |
| ERR\_REPO\_NO\_ITEM\_OR\_FOLDER\_REFERENCES | -2,147,220,827 |  |
| ERR\_REPO\_TARGET\_REF\_NOT\_IN\_MAP | -2,147,220,828 |  |
| ERR\_REPO\_UNDO\_COPY\_FAIL | -2,147,220,829 |  |
| ERR\_REPO\_VERSIONHISTORY\_IN\_UNKNOWN\_FORMAT | -2,147,220,830 |  |
| ERR\_REPO\_NO\_DATA\_FOR\_THAT\_VERSION | -2,147,220,831 |  |
| ERR\_REPO\_INVALID\_USERID | -2,147,220,832 |  |
| ERR\_REPO\_VERSION\_IN\_UNKNOWN\_FORMAT | -2,147,220,833 |  |
| ERR\_REPO\_NOT\_STORE\_RECYCLEBIN\_TO\_DISK | -2,147,220,834 |  |
| ERR\_REPO\_NOT\_LOAD\_RECYCLEBIN\_FROM\_DISK | -2,147,220,835 |  |
| ERR\_REPO\_NOT\_READ\_FILE\_FROM\_DISK | -2,147,220,836 |  |
| ERR\_REPO\_INVALID\_REFERENCE\_COUNT | -2,147,220,837 |  |
| ERR\_REPO\_NOT\_DELETE\_FILE | -2,147,220,838 |  |
| ERR\_REPO\_EXISTING\_LABEL\_REFERENCES | -2,147,220,839 |  |
| ERR\_REPO\_INVALID\_LABEL\_FILENAME | -2,147,220,840 |  |
| ERR\_REPO\_NOT\_CLOSE\_FILE | -2,147,220,841 |  |
| ERR\_REPO\_NOT\_WRITE\_FILE\_TO\_DISK | -2,147,220,842 |  |
| ERR\_REPO\_FOLDERITEM\_IN\_UNKNOWN\_FORMAT | -2,147,220,843 |  |
| ERR\_REPO\_UNKNOWN\_OBJECT\_TYPE | -2,147,220,844 |  |
| ERR\_REPO\_NOT\_UNDO\_RESTORE | -2,147,220,845 |  |
| ERR\_REPO\_NOT\_FIND\_RECYCLEBIN\_DATA | -2,147,220,846 |  |
| ERR\_REPO\_NOT\_DELETE\_DIR | -2,147,220,847 |  |
| ERR\_REPO\_ITEM\_POLICY\_INVALID\_SECURE\_OBJECT\_TYPE | -2,147,220,848 |  |
| ERR\_REPO\_NO\_UNDO\_REDO\_HISTORY | -2,147,220,849 |  |
| ERR\_REPO\_FOLDER\_DOES\_NOT\_EXIST | -2,147,220,850 |  |
| ERR\_REPO\_NOT\_CREATE\_WORKSPACES\_DIR | -2,147,220,851 |  |
| ERR\_REPO\_NOT\_CREATE\_VERSIONS\_DIR | -2,147,220,852 |  |
| ERR\_REPO\_NOT\_CREATE\_PROPERTIES\_DIR | -2,147,220,853 |  |
| ERR\_REPO\_NOT\_CREATE\_RECYCLEBIN\_DIR | -2,147,220,854 |  |
| ERR\_REPO\_NOT\_CREATE\_PROJECTS\_DIR | -2,147,220,855 |  |
| ERR\_REPO\_NOT\_CREATE\_LABELS\_DIR | -2,147,220,856 |  |
| ERR\_REPO\_NOT\_CREATE\_HISTORIES\_DIR | -2,147,220,857 |  |
| ERR\_REPO\_NOT\_CREATE\_ROOT\_DIR | -2,147,220,858 |  |
| ERR\_REPO\_ROOT\_PATH\_ALREADY\_EXISTS | -2,147,220,859 |  |
| ERR\_REPO\_INVALID\_SECURE\_OBJECT\_TYPE | -2,147,220,860 |  |
| ERR\_REPO\_REPO\_INSTANCE\_ALREADY\_EXISTS | -2,147,220,861 |  |
| ERR\_REPO\_UNREGISTER\_ITEM\_FAILURE | -2,147,220,862 |  |
| ERR\_REPO\_UNREGISTER\_FOLDER\_FAILURE | -2,147,220,863 |  |
| ERR\_REPO\_MAP\_COLLISION\_FOLDER | -2,147,220,864 |  |
| ERR\_REPO\_MAP\_COLLISION\_ITEM | -2,147,220,865 |  |
| ERR\_REPO\_FOLDER\_NOT\_FOUND | -2,147,220,866 |  |
| ERR\_REPO\_REFERENCE\_NOT\_FOUND | -2,147,220,867 |  |
| ERR\_REPO\_ITEM\_NOT\_IN\_MAP | -2,147,220,868 |  |
| ERR\_REPO\_FOLDER\_NOT\_IN\_MAP | -2,147,220,869 |  |
| ERR\_REPO\_REPO\_NOT\_FOUND | -2,147,220,870 |  |
| ERR\_REPO\_FORWARDING\_ADDRESS | -2,147,220,871 |  |
| ERR\_REPO\_FOLDER\_ALREADY\_EXISTS | -2,147,220,872 |  |
| ERR\_REPO\_ITEM\_ALREADY\_EXISTS | -2,147,220,873 |  |
| ERR\_REPO\_INVALID\_REF\_BAD\_VERSION\_ID | -2,147,220,874 |  |
| ERR\_REPO\_INVALID\_REF\_BAD\_REPO\_NAME | -2,147,220,875 |  |
| ERR\_REPO\_INVALID\_REF\_BAD\_ITEM\_NAME | -2,147,220,876 |  |
| ERR\_REPO\_INVALID\_REF\_BAD\_FOLDER\_PATH | -2,147,220,877 |  |
| ERR\_REPO\_INVALID\_REF\_MISSING\_FOLDER\_PATH | -2,147,220,878 |  |
| ERR\_REPO\_INVALID\_REF\_MISSING\_REPO\_NAME | -2,147,220,879 |  |
| ERR\_REPO\_INVALID\_NULL\_REFERENCE | -2,147,220,880 |  |
| ERR\_REPO\_COULD\_NOT\_FIND\_NOTE | -2,147,220,881 |  |
| ERR\_REPO\_NO\_HISTORY | -2,147,220,882 |  |
| ERR\_REPO\_VERSION\_ALREADY\_EXISTS\_FOR\_ITEM | -2,147,220,883 |  |
| ERR\_REPO\_NO\_FOLDER\_ITEM\_NAME | -2,147,220,884 |  |
| ERR\_REPO\_ITEM\_NAME\_ALREADY\_EXISTS\_IN\_FOLDER | -2,147,220,885 |  |
| ERR\_REPO\_FOLDER\_NAME\_ALREADY\_EXISTS\_IN\_FOLDER | -2,147,220,886 |  |
| JAVA\_E\_EMPTY\_STACK\_EXCEPTION | -2,147,220,887 | java.util.EmptyStackException |
| JAVA\_E\_NO\_SUCH\_ELEMENT\_EXCEPTION | -2,147,220,888 | java.util.NoSuchElementException |
| JAVA\_E\_CONNECT\_EXCEPTION | -2,147,220,889 | java.net.ConnectException |
| JAVA\_E\_NO\_ROUTE\_TO\_HOST\_EXCEPTION | -2,147,220,890 | java.net.NoRouteToHostException |
| JAVA\_E\_MALFORMED\_URL\_EXCEPTION | -2,147,220,891 | java.net.MalformedURLException |
| JAVA\_E\_SOCKET\_EXCEPTION | -2,147,220,892 | java.net.SocketException |
| JAVA\_E\_OBJECT\_STREAM\_EXCEPTION | -2,147,220,893 | java.io.ObjectStreamException |
| JAVA\_E\_INVALIDOBJECT\_EXCEPTION | -2,147,220,894 | java.io.InvalidObjectException |
| JAVA\_E\_NOT\_ACTIVE\_EXCEPTION | -2,147,220,895 | java.io.NotActiveException |
| JAVA\_E\_FILE\_NOT\_FOUND\_EXCEPTION | -2,147,220,896 | java.io.FileNotFoundException |
| JAVA\_E\_EOF\_EXCEPTION | -2,147,220,897 | java.io.EOFException |
| JAVA\_E\_INDEX\_OUT\_OF\_BOUNDS\_EXCEPTION | -2,147,220,898 | java.lang.IndexOutOfBoundsException |
| JAVA\_E\_STRING\_INDEX\_OUT\_OF\_BOUNDS\_EXCEPTION | -2,147,220,899 | java.lang.StringIndexOutOfBoundsException |
| JAVA\_E\_JAVA\_LANG\_RUNTIME\_EXCEPTION | -2,147,220,900 | java.lang.RuntimeException |
| JAVA\_E\_NO\_CLASS\_DEF\_FOUND\_ERROR | -2,147,220,901 | java.lang.NoClassDefFoundError |
| JAVA\_E\_NEGATIVE\_ARRAY\_SIZE\_EXCEPTION | -2,147,220,902 | java.lang.NegativeArraySizeException |
| JAVA\_E\_NO\_SUCH\_FIELD\_EXCEPTION | -2,147,220,903 | java.lang.NoSuchFieldException |
| JAVA\_E\_INSTANTIATION\_EXCEPTION | -2,147,220,904 | java.lang.InstantiationException |
| JAVA\_E\_INVOCATION\_TARGET\_EXCEPTION | -2,147,220,905 | java.lang.reflect.InvocationTargetException |
| AD\_E\_GEOMETRY\_QRY\_FAILED | -2,147,220,906 | Geometry query failed. Unable to extract geometry data |
| AD\_E\_EQUATION\_ILLEGAL | -2,147,220,907 | Illegal equation syntax. Unable to process the equation |
| AD\_E\_EDGE\_ZERO\_LENGTH | -2,147,220,908 | Zero length edge. Can't query the property. |
| AD\_E\_CANNOT\_TRANSFORM\_OCCURRENCE | -2,147,220,909 | Could not transform Occurrence |
| AD\_E\_INVALID\_WEIGHTARRAY\_SIZE | -2,147,220,910 | Invalid Array size for Weights |
| AD\_E\_INVALID\_VKNOTARRAY\_SIZE | -2,147,220,911 | Invalid Array size for V-Knot Vector |
| AD\_E\_INVALID\_UKNOTARRAY\_SIZE | -2,147,220,912 | Invalid Array size for U-Knot Vector |
| AD\_E\_INVALID\_POLEARRAY\_SIZE | -2,147,220,913 | Invalid Array size for Control Points/Poles |
| AD\_E\_GUI\_NOT\_AVAILABLE | -2,147,220,914 | GUI is not available to perform operation |
| AD\_E\_INVALID\_SKETCHFIGURE | -2,147,220,915 | Input sketch figure is not valid for this dimension method |
| AD\_E\_INVALID\_OBJECT | -2,147,220,916 | Can't execute query. Object no longer exists in server |
| AD\_E\_CANNOT\_DELETE\_ROOT | -2,147,220,917 | Can't delete Root Occurrence |
| AD\_E\_ACTIVEOCCURRENCE | -2,147,220,918 | Operation is invalid as the parent Occurrence is not active |
| AD\_E\_NO\_INCLUSIONNODE | -2,147,220,919 | Failed to locate inclusion node |
| AD\_E\_ASSEMBLY\_SESSION\_FAILED | -2,147,220,920 | Failed to create Assembly Session |
| AD\_E\_PART\_SESSION\_FAILED | -2,147,220,921 | Failed to create Part Session |
| AD\_E\_INVALID\_FILE | -2,147,220,922 | Invalid input file type |
| AD\_E\_INVALID\_ASSEMBLYFILE | -2,147,220,923 | Invalid input assembly file type |
| AD\_E\_ASSEMBLY\_INCLUSION\_FAILED | -2,147,220,924 | Failed to create Assembly Occurrence |
| AD\_E\_SM\_INCLUSION\_FAILED | -2,147,220,925 | Failed to create Sheet Metal Occurrence |
| AD\_E\_CANNOT\_INSERT\_OCCURRENCE | -2,147,220,926 | Can't insert Occurrence |
| AD\_E\_PART\_INCLUSION\_FAILED | -2,147,220,927 | Failed to create Part Occurrence |
| AD\_E\_INVALID\_PATHOBJECT | -2,147,220,928 | Invalid Path object. Only IADSketch, IAD3DSketch, and IADEdge are valid |
| AD\_E\_INVALID\_ARRAY | -2,147,220,929 | Incorrect no. of elements. The no. of elements of transformation array must be 16 |
| AD\_E\_INVALID\_POINT | -2,147,220,930 | Invalid input points. Only IADVertex/IADDesignPoint type are allowed |
| AD\_E\_INVALID\_AXIS | -2,147,220,931 | Invalid input for Revolve Axis. Input should be SketchLine/Edge/Axis |
| AD\_E\_CANNOT\_DELETE\_FEATURE | -2,147,220,932 | Can't delete feature |
| AD\_E\_DIRECTION\_PARALELL\_SKETCH | -2,147,220,933 | Invalid Direction. Direction vector parallel to the normal of the sketch |
| AD\_E\_INVALID\_SOURCE\_OBJECT | -2,147,220,934 | The source object is invalid or suppressed |
| AD\_E\_INVALID\_ENDCONDITION | -2,147,220,935 | The input end condition is invalid |
| AD\_E\_INVALID\_SKETCH | -2,147,220,936 | Invalid sketch |
| AD\_E\_AXIS\_PARALELL\_SKETCH | -2,147,220,937 | Invalid Axis. Axis parallel |
| AD\_E\_INVALID\_SKETCHSESSION | -2,147,220,938 | Invalid sketch session |
| AD\_E\_INVALID\_ANGLE | -2,147,220,939 | Invalid angle input |
| AD\_E\_CONSUMED\_SKETCH | -2,147,220,940 | Sketch is already consumed |
| AD\_E\_OPEN\_SKETCH | -2,147,220,941 | Feature operation can't be performed on an open sketch |
| AD\_E\_INVALID\_GEOMETRY | -2,147,220,942 | Invalied input geometry |
| AD\_E\_ZERO\_RADIUS | -2,147,220,943 | Radius can not be zero |
| AD\_E\_ZERO\_DEPTH | -2,147,220,944 | Depth can not be zero |
| AD\_E\_UNSUPPORTED\_OPERATION | -2,147,220,945 | Unsupported operation type |
| AD\_E\_INVALD\_CURRENT\_SKETCHSESSION | -2,147,220,946 | Invalid Sketch Session. Change the Current Sketch Session to Sketch Session associated with the Sketch Figure |
| AD\_E\_OPEN\_FIGURE | -2,147,220,947 | Open or overlapping figures are not supported |
| AD\_E\_TOOFEW\_CTRLPOINTS | -2,147,220,948 | No. of control points should be greater or equal to the order of the Bspline |
| AD\_E\_SKETCH\_CREATION\_FAILED | -2,147,220,949 | Creating Sketch Session failed |
| AD\_E\_CANNOT\_DELETE\_SKETCH | -2,147,220,950 | Can not delete the reference sketch |
| AD\_E\_CANNOT\_DELETE\_POINT | -2,147,220,951 | Can not delete the reference point |
| AD\_E\_CANNOT\_DELETE\_AXIS | -2,147,220,952 | Can not delete the reference axis |
| AD\_E\_CANNOT\_DELETE\_SURFACE | -2,147,220,953 | Cannot delete the design surface |
| AD\_E\_CANNOT\_DELETE\_PLANE | -2,147,220,954 | Can not delete the reference plane |
| AD\_E\_GEOMETRY\_PRODCUER\_FAILED | -2,147,220,955 | Failed while creating the geometry producer |
| AD\_E\_NO\_ACTIVE\_SKETCHSESSION | -2,147,220,956 | No Active Sketch Session available |
| AD\_E\_CURVED\_FACE | -2,147,220,957 | Input Face can't be a Cureved face |
| AD\_E\_AXIS\_PLANE\_PARALLEL | -2,147,220,958 | Invalid Axis/Plane. Axis must be parallel to the plane |
| AD\_E\_NONPLANAR\_FACE | -2,147,220,959 | Invalid input face. Input face must be planar |
| AD\_E\_INVALID\_EDGE | -2,147,220,960 | Invalid input edge. Input edge must be circular |
| AD\_E\_INVALID\_FACE | -2,147,220,961 | Invalid input face. Input face must be curved |
| AD\_E\_INVALID\_PLANE | -2,147,220,962 | Invalid input plane |
| AD\_E\_ACTIVE\_SKETCHSESSION\_EXISTS | -2,147,220,963 | Active Sketch Session already exists |
| AD\_E\_SERVER\_INVALID\_EXPRESSION | -2,147,220,964 | Invalid expression |
| AD\_E\_COLLINEAR\_POINTS | -2,147,220,965 | Cannot create plane with Collinear points |
| AD\_E\_GEOMETRY\_CREATION\_FAILURE | -2,147,220,966 | Geometry creation failed |
| AD\_E\_PHYSICAL\_PROPERTIES\_UNAVIALABLE | -2,147,220,967 | Physical properties could not be calculated |
| AD\_E\_PARAMETER\_TRANSACTION\_ERROR | -2,147,220,968 | Parameter transaction error |
| AD\_E\_PARAMETER\_DOES\_NOT\_EXIST | -2,147,220,969 | Parameter does not exist |
| AD\_E\_PARAMETER\_OPERATION\_UNSUPPORTED | -2,147,220,970 | Unsupported parameter operation |
| AD\_E\_PARAMETER\_EQUATION\_UNSUPPORTED | -2,147,220,971 | Unsupported parameter equation format |
| AD\_E\_PARAMETER\_VALUE\_UNSUPPORTED | -2,147,220,972 | Unsupported parameter value format |
| AD\_E\_PARAMETER\_NAME\_UNSUPPORTED | -2,147,220,973 | Unsupported parameter name format |
| AD\_E\_PARAMETER\_NAME\_EXISTS | -2,147,220,974 | A parameter name already exists |
| AD\_E\_PARAMETER\_TYPE\_UNSUPPORTED | -2,147,220,975 | Unsupported parameter type |
| AD\_E\_OBJECT\_NOT\_FOUND\_AT\_INDEX | -2,147,220,976 | Item Not Found in the collection |
| AD\_E\_DESIGN\_PROPERTIES\_UNAVIALABLE | -2,147,220,977 | Design properties could not be calculated |
| AD\_E\_REPOSVERSIONREF\_INVALID | -2,147,220,978 | RepositoryVersionReference is invalid. This newly created session needs to be saved using SaveAs or SaveNew before calling Save/Close |
| AD\_E\_SESSION\_NOT\_EXIST | -2,147,220,979 | Session does not exist |
| AD\_E\_CANNOT\_WITHDRAW\_INTERNAL\_TYPE | -2,147,220,980 | Cannot withdraw native Alibre part/assembly/drawing |
| AD\_E\_FOLDERITEM\_TYPE\_UNSUPPORTED | -2,147,220,981 | Unsupported folder item type |
| AD\_E\_OCCURRENCE\_NOT\_FOUND\_AT\_INDEX | -2,147,220,982 | Occurrence not found at index |
| AD\_E\_FOLDERITEM\_NOT\_FOUND\_AT\_INDEX | -2,147,220,983 | FolderItem not found at index |
| AD\_E\_FILE\_DOES\_NOT\_EXIST | -2,147,220,984 | File does not exist |
| AD\_E\_FOLDER\_NOT\_FOUND\_AT\_INDEX | -2,147,220,985 | Folder not found at index |
| AD\_E\_INDEX\_OUT\_OF\_BOUNDS | -2,147,220,986 | Index out of bounds |
| AD\_E\_VARIANT\_TYPE\_UNSUPPORTED | -2,147,220,987 | Unsupported variant type |
| AD\_E\_SOBJECT\_TYPE\_UNDEFINED | -2,147,220,988 | SecureObjectTypeProperty is not defined |
| AD\_E\_SOBJECT\_TYPE\_UNKNOWN | -2,147,220,989 | Unknown secureObjectType |
| AD\_E\_OBJECT\_TYPE\_UNSUPPORTED | -2,147,220,990 | Unsupported repository object type |
| AD\_E\_FOLDER\_NOT\_FOUND | -2,147,220,991 | Folder not found or cannot be root folder |
| E\_FIRST | -2,147,220,992 |  |



# IADGeometryFactory.CreateUniformScalingTransform Method

Create a Unifom Scaling Transformation. Scale factor has to be more than or equal to 0.000001

#### Syntax

```
IADTransformation CreateUniformScalingTransform(
	double scaleFactor
)
```

#### Parameters

scaleFactor  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The scale factor of the transformation.

#### Return Value

IADTransformation  
A new scaling transformation.

#### Example

This sample demonstrates creating and using a uniform scaling transformation.

```
// Get the current transform for a valid IADDesignSurface object.
IADTransformation surfaceTransform = designSurface.Transform;
// Use the geometry factory to create the scale transform with a factor of 1.5.
IADTransformation scaleTransform = designSession.GeometryFactory.CreateUniformScalingTransform(1.5);
// Apply the scale transform to the surface's original transform.
surfaceTransform = surfaceTransform.Apply(scaleTransform);
// Set the design surface's transfromation to the scaled transformation.
designSurface.Transform = surfaceTransform;
```



# ADEdgeChamferType Enumeration

#### Syntax

```
public enum ADEdgeChamferType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_DISTANCE\_TO\_DISTANCE | 0 |  |
| AD\_ANGLE\_DISTANCE | 1 |  |
| AD\_EQUAL\_DISTANCE | 2 |  |



# IADGeometryFactory.CreateTransformByVariantArray Method

Creates a transformation with 4X4 Variant array.

#### Syntax

```
IADTransformation CreateTransformByVariantArray(
	Object pArray
)
```

#### Parameters

pArray  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   A 4x4 Variant array defining the transformation.

#### Return Value

IADTransformation  
A new transformation.



# EventManager.OnModelLoadComplete Event

Event notifying that a session has fully loaded.

#### Syntax

```
public event EventManagerSessionLoadCompleteHandler OnModelLoadComplete
```

#### Value

EventManagerSessionLoadCompleteHandler



# IADRoot.TopmostSession Property

Returns an interface to the session whose window is the highest in the Z-order of all Alibre session windows.
If no sessions are open, this property will be null.

#### Syntax

```
IADSession TopmostSession { get; }
```

#### Property Value

IADSession

#### Remarks

The session returned by the property is not necessarily in focus. It is possible that
windows from other programs are on top of the highest Alibre Design window.



# ADViewOrientation Enumeration

This enumeration identifies the different standard orientations which can be used
to create Standard Views in drawings.

#### Syntax

```
[FlagsAttribute]
public enum ADViewOrientation
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_FRONT | 1 | The front view. |
| AD\_BACK | 2 | The back view. |
| AD\_LEFT | 4 | The left view. |
| AD\_RIGHT | 8 | The right view. |
| AD\_TOP | 16 | The top view. |
| AD\_BOTTOM | 32 | The bottom view. |
| AD\_TOP\_LEFT | 64 | The top-left isometric view. |
| AD\_TOP\_RIGHT | 128 | The top-right isometric view. |
| AD\_BOTTOM\_LEFT | 256 | The bottom-left isometric view. |
| AD\_BOTTOM\_RIGHT | 512 | The bottom-right isometric view. |

#### Remarks

Use bitwise OR to specify the creation of several views at once.



# IADAddOns Methods

The IADAddOns type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | ExportFile(String, IADSession) |  |
|  | ExportFile(String, IADSession, String) |  |
|  | ImportFile |  |



# IAD2DPoint.Y Property

Returns the Y coordinate of the 2D point.

#### Syntax

```
double Y { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADPoint.Z Property

Returns the Z coordinate of the 3D point.

#### Syntax

```
double Z { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADRoot.CreateEmptyDrawingEx Method

Creates a new empty Drawing.

#### Syntax

```
IADDrawingSession CreateEmptyDrawingEx(
	string name,
	bool openEditor
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name for the new Drawing.

openEditor  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Flag specifying whether to show the newly created drawing in an editor window

#### Return Value

IADDrawingSession  
The interface to the new Drawing session.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_CREATE\_DRAWING\_SESSION\_FAILED | Alibre failed to create the empty drawing session. |



# IADRoot.Terminate Method

Terminates the Automation client.

#### Syntax

```
void Terminate()
```



# IADSession.SaveAs Method

Saves the session to create a new copy with the given name.

#### Syntax

```
void SaveAs(
	in Object pDestination,
	string itemName
)
```

#### Parameters

pDestination  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The destination can be a windows folder-path string.

itemName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name to be used for the saved file.

#### Remarks

To save to PDM using the API, you will use the same Save methods as with the file system.
The pDestination can be either a IADPDMFolder, IADPDMSafeProject,
IADPDMSafeLibrary interface object or it can be
a folder path String which can be extracted by calling the Reference
method on the IADPDMFolder, IADPDMSafeProject or IADPDMSafeLibrary interfaces.

To save to MFiles vault using the API, you will use the same Save methods as with the file system.
The pDestination would be a filepath string that should be passed in the following format: [MFiles drive letter]:\[Vault name]
(eg. "M:\MyVault").



# IADSession Interface

IADSession interface

#### Syntax

```
public interface IADSession
```

The IADSession type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ConstituentFilePaths | Returns file path strings for other Design files that are referenced by this session. |
|  | FilePath | Returns the location on disk of where the file was last saved. If unsaved, returns null. |
|  | GeometryFactory | Returns the Geometry Factory. |
|  | Identifier | Returns the session's unique identifier. |
|  | IsGUIVisible | Returns True if the GUI for this session is visible. |
|  | Name | Returns this session's name. |
|  | Parameters | Returns a collection of parameters for this session. |
|  | PreviewSnapshot | Returns a OLE picture object containing the preview snapshot bitmap for the session. |
|  | Root | Returns the automation root. |
|  | SelectedObjects | Returns all selected entities in the session's browser as a collection of target proxies. |
|  | SessionType | Returns a pre-defined constant that identifies whether this session is a part or assembly or drawing session. |
|  | TimeStamp | Returns time stamp of this session; the time stamp changes when changes are saved to the session. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SESSION) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | BindKeyToItem | Given a Persistent Key, returns the corresponding Occurrence/Topology element/Sketch. |
|  | Close | Closes the session and optionally saves before closing. |
|  | CreatePackage |  |
|  | Highlight | Highlights the object in the canvas. |
|  | NewTargetProxy | Creates a new TargetProxy for the given target and the occurrence |
|  | Save | Saves modified session and sub-sessions, if any, to their original folder locations. |
|  | SaveAll | Saves a copy of the session and all sub-sessions to the directory indicated by the destination parameter. |
|  | SaveAs | Saves the session to create a new copy with the given name. |
|  | SaveCurrentViewSnapshot | Saves the snapshot of the graphic canvas for current view in the session, at the given location and of the given size. |
|  | SaveNew | Saves a new, unsaved session to the specified folder location. |
|  | Select | Selects all objects passed in pEntities. |
|  | SelectedObjectsEx | Returns all selected entities in the session's browser as a collection of target proxies, and sets the parameter lastSelectedPoint to last point in the user clicked to make the selection. |
|  | UpdatePreviewSnaphot | Captures the canvas image displayed for this session and silently saves it as the file snapshot property |



# IADRoot.GetTeamByName Method

Returns interface describing existing team identified by name.

#### Syntax

```
IADTeam GetTeamByName(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the existing team.

#### Return Value

IADTeam  
An interface to the team.

#### Remarks

This method is obsolete as of V11 of Alibre Design.



# IADRoot.Materials Property

Returns a collection of materials in the material library.

#### Syntax

```
IADMaterials Materials { get; }
```

#### Property Value

IADMaterials



# IADRoot.LanguageForResources Property

Returns the language Alibre is currently running on.

#### Syntax

```
string LanguageForResources { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# EventManager.SessionLoadCompleteHandler Delegate

#### Syntax

```
public delegate void SessionLoadCompleteHandler(
	IADSession pSession
)
```

#### Parameters

pSession  IADSession



# EventManager Events

The EventManager type exposes the following members.

#### Events

|  | Name | Description |
| --- | --- | --- |
|  | OnInitialize | Event notifying that Alibre Design has been initialized. |
|  | OnModelLoadComplete | Event notifying that a session has fully loaded. |
|  | OnSessionChange | Event notifying that a session has been modified. |
|  | OnSessionClose | Event notifying that a new top level session has been opened. |
|  | OnSessionOpen | Event notifying that a new top level session has been opened. |
|  | OnTerminate | Event notifying that Alibre Design has been terminated. |



# IADRoot.MaterialLibraries Property

Returns a collection of material library.

#### Syntax

```
IADMaterialLibraries MaterialLibraries { get; }
```

#### Property Value

IADMaterialLibraries



# IADPoint.X Property

Returns the X coordinate of the 3D point.

#### Syntax

```
double X { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# DIEnum Methods

The DIEnum type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | HasMoreElements | Returns true if the enumerator has more elements. |
|  | NextElement | Returns the next element of the enumerator. |



# ADPartFeatureEndCondition Enumeration

This enumeration identifies different possible end conditions for a number
of part features.

#### Syntax

```
public enum ADPartFeatureEndCondition
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_TO\_DEPTH | 0 | To Depth: The feature will extent to a precise length, specified by a parameter. |
| AD\_MID\_PLANE | 1 | Mid Plane: Extends from the selected face or plane equally in both directions, by a total distance specified by a parameter. Divide this number by two for the distance in one direction. |
| AD\_TO\_NEXT | 2 | To Next: Extends the feature up to the next face(s) of the part. |
| AD\_TO\_GEOMETRY | 3 | To Geometry: A specific face is selected, which will be used as the end condition for the feature. |
| AD\_THROUGH\_ALL | 4 | Through All: Cuts through all existing geometry. Only available for Cut features. |
| AD\_ENTIRE\_PATH | 5 | Entire Path: The feature will be created over the entire length of its path object. |



# IADRoot.AppTitle Property

Returns the version number of the application.

#### Syntax

```
string AppTitle { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADRoot.ImportSATFileEx Method

Creates a new design session from contents of the input SAT file.

#### Syntax

```
IADSession ImportSATFileEx(
	string filePath,
	bool applyImportOptions,
	bool openEditor
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the SAT file to be imported.

applyImportOptions  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Flag specifying whether to apply file import options present in the user's profile.

openEditor  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Flag specifying whether to show the imported session in an editor window

#### Return Value

IADSession  

#### Remarks

This method can show the import options dialog and the editor only if Alibre's UI is running.



# IADEventsCallback.OnInitialize Method

Event notifying that Alibre Design has been initialized.

#### Syntax

```
void OnInitialize()
```



# IADRoot.GetRepositoryReference Method

Returns the repository reference for a given file if it exists in the repository.

#### Syntax

```
string GetRepositoryReference(
	string filePathOnDisk
)
```

#### Parameters

filePathOnDisk  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The full disk path of the file.

#### Return Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADSessions Interface

IADSessions represents the collection of all open sessions in Alibre Design.

#### Syntax

```
public interface IADSessions
```

The IADSessions type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of sessions in this collection. |
|  | Enum | Returns an enumerator for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a name or index, into the collection, returns the corresponding session. |



# IADSession.Identifier Property

Returns the session's unique identifier.

#### Syntax

```
string Identifier { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADSession.FilePath Property

Returns the location on disk of where the file was last saved. If unsaved, returns null.

#### Syntax

```
string FilePath { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADRoot.ListedUsers Property

Returns a collection of users available for collaboration.

#### Syntax

```
IADUsers ListedUsers { get; }
```

#### Property Value

IADUsers

#### Remarks

This method is obsolete as of V11 of Alibre Design.



# IADRoot.SendMessage Method

Sends a notification message to a collection of teams and/or users.

#### Syntax

```
void SendMessage(
	IObjectCollector pUsers,
	IObjectCollector pTeams,
	string message
)
```

#### Parameters

pUsers  IObjectCollector

pTeams  IObjectCollector

message  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Remarks

This method is obsolete as of V11 of Alibre Design.



# ADEntityPointRelation Enumeration

This enumeration identifies the different possible spatial relationships between
a point and a face. The PointOnFace method
uses this enumeration as a return value.

#### Syntax

```
public enum ADEntityPointRelation
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| POINT\_INSIDE\_BOUNDARY | 0 | The point is inside the boundary of the face. |
| POINT\_ON\_BOUNDARY | 1 | The point is on the boundary of the face. |
| POINT\_OUTSIDE\_BOUNDARY | 2 | The point is outside the boundary of the face. |



# IADRoot.CreateTeam Method

Creates a new team and automatically adds the owner to it.

#### Syntax

```
IADTeam CreateTeam(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new team.

#### Return Value

IADTeam  
An interface to the new team.

#### Remarks

This method is obsolete as of V11 of Alibre Design.



# IADRoot.CreateEmptyAssembly Method

Creates an empty assembly.

#### Syntax

```
IADAssemblySession CreateEmptyAssembly(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name for the new assembly.

#### Return Value

IADAssemblySession  
The interface to the new assembly.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_ASSEMBLY\_SESSION\_FAILED | Alibre failed to create the empty assembly session. |

#### Example

This Visual Basic sample shows how to use the CreateEmptyAssembly method.

```
' Holds Session object
Dim objADSession As AlibreX.IADSession

' Create a new Assembly using CreateEmptyAssembly() on Root object.
Set objADSession = m_objADRoot.CreateEmptyAssembly("NewAssembly")

' Verify Name on the new Session
Debug.Print "Session.Name = " & objADSession.Name

' Verify Session Type
If objADSession.SessionType = AD_ASSEMBLY Then
    Debug.Print "Session.SessionType = AD_ASSEMBLY"
Else
    Debug.Print "Session.SessionType <> AD_ASSEMBLY"
End If
```



# IADVector.Length Property

Returns the length of the vector.

#### Syntax

```
double Length { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADRoot.Type Property

Returns a pre-defined constant that identifies the type (AD\_ROOT) of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# ADLoftGuideType Enumeration

This enumeration identifies the different options available for
guide curves in a Loft feature.

#### Syntax

```
public enum ADLoftGuideType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_UNKNOWN | 0 | Unknown; generally indicates an error. |
| AD\_GLOBAL | 1 | Global |
| AD\_LOCAL | 2 | Local |
| AD\_TANGENT | 3 | Tangent |
| AD\_CENTERLINE | 4 | Tangent |
| AD\_NONE | 5 | Tangent |



# IADGeometryFactory.CreatePoint Method

Creates a 3D point from the given coordinates.

#### Syntax

```
IADPoint CreatePoint(
	double X,
	double Y,
	double Z
)
```

#### Parameters

X  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the point.

Y  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the point.

Z  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Z coordinate of the point.

#### Return Value

IADPoint  
The created point.

#### Example

This Visual Basic sample shows how to call the CreatePoint method.

```
' Holds Geometry Factory
Dim objADGeometryFactory As AlibreX.IADGeometryFactory

' Get Geometry Factory from Session object
Set objADGeometryFactory = m_objADSession.GeometryFactory

' Holds Point
Dim objADNewPoint As AlibreX.IADPoint

' Create point at (10, 10, 0) using Geometry Factory
Set objADNewPoint = objADGeometryFactory.CreatePoint(10, 10, 0)
```



# ADAssemblyConstraintType Enumeration

This enumeration identifies the different types of Assembly constraints. This
information can be obtained for a constraint by querying its
ConstraintType property.

#### Syntax

```
public enum ADAssemblyConstraintType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_UNKNOWN\_TYPE | 0 | Unknown; generally indicates an error. |
| AD\_MATE\_TYPE | 1 | IADMateConstraint |
| AD\_ALIGN\_TYPE | 2 | IADAlignConstraint |
| AD\_ORIENT\_TYPE | 3 | IADOrientConstraint |
| AD\_ANGLE\_TYPE | 4 | IADAngleConstraint |
| AD\_TANGENT\_INSIDE\_TYPE | 5 | IADTangentInsideConstraint |
| AD\_TANGENT\_OUTSIDE\_TYPE | 6 | IADTangentOutsideConstraint |
| AD\_FASTENER\_TYPE | 7 | IADFastenerConstraint |
| AD\_GEAR\_TYPE | 8 | IADGearConstraint |
| AD\_RACK\_TYPE | 9 | IADRackConstraint |
| AD\_SCREW\_TYPE | 10 | IADScrewConstraint |



# IADRoot.VaultInfo Property

Returns the Vault Information interface.

#### Syntax

```
IADVaultInfo VaultInfo { get; }
```

#### Property Value

IADVaultInfo



# ADPartFeatureType Enumeration

This enumeration describes the different types of Features available in a Part.
By querying the FeatureType property
of IADPartFeature, you can which derived type to
cast it to, which will have additional methods and properties to query the feature.

#### Syntax

```
public enum ADPartFeatureType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_EXTRUSION\_FEATURE | 0 | IADExtrusionFeature |
| AD\_REVOLUTION\_FEATURE | 1 | IADRevolutionFeature |
| AD\_LOFT\_FEATURE | 2 | IADLoftFeature |
| AD\_SWEEP\_FEATURE | 3 | IADSweepFeature |
| AD\_FILLET\_FEATURE | 4 | IADFilletFeature |
| AD\_CHAMFER\_FEATURE | 5 | IADChamferFeature |
| AD\_SHELL\_FEATURE | 6 | IADShellFeature |
| AD\_DRAFT\_FEATURE | 7 | IADDraftFeature |
| AD\_HOLE\_FEATURE | 8 | IADHoleFeature |
| AD\_MIRROR\_FEATURE | 9 | IADMirrorFeature |
| AD\_PATTERN\_FEATURE | 10 | IADPatternFeature |
| AD\_DESIGNBOOLEAN\_FEATURE | 11 | IADDesignBooleanFeature |
| AD\_SM\_CLOSEDCORNER\_FEATURE | 12 | IADSMClosedCornerFeature |
| AD\_SM\_CORNERCHAMFER\_FEATURE | 13 | IADSMCornerChamferFeature |
| AD\_SM\_CORNERROUND\_FEATURE | 14 | IADSMCornerRoundFeature |
| AD\_SM\_DIMPLE\_FEATURE | 15 | IADSMDimpleFeature |
| AD\_SM\_FLANGE\_FEATURE | 16 | IADSMFlangeFeature |
| AD\_SM\_PUNCH\_FEATURE | 17 | IADSMPunchFeature |
| AD\_SM\_REBEND\_FEATURE | 18 | IADSMRebendFeature |
| AD\_SM\_UNBEND\_FEATURE | 19 | IADSMUnbendFeature |
| AD\_IMPORT\_FILE\_FEATURE | 20 | IADImportFileFeature |
| AD\_SM\_TAB\_FEATURE | 21 | IADSMTabFeature |
| AD\_HELICAL\_FEATURE | 22 | IADHelicalFeature |
| AD\_THIN\_WALL\_EXTRUSION\_FEATURE | 23 | IADThinWallExtrusionFeature |
| AD\_THIN\_WALL\_REVOLUTION\_FEATURE | 24 | IADThinWallRevolutionFeature |
| AD\_THIN\_WALL\_SWEEP\_FEATURE | 25 | IADThinWallSweepFeature |
| AD\_SCALE\_FEATURE | 26 | IADScaleFeature |
| AD\_THICKEN\_SURFACE\_FEATURE | 27 | IADThickenSurfaceFeature |
| AD\_TRIM\_MODEL\_FEATURE | 28 | IADTrimModelFeature |
| AD\_REMOVE\_FACE\_FEATURE | 29 | IADRemoveFaceFeature |
| AD\_OFFSET\_FACE\_FEATURE | 30 | IADOffsetFaceFeature |
| AD\_MOVE\_FACE\_FEATURE | 31 | IADMoveFaceFeature |
| AD\_VERTEX\_CHAMFER\_FEATURE | 32 | IADVertexChamferFeature |
| AD\_EXTERNAL\_THREAD\_FEATURE | 33 | IADExternalThreadFeature |
| AD\_DELETE\_LUMPS\_FEATURE | 34 | IADDeleteLumpsFeature |
| AD\_MESH\_BOOLEAN\_FEATURE | 35 | IADMeshBooleanFeature |
| AD\_WRAP\_FEATURE | 36 | IADWrapFeature |
| AD\_PROJECT\_FEATURE | 37 | IADProjectFeature |
| AD\_CIRCULAR\_PATTERN\_FEATURE | 38 | IADCircularPatternFeature |
| AD\_CIRCULAR\_TOPOLOGY\_PATTERN\_FEATURE | 39 | IADCircularTopologyPatternFeature |
| AD\_LINEAR\_PATTERN\_FEATURE | 40 | IADLinearPatternFeature |
| AD\_LINEAR\_TOPOLOGY\_PATTERN\_FEATURE | 41 | IADLinearTopologyPatternFeature |
| AD\_ALONG\_PATH\_PATTERN\_FEATURE | 42 | IADAlongPathPatternFeature |



# IADGeometryFactory.CreateRotationTransform Method

Create a rotation transformation around an axis (position, direction) by a specified angle.

#### Syntax

```
IADTransformation CreateRotationTransform(
	IADVector rotationAxisDirection,
	IADPoint rotationAxisPosition,
	double rotationAngle
)
```

#### Parameters

rotationAxisDirection  IADVector
:   A vector representing the rotation axis of the new transformation.

rotationAxisPosition  IADPoint
:   A point representing the position of the axis vector.

rotationAngle  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The angle in radians about the rotation axis which the new transformation should describe.

#### Return Value

IADTransformation  
A new rotation transformation.

#### Example

This sample demonstrates creating and using a rotation transformation.

```
// Get the current transform for a valid IADDesignSurface object.
IADTransformation surfaceTransform = designSurface.Transform;
// Create a direction vector to use for the transformation.
// This vector indicates the up direction, the same as the Y-Axis.
IADVector direction = designSession.GeometryFactory.CreateVector(0, 1, 0);
// Create a point for the position at the origin.
IADPoint position = designSession.GeometryFactory.CreatePoint(0, 0, 0);
// Use the geometry factory to create the rotation transform along the vector and 
// at the position.  The rotation angle of PI radians is equivalent to 180 degrees.
// This transformation is equivalent to flipping the surface about the Y-Axis.
IADTransformation rotateTransform = 
      designSession.GeometryFactory.CreateRotationTransform(direction, position, Math.PI);
// Apply the translation transform to the surface's original transform.
surfaceTransform = surfaceTransform.Apply(rotateTransform);
// Set the design surface's transfromation to the translated transformation.
designSurface.Transform = surfaceTransform;
```



# IADRoot.RestorePackage Method

Restores a Alibre Package File (.AD\_PKG) to its expanded constituent native Alibre files.

#### Syntax

```
string RestorePackage(
	string packageFilePath,
	string restoreDirectoryPath,
	bool overwrite
)
```

#### Parameters

packageFilePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the Package file to restore. (\*.AD\_PKG)

restoreDirectoryPath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The target directory where the Alibre files will be restored to.
    If null, the directory of the package file will be used.

overwrite  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, existing files with conflicting names in the restore directory will be overwritten.

#### Return Value

[String](https://learn.microsoft.com/dotnet/api/system.string)  
Returns the filepath of the restored root file of the package.
Open the restored file using OpenFile or
OpenFileWithUI.



# EventManager.OnSessionChange Event

Event notifying that a session has been modified.

#### Syntax

```
public event EventManagerSessionChangeHandler OnSessionChange
```

#### Value

EventManagerSessionChangeHandler



# IADRoot.NewPermissionSelector Method

Creates a new permission selector object used for setting access rights to a repository resource.

#### Syntax

```
IPermissionSelector NewPermissionSelector()
```

#### Return Value

IPermissionSelector  

#### Remarks

This method is obsolete as of V11 of Alibre Design.



# EventManager Methods

The EventManager type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | [Equals](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)) | Determines whether the specified object is equal to the current object. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | [Finalize](https://learn.microsoft.com/dotnet/api/system.object.finalize) | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | [GetHashCode](https://learn.microsoft.com/dotnet/api/system.object.gethashcode) | Serves as the default hash function. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | [GetType](https://learn.microsoft.com/dotnet/api/system.object.gettype) | Gets the [Type](https://learn.microsoft.com/dotnet/api/system.type) of the current instance. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | [MemberwiseClone](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone) | Creates a shallow copy of the current [Object](https://learn.microsoft.com/dotnet/api/system.object). (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |
|  | [ToString](https://learn.microsoft.com/dotnet/api/system.object.tostring) | Returns a string that represents the current object. (Inherited from [Object](https://learn.microsoft.com/dotnet/api/system.object)) |



# ADDetailingOption Enumeration

This enumeration allows specification of which drawing view detailing options to use during view creation.
Use bitwise OR operations to specify any combination of the options. Detailing options which are not available
for the design or view type which is being created will be ignored.

#### Syntax

```
[FlagsAttribute]
public enum ADDetailingOption
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_NONE | 0 |  |
| AD\_DESIGN\_DIMENSIONS | 1 |  |
| AD\_HIDDEN\_LINES | 2 |  |
| AD\_SUPPRESS\_NEW\_CONSTRAINTS | 4 |  |
| AD\_TANGENT\_EDGES | 8 |  |
| AD\_COSMETIC\_THREADS | 16 |  |
| AD\_HOLE\_CALLOUTS | 32 |  |
| AD\_EXTERNAL\_THREAD\_CALLOUTS | 64 |  |
| AD\_CIRCULAR\_HOLE\_PATTERN | 128 |  |
| AD\_LINEAR\_HOLE\_PATTERN | 256 |  |
| AD\_PART\_TRAILS | 512 |  |
| AD\_CENTERMARKS | 1,024 |  |
| AD\_CENTERLINES | 2,048 |  |
| AD\_BEND\_CENTERLINES | 4,096 |  |
| AD\_PROJECT\_FLAT\_PATTERN | 8,192 |  |
| AD\_USE\_SHEET\_SCALE | 16,384 |  |
| AD\_BEND\_NOTES | 32,768 |  |
| AD\_ALL | 65,535 |  |



# IADVector Methods

The IADVector type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | IsEqualTo | Returns whether this vector is equal to the given vector. |
|  | Normalize | Returns the normalized vector. This vector remains unchanged. |



# IADVector.Y Property

Gets the Y direction component.

#### Syntax

```
double Y { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

