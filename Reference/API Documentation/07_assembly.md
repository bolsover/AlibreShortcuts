# AlibreX API — Assembly, Occurrences & Constraints

> Part of the split AlibreX reference. See `00_index.md` for the full map.

**Sections in this file:** 190

---


# IADOccurrence.IsSuppressed Property

Gets/sets the suppression state of this occurrence.

#### Syntax

```
bool IsSuppressed { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADAssemblyPath.getItemOfNestLevel Method

Returns the item at the given Nest level.

#### Syntax

```
IADOccurrence getItemOfNestLevel(
	int itemNestLevel
)
```

#### Parameters

itemNestLevel  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The nest level of the occurrence.

#### Return Value

IADOccurrence  
Returns IADOccurrence



# IADAssemblyConstraints.AddConstraintEx Method

Create a new Assembly Constraint.

#### Syntax

```
IADAssemblyConstraint AddConstraintEx(
	IADTargetProxy first,
	IADTargetProxy second,
	ADAssemblyConstraintType eConstraintType,
	ADAssemblyConstraintBoundType eBoundType = ADAssemblyConstraintBoundType.AD_LOGICAL_TYPE,
	Object parameterValue = null,
	Object parameter2Value = null,
	bool isReversed = false,
	string name = "",
	string parameterName = "",
	string parameter2Name = ""
)
```

#### Parameters

first  IADTargetProxy
:   The first target of the constraint.

second  IADTargetProxy
:   The second target of the constraint

eConstraintType  ADAssemblyConstraintType
:   The type of constraint to be created.

eBoundType  ADAssemblyConstraintBoundType  (Optional)
:   The boundary type of constraint to be created

parameterValue  [Object](https://learn.microsoft.com/dotnet/api/system.object)  (Optional)
:   The value of the parameter of the constraint (such as angle or distance offset) if it has one.

parameter2Value  [Object](https://learn.microsoft.com/dotnet/api/system.object)  (Optional)
:   The value of the second parameter of the constraint if it has one.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)  (Optional)
:   Indicates whether the direction of the constraint should be reveresed.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   A name for the new constraint. If null, one will be generated
    automatically.

parameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   A name for the first parameter if one is needed for the constraint. If null, one will be generated automatically.

parameter2Name  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   A name for the second parameter if one is needed for the constraint. If null, one will be generated automatically.

#### Return Value

IADAssemblyConstraint  
The newly created constraint.



# IADInterference Interface

IADInterference interface

#### Syntax

```
public interface IADInterference
```

The IADInterference type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | InterferenceVolume | Returns volume of this interference in CM^3 |
|  | Part1 | Returns Part 1 in the interference |
|  | Part2 | Returns Part 2 in the interference |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetExtents | Returns the diagonal points of bounding box for the interference volume |



# IADAssemblyConstraint Properties

The IADAssemblyConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint. |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint. |
|  | HasError | Returns True if an error was encountered in evaluating the constraint. |
|  | IsSuppressed | Gets/sets the suppression state of this constraint. |
|  | Name | Gets the name of the constraint. |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT) |



# IADAssemblyConstraint Interface

IADAssemblyConstraint represents a single assembly constraint, which supports all
the necessary and common functionalities of a constraint.

#### Syntax

```
public interface IADAssemblyConstraint
```

The IADAssemblyConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint. |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint. |
|  | HasError | Returns True if an error was encountered in evaluating the constraint. |
|  | IsSuppressed | Gets/sets the suppression state of this constraint. |
|  | Name | Gets the name of the constraint. |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly. |



# IADExplodedView.ExplodedViewSteps Property

Gets the steps created in the exploded view. Each step will move a part
from its initial position to its exploded position or from its exploded position to
its initial position.

#### Syntax

```
IADExplodedViewSteps ExplodedViewSteps { get; }
```

#### Property Value

IADExplodedViewSteps



# IADOccurrence.GetMeshDataForSectionViewEx Method

Returns the index-based triangular mesh data of a sectioned body, including the normals.

#### Syntax

```
void GetMeshDataForSectionViewEx(
	out Array faceData,
	out Array vertexData,
	out Array normalData
)
```

#### Parameters

faceData  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   The faceData contains zero-based indices for facets in mesh.

vertexData  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   The vertexData contains (x,y,z) co-ordinates for triplets of points.

normalData  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   The normalData contains (x,y,z) vector components for normals.

#### Remarks

The x co-ordinate of point i is at [3\*faceData[i]] in vertex array.
To get the size of the faceData, vertexData, and normalData arrays, use the GetMeshDefinitionForSectionViewEx method.



# IADMateConstraint.Offset Property

Returns the distance between the objects participating in the Mate Constraint.

#### Syntax

```
IADParameter Offset { get; }
```

#### Property Value

IADParameter

#### Example

This Visual Basic sample shows how to get the Offset property.

```
' Holds the assembly constraint object
Dim assmConstraint As IADAssemblyConstraint

' Set the assembly constraint object to be the first constraint in the assembly
Set assmConstraint = assmConstraints.Item(0) 

' Holds the Mate constraint object
Dim mateConstraint As IADMateConstraint

' If the first assembly constraint is of Mate constraint type, then display the offset value for the mate constraint
If assmConstraint.ConstraintType = 1 Then
    Set mateConstraint = assmConstraint
    Text1.Text = "Offset value for Mate Constraint is " & mateConstraint.Offset
```



# IADTangentInsideConstraint Properties

The IADTangentInsideConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Offset | Gets the distance between the objects participating in the Tangent Inside Constraint. |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |



# IADExplodedViewStep.Type Property

Returns a pre-defined constant that identifies the type of this object.
(AD\_EXPLODED\_VIEW\_STEP)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADAssemblySession.ExplodedViews Property

Returns the collection of all exploded views in this assembly session.

#### Syntax

```
IADExplodedViews ExplodedViews { get; }
```

#### Property Value

IADExplodedViews



# IADOccurrences.Item Method

Given an occurrence's name or index, returns its occurrence.

#### Syntax

```
IADOccurrence Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or numerical index of an occurrence.

#### Return Value

IADOccurrence  
Returns IADOccurrence



# IADExplodedViewStep Methods

The IADExplodedViewStep type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | InitialTransform | Gets initial transformaion of the occurrence. |
|  | SegmentCount | Gets count of the segments for this occurrence. |
|  | SegmentMemberName | Gets an string of InclusionDesignName objects, corresponding to each segment for this occurrence. |
|  | SegmentTransformations | Gets an IObjectCollector of IADTransformation objects, corresponding to each segment for this occurrence. |



# IADOccurrence.NestLevel Property

Gets nest level of this occurrence.

#### Syntax

```
int NestLevel { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADRackConstraint Interface

IADRackConstraint interface

#### Syntax

```
public interface IADRackConstraint : IADAssemblyConstraint
```

The IADRackConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | PinionRadius | Gets the pinion radius parameter. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADAlignConstraint Methods

The IADAlignConstraint type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADInterference.Part2 Property

Returns Part 2 in the interference

#### Syntax

```
IADOccurrence Part2 { get; }
```

#### Property Value

IADOccurrence

#### Example

See the example for the Part1 property.



# IADAssemblyPath Methods

The IADAssemblyPath type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | getFirstOccurrence | Returns the first Occurrence in the path. |
|  | getItemOfNestLevel | Returns the item at the given Nest level. |
|  | getLastOccurrence | Returns the last Occurrence in the path. |
|  | getRootOccurrence | Returns the root Occurrence in the path. |
|  | Item | Given an Occurrence's name or index, returns its Occurrence. |



# IADTargetProxy.Target Property

The Target retrieved from an IADTargetProxy is the object represented by the proxy,
and may belong to the same or other Occurrence. It
may be reference geometry (IADDesignPlane, IADDesignAxis, IADDesignPoint) or it may
be topology (IADFace, IADEdge, IADVertex).

#### Syntax

```
Object Target { get; }
```

#### Property Value

[Object](https://learn.microsoft.com/dotnet/api/system.object)

#### Remarks

Note that the Target returned is of type "Object". To determine the type
of the Target, use the property "Type". This property is supported on all the objects
that are returned by Alibre Automation Type Library. This way, this property is
late-bound.

#### Example

This Visual Basic sample shows how to determine whether a Edge or Design Axis is specified as Direction for an Extude Boss Feature.

```
Dim objTargetProxy As AlibreX.IADTargetProxy
Set objTargetProxy = objExtrudeBossFeature.Direction

If Not objTargetProxy Is Nothing Then
    Dim objTarget As Object
    Set objTarget = objTargetProxy.Target

    If objTarget.Type = ADObjectType.AD_DESIGN_AXIS Then
        MsgBox "Design Axis is used for specifying Direction"
    ElseIf objTarget.Type = ADObjectType.AD_TOPOLOGY Then
        If objTarget.TopologyType = ADTopologyType.AD_EDGE Then
            MsgBox "Edge is used for specifying Direction"
        End If
    End If
End If
```



# IADOccurrence.Name Property

Returns the occurrence's name.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADAssemblyConstraints.Count Property

The number of constraints in the collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Example

This Visual Basic sample shows how to get the Count property.

```
' Holds Session object
Dim objADSession As AlibreX.IADSession

' Open an existing Assembly using OpenFile() on Root object. Note: User may set it to any required file and location
Set objADSession = m_objADRoot.OpenFile("C:\Assembly.AD_ASM")

' Holds Assembly Session object
Dim objADAssemblySession As AlibreX.IADAssemblySession

' Set Session as Assembly Session
Set objADAssemblySession = objADSession

' Holds Assembly Constraints
Dim assmConstraints As IADAssemblyConstraints

' Set Constraints in Session as Assembly Constarints
Set assmConstraints = assmSession.AssemblyConstraints

' Holds the count of the Assembly Constraints 
Dim numberOfConstraints As Long

' Set the count of the assembly Constraints
numberOfConstraints = assmConstraints.count
```



# IADInterference Properties

The IADInterference type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | InterferenceVolume | Returns volume of this interference in CM^3 |
|  | Part1 | Returns Part 1 in the interference |
|  | Part2 | Returns Part 2 in the interference |



# IADExplodedViewSteps Interface

IADExplodedViewSteps represents the collection of exploded view steps that
make up a particular exploded view. You can
get these steps by querying the exploded view's
ExplodedViewSteps property.

#### Syntax

```
public interface IADExplodedViewSteps
```

The IADExplodedViewSteps type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Gets count of exploded view steps in this collection. |
|  | Enum | Returns an enumerator for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given an exploded view step's name or index, returns the exploded view step. |



# IADAssemblyPath.Enum Property

Returns an enumerator for this path.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADTangentOutsideConstraint Properties

The IADTangentOutsideConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Offset | Gets the distance between the objects participating in the Tangent Outside Constraint. |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |



# IADAngleConstraint.MaximumAngle Property

Gets the maximum angle between the objects participating in the Angle Constraint.

#### Syntax

```
IADParameter MaximumAngle { get; }
```

#### Property Value

IADParameter



# IADAssemblySession Properties

The IADAssemblySession type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ActiveConfiguration | Gets/sets the active configuration for this design session.  (Inherited from IADDesignSession) |
|  | ActiveOccurrence | Sets/Returns the Active Occurrence, which is the one which may be modified. |
|  | AssemblyConstraints | The collection of all constraints in the Assembly Session. |
|  | AutoBrepImportSummary | (Inherited from IADDesignSession) |
|  | AutoRegenerate | Determines whether the DesignSession will be automatically regenerated after a change.  (Inherited from IADDesignSession) |
|  | CameraPosition | Returns an IADPoint with the current location of the camera in this design session.  (Inherited from IADDesignSession) |
|  | CircularFacets | Gets the current display setting for the minimal circular facets option of the design.  (Inherited from IADDesignSession) |
|  | Configurations | Returns the collection of configurations present in this design session.  (Inherited from IADDesignSession) |
|  | ConstituentFilePaths | Returns file path strings for other Design files that are referenced by this session.  (Inherited from IADSession) |
|  | DesignAxes | Returns a collection of design axes for this session.  (Inherited from IADDesignSession) |
|  | DesignMeshes | Returns a collection of design meshes for this session.  (Inherited from IADDesignSession) |
|  | DesignPlanes | Returns a collection of design planes for this session.  (Inherited from IADDesignSession) |
|  | DesignPoints | Returns a collection of design points for this session.  (Inherited from IADDesignSession) |
|  | DesignProperties | Returns the design properties of the design.  (Inherited from IADDesignSession) |
|  | ExplodedViews | Returns the collection of all exploded views in this assembly session. |
|  | Features | Returns the collection of features in this assembly. |
|  | FilePath | Returns the location on disk of where the file was last saved. If unsaved, returns null.  (Inherited from IADSession) |
|  | GeometryFactory | Returns the Geometry Factory.  (Inherited from IADSession) |
|  | HasErrors | Returns true if the design has errors.  (Inherited from IADDesignSession) |
|  | Identifier | Returns the session's unique identifier.  (Inherited from IADSession) |
|  | IGESOptions | Returns an IADIGESOptions object containing the currently selected IGES options. This object has several properties you can get/set to change the current options relating to IGES export.  (Inherited from IADDesignSession) |
|  | IsGUIVisible | Returns True if the GUI for this session is visible.  (Inherited from IADSession) |
|  | IsPerspective | Returns true if the current display of the design is in perspective view mode, rather than orthogonal.  (Inherited from IADDesignSession) |
|  | IsSectioning | Returns true if design has a current active section view.  (Inherited from IADDesignSession) |
|  | ModelTolerance | Returns Model tolerance.  (Inherited from IADDesignSession) |
|  | Name | Returns this session's name.  (Inherited from IADSession) |
|  | Parameters | Returns a collection of parameters for this session.  (Inherited from IADSession) |
|  | PreviewSnapshot | Returns a OLE picture object containing the preview snapshot bitmap for the session.  (Inherited from IADSession) |
|  | Root | Returns the automation root.  (Inherited from IADSession) |
|  | RootOccurrence | The root occurrence of the assembly. |
|  | SavedViews | Gets all the saved views for this session.  (Inherited from IADDesignSession) |
|  | SelectedObjects | Returns all selected entities in the session's browser as a collection of target proxies.  (Inherited from IADSession) |
|  | SelectionFilter | Gets the interface to this design session's selection filter. The interface's properties can be queried to find the current settings or set to change the active selection filters.  (Inherited from IADDesignSession) |
|  | SessionType | Returns a pre-defined constant that identifies whether this session is a part or assembly or drawing session.  (Inherited from IADSession) |
|  | Sketches | Returns the collection of sketches for this design.  (Inherited from IADDesignSession) |
|  | TimeStamp | Returns time stamp of this session; the time stamp changes when changes are saved to the session.  (Inherited from IADSession) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SESSION)  (Inherited from IADSession) |
|  | ViewTransform | Returns view transformation of this design session.  (Inherited from IADDesignSession) |



# IADInterferences.Item Method

Returns the item of given index.

#### Syntax

```
IADInterference Item(
	int index
)
```

#### Parameters

index  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The numerical index of the item.

#### Return Value

IADInterference  
Returns the specified interference.

#### Example

This Visual Basic sample shows how to call the Item method.

```
'Holds Alibre Session object
Dim objSession As IADSession

'Set objSession to the Assembly opened
Set objSession = rootObj.OpenFile("D://Assembly.AD_ASM")

'Holds Alibre Assembly Session object
Dim assmSession As IADAssemblySession  

'Set session as Assembly Session
Set assmSession = objSession

'Holds Interferences Object
Dim iObjects As IADInterferences

'Set the Interferences Object to the interferences in the Assembly
Set iObjects = assmSession.CheckInterference

'Holds Interference Object
Dim iObject As IADInterference

'Set Interference object to be the first item in the interferences
Set iObject = iObjects.Item(0)
```



# IADAlignConstraint.Offset Property

Gets the distance between the objects participating in the Align Constraint.

#### Syntax

```
IADParameter Offset { get; }
```

#### Property Value

IADParameter

#### Example

This Visual Basic sample shows how to get the Offset property.

```
' Holds the assembly constraint object
Dim assmConstraint As IADAssemblyConstraint

' Set the assembly constraint object to be the first constraint in the assembly
Set assmConstraint = assmConstraints.Item(0) 

' Holds the Align constraint object
Dim alignConstraint As IADAlignConstraint

' If the first assembly constraint is of Align constraint type, then display the offset value for the Align constraint
If assmConstraint.ConstraintType = ADAssemblyConstraintType.AD_ALIGN_TYPE Then
    Set alignConstraint = assmConstraint
    Text1.Text = "Offset value for Align Constraint is " & alignConstraint.Offset
```



# IADExplodedViewStep Interface

IADExplodedViewStep represents a single step of an
exploded view of an assembly. Each step is
composed of one or more occurrence with
one or more transformation applied to make
up the segments of the step. Each step will move a part from its initial position
to its exploded position or from its exploded position to its initial position.

#### Syntax

```
public interface IADExplodedViewStep
```

The IADExplodedViewStep type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Description | Gets the description associated with this step. |
|  | ExplodedView | Gets the exploded view for this step. |
|  | Name | Gets the name of this exploded view step. |
|  | Occurrences | Gets the occurrences transformed in this step. |
|  | SerialNumber | Gets the serial number of the step in the sequence of steps. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_EXPLODED\_VIEW\_STEP) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | InitialTransform | Gets initial transformaion of the occurrence. |
|  | SegmentCount | Gets count of the segments for this occurrence. |
|  | SegmentMemberName | Gets an string of InclusionDesignName objects, corresponding to each segment for this occurrence. |
|  | SegmentTransformations | Gets an IObjectCollector of IADTransformation objects, corresponding to each segment for this occurrence. |



# IADOccurrence.Reflectivity Property

Gets/Sets the occurrence's reflectivity.

#### Syntax

```
int Reflectivity { get; set; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

Reflectivity goes from 0 to 100, with 100 being the most shiny, just
like in the GUI.



# IADOccurrence.LocalTransform Property

Returns local transformation of this occurrence that is relative to its immediate parent.

#### Syntax

```
IADTransformation LocalTransform { get; }
```

#### Property Value

IADTransformation



# IADFastenerConstraint.MinimumOffset Property

Gets the minimum distance between the objects participating in the Fastener Constraint.

#### Syntax

```
IADParameter MinimumOffset { get; }
```

#### Property Value

IADParameter



# IADInterference.InterferenceVolume Property

Returns volume of this interference in CM^3

#### Syntax

```
double InterferenceVolume { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Example

This Visual Basic sample shows how to get the InterferenceVolume property.

```
'Holds Alibre Session object
Dim objSession As IADSession

'Set objSession to the Assembly opened
Set objSession = rootObj.OpenFile("D://Assembly.AD_ASM")

'Holds Alibre Assembly Session object
Dim assmSession As IADAssemblySession  

'Set session as Assembly Session
Set assmSession = objSession 

'Holds Interferences Object
Dim iObjects As IADInterferences

'Set the Interferences Object to the interferences in the Assembly
Set iObjects = assmSession.CheckInterference

'Holds Interference Object
Dim iObject As IADInterference

'Set Interference object to be the first item in the interferences
Set iObject = iObjects.Item(0)

'Holds Volume of the Interference as Long
Dim iVolume As Double

'Gets the Volume of the Interference
iVolume = iObject.InterferenceVolume
```



# IADAngleConstraint.MinimumAngle Property

Gets the minimum angle between the objects participating in the Angle Constraint.

#### Syntax

```
IADParameter MinimumAngle { get; }
```

#### Property Value

IADParameter



# IADOrientConstraint Interface

IADOrientConstraint interface

#### Syntax

```
public interface IADOrientConstraint : IADAssemblyConstraint
```

The IADOrientConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADExplodedViews.Count Property

Gets the count of exploded views in this collection

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADOccurrence.DesignSession Property

Returns the design session of the occurrence.

#### Syntax

```
IADDesignSession DesignSession { get; }
```

#### Property Value

IADDesignSession



# IADMateConstraint.MinimumOffset Property

Gets the minimum distance between the objects participating in the Mate Constraint.

#### Syntax

```
IADParameter MinimumOffset { get; }
```

#### Property Value

IADParameter



# IADAssemblyPath.Count Property

Gets count of Occurrences in this path collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADFastenerConstraint Properties

The IADFastenerConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | MaximumOffset | Gets the maximum distance between the objects participating in the Fastener Constraint. |
|  | MinimumOffset | Gets the minimum distance between the objects participating in the Fastener Constraint. |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Offset | Gets the distance between the objects participating in the Fastener Constraint. |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |



# IADTangentInsideConstraint Methods

The IADTangentInsideConstraint type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADExplodedView.Identifier Property

Gets the unique identifier for this exploded view.

#### Syntax

```
string Identifier { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADTargetProxy.DisplayName Property

Returns the display name of the Target object, if available. This name should not be used
as a 'key' to identifying the object, but is only intended for display purposes to help
identify selected items for the user. The display name of topology objects (IADFace, etc.) may
change whenever the design is changed.

#### Syntax

```
string DisplayName { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADInterferences Interface

IADInterferences interface

#### Syntax

```
public interface IADInterferences
```

The IADInterferences type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the count of interferences in the specified Assembly Session. |
|  | Enum | Returns an enumerator for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Returns the item of given index. |



# IADExplodedView.Type Property

Returns a pre-defined constant that identifies the type of this object.
(AD\_EXPLODED\_VIEW)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADAssemblySession.RootOccurrence Property

The root occurrence of the assembly.

#### Syntax

```
IADOccurrence RootOccurrence { get; }
```

#### Property Value

IADOccurrence

#### Remarks

This is the occurrence for this assembly session.

#### Example

This Visual Basic sample shows how to get the RootOccurrence property.

```
' Holds Session object
Dim objADSession As AlibreX.IADSession

' Create a new Assembly using CreateEmptyAssembly() on Root object.
Set objADSession = m_objADRoot.CreateEmptyAssembly("NewAssembly")

' Holds Assembly Session object
Dim objADAssemblySession As AlibreX.IADAssemblySession

' Set Session as Assembly Session
Set objADAssemblySession = objADSession

' Holds Root Occurrence
Dim objADRootOccurrence As AlibreX.IADOccurrence

' Get Root Occurrence from Assembly Session
Set objADRootOccurrence = objADAssemblySession.RootOccurrence()
```



# IADExplodedViews Interface

IADExplodedViews represents the collection of Exploded Views that can be obtained
from an IADAssemblySession by querying its
ExplodedViews property.

#### Syntax

```
public interface IADExplodedViews
```

The IADExplodedViews type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Gets the count of exploded views in this collection |
|  | CurrentExplodedView | Returns the current active exploded view in this assembly session. |
|  | Enum | Returns an enumerator for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given an exploded view's unique identifier or index, returns the exploded view. |



# IADTangentInsideConstraint.Offset Property

Gets the distance between the objects participating in the Tangent Inside Constraint.

#### Syntax

```
IADParameter Offset { get; }
```

#### Property Value

IADParameter

#### Example

This Visual Basic sample shows how to get the Offset property.

```
' Holds the assembly constraint object
Dim assmConstraint As IADAssemblyConstraint

' Set the assembly constraint object to be the first constraint in the assembly
Set assmConstraint = assmConstraints.Item(0)

' Holds the TangentInside constraint object
Dim tangentInside As IADTangentInsideConstraint

' If the first assembly constraint is of TangentInside constraint type, then display the offset value for that constraint
If assmConstraint.ConstraintType = 5 Then
    Set tangentInsideConstraint = assmConstraint
    Text1.Text = "Offset value for TangentInside Constraint is " & tangentInsideConstraint.Offset
```



# IADInterferences Properties

The IADInterferences type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the count of interferences in the specified Assembly Session. |
|  | Enum | Returns an enumerator for the collection. |



# IADGearConstraint Properties

The IADGearConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | Ratio1 | Gets the first gear ratio parameter. |
|  | Ratio2 | Gets the second gear ratio parameter. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |



# IADOccurrence.IsFlexible Property

Gets/sets the flexible property of this occurrence.

#### Syntax

```
bool IsFlexible { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADOrientConstraint Methods

The IADOrientConstraint type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADAssemblyConstraint Methods

The IADAssemblyConstraint type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly. |



# IADAssemblyPath.getFirstOccurrence Method

Returns the first Occurrence in the path.

#### Syntax

```
IADOccurrence getFirstOccurrence()
```

#### Return Value

IADOccurrence  
Returns IADOccurrence



# IADMateConstraint Methods

The IADMateConstraint type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADGearConstraint.Ratio1 Property

Gets the first gear ratio parameter.

#### Syntax

```
IADParameter Ratio1 { get; }
```

#### Property Value

IADParameter

#### Example

This Visual Basic sample shows how to get the Ratio1 property.

```
' Holds the assembly constraint object
Dim assmConstraint As IADAssemblyConstraint

' Set the assembly constraint object to be the first constraint in the assembly
Set assmConstraint = assmConstraints.Item(0) 

' Holds the Align constraint object
Dim gearConstraint As IADGearConstraint

' If the first assembly constraint is of Gear constraint type, then display the ratio 1 value for the Gear constraint
If assmConstraint.ConstraintType = ADAssemblyConstraintType.AD_GEAR_TYPE Then
    Set gearConstraint = assmConstraint
    Text1.Text = "Ratio1 value for Gear Constraint is " & gearConstraint.Ratio1
```



# IADGearConstraint.Ratio2 Property

Gets the second gear ratio parameter.

#### Syntax

```
IADParameter Ratio2 { get; }
```

#### Property Value

IADParameter



# IADTargetProxy Interface

IADTargetProxy represents a wrapper to a specific elemental object. This wrapper wraps
the "native object" (called target) and the Occurrence
to which this target belongs. The target retrieved from this Proxy will be in the local
space of the Occurrence, where it naturally lives. The Client should look upon this Proxy
object as the instance of the target as seen in this Occurrence.

#### Syntax

```
public interface IADTargetProxy
```

The IADTargetProxy type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DisplayName | Returns the display name of the Target object, if available. This name should not be used as a 'key' to identifying the object, but is only intended for display purposes to help identify selected items for the user. The display name of topology objects (IADFace, etc.) may change whenever the design is changed. |
|  | Occurrence | Returns the Occurrence of this Proxy. The target retrieved from this Proxy will be in the local space of this Occurrence, where it naturally lives. |
|  | Target | The Target retrieved from an IADTargetProxy is the object represented by the proxy, and may belong to the same or other Occurrence. It may be reference geometry (IADDesignPlane, IADDesignAxis, IADDesignPoint) or it may be topology (IADFace, IADEdge, IADVertex). |

#### Remarks

Consider an Assembly A containing a
Part P. To represent an element in P, say a
Design Plane, IADTargetProxy can be used. This
Proxy wraps the element (in this case, a Design Plane) and the Occurrence corresponding
to Component P in Assembly A. This way, the element can be represented without any ambiguity.
If the Part P is a standalone Part, then the Occurrence is null in the Proxy object.



# IADAssemblySession.HasInterDesignRelations Method

Returns True if the assembly has at least one constituent whose geometry depends on
geometry from another constituent.

#### Syntax

```
bool HasInterDesignRelations()
```

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)  
Returns true if inter-design relations are present.



# IADAssemblySession Methods

The IADAssemblySession type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | ApplyConstrainedTransformations | Applies an optimized set of transformations to a set of occurrences with constraint evaluation enabled. |
|  | ApplyTransformations | Applies a set of transformations to a set of occurrences. |
|  | BindKeyToItem | Given a Persistent Key, returns the corresponding Occurrence/Topology element/Sketch.  (Inherited from IADSession) |
|  | CheckInterference | Checks interference on the assembly between the occurrences groups given. |
|  | CheckPrintability | Start checking printability, check printability calculating status is on or off.  (Inherited from IADDesignSession) |
|  | Close | Closes the session and optionally saves before closing.  (Inherited from IADSession) |
|  | CreatePackage | (Inherited from IADSession) |
|  | ExportAP203 | Exports the design session as ISO AP203 STEP file.  (Inherited from IADDesignSession) |
|  | ExportAP214 | Exports the design session as ISO AP214 STEP file.  (Inherited from IADDesignSession) |
|  | ExportAP242 | Exports the design session as ISO AP242 STEP file.  (Inherited from IADDesignSession) |
|  | ExportBIP(String) | (Inherited from IADDesignSession) |
|  | ExportBIP(String, String) | (Inherited from IADDesignSession) |
|  | ExportBOM | Export the bill of materials as a .csv file at the specified path.  (Inherited from IADDesignSession) |
|  | ExportIGES | Exports the design session as an IGES file. The settings in Alibre's Options will be used when exporting the file.  (Inherited from IADDesignSession) |
|  | ExportOBJ | Exports the design session as a OBJ file.  (Inherited from IADDesignSession) |
|  | ExportParasolid | Exports the design session as a Parasolid file.  (Inherited from IADDesignSession) |
|  | ExportSAT | Exports the design session as an ACIS SAT file.  (Inherited from IADDesignSession) |
|  | ExportSAT2 | Exports the design as an ACIS SAT file.  (Inherited from IADDesignSession) |
|  | ExportSTEP | Exports the design session as a Alibre STEP file.  (Inherited from IADDesignSession) |
|  | ExportSTL | Exports the design session as an STL file.  (Inherited from IADDesignSession) |
|  | ExportSTL2 | Exports the design session as an STL file.  (Inherited from IADDesignSession) |
|  | GetInclusionCount | Returns the number of times an instance of the speicified child session is included in the Assembly. Sub-assemblies will be searched as well. |
|  | HasInterDesignRelations | Returns True if the assembly has at least one constituent whose geometry depends on geometry from another constituent. |
|  | Highlight | Highlights the object in the canvas.  (Inherited from IADSession) |
|  | NewTargetProxy | Creates a new TargetProxy for the given target and the occurrence  (Inherited from IADSession) |
|  | PhysicalProperties | Returns the physical properties of this design. These properties include Number of faces, Number of edges, Number of vertices, Volume, Mass, Center of mass, etc.  (Inherited from IADDesignSession) |
|  | postProcessPrintabilityChecking | Postprocess of printability checking (Clear body member cache.)  (Inherited from IADDesignSession) |
|  | preparePrintabilityChecking | Prepares printability meshes. This is only for Alibre Test Bed.  (Inherited from IADDesignSession) |
|  | PrintabilityCheckResults | Returns the printability check results of this design  (Inherited from IADDesignSession) |
|  | RegenerateDesign | Regenerate all the features of the design in this session.  (Inherited from IADDesignSession) |
|  | Save | Saves modified session and sub-sessions, if any, to their original folder locations.  (Inherited from IADSession) |
|  | SaveAll | Saves a copy of the session and all sub-sessions to the directory indicated by the destination parameter.  (Inherited from IADSession) |
|  | SaveAs | Saves the session to create a new copy with the given name.  (Inherited from IADSession) |
|  | SaveCurrentViewSnapshot | Saves the snapshot of the graphic canvas for current view in the session, at the given location and of the given size.  (Inherited from IADSession) |
|  | SaveNew | Saves a new, unsaved session to the specified folder location.  (Inherited from IADSession) |
|  | Select | Selects all objects passed in pEntities.  (Inherited from IADSession) |
|  | SelectedObjectsEx | Returns all selected entities in the session's browser as a collection of target proxies, and sets the parameter lastSelectedPoint to last point in the user clicked to make the selection.  (Inherited from IADSession) |
|  | SetViewTransform | Sets the view transformation of this design session.  (Inherited from IADDesignSession) |
|  | StartChanges | (Inherited from IADDesignSession) |
|  | StopChanges | (Inherited from IADDesignSession) |
|  | SuppressConstraints | Suppresses the input set of constraints that are currently in unsuppressed state. |
|  | UnsuppressConstraints | Unsuppresses the input set of constraints that are currently in suppressed state. |
|  | UpdatePreviewSnaphot | Captures the canvas image displayed for this session and silently saves it as the file snapshot property  (Inherited from IADSession) |
|  | ViewExtents | Returns view extents of this design session, in screen coordinates.  (Inherited from IADDesignSession) |



# IADFastenerConstraint.MaximumOffset Property

Gets the maximum distance between the objects participating in the Fastener Constraint.

#### Syntax

```
IADParameter MaximumOffset { get; }
```

#### Property Value

IADParameter



# IADExplodedViewStep.InitialTransform Method

Gets initial transformaion of the occurrence.

#### Syntax

```
IADTransformation InitialTransform(
	IADOccurrence pOccurrence
)
```

#### Parameters

pOccurrence  IADOccurrence
:   The occurrence to get the intial transformation of.

#### Return Value

IADTransformation  
Returns IADTransformation



# IADTangentOutsideConstraint.Offset Property

Gets the distance between the objects participating in the Tangent Outside Constraint.

#### Syntax

```
IADParameter Offset { get; }
```

#### Property Value

IADParameter



# IADOccurrence Properties

The IADOccurrence type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Color | Gets/Sets the occurrence's color. |
|  | Configuration | Gets/sets the configuration of the occurrence. |
|  | DesignSession | Returns the design session of the occurrence. |
|  | IsAnchored | Gets/Sets the anchored property of this occurrence. |
|  | IsFlexible | Gets/sets the flexible property of this occurrence. |
|  | IsHidden | Gets/Sets the hidden property of this occurrence. |
|  | IsSuppressed | Gets/sets the suppression state of this occurrence. |
|  | Key | Gets the Persistent Key property of this occurrence. |
|  | LocalTransform | Returns local transformation of this occurrence that is relative to its immediate parent. |
|  | Name | Returns the occurrence's name. |
|  | NestLevel | Gets nest level of this occurrence. |
|  | Occurrences | Returns child occurrences. |
|  | ParentAssemblySession | Returns the assembly session of parent occurrence. |
|  | ParentOccurrence | Returns the parent occurrence. |
|  | Path | Gets path of occurrence from the root occurrence to this occurrence. |
|  | Reflectivity | Gets/Sets the occurrence's reflectivity. |
|  | RootAssemblySession | Returns the assembly session of root occurrence. |
|  | RootOccurrence | Returns the root occurrence. |
|  | SectionBody | Returns the section body of this occurrence. |
|  | ShowFeatureColor | Returns whether the feature color is shown for this occurrence or not. |
|  | TotalLeafNodes | Gets total number of leaf nodes under this occurrence. |
|  | Transparency | Gets/Sets the occurrence's transparency. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_OCCURRENCE) |
|  | WorldTransform | Returns world transformation of this occurrence that is relative to the root assembly. |



# IADExplodedViewStep.SegmentCount Method

Gets count of the segments for this occurrence.

#### Syntax

```
int SegmentCount(
	IADOccurrence occurrence
)
```

#### Parameters

occurrence  IADOccurrence
:   The occurrence whose segments will be counted.

#### Return Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)  
Returns the number of segments.



# IADRackConstraint.PinionRadius Property

Gets the pinion radius parameter.

#### Syntax

```
IADParameter PinionRadius { get; }
```

#### Property Value

IADParameter



# IADOccurrence.ParentOccurrence Property

Returns the parent occurrence.

#### Syntax

```
IADOccurrence ParentOccurrence { get; }
```

#### Property Value

IADOccurrence



# IADAssemblyConstraints.AddConstraint Method

Create a new Assembly Constraint.

#### Syntax

```
IADAssemblyConstraint AddConstraint(
	IADTargetProxy first,
	IADTargetProxy second,
	ADAssemblyConstraintType type,
	Object parameterValue = null,
	bool isReversed = false,
	string name = "",
	string parameterName = ""
)
```

#### Parameters

first  IADTargetProxy
:   The first target of the constraint.

second  IADTargetProxy
:   The second target of the constraint

type  ADAssemblyConstraintType
:   The type of constraint to be created.

parameterValue  [Object](https://learn.microsoft.com/dotnet/api/system.object)  (Optional)
:   The value of the parameter of the constraint (such
    as angle or distance offset) if it has one.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)  (Optional)
:   Indicates whether the direction of the constraint should be reveresed.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   A name for the new constraint. If null, one will be generated
    automatically.

parameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   A name for the offset/angle parameter if one is created for
    the constraint. If null, one will be generated automatically.

#### Return Value

IADAssemblyConstraint  
The newly created constraint.



# IADExplodedViewSteps Methods

The IADExplodedViewSteps type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given an exploded view step's name or index, returns the exploded view step. |



# IADAssemblyConstraint.Type Property

Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADExplodedViewSteps.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADRackConstraint Properties

The IADRackConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | PinionRadius | Gets the pinion radius parameter. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |



# IADAssemblyConstraint.IsSuppressed Property

Gets/sets the suppression state of this constraint.

#### Syntax

```
bool IsSuppressed { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADExplodedView.Root Property

Returns the automation root.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADOccurrence.RootAssemblySession Property

Returns the assembly session of root occurrence.

#### Syntax

```
IADAssemblySession RootAssemblySession { get; }
```

#### Property Value

IADAssemblySession



# IADFastenerConstraint Methods

The IADFastenerConstraint type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADInterference.Part1 Property

Returns Part 1 in the interference

#### Syntax

```
IADOccurrence Part1 { get; }
```

#### Property Value

IADOccurrence

#### Example

This Visual Basic sample shows how to get the Part1 property.

```
'Holds Alibre Session object
Dim objSession As IADSession

'Set objSession to the Assembly opened
Set objSession = rootObj.OpenFile("D://Assembly.AD_ASM")

'Holds Alibre Assembly Session object
Dim assmSession As IADAssemblySession  

'Set session as Assembly Session
Set assmSession = objSession 

'Holds Interferences Object
Dim iObjects As IADInterferences

'Set the Interferences Object to the interferences in the Assembly
Set iObjects = assmSession.CheckInterference

'Holds Interference Object
Dim iObject As IADInterference

'Set Interference object to be the first item in the interferences
Set iObject = iObjects.Item(0)

'Holds Part1 in the Interefence
Dim iPart1 As IADOccurrence

'Sets Part1 in the Interference
Set iPart1 = iObject.Part1
MsgBox ("Part1 involved in Interference is: " & iPart1.Name)
```



# IADOccurrence.ApplyTransform Method

Applies the input transformation on this occurrence.

#### Syntax

```
void ApplyTransform(
	IADTransformation pTransform
)
```

#### Parameters

pTransform  IADTransformation
:   The transformation to be applied to the occurrence.

#### Remarks

You can create a transformation object
using IADGeometryFactory.



# IADExplodedViewStep.SegmentMemberName Method

Gets an string of InclusionDesignName objects, corresponding to each segment for this occurrence.

#### Syntax

```
string SegmentMemberName(
	IADOccurrence occurrence
)
```

#### Parameters

occurrence  IADOccurrence
:   The occurrence to get InclusionName of.

#### Return Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADOccurrences.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADExplodedViews Properties

The IADExplodedViews type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Gets the count of exploded views in this collection |
|  | CurrentExplodedView | Returns the current active exploded view in this assembly session. |
|  | Enum | Returns an enumerator for the collection. |



# IADExplodedViews.Item Method

Given an exploded view's unique identifier or index, returns the exploded view.

#### Syntax

```
IADExplodedView Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The numerical index or unique identifier of the exploded view.

#### Return Value

IADExplodedView  
Returns IADExplodedView



# IADOccurrence.Key Property

Gets the Persistent Key property of this occurrence.

#### Syntax

```
Array Key { get; }
```

#### Property Value

[Array](https://learn.microsoft.com/dotnet/api/system.array)



# IADTargetProxy Properties

The IADTargetProxy type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DisplayName | Returns the display name of the Target object, if available. This name should not be used as a 'key' to identifying the object, but is only intended for display purposes to help identify selected items for the user. The display name of topology objects (IADFace, etc.) may change whenever the design is changed. |
|  | Occurrence | Returns the Occurrence of this Proxy. The target retrieved from this Proxy will be in the local space of this Occurrence, where it naturally lives. |
|  | Target | The Target retrieved from an IADTargetProxy is the object represented by the proxy, and may belong to the same or other Occurrence. It may be reference geometry (IADDesignPlane, IADDesignAxis, IADDesignPoint) or it may be topology (IADFace, IADEdge, IADVertex). |



# IADExplodedView.Session Property

Returns the assembly session for this exploded view.

#### Syntax

```
IADAssemblySession Session { get; }
```

#### Property Value

IADAssemblySession



# IADAssemblySession.GetInclusionCount Method

Returns the number of times an instance of the speicified child session is included
in the Assembly. Sub-assemblies will be searched as well.

#### Syntax

```
int GetInclusionCount(
	string childSessionID
)
```

#### Parameters

childSessionID  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The session ID of the design to be counted, must belong to this assembly.
    Obtain the ID from the Identifier property of the session.

#### Return Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)  
The number of times childSession is present in this asembly.



# IADOccurrences Methods

The IADOccurrences type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Add | Adds an occurrence of a part or subassembly which can be input as IADDesignSession or a Windows file-path string. |
|  | AddEmptyAssembly | Adds an empty assembly occurrence. |
|  | AddEmptyPart | Adds an empty part occurrence. |
|  | Item | Given an occurrence's name or index, returns its occurrence. |



# IADOccurrence.IsHidden Property

Gets/Sets the hidden property of this occurrence.

#### Syntax

```
bool IsHidden { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADAssemblyConstraints Methods

The IADAssemblyConstraints type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddConstraint | Create a new Assembly Constraint. |
|  | AddConstraintEx | Create a new Assembly Constraint. |
|  | Item | Given a name or index, returns the corresponding constraint. |



# IADAssemblyConstraint.Name Property

Gets the name of the constraint.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADOccurrence.SectionBody Property

Returns the section body of this occurrence.

#### Syntax

```
IADBody SectionBody { get; }
```

#### Property Value

IADBody



# IADInterferences.Count Property

Returns the count of interferences in the specified Assembly Session.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Example

This Visual Basic sample shows how to get the Count property.

```
'Holds Alibre Session object
Dim objSession As IADSession

'Set objSession to the Assembly opened
Set objSession = rootObj.OpenFile("D://Assembly.AD_ASM")

'Holds Alibre Assembly Session object
Dim assmSession As IADAssemblySession  

'Set session as Assembly Session
Set assmSession = objSession

'Holds Interferences Object
Dim iObjects As IADInterferences

'Set the Interferences Object to the interferences in the Assembly
Set iObjects = assmSession.CheckInterference

'Holds the Count of interferences as long
Dim iCount As Long

'Set the count of Interferences in the Assembly
iCount = iObjects.Count
```



# IADOccurrences Properties

The IADOccurrences type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Gets the count of occurrences in this collection. |
|  | Enum | Returns an enumerator for the collection. |



# IADOccurrence.Transparency Property

Gets/Sets the occurrence's transparency.

#### Syntax

```
int Transparency { get; set; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

Acceptable values for the transparency range from 0 to 99. A transparency of
0 makes the part opaque and 99 gives the part the maximum transparency.



# IADOccurrence.GetMeshDefinitionForSectionViewEx Method

Returns the definition of the index-based triangular mesh data of a sectioned body, including the normals.

#### Syntax

```
void GetMeshDefinitionForSectionViewEx(
	int minCircularFacets,
	out int faceDataSize,
	out int vertexDataSize,
	out int normalDataSize
)
```

#### Parameters

minCircularFacets  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The minimum number of facets to be generated for a curved face.

faceDataSize  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   Gets set to the size of the index array containing indices of triangles in the mesh.

vertexDataSize  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   Gets set to the size of an array containing co-ordinates of the vertices in the mesh.

normalDataSize  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   Gets set to the size of an array containing vectors of the normals in the mesh.



# IADOccurrence.RootOccurrence Property

Returns the root occurrence.

#### Syntax

```
IADOccurrence RootOccurrence { get; }
```

#### Property Value

IADOccurrence



# IADOccurrence Interface

IADOccurrence interface

#### Syntax

```
public interface IADOccurrence
```

The IADOccurrence type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Color | Gets/Sets the occurrence's color. |
|  | Configuration | Gets/sets the configuration of the occurrence. |
|  | DesignSession | Returns the design session of the occurrence. |
|  | IsAnchored | Gets/Sets the anchored property of this occurrence. |
|  | IsFlexible | Gets/sets the flexible property of this occurrence. |
|  | IsHidden | Gets/Sets the hidden property of this occurrence. |
|  | IsSuppressed | Gets/sets the suppression state of this occurrence. |
|  | Key | Gets the Persistent Key property of this occurrence. |
|  | LocalTransform | Returns local transformation of this occurrence that is relative to its immediate parent. |
|  | Name | Returns the occurrence's name. |
|  | NestLevel | Gets nest level of this occurrence. |
|  | Occurrences | Returns child occurrences. |
|  | ParentAssemblySession | Returns the assembly session of parent occurrence. |
|  | ParentOccurrence | Returns the parent occurrence. |
|  | Path | Gets path of occurrence from the root occurrence to this occurrence. |
|  | Reflectivity | Gets/Sets the occurrence's reflectivity. |
|  | RootAssemblySession | Returns the assembly session of root occurrence. |
|  | RootOccurrence | Returns the root occurrence. |
|  | SectionBody | Returns the section body of this occurrence. |
|  | ShowFeatureColor | Returns whether the feature color is shown for this occurrence or not. |
|  | TotalLeafNodes | Gets total number of leaf nodes under this occurrence. |
|  | Transparency | Gets/Sets the occurrence's transparency. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_OCCURRENCE) |
|  | WorldTransform | Returns world transformation of this occurrence that is relative to the root assembly. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | ApplyTransform | Applies the input transformation on this occurrence. |
|  | GetExtents | Returns a range box that denotes the max/min of a 3D box for this occurrence. |
|  | GetMeshDataForSectionView | Returns the index-based triangular mesh data of a sectioned body. |
|  | GetMeshDataForSectionViewEx | Returns the index-based triangular mesh data of a sectioned body, including the normals. |
|  | GetMeshDefinitionForSectionView | Returns the definition of the index-based triangular mesh data of a sectioned body. |
|  | GetMeshDefinitionForSectionViewEx | Returns the definition of the index-based triangular mesh data of a sectioned body, including the normals. |



# IADOccurrence.GetMeshDataForSectionView Method

Returns the index-based triangular mesh data of a sectioned body.

#### Syntax

```
void GetMeshDataForSectionView(
	out Array faceData,
	out Array vertexData
)
```

#### Parameters

faceData  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   The faceData contains zero-based indices for facets in mesh.

vertexData  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   The vertexData contains (x,y,z) co-ordinates for triplets of points.

#### Remarks

The x co-ordinate of point i is at [3\*faceData[i]] in vertex array.
To get the size of the faceData and vertexData arrays, use the GetMeshDefinitionForSectionView method.



# IADExplodedViews.CurrentExplodedView Property

Returns the current active exploded view in this assembly session.

#### Syntax

```
IADExplodedView CurrentExplodedView { get; }
```

#### Property Value

IADExplodedView



# IADAssemblySession.Features Property

Returns the collection of features in this assembly.

#### Syntax

```
IADAssemblyFeatures Features { get; }
```

#### Property Value

IADAssemblyFeatures



# IADExplodedViewStep.Description Property

Gets the description associated with this step.

#### Syntax

```
string Description { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADExplodedViewSteps.Item Method

Given an exploded view step's name or index, returns the exploded view step.

#### Syntax

```
IADExplodedViewStep Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or numerical index of the step.

#### Return Value

IADExplodedViewStep  
Returns IADExplodedViewStep



# IADAssemblyPath Interface

IADAssemblyPath represents the path from the root assembly to the selected assembly.

#### Syntax

```
public interface IADAssemblyPath
```

The IADAssemblyPath type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Gets count of Occurrences in this path collection. |
|  | Enum | Returns an enumerator for this path. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | getFirstOccurrence | Returns the first Occurrence in the path. |
|  | getItemOfNestLevel | Returns the item at the given Nest level. |
|  | getLastOccurrence | Returns the last Occurrence in the path. |
|  | getRootOccurrence | Returns the root Occurrence in the path. |
|  | Item | Given an Occurrence's name or index, returns its Occurrence. |



# IADOccurrence.GetMeshDefinitionForSectionView Method

Returns the definition of the index-based triangular mesh data of a sectioned body.

#### Syntax

```
void GetMeshDefinitionForSectionView(
	out int faceDataSize,
	out int vertexDataSize
)
```

#### Parameters

faceDataSize  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   Gets set to the size of the index array containing indices of triangles in the mesh.

vertexDataSize  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   Gets set to the size of an array containing co-ordinates of the vertices in the mesh.



# IADExplodedViewStep.ExplodedView Property

Gets the exploded view for this step.

#### Syntax

```
IADExplodedView ExplodedView { get; }
```

#### Property Value

IADExplodedView



# IADOrientConstraint Properties

The IADOrientConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |



# IADRackConstraint Methods

The IADRackConstraint type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADTangentInsideConstraint Interface

IADTangentInsideConstraint interface

#### Syntax

```
public interface IADTangentInsideConstraint : IADAssemblyConstraint
```

The IADTangentInsideConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Offset | Gets the distance between the objects participating in the Tangent Inside Constraint. |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADMateConstraint Interface

IADMateConstraint interface

#### Syntax

```
public interface IADMateConstraint : IADAssemblyConstraint
```

The IADMateConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | MaximumOffset | Gets the maximum distance between the objects participating in the Mate Constraint. |
|  | MinimumOffset | Gets the minimum distance between the objects participating in the Mate Constraint. |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Offset | Returns the distance between the objects participating in the Mate Constraint. |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADAssemblyConstraint.Participants Property

Returns list of Target Proxies participating in this constraint. This can be a
Face, Edge,
Design Axis, Design Point,
Design Plane or Surface.

#### Syntax

```
IObjectCollector Participants { get; }
```

#### Property Value

IObjectCollector



# IADOccurrences.AddEmptyPart Method

Adds an empty part occurrence.

#### Syntax

```
IADOccurrence AddEmptyPart(
	string name,
	bool isSheetMetal,
	IADTransformation pTransform
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new empty part.

isSheetMetal  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, a sheet metal part will be created.

pTransform  IADTransformation
:   A transformation to specify the location of the new part in the assembly.

#### Return Value

IADOccurrence  
The new part's occurrence.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_ACTIVEOCCURRENCE | The parent occurrence of this collection and the active occurrence must be the same. |

#### Remarks

An active occurrence is required for using this method. If the parent occurrence
of this collection and active occurrence are not the same, this method will throw an exception.

Note that the newly created Occurrence object is not added to the Collection on which this method
is called. Query for the Collection again to get the updated Collection.

You can create a transformation object
using IADGeometryFactory.

#### Example

This Visual Basic sample demonstrates the usage of AddEmptyPart. A new Part Session with "NewPart" as name is added here. The transformation of the new occurrance is set to the "Top" view.

```
' Holds Session object
Dim objADSession As AlibreX.IADSession

' Create a new Assembly using CreateEmptyAssembly() on Root object.
Set objADSession = m_objADRoot.CreateEmptyAssembly("NewAssembly")

' Holds Assembly Session object
Dim objADAssemblySession As AlibreX.IADAssemblySession

' Set Session as Assembly Session
Set objADAssemblySession = objADSession

' Holds Root Occurrence
Dim objADRootOccurrence As AlibreX.IADOccurrence

' Get Root Occurrence from Assembly Session
Set objADRootOccurrence = objADAssemblySession.RootOccurrence()

' Holds Occurrences
Dim objADOccurrences As AlibreX.IADOccurrences

' Get Occurrences collection from Root Occurance
Set objADOccurrences = objADRootOccurrence.Occurrences()

' Holds Geometry Factory
Dim objADGeometryFactory As AlibreX.IADGeometryFactory

' Get Geometry Factory from Session object
Set objADGeometryFactory = objADSession.GeometryFactory

' Holds Transformation Array Data
Dim adblTransformationArrayData(15) As Double

' Populate the Transformation Array with the following Data for Top View
'   1   0   0   0
'   0   0   1   0
'   0  -1   0   0
'   0   0   0   1

adblTransformationArrayData(0) = 1
adblTransformationArrayData(1) = 0
adblTransformationArrayData(2) = 0
adblTransformationArrayData(3) = 0

adblTransformationArrayData(4) = 0
adblTransformationArrayData(5) = 0
adblTransformationArrayData(6) = 1
adblTransformationArrayData(7) = 0

adblTransformationArrayData(8) = 0
adblTransformationArrayData(9) = -1
adblTransformationArrayData(10) = 0
adblTransformationArrayData(11) = 0

adblTransformationArrayData(12) = 0
adblTransformationArrayData(13) = 0
adblTransformationArrayData(14) = 0
adblTransformationArrayData(15) = 1

' Holds Transformation
Dim objADTransformation As AlibreX.IADTransformation

' Create Transformation
Set objADTransformation = objADGeometryFactory.CreateTransform( _
        adblTransformationArrayData())

' Holds Occurrence object
Dim objADOccurrence As AlibreX.IADOccurrence

' Add an Empty Part as Occurrence
Set objADOccurrence = objADOccurrences.AddEmptyPart( _
        "NewPart", False, objADTransformation)

' Verify Name on the new Occurrence
Debug.Print "Occurrence.Name = " & objADOccurrence.Name

' Holds Session object
Dim objADNewSession As AlibreX.IADSession

' Get Design Session of the Occurrence
Set objADNewSession = objADOccurrence.DesignSession

' Verify Session Type
If objADNewSession.SessionType = AD_PART Then
    Debug.Print "Session.SessionType =  AD_PART"
Else
    Debug.Print "Session.SessionType <>  AD_PART"
End If
```



# IADAlignConstraint.MinimumOffset Property

Gets the minimum distance between the objects participating in the Align Constraint.

#### Syntax

```
IADParameter MinimumOffset { get; }
```

#### Property Value

IADParameter



# IADOccurrence.Occurrences Property

Returns child occurrences.

#### Syntax

```
IADOccurrences Occurrences { get; }
```

#### Property Value

IADOccurrences

#### Example

This Visual Basic sample shows how to get the Occurrences property.

```
' Holds Root Occurrence
Dim objADRootOccurrence As AlibreX.IADOccurrence

' Get Root Occurrence from Assembly Session
Set objADRootOccurrence = objADAssemblySession.RootOccurrence()

' Holds Occurrences
Dim objADOccurrences As AlibreX.IADOccurrences

' Get Occurrences collection from Root Occurance
Set objADOccurrences = objADRootOccurrence.Occurrences()
```



# IADGearConstraint Interface

IADGearConstraint interface

#### Syntax

```
public interface IADGearConstraint : IADAssemblyConstraint
```

The IADGearConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | Ratio1 | Gets the first gear ratio parameter. |
|  | Ratio2 | Gets the second gear ratio parameter. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADExplodedView.Name Property

Gets the name of this exploded view.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADAssemblyPath Properties

The IADAssemblyPath type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Gets count of Occurrences in this path collection. |
|  | Enum | Returns an enumerator for this path. |



# IADScrewConstraint Methods

The IADScrewConstraint type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADExplodedViews.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADAssemblySession.SuppressConstraints Method

Suppresses the input set of constraints that are currently in unsuppressed state.

#### Syntax

```
void SuppressConstraints(
	IObjectCollector pConstraints
)
```

#### Parameters

pConstraints  IObjectCollector
:   The collection of IADAssemblyConstraints to be suppressed.



# IADOccurrence.ShowFeatureColor Property

Returns whether the feature color is shown for this occurrence or not.

#### Syntax

```
bool ShowFeatureColor { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADAssemblySession.CheckInterference Method

Checks interference on the assembly between the occurrences groups given.

#### Syntax

```
IADInterferences CheckInterference(
	[OptionalAttribute] in Object occurrencesGroup1,
	[OptionalAttribute] in Object occurrencesGroup2
)
```

#### Parameters

occurrencesGroup1  [Object](https://learn.microsoft.com/dotnet/api/system.object)  (Optional)
:   An array or IObjectCollector
    of IADOccurrence objects in the assembly to check for interferences.

occurrencesGroup2  [Object](https://learn.microsoft.com/dotnet/api/system.object)  (Optional)
:   An array or IObjectCollector
    of IADOccurrence objects in the assembly to check for interferences.

#### Return Value

IADInterferences  
Returns all interferences if any in the assembly session as IADInterferences.
Each Interference can then be accessed using the properties of IADInterferences Interface.

#### Remarks

If both of the occurrence groups are empty, the interference check is
done for the entire assembly. It can also be done on a single group as well.

#### Example

This Visual Basic sample shows how to call the CheckInterference method.

```
'Holds Alibre Session object
Dim objSession As IADSession

'Set objSession to the Assembly opened
Set objSession = rootObj.OpenFile("D://Assembly.AD_ASM")

'Holds Alibre Assembly Session object
Dim assmSession As IADAssemblySession  

'Set session as Assembly Session 
Set assmSession = objSession

'Holds Interferences Object
Dim iObjects As IADInterferences

'Set the Interferences Object to the interferences in the Assembly
Set iObjects = assmSession.CheckInterference
```



# IADInterference Methods

The IADInterference type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetExtents | Returns the diagonal points of bounding box for the interference volume |



# IADOccurrences Interface

IADOccurrences interface

#### Syntax

```
public interface IADOccurrences
```

The IADOccurrences type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Gets the count of occurrences in this collection. |
|  | Enum | Returns an enumerator for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Add | Adds an occurrence of a part or subassembly which can be input as IADDesignSession or a Windows file-path string. |
|  | AddEmptyAssembly | Adds an empty assembly occurrence. |
|  | AddEmptyPart | Adds an empty part occurrence. |
|  | Item | Given an occurrence's name or index, returns its occurrence. |



# IADMateConstraint Properties

The IADMateConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | MaximumOffset | Gets the maximum distance between the objects participating in the Mate Constraint. |
|  | MinimumOffset | Gets the minimum distance between the objects participating in the Mate Constraint. |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Offset | Returns the distance between the objects participating in the Mate Constraint. |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |



# IADAngleConstraint Interface

IADAngleConstraint interface

#### Syntax

```
public interface IADAngleConstraint : IADAssemblyConstraint
```

The IADAngleConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Angle | Gets the angle between the objects participating in the Angle Constraint. |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | MaximumAngle | Gets the maximum angle between the objects participating in the Angle Constraint. |
|  | MinimumAngle | Gets the minimum angle between the objects participating in the Angle Constraint. |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADAssemblyPath.getLastOccurrence Method

Returns the last Occurrence in the path.

#### Syntax

```
IADOccurrence getLastOccurrence()
```

#### Return Value

IADOccurrence  
Returns IADOccurrence



# IADAssemblySession.AssemblyConstraints Property

The collection of all constraints in the Assembly Session.

#### Syntax

```
IADAssemblyConstraints AssemblyConstraints { get; }
```

#### Property Value

IADAssemblyConstraints



# IADAssemblyPath.Item Method

Given an Occurrence's name or index, returns its Occurrence.

#### Syntax

```
IADOccurrence Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or numerical index of the occurrence.

#### Return Value

IADOccurrence  
Returns IADOccurrence



# IADOccurrence.ParentAssemblySession Property

Returns the assembly session of parent occurrence.

#### Syntax

```
IADAssemblySession ParentAssemblySession { get; }
```

#### Property Value

IADAssemblySession



# IADScrewConstraint Interface

IADScrewConstraint interface

#### Syntax

```
public interface IADScrewConstraint : IADAssemblyConstraint
```

The IADScrewConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | Pitch | Gets the pitch parameter. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADInterference.GetExtents Method

Returns the diagonal points of bounding box for the interference volume

#### Syntax

```
void GetExtents(
	out IADPoint ppLower,
	out IADPoint ppUpper
)
```

#### Parameters

ppLower  IADPoint
:   Pointer to IADPoint interface object. This will get
    the bottom left corner of the bounding box for this interference.

ppUpper  IADPoint
:   Pointer to IADPoint interface object. This will get
    the top right corner of the bounding box for this interference.

#### Example

This Visual Basic sample shows how to call the GetExtents method.

```
'Holds Alibre Session object
Dim objSession As IADSession

'Set objSession to the Assembly opened
Set objSession = rootObj.OpenFile("D://Assembly.AD_ASM")

'Holds Alibre Assembly Session object
Dim assmSession As IADAssemblySession  

'Set session as Assembly Session
Set assmSession = objSession 

'Holds Interferences Object
Dim iObjects As IADInterferences

'Set the Interferences Object to the interferences in the Assembly
Set iObjects = assmSession.CheckInterference

'Holds Interference Object
Dim iObject As IADInterference

'Set Interference object to be the first item in the interferences
Set iObject = iObjects.Item(0)

Dim objLowerPoint As IADPoint
Dim objUpperPoint As IADPoint

'Call to the IADInterference.GetExtents Object which returns the diagonal points of bounding box for the interference 'volume as IADPoint
Call iObject.GetExtents(objLowerPoint, objUpperPoint)
MsgBox ("Lower extent coordinates are: " & objLowerPoint.X & "  " & objLowerPoint.Y)
MsgBox ("Upper extent coordinates are: " & objUpperPoint.X & "  " & objUpperPoint.Y)
```



# IADOccurrence.GetExtents Method

Returns a range box that denotes the max/min of a 3D box for this occurrence.

#### Syntax

```
void GetExtents(
	out IADPoint ppLower,
	out IADPoint ppUpper
)
```

#### Parameters

ppLower  IADPoint
:   The lower corner of the exents.

ppUpper  IADPoint
:   The upper corner of the exents.



# IADAssemblyConstraints Properties

The IADAssemblyConstraints type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | The number of constraints in the collection. |
|  | Enum | Returns an enumerator for the collection. |



# IADMateConstraint.MaximumOffset Property

Gets the maximum distance between the objects participating in the Mate Constraint.

#### Syntax

```
IADParameter MaximumOffset { get; }
```

#### Property Value

IADParameter



# IADOccurrence.IsAnchored Property

Gets/Sets the anchored property of this occurrence.

#### Syntax

```
bool IsAnchored { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

In order to set this property, the ActiveOccurrence
must be set to the parent of this
occurrence.



# IADAssemblySession.ApplyConstrainedTransformations Method

Applies an optimized set of transformations to a set of occurrences with constraint
evaluation enabled.

#### Syntax

```
void ApplyConstrainedTransformations(
	IObjectCollector occurrences,
	IObjectCollector transformations
)
```

#### Parameters

occurrences  IObjectCollector
:   A collection of IADOccurrence objects to be transformed.

transformations  IObjectCollector
:   A collection of IADTransformations to be applied to the specified occurrences.



# IADAssemblySession.UnsuppressConstraints Method

Unsuppresses the input set of constraints that are currently in suppressed state.

#### Syntax

```
void UnsuppressConstraints(
	IObjectCollector pConstraints
)
```

#### Parameters

pConstraints  IObjectCollector
:   The collection of IADAssemblyConstraints to be unsuppressed.



# IADAssemblySession.ActiveOccurrence Property

Sets/Returns the Active Occurrence, which is the one which may be modified.

#### Syntax

```
IADOccurrence ActiveOccurrence { get; set; }
```

#### Property Value

IADOccurrence

#### Remarks

If a part/subassembly is being edited from the context of this assembly, it is the active occurrence.
Setting the active occurrence is the same as right clicking a part/subassembly and selecting Edit Here in the UI.

#### Example

This Visual Basic sample shows how to get the ActiveOccurrence property.

```
' Holds Session object
Dim objADSession As AlibreX.IADSession

' Create a new Assembly using CreateEmptyAssembly() on Root object.
Set objADSession = m_objADRoot.CreateEmptyAssembly("NewAssembly")

' Holds Assembly Session object
Dim objADAssemblySession As AlibreX.IADAssemblySession

' Set Session as Assembly Session
Set objADAssemblySession = objADSession

' Holds Active Occurrence
Dim objADActiveOccurrence As AlibreX.IADOccurrence

' Get Active Occurrence from Assembly Session
Set objADActiveOccurrence = objADAssemblySession.ActiveOccurrence()
```



# IADOccurrence.Color Property

Gets/Sets the occurrence's color.

#### Syntax

```
int Color { get; set; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Example

This Visual Basic sample shows how to set the Color property.

```
Dim objOccurrence As IADOccurrence
' Get the root occurrence of the Assembly session 
Set objOccurrence = m_objAlibreAsseblySession.RootOccurrence

Dim objChildOccurrences As IADOccurrences
Dim objChildOccurrence As IADOccurrence
Dim color As Long
'Get the child occurrences of the Root occurrence
Set objChildOccurrences = objOccurrence.Occurrences()

'Get the firt occurrence in the child occurrence collection   
Set objChildOccurrence = objChildOccurrences.Item(0)

'Define the Color with Red = 255, Green = 255 and Blue = 0
color = RGB(255, 255, 0)
'Set the color of the occurrence
objChildOccurrence.Color = color
```



# IADAngleConstraint Methods

The IADAngleConstraint type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADAlignConstraint.MaximumOffset Property

Gets the maximum distance between the objects participating in the Align Constraint.

#### Syntax

```
IADParameter MaximumOffset { get; }
```

#### Property Value

IADParameter



# IADOccurrences.Add Method

Adds an occurrence of a part or subassembly which can be input as
IADDesignSession or a Windows file-path string.

#### Syntax

```
IADOccurrence Add(
	in Object designObject,
	IADTransformation pTransform
)
```

#### Parameters

designObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   A filepath string to the design to add or an
    IADDesignSession.

pTransform  IADTransformation
:   A transformation to specify the location of the inserted design.

#### Return Value

IADOccurrence  
The inserted design's occurrence.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_ACTIVEOCCURRENCE | The parent occurrence of this collection and the active occurrence must be the same. |
| AD\_E\_VARIANT\_TYPE\_UNSUPPORTED | The parameter designObject must be either a string or an IADDesignSession. |
| AD\_E\_INVALID\_FILE | If using a filepath to specify the design it insert, the file must be a Alibre Design part, sheet metal, or assembly file. |
| STD\_E\_INVALIDARG | One or more arguments are invalid. |

#### Remarks

An active occurrence is required for using this method. If the parent occurrence
of this collection and active occurrence are not the same, this method will throw an exception.

Note that the newly created Occurrence object is not added to the Collection on which this method
is called. Query for the Collection again to get the updated Collection.

You can create a transformation object
using IADGeometryFactory.

#### Example

Demonstrates the usage of the Add method. A sample Kettle Part is opened and added to a New Assembly here. The transformation of the new occurrance is set to the "Back" view.

```
' Holds Session object
Dim objADSession As AlibreX.IADSession

' Create a new Assembly using CreateEmptyAssembly() on Root object.
Set objADSession = m_objADRoot.CreateEmptyAssembly("NewAssembly")

' Holds Assembly Session object
Dim objADAssemblySession As AlibreX.IADAssemblySession

' Set Session as Assembly Session
Set objADAssemblySession = objADSession

' Holds Root Occurrence
Dim objADRootOccurrence As AlibreX.IADOccurrence

' Get Root Occurrence from Assembly Session
Set objADRootOccurrence = objADAssemblySession.RootOccurrence()

' Holds Occurrences
Dim objADOccurrences As AlibreX.IADOccurrences

' Get Occurrences collection from Root Occurance
Set objADOccurrences = objADRootOccurrence.Occurrences()

' Holds Geometry Factory
Dim objADGeometryFactory As AlibreX.IADGeometryFactory

' Get Geometry Factory from Session object
Set objADGeometryFactory = objADSession.GeometryFactory

' Holds Transformation Array Data
Dim adblTransformationArrayData(15) As Double

' Populate the Transformation Array with the following Data for Back View
'   1   0   0   0
'   0   1   0   0
'   0   0   1   0
'   0   0   0   1

adblTransformationArrayData(0) = 1
adblTransformationArrayData(1) = 0
adblTransformationArrayData(2) = 0
adblTransformationArrayData(3) = 0

adblTransformationArrayData(4) = 0
adblTransformationArrayData(5) = 1
adblTransformationArrayData(6) = 0
adblTransformationArrayData(7) = 0

adblTransformationArrayData(8) = 0
adblTransformationArrayData(9) = 0
adblTransformationArrayData(10) = 1
adblTransformationArrayData(11) = 0

adblTransformationArrayData(12) = 0
adblTransformationArrayData(13) = 0
adblTransformationArrayData(14) = 0
adblTransformationArrayData(15) = 1

' Holds Transformation
Dim objADTransformation As AlibreX.IADTransformation

' Create Transformation
Set objADTransformation = objADGeometryFactory.CreateTransform( _
        adblTransformationArrayData())

' Holds File Path
Dim strFilePath As String

'Set file path.   Note: To be updated by the user
strFilePath = "\\Alibre\Examples\API_Kettle.AD_PRT"    

Dim objKettlePart As AlibreX.IADDesignSession

' Open Kettle File
Set objKettlePart = m_objADRoot.OpenFile(strFilePath)

' Holds Occurrence object
Dim objADOccurrence As AlibreX.IADOccurrence

' Add an Empty Part as Occurrence
Set objADOccurrence = objADOccurrences.Add( _
        objKettlePart, objADTransformation)
```



# IADOccurrence Methods

The IADOccurrence type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | ApplyTransform | Applies the input transformation on this occurrence. |
|  | GetExtents | Returns a range box that denotes the max/min of a 3D box for this occurrence. |
|  | GetMeshDataForSectionView | Returns the index-based triangular mesh data of a sectioned body. |
|  | GetMeshDataForSectionViewEx | Returns the index-based triangular mesh data of a sectioned body, including the normals. |
|  | GetMeshDefinitionForSectionView | Returns the definition of the index-based triangular mesh data of a sectioned body. |
|  | GetMeshDefinitionForSectionViewEx | Returns the definition of the index-based triangular mesh data of a sectioned body, including the normals. |



# IADOccurrences.Count Property

Gets the count of occurrences in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADExplodedView Properties

The IADExplodedView type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ExplodedViewSteps | Gets the steps created in the exploded view. Each step will move a part from its initial position to its exploded position or from its exploded position to its initial position. |
|  | Identifier | Gets the unique identifier for this exploded view. |
|  | IsCurrent | Return whether the exploded view is a current view. |
|  | Name | Gets the name of this exploded view. |
|  | Root | Returns the automation root. |
|  | Session | Returns the assembly session for this exploded view. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_EXPLODED\_VIEW) |



# IADExplodedViewStep.Occurrences Property

Gets the occurrences transformed in this step.

#### Syntax

```
IADOccurrences Occurrences { get; }
```

#### Property Value

IADOccurrences



# IADExplodedView Interface

IADExplodedView represents an exploded view of an assembly,
which can subsequently be used as views in drawings. Exploded views affect the display only,
constraints are not modified.

#### Syntax

```
public interface IADExplodedView
```

The IADExplodedView type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ExplodedViewSteps | Gets the steps created in the exploded view. Each step will move a part from its initial position to its exploded position or from its exploded position to its initial position. |
|  | Identifier | Gets the unique identifier for this exploded view. |
|  | IsCurrent | Return whether the exploded view is a current view. |
|  | Name | Gets the name of this exploded view. |
|  | Root | Returns the automation root. |
|  | Session | Returns the assembly session for this exploded view. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_EXPLODED\_VIEW) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetTransformForOccurrence | Gets the world transform for the occurrence in exploded state. |



# IADAssemblyConstraint.HasError Property

Returns True if an error was encountered in evaluating the constraint.

#### Syntax

```
bool HasError { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADAngleConstraint Properties

The IADAngleConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Angle | Gets the angle between the objects participating in the Angle Constraint. |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | MaximumAngle | Gets the maximum angle between the objects participating in the Angle Constraint. |
|  | MinimumAngle | Gets the minimum angle between the objects participating in the Angle Constraint. |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |



# IADTangentOutsideConstraint Interface

IADTangentOutsideConstraint interface

#### Syntax

```
public interface IADTangentOutsideConstraint : IADAssemblyConstraint
```

The IADTangentOutsideConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Offset | Gets the distance between the objects participating in the Tangent Outside Constraint. |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADAssemblyPath.getRootOccurrence Method

Returns the root Occurrence in the path.

#### Syntax

```
IADOccurrence getRootOccurrence()
```

#### Return Value

IADOccurrence  
Returns IADOccurrence



# IADAlignConstraint Interface

IADAlignConstraint interface

#### Syntax

```
public interface IADAlignConstraint : IADAssemblyConstraint
```

The IADAlignConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | MaximumOffset | Gets the maximum distance between the objects participating in the Align Constraint. |
|  | MinimumOffset | Gets the minimum distance between the objects participating in the Align Constraint. |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Offset | Gets the distance between the objects participating in the Align Constraint. |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADExplodedViews Methods

The IADExplodedViews type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given an exploded view's unique identifier or index, returns the exploded view. |



# IADAssemblySession.ApplyTransformations Method

Applies a set of transformations to a set of occurrences.

#### Syntax

```
void ApplyTransformations(
	IObjectCollector pOccurrences,
	IObjectCollector pTransformations,
	bool runInOptimizedMode
)
```

#### Parameters

pOccurrences  IObjectCollector
:   A collection of IADOccurrence objects to be transformed.

pTransformations  IObjectCollector
:   A collection of IADTransformations to be applied to the specified occurrences.

runInOptimizedMode  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Setting runInOptimizedMode to True will avoid creating undo history.

#### Remarks

Method should be used only in the assembly without any type of constraints.



# IADExplodedViewSteps.Count Property

Gets count of exploded view steps in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADAssemblySession Interface

IADAssemblySession interface

#### Syntax

```
public interface IADAssemblySession : IADDesignSession, 
	IADSession
```

The IADAssemblySession type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ActiveConfiguration | Gets/sets the active configuration for this design session.  (Inherited from IADDesignSession) |
|  | ActiveOccurrence | Sets/Returns the Active Occurrence, which is the one which may be modified. |
|  | AssemblyConstraints | The collection of all constraints in the Assembly Session. |
|  | AutoBrepImportSummary | (Inherited from IADDesignSession) |
|  | AutoRegenerate | Determines whether the DesignSession will be automatically regenerated after a change.  (Inherited from IADDesignSession) |
|  | CameraPosition | Returns an IADPoint with the current location of the camera in this design session.  (Inherited from IADDesignSession) |
|  | CircularFacets | Gets the current display setting for the minimal circular facets option of the design.  (Inherited from IADDesignSession) |
|  | Configurations | Returns the collection of configurations present in this design session.  (Inherited from IADDesignSession) |
|  | ConstituentFilePaths | Returns file path strings for other Design files that are referenced by this session.  (Inherited from IADSession) |
|  | DesignAxes | Returns a collection of design axes for this session.  (Inherited from IADDesignSession) |
|  | DesignMeshes | Returns a collection of design meshes for this session.  (Inherited from IADDesignSession) |
|  | DesignPlanes | Returns a collection of design planes for this session.  (Inherited from IADDesignSession) |
|  | DesignPoints | Returns a collection of design points for this session.  (Inherited from IADDesignSession) |
|  | DesignProperties | Returns the design properties of the design.  (Inherited from IADDesignSession) |
|  | ExplodedViews | Returns the collection of all exploded views in this assembly session. |
|  | Features | Returns the collection of features in this assembly. |
|  | FilePath | Returns the location on disk of where the file was last saved. If unsaved, returns null.  (Inherited from IADSession) |
|  | GeometryFactory | Returns the Geometry Factory.  (Inherited from IADSession) |
|  | HasErrors | Returns true if the design has errors.  (Inherited from IADDesignSession) |
|  | Identifier | Returns the session's unique identifier.  (Inherited from IADSession) |
|  | IGESOptions | Returns an IADIGESOptions object containing the currently selected IGES options. This object has several properties you can get/set to change the current options relating to IGES export.  (Inherited from IADDesignSession) |
|  | IsGUIVisible | Returns True if the GUI for this session is visible.  (Inherited from IADSession) |
|  | IsPerspective | Returns true if the current display of the design is in perspective view mode, rather than orthogonal.  (Inherited from IADDesignSession) |
|  | IsSectioning | Returns true if design has a current active section view.  (Inherited from IADDesignSession) |
|  | ModelTolerance | Returns Model tolerance.  (Inherited from IADDesignSession) |
|  | Name | Returns this session's name.  (Inherited from IADSession) |
|  | Parameters | Returns a collection of parameters for this session.  (Inherited from IADSession) |
|  | PreviewSnapshot | Returns a OLE picture object containing the preview snapshot bitmap for the session.  (Inherited from IADSession) |
|  | Root | Returns the automation root.  (Inherited from IADSession) |
|  | RootOccurrence | The root occurrence of the assembly. |
|  | SavedViews | Gets all the saved views for this session.  (Inherited from IADDesignSession) |
|  | SelectedObjects | Returns all selected entities in the session's browser as a collection of target proxies.  (Inherited from IADSession) |
|  | SelectionFilter | Gets the interface to this design session's selection filter. The interface's properties can be queried to find the current settings or set to change the active selection filters.  (Inherited from IADDesignSession) |
|  | SessionType | Returns a pre-defined constant that identifies whether this session is a part or assembly or drawing session.  (Inherited from IADSession) |
|  | Sketches | Returns the collection of sketches for this design.  (Inherited from IADDesignSession) |
|  | TimeStamp | Returns time stamp of this session; the time stamp changes when changes are saved to the session.  (Inherited from IADSession) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SESSION)  (Inherited from IADSession) |
|  | ViewTransform | Returns view transformation of this design session.  (Inherited from IADDesignSession) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | ApplyConstrainedTransformations | Applies an optimized set of transformations to a set of occurrences with constraint evaluation enabled. |
|  | ApplyTransformations | Applies a set of transformations to a set of occurrences. |
|  | BindKeyToItem | Given a Persistent Key, returns the corresponding Occurrence/Topology element/Sketch.  (Inherited from IADSession) |
|  | CheckInterference | Checks interference on the assembly between the occurrences groups given. |
|  | CheckPrintability | Start checking printability, check printability calculating status is on or off.  (Inherited from IADDesignSession) |
|  | Close | Closes the session and optionally saves before closing.  (Inherited from IADSession) |
|  | CreatePackage | (Inherited from IADSession) |
|  | ExportAP203 | Exports the design session as ISO AP203 STEP file.  (Inherited from IADDesignSession) |
|  | ExportAP214 | Exports the design session as ISO AP214 STEP file.  (Inherited from IADDesignSession) |
|  | ExportAP242 | Exports the design session as ISO AP242 STEP file.  (Inherited from IADDesignSession) |
|  | ExportBIP(String) | (Inherited from IADDesignSession) |
|  | ExportBIP(String, String) | (Inherited from IADDesignSession) |
|  | ExportBOM | Export the bill of materials as a .csv file at the specified path.  (Inherited from IADDesignSession) |
|  | ExportIGES | Exports the design session as an IGES file. The settings in Alibre's Options will be used when exporting the file.  (Inherited from IADDesignSession) |
|  | ExportOBJ | Exports the design session as a OBJ file.  (Inherited from IADDesignSession) |
|  | ExportParasolid | Exports the design session as a Parasolid file.  (Inherited from IADDesignSession) |
|  | ExportSAT | Exports the design session as an ACIS SAT file.  (Inherited from IADDesignSession) |
|  | ExportSAT2 | Exports the design as an ACIS SAT file.  (Inherited from IADDesignSession) |
|  | ExportSTEP | Exports the design session as a Alibre STEP file.  (Inherited from IADDesignSession) |
|  | ExportSTL | Exports the design session as an STL file.  (Inherited from IADDesignSession) |
|  | ExportSTL2 | Exports the design session as an STL file.  (Inherited from IADDesignSession) |
|  | GetInclusionCount | Returns the number of times an instance of the speicified child session is included in the Assembly. Sub-assemblies will be searched as well. |
|  | HasInterDesignRelations | Returns True if the assembly has at least one constituent whose geometry depends on geometry from another constituent. |
|  | Highlight | Highlights the object in the canvas.  (Inherited from IADSession) |
|  | NewTargetProxy | Creates a new TargetProxy for the given target and the occurrence  (Inherited from IADSession) |
|  | PhysicalProperties | Returns the physical properties of this design. These properties include Number of faces, Number of edges, Number of vertices, Volume, Mass, Center of mass, etc.  (Inherited from IADDesignSession) |
|  | postProcessPrintabilityChecking | Postprocess of printability checking (Clear body member cache.)  (Inherited from IADDesignSession) |
|  | preparePrintabilityChecking | Prepares printability meshes. This is only for Alibre Test Bed.  (Inherited from IADDesignSession) |
|  | PrintabilityCheckResults | Returns the printability check results of this design  (Inherited from IADDesignSession) |
|  | RegenerateDesign | Regenerate all the features of the design in this session.  (Inherited from IADDesignSession) |
|  | Save | Saves modified session and sub-sessions, if any, to their original folder locations.  (Inherited from IADSession) |
|  | SaveAll | Saves a copy of the session and all sub-sessions to the directory indicated by the destination parameter.  (Inherited from IADSession) |
|  | SaveAs | Saves the session to create a new copy with the given name.  (Inherited from IADSession) |
|  | SaveCurrentViewSnapshot | Saves the snapshot of the graphic canvas for current view in the session, at the given location and of the given size.  (Inherited from IADSession) |
|  | SaveNew | Saves a new, unsaved session to the specified folder location.  (Inherited from IADSession) |
|  | Select | Selects all objects passed in pEntities.  (Inherited from IADSession) |
|  | SelectedObjectsEx | Returns all selected entities in the session's browser as a collection of target proxies, and sets the parameter lastSelectedPoint to last point in the user clicked to make the selection.  (Inherited from IADSession) |
|  | SetViewTransform | Sets the view transformation of this design session.  (Inherited from IADDesignSession) |
|  | StartChanges | (Inherited from IADDesignSession) |
|  | StopChanges | (Inherited from IADDesignSession) |
|  | SuppressConstraints | Suppresses the input set of constraints that are currently in unsuppressed state. |
|  | UnsuppressConstraints | Unsuppresses the input set of constraints that are currently in suppressed state. |
|  | UpdatePreviewSnaphot | Captures the canvas image displayed for this session and silently saves it as the file snapshot property  (Inherited from IADSession) |
|  | ViewExtents | Returns view extents of this design session, in screen coordinates.  (Inherited from IADDesignSession) |



# IADExplodedView.IsCurrent Property

Return whether the exploded view is a current view.

#### Syntax

```
bool IsCurrent { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADExplodedViewStep.SerialNumber Property

Gets the serial number of the step in the sequence of steps.

#### Syntax

```
int SerialNumber { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADAssemblyConstraint.ConstraintType Property

Gets the pre-defined constant that identifies the type of the constraint.

#### Syntax

```
ADAssemblyConstraintType ConstraintType { get; }
```

#### Property Value

ADAssemblyConstraintType

#### Remarks

Possible values for this property and their corresponding types include:

- AD\_MATE\_TYPE
- AD\_ALIGN\_TYPE
- AD\_ORIENT\_TYPE
- AD\_ANGLE\_TYPE
- AD\_TANGENT\_INSIDE\_TYPE
- AD\_TANGENT\_OUTSIDE\_TYPE
- AD\_FASTENER\_TYPE
- AD\_GEAR\_TYPE
- AD\_RACK\_TYPE
- AD\_SCREW\_TYPE



# IADOccurrence.WorldTransform Property

Returns world transformation of this occurrence that is relative to the root assembly.

#### Syntax

```
IADTransformation WorldTransform { get; }
```

#### Property Value

IADTransformation



# IADExplodedViewStep Properties

The IADExplodedViewStep type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Description | Gets the description associated with this step. |
|  | ExplodedView | Gets the exploded view for this step. |
|  | Name | Gets the name of this exploded view step. |
|  | Occurrences | Gets the occurrences transformed in this step. |
|  | SerialNumber | Gets the serial number of the step in the sequence of steps. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_EXPLODED\_VIEW\_STEP) |



# IADFastenerConstraint.Offset Property

Gets the distance between the objects participating in the Fastener Constraint.

#### Syntax

```
IADParameter Offset { get; }
```

#### Property Value

IADParameter

#### Example

This Visual Basic sample shows how to get the Offset property.

```
' Holds the assembly constraint object
Dim assmConstraint As IADAssemblyConstraint

' Set the assembly constraint object to be the first constraint in the assembly
Set assmConstraint = assmConstraints.Item(0) 

' Holds the Fastener constraint object
Dim fastenerConstraint As IADFastenerConstraint

' If the first assembly constraint is of Fastener constraint type, then display the offset value for the Fastener constraint
If assmConstraint.ConstraintType = ADAssemblyConstraintType.AD_FASTENER_TYPE Then
    Set fastenerConstraint = assmConstraint
    Text1.Text = "Offset value for Fastener Constraint is " & fastenerConstraint.Offset
```



# IADExplodedViewSteps Properties

The IADExplodedViewSteps type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Gets count of exploded view steps in this collection. |
|  | Enum | Returns an enumerator for the collection. |



# IADOccurrences.AddEmptyAssembly Method

Adds an empty assembly occurrence.

#### Syntax

```
IADOccurrence AddEmptyAssembly(
	string name,
	IADTransformation pTransform
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new empty assembly.

pTransform  IADTransformation
:   A transformation to specify the location of the new assembly.

#### Return Value

IADOccurrence  
The new assembly's occurrence.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_ACTIVEOCCURRENCE | The parent occurrence of this collection and the active occurrence must be the same. |

#### Remarks

An active occurrence is required for using this method. If the parent occurrence
of this collection and active occurrence are not the same, this method will throw an exception.

Note that the newly created Occurrence object is not added to the Collection on which this method
is called. Query for the Collection again to get the updated Collection.

You can create a transformation object
using IADGeometryFactory.

#### Example

This Visual Basic sample demonstrates the usage of AddEmptyAssembly. A new Assembly Session with "NewAssemblyOccurrence" as the name is added here. The transformation of the new occurrance is set to the "Bottom" view.

```
' Holds Session object
Dim objADSession As AlibreX.IADSession

' Create a new Assembly using CreateEmptyAssembly() on Root object.
Set objADSession = m_objADRoot.CreateEmptyAssembly("NewAssembly")

' Holds Assembly Session object
Dim objADAssemblySession As AlibreX.IADAssemblySession

' Set Session as Assembly Session
Set objADAssemblySession = objADSession

' Holds Root Occurrence
Dim objADRootOccurrence As AlibreX.IADOccurrence

' Get Root Occurrence from Assembly Session
Set objADRootOccurrence = objADAssemblySession.RootOccurrence()

' Holds Occurrences
Dim objADOccurrences As AlibreX.IADOccurrences

' Get Occurrences collection from Root Occurance
Set objADOccurrences = objADRootOccurrence.Occurrences()

' Holds Geometry Factory
Dim objADGeometryFactory As AlibreX.IADGeometryFactory

' Get Geometry Factory from Session object
Set objADGeometryFactory = objADSession.GeometryFactory

' Holds Transformation Array Data
Dim adblTransformationArrayData(15) As Double

' Populate the Transformation Array with the following Data for Bottom View
'   1   0   0   0
'   0   0  -1   0
'   0   1   0   0
'   0   0   0   1

adblTransformationArrayData(0) = 1
adblTransformationArrayData(1) = 0
adblTransformationArrayData(2) = 0
adblTransformationArrayData(3) = 0

adblTransformationArrayData(4) = 0
adblTransformationArrayData(5) = 0
adblTransformationArrayData(6) = -1
adblTransformationArrayData(7) = 0

adblTransformationArrayData(8) = 0
adblTransformationArrayData(9) = 1
adblTransformationArrayData(10) = 0
adblTransformationArrayData(11) = 0

adblTransformationArrayData(12) = 0
adblTransformationArrayData(13) = 0
adblTransformationArrayData(14) = 0
adblTransformationArrayData(15) = 1

' Holds Transformation
Dim objADTransformation As AlibreX.IADTransformation

' Create Transformation
Set objADTransformation = objADGeometryFactory.CreateTransform( _
        adblTransformationArrayData())

' Holds Occurrence object
Dim objADOccurrence As AlibreX.IADOccurrence

' Add an Empty Part as Occurrence
Set objADOccurrence = objADOccurrences.AddEmptyAssembly( _
        "NewAssemblyOccurrence", objADTransformation)

' Verify Name on the new Occurrence
Debug.Print "Occurrence.Name = " & objADOccurrence.Name

' Holds Session object

Dim objADNewSession As AlibreX.IADSession

' Get Design Session of the Occurrence
Set objADNewSession = objADOccurrence.DesignSession

' Verify Session Type
If objADNewSession.SessionType = AD_ASSEMBLY Then
    Debug.Print "Session.SessionType =  AD_ASSEMBLY"
Else
    Debug.Print "Session.SessionType <>  AD_ASSEMBLY"
End If
```



# IADOccurrence.Path Property

Gets path of occurrence from the root occurrence to this occurrence.

#### Syntax

```
IADAssemblyPath Path { get; }
```

#### Property Value

IADAssemblyPath



# IADOccurrence.Type Property

Returns a pre-defined constant that identifies the type of this object. (AD\_OCCURRENCE)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADOccurrence.Configuration Property

Gets/sets the configuration of the occurrence.

#### Syntax

```
IADConfiguration Configuration { get; set; }
```

#### Property Value

IADConfiguration



# IADOccurrence.TotalLeafNodes Property

Gets total number of leaf nodes under this occurrence.

#### Syntax

```
int TotalLeafNodes { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADTangentOutsideConstraint Methods

The IADTangentOutsideConstraint type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADExplodedView Methods

The IADExplodedView type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetTransformForOccurrence | Gets the world transform for the occurrence in exploded state. |



# IADAssemblyConstraint.Delete Method

Removes the constraint from the assembly.

#### Syntax

```
void Delete()
```



# IADInterferences Methods

The IADInterferences type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Returns the item of given index. |



# IADAngleConstraint.Angle Property

Gets the angle between the objects participating in the Angle Constraint.

#### Syntax

```
IADParameter Angle { get; }
```

#### Property Value

IADParameter

#### Example

This Visual Basic sample shows how to get the Axis property.

```
' Holds the assembly constraint object
Dim assmConstraint As IADAssemblyConstraint

' Set the assembly constraint object to be the first constraint in the assembly
Set assmConstraint = assmConstraints.Item(0)

' Holds the Angle constraint object
Dim angleConstraint As IADAngleConstraint

' If the first assembly constraint is of Angle constraint type, then display the Angle value for the Angle constraint
If assmConstraint.ConstraintType = ADAssemblyConstraintType.AD_ANGLE_TYPE Then
    Set angleConstraint = assmConstraint
    Text1.Text = "Offset value for Angle Constraint is " & angleConstraint.Angle
```



# IADTargetProxy.Occurrence Property

Returns the Occurrence of this Proxy. The target retrieved from this Proxy will be in the
local space of this Occurrence, where it naturally lives.

#### Syntax

```
IADOccurrence Occurrence { get; }
```

#### Property Value

IADOccurrence

#### Remarks

The Occurrence will be null if the Proxy is from a standalone Part
workspace.



# IADScrewConstraint Properties

The IADScrewConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | Pitch | Gets the pitch parameter. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |



# IADAssemblyConstraints Interface

IADAssemblyConstraints represents a collection of all constraints in a particular assembly session.

#### Syntax

```
public interface IADAssemblyConstraints
```

The IADAssemblyConstraints type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | The number of constraints in the collection. |
|  | Enum | Returns an enumerator for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddConstraint | Create a new Assembly Constraint. |
|  | AddConstraintEx | Create a new Assembly Constraint. |
|  | Item | Given a name or index, returns the corresponding constraint. |



# IADAssemblyConstraint.BoundType Property

Gets the pre-defined constant that identifies the bound type of the constraint.

#### Syntax

```
ADAssemblyConstraintBoundType BoundType { get; }
```

#### Property Value

ADAssemblyConstraintBoundType



# IADInterferences.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADExplodedViewStep.Name Property

Gets the name of this exploded view step.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADExplodedViewStep.SegmentTransformations Method

Gets an IObjectCollector of IADTransformation objects, corresponding to each segment for this occurrence.

#### Syntax

```
IObjectCollector SegmentTransformations(
	IADOccurrence occurrence
)
```

#### Parameters

occurrence  IADOccurrence
:   The occurrence to get transformations of.

#### Return Value

IObjectCollector  
Returns a collection of IADTransformation



# IADAlignConstraint Properties

The IADAlignConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | MaximumOffset | Gets the maximum distance between the objects participating in the Align Constraint. |
|  | MinimumOffset | Gets the minimum distance between the objects participating in the Align Constraint. |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Offset | Gets the distance between the objects participating in the Align Constraint. |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |



# IADExplodedView.GetTransformForOccurrence Method

Gets the world transform for the occurrence in exploded state.

#### Syntax

```
IADTransformation GetTransformForOccurrence(
	IADOccurrence pOccurrence
)
```

#### Parameters

pOccurrence  IADOccurrence
:   The occurrence to get the exploded view world transform for.

#### Return Value

IADTransformation  
Returns IADTransformation



# IADFastenerConstraint Interface

IADFastenerConstraint interface

#### Syntax

```
public interface IADFastenerConstraint : IADAssemblyConstraint
```

The IADFastenerConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BoundType | Gets the pre-defined constant that identifies the bound type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | ConstraintType | Gets the pre-defined constant that identifies the type of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | HasError | Returns True if an error was encountered in evaluating the constraint.  (Inherited from IADAssemblyConstraint) |
|  | IsSuppressed | Gets/sets the suppression state of this constraint.  (Inherited from IADAssemblyConstraint) |
|  | MaximumOffset | Gets the maximum distance between the objects participating in the Fastener Constraint. |
|  | MinimumOffset | Gets the minimum distance between the objects participating in the Fastener Constraint. |
|  | Name | Gets the name of the constraint.  (Inherited from IADAssemblyConstraint) |
|  | Offset | Gets the distance between the objects participating in the Fastener Constraint. |
|  | Participants | Returns list of Target Proxies participating in this constraint. This can be a Face, Edge, Design Axis, Design Point, Design Plane or Surface.  (Inherited from IADAssemblyConstraint) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_CONSTRAINT)  (Inherited from IADAssemblyConstraint) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADAssemblyConstraints.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADAssemblyConstraints.Item Method

Given a name or index, returns the corresponding constraint.

#### Syntax

```
IADAssemblyConstraint Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name of numerical index of the constraint.

#### Return Value

IADAssemblyConstraint  
Returns IADAssemblyConstraint

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INDEX\_OUT\_OF\_BOUNDS | The specified index is outside the boundaries of this collection. |

#### Example

This Visual Basic sample shows how to call the Item method.

```
' Holds Session object
Dim objADSession As AlibreX.IADSession

' Open an existing Assembly using OpenFile() on Root object. Note: User may set it to any required file and location
Set objADSession = m_objADRoot.OpenFile("C:\Assembly.AD_ASM")

' Holds Assembly Session object
Dim objADAssemblySession As AlibreX.IADAssemblySession

' Set Session as Assembly Session
Set objADAssemblySession = objADSession

' Holds Assembly Constraints
Dim assmConstraints As IADAssemblyConstraints

' Set Constraints in Session as Assembly Constarints
Set assmConstraints = assmSession.AssemblyConstraints

' Holds constraint name
Dim constraintName As String

'Set constraint name to be the name of the first constraint in the assembly
constraintName = assmConstraints.Item(0).Name
```



# IADGearConstraint Methods

The IADGearConstraint type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the constraint from the assembly.  (Inherited from IADAssemblyConstraint) |



# IADScrewConstraint.Pitch Property

Gets the pitch parameter.

#### Syntax

```
IADParameter Pitch { get; }
```

#### Property Value

IADParameter

#### Example

This Visual Basic sample shows how to get the Pitch property.

```
' Holds the assembly constraint object
Dim assmConstraint As IADAssemblyConstraint

' Set the assembly constraint object to be the first constraint in the assembly
Set assmConstraint = assmConstraints.Item(0) 

' Holds the Screw constraint object
Dim screwConstraint As IADScrewConstraint

' If the first assembly constraint is of Screw constraint type, then display the pitch value for the Screw constraint
If assmConstraint.ConstraintType = ADAssemblyConstraintType.AD_SCREW_TYPE Then
    Set screwConstraint = assmConstraint
    Text1.Text = "Pitch value for Screw Constraint is " & screwConstraint.Pitch
```



# IADOccurrence.SectionBodies Property

Returns the collection of section bodies.

#### Syntax

```
IADBodies SectionBodies { get; }
```

#### Property Value

IADBodies
