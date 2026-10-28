# AlibreX API — Part Session & Design Session

> Part of the split AlibreX reference. See `00_index.md` for the full map.

**Sections in this file:** 278

---


# IADDesignPoint.Root Property

Returns the automation root.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADDesignSession.Sketches Property

Returns the collection of sketches for this design.

#### Syntax

```
IADSketches Sketches { get; }
```

#### Property Value

IADSketches



# IADDesignSurface Methods

The IADDesignSurface type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes the design surface. |



# IADPartSession.UnSuppressAll Method

Unsuppress all features.

#### Syntax

```
void UnSuppressAll()
```



# IADConfigurations Interface

IADConfigurations represents a collection of all configurations in a particular part,
assembly or a sheetmetal part.

#### Syntax

```
public interface IADConfigurations
```

The IADConfigurations type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Gets the count of configurations in this collection. |
|  | Enum | Returns an enumerator for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddConfiguration | Adds a new configuration to the design. |
|  | Item | Given a configuration's name or index, returns the corresponding configuration. |



# IADDesignPlane.Delete Method

Deletes the design plane.

#### Syntax

```
void Delete()
```

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_CANNOT\_DELETE\_PLANE | This plane cannot be deleted. Built-in Design Planes (XY-Plane, YZ-Plane, ZX-Plane) cannot be deleted. If it is being used by a feature, it may be necessary to delete that feature first. |
| AD\_E\_INVALID\_OBJECT | This is not a valid plane. It may have already been deleted. |

#### Remarks

Built-in Design Planes (XY-Plane, YZ-Plane, ZX-Plane) cannot be deleted.

Calling any method on the deleted object throws an exception indicating that the object
is no longer valid.



# IADDesignMeshes Properties

The IADDesignMeshes type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of design meshes in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the design session for the collection. |



# IADDesignPoints Properties

The IADDesignPoints type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of design points in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the design session for the collection. |



# IADIGESOptions.HasWireAsCopiousData Property

Set this option to true to write a wire as copious data (entity #106, form 12).
Otherwise, separate curves are written for the wire.

#### Syntax

```
bool HasWireAsCopiousData { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDesignAxis.AxisType Property

Returns a pre-defined constant that identifies how this design geometry was created.

#### Syntax

```
ADDesignGeometryType AxisType { get; }
```

#### Property Value

ADDesignGeometryType



# IADDesignProperties Properties

The IADDesignProperties type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | AngleDisplayUnits | Gets the unit of measurement for displaying angles in the workspace. |
|  | Density | Gets/Sets the density of the material used for the design. |
|  | Description | Gets/sets the description for the design. |
|  | LengthDisplayUnits | Gets the unit of measurement for displaying lengths in the workspace. |
|  | MassUnits | Returns the unit of measurement for displaying mass in the workspace. |
|  | Material | Gets/sets the name of the material of the design. |
|  | ModelUnits | Returns the internal model unit of measurement for representing lengths in the design. |
|  | Number | Gets/Sets the number for the design. This is a user-specific string to denote version of the design. |
|  | TreatAsPartInBOM | Gets/Sets the Treat as part in BOM design property. NOTE: This property affects only an assembly workspace. |
|  | VersionComment | Gets/sets the Version Comment for the design. |



# IADDesignAxes.Session Property

Returns the design session for the collection.

#### Syntax

```
IADDesignSession Session { get; }
```

#### Property Value

IADDesignSession



# IADDesignProperties.MassUnits Property

Returns the unit of measurement for displaying mass in the workspace.

#### Syntax

```
ADUnits MassUnits { get; }
```

#### Property Value

ADUnits



# IADDesignPlane.SourceObjects Property

The source objects collection represents the objects used to create the Design Plane. This
property returns a collection of IADTargetProxy objects.
The IADTargetProxy object wraps the dependent object, and
also its occurrence if the object belongs to an
assembly.

#### Syntax

```
IObjectCollector SourceObjects { get; }
```

#### Property Value

IObjectCollector

#### Remarks

This method will return null if the Plane is a Primary Design Plane.

#### Example

This Visual Basic sample iterates through all the source objects used for creating Planes in the design, and prints the name of the occurrence as well as Type of the target.

```
Dim objPlanes As AlibreX.IADDesignPlanes
Dim objPlane As AlibreX.IADDesignPlane
Dim objTargetProxy As AlibreX.IADTargetProxy
Dim objSourceObjects As AlibreX.IObjectCollector
Dim occurrenceName As String
Dim targetType As Integer

Set objPlanes = m_objAlibreDesignSession.DesignPlanes
For Each objPlane In objPlanes
    Set objSourceObjects = objPlane.SourceObjects

    If Not objSourceObjects Is Nothing Then
        occurrenceName = ""
        For Each objTargetProxy In objSourceObjects
            If Not objTargetProxy.Occurrence Is Nothing Then
                occurrenceName = objTargetProxy.Occurrence.Name
            End If

            targetType = objTargetProxy.Target.Type

            Msgbox occurrenceName & " <" & targetType & ">"
        Next
    End If
Next
```



# IADPartSession.RegenerateAll Method

Regenerate all features.

#### Syntax

```
void RegenerateAll()
```



# IADDesignPoints.CreatePointFromCircularEdge Method

Creates a design point at the center of a circular edge.

#### Syntax

```
IADDesignPoint CreatePointFromCircularEdge(
	IADOccurrence pOccurrence,
	IADEdge pEdge,
	string name
)
```

#### Parameters

pOccurrence  IADOccurrence
:   Denotes an "instance" of a Part or
    Assembly, to which the given pEdge belongs to. For
    creating a Point in a standalone Part, pOccurrence should be null.

pEdge  IADEdge
:   A circular edge whose center point is used to define
    the new design point.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new design point. If a null or empty string is passed,
    Alibre will name the point.

#### Return Value

IADDesignPoint  
Returns the new IADDesignPoint.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INVALID\_EDGE | pEdge must be a circular edge. |

#### Remarks

Note that the newly created Point object is not added to the Collection on which this
method is called. Query for the Collection again to get the updated Collection. If the input
edge is not a circular edge, this method throws an exception.

#### Example

This Visual Basic sample shows how to call the CreatePointFromCircularEdge method.

```
' Holds File Path
Dim strFilePath As String
strFilePath = "...\Examples\API_Kettle.AD_PRT"    

' Open Alibre Design File
Set m_objADSession = m_objADRoot.OpenFile(strFilePath) 

' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session object from existing session
Set objADPartSession = m_objADSession

' Holds Body object
Dim objADBody As AlibreX.IADBody

If objADPartSession.Bodies.Count > 0 Then
    ' Get Body object from Part Session
    Set objADBody = objADPartSession.Bodies(0) 

    ' Holds Curve object
    Dim objADCurve As AlibreX.IADCurve

    ' Holds Edge object
    Dim objADEdge As AlibreX.IADEdge

    ' Search for Cylindrical Edge in the Edges collection on the Body
    For Each objADEdge In objADBody.Edges
        ' Get Curve object using Geometry on the Edge
        Set objADCurve = objADEdge.Geometry()
        ' Check if the Curve is of Circular
        If (objADCurve.CurveType = ADGeometryType.AD_CIRCLE) Or _
             (objADCurve.CurveType = ADGeometryType.AD_CIRCULAR_ARC) Then
            ' Holds as Edge object
            Dim objCircularEdge As AlibreX.IADEdge
            ' Capture Circular Edge object
            Set objCircularEdge = objADEdge
            ' Exit the loop
            Exit For
        End If
    Next objADEdge

    ' Release unused objects
    Set objADCurve = Nothing
    Set objADEdge = Nothing

    ' Holds Design Session object
    Dim objADDesignSession  As AlibreX.IADDesignSession

    ' Get Design Session object from existing session
    Set objADDesignSession = m_objADSession

    ' Holds Design Points collection object
    Dim objADDesignPoints As AlibreX.IADDesignPoints

    ' Get Design Points collection from Design Session
    Set objADDesignPoints = objADDesignSession.DesignPoints()

    If Not objCircularEdge Is Nothing Then
        ' Holds the new Design Axis
        Dim objADNewDesignPoint As AlibreX.IADDesignPoint
        ' Create a Design Point form the Circular Edge.  Since Edge is belonging
        ' to the current Part, Occurance Value is passed as Nothing. 
        Set objADNewDesignPoint = objADDesignPoints.CreatePointFromCircularEdge( _
                  Nothing, objCircularEdge, _
                  "NewPointFromCircularEdge")
        End If
    End If
```



# IADDesignProperties.ExtendedDesignProperty(ADExtendedDesignProperty, Object) Method

Sets the design property for the input property identifier.

#### Syntax

```
void ExtendedDesignProperty(
	ADExtendedDesignProperty propertyID,
	Object propertyValue
)
```

#### Parameters

propertyID  ADExtendedDesignProperty
:   The identifier for the design property to be set.

propertyValue  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The value to set the specified property to.



# IADDesignSurface.Transform Property

Gets/sets the local transformation of this surface. This transformation defines
the scale, position, and rotation of the surface within the design.

#### Syntax

```
IADTransformation Transform { get; set; }
```

#### Property Value

IADTransformation

#### Example

This sample demonstrates using the Transform property to double the size of a Design Surface.

```
// Get the current transform for a valid IADDesignSurface object.
IADTransformation surfaceTransform = designSurface.Transform;
// Use the geometry factory to create the scale transform with a factor of 2.
IADTransformation scaleTransform = designSession.GeometryFactory.CreateUniformScalingTransform(2.0);
// Apply the scale transform to the surface's original transform.
surfaceTransform = surfaceTransform.Apply(scaleTransform);
// Set the design surface's transfromation to the scaled transformation.
designSurface.Transform = surfaceTransform;
```



# IADDesignProperties.Density Property

Gets/Sets the density of the material used for the design.

#### Syntax

```
double Density { get; set; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

Specify the density value such that it is consistent with the unit of mass
and the display unit of length.



# IADPartSession.Sketches Property

Returns the collection of sketches for this design.

#### Syntax

```
IADSketches Sketches { get; }
```

#### Property Value

IADSketches

#### Implements

IADDesignSessionSketches



# IADDesignSurfaces.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADDesignAxis.Root Property

Returns the automation root.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADDesignSession.IGESOptions Property

Returns an IADIGESOptions object containing the currently selected IGES options.
This object has several properties you can get/set to change the current options
relating to IGES export.

#### Syntax

```
IADIGESOptions IGESOptions { get; }
```

#### Property Value

IADIGESOptions



# IADBodies.Count Property

Returns the number of bodies in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

With the current implementation this collection has just one body held by the design.



# IADDesignMeshes Interface

#### Syntax

```
public interface IADDesignMeshes
```

The IADDesignMeshes type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of design meshes in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the design session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateFromFile |  |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given a name or numerical index into the collection, returns the corresponding design mesh. |



# IADConfiguration.DesignSession Property

Returns the session in which this configuration is defined.

#### Syntax

```
IADDesignSession DesignSession { get; }
```

#### Property Value

IADDesignSession

#### Example

This Visual Basic sample shows how to get the DesignSession property.

```
' Holds Session object
Dim objSession as IADSession 

' Open an existing part using OpenFile() on Root object. Note: User may set it to any required file and location
Set objADSession = m_objADRoot.OpenFile("C://Part.AD_PRT")

' Holds Alibre Design Session object
Dim objDesignSession As IADDesignSession 

'Assign objADSession to objDesignSession 
Set objDesignSession = objADSession

'Holds all configurations in a design session
Dim objConfigs As IADConfigurations

'set the configurations in the design session
Set objConfigs = DesignSession.Configurations

'Holds a configuration in a design session
Dim objConfig As IADConfigurations

'Set the first configuration to objConfig  
Set objConfig = objConfigs.Item(0)

'Set the first configuration's design session 
Set objDesignSession = objConfig.DesignSession
```



# IADDesignSelectionFilter.Axes Property

If true, reference axes are selectable.

#### Syntax

```
bool Axes { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDesignPoint.Delete Method

Deletes the current design point.

#### Syntax

```
void Delete()
```

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_CANNOT\_DELETE\_POINT | This point cannot be deleted. The origin design point cannot be deleted. If it is being used by a feature, it may be necessary to delete that feature first. |
| AD\_E\_INVALID\_OBJECT | This is not a valid point. It may have already been deleted. |

#### Remarks

The Origin point cannot be deleted.

Calling any method on a deleted object throws an exception indicating that the object
is no longer valid.



# IADDesignAxes.CreateFromCylindricalFace Method

Creates a design axis touching a cylindrical face.

#### Syntax

```
IADDesignAxis CreateFromCylindricalFace(
	IADOccurrence pOccurrence,
	IADFace pFace,
	string name
)
```

#### Parameters

pOccurrence  IADOccurrence
:   Denotes an "instance" of a Part or Assembly to which the given
    pFace belongs to. For creating an axis in a standalone Part, pOccurrence
    should be null.

pFace  IADFace
:   A cylindrical face.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new design axis. If a null or empty string is passed,
    Alibre will name the axis.

#### Return Value

IADDesignAxis  
An interface to the new design axis.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INVALID\_FACE | pFace was not valid. It must be cylindrical for this method. |
| AD\_E\_GEOMETRY\_CREATION\_FAILURE | Alibre was unable to create valid geometry for the design axis. |

#### Remarks

Note that the newly created Axis object is not added to the Collection on which this
method is called. Query for the Collection again to get the updated Collection.

#### Example

This Visual Basic sample shows how to create a Design Axis from a cylindrical face.

```
' Holds Design Axes collection object
Dim objADDesignAxes As AlibreX.IADDesignAxes

' Get Design Axes collection from Design Session
Set objADDesignAxes = objADDesignSession.DesignAxes

' Create a Design Axis using the cylindrical Face.
Set objADNewDesignAxis = objADDesignAxes.CreateFromCylindricalFace( _
Nothing, objConicalFace, _
      "NewAxisFromCylindricalFace")
```



# IADPartSession.FacetData Property

Returns the triangular mesh data for the active configuration.

#### Syntax

```
Array FacetData { get; }
```

#### Property Value

[Array](https://learn.microsoft.com/dotnet/api/system.array)

#### Remarks

The array contains triplets of double values representing (x,y,z) co-ordinates
corresponding to triangle vertices.



# IADDesignMeshes.Count Property

Returns the number of design meshes in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADDesignPlane Properties

The IADDesignPlane type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Name | Gets/sets this design plane's name. |
|  | Normal | Returns the plane's normal. |
|  | Parameters | Get a collection object containing IADParameter objects associated with this design geometry. |
|  | PlaneType | Returns a pre-defined constant that identifies how this design geometry was created. |
|  | Root | Returns the automation root. |
|  | Session | Returns the design session for the design plane. |
|  | SourceObjects | The source objects collection represents the objects used to create the Design Plane. This property returns a collection of IADTargetProxy objects. The IADTargetProxy object wraps the dependent object, and also its occurrence if the object belongs to an assembly. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_DESIGN\_PLANE) of this object. |



# IADDesignSession Properties

The IADDesignSession type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ActiveConfiguration | Gets/sets the active configuration for this design session. |
|  | AutoBrepImportSummary |  |
|  | AutoRegenerate | Determines whether the DesignSession will be automatically regenerated after a change. |
|  | CameraPosition | Returns an IADPoint with the current location of the camera in this design session. |
|  | CircularFacets | Gets the current display setting for the minimal circular facets option of the design. |
|  | Configurations | Returns the collection of configurations present in this design session. |
|  | ConstituentFilePaths | Returns file path strings for other Design files that are referenced by this session.  (Inherited from IADSession) |
|  | DesignAxes | Returns a collection of design axes for this session. |
|  | DesignMeshes | Returns a collection of design meshes for this session. |
|  | DesignPlanes | Returns a collection of design planes for this session. |
|  | DesignPoints | Returns a collection of design points for this session. |
|  | DesignProperties | Returns the design properties of the design. |
|  | FilePath | Returns the location on disk of where the file was last saved. If unsaved, returns null.  (Inherited from IADSession) |
|  | GeometryFactory | Returns the Geometry Factory.  (Inherited from IADSession) |
|  | HasErrors | Returns true if the design has errors. |
|  | Identifier | Returns the session's unique identifier.  (Inherited from IADSession) |
|  | IGESOptions | Returns an IADIGESOptions object containing the currently selected IGES options. This object has several properties you can get/set to change the current options relating to IGES export. |
|  | IsGUIVisible | Returns True if the GUI for this session is visible.  (Inherited from IADSession) |
|  | IsPerspective | Returns true if the current display of the design is in perspective view mode, rather than orthogonal. |
|  | IsSectioning | Returns true if design has a current active section view. |
|  | ModelTolerance | Returns Model tolerance. |
|  | Name | Returns this session's name.  (Inherited from IADSession) |
|  | Parameters | Returns a collection of parameters for this session.  (Inherited from IADSession) |
|  | PreviewSnapshot | Returns a OLE picture object containing the preview snapshot bitmap for the session.  (Inherited from IADSession) |
|  | Root | Returns the automation root.  (Inherited from IADSession) |
|  | SavedViews | Gets all the saved views for this session. |
|  | SelectedObjects | Returns all selected entities in the session's browser as a collection of target proxies.  (Inherited from IADSession) |
|  | SelectionFilter | Gets the interface to this design session's selection filter. The interface's properties can be queried to find the current settings or set to change the active selection filters. |
|  | SessionType | Returns a pre-defined constant that identifies whether this session is a part or assembly or drawing session.  (Inherited from IADSession) |
|  | Sketches | Returns the collection of sketches for this design. |
|  | TimeStamp | Returns time stamp of this session; the time stamp changes when changes are saved to the session.  (Inherited from IADSession) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SESSION)  (Inherited from IADSession) |
|  | ViewTransform | Returns view transformation of this design session. |



# IADPartSession.Sketches3D Property

The collection of 3D sketches for this design.

#### Syntax

```
IAD3DSketches Sketches3D { get; }
```

#### Property Value

IAD3DSketches



# IADDesignProperties.CustomProperty(String, Object) Method

Sets the custom property for the input custom property name.

#### Syntax

```
void CustomProperty(
	string propertyName,
	Object propertyValue
)
```

#### Parameters

propertyName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name for the custom property to be set.

propertyValue  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The value to set the specified property to.



# IADConfiguration.Locks Property

Gets/sets the lock for a configuration.

#### Syntax

```
ADConfigurationLockType Locks { get; set; }
```

#### Property Value

ADConfigurationLockType

#### Example

This Visual Basic sample shows how to get/set the Locks property.

```
' Holds Session object
Dim objSession as IADSession 

' Open an existing part using OpenFile() on Root object. Note: User may set it to any required file and location
Set objADSession = m_objADRoot.OpenFile("C://Part.AD_PRT")

' Holds Alibre Design Session object
Dim objDesignSession As IADDesignSession 

'Assign objADSession to objDesignSession 
Set objDesignSession = objADSession

'Holds all configurations in a design session
Dim objConfigs As IADConfigurations

'set the configurations in the design session
Set objConfigs = DesignSession.Configurations

'Holds a configuration in a design session
Dim objConfig As IADConfigurations

'Set the first configuration to objConfig  
Set objConfig = objConfigs.Item(0)

'The below code snippet is an example where you are setting the lock for color Properties in the configuration
objConfig.Locks = AD_LOCK_COLOR_PROPERTIES

'Check to see if the Color Properties bit has been locked for the first configuration
'This is an example where you are getting the lock property that has been set on a configuration.
If objConfig.Locks = AD_LOCK_COLOR_PROPERTIES Then
    MsgBox ("Configuration is locked for Color Properties")
Else
    MsgBox ("Configuration is not locked for Color Properties")
End If
```



# IADDesignSession.ExportIGES Method

Exports the design session as an IGES file. The settings in Alibre's Options will be used
when exporting the file.

#### Syntax

```
void ExportIGES(
	string fileName
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the exported file.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_INVALID\_LICENSE\_KEY | The license for this installation of Alibre Design does not permit exporting this design as a IGES file. |

#### Remarks

To specify the options to use when exporting an IGES file, use the
IADIGESOptions object available from the
IGESOptions property to get and set the
current IGES export options.



# IADPartSession.FacetDataForConfiguration Method

Returns triangular mesh data for the specified Configuration.

#### Syntax

```
Array FacetDataForConfiguration(
	IADConfiguration pConfiguration
)
```

#### Parameters

pConfiguration  IADConfiguration
:   This configuration will be used to generate the facet data.

#### Return Value

[Array](https://learn.microsoft.com/dotnet/api/system.array)  
A double array of xyz coordinates corresponding to triangle vertices.

#### Remarks

Array contains triplets of (x,y,z) coordinates corresponding to triangle vertices.



# IADDesignPlanes.Session Property

Returns the design session for the collection.

#### Syntax

```
IADDesignSession Session { get; }
```

#### Property Value

IADDesignSession



# IDecomposedTransformData.ScaleY Property

Returns the scale component of the decomposed transform in Y direction.

#### Syntax

```
double ScaleY { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADDesignPlane Methods

The IADDesignPlane type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes the design plane. |
|  | GetGeometry | Returns the lower, upper, and top left corner points for the plane. |
|  | Hide | Hides the design plane. |
|  | Show | Shows the design plane. |



# IADDesignSession.ViewExtents Method

Returns view extents of this design session, in screen coordinates.

#### Syntax

```
void ViewExtents(
	out IAD2DPoint pUpperLeft,
	out IAD2DPoint pBottomRight
)
```

#### Parameters

pUpperLeft  IAD2DPoint
:   The upper left screen point.

pBottomRight  IAD2DPoint
:   The bottom right screen point.



# IADPartSession.Color Property

The part's color.

#### Syntax

```
int Color { get; set; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Example

This sample demonstrates getting the color of a part and then changing it.

```
Dim originalValue As Integer
Dim rgbValue As Integer
Dim newColor As Integer

' Get the current color from the part
originalValue = partSession.Color
print("--Color (int): " & originalValue)
' A GetRGB function is defined below, to get the discrete red, green, and 
' blue values from the color
print("--Color (R,G,B): (" & GetRGB(originalValue, 1) & ", " & _
    GetRGB(originalValue, 2) & ", " & GetRGB(originalValue, 3) & ")")

' The RGB function returns a whole number representing a RGB color value.
rgbValue = RGB(255, 100, 0) ' Orange
print("--New Color (int): " & rgbValue)
print("--New Color (R,G,B): (" & GetRGB(rgbValue, 1) & ", " & _
    GetRGB(rgbValue, 2) & ", " & GetRGB(rgbValue, 3) & ")")

print("--Setting new color...")
partSession.Color = rgbValue

' Getting the color from the part again, to confirm that it changed the color.
newColor = partSession.Color
print("--Updated Color (int): " & newColor)
print("--Updated Color (R,G,B): (" & GetRGB(newColor, 1) & ", " _
    & GetRGB(newColor, 2) & ", " & GetRGB(newColor, 3) & ")")
```

To get the RGB values from the whole color value, this function can be used:

```
'-----------------------------------------------------------------
'PURPOSE: Returns red/green/blue color from RGB color value.
'ACCEPTS: RGB color value as Long, and component number as integer
'         that represents the component color to return (1=red,
'         2=green, 3=blue).
'RETURNS: The intensity of the color component (0 - 255) as an
'         integer or -1 indicating that an argument was invalid.
'-----------------------------------------------------------------
Function GetRGB(ByVal RGBval As Long, ByVal Num As Integer) As Integer
    ' Check if Num, RGBval are valid.
    If Num > 0 And Num < 4 And RGBval > -1 And RGBval < 16777216 Then
        GetRGB = RGBval \ 256 ^ (Num - 1) And 255
    Else
        ' Return True (-1) if Num or RGBval are invalid.
        GetRGB = True
    End If
End Function
```



# IADDesignSession.ExportSTL2 Method

Exports the design session as an STL file.

#### Syntax

```
void ExportSTL2(
	string fileName
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the exported file.

#### Remarks

The user's STL preferences for max cell size, normal deviation, and surface deviation
are used to create the STL file for this method.
The method ExportSTL allows the values for in the user's profile to be overridden.



# IADPartSession.GetMeshDefinitionEx Method

Returns definition of index-based triangular mesh data, including normals.

#### Syntax

```
void GetMeshDefinitionEx(
	IADConfiguration pConfiguration,
	int minCircularFacets,
	out int pFaceDataSize,
	out int pVertexDataSize,
	out int pNormalDataSize
)
```

#### Parameters

pConfiguration  IADConfiguration
:   This configuration will be used to generate the mesh.

minCircularFacets  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The minimum number of facets to be generated for a curved face.

pFaceDataSize  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The size of the index array which contains indices of triangles in mesh.

pVertexDataSize  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The size of an array which contains co-ordinates of vertices in the mesh.

pNormalDataSize  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The size of an array which contains vector components of normals of the mesh.



# IADDesignSession.HasErrors Property

Returns true if the design has errors.

#### Syntax

```
bool HasErrors { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADIGESOptions.IsAutoCAD Property

If true, IGES files will be exported with faces specifically for use with AutoCAD.

#### Syntax

```
bool IsAutoCAD { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDesignPoint.PointType Property

Returns a pre-defined constant that identifies how this design geometry was created.

#### Syntax

```
ADDesignGeometryType PointType { get; }
```

#### Property Value

ADDesignGeometryType



# IADDesignSelectionFilter Interface

IADDesignSelectionFilter provides an interface to change the active
selection filters for a design session.

#### Syntax

```
public interface IADDesignSelectionFilter
```

The IADDesignSelectionFilter type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Annotations | If true, annotations are selectable. |
|  | Axes | If true, reference axes are selectable. |
|  | Dimensions | If true, dimensions are selectable. |
|  | Planes | If true, reference planes are selectable. |
|  | Points | If true, reference points are selectable. |
|  | Redlines | If true, redlines are selectable. |
|  | Sketches2D | If true, 2D sketches are selectable. |
|  | Sketches3D | If true, 3D sketches are selectable. |
|  | Solid | Gets/sets the current selection filter setting for topological elements of solid bodies in the design. |
|  | Surface | Gets/sets the current selection filter setting for reference surfaces. |



# IADDesignPoint.SourceObjects Property

The source objects collection represents the objects used to create the Design Point. This
property returns a collection of IADTargetProxy objects.
The IADTargetProxy object wraps the dependent object, and
also its occurrence if the object belongs to an
assembly.

#### Syntax

```
IObjectCollector SourceObjects { get; }
```

#### Property Value

IObjectCollector

#### Remarks

This method will return null if the Plane is a Primary Design Point.



# IADDesignPlanes Methods

The IADDesignPlanes type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateAtAngleToPlane | Creates a design plane at an angle to an existing plane/face and passing through an axis/edge. |
|  | CreateAtOffsetToPlane | Create design plane at an offset to the given existing plane or planar face. |
|  | CreateBy3Points | Create a design plane such that it passes through the given three points or vertices. |
|  | Item | Given a name or numerical index into the collection, returns the corresponding design plane. |



# IADDesignSurface Properties

The IADDesignSurface type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Edges | Get all the edges in this surface. |
|  | Faces | Get all the faces in this surface. |
|  | Name | Gets/sets the name of this design surface. |
|  | Root | Returns the automation root object. |
|  | Session | Returns the part session for the design surface. |
|  | Transform | Gets/sets the local transformation of this surface. This transformation defines the scale, position, and rotation of the surface within the design. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_DESIGN\_SURFACE) of this object. |
|  | Vertices | Get all the vertices in this surface |



# IDecomposedTransformData.RotateVector Property

Returns the vector around which the rotation component was decomposed for the transform.

#### Syntax

```
IADVector RotateVector { get; }
```

#### Property Value

IADVector



# IADConfigurations.AddConfiguration Method

Adds a new configuration to the design.

#### Syntax

```
IADConfiguration AddConfiguration(
	string name,
	bool lockOption
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name for the new configuration.

lockOption  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, the configuration created is fully locked, else, it is fully unlocked.

#### Return Value

IADConfiguration  
Returns IADConfiguration

#### Example

This Visual Basic sample shows how to call the AddConfiguration method.

```
' Holds Session object
Dim objSession as IADSession 

' Open an existing part using OpenFile() on Root object. Note: User may set it to any required file and location
Set objADSession = m_objADRoot.OpenFile("C://Part.AD_PRT")

' Holds Alibre Design Session object
Dim objDesignSession As IADDesignSession 

'Assign objADSession to objDesignSession 
Set objDesignSession = objADSession

'Holds all configurations in a design session
Dim objConfigs As IADConfigurations

'set the configurations in the design session
Set objConfigs = DesignSession.Configurations

'Holds a configuration in a design session
Dim objConfig As IADConfigurations

'Set objConfig to the newly added configuration
Set objConfig = objConfigs.AddConfiguration("NewConfig<1>", True)
```



# IADDesignPoint Methods

The IADDesignPoint type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes the current design point. |
|  | Hide | Hides the design point. |
|  | Show | Shows the design point. |



# IADDesignPoints.Session Property

Returns the design session for the collection.

#### Syntax

```
IADDesignSession Session { get; }
```

#### Property Value

IADDesignSession



# IADDesignPoints.CreateBy3Planes Method

Creates a design point at the intersection of three planes/faces

#### Syntax

```
IADDesignPoint CreateBy3Planes(
	IADOccurrence pOccurrence1,
	Object pPlane1,
	IADOccurrence pOccurrence2,
	Object pPlane2,
	IADOccurrence pOccurrence3,
	Object pPlane3,
	string name
)
```

#### Parameters

pOccurrence1  IADOccurrence
:   Denotes an "instance" of a Part or Assembly to which the given
    pPlane1 belongs to. For creating a point in a standalone Part, pOccurrence1
    should be null.

pPlane1  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   A plane or planar face
    which will be used to define the point.

pOccurrence2  IADOccurrence
:   Denotes an "instance" of a Part or Assembly to which the given
    pPlane2 belongs to. For creating a point in a standalone Part, pOccurrence2
    should be null.

pPlane2  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   A plane or planar face
    which will be used to define the point.

pOccurrence3  IADOccurrence
:   Denotes an "instance" of a Part or Assembly to which the given
    pPlane3 belongs to. For creating a point in a standalone Part, pOccurrence3
    should be null.

pPlane3  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   A plane or planar face
    which will be used to define the point.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new design point. If a null or empty string is passed,
    Alibre will name the point.

#### Return Value

IADDesignPoint  
An interface to the new design point.



# IADDesignPlane.Show Method

Shows the design plane.

#### Syntax

```
void Show()
```



# IADDesignSession.ExportOBJ Method

Exports the design session as a OBJ file.

#### Syntax

```
void ExportOBJ(
	string fileName
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the exported file.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_INVALID\_LICENSE\_KEY | The license for this installation of Alibre Design does not permit exporting this design as a OBJ file. |



# IADDesignSession.ExportBIP(String, String) Method

#### Syntax

```
void ExportBIP(
	string fileName,
	string optionFilePath
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)

optionFilePath  [String](https://learn.microsoft.com/dotnet/api/system.string)



# IADDesignMesh.IsSurfaced Property

Returns true if surfacing of the DesignMesh is complete.

#### Syntax

```
bool IsSurfaced { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDesignPlanes.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADDesignPlanes.CreateAtAngleToPlane Method

Creates a design plane at an angle to an existing plane/face and passing through an axis/edge.

#### Syntax

```
IADDesignPlane CreateAtAngleToPlane(
	IADOccurrence pPlaneOcc,
	Object pPlane,
	IADOccurrence pAxisOcc,
	Object pAxis,
	Object Angle,
	string name
)
```

#### Parameters

pPlaneOcc  IADOccurrence
:   Denotes an "instance" of a Part or
    Assembly, to which the given pPlane belongs to. For
    creating a Plane in a standalone Part, pPlaneOcc should be null.

pPlane  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   A plane or planar
    face used to define the new design plane.

pAxisOcc  IADOccurrence
:   Denotes an "instance" of a Part or
    Assembly, to which the given pAxis belongs to. For
    creating a Plane in a standalone Part, pAxisOcc should be null.

pAxis  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   An axis or linear
    edge used to define the new design plane.

Angle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The angle between pPlane and the new design plane. Can be either
    a double or an angular parameter value.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new design plane. If a null or empty string is passed,
    Alibre will name the plane.

#### Return Value

IADDesignPlane  
Returns IADDesignPlane

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_CURVED\_FACE | If using a face for pPlane it must be planar. |
| AD\_E\_VARIANT\_TYPE\_UNSUPPORTED | pPlane must be an IADDesignPlane or IADFace. Angle must be either an IADParameter or double value. pAxis must be an IADDesignAxis or a linear IADEdge |
| AD\_E\_AXIS\_PLANE\_PARALLEL | pAxis must be parallel to pPlane. |
| AD\_E\_INVALID\_AXIS | pAxis was not a valid axis. |

#### Remarks

Note that the newly created Plane object is not added to the Collection on which this
method is called. Query for the Collection again to get the updated Collection.

#### Example

This Visual Basic sample demonstrates creating a Design Plane at an angle to a plane. A Design Plane that is at an angle of 0.785 radians to "XY-Plane" with X-Axis as the axis of rotation is created here. The new Design Plane is named "NewPlaneAtAngleToPlane".

```
' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Planes collection object
Dim objADDesignPlanes As AlibreX.IADDesignPlanes

' Get Design Planes collection from Design Session
Set objADDesignPlanes = objADDesignSession.DesignPlanes

' Holds a Design Plane
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Get "XY-Plane" Design Plane from Design Planes collection
Set objADDesignPlane = objADDesignPlanes.Item("XY-Plane")

' Holds an Design Axis
Dim objADDesignAxis As AlibreX.IADDesignAxis

' Get "X-Axis" from Design Axes collection
Set objADDesignAxis = objADDesignSession.DesignAxes("X-Axis")

' Holds new Design Plane
Dim objADNewDesignPlane As AlibreX.IADDesignPlane

' Create a new Design Plane using CreateAtAngleToPlane 
Set objADNewDesignPlane = objADDesignPlanes.CreateAtAngleToPlane( _
Nothing, objADDesignPlane, Nothing, objADDesignAxis, 0.785, _
"NewPlaneAtAngleToPlane")
```



# IADDesignPlane.PlaneType Property

Returns a pre-defined constant that identifies how this design geometry was created.

#### Syntax

```
ADDesignGeometryType PlaneType { get; }
```

#### Property Value

ADDesignGeometryType



# IADDesignAxes.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADDesignSurfaces.Item Method

Given a name or numerical index into the collection, returns the corresponding design surface.

#### Syntax

```
IADDesignSurface Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or numerical index of the design surface. If a numeric expression,
    index must be a number 0 or higher, but less than the collection's Count property.

#### Return Value

IADDesignSurface  
Returns IADDesignSurface



# IADDesignSelectionFilter.Sketches2D Property

If true, 2D sketches are selectable.

#### Syntax

```
bool Sketches2D { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDesignAxis Interface

IADDesignAxis repesents the interface for a Design Axis object in a Design.

#### Syntax

```
public interface IADDesignAxis
```

The IADDesignAxis type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | AxisType | Returns a pre-defined constant that identifies how this design geometry was created. |
|  | Direction | Returns the direction of the axis. |
|  | Name | Gets/sets this design axis's name. |
|  | Parameters | Get a collection object containing IADParameter objects associated with this design geometry. |
|  | Root | Returns the automation root. |
|  | Session | Returns the design session for the design axis. |
|  | SourceObjects | The source objects collection represents the objects used to create the Design Axis. This property returns a collection of IADTargetProxy objects. The IADTargetProxy object wraps the dependent object, and also its occurrence if the object belongs to an assembly. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes the design axis. |
|  | GetGeometry | Outputs a point on the axis and a direction vector. |
|  | Hide | Hides the design axis. |
|  | Show | Shows the design axis. |



# IADDesignMesh Interface

IADDesignMesh represents the interface for a Design Mesh object in a Design.

#### Syntax

```
public interface IADDesignMesh
```

The IADDesignMesh type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | IsSurfaced | Returns true if surfacing of the DesignMesh is complete. |
|  | Name | Gets/sets this design mesh's name. |
|  | Root | Returns the automation root. |
|  | Session | Returns the design session for the design plane. |
|  | TriangleCount | Returns true if surfacing of the DesignMesh is complete. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_DESIGN\_PLANE) of this object. |



# IADDesignPlane.Hide Method

Hides the design plane.

#### Syntax

```
void Hide()
```



# IADDesignSession.StopChanges Method

#### Syntax

```
void StopChanges()
```



# IADDesignMesh.Name Property

Gets/sets this design mesh's name.

#### Syntax

```
string Name { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPartSession.Unsuppress Method

Unsuppress all the states in the given collection.

#### Syntax

```
void Unsuppress(
	IObjectCollector states
)
```

#### Parameters

states  IObjectCollector
:   A collection of IADPartFeature objects to unsuppress



# IADDesignSession.DesignMeshes Property

Returns a collection of design meshes for this session.

#### Syntax

```
IADDesignMeshes DesignMeshes { get; }
```

#### Property Value

IADDesignMeshes



# IADDesignAxes.Item Method

Given a name or numerical index into the collection, returns the corresponding design axis.

#### Syntax

```
IADDesignAxis Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or numerical index of the design axis.

#### Return Value

IADDesignAxis  
Returns IADDesignAxis

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INDEX\_OUT\_OF\_BOUNDS | The specified index is outside of the bounds of the collection. |
| AD\_E\_OBJECT\_NOT\_FOUND\_AT\_INDEX | No object exists at the specified index. |
| AD\_E\_VARIANT\_TYPE\_UNSUPPORTED | The index parameter should be an int or a string. |

#### Example

This Visual Basic sample shows how to use the Item method.

```
Set objAlibreDesignAxes = m_objAlibreDesignSession.DesignAxes

'Get Item by number
Set objAlibreDesignAxis = objAlibreDesignAxes.Item(0)

'Get Item by name 
Set objAlibreDesignAxis = objAlibreDesignAxes.Item("X-Axis")
```



# IADDesignPlane Interface

IADDesignPlane represents the interface for a Design Plane object in a Design.

#### Syntax

```
public interface IADDesignPlane
```

The IADDesignPlane type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Name | Gets/sets this design plane's name. |
|  | Normal | Returns the plane's normal. |
|  | Parameters | Get a collection object containing IADParameter objects associated with this design geometry. |
|  | PlaneType | Returns a pre-defined constant that identifies how this design geometry was created. |
|  | Root | Returns the automation root. |
|  | Session | Returns the design session for the design plane. |
|  | SourceObjects | The source objects collection represents the objects used to create the Design Plane. This property returns a collection of IADTargetProxy objects. The IADTargetProxy object wraps the dependent object, and also its occurrence if the object belongs to an assembly. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_DESIGN\_PLANE) of this object. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes the design plane. |
|  | GetGeometry | Returns the lower, upper, and top left corner points for the plane. |
|  | Hide | Hides the design plane. |
|  | Show | Shows the design plane. |



# IADDesignSession.PhysicalProperties Method

Returns the physical properties of this design. These properties include Number of
faces, Number of edges, Number of vertices, Volume, Mass, Center of mass, etc.

#### Syntax

```
IADPhysicalProperties PhysicalProperties(
	ADAccuracySetting accuracy
)
```

#### Parameters

accuracy  ADAccuracySetting
:   The precision level of the physical properties calculation.

#### Return Value

IADPhysicalProperties  
An interface to the results of the physical properties calculation.

#### Remarks

User can specify the accuracy level for calculating the physical properties of
the design. The following are allowed values for the specifying accuracy level:

- **AD\_LOW** – - one decimal point (0.1)
- **AD\_MEDIUM** – - two decimal points (0.01)
- **AD\_HIGH** – - three decimal points (0.0010)
- **AD\_VERY\_HIGH** – - four decimal points (1.0E-4)



# IADPartSession.GetMeshDataEx Method

Returns index-based triangular mesh data, including normals.

#### Syntax

```
void GetMeshDataEx(
	IADConfiguration pConfiguration,
	out Array faceData,
	out Array vertexData,
	out Array normalData
)
```

#### Parameters

pConfiguration  IADConfiguration
:   This configuration will be used to generate the mesh.

faceData  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   The faceData array contains zero-based indices for facets in the mesh.

vertexData  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   vertexData contains (x,y,z) co-ordinates for triplets of points.

normalData  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   normalData contains (x,y,z) components of vectors for normals.

#### Remarks

The x co-ordinate of i th point is at [3\*faceData[i]] position in vertex array.



# IADDesignPlane.Name Property

Gets/sets this design plane's name.

#### Syntax

```
string Name { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)

#### Example

This Visual Basic sample shows how to get/set the Name property.

```
'Print the Design Plane Name
Debug.Print objAlibreDesignPlane.Name

'Set the Design Plane Name to "myPlane"
objAlibreDesignPlane.Name = "myPlane"
```



# IADDesignSession.SetViewTransform Method

Sets the view transformation of this design session.

#### Syntax

```
void SetViewTransform(
	IADTransformation transform
)
```

#### Parameters

transform  IADTransformation



# IADPartSession Methods

The IADPartSession type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | BindKeyToItem | Given a Persistent Key, returns the corresponding Occurrence/Topology element/Sketch.  (Inherited from IADSession) |
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
|  | FacetDataForConfiguration | Returns triangular mesh data for the specified Configuration. |
|  | GetBodiesForConfiguration | Returns the collection of bodies for a specific configuration of this part. |
|  | GetMeshData | Returns index-based triangular mesh data. |
|  | GetMeshDataEx | Returns index-based triangular mesh data, including normals. |
|  | GetMeshDefinition | Returns definition of index-based triangular mesh data. and pVertexDataSize returns |
|  | GetMeshDefinitionEx | Returns definition of index-based triangular mesh data, including normals. |
|  | Highlight | Highlights the object in the canvas.  (Inherited from IADSession) |
|  | NewTargetProxy | Creates a new TargetProxy for the given target and the occurrence  (Inherited from IADSession) |
|  | PhysicalProperties | Returns the physical properties of this design. These properties include Number of faces, Number of edges, Number of vertices, Volume, Mass, Center of mass, etc.  (Inherited from IADDesignSession) |
|  | postProcessPrintabilityChecking | Postprocess of printability checking (Clear body member cache.)  (Inherited from IADDesignSession) |
|  | preparePrintabilityChecking | Prepares printability meshes. This is only for Alibre Test Bed.  (Inherited from IADDesignSession) |
|  | PrintabilityCheckResults | Returns the printability check results of this design  (Inherited from IADDesignSession) |
|  | RegenerateAll | Regenerate all features. |
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
|  | Suppress | Suppress all the states in the given collection. |
|  | Unsuppress | Unsuppress all the states in the given collection. |
|  | UnSuppressAll | Unsuppress all features. |
|  | UpdatePreviewSnaphot | Captures the canvas image displayed for this session and silently saves it as the file snapshot property  (Inherited from IADSession) |
|  | ViewExtents | Returns view extents of this design session, in screen coordinates.  (Inherited from IADDesignSession) |



# IADDesignSession.ViewTransform Property

Returns view transformation of this design session.

#### Syntax

```
IADTransformation ViewTransform { get; }
```

#### Property Value

IADTransformation



# IADDesignSelectionFilter.Surface Property

Gets/sets the current selection filter setting for reference surfaces.

#### Syntax

```
ADSelectionFilterOption Surface { get; set; }
```

#### Property Value

ADSelectionFilterOption



# IADDesignPoint.Hide Method

Hides the design point.

#### Syntax

```
void Hide()
```



# IADDesignSession.DesignPoints Property

Returns a collection of design points for this session.

#### Syntax

```
IADDesignPoints DesignPoints { get; }
```

#### Property Value

IADDesignPoints



# IADDesignPoint.Show Method

Shows the design point.

#### Syntax

```
void Show()
```



# IADDesignSession.CameraPosition Property

Returns an IADPoint with the current location of the camera in this design session.

#### Syntax

```
IADPoint CameraPosition { get; }
```

#### Property Value

IADPoint



# IADDesignMeshes Methods

The IADDesignMeshes type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateFromFile |  |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given a name or numerical index into the collection, returns the corresponding design mesh. |



# IADDesignSurfaces.Count Property

Returns the number of design surface in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADIGESOptions.HasTrimmedCurves Property

If true, Alibre will write trimmed curves as 2D parametric curves with the trimmed
curve preference for 2D data when exporting IGES files. Required when writing IGES
files for CATIA.

#### Syntax

```
bool HasTrimmedCurves { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDesignPlanes.Count Property

Returns the number of design planes in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADDesignProperties.Description Property

Gets/sets the description for the design.

#### Syntax

```
string Description { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADIGESOptions.Units Property

Gets/sets the units used when exporting IGES files.

#### Syntax

```
ADUnits Units { get; set; }
```

#### Property Value

ADUnits



# IADDesignProperties.CustomProperty Method

#### Overload List

|  | Name | Description |
| --- | --- | --- |
|  | CustomProperty(String) | Returns the custom property for the input custom property name (applies to file based custom properties only) |
|  | CustomProperty(String, Object) | Sets the custom property for the input custom property name. |



# IDecomposedTransformData.TranslateX Property

Returns the translate component of the decomposed transform in the X direction.

#### Syntax

```
double TranslateX { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADDesignSelectionFilter.Points Property

If true, reference points are selectable.

#### Syntax

```
bool Points { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADIGESOptions Interface

IADIGESOptions represents the IGES File Type options that are available in the
Options dialog in the Alibre Design GUI. Setting the properties on this interface
will change the setting for these options. Currently, only the Write section
of the IGES options is supported by the API.

#### Syntax

```
public interface IADIGESOptions
```

The IADIGESOptions type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EOLLength | Gets/sets the length of the end-of-line character (in bytes). Value must be between 1 through 4. |
|  | HasBoundedSurfaces | If true, Alibre will write all surfaces as bounded when exporting IGES files. Otherwise, surfaces are written as trimmed whenever possible. |
|  | HasEllipsesAsNURBS | If true, Alibre will write ellipses as NURBs curves when exporting IGES files. This compensates for programs that do not support conic arcs. IGES uses conic arcs to write ACIS ellipses. |
|  | HasTrimmedCurves | If true, Alibre will write trimmed curves as 2D parametric curves with the trimmed curve preference for 2D data when exporting IGES files. Required when writing IGES files for CATIA. |
|  | HasTrimSurfacesAsNURBS | If true, this option specifies that all surfaces be converted to NURBs (Non-Uniform Rational B-Splines) and written as IGES NURBs surfaces (Entity #128). |
|  | HasWireAsCopiousData | Set this option to true to write a wire as copious data (entity #106, form 12). Otherwise, separate curves are written for the wire. |
|  | IsAutoCAD | If true, IGES files will be exported with faces specifically for use with AutoCAD. |
|  | IsJAMA | If true, the JAMA-IS v1.04 Specification, a subset of the IGES V5.0 specification, will be used to export IGES files. Setting this to true accepts the JAMA convention of not supporting some constraints. |
|  | IsMSBO | If true, parts will be exported as MSBOs (Manifold Solid B-rep Objects). Otherwise these parts are exported as trimmed faces, but without connectivity information for IGES Version 4.0 compatibility. |
|  | Units | Gets/sets the units used when exporting IGES files. |

#### Remarks

After setting the desired IGES file type options, an IGES file can be
exported using these settings with the ExportIGES
method on the design session you wish to export.

#### Example

This sample shows how to change the IGES export options and export an IGES file with those options.

```
IADIGESOptions IgesOptions = designSession.IGESOptions;  //designSession is a valid IADDesignSession
IgesOptions.IsAutoCAD = false;
IgesOptions.IsJAMA = false;
IgesOptions.HasEllipsesAsNURBS = false;
IgesOptions.IsMSBO = false;
IgesOptions.HasWireAsCopiousData = false;
IgesOptions.HasTrimmedCurves = true;
IgesOptions.HasTrimSurfacesAsNURBS = true;
IgesOptions.HasBoundedSurfaces = true;
IgesOptions.EOLLength = 4;
IgesOptions.Units = ADUnits.AD_CENTIMETERS;
designSession.ExportIGES(@"C:\TestExport.igs");
```



# IADDesignPoints Methods

The IADDesignPoints type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateAtOffsetToPoint | Creates a new design point at a given offset distance from another point/vertex |
|  | CreateBetween2Points | Creates a new design point at a set ratio between two given points |
|  | CreateBy2Axes | Creates a design point at the intersection of an axis/edge and another axis/edge |
|  | CreateBy3Planes | Creates a design point at the intersection of three planes/faces |
|  | CreateByAxisAndPlane | Creates a design point at the intersection of an axis/edge and a plane/face. |
|  | CreateByProjectingToPlane | Creates a new design point projected on to a plane |
|  | CreateOnEdge | Creates a new design point on a given edge at a set ratio from its start point |
|  | CreatePoint | Creates a design point given X, Y and Z coordinates. |
|  | CreatePointFromCircularEdge | Creates a design point at the center of a circular edge. |
|  | CreatePointFromToroidalFace | Creates a design point at the center of a toroidal face. |
|  | Item | Given a name or numerical index into the collection, returns the corresponding design point. |



# IADDesignProperties Methods

The IADDesignProperties type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CustomProperty(String) | Returns the custom property for the input custom property name (applies to file based custom properties only) |
|  | CustomProperty(String, Object) | Sets the custom property for the input custom property name. |
|  | ExtendedDesignProperty(ADExtendedDesignProperty) | Returns the design property for the input property identifier. |
|  | ExtendedDesignProperty(ADExtendedDesignProperty, Object) | Sets the design property for the input property identifier. |



# IDecomposedTransformData.ShearZX Property

Returns the shearZX component of the decomposed transform.

#### Syntax

```
double ShearZX { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADDesignPoint.Name Property

Gets/sets this design point's name.

#### Syntax

```
string Name { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADDesignProperties Interface

IADDesignProperties is an interface for properties that are associated with the workspace.
These properties include display units, and file information for the design.

#### Syntax

```
public interface IADDesignProperties
```

The IADDesignProperties type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | AngleDisplayUnits | Gets the unit of measurement for displaying angles in the workspace. |
|  | Density | Gets/Sets the density of the material used for the design. |
|  | Description | Gets/sets the description for the design. |
|  | LengthDisplayUnits | Gets the unit of measurement for displaying lengths in the workspace. |
|  | MassUnits | Returns the unit of measurement for displaying mass in the workspace. |
|  | Material | Gets/sets the name of the material of the design. |
|  | ModelUnits | Returns the internal model unit of measurement for representing lengths in the design. |
|  | Number | Gets/Sets the number for the design. This is a user-specific string to denote version of the design. |
|  | TreatAsPartInBOM | Gets/Sets the Treat as part in BOM design property. NOTE: This property affects only an assembly workspace. |
|  | VersionComment | Gets/sets the Version Comment for the design. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CustomProperty(String) | Returns the custom property for the input custom property name (applies to file based custom properties only) |
|  | CustomProperty(String, Object) | Sets the custom property for the input custom property name. |
|  | ExtendedDesignProperty(ADExtendedDesignProperty) | Returns the design property for the input property identifier. |
|  | ExtendedDesignProperty(ADExtendedDesignProperty, Object) | Sets the design property for the input property identifier. |



# IADDesignAxes Interface

This interface represents a collection of IADDesignAxis.

#### Syntax

```
public interface IADDesignAxes
```

The IADDesignAxes type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of design axes in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the design session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateBy2Planes | Creates a design axis from two intersecting design planes or planar faces. |
|  | CreateBy2Points | Creates a design axis given two points/vertices. |
|  | CreateFromCylindricalFace | Creates a design axis touching a cylindrical face. |
|  | Item | Given a name or numerical index into the collection, returns the corresponding design axis. |

#### Remarks

- The Axes collection is obtained by querying for the property DesignAxes
  on IADDesignSession. This gives a collection of all the Design
  Axes existing in the Design.
- Three built-in objects to represent X-Axis, Y-Axis, and Z-Axis are provided.
  These three objects will be the first three items in the Axes collection.
- It is possible to create a new Axis.
  Following are three different ways provided to create a new Axis:
  - Using two existing Planes (CreateBy2Planes)
  - Using two existing Points (CreateBy2Points)
  - Using a cylindrical Face (CreateFromCylindricalFace)



# IADBodies.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADDesignSurfaces Properties

The IADDesignSurfaces type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of design surface in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the part session for the collection. |



# IADDesignSession.DesignPlanes Property

Returns a collection of design planes for this session.

#### Syntax

```
IADDesignPlanes DesignPlanes { get; }
```

#### Property Value

IADDesignPlanes



# IADDesignSession.SelectionFilter Property

Gets the interface to this design session's selection filter. The interface's properties
can be queried to find the current settings or set to change the active selection filters.

#### Syntax

```
IADDesignSelectionFilter SelectionFilter { get; }
```

#### Property Value

IADDesignSelectionFilter



# IADDesignSession.CheckPrintability Method

Start checking printability, check printability calculating status is on or off.

#### Syntax

```
bool CheckPrintability(
	bool bCheckStatus
)
```

#### Parameters

bCheckStatus  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IDecomposedTransformData.RotateAngle Property

Returns the rotation angle component in radians about the rotation vector for the decomposed transform.

#### Syntax

```
double RotateAngle { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADDesignProperties.Number Property

Gets/Sets the number for the design. This is a user-specific string to denote version of the design.

#### Syntax

```
string Number { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADDesignSurface.Faces Property

Get all the faces in this surface.

#### Syntax

```
IADFaces Faces { get; }
```

#### Property Value

IADFaces



# IADDesignProperties.TreatAsPartInBOM Property

Gets/Sets the Treat as part in BOM design property.
NOTE: This property affects only an assembly workspace.

#### Syntax

```
bool TreatAsPartInBOM { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDesignSelectionFilter Properties

The IADDesignSelectionFilter type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Annotations | If true, annotations are selectable. |
|  | Axes | If true, reference axes are selectable. |
|  | Dimensions | If true, dimensions are selectable. |
|  | Planes | If true, reference planes are selectable. |
|  | Points | If true, reference points are selectable. |
|  | Redlines | If true, redlines are selectable. |
|  | Sketches2D | If true, 2D sketches are selectable. |
|  | Sketches3D | If true, 3D sketches are selectable. |
|  | Solid | Gets/sets the current selection filter setting for topological elements of solid bodies in the design. |
|  | Surface | Gets/sets the current selection filter setting for reference surfaces. |



# IADDesignMesh.Type Property

Returns a pre-defined constant that identifies the type (AD\_DESIGN\_PLANE) of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADPartSession.Bodies Property

The collection of bodies in this part.

#### Syntax

```
IADBodies Bodies { get; }
```

#### Property Value

IADBodies



# IADDesignSession.DesignProperties Property

Returns the design properties of the design.

#### Syntax

```
IADDesignProperties DesignProperties { get; }
```

#### Property Value

IADDesignProperties



# IADDesignPlanes Properties

The IADDesignPlanes type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of design planes in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the design session for the collection. |



# IADBodies Properties

The IADBodies type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of bodies in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the part session for the collection. |



# IADConfigurations.Item Method

Given a configuration's name or index, returns the corresponding configuration.

#### Syntax

```
IADConfiguration Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or numerical index of the configuration.

#### Return Value

IADConfiguration  
Returns IADConfiguration

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INDEX\_OUT\_OF\_BOUNDS | The specified index is outside the bounds of the collection. |

#### Example

This Visual Basic sample shows how to call the Item method.

```
' Holds Session object
Dim objSession as IADSession 

' Open an existing part using OpenFile() on Root object. Note: User may set it to any required file and location
Set objADSession = m_objADRoot.OpenFile("C://Part.AD_PRT")

' Holds Alibre Design Session object
Dim objDesignSession As IADDesignSession 

'Assign objADSession to objDesignSession 
Set objDesignSession = objADSession

'Holds all configurations in a design session
Dim objConfigs As IADConfigurations

'set the configurations in the design session
Set objConfigs = DesignSession.Configurations

'Holds a configuration in a design session
Dim objConfig As IADConfigurations

'Set the first configuration to objConfig  
Set objConfig = objConfigs.Item(0)
```



# IADIGESOptions.IsJAMA Property

If true, the JAMA-IS v1.04 Specification, a subset of the IGES V5.0 specification, will
be used to export IGES files. Setting this to true accepts the JAMA convention of not
supporting some constraints.

#### Syntax

```
bool IsJAMA { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

JAMA does not support any MSBO entities.



# IADDesignAxis.Show Method

Shows the design axis.

#### Syntax

```
void Show()
```



# IADGlobalParameterSession Properties

The IADGlobalParameterSession type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ActiveConfiguration | Gets/sets the active configuration for this global parameter session. |
|  | Configurations | Returns the collection of configurations present in this global parameter session. |
|  | ConstituentFilePaths | Returns file path strings for other Design files that are referenced by this session.  (Inherited from IADSession) |
|  | FilePath | Returns the location on disk of where the file was last saved. If unsaved, returns null.  (Inherited from IADSession) |
|  | GeometryFactory | Returns the Geometry Factory.  (Inherited from IADSession) |
|  | Identifier | Returns the session's unique identifier.  (Inherited from IADSession) |
|  | IsGUIVisible | Returns True if the GUI for this session is visible.  (Inherited from IADSession) |
|  | Name | Returns this session's name.  (Inherited from IADSession) |
|  | Parameters | Returns a collection of parameters for this session.  (Inherited from IADSession) |
|  | PreviewSnapshot | Returns a OLE picture object containing the preview snapshot bitmap for the session.  (Inherited from IADSession) |
|  | Root | Returns the automation root.  (Inherited from IADSession) |
|  | SelectedObjects | Returns all selected entities in the session's browser as a collection of target proxies.  (Inherited from IADSession) |
|  | SessionType | Returns a pre-defined constant that identifies whether this session is a part or assembly or drawing session.  (Inherited from IADSession) |
|  | TimeStamp | Returns time stamp of this session; the time stamp changes when changes are saved to the session.  (Inherited from IADSession) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SESSION)  (Inherited from IADSession) |



# IADDesignSession.IsSectioning Property

Returns true if design has a current active section view.

#### Syntax

```
bool IsSectioning { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPartSession.Suppress Method

Suppress all the states in the given collection.

#### Syntax

```
void Suppress(
	IObjectCollector states
)
```

#### Parameters

states  IObjectCollector
:   A collection of IADPartFeature objects to suppress



# IADDesignSurfaces.InsertFromFile Method

Insert Surface(s) from the given file.

#### Syntax

```
IObjectCollector InsertFromFile(
	string fileName,
	ADFaceProcessingType faceProcessingType,
	bool healOption,
	bool makeTolerantOption,
	ADUnits overridingUnit
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The full path of the file containing the surface to insert.
    Valid filetypes are \*.igs, \*.sat, and \*.3dm

faceProcessingType  ADFaceProcessingType
:   The type of face processing to be used when importing the file.

healOption  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, Alibre will attempt to heal the surface after importing.

makeTolerantOption  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, Alibre will attempt to make edges tolerant after importing.

overridingUnit  ADUnits
:   Use this parameter to override the units in the file being imported.
    The default value AD\_UNITLESS will not override the units.

#### Return Value

IObjectCollector  
Returns a collection of Surfaces that are inserted. Note
that depending upon the Face Processing Type specified, more than one surface can result
from a given file.

#### Remarks

Currently, only IGES, SAT, and 3DM files are supported.

You can specify how the faces are to be processed. Following is a description
of each of the allowed types.

- AD\_STITCH\_ADJOINING\_FACES - takes faces that meet
  at a common edge and places them in the same surface body. Each resulting lump becomes a
  surface.
- AD\_NONE - inserts the surfaces as they exist in the file. Each lump
  is a surface. The body is unchanged.
- AD\_UNSTITCH\_TO\_STANDALONE\_SURFACES - converts each face into
  a separate surface.

In addition to Face Processing type, user can also specify options for healing.

If Heal option is true, it cleans up the body by making sure edges lie on faces, eliminates
duplicate vertices, etc. Healing attempts to fix problems detected with the model by changing it.
Most IGES files require healing to import properly.

The Make Tolerant option will tag inaccurate geometry to enable more intelligent subsequent
operations after import. Because the geometry of a tolerant model is allowed to be less precise,
inaccurate or leaky data can often be imported using the Make Tolerant option. Making a model
tolerant leaves its underlying geometry unchanged.



# IADDesignMesh.Root Property

Returns the automation root.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADDesignPlane.Parameters Property

Get a collection object containing IADParameter objects associated with this design geometry.

#### Syntax

```
IObjectCollector Parameters { get; }
```

#### Property Value

IObjectCollector

#### Remarks

If a Plane is created at an offset to an existing Plane, then
Parameters include the Offset parameter specified. Similarly,
Parameters include the Angle parameter in the case of a Plane that is created at an angle to
a given Plane.

This Property returns null when called on built-in Planes (i.e. XY-Plane, YZ-Plane,
ZX-Plane).

#### Example

This Visual Basic sample shows how to get the Parameters property.

```
' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds XY-Plane object
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Get XY-Plane from Design Planes collection by Name
Set objADDesignPlane = objADDesignSession.DesignPlanes("XY-Plane")

' Holds an Design Axis
Dim objADDesignAxis As AlibreX.IADDesignAxis

' Get "X-Axis" from Design Axes collection
Set objADDesignAxis = objADDesignSession.DesignAxes("X-Axis")

' Holds new Design Plane created at an angle to plane
Dim objADNewDesignPlane As AlibreX.IADDesignPlane

' Create a new Design Plane using CreateAtAngleToPlane.
Set objADNewDesignPlane = objADDesignSession.DesignPlanes.CreateAtAngleToPlane( _
            Nothing, objADDesignPlane, Nothing, objADDesignAxis, 0.785,  _
            "NewPlaneAtAngleToPlane")

' Holds Paramaters collection object
Dim objObjectCollector As AlibreX.IObjectCollector

' Get parameters associated with the plane.
Set objObjectCollector = objADNewDesignPlane.Parameters
```



# IADDesignSelectionFilter.Sketches3D Property

If true, 3D sketches are selectable.

#### Syntax

```
bool Sketches3D { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDesignSurface Interface

IADDesignSurface is the interface for a Design Surface body in a Design. For example,
if the user inserts a surface or surfaces into the Part design, each of those surface
bodies is represented by an IADDesignSurface interface. This interface is similar
to IADBody. While IADBody represents
a body of the Part design, IADDesignSurface represents a surface body inserted
into the Part design.

#### Syntax

```
public interface IADDesignSurface
```

The IADDesignSurface type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Edges | Get all the edges in this surface. |
|  | Faces | Get all the faces in this surface. |
|  | Name | Gets/sets the name of this design surface. |
|  | Root | Returns the automation root object. |
|  | Session | Returns the part session for the design surface. |
|  | Transform | Gets/sets the local transformation of this surface. This transformation defines the scale, position, and rotation of the surface within the design. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_DESIGN\_SURFACE) of this object. |
|  | Vertices | Get all the vertices in this surface |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes the design surface. |



# IADDesignPlane.Normal Property

Returns the plane's normal.

#### Syntax

```
IADVector Normal { get; }
```

#### Property Value

IADVector

#### Remarks

The normal returned is a unit vector.

#### Example

This Visual Basic sample shows how to get the Normal property.

```
' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane object
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Get Design Plane from Design Planes collection by Name
Set objADDesignPlane = objADDesignSession.DesignPlanes("XY-Plane")

' Vector to capture Plane Normal
Dim objADVector As AlibreX.IADVector

' Get Design Plane Normal using Normal.
Set objADVector = objADDesignPlane.Normal
```



# IADDesignPoints.CreateBetween2Points Method

Creates a new design point at a set ratio between two given points

#### Syntax

```
IADDesignPoint CreateBetween2Points(
	IADOccurrence pOccurrence1,
	Object pPoint1,
	IADOccurrence pOccurrence2,
	Object pPoint2,
	double ratio,
	string name
)
```

#### Parameters

pOccurrence1  IADOccurrence
:   Denotes an "instance" of a Part or Assembly to which
    pPoint1 belongs to. For creating a new point in a standalone Part, pOccurrence1
    should be null.

pPoint1  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   First point or vertex.

pOccurrence2  IADOccurrence
:   Denotes an "instance" of a Part or Assembly to which
    pPoint2 belongs to. For creating a new point in a standalone Part, pOccurrence2
    should be null.

pPoint2  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Second point or vertex.

ratio  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The interpolation ratio as a proportion of the distance between the two input points.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new design point. If a null or empty string is passed,
    Alibre will name the point.

#### Return Value

IADDesignPoint  
Returns the new IADDesignPoint.



# IADDesignPoints.Count Property

Returns the number of design points in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IDecomposedTransformData.ScaleZ Property

Returns the scale component of the decomposed transform in Z direction.

#### Syntax

```
double ScaleZ { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADDesignSession Interface

IADDesignSession interface

#### Syntax

```
public interface IADDesignSession : IADSession
```

The IADDesignSession type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ActiveConfiguration | Gets/sets the active configuration for this design session. |
|  | AutoBrepImportSummary |  |
|  | AutoRegenerate | Determines whether the DesignSession will be automatically regenerated after a change. |
|  | CameraPosition | Returns an IADPoint with the current location of the camera in this design session. |
|  | CircularFacets | Gets the current display setting for the minimal circular facets option of the design. |
|  | Configurations | Returns the collection of configurations present in this design session. |
|  | ConstituentFilePaths | Returns file path strings for other Design files that are referenced by this session.  (Inherited from IADSession) |
|  | DesignAxes | Returns a collection of design axes for this session. |
|  | DesignMeshes | Returns a collection of design meshes for this session. |
|  | DesignPlanes | Returns a collection of design planes for this session. |
|  | DesignPoints | Returns a collection of design points for this session. |
|  | DesignProperties | Returns the design properties of the design. |
|  | FilePath | Returns the location on disk of where the file was last saved. If unsaved, returns null.  (Inherited from IADSession) |
|  | GeometryFactory | Returns the Geometry Factory.  (Inherited from IADSession) |
|  | HasErrors | Returns true if the design has errors. |
|  | Identifier | Returns the session's unique identifier.  (Inherited from IADSession) |
|  | IGESOptions | Returns an IADIGESOptions object containing the currently selected IGES options. This object has several properties you can get/set to change the current options relating to IGES export. |
|  | IsGUIVisible | Returns True if the GUI for this session is visible.  (Inherited from IADSession) |
|  | IsPerspective | Returns true if the current display of the design is in perspective view mode, rather than orthogonal. |
|  | IsSectioning | Returns true if design has a current active section view. |
|  | ModelTolerance | Returns Model tolerance. |
|  | Name | Returns this session's name.  (Inherited from IADSession) |
|  | Parameters | Returns a collection of parameters for this session.  (Inherited from IADSession) |
|  | PreviewSnapshot | Returns a OLE picture object containing the preview snapshot bitmap for the session.  (Inherited from IADSession) |
|  | Root | Returns the automation root.  (Inherited from IADSession) |
|  | SavedViews | Gets all the saved views for this session. |
|  | SelectedObjects | Returns all selected entities in the session's browser as a collection of target proxies.  (Inherited from IADSession) |
|  | SelectionFilter | Gets the interface to this design session's selection filter. The interface's properties can be queried to find the current settings or set to change the active selection filters. |
|  | SessionType | Returns a pre-defined constant that identifies whether this session is a part or assembly or drawing session.  (Inherited from IADSession) |
|  | Sketches | Returns the collection of sketches for this design. |
|  | TimeStamp | Returns time stamp of this session; the time stamp changes when changes are saved to the session.  (Inherited from IADSession) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SESSION)  (Inherited from IADSession) |
|  | ViewTransform | Returns view transformation of this design session. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | BindKeyToItem | Given a Persistent Key, returns the corresponding Occurrence/Topology element/Sketch.  (Inherited from IADSession) |
|  | CheckPrintability | Start checking printability, check printability calculating status is on or off. |
|  | Close | Closes the session and optionally saves before closing.  (Inherited from IADSession) |
|  | CreatePackage | (Inherited from IADSession) |
|  | ExportAP203 | Exports the design session as ISO AP203 STEP file. |
|  | ExportAP214 | Exports the design session as ISO AP214 STEP file. |
|  | ExportAP242 | Exports the design session as ISO AP242 STEP file. |
|  | ExportBIP(String) |  |
|  | ExportBIP(String, String) |  |
|  | ExportBOM | Export the bill of materials as a .csv file at the specified path. |
|  | ExportIGES | Exports the design session as an IGES file. The settings in Alibre's Options will be used when exporting the file. |
|  | ExportOBJ | Exports the design session as a OBJ file. |
|  | ExportParasolid | Exports the design session as a Parasolid file. |
|  | ExportSAT | Exports the design session as an ACIS SAT file. |
|  | ExportSAT2 | Exports the design as an ACIS SAT file. |
|  | ExportSTEP | Exports the design session as a Alibre STEP file. |
|  | ExportSTL | Exports the design session as an STL file. |
|  | ExportSTL2 | Exports the design session as an STL file. |
|  | Highlight | Highlights the object in the canvas.  (Inherited from IADSession) |
|  | NewTargetProxy | Creates a new TargetProxy for the given target and the occurrence  (Inherited from IADSession) |
|  | PhysicalProperties | Returns the physical properties of this design. These properties include Number of faces, Number of edges, Number of vertices, Volume, Mass, Center of mass, etc. |
|  | postProcessPrintabilityChecking | Postprocess of printability checking (Clear body member cache.) |
|  | preparePrintabilityChecking | Prepares printability meshes. This is only for Alibre Test Bed. |
|  | PrintabilityCheckResults | Returns the printability check results of this design |
|  | RegenerateDesign | Regenerate all the features of the design in this session. |
|  | Save | Saves modified session and sub-sessions, if any, to their original folder locations.  (Inherited from IADSession) |
|  | SaveAll | Saves a copy of the session and all sub-sessions to the directory indicated by the destination parameter.  (Inherited from IADSession) |
|  | SaveAs | Saves the session to create a new copy with the given name.  (Inherited from IADSession) |
|  | SaveCurrentViewSnapshot | Saves the snapshot of the graphic canvas for current view in the session, at the given location and of the given size.  (Inherited from IADSession) |
|  | SaveNew | Saves a new, unsaved session to the specified folder location.  (Inherited from IADSession) |
|  | Select | Selects all objects passed in pEntities.  (Inherited from IADSession) |
|  | SelectedObjectsEx | Returns all selected entities in the session's browser as a collection of target proxies, and sets the parameter lastSelectedPoint to last point in the user clicked to make the selection.  (Inherited from IADSession) |
|  | SetViewTransform | Sets the view transformation of this design session. |
|  | StartChanges |  |
|  | StopChanges |  |
|  | UpdatePreviewSnaphot | Captures the canvas image displayed for this session and silently saves it as the file snapshot property  (Inherited from IADSession) |
|  | ViewExtents | Returns view extents of this design session, in screen coordinates. |



# IADPartSession.GetMeshDefinition Method

Returns definition of index-based triangular mesh data. and pVertexDataSize returns

#### Syntax

```
void GetMeshDefinition(
	IADConfiguration pConfiguration,
	out int pFaceDataSize,
	out int pVertexDataSize
)
```

#### Parameters

pConfiguration  IADConfiguration
:   This configuration will be used to generate the mesh.

pFaceDataSize  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The size of the index array which contains indices of triangles in mesh.

pVertexDataSize  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The size of an array which contains co-ordinates of vertices in the mesh.



# IDecomposedTransformData.TranslateZ Property

Returns the translate component of the decomposed transform in the Z direction.

#### Syntax

```
double TranslateZ { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADGlobalParameterSession.ActiveConfiguration Property

Gets/sets the active configuration for this global parameter session.

#### Syntax

```
IADConfiguration ActiveConfiguration { get; set; }
```

#### Property Value

IADConfiguration



# IADPartSession Properties

The IADPartSession type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ActiveConfiguration | Gets/sets the active configuration for this design session.  (Inherited from IADDesignSession) |
|  | AutoBrepImportSummary | (Inherited from IADDesignSession) |
|  | AutoRegenerate | Determines whether the DesignSession will be automatically regenerated after a change.  (Inherited from IADDesignSession) |
|  | Bodies | The collection of bodies in this part. |
|  | CameraPosition | Returns an IADPoint with the current location of the camera in this design session.  (Inherited from IADDesignSession) |
|  | CircularFacets | Gets the current display setting for the minimal circular facets option of the design.  (Inherited from IADDesignSession) |
|  | Color | The part's color. |
|  | Configurations | Returns the collection of configurations present in this design session.  (Inherited from IADDesignSession) |
|  | ConstituentFilePaths | Returns file path strings for other Design files that are referenced by this session.  (Inherited from IADSession) |
|  | DesignAxes | Returns a collection of design axes for this session.  (Inherited from IADDesignSession) |
|  | DesignMeshes | Returns a collection of design meshes for this session.  (Inherited from IADDesignSession) |
|  | DesignPlanes | Returns a collection of design planes for this session.  (Inherited from IADDesignSession) |
|  | DesignPoints | Returns a collection of design points for this session.  (Inherited from IADDesignSession) |
|  | DesignProperties | Returns the design properties of the design.  (Inherited from IADDesignSession) |
|  | DesignSurfaces | The collection of surfaces in this part. |
|  | EdgeColor | The edge color of the part, as a BGR int. |
|  | FacetData | Returns the triangular mesh data for the active configuration. |
|  | FeatureCount | Returns the features count. |
|  | Features | Returns the collection of features in this part. |
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
|  | Reflectivity | The part's reflectivity |
|  | Root | Returns the automation root.  (Inherited from IADSession) |
|  | SavedViews | Gets all the saved views for this session.  (Inherited from IADDesignSession) |
|  | SectionBody | Returns the section body in this design. |
|  | SelectedObjects | Returns all selected entities in the session's browser as a collection of target proxies.  (Inherited from IADSession) |
|  | SelectionFilter | Gets the interface to this design session's selection filter. The interface's properties can be queried to find the current settings or set to change the active selection filters.  (Inherited from IADDesignSession) |
|  | SessionType | Returns a pre-defined constant that identifies whether this session is a part or assembly or drawing session.  (Inherited from IADSession) |
|  | ShowFeatureColor | Returns whether the feature color is shown for this design or not. |
|  | Sketches | Returns the collection of sketches for this design. |
|  | Sketches3D | The collection of 3D sketches for this design. |
|  | TimeStamp | Returns time stamp of this session; the time stamp changes when changes are saved to the session.  (Inherited from IADSession) |
|  | Transparency | The part's transparency. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SESSION)  (Inherited from IADSession) |
|  | ViewTransform | Returns view transformation of this design session.  (Inherited from IADDesignSession) |



# IADDesignSession.postProcessPrintabilityChecking Method

Postprocess of printability checking (Clear body member cache.)

#### Syntax

```
bool postProcessPrintabilityChecking()
```

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDesignPoints Interface

IADDesignPoints represent the interface for a Collection of Points in a Design.

#### Syntax

```
public interface IADDesignPoints
```

The IADDesignPoints type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of design points in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the design session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateAtOffsetToPoint | Creates a new design point at a given offset distance from another point/vertex |
|  | CreateBetween2Points | Creates a new design point at a set ratio between two given points |
|  | CreateBy2Axes | Creates a design point at the intersection of an axis/edge and another axis/edge |
|  | CreateBy3Planes | Creates a design point at the intersection of three planes/faces |
|  | CreateByAxisAndPlane | Creates a design point at the intersection of an axis/edge and a plane/face. |
|  | CreateByProjectingToPlane | Creates a new design point projected on to a plane |
|  | CreateOnEdge | Creates a new design point on a given edge at a set ratio from its start point |
|  | CreatePoint | Creates a design point given X, Y and Z coordinates. |
|  | CreatePointFromCircularEdge | Creates a design point at the center of a circular edge. |
|  | CreatePointFromToroidalFace | Creates a design point at the center of a toroidal face. |
|  | Item | Given a name or numerical index into the collection, returns the corresponding design point. |

#### Remarks

- The Points collection is obtained by querying for the property DesignPoints
  on IADDesignSession. This gives a collection of all the Design
  Points existing in the Design.
- Origin is the only 3D point that exists by default.
- A new Point (IADDesignPoint) can be created by using
  any of the following ways to create a new Point.
  - Using the XYZ coordinates of the point (
    CreatePoint)
  - Using a circular edge (
    CreatePointFromCircularEdge)



# IADDesignProperties.Material Property

Gets/sets the name of the material of the design.

#### Syntax

```
string Material { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADDesignSession.ExportAP242 Method

Exports the design session as ISO AP242 STEP file.

#### Syntax

```
void ExportAP242(
	string fileName
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the exported file.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_INVALID\_LICENSE\_KEY | The license for this installation of Alibre Design does not permit exporting this design as a STEP file. |



# IADDesignMeshes.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADIGESOptions.IsMSBO Property

If true, parts will be exported as MSBOs (Manifold Solid B-rep Objects). Otherwise these
parts are exported as trimmed faces, but without connectivity information for IGES
Version 4.0 compatibility.

#### Syntax

```
bool IsMSBO { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

IGES Version 4.0 does not support topology information.



# IADDesignSession.ModelTolerance Property

Returns Model tolerance.

#### Syntax

```
double ModelTolerance { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADDesignSelectionFilter.Solid Property

Gets/sets the current selection filter setting for topological
elements of solid bodies in the design.

#### Syntax

```
ADSelectionFilterOption Solid { get; set; }
```

#### Property Value

ADSelectionFilterOption



# IDecomposedTransformData.ScaleX Property

Returns the scale component of the decomposed transform in X direction.

#### Syntax

```
double ScaleX { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADPartSession.DesignSurfaces Property

The collection of surfaces in this part.

#### Syntax

```
IADDesignSurfaces DesignSurfaces { get; }
```

#### Property Value

IADDesignSurfaces



# IADPartSession.EdgeColor Property

The edge color of the part, as a BGR int.

#### Syntax

```
int EdgeColor { get; set; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADDesignPoints.CreateByProjectingToPlane Method

Creates a new design point projected on to a plane

#### Syntax

```
IADDesignPoint CreateByProjectingToPlane(
	IADOccurrence pOccurrence1,
	Object pPoint,
	IADOccurrence pOccurrence2,
	Object pPlane,
	Object XOffset,
	Object YOffset,
	string name
)
```

#### Parameters

pOccurrence1  IADOccurrence
:   Denotes an "instance" of a Part or Assembly to which the given
    pPoint belongs to. For creating a new point in a standalone Part, pOccurrence
    should be null.

pPoint  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Input point or vertex
    to project

pOccurrence2  IADOccurrence
:   Denotes an "instance" of a Part or Assembly to which the given
    pPlane belongs to. For creating a new point in a standalone Part, pOccurrence
    should be null.

pPlane  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Input plane or planar face
    which will be used to define the projection point.

XOffset  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Offset distance along plane's X direction after projection.

YOffset  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Offset distance along plane's Y direction after projection.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new design point. If a null or empty string is passed,
    Alibre will name the point.

#### Return Value

IADDesignPoint  
Returns the new IADDesignPoint.



# IADPartSession.Transparency Property

The part's transparency.

#### Syntax

```
int Transparency { get; set; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

Acceptable values for the transparency range from 0 to 99. A transparency of
0 makes the part opaque and 99 gives the part the maximum transparency.



# IADDesignMesh.Session Property

Returns the design session for the design plane.

#### Syntax

```
IADDesignSession Session { get; }
```

#### Property Value

IADDesignSession



# IADDesignAxes Methods

The IADDesignAxes type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateBy2Planes | Creates a design axis from two intersecting design planes or planar faces. |
|  | CreateBy2Points | Creates a design axis given two points/vertices. |
|  | CreateFromCylindricalFace | Creates a design axis touching a cylindrical face. |
|  | Item | Given a name or numerical index into the collection, returns the corresponding design axis. |



# IADPartSession.SectionBody Property

Returns the section body in this design.

#### Syntax

```
IADBody SectionBody { get; }
```

#### Property Value

IADBody



# IADDesignAxis.Name Property

Gets/sets this design axis's name.

#### Syntax

```
string Name { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)

#### Example

This Visual Basic sample shows how to call the GetGeometry method.

```
' Example Description: Demonstrates accessing Geometry information of a Design Axis.
' Geometry information Design Plane "X-Axis" is obtained here.

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Axis object
Dim objADDesignAxis As AlibreX.IADDesignAxis

' Get Design Axis from Design Axes collection by Name
Set objADDesignAxis = objADDesignSession.DesignAxes("X-Axis")

' Points to capture geometry information
Dim objADPoint1 As AlibreX.IADPoint
Dim objADPoint2 As AlibreX.IADPoint

' Get Geometry information using GetGeometry() 
Call objADDesignAxis.GetGeometry(objADPoint1, objADPoint2)
```



# IADDesignProperties.VersionComment Property

Gets/sets the Version Comment for the design.

#### Syntax

```
string VersionComment { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADDesignSession.RegenerateDesign Method

Regenerate all the features of the design in this session.

#### Syntax

```
void RegenerateDesign(
	bool deepRegenerate
)
```

#### Parameters

deepRegenerate  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If set to true, constituents will be regenerated as well.



# IADIGESOptions.HasTrimSurfacesAsNURBS Property

If true, this option specifies that all surfaces be converted to NURBs (Non-Uniform
Rational B-Splines) and written as IGES NURBs surfaces (Entity #128).

#### Syntax

```
bool HasTrimSurfacesAsNURBS { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDesignAxis.Hide Method

Hides the design axis.

#### Syntax

```
void Hide()
```



# IADGlobalParameterSession.Configurations Property

Returns the collection of configurations present in this global parameter session.

#### Syntax

```
IADConfigurations Configurations { get; }
```

#### Property Value

IADConfigurations



# IADDesignPoint.Type Property

Returns a pre-defined constant that identifies the type (AD\_DESIGN\_POINT) of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IDecomposedTransformData Interface

IDecomposedTransformData contains properties for querying the components of a transformation
without directly working with the transformation matrix. You can get decomposed transformation
data for any IADTransformation by calling its
Decompose method.

#### Syntax

```
public interface IDecomposedTransformData
```

The IDecomposedTransformData type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | RotateAngle | Returns the rotation angle component in radians about the rotation vector for the decomposed transform. |
|  | RotateVector | Returns the vector around which the rotation component was decomposed for the transform. |
|  | RotateX | Returns the rotation angle component in radians about the X-axis for the decomposed transform. |
|  | RotateY | Returns the rotation angle component in radians about the Y-axis for the decomposed transform. |
|  | RotateZ | Returns the rotation angle component in radians about the Z-axis for the decomposed transform. |
|  | ScaleX | Returns the scale component of the decomposed transform in X direction. |
|  | ScaleY | Returns the scale component of the decomposed transform in Y direction. |
|  | ScaleZ | Returns the scale component of the decomposed transform in Z direction. |
|  | ShearXY | Returns the shearXY component of the decomposed transform. |
|  | ShearYZ | Returns the shearYZ component of the decomposed transform. |
|  | ShearZX | Returns the shearZX component of the decomposed transform. |
|  | TranslateX | Returns the translate component of the decomposed transform in the X direction. |
|  | TranslateY | Returns the translate component of the decomposed transform in the Y direction. |
|  | TranslateZ | Returns the translate component of the decomposed transform in the Z direction. |



# IADDesignSession.CircularFacets Property

Gets the current display setting for the minimal circular facets option of the design.

#### Syntax

```
int CircularFacets { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADDesignPlanes.CreateBy3Points Method

Create a design plane such that it passes through the given three points or vertices.

#### Syntax

```
IADDesignPlane CreateBy3Points(
	IADOccurrence pOccurrence1,
	Object pPnt1,
	IADOccurrence pOccurrence2,
	Object pPnt2,
	IADOccurrence pOccurrence3,
	Object pPnt3,
	string name
)
```

#### Parameters

pOccurrence1  IADOccurrence
:   Denotes an "instance" of a Part or
    Assembly, to which the given pPnt1 belongs to. For
    creating a Plane in a standalone Part, pOccurrence1 should be null.

pPnt1  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The first point or vertex
    which will be used to define the plane.

pOccurrence2  IADOccurrence
:   Denotes an "instance" of a Part or
    Assembly, to which the given pPnt2 belongs to. For
    creating a Plane in a standalone Part, pOccurrence2 should be null.

pPnt2  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The second point or vertex
    which will be used to define the plane.

pOccurrence3  IADOccurrence
:   Denotes an "instance" of a Part or
    Assembly, to which the given pPnt3 belongs to. For
    creating a Plane in a standalone Part, pOccurrence3 should be null.

pPnt3  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The third point or vertex
    which will be used to define the plane.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new design plane. If a null or empty string is passed, Alibre will name the plane.

#### Return Value

IADDesignPlane  
Returns IADDesignPlane

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_GEOMETRY\_CREATION\_FAILURE | Alibre was unable to create valid geometry for the design plane. |
| AD\_E\_INVALID\_POINT | The input points may not be null. |
| AD\_E\_COLLINEAR\_POINTS | All three points cannot be collinear when defining a plane. |

#### Remarks

Note that the newly created Plane object is not added to the Collection on which this
method is called. Query for the Collection again to get the updated Collection

#### Example

This Visual Basic sample demonstrates creating a Design Plane by three design points. A Design Plane that is equally oriented to the three default Design Planes is created here. The new Design Plane is named "NewPlaneBy3Points".

```
' Holds Design Session object
Dim objADDesignSession As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Point 1
Dim objADDesignPoint1 As AlibreX.IADDesignPoint

' Holds Design Point 2
Dim objADDesignPoint2 As AlibreX.IADDesignPoint

' Holds Design Point 3
Dim objADDesignPoint3 As AlibreX.IADDesignPoint

' Create first Design Point at one unit (1 cm) distance along X-Axis.
Set objADDesignPoint1 = objADDesignSession.DesignPoints.CreatePoint(1, 0, 0)

' Create second Design Point at one unit (1 cm) distance along Y-Axis.
Set objADDesignPoint2 = objADDesignSession.DesignPoints.CreatePoint(0, 1, 0)

' Create third Design Point at one unit (1 cm) distance along Z-Axis.
Set objADDesignPoint3 = objADDesignSession.DesignPoints.CreatePoint(0, 0, 1)

' Holds the new Design Plane
Dim objADNewDesignPlane As AlibreX.IADDesignPlane

' Holds Design Planes collection object
Dim objADDesignPlanes As AlibreX.IADDesignPlanes

' Get Design Planes collection from Design Session
Set objADDesignPlanes = objADDesignSession.DesignPlanes

' Create a Design Plane using the above three Design Points.  Since all
' Design Points are belonging to the current Part, Occurances Values
' are passed as Nothing.
Set objADNewDesignPlane = objADDesignPlanes.CreateBy3Points( _
            Nothing, objADDesignPoint1, _
            Nothing, objADDesignPoint2, _
            Nothing, objADDesignPoint3, _
            "NewPlaneBy3Points")
```



# IADDesignSession.ExportAP203 Method

Exports the design session as ISO AP203 STEP file.

#### Syntax

```
void ExportAP203(
	string fileName
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the exported file.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_INVALID\_LICENSE\_KEY | The license for this installation of Alibre Design does not permit exporting this design as a STEP file. |



# IDecomposedTransformData.TranslateY Property

Returns the translate component of the decomposed transform in the Y direction.

#### Syntax

```
double TranslateY { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADDesignSession.IsPerspective Property

Returns true if the current display of the design is in perspective view mode,
rather than orthogonal.

#### Syntax

```
bool IsPerspective { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADGlobalParameterSession Interface

IADGlobalParameterSession interface represents an instance of a Global
Parameters workspace.

#### Syntax

```
public interface IADGlobalParameterSession : IADSession
```

The IADGlobalParameterSession type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ActiveConfiguration | Gets/sets the active configuration for this global parameter session. |
|  | Configurations | Returns the collection of configurations present in this global parameter session. |
|  | ConstituentFilePaths | Returns file path strings for other Design files that are referenced by this session.  (Inherited from IADSession) |
|  | FilePath | Returns the location on disk of where the file was last saved. If unsaved, returns null.  (Inherited from IADSession) |
|  | GeometryFactory | Returns the Geometry Factory.  (Inherited from IADSession) |
|  | Identifier | Returns the session's unique identifier.  (Inherited from IADSession) |
|  | IsGUIVisible | Returns True if the GUI for this session is visible.  (Inherited from IADSession) |
|  | Name | Returns this session's name.  (Inherited from IADSession) |
|  | Parameters | Returns a collection of parameters for this session.  (Inherited from IADSession) |
|  | PreviewSnapshot | Returns a OLE picture object containing the preview snapshot bitmap for the session.  (Inherited from IADSession) |
|  | Root | Returns the automation root.  (Inherited from IADSession) |
|  | SelectedObjects | Returns all selected entities in the session's browser as a collection of target proxies.  (Inherited from IADSession) |
|  | SessionType | Returns a pre-defined constant that identifies whether this session is a part or assembly or drawing session.  (Inherited from IADSession) |
|  | TimeStamp | Returns time stamp of this session; the time stamp changes when changes are saved to the session.  (Inherited from IADSession) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SESSION)  (Inherited from IADSession) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | BindKeyToItem | Given a Persistent Key, returns the corresponding Occurrence/Topology element/Sketch.  (Inherited from IADSession) |
|  | Close | Closes the session and optionally saves before closing.  (Inherited from IADSession) |
|  | CreatePackage | (Inherited from IADSession) |
|  | Highlight | Highlights the object in the canvas.  (Inherited from IADSession) |
|  | NewTargetProxy | Creates a new TargetProxy for the given target and the occurrence  (Inherited from IADSession) |
|  | Save | Saves modified session and sub-sessions, if any, to their original folder locations.  (Inherited from IADSession) |
|  | SaveAll | Saves a copy of the session and all sub-sessions to the directory indicated by the destination parameter.  (Inherited from IADSession) |
|  | SaveAs | Saves the session to create a new copy with the given name.  (Inherited from IADSession) |
|  | SaveCurrentViewSnapshot | Saves the snapshot of the graphic canvas for current view in the session, at the given location and of the given size.  (Inherited from IADSession) |
|  | SaveNew | Saves a new, unsaved session to the specified folder location.  (Inherited from IADSession) |
|  | Select | Selects all objects passed in pEntities.  (Inherited from IADSession) |
|  | SelectedObjectsEx | Returns all selected entities in the session's browser as a collection of target proxies, and sets the parameter lastSelectedPoint to last point in the user clicked to make the selection.  (Inherited from IADSession) |
|  | UpdatePreviewSnaphot | Captures the canvas image displayed for this session and silently saves it as the file snapshot property  (Inherited from IADSession) |



# IADDesignSession.DesignAxes Property

Returns a collection of design axes for this session.

#### Syntax

```
IADDesignAxes DesignAxes { get; }
```

#### Property Value

IADDesignAxes



# IADDesignMeshes.Item Method

Given a name or numerical index into the collection, returns the corresponding design mesh.

#### Syntax

```
IADDesignMesh Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or numerical index of the mesh.

#### Return Value

IADDesignMesh  
Returns IADDesignMesh

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INDEX\_OUT\_OF\_BOUNDS | The specified index is outside of the bounds of the collection. |
| AD\_E\_OBJECT\_NOT\_FOUND\_AT\_INDEX | No object exists at the specified index. |
| AD\_E\_VARIANT\_TYPE\_UNSUPPORTED | The index parameter should be an int or a string. |



# IADDesignSession.SavedViews Property

Gets all the saved views for this session.

#### Syntax

```
IADSavedViews SavedViews { get; }
```

#### Property Value

IADSavedViews



# IADDesignAxis Properties

The IADDesignAxis type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | AxisType | Returns a pre-defined constant that identifies how this design geometry was created. |
|  | Direction | Returns the direction of the axis. |
|  | Name | Gets/sets this design axis's name. |
|  | Parameters | Get a collection object containing IADParameter objects associated with this design geometry. |
|  | Root | Returns the automation root. |
|  | Session | Returns the design session for the design axis. |
|  | SourceObjects | The source objects collection represents the objects used to create the Design Axis. This property returns a collection of IADTargetProxy objects. The IADTargetProxy object wraps the dependent object, and also its occurrence if the object belongs to an assembly. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. |



# IADDesignMeshes.GetEnumerator Method

Returns an enumerator for the collection.

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADPartSession.GetBodiesForConfiguration Method

Returns the collection of bodies for a specific configuration of this part.

#### Syntax

```
IADBodies GetBodiesForConfiguration(
	IADConfiguration pConfiguration
)
```

#### Parameters

pConfiguration  IADConfiguration
:   The configuration of the part to get the bodies for.

#### Return Value

IADBodies



# IADBodies.Session Property

Returns the part session for the collection.

#### Syntax

```
IADPartSession Session { get; }
```

#### Property Value

IADPartSession



# IADDesignPlanes.CreateAtOffsetToPlane Method

Create design plane at an offset to the given existing plane or planar face.

#### Syntax

```
IADDesignPlane CreateAtOffsetToPlane(
	IADOccurrence pOcc,
	Object pPlaneObject,
	Object Offset,
	string name
)
```

#### Parameters

pOcc  IADOccurrence
:   Denotes an "instance" of a Part or
    Assembly, to which the given pPlaneObject belongs to.
    For creating a Plane in a standalone Part, pOcc should be null.

pPlaneObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   A plane or planar
    face used to define the new design plane.

Offset  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Offset distance to pPlaneObject. This can be a variant representing
    a double or a parameter value. This value can be negative.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new design plane. If a null or empty string is passed,
    Alibre will name the plane.

#### Return Value

IADDesignPlane  
Returns IADDesignPlane

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_GEOMETRY\_CREATION\_FAILURE | Alibre was unable to create valid geometry for the design plane. |
| AD\_E\_CURVED\_FACE | If using a face for pPlaneObject it must be planar. |
| AD\_E\_INVALID\_PLANE | pPlaneObject was not a valid plane. |
| AD\_E\_VARIANT\_TYPE\_UNSUPPORTED | pPlaneObject must be an IADDesignPlane or IADFace. Offset must be either an IADParameter or double value. |

#### Remarks

Note that the newly created Plane object is not added to the Collection on which this
method is called. Query for the Collection again to get the updated Collection.

#### Example

This Visual Basic sample demonstrates creating a Design Plane at an offset to a plane. A Design Plane that is offset by 10 cm to "XY-Plane" is created here. The new Design Plane is named "NewPlaneAtOffsetToPlane".

```
' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Planes collection object
Dim objADDesignPlanes As AlibreX.IADDesignPlanes

' Get Design Planes collection from Design Session
Set objADDesignPlanes = objADDesignSession.DesignPlanes

' Holds a Design Plane
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Get "XY-Plane" Design Plane from Design Planes collection
Set objADDesignPlane = objADDesignPlanes.Item("XY-Plane")

' Holds New Design Plane object
Dim objADNewDesignPlane As AlibreX.IADDesignPlane

' Create a Design Plane using CreateAtOffsetToPlane method.
Set objADNewDesignPlane = objADDesignPlanes.CreateAtOffsetToPlane( _
Nothing, objADDesignPlane, 10, "NewPlaneAtOffsetToPlane")
```



# IADDesignProperties.LengthDisplayUnits Property

Gets the unit of measurement for displaying lengths in the workspace.

#### Syntax

```
ADUnits LengthDisplayUnits { get; }
```

#### Property Value

ADUnits



# IADDesignPoint Properties

The IADDesignPoint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Geometry | Returns the point's definition. |
|  | Name | Gets/sets this design point's name. |
|  | Parameters | Get a collection object containing IADParameter objects associated with this design geometry. |
|  | PointType | Returns a pre-defined constant that identifies how this design geometry was created. |
|  | Root | Returns the automation root. |
|  | Session | Returns the design session for the design point. |
|  | SourceObjects | The source objects collection represents the objects used to create the Design Point. This property returns a collection of IADTargetProxy objects. The IADTargetProxy object wraps the dependent object, and also its occurrence if the object belongs to an assembly. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_DESIGN\_POINT) of this object. |



# IADDesignSession.preparePrintabilityChecking Method

Prepares printability meshes. This is only for Alibre Test Bed.

#### Syntax

```
bool preparePrintabilityChecking()
```

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDesignSession.ExportSAT Method

Exports the design session as an ACIS SAT file.

#### Syntax

```
void ExportSAT(
	string fileName,
	int version
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the exported file.

version  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The ACIS version to use for the exported SAT file.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_INVALID\_LICENSE\_KEY | The license for this installation of Alibre Design does not permit exporting SAT files. |

#### Remarks

V11 of Alibre Design is using R18 of ACIS. For the version parameter, only
the values 18, 17, 16, 15, 14, 13, 10, 7, and 5 are supported.



# IADDesignSurfaces Methods

The IADDesignSurfaces type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | InsertFromFile | Insert Surface(s) from the given file. |
|  | Item | Given a name or numerical index into the collection, returns the corresponding design surface. |



# IADConfigurations.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADDesignSession.ExportBIP Method

#### Overload List

|  | Name | Description |
| --- | --- | --- |
|  | ExportBIP(String) |  |
|  | ExportBIP(String, String) |  |



# IADPartSession.FeatureCount Property

Returns the features count.

#### Syntax

```
int FeatureCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADDesignPlanes Interface

IADDesignPlanes represents the interface for a Collection of Planes in the Design.

#### Syntax

```
public interface IADDesignPlanes
```

The IADDesignPlanes type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of design planes in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the design session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateAtAngleToPlane | Creates a design plane at an angle to an existing plane/face and passing through an axis/edge. |
|  | CreateAtOffsetToPlane | Create design plane at an offset to the given existing plane or planar face. |
|  | CreateBy3Points | Create a design plane such that it passes through the given three points or vertices. |
|  | Item | Given a name or numerical index into the collection, returns the corresponding design plane. |

#### Remarks

- The Planes collection is obtained by querying for the property DesignPlanes
  on IADDesignSession. This gives a collection of all the Design
  Planes existing in the Design.
- Three built-in objects to represent XY-Plane, YZ-Plane, and ZX-Plane are provided.
  These three objects will be the first three items in the Planes collection.
- It is possible to create a new Plane.
  Following are three different ways provided to create a new Plane:
  - At an Angle to a given existing Plane (
    CreateAtAngleToPlane)
  - At an Offset to a given Plane (
    CreateAtOffsetToPlane)
  - Using three 3 Points (CreateBy3Points)



# IADDesignPoints.CreatePointFromToroidalFace Method

Creates a design point at the center of a toroidal face.

#### Syntax

```
IADDesignPoint CreatePointFromToroidalFace(
	IADOccurrence pOccurrence,
	IADFace pFace,
	string name
)
```

#### Parameters

pOccurrence  IADOccurrence
:   Denotes an "instance" of a Part or
    Assembly, to which the given pEdge belongs to. For
    creating a Point in a standalone Part, pOccurrence should be null.

pFace  IADFace
:   A toroidal face whose center point is used to define
    the new design point.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new design point. If a null or empty string is passed,
    Alibre will name the point.

#### Return Value

IADDesignPoint  
Returns the new IADDesignPoint.

#### Remarks

Note that the newly created Point object is not added to the Collection on which this
method is called. Query for the Collection again to get the updated Collection.



# IADDesignPoint.Session Property

Returns the design session for the design point.

#### Syntax

```
IADDesignSession Session { get; }
```

#### Property Value

IADDesignSession



# IADDesignPoints.CreatePoint Method

Creates a design point given X, Y and Z coordinates.

#### Syntax

```
IADDesignPoint CreatePoint(
	double XCoord,
	double YCoord,
	double ZCoord,
	string name
)
```

#### Parameters

XCoord  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X Coordinate for the new point.

YCoord  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y Coordinate for the new point.

ZCoord  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Z Coordinate for the new point.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new design point. If a null or empty string is passed,
    Alibre will name the point.

#### Return Value

IADDesignPoint  
Returns the new IADDesignPoint.

#### Example

This Visual Basic sample shows how to call the CreatePoint method.

```
' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Points
Dim objADDesignPoints As AlibreX.IADDesignPoints

' Get Design Points Collection from Design Session
Set objADDesignPoints = objADDesignSession.DesignPoints

' Holds Design Point
Dim objADDesignPoint As AlibreX.IADDesignPoint

' Create Design Point at (1, 1, 1)
Set objADDesignPoint = objADDesignPoints.CreatePoint(1, 1, 1, "NewDesignPoint")
```



# IADDesignMeshes.Session Property

Returns the design session for the collection.

#### Syntax

```
IADDesignSession Session { get; }
```

#### Property Value

IADDesignSession



# IADDesignSession.PrintabilityCheckResults Method

Returns the printability check results of this design

#### Syntax

```
IADPrintabilityCheckResults PrintabilityCheckResults()
```

#### Return Value

IADPrintabilityCheckResults



# IADDesignSurface.Session Property

Returns the part session for the design surface.

#### Syntax

```
IADPartSession Session { get; }
```

#### Property Value

IADPartSession



# IADPartSession.ShowFeatureColor Property

Returns whether the feature color is shown for this design or not.

#### Syntax

```
bool ShowFeatureColor { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDesignSelectionFilter.Redlines Property

If true, redlines are selectable.

#### Syntax

```
bool Redlines { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDesignProperties.ExtendedDesignProperty(ADExtendedDesignProperty) Method

Returns the design property for the input property identifier.

#### Syntax

```
Object ExtendedDesignProperty(
	ADExtendedDesignProperty propertyID
)
```

#### Parameters

propertyID  ADExtendedDesignProperty
:   The identifier for the design property to get.

#### Return Value

[Object](https://learn.microsoft.com/dotnet/api/system.object)  
Returns an object containing a string or a null value if there
was value for the given propertyID.



# IADPartSession.GetMeshData Method

Returns index-based triangular mesh data.

#### Syntax

```
void GetMeshData(
	IADConfiguration pConfiguration,
	out Array faceData,
	out Array vertexData
)
```

#### Parameters

pConfiguration  IADConfiguration
:   This configuration will be used to generate the mesh.

faceData  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   The faceData array contains zero-based indices for facets in the mesh.

vertexData  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   vertexData contains (x,y,z) co-ordinates for triplets of points.

#### Remarks

The x co-ordinate of i th point is at [3\*faceData[i]] position in vertex array.



# IADConfigurations Properties

The IADConfigurations type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Gets the count of configurations in this collection. |
|  | Enum | Returns an enumerator for the collection. |



# IADDesignAxis.Type Property

Returns a pre-defined constant that identifies the type of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADDesignSession.StartChanges Method

#### Syntax

```
void StartChanges()
```



# IADPartSession.Features Property

Returns the collection of features in this part.

#### Syntax

```
IADPartFeatures Features { get; }
```

#### Property Value

IADPartFeatures



# IADGlobalParameterSession Methods

The IADGlobalParameterSession type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | BindKeyToItem | Given a Persistent Key, returns the corresponding Occurrence/Topology element/Sketch.  (Inherited from IADSession) |
|  | Close | Closes the session and optionally saves before closing.  (Inherited from IADSession) |
|  | CreatePackage | (Inherited from IADSession) |
|  | Highlight | Highlights the object in the canvas.  (Inherited from IADSession) |
|  | NewTargetProxy | Creates a new TargetProxy for the given target and the occurrence  (Inherited from IADSession) |
|  | Save | Saves modified session and sub-sessions, if any, to their original folder locations.  (Inherited from IADSession) |
|  | SaveAll | Saves a copy of the session and all sub-sessions to the directory indicated by the destination parameter.  (Inherited from IADSession) |
|  | SaveAs | Saves the session to create a new copy with the given name.  (Inherited from IADSession) |
|  | SaveCurrentViewSnapshot | Saves the snapshot of the graphic canvas for current view in the session, at the given location and of the given size.  (Inherited from IADSession) |
|  | SaveNew | Saves a new, unsaved session to the specified folder location.  (Inherited from IADSession) |
|  | Select | Selects all objects passed in pEntities.  (Inherited from IADSession) |
|  | SelectedObjectsEx | Returns all selected entities in the session's browser as a collection of target proxies, and sets the parameter lastSelectedPoint to last point in the user clicked to make the selection.  (Inherited from IADSession) |
|  | UpdatePreviewSnaphot | Captures the canvas image displayed for this session and silently saves it as the file snapshot property  (Inherited from IADSession) |



# IADDesignSession.ExportSAT2 Method

Exports the design as an ACIS SAT file.

#### Syntax

```
void ExportSAT2(
	string fileName,
	int version,
	bool saveColorAttribute
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the exported file.

version  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The ACIS version to use for the exported SAT file.

saveColorAttribute  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, the colors of the design will be preserved in the
    SAT file.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_INVALID\_LICENSE\_KEY | The license for this installation of Alibre Design does not permit exporting SAT files. |

#### Remarks

V11 of Alibre Design is using R18 of ACIS. For the version parameter, only
the values 18, 17, 16, 15, 14, 13, 10, 7, and 5 are supported.



# IADDesignPoints.Item Method

Given a name or numerical index into the collection, returns the corresponding design point.

#### Syntax

```
IADDesignPoint Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or numerical index of the design point.

#### Return Value

IADDesignPoint  
Returns IADDesignPoint



# IADDesignSurface.Name Property

Gets/sets the name of this design surface.

#### Syntax

```
string Name { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADDesignAxis.SourceObjects Property

The source objects collection represents the objects used to create the Design Axis. This
property returns a collection of IADTargetProxy objects.
The IADTargetProxy object wraps the dependent object, and
also its occurrence if the object belongs to an
assembly.

#### Syntax

```
IObjectCollector SourceObjects { get; }
```

#### Property Value

IObjectCollector

#### Remarks

This method will return null if the Axis is a Primary Design Axis.

#### Example

This Visual Basic sample iterates through all the source objects used for creating Axes in the design. And, prints the name of the occurrence as well as Type of the target.

```
Dim objAxes As AlibreX.IADDesignAxes
Dim objAxis As AlibreX.IADDesignAxis
Dim objTargetProxy As AlibreX.IADTargetProxy
Dim objSourceObjects As AlibreX.IObjectCollector
Dim occurrenceName As String
Dim targetType As Integer

Set objAxes = m_objAlibreDesignSession.DesignAxes
For Each objAxis In objAxes
    Set objSourceObjects = objAxis.SourceObjects
    If Not objSourceObjects Is Nothing Then
        occurrenceName = ""
        For Each objTargetProxy In objSourceObjects
            If Not objTargetProxy.Occurrence Is Nothing Then
                occurrenceName = objTargetProxy.Occurrence.Name
            End If

            targetType = objTargetProxy.Target.Type

            MsgBox occurrenceName & " <" & targetType & ">"
        Next
    End If
Next
```



# IADDesignSurfaces Interface

IADDesignSurfaces is the interface for a collection of Surfaces in the Part workspace.

#### Syntax

```
public interface IADDesignSurfaces
```

The IADDesignSurfaces type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of design surface in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the part session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | InsertFromFile | Insert Surface(s) from the given file. |
|  | Item | Given a name or numerical index into the collection, returns the corresponding design surface. |

#### Remarks

- The Surfaces collection is obtained by querying the property
  DesignSurfaces on IADPartSession. This gives
  a collection of all the Surfaces existing in the Design.
- A new Surface can be inserted
  from a given file by making a call to
  InsertFromFile.



# IADDesignSurface.Vertices Property

Get all the vertices in this surface

#### Syntax

```
IADVertices Vertices { get; }
```

#### Property Value

IADVertices



# IADDesignMeshes.CreateFromFile Method

#### Syntax

```
IObjectCollector CreateFromFile(
	string fileName,
	string meshName,
	ADUnits adUnits
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)

meshName  [String](https://learn.microsoft.com/dotnet/api/system.string)

adUnits  ADUnits

#### Return Value

IObjectCollector



# IADDesignSession.ExportBIP(String) Method

#### Syntax

```
void ExportBIP(
	string fileName
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)



# IADDesignSession.AutoRegenerate Property

Determines whether the DesignSession will be automatically regenerated after a change.

#### Syntax

```
bool AutoRegenerate { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADBodies Methods

The IADBodies type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding body. |



# IADDesignPoints.CreateAtOffsetToPoint Method

Creates a new design point at a given offset distance from another point/vertex

#### Syntax

```
IADDesignPoint CreateAtOffsetToPoint(
	IADOccurrence pOccurrence,
	Object pPoint,
	Object XOffset,
	Object YOffset,
	Object ZOffset,
	string name
)
```

#### Parameters

pOccurrence  IADOccurrence
:   Denotes an "instance" of a Part or Assembly to which the given
    pPoint belongs to. For creating a new point in a standalone Part, pOccurrence
    should be null.

pPoint  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Input point or vertex
    to which the given offsets will be applied.

XOffset  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The X component for the offset. Can be a number or a string denoting an equation

YOffset  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The Y component for the offset. Can be a number or a string denoting an equation

ZOffset  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The Z component for the offset. Can be a number or a string denoting an equation

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new design point. If a null or empty string is passed,
    Alibre will name the point.

#### Return Value

IADDesignPoint  
Returns the new IADDesignPoint.



# IDecomposedTransformData.ShearXY Property

Returns the shearXY component of the decomposed transform.

#### Syntax

```
double ShearXY { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADDesignSession.AutoBrepImportSummary Property

#### Syntax

```
IADAutoBrepImportSummary AutoBrepImportSummary { get; }
```

#### Property Value

IADAutoBrepImportSummary



# IADDesignProperties.AngleDisplayUnits Property

Gets the unit of measurement for displaying angles in the workspace.

#### Syntax

```
ADUnits AngleDisplayUnits { get; }
```

#### Property Value

ADUnits



# IADDesignProperties.ExtendedDesignProperty Method

#### Overload List

|  | Name | Description |
| --- | --- | --- |
|  | ExtendedDesignProperty(ADExtendedDesignProperty) | Returns the design property for the input property identifier. |
|  | ExtendedDesignProperty(ADExtendedDesignProperty, Object) | Sets the design property for the input property identifier. |



# IADConfiguration.Type Property

Returns a pre-defined constant that identifies the type (AD\_CONFIGURATION) of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType

#### Example

This Visual Basic sample shows how to get the Type property.

```
' Holds Session object
Dim objSession as IADSession 

' Open an existing part using OpenFile() on Root object. Note: User may set it to any required file and location
Set objADSession = m_objADRoot.OpenFile("C://Part.AD_PRT")

' Holds Alibre Design Session object
Dim objDesignSession As IADDesignSession 

'Assign objADSession to objDesignSession 
Set objDesignSession = objADSession

'Holds all configurations in a design session
Dim objConfigs As IADConfigurations

'set the configurations in the design session
Set objConfigs = DesignSession.Configurations

'Holds a configuration in a design session
Dim objConfig As IADConfigurations

'Set the first configuration to objConfig  
Set objConfig = objConfigs.Item(0)

'Get the object Type for the first configuration
MsgBox ("First configuration is of Object Type: " & objConfig.Type)
```



# IADDesignAxes Properties

The IADDesignAxes type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of design axes in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the design session for the collection. |



# IADDesignMesh Properties

The IADDesignMesh type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | IsSurfaced | Returns true if surfacing of the DesignMesh is complete. |
|  | Name | Gets/sets this design mesh's name. |
|  | Root | Returns the automation root. |
|  | Session | Returns the design session for the design plane. |
|  | TriangleCount | Returns true if surfacing of the DesignMesh is complete. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_DESIGN\_PLANE) of this object. |



# IADDesignAxis.Direction Property

Returns the direction of the axis.

#### Syntax

```
IADVector Direction { get; }
```

#### Property Value

IADVector



# IADDesignProperties.CustomProperty(String) Method

Returns the custom property for the input custom property name (applies to file based custom properties only)

#### Syntax

```
Object CustomProperty(
	string propertyName
)
```

#### Parameters

propertyName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name for the custom property to get.

#### Return Value

[Object](https://learn.microsoft.com/dotnet/api/system.object)  
Returns an object containing a string or a null value if there
was value for the given propertyName.



# IADConfigurations Methods

The IADConfigurations type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddConfiguration | Adds a new configuration to the design. |
|  | Item | Given a configuration's name or index, returns the corresponding configuration. |



# IADDesignSession.ExportSTEP Method

Exports the design session as a Alibre STEP file.

#### Syntax

```
void ExportSTEP(
	string fileName
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the exported file.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_INVALID\_LICENSE\_KEY | The license for this installation of Alibre Design does not permit exporting this design as a STEP file. |



# IADDesignSession.Configurations Property

Returns the collection of configurations present in this design session.

#### Syntax

```
IADConfigurations Configurations { get; }
```

#### Property Value

IADConfigurations

#### Example

Please refer to the example in IADDesignSession.ActiveConfiguration



# IADPartSession Interface

IADPartSession interface

#### Syntax

```
public interface IADPartSession : IADDesignSession, 
	IADSession
```

The IADPartSession type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ActiveConfiguration | Gets/sets the active configuration for this design session.  (Inherited from IADDesignSession) |
|  | AutoBrepImportSummary | (Inherited from IADDesignSession) |
|  | AutoRegenerate | Determines whether the DesignSession will be automatically regenerated after a change.  (Inherited from IADDesignSession) |
|  | Bodies | The collection of bodies in this part. |
|  | CameraPosition | Returns an IADPoint with the current location of the camera in this design session.  (Inherited from IADDesignSession) |
|  | CircularFacets | Gets the current display setting for the minimal circular facets option of the design.  (Inherited from IADDesignSession) |
|  | Color | The part's color. |
|  | Configurations | Returns the collection of configurations present in this design session.  (Inherited from IADDesignSession) |
|  | ConstituentFilePaths | Returns file path strings for other Design files that are referenced by this session.  (Inherited from IADSession) |
|  | DesignAxes | Returns a collection of design axes for this session.  (Inherited from IADDesignSession) |
|  | DesignMeshes | Returns a collection of design meshes for this session.  (Inherited from IADDesignSession) |
|  | DesignPlanes | Returns a collection of design planes for this session.  (Inherited from IADDesignSession) |
|  | DesignPoints | Returns a collection of design points for this session.  (Inherited from IADDesignSession) |
|  | DesignProperties | Returns the design properties of the design.  (Inherited from IADDesignSession) |
|  | DesignSurfaces | The collection of surfaces in this part. |
|  | EdgeColor | The edge color of the part, as a BGR int. |
|  | FacetData | Returns the triangular mesh data for the active configuration. |
|  | FeatureCount | Returns the features count. |
|  | Features | Returns the collection of features in this part. |
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
|  | Reflectivity | The part's reflectivity |
|  | Root | Returns the automation root.  (Inherited from IADSession) |
|  | SavedViews | Gets all the saved views for this session.  (Inherited from IADDesignSession) |
|  | SectionBody | Returns the section body in this design. |
|  | SelectedObjects | Returns all selected entities in the session's browser as a collection of target proxies.  (Inherited from IADSession) |
|  | SelectionFilter | Gets the interface to this design session's selection filter. The interface's properties can be queried to find the current settings or set to change the active selection filters.  (Inherited from IADDesignSession) |
|  | SessionType | Returns a pre-defined constant that identifies whether this session is a part or assembly or drawing session.  (Inherited from IADSession) |
|  | ShowFeatureColor | Returns whether the feature color is shown for this design or not. |
|  | Sketches | Returns the collection of sketches for this design. |
|  | Sketches3D | The collection of 3D sketches for this design. |
|  | TimeStamp | Returns time stamp of this session; the time stamp changes when changes are saved to the session.  (Inherited from IADSession) |
|  | Transparency | The part's transparency. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SESSION)  (Inherited from IADSession) |
|  | ViewTransform | Returns view transformation of this design session.  (Inherited from IADDesignSession) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | BindKeyToItem | Given a Persistent Key, returns the corresponding Occurrence/Topology element/Sketch.  (Inherited from IADSession) |
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
|  | FacetDataForConfiguration | Returns triangular mesh data for the specified Configuration. |
|  | GetBodiesForConfiguration | Returns the collection of bodies for a specific configuration of this part. |
|  | GetMeshData | Returns index-based triangular mesh data. |
|  | GetMeshDataEx | Returns index-based triangular mesh data, including normals. |
|  | GetMeshDefinition | Returns definition of index-based triangular mesh data. and pVertexDataSize returns |
|  | GetMeshDefinitionEx | Returns definition of index-based triangular mesh data, including normals. |
|  | Highlight | Highlights the object in the canvas.  (Inherited from IADSession) |
|  | NewTargetProxy | Creates a new TargetProxy for the given target and the occurrence  (Inherited from IADSession) |
|  | PhysicalProperties | Returns the physical properties of this design. These properties include Number of faces, Number of edges, Number of vertices, Volume, Mass, Center of mass, etc.  (Inherited from IADDesignSession) |
|  | postProcessPrintabilityChecking | Postprocess of printability checking (Clear body member cache.)  (Inherited from IADDesignSession) |
|  | preparePrintabilityChecking | Prepares printability meshes. This is only for Alibre Test Bed.  (Inherited from IADDesignSession) |
|  | PrintabilityCheckResults | Returns the printability check results of this design  (Inherited from IADDesignSession) |
|  | RegenerateAll | Regenerate all features. |
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
|  | Suppress | Suppress all the states in the given collection. |
|  | Unsuppress | Unsuppress all the states in the given collection. |
|  | UnSuppressAll | Unsuppress all features. |
|  | UpdatePreviewSnaphot | Captures the canvas image displayed for this session and silently saves it as the file snapshot property  (Inherited from IADSession) |
|  | ViewExtents | Returns view extents of this design session, in screen coordinates.  (Inherited from IADDesignSession) |



# IADIGESOptions Properties

The IADIGESOptions type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EOLLength | Gets/sets the length of the end-of-line character (in bytes). Value must be between 1 through 4. |
|  | HasBoundedSurfaces | If true, Alibre will write all surfaces as bounded when exporting IGES files. Otherwise, surfaces are written as trimmed whenever possible. |
|  | HasEllipsesAsNURBS | If true, Alibre will write ellipses as NURBs curves when exporting IGES files. This compensates for programs that do not support conic arcs. IGES uses conic arcs to write ACIS ellipses. |
|  | HasTrimmedCurves | If true, Alibre will write trimmed curves as 2D parametric curves with the trimmed curve preference for 2D data when exporting IGES files. Required when writing IGES files for CATIA. |
|  | HasTrimSurfacesAsNURBS | If true, this option specifies that all surfaces be converted to NURBs (Non-Uniform Rational B-Splines) and written as IGES NURBs surfaces (Entity #128). |
|  | HasWireAsCopiousData | Set this option to true to write a wire as copious data (entity #106, form 12). Otherwise, separate curves are written for the wire. |
|  | IsAutoCAD | If true, IGES files will be exported with faces specifically for use with AutoCAD. |
|  | IsJAMA | If true, the JAMA-IS v1.04 Specification, a subset of the IGES V5.0 specification, will be used to export IGES files. Setting this to true accepts the JAMA convention of not supporting some constraints. |
|  | IsMSBO | If true, parts will be exported as MSBOs (Manifold Solid B-rep Objects). Otherwise these parts are exported as trimmed faces, but without connectivity information for IGES Version 4.0 compatibility. |
|  | Units | Gets/sets the units used when exporting IGES files. |



# IADDesignPlane.Root Property

Returns the automation root.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot

#### Example

This Visual Basic sample shows how to get the Root property.

```
Dim objAlibreRoot As.IADRoot
Set objAlibreRoot = objAlibreDesignPlane.Root
```



# IADDesignPoints.CreateOnEdge Method

Creates a new design point on a given edge at a set ratio from its start point

#### Syntax

```
IADDesignPoint CreateOnEdge(
	IADOccurrence pOccurrence,
	IADEdge pEdge,
	double ratio,
	string name
)
```

#### Parameters

pOccurrence  IADOccurrence
:   Denotes an "instance" of a Part or Assembly to which the given
    pPoint belongs to. For creating a new point in a standalone Part, pOccurrence
    should be null.

pEdge  IADEdge
:   Input edge on which a new point will be created
    at a set ratio of its length from its starting point.

ratio  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The ratio of the length of input edge.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new design point. If a null or empty string is passed,
    Alibre will name the point.

#### Return Value

IADDesignPoint  
Returns the new IADDesignPoint.



# IADDesignSelectionFilter.Annotations Property

If true, annotations are selectable.

#### Syntax

```
bool Annotations { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDesignAxes.Count Property

Returns the number of design axes in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IDecomposedTransformData.RotateZ Property

Returns the rotation angle component in radians about the Z-axis for the decomposed transform.

#### Syntax

```
double RotateZ { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADDesignPoints.CreateBy2Axes Method

Creates a design point at the intersection of an axis/edge and another axis/edge

#### Syntax

```
IADDesignPoint CreateBy2Axes(
	IADOccurrence pOccurrence1,
	Object pAxis1,
	IADOccurrence pOccurrence2,
	Object pAxis2,
	string name
)
```

#### Parameters

pOccurrence1  IADOccurrence
:   Denotes an "instance" of a Part or Assembly to which the given
    pAxis1 belongs to. For creating a point in a standalone Part, pOccurrence1
    should be null.

pAxis1  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   First axis or linear edge
    which will be used to define the point.

pOccurrence2  IADOccurrence
:   Denotes an "instance" of a Part or Assembly to which the given
    pAxis2 belongs to. For creating a point in a standalone Part, pOccurrence2
    should be null.

pAxis2  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Second axis or linear edge
    which will be used to define the point.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new design point. If a null or empty string is passed,
    Alibre will name the point.

#### Return Value

IADDesignPoint  
An interface to the new design point.



# IADDesignSession.ExportBOM Method

Export the bill of materials as a .csv file at the specified path.

#### Syntax

```
void ExportBOM(
	string fileName
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the exported file.

#### Remarks

This is an obsolete method. Use the ExportBOM method on the IADBOMTableSession interface instead.



# IADBodies Interface

This collection is needed for querying the model held by the design.
This interface represents the collection of all the bodies held by the design.
However, as per current architecture, the design holds only one solid body
and hence this collection has only a single IADBody.

#### Syntax

```
public interface IADBodies
```

The IADBodies type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of bodies in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the part session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding body. |

#### Remarks

This collection of bodies is obtained by querying the property Bodies
on IADPartSession interface object. It is not possible to alter or delete the
body, and only query methods are supported on it.

#### Example

This Visual Basic sample demonstrates topology queries.

```
' Example Description: Demonstrates topology queries

' Holds File Path
Dim strFilePath As String

' Set file path. Note: To be updated by the user
strFilePath = "\\Alibre\Examples\API_Kettle.AD_PRT"    

' Open Alibre Design File
Set m_objADSession = m_objADRoot.OpenFile(strFilePath)

' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session object from existing session

Set objADPartSession = m_objADSession

' Holds Body object
Dim objADBody As AlibreX.IADBody

' Query for Bodies collection on Part Session
If objADPartSession.Bodies.Count > 0 Then
    ' Get Body object from Part Session
    ' (Current Alibre Design implementation will have only one Body item with index zero)
    Set objADBody = objADPartSession.Bodies(0)
End If

' Print indicative topology element properties exposed by Body Object

Debug.Print "Topology Data From Body Object: "
Debug.Print vbTab & "Body.TopologyType = " & objADBody.TopologyType
Debug.Print vbTab & "Body.Type = " & objADBody.Type
Debug.Print vbTab & "Body.Lumps.Count = " & objADBody.Lumps.Count
Debug.Print vbTab & "Body.Shells.Count = " & objADBody.Shells.Count
Debug.Print vbTab & "Body.Faces.Count = " & objADBody.Faces.Count
Debug.Print vbTab & "Body.Edges.Count = " & objADBody.Edges.Count
Debug.Print vbTab & "Body.Vertices.Count = " & objADBody.Vertices.Count

' Holds Lump object
Dim objADLump As AlibreX.IADLump

' Get Lump Object from Lumps collection on Body object
Set objADLump = objADBody.Lumps(0)

' Print indicative topology element properties exposed by Lump Object
Debug.Print "Topology Data From Lump Object: "
Debug.Print vbTab & "Lump.TopologyType = " & objADLump.TopologyType
Debug.Print vbTab & "Lump.Type = " & objADLump.Type
Debug.Print vbTab & "Lump.Shells.Count = " & objADLump.Shells.Count

Debug.Print vbTab & "Lump.Faces.Count = " & objADLump.Faces.Count
Debug.Print vbTab & "Lump.Edges.Count = " & objADLump.Edges.Count
If Not objADLump.Body Is Nothing Then
    Debug.Print vbTab & "Body object can be obtained from Lump.Body"
End If

' Holds Shell object
Dim objADShell As AlibreX.IADShell

' Get Shell Object from Shells collection on Body object
Set objADShell = objADBody.Shells(0)

' Print indicative topology element properties exposed by Shell Object

Debug.Print "Topology Data From Shell Object: "
Debug.Print vbTab & "Shell.TopologyType = " & objADShell.TopologyType
Debug.Print vbTab & "Shell.Type = " & objADShell.Type
Debug.Print vbTab & "Shell.Faces.Count = " & objADShell.Faces.Count
Debug.Print vbTab & "Shell.Edges.Count = " & objADShell.Edges.Count
If Not objADShell.Body Is Nothing Then
    Debug.Print vbTab & "Body object can be obtained from Shell.Body"
End If

If Not objADShell.Lump Is Nothing Then

    Debug.Print vbTab & "Lump object can be obtained from Shell.Lump"
End If

' Holds Face object
Dim objADFace As AlibreX.IADFace

' Get Face Object from Faces collection on Body object
Set objADFace = objADBody.Faces(0)

' Print indicative topology element properties exposed by Face Object
Debug.Print "Topology Data From Face Object: "
Debug.Print vbTab & "Face.TopologyType = " & objADFace.TopologyType
Debug.Print vbTab & "Face.Type = " & objADFace.Type

Debug.Print vbTab & "Face.Loops.Count = " & objADFace.Loops.Count
Debug.Print vbTab & "Face.Edges.Count = " & objADFace.Edges.Count
Debug.Print vbTab & "Face.Vertices.Count = " & objADFace.Vertices.Count
If Not objADFace.Body Is Nothing Then
    Debug.Print vbTab & "Body object can be obtained from Face.Body"
End If

' Holds Loop object
Dim objADLoop As AlibreX.IADLoop

' Get Face Object from Loops collection on Face object
Set objADLoop = objADFace.Loops(0)

' Print indicative topology element properties exposed by Loop Object
Debug.Print "Topology Data From Loop Object: "
Debug.Print vbTab & "Loop.TopologyType = " & objADLoop.TopologyType
Debug.Print vbTab & "Loop.Type = " & objADLoop.Type
Debug.Print vbTab & "Loop.Edges.Count = " & objADLoop.Edges.Count
Debug.Print vbTab & "Loop.Coedges.Count = " & objADLoop.Coedges.Count
If Not objADLoop.Body Is Nothing Then
    Debug.Print vbTab & "Body object can be obtained from Loop.Body"

End If

If Not objADLoop.Face Is Nothing Then
    Debug.Print vbTab & "Face object can be obtained from Loop.Face"
End If

' Holds Coedge object
Dim objADCoedge As AlibreX.IADCoedge

' Get Coedge Object from Coedges collection on Loop object
Set objADCoedge = objADLoop.Coedges(0)

' Print indicative topology element properties exposed by Coedge Object
Debug.Print "Topology Data From Coedge Object: "
Debug.Print vbTab & "Coedge.TopologyType = " & objADCoedge.TopologyType

Debug.Print vbTab & "Coedge.Type = " & objADCoedge.Type

If Not objADCoedge.Body Is Nothing Then
    Debug.Print vbTab & "Body object can be obtained from Coedge.Body"
End If

If Not objADCoedge.Loop Is Nothing Then
    Debug.Print vbTab & "Loop object can be obtained from Coedge.Loop"
End If

If Not objADCoedge.Edge Is Nothing Then
    Debug.Print vbTab & "Edge object can be obtained from Coedge.Edge "
End If

If Not objADCoedge.PartnerCoedge Is Nothing Then

    Debug.Print vbTab & "PartnerCoedge object can be obtained from Coedge.PartnerCoedge "
End If

Dim objADEdge As AlibreX.IADEdge
Set objADEdge = objADBody.Edges(0)

' Print indicative topology element properties exposed by Edge Object
Debug.Print "Topology Data From Edge Object: "
Debug.Print vbTab & "Edge.TopologyType = " & objADEdge.TopologyType
Debug.Print vbTab & "Edge.Type = " & objADEdge.Type
Debug.Print vbTab & "Edge.Faces.Count = " & objADEdge.Faces.Count

If Not objADFace.Body Is Nothing Then
    Debug.Print vbTab & "Body object can be obtained from Face.Body"
End If

If Not objADEdge.Coedge(objADEdge.Faces(0)) Is Nothing Then
    Debug.Print vbTab & "Given a Face, Coedge object can be obtained from Edge.Coedge"
End If

If Not objADEdge.StartVertex Is Nothing Then
    Debug.Print vbTab & "StartVertex object can be obtained from Edge.StartVertex"
End If

If Not objADEdge.EndVertex Is Nothing Then

    Debug.Print vbTab & "EndVertex object can be obtained from Edge.EndVertex"
End If

' Holds Vertex object
Dim objADVertex As AlibreX.IADVertex

' Get Vertex Object from Vertices collection on Body object
Set objADVertex = objADBody.Vertices(0)

' Print indicative topology element properties exposed by Vertex Object
Debug.Print "Topology Data From Vertex Object: "
Debug.Print vbTab & "Vertex.TopologyType = " & objADVertex.TopologyType

Debug.Print vbTab & "Vertex.Type = " & objADVertex.Type
Debug.Print vbTab & "Vertex.Faces.Count = " & objADVertex.Faces.Count
Debug.Print vbTab & "Vertex.Edges.Count = " & objADVertex.Edges.Count

If Not objADVertex.Body Is Nothing Then
    Debug.Print vbTab & "Body object can be obtained from Vertex.Body"
End If
```



# IADDesignPoint.Parameters Property

Get a collection object containing IADParameter objects associated with this design geometry.

#### Syntax

```
IObjectCollector Parameters { get; }
```

#### Property Value

IObjectCollector

#### Remarks

This property will return null for the Origin Point.

Points with the following PointType properties are supported:

- AD\_POINT\_FROM\_XYZ\_COORDINATES
- AD\_POINT\_FROM\_CIRCULAR\_EDGE

For points with a PointType other than the above, this property will
throw an exception.

#### Example

This Visual Basic sample shows how to get the Parameters property.

```
Dim objAlibreSourceObjects As AlibreX.IObjectCollector
Dim objAlibreDesignPoint as AlibreX.IADDesignPoint

Set objAlibreDesignPoint = m_objAlibreDesignSession.DesignPoints ("XY-New")
Set objAlibreSourceObjects = objAlibreDesignPoint.Parameters
```



# IADDesignSession.ExportSTL Method

Exports the design session as an STL file.

#### Syntax

```
void ExportSTL(
	string fileName,
	double maxCellSize,
	double normalDeviation,
	double surfaceDeviation
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the exported file.

maxCellSize  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The maximum cell size specifies the maximum length of a side of a
    cell in object space. Since a facet cannot be larger than the cell, this determines the maximum
    size of the facet. The default is zero.

normalDeviation  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The normal deviation specifies the maximum angle allowed between
    two normals on a facet. The proper value is usually independent of the model size. The default
    is 10 degrees.

surfaceDeviation  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The surface deviation is the maximum distance between the facet
    and the true surface. The proper value is dependent on the model size. The default is zero.

#### Remarks

To use the max cell size, normal deviation, and surface deviation specified by the
user in their preferences, use the method ExportSTL2.



# IADDesignSession Methods

The IADDesignSession type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | BindKeyToItem | Given a Persistent Key, returns the corresponding Occurrence/Topology element/Sketch.  (Inherited from IADSession) |
|  | CheckPrintability | Start checking printability, check printability calculating status is on or off. |
|  | Close | Closes the session and optionally saves before closing.  (Inherited from IADSession) |
|  | CreatePackage | (Inherited from IADSession) |
|  | ExportAP203 | Exports the design session as ISO AP203 STEP file. |
|  | ExportAP214 | Exports the design session as ISO AP214 STEP file. |
|  | ExportAP242 | Exports the design session as ISO AP242 STEP file. |
|  | ExportBIP(String) |  |
|  | ExportBIP(String, String) |  |
|  | ExportBOM | Export the bill of materials as a .csv file at the specified path. |
|  | ExportIGES | Exports the design session as an IGES file. The settings in Alibre's Options will be used when exporting the file. |
|  | ExportOBJ | Exports the design session as a OBJ file. |
|  | ExportParasolid | Exports the design session as a Parasolid file. |
|  | ExportSAT | Exports the design session as an ACIS SAT file. |
|  | ExportSAT2 | Exports the design as an ACIS SAT file. |
|  | ExportSTEP | Exports the design session as a Alibre STEP file. |
|  | ExportSTL | Exports the design session as an STL file. |
|  | ExportSTL2 | Exports the design session as an STL file. |
|  | Highlight | Highlights the object in the canvas.  (Inherited from IADSession) |
|  | NewTargetProxy | Creates a new TargetProxy for the given target and the occurrence  (Inherited from IADSession) |
|  | PhysicalProperties | Returns the physical properties of this design. These properties include Number of faces, Number of edges, Number of vertices, Volume, Mass, Center of mass, etc. |
|  | postProcessPrintabilityChecking | Postprocess of printability checking (Clear body member cache.) |
|  | preparePrintabilityChecking | Prepares printability meshes. This is only for Alibre Test Bed. |
|  | PrintabilityCheckResults | Returns the printability check results of this design |
|  | RegenerateDesign | Regenerate all the features of the design in this session. |
|  | Save | Saves modified session and sub-sessions, if any, to their original folder locations.  (Inherited from IADSession) |
|  | SaveAll | Saves a copy of the session and all sub-sessions to the directory indicated by the destination parameter.  (Inherited from IADSession) |
|  | SaveAs | Saves the session to create a new copy with the given name.  (Inherited from IADSession) |
|  | SaveCurrentViewSnapshot | Saves the snapshot of the graphic canvas for current view in the session, at the given location and of the given size.  (Inherited from IADSession) |
|  | SaveNew | Saves a new, unsaved session to the specified folder location.  (Inherited from IADSession) |
|  | Select | Selects all objects passed in pEntities.  (Inherited from IADSession) |
|  | SelectedObjectsEx | Returns all selected entities in the session's browser as a collection of target proxies, and sets the parameter lastSelectedPoint to last point in the user clicked to make the selection.  (Inherited from IADSession) |
|  | SetViewTransform | Sets the view transformation of this design session. |
|  | StartChanges |  |
|  | StopChanges |  |
|  | UpdatePreviewSnaphot | Captures the canvas image displayed for this session and silently saves it as the file snapshot property  (Inherited from IADSession) |
|  | ViewExtents | Returns view extents of this design session, in screen coordinates. |



# IDecomposedTransformData.RotateX Property

Returns the rotation angle component in radians about the X-axis for the decomposed transform.

#### Syntax

```
double RotateX { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADDesignPoint Interface

IADDesignPoint represents the interface for a Design Point object in a Design.

#### Syntax

```
public interface IADDesignPoint
```

The IADDesignPoint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Geometry | Returns the point's definition. |
|  | Name | Gets/sets this design point's name. |
|  | Parameters | Get a collection object containing IADParameter objects associated with this design geometry. |
|  | PointType | Returns a pre-defined constant that identifies how this design geometry was created. |
|  | Root | Returns the automation root. |
|  | Session | Returns the design session for the design point. |
|  | SourceObjects | The source objects collection represents the objects used to create the Design Point. This property returns a collection of IADTargetProxy objects. The IADTargetProxy object wraps the dependent object, and also its occurrence if the object belongs to an assembly. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_DESIGN\_POINT) of this object. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes the current design point. |
|  | Hide | Hides the design point. |
|  | Show | Shows the design point. |



# IADDesignAxis.Delete Method

Deletes the design axis.

#### Syntax

```
void Delete()
```

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_CANNOT\_DELETE\_AXIS | The design axis could not be deleted. If it is being used by a feature, it may be necessary to delete that feature first. |
| AD\_E\_INVALID\_OBJECT | This axis is not valid. It may have already been deleted. |

#### Remarks

Built-in Design Axes (X-Axis, Y-Axis, Z-Axis) cannot be deleted.

Calling any method on a deleted object throws an exception indicating that the
object is no longer valid.

The IADDesignAxes collection held by the automation
client will not be updated after Adding/Deleting an item. Get a fresh collection from the
Design Session, to get the updated list of the
Design Axes.



# IADDesignSurface.Edges Property

Get all the edges in this surface.

#### Syntax

```
IADEdges Edges { get; }
```

#### Property Value

IADEdges



# IADIGESOptions.HasEllipsesAsNURBS Property

If true, Alibre will write ellipses as NURBs curves when exporting IGES files. This
compensates for programs that do not support conic arcs. IGES uses conic arcs to
write ACIS ellipses.

#### Syntax

```
bool HasEllipsesAsNURBS { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDesignProperties.ModelUnits Property

Returns the internal model unit of measurement for representing lengths in the design.

#### Syntax

```
ADUnits ModelUnits { get; }
```

#### Property Value

ADUnits



# IADDesignAxes.CreateBy2Points Method

Creates a design axis given two points/vertices.

#### Syntax

```
IADDesignAxis CreateBy2Points(
	IADOccurrence pOccurrence1,
	Object pPoint1,
	IADOccurrence pOccurrence2,
	Object pPoint2,
	string name
)
```

#### Parameters

pOccurrence1  IADOccurrence
:   Denotes an "instance" of a Part or Assembly to which the given
    pPoint1 belongs to. For creating an axis in a standalone Part, pOccurrence1
    should be null.

pPoint1  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   An IADDesignPoint or
    IADVertex which will be used to define the axis.

pOccurrence2  IADOccurrence
:   Denotes an "instance" of a Part or Assembly to which the given
    pPoint2 belongs to. For creating an axis in a standalone Part, pOccurrence2
    should be null.

pPoint2  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   An IADDesignPoint or
    IADVertex which will be used to define the axis.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new design axis. If a null or empty string is passed,
    Alibre will name the axis.

#### Return Value

IADDesignAxis  
An interface to the new design axis.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_VARIANT\_TYPE\_UNSUPPORTED | The input points may only be of type IADVertex or IADDesignPoint. |
| AD\_E\_INVALID\_POINT | The input points may not be null. |

#### Remarks

Note that the newly created Axis object is not added to the Collection on which this
method is called. Query for the Collection again to get the updated Collection.

#### Example

This Visual Basic sample demonstrates creating a Design Axis by two Design Points. A Design Axis that is defined by two points (1, 1, 1) and (-1, -1, -1) is created here. The new Axis is named "NewAxisBy2Points".

```
' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Point 1
Dim objADDesignPoint1 As AlibreX.IADDesignPoint

' Holds Design Point 2
Dim objADDesignPoint2 As AlibreX.IADDesignPoint

' Create first Design Point at one unit (1 cm) distance along X, Y and Z.
Set objADDesignPoint1 = objADDesignSession.DesignPoints.CreatePoint(1, 1, 1)

' Create second Design Point at ten units (10 cm) distance along Y-Axis.
Set objADDesignPoint2 = objADDesignSession.DesignPoints.CreatePoint(-1, -1, -1)

' Holds the new Design Axis
Dim objADNewDesignAxis As AlibreX.IADDesignAxis

' Holds Design Axes collection object
Dim objADDesignAxes As AlibreX.IADDesignAxes

' Get Design Axes collection from Design Session
Set objADDesignAxes = objADDesignSession.DesignAxes

' Create a Design Axis using the above two Design Points.  Since all
' Design Points are belonging to the current Part, Occurances Values
' are passed as Nothing.
Set objADNewDesignAxis = objADDesignAxes.CreateBy2Points( _
            Nothing, objADDesignPoint1, _
            Nothing, objADDesignPoint2, _
            "NewAxisBy2Points")
```



# IADDesignSurfaces.Session Property

Returns the part session for the collection.

#### Syntax

```
IADPartSession Session { get; }
```

#### Property Value

IADPartSession



# IADDesignPlane.Session Property

Returns the design session for the design plane.

#### Syntax

```
IADDesignSession Session { get; }
```

#### Property Value

IADDesignSession

#### Example

This Visual Basic sample shows how to get the Session property.

```
Dim  objAlibreDesignSession As AlibreX.IADDesignSession 
Dim objAlibreDesignPlane as AlibreX.IADDesignPlane

Set objAlibreDesignPlane = m_objAlibreDesignSession.DesignPlanes (0)
Set objAlibreDesignSession =  objAlibreDesignPlane.Session
```



# IADDesignAxis.Session Property

Returns the design session for the design axis.

#### Syntax

```
IADDesignSession Session { get; }
```

#### Property Value

IADDesignSession



# IADIGESOptions.HasBoundedSurfaces Property

If true, Alibre will write all surfaces as bounded when exporting IGES files. Otherwise,
surfaces are written as trimmed whenever possible.

#### Syntax

```
bool HasBoundedSurfaces { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

Set this option to true when writing IGES files for CATIA. CATIA requires that
all surfaces be bounded.



# IADDesignSurface.Delete Method

Deletes the design surface.

#### Syntax

```
void Delete()
```

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_CANNOT\_DELETE\_SURFACE | This surface cannot be deleted. If it is being used by a feature, it may be necessary to delete that feature first. |
| AD\_E\_INVALID\_OBJECT | This is not a valid surface. It may have already been deleted. |

#### Remarks

Calling any method on the deleted object throws an exception indicating
that the object is no longer valid.



# IADConfiguration Interface

IADConfiguration represents a single configuration in a design session.

#### Syntax

```
public interface IADConfiguration
```

The IADConfiguration type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DesignSession | Returns the session in which this configuration is defined. |
|  | ID | Returns the ID of this configuration |
|  | Locks | Gets/sets the lock for a configuration. |
|  | Name | Returns the configuration's name. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_CONFIGURATION) of this object. |



# IADDesignAxis Methods

The IADDesignAxis type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes the design axis. |
|  | GetGeometry | Outputs a point on the axis and a direction vector. |
|  | Hide | Hides the design axis. |
|  | Show | Shows the design axis. |



# IDecomposedTransformData.RotateY Property

Returns the rotation angle component in radians about the Y-axis for the decomposed transform.

#### Syntax

```
double RotateY { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IDecomposedTransformData Properties

The IDecomposedTransformData type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | RotateAngle | Returns the rotation angle component in radians about the rotation vector for the decomposed transform. |
|  | RotateVector | Returns the vector around which the rotation component was decomposed for the transform. |
|  | RotateX | Returns the rotation angle component in radians about the X-axis for the decomposed transform. |
|  | RotateY | Returns the rotation angle component in radians about the Y-axis for the decomposed transform. |
|  | RotateZ | Returns the rotation angle component in radians about the Z-axis for the decomposed transform. |
|  | ScaleX | Returns the scale component of the decomposed transform in X direction. |
|  | ScaleY | Returns the scale component of the decomposed transform in Y direction. |
|  | ScaleZ | Returns the scale component of the decomposed transform in Z direction. |
|  | ShearXY | Returns the shearXY component of the decomposed transform. |
|  | ShearYZ | Returns the shearYZ component of the decomposed transform. |
|  | ShearZX | Returns the shearZX component of the decomposed transform. |
|  | TranslateX | Returns the translate component of the decomposed transform in the X direction. |
|  | TranslateY | Returns the translate component of the decomposed transform in the Y direction. |
|  | TranslateZ | Returns the translate component of the decomposed transform in the Z direction. |



# IADDesignPoint.Geometry Property

Returns the point's definition.

#### Syntax

```
IADPoint Geometry { get; }
```

#### Property Value

IADPoint



# IADDesignSelectionFilter.Dimensions Property

If true, dimensions are selectable.

#### Syntax

```
bool Dimensions { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADConfiguration.Name Property

Returns the configuration's name.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)

#### Example

This Visual Basic sample shows how to get the Name property.

```
' Holds Session object
Dim objSession as IADSession 

' Open an existing part using OpenFile() on Root object. Note: User may set it to any required file and location
Set objADSession = m_objADRoot.OpenFile("C://Part.AD_PRT")

' Holds Alibre Design Session object
Dim objDesignSession As IADDesignSession 

'Assign objADSession to objDesignSession 
Set objDesignSession = objADSession

'Holds all configurations in a design session
Dim objConfigs As IADConfigurations

'set the configurations in the design session
Set objConfigs = DesignSession.Configurations

'Holds a configuration in a design session
Dim objConfig As IADConfigurations

'Set the first configuration to objConfig  
Set objConfig = objConfigs.Item(0)

'Holds the name of the configuration
Dim ConfigName As String

'Get the name of the first configuration
ConfigName = objConfig.Name
```



# IADIGESOptions.EOLLength Property

Gets/sets the length of the end-of-line character (in bytes). Value must be between 1
through 4.

#### Syntax

```
int EOLLength { get; set; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

When writing for CATIA use 1 or 4.



# IADBodies.Item Method

Given a numerical index into the collection, returns the corresponding body.

#### Syntax

```
IADBody Item(
	int index
)
```

#### Parameters

index  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The numerical index of the body.

#### Return Value

IADBody  
Returns IADBody

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INDEX\_OUT\_OF\_BOUNDS | The specified index is outside of the bounds of the collection. |
| AD\_E\_OBJECT\_NOT\_FOUND\_AT\_INDEX | No object exists at the specified index. |



# IADConfigurations.Count Property

Gets the count of configurations in this collection.

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
Dim objSession as IADSession 

' Open an existing part using OpenFile() on Root object. Note: User may set it to any required file and 
location
Set objADSession = m_objADRoot.OpenFile("C://Part.AD_PRT")

' Holds Alibre Design Session object
Dim objDesignSession As IADDesignSession 

'Assign objADSession to objDesignSession 
Set objDesignSession = objADSession

'Holds all configurations in a design session
Dim objConfigs As IADConfigurations

'set the configurations in the design session
Set objConfigs = DesignSession.Configurations

'Holds the configurations count in the design session
Dim ConfigCount As Long

'Set the count of the configurations in the design session
ConfigCount = objConfigs.Count
```



# IADConfiguration Properties

The IADConfiguration type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DesignSession | Returns the session in which this configuration is defined. |
|  | ID | Returns the ID of this configuration |
|  | Locks | Gets/sets the lock for a configuration. |
|  | Name | Returns the configuration's name. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_CONFIGURATION) of this object. |



# IADDesignPoints.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADDesignAxis.Parameters Property

Get a collection object containing IADParameter objects associated with this design geometry.

#### Syntax

```
IObjectCollector Parameters { get; }
```

#### Property Value

IObjectCollector

#### Remarks

If this property is called on a Primary Design Axis, this property will return null.

#### Example

This Visual Basic sample shows how to get the Parameters property.

```
Dim objAlibreParameters As AlibreX.IADDParameters
Dim objAlibreDesignAxis as AlibreX.IADDesignAxis

Set objAlibreDesignAxis = m_objAlibreDesignSession.DesignAxes ("X-New")
Set objAlibreParameters =  objAlibreDesignAxis.Parameters
```



# IADDesignSession.ExportAP214 Method

Exports the design session as ISO AP214 STEP file.

#### Syntax

```
void ExportAP214(
	string fileName
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the exported file.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_INVALID\_LICENSE\_KEY | The license for this installation of Alibre Design does not permit exporting this design as a STEP file. |



# IADDesignPlane.Type Property

Returns a pre-defined constant that identifies the type (AD\_DESIGN\_PLANE) of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADPartSession.Reflectivity Property

The part's reflectivity

#### Syntax

```
int Reflectivity { get; set; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

Reflectivity goes from 0 to 100, with 100 being the most shiny, just
like in the GUI.



# IADDesignSelectionFilter.Planes Property

If true, reference planes are selectable.

#### Syntax

```
bool Planes { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDesignPoints.CreateByAxisAndPlane Method

Creates a design point at the intersection of an axis/edge and a plane/face.

#### Syntax

```
IADDesignPoint CreateByAxisAndPlane(
	IADOccurrence pOccurrence1,
	Object pAxis,
	IADOccurrence pOccurrence2,
	Object pPlane,
	string name
)
```

#### Parameters

pOccurrence1  IADOccurrence
:   Denotes an "instance" of a Part or Assembly to which the given
    pAxis belongs to. For creating a point in a standalone Part, pOccurrence1
    should be null.

pAxis  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   First axis or linear edge
    which will be used to define the intersection point.

pOccurrence2  IADOccurrence
:   Denotes an "instance" of a Part or Assembly to which the given
    pPlane belongs to. For creating a point in a standalone Part, pOccurrence2
    should be null.

pPlane  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Input plane or planar face
    which will be used to define the intersection point.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new design point. If a null or empty string is passed,
    Alibre will name the point.

#### Return Value

IADDesignPoint  
An interface to the new design point.



# IADDesignAxis.GetGeometry Method

Outputs a point on the axis and a direction vector.

#### Syntax

```
void GetGeometry(
	out IADPoint ppPoint1,
	out IADPoint ppVector
)
```

#### Parameters

ppPoint1  IADPoint
:   A point which lies on the axis.

ppVector  IADPoint
:   The direction vector of the axis.

#### Example

This Visual Basic sample shows how to call the GetGeometry method.

```
' Example Description: Demonstrates accessing Geometry information of a Design Axis.
' Geometry information Design Plane "X-Axis" is obtained here.

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Axis object
Dim objADDesignAxis As AlibreX.IADDesignAxis

' Get Design Axis from Design Axes collection by Name
Set objADDesignAxis = objADDesignSession.DesignAxes("X-Axis")

' Points to capture geometry information
Dim objADPoint1 As AlibreX.IADPoint
Dim objADPoint2 As AlibreX.IADPoint

' Get Geometry information using GetGeometry() 
Call objADDesignAxis.GetGeometry(objADPoint1, objADPoint2)
```



# IADDesignAxes.CreateBy2Planes Method

Creates a design axis from two intersecting design planes or planar faces.

#### Syntax

```
IADDesignAxis CreateBy2Planes(
	IADOccurrence pOccurrence1,
	Object pPlane1,
	IADOccurrence pOccurrence2,
	Object pPlane2,
	string name
)
```

#### Parameters

pOccurrence1  IADOccurrence
:   Denotes an "instance" of a Part or Assembly to which the given
    pPlane1 belongs to. For creating an axis in a standalone Part, pOccurrence1
    should be null.

pPlane1  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   A plane or planar face
    which will be used to define the axis.

pOccurrence2  IADOccurrence
:   Denotes an "instance" of a Part or Assembly to which the given
    pPlane2 belongs to. For creating an axis in a standalone Part, pOccurrence2
    should be null.

pPlane2  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   A plane or planar face
    which will be used to define the axis.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new design axis. If a null or empty string is passed,
    Alibre will name the axis.

#### Return Value

IADDesignAxis  
An interface to the new design axis.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INVALID\_PLANE | The input plane was not valid. |
| AD\_E\_NONPLANAR\_FACE | If using a face as one of the parameters, it must be planar. |
| AD\_E\_GEOMETRY\_CREATION\_FAILURE | Alibre was unable to create valid geometry for the design axis. |

#### Remarks

Note that the newly created Axis object is not added to the Collection on which this
method is called. Query for the Collection again to get the updated Collection.

#### Example

This Visual Basic sample shows how to get the CreateBy2Planes method.

```
' Example Description: Demonstrates creating a Design Axis by two Design
' Planes.  A Design Axis that is defined by the intersection of XY-Plane and
' YZ-Plane is created here.  New Axis is named as "NewAxisBy2Planes"

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane 1
Dim objADDesignPlane1 As AlibreX.IADDesignPlane

' Get XY-Plane from Design Planes collection by Name
Set objADDesignPlane1 = objADDesignSession.DesignPlanes("XY-Plane")

' Holds Design Plane 2
Dim objADDesignPlane2 As AlibreX.IADDesignPlane

' Get YZ-Plane from Design Planes collection by Name
Set objADDesignPlane2 = objADDesignSession.DesignPlanes("YZ-Plane")

' Holds the new Design Axis
Dim objADNewDesignAxis As AlibreX.IADDesignAxis

' Holds Design Axes collection object
Dim objADDesignAxes As AlibreX.IADDesignAxes

' Get Design Axes collection from Design Session
Set objADDesignAxes = objADDesignSession.DesignAxes

' Create a Design Axis using the above two Design Planes.  Since all
' Design Planes are belonging to the current Part, Occurances Values
' are passed as Nothing.
Set objADNewDesignAxis = objADDesignAxes.CreateBy2Planes( _
            Nothing, objADDesignPlane1, _
            Nothing, objADDesignPlane2, _
            "NewAxisBy2Planes")
```



# IADDesignPlanes.Item Method

Given a name or numerical index into the collection, returns the corresponding design plane.

#### Syntax

```
IADDesignPlane Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or numerical index of the plane.

#### Return Value

IADDesignPlane  
Returns IADDesignPlane

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INDEX\_OUT\_OF\_BOUNDS | The specified index is outside of the bounds of the collection. |
| AD\_E\_OBJECT\_NOT\_FOUND\_AT\_INDEX | No object exists at the specified index. |
| AD\_E\_VARIANT\_TYPE\_UNSUPPORTED | The index parameter should be an int or a string. |

#### Example

Get Item by number

```
' Example Description: Demonstrates accessing Design Plane by Item Index.
' A Design Plane with Index value of zero is accessed here.
' Holds Design Session object
Dim objADDesignSession As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Planes collection object
Dim objADDesignPlanes As AlibreX.IADDesignPlanes

' Get Design Planes collection from Design Session
Set objADDesignPlanes = objADDesignSession.DesignPlanes

' Holds Design Plane object
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Get Design Plane from Design Planes collection by Index
Set objADDesignPlane = objADDesignPlanes.Item(0)
```

Get Item by name

```
' Example Description: Demonstrates accessing Design Plane by Item Name.
' A Design Plane with name "XY-Plane" is accessed here.

' Holds Design Session object
Dim objADDesignSession As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Planes collection object
Dim objADDesignPlanes As AlibreX.IADDesignPlanes

' Get Design Planes collection from Design Session
Set objADDesignPlanes = objADDesignSession.DesignPlanes

' Holds Design Plane object
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Get Design Plane from Design Planes collection by Name
Set objADDesignPlane = objADDesignPlanes.Item("XY-Plane")
```



# IADDesignSession.ExportParasolid Method

Exports the design session as a Parasolid file.

#### Syntax

```
void ExportParasolid(
	string fileName
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the exported file.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_INVALID\_LICENSE\_KEY | The license for this installation of Alibre Design does not permit exporting this design as a Parasolid file. |



# IADDesignPlane.GetGeometry Method

Returns the lower, upper, and top left corner points for the plane.

#### Syntax

```
void GetGeometry(
	out IADPoint ppPoint1,
	out IADPoint ppPoint2,
	out IADPoint ppPoint3
)
```

#### Parameters

ppPoint1  IADPoint
:   The lower left point.

ppPoint2  IADPoint
:   The upper right point.

ppPoint3  IADPoint
:   The top left point.

#### Example

This Visual Basic sample shows how to call the GetGeometry method.

```
' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane object
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Get Design Plane from Design Planes collection by Name
Set objADDesignPlane = objADDesignSession.DesignPlanes("XY-Plane")

' Points to capture geometry information
Dim objADPoint1 As AlibreX.IADPoint
Dim objADPoint2 As AlibreX.IADPoint
Dim objADPoint3 As AlibreX.IADPoint

' Get Geometry information using GetGeometry() 
Call objADDesignPlane.GetGeometry(objADPoint1, objADPoint2, objADPoint3)
```



# IDecomposedTransformData.ShearYZ Property

Returns the shearYZ component of the decomposed transform.

#### Syntax

```
double ShearYZ { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADDesignSurface.Root Property

Returns the automation root object.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADDesignSurface.Type Property

Returns a pre-defined constant that identifies the type (AD\_DESIGN\_SURFACE)
of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADDesignSession.ActiveConfiguration Property

Gets/sets the active configuration for this design session.

#### Syntax

```
IADConfiguration ActiveConfiguration { get; set; }
```

#### Property Value

IADConfiguration

#### Example

This Visual Basic sample shows how to get and set the ActiveConfiguration property.

```
' Holds Session object
Dim objSession as IADSession 

' Open an existing part using OpenFile() on Root object. Note: User may set it to any required file and location
Set objADSession = m_objADRoot.OpenFile("C://Part.AD_PRT")

' Holds Alibre Design Session object
Dim objDesignSession As IADDesignSession 

'Assign objADSession to objDesignSession 
Set objDesignSession = objADSession

'Holds all configurations in a design session
Dim objConfigs As IADConfigurations

'set the configurations in the design session
Set objConfigs = DesignSession.Configurations

'Holds a configuration in a design session
Dim objConfig As IADConfigurations

'Set the first configuration to objConfig  
Set objConfig = objConfigs.Item(0)

'Holds the active configuration in a design session
Dim ActiveConfig As IADConfiguration

'Gets the Active Configuration in the design session
Set ActiveConfig = DesignSession. ActiveConfiguration

'Set objConfig to be the Active Configuration in the design session
If Not (objConfig Is DesignSession.ActiveConfiguration) Then
    Set DesignSession.ActiveConfiguration = objConfigEnd If
```



# IADConfiguration.ID Property

Returns the ID of this configuration

#### Syntax

```
int ID { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Example

This Visual Basic sample shows how to get the DesignSession property.

```
' Holds Session object
Dim objSession as IADSession 

' Open an existing part using OpenFile() on Root object. Note: User may set it to any required file and location
Set objADSession = m_objADRoot.OpenFile("C://Part.AD_PRT")

' Holds Alibre Design Session object
Dim objDesignSession As IADDesignSession 

'Assign objADSession to objDesignSession 
Set objDesignSession = objADSession

'Holds all configurations in a design session
Dim objConfigs As IADConfigurations

'set the configurations in the design session
Set objConfigs = DesignSession.Configurations

'Holds a configuration in a design session
Dim objConfig As IADConfigurations

'Set the first configuration to objConfig  
Set objConfig = objConfigs.Item(0)

'Set the first configuration's design session 
Set objDesignSession = objConfig.DesignSession
```



# IADDesignMesh.TriangleCount Property

Returns true if surfacing of the DesignMesh is complete.

#### Syntax

```
long TriangleCount { get; }
```

#### Property Value

[Int64](https://learn.microsoft.com/dotnet/api/system.int64)



# IADPartSession.SectionBodies Property

Returns the collection of section bodies.

#### Syntax

```
IADBodies SectionBodies { get; }
```

#### Property Value

IADBodies
