# AlibreX API — Geometry & BRep Topology

> Part of the split AlibreX reference. See `00_index.md` for the full map.

**Sections in this file:** 282

---


# IADFace.Body Property

Get the owning body.

#### Syntax

```
IADBody Body { get; }
```

#### Property Value

IADBody



# IADFaces.Item Method

Given a numerical index into the collection, returns the corresponding face.

#### Syntax

```
IADFace Item(
	int index
)
```

#### Parameters

index  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The numerical index of the face.

#### Return Value

IADFace  
Returns IADFace

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INDEX\_OUT\_OF\_BOUNDS | The specified index is outside of the bounds of the collection. |
| AD\_E\_OBJECT\_NOT\_FOUND\_AT\_INDEX | No object exists at the specified index. |



# IADPhysicalProperties.GetCenterOfGravity Method

Returns the X, Y and Z coordinates of the center of gravity.

#### Syntax

```
void GetCenterOfGravity(
	out double pX,
	out double pY,
	out double pZ
)
```

#### Parameters

pX  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate.

pY  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate.

pZ  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Z coordinate.



# IADLine Interface

IADLine interface represents the straight line geometry and can be obtained by typecasting
the Curve object which is of type AD\_LINE. This interface defines the line as a start point
and a vector denoting the length and direction of the line. Using this data it is possible
to find the end point of the line.

#### Syntax

```
public interface IADLine : IADCurve
```

The IADLine type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CurveType | Returns a pre-defined constant that identifies the curve type of this object.  (Inherited from IADCurve) |
|  | DirectionVector | Gets the vector representing the direction of the line. |
|  | IsClosed | Returns true if this curve is closed.  (Inherited from IADCurve) |
|  | StartPoint | Gets the starting point of the line. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADCurve) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Curvature | Gets the curvature at the given parameter as a vector.  (Inherited from IADCurve) |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADCurve) |
|  | GetParameterExtents | Gets the Parameter Extents: Start Param and End Param.  (Inherited from IADCurve) |
|  | ParamAtPoint | Gets the parameter at the given point.  (Inherited from IADCurve) |
|  | PointAtParam | Gets the point at the given parameter.  (Inherited from IADCurve) |
|  | Tangent | Gets the tangent at the given parameter.  (Inherited from IADCurve) |



# IADPlane Properties

The IADPlane type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Normal | Gets the plane's normal. |
|  | RootPoint | Gets the root point of the plane. |
|  | SurfaceType | Returns a pre-defined constant that identifies the surface type of this object.  (Inherited from IADSurface) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADSurface) |



# IADShell.Type Property

Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADCoedges Properties

The IADCoedges type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of Co-Edges in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the part session for the collection. |



# IADLoop.Type Property

Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADLump Interface

This interface represents the Lump in Alibre Design. This is the second level
topological entity. A lump represents a collection of bounded, connected region
in space. A Body can have zero, one, or more lumps.

#### Syntax

```
public interface IADLump
```

The IADLump type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Body | Get the owning body for this lump. |
|  | Edges | Get all the edges in the lump. |
|  | Faces | Get all the faces in the lump. |
|  | Part | Get the part session owning the lump. |
|  | Shells | Get all the shells in the lump. |
|  | TopologyType | Returns a pre-defined constant that identifies the topology type (AD\_LUMP) of this object. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object. |



# IADShells.Item Method

Given a numerical index into the collection, returns the corresponding shell.

#### Syntax

```
IADShell Item(
	int index
)
```

#### Parameters

index  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The numerical index of a shell.

#### Return Value

IADShell  
Returns IADShell

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INDEX\_OUT\_OF\_BOUNDS | The specified index is outside of the bounds of the collection. |
| AD\_E\_OBJECT\_NOT\_FOUND\_AT\_INDEX | No object exists at the specified index. |



# IADEdge Interface

This interface represents the Edge in Alibre Design. An edge is the topology associated with a curve.
An edge is bounded by one or more vertices, referring to one vertex at each end.

#### Syntax

```
public interface IADEdge
```

The IADEdge type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Body | Get the owning body. |
|  | EndVertex | Gets the end vertex of the edge. |
|  | Faces | Get all faces sharing this edge. |
|  | Geometry | Get the curve geometry associated with this edge. |
|  | IsSenseReversed | Returns the sense of the edge with respect to the underlying curve. It returns true if the direction of the underlying curve and the edge are in opposite direction. |
|  | Key | Gets the Persistent Key property of this Edge. This Key is unique for this Edge and can be used to access the edge. |
|  | Part | Get the part session owning the body. |
|  | StartVertex | Gets the start vertex of the edge. |
|  | TimeStamp | Returns time stamp of this edge; the time stamp changes when the edge is modified. |
|  | TopologyType | Returns a pre-defined constant that identifies the topology type (AD\_EDGE) of this object. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Coedge | Get one Coedge of the Edge on the given face. |
|  | GetExtents | Returns Range Box that denotes the max/min of a 3D box for this edge. |



# IADLoop.Coedges Property

Get all the Co-edges in the loop.

#### Syntax

```
IADCoedges Coedges { get; }
```

#### Property Value

IADCoedges



# IADBody.Type Property

Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADTorus Methods

The IADTorus type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADSurface) |
|  | GetFirstDerivative | Gets the first derivative for the given parameter.  (Inherited from IADSurface) |
|  | GetParamAtPoint | Gets the u,v parameters at the given point on the parametric surface.  (Inherited from IADSurface) |
|  | GetParameterExtents | Gets the parameter range in u and v directions.  (Inherited from IADSurface) |
|  | GetRayIntersectionPoint | Returns intersection point and distance from given ray.  (Inherited from IADSurface) |
|  | GetSecondDerivative | Gets the second order derivatives on the parametric surface for the given parameter values. There are three second order derivatives Xuu, Xuv and Xvv.  (Inherited from IADSurface) |
|  | NormalAtParam | Gets the normal to the parametric surface at the point with given parameters.  (Inherited from IADSurface) |
|  | NormalAtPoint | Gets the normal to the surface at the given point.  (Inherited from IADSurface) |
|  | PointAtParam | Gets the point corresponding to the given parameter values on the parametric surface.  (Inherited from IADSurface) |



# IADVertex.Part Property

Get the part session owning the vertex.

#### Syntax

```
IADPartSession Part { get; }
```

#### Property Value

IADPartSession



# IADCircularArc.Center Property

Gets the center point of the circular arc.

#### Syntax

```
IADPoint Center { get; }
```

#### Property Value

IADPoint

#### Example

This Visual Basic sample shows how to call the Center property.

```
Dim objADCircularArc As AlibreX.IADCircularArc
Dim objADPoint As AlibreX.IADPoint

If objCurve.CurveType = AD_CIRCULAR_ARC Then
    Set objADCircularArc = objCurve
    Set objADPoint = objADCircularArc.Center()
End If
```



# IADTorus.MinorRadius Property

Gets the radius of the circular cross section used to create the torus.

#### Syntax

```
double MinorRadius { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

The absolute value of this value specifies the radius of a cross-sectional circle of the ring.
If this is negative, then the torus is a void. If this value is 0, then the torus is undefined.



# IADPhysicalProperties Methods

The IADPhysicalProperties type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetCenterOfGravity | Returns the X, Y and Z coordinates of the center of gravity. |
|  | GetExtents | Returns the range box that denotes the max/min of a 3D box surrounding the design. |
|  | GetMomentsOfInertia | Returns the XX, YY, ZZ, YZ, ZX, XY values of the moment of inertia. |
|  | GetPrincipalAxis1 | Returns the orientation of the first principal axis. |
|  | GetPrincipalAxis2 | Returns the orientation of the second principal axis. |
|  | GetPrincipalAxis3 | Returns the orientation of the third principal axis. |
|  | GetPrincipalMomentsOfInertia | Returns the principal moments of inertia. |



# IADCircularArc.Start Property

Returns the start point of the circular arc.

#### Syntax

```
IADPoint Start { get; }
```

#### Property Value

IADPoint

#### Example

This Visual Basic sample shows how to call the Start property.

```
Dim objADCircularArc As AlibreX.IADCircularArc
Dim objADPoint As AlibreX.IADPoint

If objCurve.CurveType = AD_CIRCULAR_ARC Then
    Set objADCircularArc = objCurve
    Set objADPoint = objADCircularArc.Starrt()
End If
```



# IADPhysicalProperties.FacesCount Property

Returns the number of faces in design. If the design is an Assembly,
then number of faces returned is the total number of faces in all the parts in the assembly.

#### Syntax

```
int FacesCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADFace Interface

This interface represents the Face in Alibre Design. A Face represents
a bounded portion of the surface and is the 2D analogue for the body.

#### Syntax

```
public interface IADFace
```

The IADFace type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | AppearanceID | Returns the appearance id for this face. |
|  | Body | Get the owning body. |
|  | Color | Returns the color applied to this face for the active configuration. This color can be the color applied using the feature color or the face color feature. |
|  | Edges | Get all Edges in a Face. |
|  | Geometry | Get the surface geometry associated with this face. |
|  | IsSenseReversed | Returns the sense of the face with respect to the underlying surface. It returns true if the normals of the underlying surface and face are in opposite direction. |
|  | Key | Gets the Persistent Key property of this face. This Key is unique for this face and can be used to access the face. |
|  | Loops | Get all Loops in a Face. |
|  | Part | Get the part session owning the body. |
|  | Shell | Get the owning shell. |
|  | TimeStamp | Returns time stamp of this face; the time stamp changes when the face is modified. |
|  | TopologyType | Returns a pre-defined constant that identifies the topology type (AD\_FACE) of this object. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object. |
|  | Vertices | Get all Vertices in a Face. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | FacetData | Returns triangular mesh data for the face given the maximum deviation of a facet from the surface. |
|  | FacetDataEx | Returns triangular mesh data for the face given the maximum deviation of a facet from the surface. |
|  | GetAlibreMeshData | Returns the raw mesh data for the face using the facet settings in the corresponding part session. |
|  | GetBSplineCurvesData |  |
|  | GetColorForConfiguration | Returns the color applied to this face for a given configuration. This color can be the color applied using the feature color or the face color feature. |
|  | GetExtents | Returns Range Box that denotes the max/min of a 3D box for this face. |
|  | GetMeshData | Returns the raw mesh data for the face given the maximum deviation of a facet from the surface. |
|  | PointOnFace | Tests the point's position with respect to the surface within the system tolerance limit. The limit is normally equal to 1e-6. Returns true of the input point lies on the face. |



# IADEllipse.MajorAxis Property

Gets length of major axis.

#### Syntax

```
double MajorAxis { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Example

This Visual Basic sample shows how to call the MajorAxis property.

```
Dim objADEllipse As AlibreX.IADEllipse

If objCurve.CurveType = AD_ELLIPSE Then
    Set objADEllipse = objCurve
    Debug.Print objADEllipse.MajorAxis()
End If
```



# IADEdges.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADFace Properties

The IADFace type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | AppearanceID | Returns the appearance id for this face. |
|  | Body | Get the owning body. |
|  | Color | Returns the color applied to this face for the active configuration. This color can be the color applied using the feature color or the face color feature. |
|  | Edges | Get all Edges in a Face. |
|  | Geometry | Get the surface geometry associated with this face. |
|  | IsSenseReversed | Returns the sense of the face with respect to the underlying surface. It returns true if the normals of the underlying surface and face are in opposite direction. |
|  | Key | Gets the Persistent Key property of this face. This Key is unique for this face and can be used to access the face. |
|  | Loops | Get all Loops in a Face. |
|  | Part | Get the part session owning the body. |
|  | Shell | Get the owning shell. |
|  | TimeStamp | Returns time stamp of this face; the time stamp changes when the face is modified. |
|  | TopologyType | Returns a pre-defined constant that identifies the topology type (AD\_FACE) of this object. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object. |
|  | Vertices | Get all Vertices in a Face. |



# IADVertices.Item Method

Given a numerical index into the collection, returns the corresponding vertex.

#### Syntax

```
IADVertex Item(
	int index
)
```

#### Parameters

index  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The numerical index of a vertex.

#### Return Value

IADVertex  
Returns IADVertex

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INDEX\_OUT\_OF\_BOUNDS | The specified index is outside of the bounds of the collection. |
| AD\_E\_OBJECT\_NOT\_FOUND\_AT\_INDEX | No object exists at the specified index. |



# IADEllipticalArc.Center Property

Gets the center point of the elliptical arc.

#### Syntax

```
IADPoint Center { get; }
```

#### Property Value

IADPoint

#### Example

This Visual Basic sample shows how to call the Center property.

```
Dim objADEllipticalArc As AlibreX.IADEllipticalArc
Dim objADPoint As AlibreX.IADPoint

If objCurve.CurveType = AD_ELLIPTICAL_ARC Then
    Set objADEllipticalArc = objCurve
    Set objADPoint = objADEllipticalArc.Center()
End If
```



# IADTopologySummary.FacesCount Property

Returns the number of faces.

#### Syntax

```
int FacesCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADEllipticalArc.Axis Property

Outputs the unit vector perpendicular to the plane of the elliptical arc according to the right hand rule.

#### Syntax

```
IADVector Axis { get; }
```

#### Property Value

IADVector

#### Example

This Visual Basic sample shows how to call the Axis property.

```
Dim objADEllipticalArc As AlibreX.IADEllipticalArc
Dim objADVector As AlibreX.IADVector

If objCurve.CurveType = AD_ELLIPTICAL_ARC Then
    Set objADEllipticalArc = objCurve
    Set objADVector = objADEllipticalArc.Axis()
End If
```



# IADPlane Methods

The IADPlane type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADSurface) |
|  | GetFirstDerivative | Gets the first derivative for the given parameter.  (Inherited from IADSurface) |
|  | GetParamAtPoint | Gets the u,v parameters at the given point on the parametric surface.  (Inherited from IADSurface) |
|  | GetParameterExtents | Gets the parameter range in u and v directions.  (Inherited from IADSurface) |
|  | GetRayIntersectionPoint | Returns intersection point and distance from given ray.  (Inherited from IADSurface) |
|  | GetSecondDerivative | Gets the second order derivatives on the parametric surface for the given parameter values. There are three second order derivatives Xuu, Xuv and Xvv.  (Inherited from IADSurface) |
|  | NormalAtParam | Gets the normal to the parametric surface at the point with given parameters.  (Inherited from IADSurface) |
|  | NormalAtPoint | Gets the normal to the surface at the given point.  (Inherited from IADSurface) |
|  | PointAtParam | Gets the point corresponding to the given parameter values on the parametric surface.  (Inherited from IADSurface) |



# IADCircularArc Interface

IADCircularArc interface represents a circular arc geometry and can be obtained by typecasting the
Curve Object which is of type AD\_CIRCULAR\_ARC. In addition to the properties of the circle namely,
center point, radius and unit normal vector, this interface gives the start and end point of the
arc to uniquely locate the circular arc.

#### Syntax

```
public interface IADCircularArc : IADCurve
```

The IADCircularArc type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Outputs the unit vector perpendicular to the plane of the circular arc according to right hand rule. |
|  | Center | Gets the center point of the circular arc. |
|  | CurveType | Returns a pre-defined constant that identifies the curve type of this object.  (Inherited from IADCurve) |
|  | End | Returns the end point of the circular arc. |
|  | IsClosed | Returns true if this curve is closed.  (Inherited from IADCurve) |
|  | Radius | Gets the radius of the circular arc. |
|  | Start | Returns the start point of the circular arc. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADCurve) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Curvature | Gets the curvature at the given parameter as a vector.  (Inherited from IADCurve) |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADCurve) |
|  | GetParameterExtents | Gets the Parameter Extents: Start Param and End Param.  (Inherited from IADCurve) |
|  | ParamAtPoint | Gets the parameter at the given point.  (Inherited from IADCurve) |
|  | PointAtParam | Gets the point at the given parameter.  (Inherited from IADCurve) |
|  | Tangent | Gets the tangent at the given parameter.  (Inherited from IADCurve) |



# IADLoop.Face Property

Get the owning face.

#### Syntax

```
IADFace Face { get; }
```

#### Property Value

IADFace



# IADLoop.IsOuter Property

Returns true if this loop is an outer loop.

#### Syntax

```
bool IsOuter { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

There can be many loops in a face. This method can be used to determine
whether a particular loop is an outer loop.



# IADBody.Edges Property

Returns a collection of all the edges in the body.

#### Syntax

```
IADEdges Edges { get; }
```

#### Property Value

IADEdges



# IADVertices.Count Property

Returns the number of vertices in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADPhysicalProperties.LumpsCount Property

Returns the number of lumps in design. If the design is an Assembly,
then number of lumps returned is the total number of lumps in all the parts in the assembly.

#### Syntax

```
int LumpsCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADLoop.Part Property

Get the part session owning the loop

#### Syntax

```
IADPartSession Part { get; }
```

#### Property Value

IADPartSession



# IADCoedges.Item Method

Given a numerical index into the collection, returns the corresponding Co-edge.

#### Syntax

```
IADCoedge Item(
	int index
)
```

#### Parameters

index  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The numerical index of the coedge.

#### Return Value

IADCoedge  
Returns IADCoedge

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INDEX\_OUT\_OF\_BOUNDS | The specified index is outside of the bounds of the collection. |
| AD\_E\_OBJECT\_NOT\_FOUND\_AT\_INDEX | No object exists at the specified index. |



# IADLoop.Body Property

Get the owning body.

#### Syntax

```
IADBody Body { get; }
```

#### Property Value

IADBody



# IADBsplineCurve Methods

The IADBsplineCurve type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Curvature | Gets the curvature at the given parameter as a vector.  (Inherited from IADCurve) |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADCurve) |
|  | GetData | Get the spline data. |
|  | GetDefinition | Get the spline definition. |
|  | GetParameterExtents | Gets the Parameter Extents: Start Param and End Param.  (Inherited from IADCurve) |
|  | ParamAtPoint | Gets the parameter at the given point.  (Inherited from IADCurve) |
|  | PointAtParam | Gets the point at the given parameter.  (Inherited from IADCurve) |
|  | Tangent | Gets the tangent at the given parameter.  (Inherited from IADCurve) |



# IADSurface.NormalAtParam Method

Gets the normal to the parametric surface at the point with given parameters.

#### Syntax

```
IADVector NormalAtParam(
	double puParam,
	double pvParam
)
```

#### Parameters

puParam  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   u parameter for the point at which the normal is to be evaluated.

pvParam  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   v parameter for the point at which the normal is to be evaluated.

#### Return Value

IADVector  
Returns IADVector

#### Example

This Visual Basic sample shows how to call the NormalAtParam method.

```
Dim objADVector As AlibreX.IADVector
Set objADVector = objSurface.NormalAtParam(0.5, 0.5)
```



# IADFace.GetAlibreMeshData Method

Returns the raw mesh data for the face using the facet settings in the corresponding part session.

#### Syntax

```
void GetAlibreMeshData(
	out Array faceArray,
	out Array normalArray,
	out Array vertexArray
)
```

#### Parameters

faceArray  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   The face indicies representing the vertices for each facet.

normalArray  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   The vertex normals of each vertex points.

vertexArray  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   The vertices array which has unique vertex points represented by a triplet for (x,y,z).



# IADEllipticalArc Methods

The IADEllipticalArc type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Curvature | Gets the curvature at the given parameter as a vector.  (Inherited from IADCurve) |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADCurve) |
|  | GetParameterExtents | Gets the Parameter Extents: Start Param and End Param.  (Inherited from IADCurve) |
|  | ParamAtPoint | Gets the parameter at the given point.  (Inherited from IADCurve) |
|  | PointAtParam | Gets the point at the given parameter.  (Inherited from IADCurve) |
|  | Tangent | Gets the tangent at the given parameter.  (Inherited from IADCurve) |



# IADLumps Interface

This interface represents the collection of all the lumps in a Body. A lump represents
a collection of connected region in space. A Body can have zero, one, two or more lumps.

#### Syntax

```
public interface IADLumps
```

The IADLumps type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of lumps in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the part session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding lump. |

#### Remarks

It is possible to obtain this collection of lumps by querying the property
Lumps on IADBody interface objects.



# IADFace.Edges Property

Get all Edges in a Face.

#### Syntax

```
IADEdges Edges { get; }
```

#### Property Value

IADEdges



# IADTorus.Center Property

Gets the center point of the torus.

#### Syntax

```
IADPoint Center { get; }
```

#### Property Value

IADPoint



# IADCoedges.Count Property

Returns the number of Co-Edges in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADVertex.Key Property

Gets the Persistent Key property of this vertex. This Key is unique for this Vertex and can be used to access the vertex.

#### Syntax

```
Array Key { get; }
```

#### Property Value

[Array](https://learn.microsoft.com/dotnet/api/system.array)



# IADBsplineSurface Properties

The IADBsplineSurface type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | SurfaceType | Returns a pre-defined constant that identifies the surface type of this object.  (Inherited from IADSurface) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADSurface) |



# IADFace.PointOnFace Method

Tests the point's position with respect to the surface within the system tolerance limit.
The limit is normally equal to 1e-6. Returns true of the input point lies on the face.

#### Syntax

```
ADEntityPointRelation PointOnFace(
	IADPoint pPoint
)
```

#### Parameters

pPoint  IADPoint
:   The input IADPoint.

#### Return Value

ADEntityPointRelation  
A pre-defined constant that describes the relationship of the point to the face.



# IADEdge.GetExtents Method

Returns Range Box that denotes the max/min of a 3D box for this edge.

#### Syntax

```
void GetExtents(
	out IADPoint ppLower,
	out IADPoint ppUpper
)
```

#### Parameters

ppLower  IADPoint
:   The bottom left corner of the bounding box for this edge.

ppUpper  IADPoint
:   The top right corner of the bounding box for this edge.



# IADPhysicalProperties.GetPrincipalAxis3 Method

Returns the orientation of the third principal axis.

#### Syntax

```
void GetPrincipalAxis3(
	out double pX,
	out double pY,
	out double pZ
)
```

#### Parameters

pX  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   X coordinate of the axis.

pY  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Y coordinate of the axis.

pZ  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Z coordinate of the axis.



# IADSphere.Radius Property

Gets the radius of the sphere.

#### Syntax

```
double Radius { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADCircularArc.Axis Property

Outputs the unit vector perpendicular to the plane of the circular arc according to right hand rule.

#### Syntax

```
IADVector Axis { get; }
```

#### Property Value

IADVector

#### Example

This Visual Basic sample shows how to call the Axis property.

```
Dim objADCircularArc As AlibreX.IADCircularArc
Dim objADVector As AlibreX.IADVector

If objCurve.CurveType = AD_CIRCULAR_ARC Then
    Set objADCircularArc = objCurve
    Set objADVector = objADCircularArc.Axis()
End If
```



# IADVertex.TopologyType Property

Returns a pre-defined constant that identifies the topology type (AD\_VERTEX) of this object.

#### Syntax

```
ADTopologyType TopologyType { get; }
```

#### Property Value

ADTopologyType



# IADLump.Shells Property

Get all the shells in the lump.

#### Syntax

```
IADShells Shells { get; }
```

#### Property Value

IADShells



# IADFace.GetExtents Method

Returns Range Box that denotes the max/min of a 3D box for this face.

#### Syntax

```
void GetExtents(
	out IADPoint ppLower,
	out IADPoint ppUpper
)
```

#### Parameters

ppLower  IADPoint
:   The lower left corner of the bounding box for this face.

ppUpper  IADPoint
:   The upper right corner of the bounding box for this face.



# IADShell Interface

This interface represents the Shell in Alibre Design. A shell is an entire connected
set of faces and/or wires, including connections through a non-manifold vertex.
Typically, a body with a cavity inside has multiple shells.
Hence, shells can represent absence of matter in addition to representing presence of matter.

#### Syntax

```
public interface IADShell
```

The IADShell type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Body | Get the owning body. |
|  | Edges | Get all the edges in the shell. |
|  | Faces | Get all the faces in the shell. |
|  | Lump | Get the owning lump. |
|  | Part | Get the part session owning the body. |
|  | TopologyType | Returns a pre-defined constant that identifies the topology type (AD\_SHELL) of this object. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object. |



# IADBody Properties

The IADBody type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Edges | Returns a collection of all the edges in the body. |
|  | Faces | Returns a collection of all the faces in the body. |
|  | Lumps | Returns a collection of all the lumps in the body. |
|  | Part | Get the part session owning the body. |
|  | Shells | Get all shells in the body. |
|  | TimeStamp | Returns time stamp of this body; the time stamp changes when the body is modified. |
|  | TopologySummary | Returns the topology summary of the body. |
|  | TopologyType | Returns a pre-defined constant that identifies the topology type (AD\_BODY) of this object. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object. |
|  | Vertices | Get all vertices in the body. |



# IADEllipse Interface

IADEllipse interface represents an elliptical curve geometry and can be obtained by typecasting
the Curve Object which is of type AD\_ELLIPSE. This interface defines an ellipse by its center,
a unit normal vector, a major-axis vector, and a double specifying the eccentricity ratio of the ellipse.

#### Syntax

```
public interface IADEllipse : IADCurve
```

The IADEllipse type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Outputs the unit vector perpendicular to the plane of the ellipse according to right hand rule. |
|  | Center | Gets the center point of the ellipse. |
|  | CurveType | Returns a pre-defined constant that identifies the curve type of this object.  (Inherited from IADCurve) |
|  | IsClosed | Returns true if this curve is closed.  (Inherited from IADCurve) |
|  | MajorAxis | Gets length of major axis. |
|  | MinorMajorRatio | Gets the ratio of minor axis ot the major axis. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADCurve) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Curvature | Gets the curvature at the given parameter as a vector.  (Inherited from IADCurve) |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADCurve) |
|  | GetParameterExtents | Gets the Parameter Extents: Start Param and End Param.  (Inherited from IADCurve) |
|  | ParamAtPoint | Gets the parameter at the given point.  (Inherited from IADCurve) |
|  | PointAtParam | Gets the point at the given parameter.  (Inherited from IADCurve) |
|  | Tangent | Gets the tangent at the given parameter.  (Inherited from IADCurve) |



# IADBody.Vertices Property

Get all vertices in the body.

#### Syntax

```
IADVertices Vertices { get; }
```

#### Property Value

IADVertices



# IADBody.TopologySummary Property

Returns the topology summary of the body.

#### Syntax

```
IADTopologySummary TopologySummary { get; }
```

#### Property Value

IADTopologySummary



# IADPlane.Normal Property

Gets the plane's normal.

#### Syntax

```
IADVector Normal { get; }
```

#### Property Value

IADVector



# IADEdge.EndVertex Property

Gets the end vertex of the edge.

#### Syntax

```
IADVertex EndVertex { get; }
```

#### Property Value

IADVertex

#### Remarks

If there is any error, like the edge being unbounded in start direction,
etc. then this property returns null. Also, if the edge has only one vertex, like
in the case of a circle, the end vertex is the same as the start vertex.



# IADBsplineSurface Interface

IADBsplineSurface interface represents a b-spline surface geometry and can be obtained by typecasting the
Surface object which is of type AD\_BSURF. A bspline surface is a b-spline curve swept along
another b-spline curve. Thus a b-spline surface has two parametric directions represented as u and v.

#### Syntax

```
public interface IADBsplineSurface : IADSurface
```

The IADBsplineSurface type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | SurfaceType | Returns a pre-defined constant that identifies the surface type of this object.  (Inherited from IADSurface) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADSurface) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADSurface) |
|  | GetData | Get b-spline surface's data. |
|  | GetDefinition | Get b-spline surface's definition. |
|  | GetFirstDerivative | Gets the first derivative for the given parameter.  (Inherited from IADSurface) |
|  | GetParamAtPoint | Gets the u,v parameters at the given point on the parametric surface.  (Inherited from IADSurface) |
|  | GetParameterExtents | Gets the parameter range in u and v directions.  (Inherited from IADSurface) |
|  | GetRayIntersectionPoint | Returns intersection point and distance from given ray.  (Inherited from IADSurface) |
|  | GetSecondDerivative | Gets the second order derivatives on the parametric surface for the given parameter values. There are three second order derivatives Xuu, Xuv and Xvv.  (Inherited from IADSurface) |
|  | NormalAtParam | Gets the normal to the parametric surface at the point with given parameters.  (Inherited from IADSurface) |
|  | NormalAtPoint | Gets the normal to the surface at the given point.  (Inherited from IADSurface) |
|  | PointAtParam | Gets the point corresponding to the given parameter values on the parametric surface.  (Inherited from IADSurface) |

#### Remarks

As all b-spline surfaces can be represented by NURBS surfaces, this interface returns all
the data pertaining to NURBS. It is possible to check whether the spline surface is actually rational
(NURBS) or non-rational by checking the definition data, which also returns a flag for rationality of the
curve. In addition, the closeness property in both the directions and planarity property of the curve can
also be obtained.

The key parameters required to define a b-spline surafce are knot vectors in u and v directions,
control points(also referred to as poles) and the weights at each of these control points. The order
of the curve is the degree of the curve plus one and hence determines the continuity of the curve. The
knot vector is a sequence of parameter values in ascending order that determine the continuity along the
NURBS curve. The number of knots is always equal to the number of control points plus the order of the
curve in each of the directions. Weights, also called as the homogeneous coordinates, provide extra
blending ability in a b-spline curve. The higher the weights at a control point the higher the
pulling/clamping effect of that control point on the b-spline surface.



# IADShell.Edges Property

Get all the edges in the shell.

#### Syntax

```
IADEdges Edges { get; }
```

#### Property Value

IADEdges



# IADFaces.Session Property

Returns the part session for the collection.

#### Syntax

```
IADPartSession Session { get; }
```

#### Property Value

IADPartSession



# IADSurface.GetFirstDerivative Method

Gets the first derivative for the given parameter.

#### Syntax

```
void GetFirstDerivative(
	double paramU,
	double paramV,
	out IADVector ppVectorU,
	out IADVector ppVectorV
)
```

#### Parameters

paramU  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   u parameter for the point at which the derivative is to be evaluated.

paramV  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   v parameter for the point at which the derivative is to be evaluated.

ppVectorU  IADVector
:   Vector for the first derivative on the parametric surface in u direction.

ppVectorV  IADVector
:   Vector for the first derivative on the parametric surface in v direction.

#### Example

This Visual Basic sample shows how to call the GetFirstDerivative method.

```
Dim objVectorU As AlibreX.IADVector
Dim objVectorV As AlibreX.IADVector
Call objSurface.GetFirstDerivative(0.5, 0.5, objVectorU, objVectorV)
```



# IADEllipse Methods

The IADEllipse type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Curvature | Gets the curvature at the given parameter as a vector.  (Inherited from IADCurve) |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADCurve) |
|  | GetParameterExtents | Gets the Parameter Extents: Start Param and End Param.  (Inherited from IADCurve) |
|  | ParamAtPoint | Gets the parameter at the given point.  (Inherited from IADCurve) |
|  | PointAtParam | Gets the point at the given parameter.  (Inherited from IADCurve) |
|  | Tangent | Gets the tangent at the given parameter.  (Inherited from IADCurve) |



# IADCircle.Radius Property

Gets the radius of circle.

#### Syntax

```
double Radius { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Example

This Visual Basic sample shows how to call the Radius property.

```
Dim objADCircle As AlibreX.IADCircle

If objCurve.CurveType = AD_CIRCLE Then
    Set objADCircle = objCurve
    Debug.Print objADCircle.Radius
End If
```



# IADSurface Properties

The IADSurface type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | SurfaceType | Returns a pre-defined constant that identifies the surface type of this object. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY) |



# IADCoedge.Edge Property

Each coedge is associated with an edge and is basically a representative for that edge in
a loop. This method returns that underlying edge for this coedge.

#### Syntax

```
IADEdge Edge { get; }
```

#### Property Value

IADEdge



# IADLump.Part Property

Get the part session owning the lump.

#### Syntax

```
IADPartSession Part { get; }
```

#### Property Value

IADPartSession



# IADVertex.Edges Property

A vertex can belong to more than one edge. This property returns all the edges which are incident on this vertex.

#### Syntax

```
IADEdges Edges { get; }
```

#### Property Value

IADEdges



# IADFace.FacetData Method

Returns triangular mesh data for the face given the maximum deviation of a facet from the surface.

#### Syntax

```
Array FacetData(
	double surfaceTol
)
```

#### Parameters

surfaceTol  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The maximum deviation of a facet from the surface.

#### Return Value

[Array](https://learn.microsoft.com/dotnet/api/system.array)  
A double array of the triangular mesh data for the face.

#### Remarks

The array contains triplets of double values representing (x,y,z) co-ordinates
corresponding to triangle vertices.



# IADCircle Properties

The IADCircle type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Gets the unit vector perpendicular to the plane of the circle according to right hand rule. |
|  | Center | Gets the center point of the circle. |
|  | CurveType | Returns a pre-defined constant that identifies the curve type of this object.  (Inherited from IADCurve) |
|  | IsClosed | Returns true if this curve is closed.  (Inherited from IADCurve) |
|  | Radius | Gets the radius of circle. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADCurve) |



# IADEllipticalArc Properties

The IADEllipticalArc type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Outputs the unit vector perpendicular to the plane of the elliptical arc according to the right hand rule. |
|  | Center | Gets the center point of the elliptical arc. |
|  | CurveType | Returns a pre-defined constant that identifies the curve type of this object.  (Inherited from IADCurve) |
|  | End | Returns the end point of the elliptical arc. |
|  | IsClosed | Returns true if this curve is closed.  (Inherited from IADCurve) |
|  | MajorAxis | Gets the length of the major axis. |
|  | MinorMajorRatio | Gets the ratio of the minor axis to the major axis. |
|  | Start | Returns the start point of the elliptical arc. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADCurve) |



# IADBsplineCurve Properties

The IADBsplineCurve type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CurveType | Returns a pre-defined constant that identifies the curve type of this object.  (Inherited from IADCurve) |
|  | IsClosed | Returns true if this curve is closed.  (Inherited from IADCurve) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADCurve) |



# IADCircularArc Methods

The IADCircularArc type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Curvature | Gets the curvature at the given parameter as a vector.  (Inherited from IADCurve) |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADCurve) |
|  | GetParameterExtents | Gets the Parameter Extents: Start Param and End Param.  (Inherited from IADCurve) |
|  | ParamAtPoint | Gets the parameter at the given point.  (Inherited from IADCurve) |
|  | PointAtParam | Gets the point at the given parameter.  (Inherited from IADCurve) |
|  | Tangent | Gets the tangent at the given parameter.  (Inherited from IADCurve) |



# IADVertex.Faces Property

A vertex can belong to more than one face. This property returns all the faces which are incident on this vertex.

#### Syntax

```
IADFaces Faces { get; }
```

#### Property Value

IADFaces



# IADCone.BasePoint Property

Gets the center point of the circle at the bottom of the cone.

#### Syntax

```
IADPoint BasePoint { get; }
```

#### Property Value

IADPoint

#### Example

This Visual Basic sample shows how to get the BasePoint property.

```
Dim objADCylinder As AlibreX.IADCylinder
Dim objADPoint As AlibreX.IADPoint

If objSurface.SurfaceType = AD_CYLINDER Then
    Set objADCylinder = objSurface
    Set objADPoint = objADCylinder.BasePoint()
End If
```



# IADSurface Methods

The IADSurface type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetClosestPoint | Returns closest point and distance from given point. |
|  | GetFirstDerivative | Gets the first derivative for the given parameter. |
|  | GetParamAtPoint | Gets the u,v parameters at the given point on the parametric surface. |
|  | GetParameterExtents | Gets the parameter range in u and v directions. |
|  | GetRayIntersectionPoint | Returns intersection point and distance from given ray. |
|  | GetSecondDerivative | Gets the second order derivatives on the parametric surface for the given parameter values. There are three second order derivatives Xuu, Xuv and Xvv. |
|  | NormalAtParam | Gets the normal to the parametric surface at the point with given parameters. |
|  | NormalAtPoint | Gets the normal to the surface at the given point. |
|  | PointAtParam | Gets the point corresponding to the given parameter values on the parametric surface. |



# IADFace.AppearanceID Property

Returns the appearance id for this face.

#### Syntax

```
string AppearanceID { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADEllipticalArc.Start Property

Returns the start point of the elliptical arc.

#### Syntax

```
IADPoint Start { get; }
```

#### Property Value

IADPoint

#### Example

This Visual Basic sample shows how to call the Start property.

```
Dim objADEllipticalArc As AlibreX.IADEllipticalArc
Dim objADPoint As AlibreX.IADPoint

If objCurve.CurveType = AD_ELLIPTICAL_ARC Then
    Set objADEllipticalArc = objCurve
    Set objADPoint = objADEllipticalArc.Start()
End If
```



# IADLumps.Session Property

Returns the part session for the collection.

#### Syntax

```
IADPartSession Session { get; }
```

#### Property Value

IADPartSession



# IADSurface.GetParameterExtents Method

Gets the parameter range in u and v directions.

#### Syntax

```
void GetParameterExtents(
	out double pUmin,
	out double pUmax,
	out double pVmin,
	out double pVmax
)
```

#### Parameters

pUmin  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Start parameter value in u - direction.

pUmax  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   End parameter value in u - direction.

pVmin  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Start parameter value in v - direction.

pVmax  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   End parameter value in v - direction.

#### Remarks

For a periodic surface, the principal parameter range is returned. A periodic
surface is defined for all parameter values in the periodic direction by reducing the
given parameter modulo the period into this principle range. For a surface that is open
or non-periodic in the chosen direction, the surface evaluation functions are defined only
for the parameter values in the returned range.

#### Example

This Visual Basic sample shows how to call the GetParameterExtents method.

```
Dim dblMinU As Double
Dim dblMaxU As Double
Dim dblMinV As Double
Dim dblMaxV As Double

Call objSurface.GetParameterExtents(dblMinU, dblMaxU, dblMinV, dblMaxV)
```



# IADTorus.MajorRadius Property

Gets the radius of the circular spine curve of the torus.

#### Syntax

```
double MajorRadius { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

This is normally positive, but it can be negative (and smaller in magnitude than the minor
radius) for the inner portion (i.e., a lemon as opposed to an apple).



# IADSurface.Type Property

Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADEllipse.Center Property

Gets the center point of the ellipse.

#### Syntax

```
IADPoint Center { get; }
```

#### Property Value

IADPoint

#### Example

This Visual Basic sample shows how to call the Center property.

```
Dim objADEllipse As AlibreX.IADEllipse
Dim objADPoint As AlibreX.IADPoint

If objCurve.CurveType = AD_ELLIPSE Then
    Set objADEllipse = objCurve
    Set objADPoint = objADEllipse.Center()
End If
```



# IADCone Methods

The IADCone type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADSurface) |
|  | GetFirstDerivative | Gets the first derivative for the given parameter.  (Inherited from IADSurface) |
|  | GetParamAtPoint | Gets the u,v parameters at the given point on the parametric surface.  (Inherited from IADSurface) |
|  | GetParameterExtents | Gets the parameter range in u and v directions.  (Inherited from IADSurface) |
|  | GetRayIntersectionPoint | Returns intersection point and distance from given ray.  (Inherited from IADSurface) |
|  | GetSecondDerivative | Gets the second order derivatives on the parametric surface for the given parameter values. There are three second order derivatives Xuu, Xuv and Xvv.  (Inherited from IADSurface) |
|  | NormalAtParam | Gets the normal to the parametric surface at the point with given parameters.  (Inherited from IADSurface) |
|  | NormalAtPoint | Gets the normal to the surface at the given point.  (Inherited from IADSurface) |
|  | PointAtParam | Gets the point corresponding to the given parameter values on the parametric surface.  (Inherited from IADSurface) |



# IADEdges.Count Property

Returns the number of edges in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADCircle Interface

IADCircle interface represents a circular curve geometry and can be obtained by typecasting
the Curve Object which is of type AD\_CIRCLE. This interface defines a circle by the center point,
radius and the normal unit vector perpendicular to the plane of the circle.

#### Syntax

```
public interface IADCircle : IADCurve
```

The IADCircle type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Gets the unit vector perpendicular to the plane of the circle according to right hand rule. |
|  | Center | Gets the center point of the circle. |
|  | CurveType | Returns a pre-defined constant that identifies the curve type of this object.  (Inherited from IADCurve) |
|  | IsClosed | Returns true if this curve is closed.  (Inherited from IADCurve) |
|  | Radius | Gets the radius of circle. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADCurve) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Curvature | Gets the curvature at the given parameter as a vector.  (Inherited from IADCurve) |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADCurve) |
|  | GetParameterExtents | Gets the Parameter Extents: Start Param and End Param.  (Inherited from IADCurve) |
|  | ParamAtPoint | Gets the parameter at the given point.  (Inherited from IADCurve) |
|  | PointAtParam | Gets the point at the given parameter.  (Inherited from IADCurve) |
|  | Tangent | Gets the tangent at the given parameter.  (Inherited from IADCurve) |



# IADFaces Properties

The IADFaces type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of faces in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the part session for the collection. |



# IADCurve Methods

The IADCurve type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Curvature | Gets the curvature at the given parameter as a vector. |
|  | GetClosestPoint | Returns closest point and distance from given point. |
|  | GetParameterExtents | Gets the Parameter Extents: Start Param and End Param. |
|  | ParamAtPoint | Gets the parameter at the given point. |
|  | PointAtParam | Gets the point at the given parameter. |
|  | Tangent | Gets the tangent at the given parameter. |



# IADVertex.Type Property

Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADCylinder.BasePoint Property

Gets the center point of the circle at the bottom of the cylinder.

#### Syntax

```
IADPoint BasePoint { get; }
```

#### Property Value

IADPoint

#### Example

This Visual Basic sample shows how to get the BasePoint property.

```
Dim objADCone As AlibreX.IADCone
Dim objADPoint As AlibreX.IADPoint

If objSurface.SurfaceType = AD_CONE Then
    Set objADCone = objSurface
    Set objADPoint = objADCone.BasePoint()
End If
```



# IADCurve.CurveType Property

Returns a pre-defined constant that identifies the curve type of this object.

#### Syntax

```
ADGeometryType CurveType { get; }
```

#### Property Value

ADGeometryType

#### Remarks

Possible values for this property and their corresponding types include:

- AD\_LINE
- AD\_CIRCLE
- AD\_CIRCULAR\_ARC
- AD\_ELLIPSE
- AD\_ELLIPTICAL\_ARC
- AD\_BSPLINE



# IADShells Interface

This interface represents the collection of all the shells in a Body/Lump.
A shell is an entire connected set of faces and/or wires, including connections
through a non-manifold vertex. Faces are connected together along common edges
or at common vertices; wires may be connected to faces at end vertices.

#### Syntax

```
public interface IADShells
```

The IADShells type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of shells in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the part session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding shell. |

#### Remarks

A solid block with a dangling sheet is one shell, but a block with
a cavity is two shells. A solid block with many embedded faces that are all
connected through some path to the exterior faces is one shell, but a solid block
with a disconnected "floating" embedded face is two shells (but one lump).

It is possible to obtain this collection of shells by querying the property
Shells on IADBody or on IADLump
.



# IADEdge.Faces Property

Get all faces sharing this edge.

#### Syntax

```
IADFaces Faces { get; }
```

#### Property Value

IADFaces



# IADLumps Methods

The IADLumps type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding lump. |



# IADCoedge.Body Property

Get the owning body.

#### Syntax

```
IADBody Body { get; }
```

#### Property Value

IADBody



# IADCurve.Curvature Method

Gets the curvature at the given parameter as a vector.

#### Syntax

```
IADVector Curvature(
	double pParam
)
```

#### Parameters

pParam  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Parameter value at which to perform the evaluation.

#### Return Value

IADVector  
Returns IADVector

#### Example

This Visual Basic sample shows how to call the Curvature method.

```
Dim objADVector As AlibreX.IADVector
Set objADVector = objCurve.Curvature(0.5)
```



# IADBody Interface

This interface represents the Body in Alibre Design. This is the topmost level topological entity.

#### Syntax

```
public interface IADBody
```

The IADBody type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Edges | Returns a collection of all the edges in the body. |
|  | Faces | Returns a collection of all the faces in the body. |
|  | Lumps | Returns a collection of all the lumps in the body. |
|  | Part | Get the part session owning the body. |
|  | Shells | Get all shells in the body. |
|  | TimeStamp | Returns time stamp of this body; the time stamp changes when the body is modified. |
|  | TopologySummary | Returns the topology summary of the body. |
|  | TopologyType | Returns a pre-defined constant that identifies the topology type (AD\_BODY) of this object. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object. |
|  | Vertices | Get all vertices in the body. |



# IADFace.GetColorForConfiguration Method

Returns the color applied to this face for a given configuration.
This color can be the color applied using the feature color or the face color feature.

#### Syntax

```
int GetColorForConfiguration(
	IADConfiguration pConfiguration
)
```

#### Parameters

pConfiguration  IADConfiguration

#### Return Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADCoedge Interface

This interface represents the Coedge in Alibre Design. A coedge records the occurrence of
an edge in a loop of a face. The introduction of coedges permits edges to occur in one, two
or more faces, and so makes possible the modeling of sheets and solids (manifold or not).
A loop refers to one coedge in the loop, from which pointers lead to the other coedges of the
loop. Coedges in a loop are ordered in a continuous path around the loop and are doubly-linked.
If a loop is not a circular list, the loop points to the first coedge.

#### Syntax

```
public interface IADCoedge
```

The IADCoedge type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Body | Get the owning body. |
|  | Edge | Each coedge is associated with an edge and is basically a representative for that edge in a loop. This method returns that underlying edge for this coedge. |
|  | IsSenseReversed | Returns the sense of the coedge with respect to the underlying edge. It returns true if the direction of the underlying edge and coedge are in opposite direction. |
|  | Loop | Gets the loop of the coedge. |
|  | Part | Get the part session owning the body. |
|  | PartnerCoedge | An edge can be associated with more than one face and is represented by a coedge in all these faces. Hence, the partner coedge gives the coedge for the same edge on other face. |
|  | TopologyType | Returns a pre-defined constant that identifies the topology type (AD\_COEDGE) of this object. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object. |



# IADEllipticalArc Interface

IADEllipticalArc interface represents an elliptical arc geometry and can be obtained by
typecasting the Curve Object which is of type AD\_ELLIPTICAL\_ARC. This interface defines
an elliptical arc by its center, a unit normal vector, a major-axis vector, and a double
specifying the eccentricity ratio of the ellipse and the start and the end points of the arc.

#### Syntax

```
public interface IADEllipticalArc : IADCurve
```

The IADEllipticalArc type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Outputs the unit vector perpendicular to the plane of the elliptical arc according to the right hand rule. |
|  | Center | Gets the center point of the elliptical arc. |
|  | CurveType | Returns a pre-defined constant that identifies the curve type of this object.  (Inherited from IADCurve) |
|  | End | Returns the end point of the elliptical arc. |
|  | IsClosed | Returns true if this curve is closed.  (Inherited from IADCurve) |
|  | MajorAxis | Gets the length of the major axis. |
|  | MinorMajorRatio | Gets the ratio of the minor axis to the major axis. |
|  | Start | Returns the start point of the elliptical arc. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADCurve) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Curvature | Gets the curvature at the given parameter as a vector.  (Inherited from IADCurve) |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADCurve) |
|  | GetParameterExtents | Gets the Parameter Extents: Start Param and End Param.  (Inherited from IADCurve) |
|  | ParamAtPoint | Gets the parameter at the given point.  (Inherited from IADCurve) |
|  | PointAtParam | Gets the point at the given parameter.  (Inherited from IADCurve) |
|  | Tangent | Gets the tangent at the given parameter.  (Inherited from IADCurve) |



# IADFace.Color Property

Returns the color applied to this face for the active configuration.
This color can be the color applied using the feature color or the face color feature.

#### Syntax

```
int Color { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADCone.Radius Property

Gets the radius of the bottom face of the cone.

#### Syntax

```
double Radius { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Example

This Visual Basic sample shows how to get the Radius property.

```
Dim objADCylinder As AlibreX.IADCylinder

If objSurface.SurfaceType = AD_CYLINDER Then
    Set objADCylinder = objSurface
    Debug.Print objADCylinder.BasePoint()
End If
```



# IADEllipse.MinorMajorRatio Property

Gets the ratio of minor axis ot the major axis.

#### Syntax

```
double MinorMajorRatio { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Example

This Visual Basic sample shows how to call the MinorMajorRatio property.

```
Dim objADEllipse As AlibreX.IADEllipse

If objCurve.CurveType = AD_ELLIPSE Then
    Set objADEllipse = objCurve
    Debug.Print objADEllipse.MinorMajorRatio()
End If
```



# IADLump Properties

The IADLump type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Body | Get the owning body for this lump. |
|  | Edges | Get all the edges in the lump. |
|  | Faces | Get all the faces in the lump. |
|  | Part | Get the part session owning the lump. |
|  | Shells | Get all the shells in the lump. |
|  | TopologyType | Returns a pre-defined constant that identifies the topology type (AD\_LUMP) of this object. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object. |



# IADCurve.ParamAtPoint Method

Gets the parameter at the given point.

#### Syntax

```
double ParamAtPoint(
	IADPoint pPoint
)
```

#### Parameters

pPoint  IADPoint
:   The position for which the parameter value is to be found.

#### Return Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)  
Returns the parameter as a double value.

#### Example

This Visual Basic sample shows how to call the ParamAtPoint method.

```
Dim objADPoint As AlibreX.IADPoint
Set objADPoint = objCurve.PointAtParam(0.5)

Dim dblU As Double
dblU = objCurve.ParamAtPoint(objADPoint)
```



# IADLoops.Count Property

Returns the number of loops in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADSurface.GetSecondDerivative Method

Gets the second order derivatives on the parametric surface for the given parameter values. There are three second order derivatives Xuu, Xuv and Xvv.

#### Syntax

```
void GetSecondDerivative(
	double paramU,
	double paramV,
	out IADVector ppVectorUU,
	out IADVector ppVectorUV,
	out IADVector ppVectorVV
)
```

#### Parameters

paramU  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   u parameter for the point at which the derivative is to be evaluated.

paramV  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   u parameter for the point at which the derivative is to be evaluated.

ppVectorUU  IADVector
:   Vector for the derivative corresponding to Xuu.

ppVectorUV  IADVector
:   Vector for the derivative corresponding to Xuv.

ppVectorVV  IADVector
:   Vector for the derivative corresponding to Xvv.

#### Example

This Visual Basic sample shows how to call the GetSecondDerivative method.

```
Dim objVectorUU As AlibreX.IADVector
Dim objVectorUV As AlibreX.IADVector
Dim objVectorVV As AlibreX.IADVector
Call objSurface.GetSecondDerivative(0.5, 0.5, objVectorUU, objVectorUV, objVectorVV)
```



# IADBsplineCurve.GetData Method

Get the spline data.

#### Syntax

```
void GetData(
	out Array pKnots,
	out Array pPoles,
	out Array pWeights
)
```

#### Parameters

pKnots  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   Array of knot values. These are always in ascending order.
    It determines the degree of the b-spline curve.

pPoles  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   Coordinates of the control points for the b-spline curve.
    Hence its size is equal to three times the number of control points.

pWeights  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   Array of weights at each of the control points.

#### Remarks

B-Spline data is represented in the form of NURBS representation.
The knot vector is a sequence of parameter values that determine the continuity along the NURBS curve.
The number of knots is always equal to the number of control points plus the order of the curve.
The poles are the coordinates of the control points and weights are the homogeneous coordinates
which provide extra blending ability. The higher the weights at a control point the higher the
pulling/clamping effect of that control point on the b-spline curve.

To initialize an array of the correct size to pass to this function, use the
GetDefinition method to first determine the number of poles, etc.

#### Example

This Visual Basic sample demonstrates usage of the GetData method.

```
' Holds Order of Bspline curve
Dim lngOrder As Long

' Holds Poles count
Dim lngNumPoles As Long

' Holds Knots count
Dim lngNumKnots As Long

' Holds IsRational Flag
Dim blnIsRational As Boolean

' Holds IsClosed Flag
Dim blnIsClosed As Boolean

' Holds IsPlanar Flag
Dim blnIsPlanar As Boolean

' Get Bspline Definition
Call objADBsplineCurve.GetDefinition( _
                    lngOrder, _
                    lngNumPoles, _
                    lngNumKnots, _

                    blnIsRational, _
                    blnIsClosed, _
                    blnIsPlanar)

' Holds Knots array
Dim a_dblKnots() As Double

' Holds Poles array
Dim a_dblPoles() As Double

' Holds Weights array
Dim a_dblWeights() As Double

' Allocate memory using information from GetDefinition() 
ReDim a_dblKnots(lngNumKnots - 1) As Double
ReDim a_dblPoles(lngNumPoles * 3 - 1) As Double
ReDim a_dblWeights(lngNumPoles - 1) As Double

' Get Bspline Data

Call objADBsplineCurve.GetData( _
                    a_dblKnots(), _
                    a_dblPoles(), _
                    a_dblWeights())
```



# IADFace.IsSenseReversed Property

Returns the sense of the face with respect to the underlying surface.
It returns true if the normals of the underlying surface and face are in opposite direction.

#### Syntax

```
bool IsSenseReversed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADCoedge.TopologyType Property

Returns a pre-defined constant that identifies the topology type (AD\_COEDGE) of this object.

#### Syntax

```
ADTopologyType TopologyType { get; }
```

#### Property Value

ADTopologyType



# IADFace.GetMeshData Method

Returns the raw mesh data for the face given the maximum deviation of a facet from the surface.

#### Syntax

```
void GetMeshData(
	double surfaceTol,
	double normalTol,
	double maxEdgeLength,
	out Array faceArray,
	out Array normalArray,
	out Array vertexArray
)
```

#### Parameters

surfaceTol  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The maximum deviation of a facet from the surface.

normalTol  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The maximum angle (in degrees) between surface normals at points on a facet.

maxEdgeLength  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Maximum length of the facet edge.

faceArray  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   The face indicies representing the vertices for each facet.

normalArray  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   The vertex normals of each vertex points.

vertexArray  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   The vertices array which has unique vertex points represented by a triplet for (x,y,z).



# IADSurface.SurfaceType Property

Returns a pre-defined constant that identifies the surface type of this object.

#### Syntax

```
ADGeometryType SurfaceType { get; }
```

#### Property Value

ADGeometryType

#### Remarks

Possible values for this property and their corresponding types include:

- AD\_PLANE
- AD\_CYLINDER
- AD\_CONE
- AD\_SPHERE
- AD\_TORUS
- AD\_BSURF



# IADPhysicalProperties Interface

IADPhysicalProperties is an interface for physical properties that are associated with the
design. These properties include the Number of faces, Number
of edges, Number of vertices, Volume, Mass, Center of mass, etc., of the design.

#### Syntax

```
public interface IADPhysicalProperties
```

The IADPhysicalProperties type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgesCount | Returns the number of edges in design. If the design is an Assembly, then number of edges returned is the total number of edges in all the parts in the assembly. |
|  | FacesCount | Returns the number of faces in design. If the design is an Assembly, then number of faces returned is the total number of faces in all the parts in the assembly. |
|  | LumpsCount | Returns the number of lumps in design. If the design is an Assembly, then number of lumps returned is the total number of lumps in all the parts in the assembly. |
|  | Mass | Returns the mass of the design. |
|  | Material | Returns name of the material used for the design. |
|  | PartsCount | Returns the number of parts in design. For a part design, it would be just 1. |
|  | SurfaceArea | Returns the surface-area of design. |
|  | UniquePartsCount | Returns the number of unique parts in design. For a part design, it would be just 1. |
|  | VerticesCount | Returns the number of vertices in design. If the design is an Assembly, then number of vertices returned is the total number of vertices in all the parts in the assembly. |
|  | Volume | Returns the volume of design. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetCenterOfGravity | Returns the X, Y and Z coordinates of the center of gravity. |
|  | GetExtents | Returns the range box that denotes the max/min of a 3D box surrounding the design. |
|  | GetMomentsOfInertia | Returns the XX, YY, ZZ, YZ, ZX, XY values of the moment of inertia. |
|  | GetPrincipalAxis1 | Returns the orientation of the first principal axis. |
|  | GetPrincipalAxis2 | Returns the orientation of the second principal axis. |
|  | GetPrincipalAxis3 | Returns the orientation of the third principal axis. |
|  | GetPrincipalMomentsOfInertia | Returns the principal moments of inertia. |



# IADSphere Interface

IADSphere interface represents a spherical surface geometry and can be obtained by
typecasting the Surface Object which is of type AD\_SPHERE.
A sphere is defined by the center and the radius.

#### Syntax

```
public interface IADSphere : IADSurface
```

The IADSphere type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Center | Gets the center point of the sphere. |
|  | Radius | Gets the radius of the sphere. |
|  | SurfaceType | Returns a pre-defined constant that identifies the surface type of this object.  (Inherited from IADSurface) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADSurface) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADSurface) |
|  | GetFirstDerivative | Gets the first derivative for the given parameter.  (Inherited from IADSurface) |
|  | GetParamAtPoint | Gets the u,v parameters at the given point on the parametric surface.  (Inherited from IADSurface) |
|  | GetParameterExtents | Gets the parameter range in u and v directions.  (Inherited from IADSurface) |
|  | GetRayIntersectionPoint | Returns intersection point and distance from given ray.  (Inherited from IADSurface) |
|  | GetSecondDerivative | Gets the second order derivatives on the parametric surface for the given parameter values. There are three second order derivatives Xuu, Xuv and Xvv.  (Inherited from IADSurface) |
|  | NormalAtParam | Gets the normal to the parametric surface at the point with given parameters.  (Inherited from IADSurface) |
|  | NormalAtPoint | Gets the normal to the surface at the given point.  (Inherited from IADSurface) |
|  | PointAtParam | Gets the point corresponding to the given parameter values on the parametric surface.  (Inherited from IADSurface) |



# IADPhysicalProperties.Mass Property

Returns the mass of the design.

#### Syntax

```
double Mass { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADBody.TimeStamp Property

Returns time stamp of this body; the time stamp changes when the body is modified.

#### Syntax

```
int TimeStamp { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

This is not a time stamp in the sense of giving the time at which the body was last modified,
but rather an int which can quickly be compared to the previous value to determine if the body has changed.
By using this property, more performance-costly query of the body can be avoided when it is unnecessary.



# IADEdge.TimeStamp Property

Returns time stamp of this edge; the time stamp changes when the edge is modified.

#### Syntax

```
int TimeStamp { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

This is not a time stamp in the sense of giving the time at which the edge was last modified,
but rather an int which can quickly be compared to the previous value to determine if the edge has changed.
By using this property, more performance-costly query of the edge can be avoided when it is unnecessary.



# IADVertex.Point Property

A vertex is a topological entity on top of a point. This property gets that underlying point.

#### Syntax

```
IADPoint Point { get; }
```

#### Property Value

IADPoint



# IADSphere.Center Property

Gets the center point of the sphere.

#### Syntax

```
IADPoint Center { get; }
```

#### Property Value

IADPoint



# IADCoedges Methods

The IADCoedges type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding Co-edge. |



# IADSphere Methods

The IADSphere type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADSurface) |
|  | GetFirstDerivative | Gets the first derivative for the given parameter.  (Inherited from IADSurface) |
|  | GetParamAtPoint | Gets the u,v parameters at the given point on the parametric surface.  (Inherited from IADSurface) |
|  | GetParameterExtents | Gets the parameter range in u and v directions.  (Inherited from IADSurface) |
|  | GetRayIntersectionPoint | Returns intersection point and distance from given ray.  (Inherited from IADSurface) |
|  | GetSecondDerivative | Gets the second order derivatives on the parametric surface for the given parameter values. There are three second order derivatives Xuu, Xuv and Xvv.  (Inherited from IADSurface) |
|  | NormalAtParam | Gets the normal to the parametric surface at the point with given parameters.  (Inherited from IADSurface) |
|  | NormalAtPoint | Gets the normal to the surface at the given point.  (Inherited from IADSurface) |
|  | PointAtParam | Gets the point corresponding to the given parameter values on the parametric surface.  (Inherited from IADSurface) |



# IADFace.Key Property

Gets the Persistent Key property of this face. This Key is unique for
this face and can be used to access the face.

#### Syntax

```
Array Key { get; }
```

#### Property Value

[Array](https://learn.microsoft.com/dotnet/api/system.array)



# IADEdge.StartVertex Property

Gets the start vertex of the edge.

#### Syntax

```
IADVertex StartVertex { get; }
```

#### Property Value

IADVertex

#### Remarks

If there is any error, like the edge being unbounded in start direction,
etc. then this property returns null.



# IADVertices Methods

The IADVertices type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding vertex. |



# IADCylinder Methods

The IADCylinder type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADSurface) |
|  | GetFirstDerivative | Gets the first derivative for the given parameter.  (Inherited from IADSurface) |
|  | GetParamAtPoint | Gets the u,v parameters at the given point on the parametric surface.  (Inherited from IADSurface) |
|  | GetParameterExtents | Gets the parameter range in u and v directions.  (Inherited from IADSurface) |
|  | GetRayIntersectionPoint | Returns intersection point and distance from given ray.  (Inherited from IADSurface) |
|  | GetSecondDerivative | Gets the second order derivatives on the parametric surface for the given parameter values. There are three second order derivatives Xuu, Xuv and Xvv.  (Inherited from IADSurface) |
|  | NormalAtParam | Gets the normal to the parametric surface at the point with given parameters.  (Inherited from IADSurface) |
|  | NormalAtPoint | Gets the normal to the surface at the given point.  (Inherited from IADSurface) |
|  | PointAtParam | Gets the point corresponding to the given parameter values on the parametric surface.  (Inherited from IADSurface) |



# IADPhysicalProperties.Material Property

Returns name of the material used for the design.

#### Syntax

```
string Material { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPhysicalProperties.SurfaceArea Property

Returns the surface-area of design.

#### Syntax

```
double SurfaceArea { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADLine.StartPoint Property

Gets the starting point of the line.

#### Syntax

```
IADPoint StartPoint { get; }
```

#### Property Value

IADPoint

#### Example

This Visual Basic sample shows how to call the StartPoint property.

```
Dim objADLine As AlibreX.IADLine
Dim objADPoint As AlibreX.IADPoint

If objCurve.CurveType = AD_LINE Then
    Set objADLine = objCurve
    Set objADPoint = objADLine.StartPoint()
End If
```



# IADBody.Shells Property

Get all shells in the body.

#### Syntax

```
IADShells Shells { get; }
```

#### Property Value

IADShells



# IADPhysicalProperties.GetPrincipalAxis2 Method

Returns the orientation of the second principal axis.

#### Syntax

```
void GetPrincipalAxis2(
	out double pX,
	out double pY,
	out double pZ
)
```

#### Parameters

pX  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   X coordinate of the axis.

pY  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Y coordinate of the axis.

pZ  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Z coordinate of the axis.



# IADEdge.Part Property

Get the part session owning the body.

#### Syntax

```
IADPartSession Part { get; }
```

#### Property Value

IADPartSession



# IADCone.HalfAngle Property

Gets the half angle for the cone.

#### Syntax

```
double HalfAngle { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADFaces Interface

This interface represents the collection of faces. A face is a bounded portion of single surface.

#### Syntax

```
public interface IADFaces
```

The IADFaces type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of faces in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the part session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding face. |

#### Remarks

It is possible to obtain this collection of faces by querying the property Faces
on interfaces IADBody, IADLump or
IADShell object.



# IADCoedge.IsSenseReversed Property

Returns the sense of the coedge with respect to the underlying edge.
It returns true if the direction of the underlying edge and coedge are in opposite direction.

#### Syntax

```
bool IsSenseReversed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADEdge Properties

The IADEdge type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Body | Get the owning body. |
|  | EndVertex | Gets the end vertex of the edge. |
|  | Faces | Get all faces sharing this edge. |
|  | Geometry | Get the curve geometry associated with this edge. |
|  | IsSenseReversed | Returns the sense of the edge with respect to the underlying curve. It returns true if the direction of the underlying curve and the edge are in opposite direction. |
|  | Key | Gets the Persistent Key property of this Edge. This Key is unique for this Edge and can be used to access the edge. |
|  | Part | Get the part session owning the body. |
|  | StartVertex | Gets the start vertex of the edge. |
|  | TimeStamp | Returns time stamp of this edge; the time stamp changes when the edge is modified. |
|  | TopologyType | Returns a pre-defined constant that identifies the topology type (AD\_EDGE) of this object. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object. |



# IADCylinder Interface

IADCylinder interface represents a cylindrical surface geometry and can be obtained by typecasting
the Surface Object which is of type AD\_CYLINDER. The cylinder
is defined by the axis, a point on the bottom circle of the cylinder and the radius.

#### Syntax

```
public interface IADCylinder : IADSurface
```

The IADCylinder type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Gets a vector along the cylinder's height whose magnitude measures the cylinder's height. |
|  | BasePoint | Gets the center point of the circle at the bottom of the cylinder. |
|  | Radius | Gets the radius of the cylinder. |
|  | SurfaceType | Returns a pre-defined constant that identifies the surface type of this object.  (Inherited from IADSurface) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADSurface) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADSurface) |
|  | GetFirstDerivative | Gets the first derivative for the given parameter.  (Inherited from IADSurface) |
|  | GetParamAtPoint | Gets the u,v parameters at the given point on the parametric surface.  (Inherited from IADSurface) |
|  | GetParameterExtents | Gets the parameter range in u and v directions.  (Inherited from IADSurface) |
|  | GetRayIntersectionPoint | Returns intersection point and distance from given ray.  (Inherited from IADSurface) |
|  | GetSecondDerivative | Gets the second order derivatives on the parametric surface for the given parameter values. There are three second order derivatives Xuu, Xuv and Xvv.  (Inherited from IADSurface) |
|  | NormalAtParam | Gets the normal to the parametric surface at the point with given parameters.  (Inherited from IADSurface) |
|  | NormalAtPoint | Gets the normal to the surface at the given point.  (Inherited from IADSurface) |
|  | PointAtParam | Gets the point corresponding to the given parameter values on the parametric surface.  (Inherited from IADSurface) |

#### Remarks

Note that the cylinder does not include the end caps. The magnitude of the axis gives the
height of the cylinder.



# IADTorus.Axis Property

Gets the normal of the torus.

#### Syntax

```
IADVector Axis { get; }
```

#### Property Value

IADVector

#### Remarks

A torus is defined as a circular spine and a circular cross-section at each point on the
spine. The normal of the torus is the normal to the plane of the circular spine.



# IADCircle Methods

The IADCircle type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Curvature | Gets the curvature at the given parameter as a vector.  (Inherited from IADCurve) |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADCurve) |
|  | GetParameterExtents | Gets the Parameter Extents: Start Param and End Param.  (Inherited from IADCurve) |
|  | ParamAtPoint | Gets the parameter at the given point.  (Inherited from IADCurve) |
|  | PointAtParam | Gets the point at the given parameter.  (Inherited from IADCurve) |
|  | Tangent | Gets the tangent at the given parameter.  (Inherited from IADCurve) |



# IADPhysicalProperties.GetPrincipalAxis1 Method

Returns the orientation of the first principal axis.

#### Syntax

```
void GetPrincipalAxis1(
	out double pX,
	out double pY,
	out double pZ
)
```

#### Parameters

pX  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   X coordinate of the axis.

pY  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Y coordinate of the axis.

pZ  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Z coordinate of the axis.



# IADShell.Body Property

Get the owning body.

#### Syntax

```
IADBody Body { get; }
```

#### Property Value

IADBody



# IADEllipticalArc.End Property

Returns the end point of the elliptical arc.

#### Syntax

```
IADPoint End { get; }
```

#### Property Value

IADPoint

#### Example

This Visual Basic sample shows how to call the End property.

```
Dim objADEllipticalArc As AlibreX.IADEllipticalArc
Dim objADPoint As AlibreX.IADPoint

If objCurve.CurveType = AD_ELLIPTICAL_ARC Then
    Set objADEllipticalArc = objCurve
    Set objADPoint = objADEllipticalArc.End()
End If
```



# IADShell.Faces Property

Get all the faces in the shell.

#### Syntax

```
IADFaces Faces { get; }
```

#### Property Value

IADFaces



# IADEllipticalArc.MajorAxis Property

Gets the length of the major axis.

#### Syntax

```
double MajorAxis { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Example

This Visual Basic sample shows how to call the MajorAxis property.

```
Dim objADEllipticalArc As AlibreX.IADEllipticalArc

If objCurve.CurveType = AD_ELLIPTICAL_ARC Then
    Set objADEllipticalArc = objCurve
    Debug.Print objADEllipticalArc.MajorAxis()
End If
```



# IADCurve.GetParameterExtents Method

Gets the Parameter Extents: Start Param and End Param.

#### Syntax

```
void GetParameterExtents(
	out double pParamMin,
	out double pParamMax
)
```

#### Parameters

pParamMin  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Start parameter value

pParamMax  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   End parameter value

#### Remarks

For a periodic curve the param range is the principal param range and
the evaluation methods reduce the given parameter modulo principal range to do
the evaluation. For an open unbounded curve, the principal range is conventionally
the empty interval. For bounded open or non-periodic curves the definition of
evaluation functions is valid only for parameter values in the returned range.

#### Example

This Visual Basic sample shows how to call the GetParameterExtents method.

```
Dim dblMinU As Double
Dim dblMaxU As Double
Call objCurve.GetParameterExtents(dblMinU, dblMaxU)
```



# IADCoedges.Session Property

Returns the part session for the collection.

#### Syntax

```
IADPartSession Session { get; }
```

#### Property Value

IADPartSession



# IADCurve.IsClosed Property

Returns true if this curve is closed.

#### Syntax

```
bool IsClosed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADCone.Axis Property

Gets a vector along the cone's height whose magnitude measures the cone height.

#### Syntax

```
IADVector Axis { get; }
```

#### Property Value

IADVector

#### Example

This Visual Basic sample shows how to get the Axis property.

```
Dim objADCone As AlibreX.IADCone
Dim objADVector As AlibreX.IADVector

If objSurface.SurfaceType = AD_CONE Then
    Set objADCone = objSurface
    Set objADVector = objADCone.Axis()
End If
```



# IADSurface.NormalAtPoint Method

Gets the normal to the surface at the given point.

#### Syntax

```
IADVector NormalAtPoint(
	IADPoint pPoint
)
```

#### Parameters

pPoint  IADPoint
:   Point at which the normal is to be evaluated.

#### Return Value

IADVector  
Returns IADVector

#### Example

This Visual Basic sample shows how to call the NormalAtPoint method.

```
Dim objADPoint As AlibreX.IADPoint
Set objADPoint = objSurface.PointAtParam(0.5, 0.5)

Dim objADNormal As AlibreX.IADVector
Set objADNormal = objSurface.NormalAtPoint(objADPoint)
```



# IADCoedge.Loop Property

Gets the loop of the coedge.

#### Syntax

```
IADLoop Loop { get; }
```

#### Property Value

IADLoop



# IADLoop Properties

The IADLoop type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Body | Get the owning body. |
|  | Coedges | Get all the Co-edges in the loop. |
|  | Edges | Get all the edges in the loop. |
|  | Face | Get the owning face. |
|  | IsOuter | Returns true if this loop is an outer loop. |
|  | Part | Get the part session owning the loop |
|  | TopologyType | Returns a pre-defined constant that identifies the topology type (AD\_LOOP) of this object. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object. |



# IADLoops.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADLumps.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADBsplineSurface Methods

The IADBsplineSurface type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADSurface) |
|  | GetData | Get b-spline surface's data. |
|  | GetDefinition | Get b-spline surface's definition. |
|  | GetFirstDerivative | Gets the first derivative for the given parameter.  (Inherited from IADSurface) |
|  | GetParamAtPoint | Gets the u,v parameters at the given point on the parametric surface.  (Inherited from IADSurface) |
|  | GetParameterExtents | Gets the parameter range in u and v directions.  (Inherited from IADSurface) |
|  | GetRayIntersectionPoint | Returns intersection point and distance from given ray.  (Inherited from IADSurface) |
|  | GetSecondDerivative | Gets the second order derivatives on the parametric surface for the given parameter values. There are three second order derivatives Xuu, Xuv and Xvv.  (Inherited from IADSurface) |
|  | NormalAtParam | Gets the normal to the parametric surface at the point with given parameters.  (Inherited from IADSurface) |
|  | NormalAtPoint | Gets the normal to the surface at the given point.  (Inherited from IADSurface) |
|  | PointAtParam | Gets the point corresponding to the given parameter values on the parametric surface.  (Inherited from IADSurface) |



# IADCircle.Axis Property

Gets the unit vector perpendicular to the plane of the circle according to right hand rule.

#### Syntax

```
IADVector Axis { get; }
```

#### Property Value

IADVector

#### Example

This Visual Basic sample shows how to call the Axis property.

```
Dim objADCircle As AlibreX.IADCircle
Dim objADVector As AlibreX.IADVector

If objCurve.CurveType = AD_CIRCLE Then
    Set objADCircle = objCurve
    Set objADVector = objADCircle.Axis()
End If
```



# IADTopologySummary Properties

The IADTopologySummary type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CoedgesCount | Returns the number of coedges. |
|  | EdgesCount | Returns the number of edges. |
|  | FacesCount | Returns the number of faces. |
|  | LoopsCount | Returns the number of loops. |
|  | LumpsCount | Returns the number of lumps. |
|  | ShellsCount | Returns the number of shells. |
|  | VerticesCount | Returns the number of vertices. |
|  | WiresCount | Returns the number of wires. |



# IADTorus Properties

The IADTorus type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Gets the normal of the torus. |
|  | Center | Gets the center point of the torus. |
|  | MajorRadius | Gets the radius of the circular spine curve of the torus. |
|  | MinorRadius | Gets the radius of the circular cross section used to create the torus. |
|  | SurfaceType | Returns a pre-defined constant that identifies the surface type of this object.  (Inherited from IADSurface) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADSurface) |



# IADShells.Session Property

Returns the part session for the collection.

#### Syntax

```
IADPartSession Session { get; }
```

#### Property Value

IADPartSession



# IADPlane.RootPoint Property

Gets the root point of the plane.

#### Syntax

```
IADPoint RootPoint { get; }
```

#### Property Value

IADPoint



# IADCylinder.Radius Property

Gets the radius of the cylinder.

#### Syntax

```
double Radius { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Example

This Visual Basic sample shows how to get the Radius property.

```
Dim objADCone As AlibreX.IADCone

If objSurface.SurfaceType = AD_CONE Then
    Set objADCone = objSurface
    Debug.Print objADCone.Radius()
End If
```



# IADVertex.Body Property

Get the owning body.

#### Syntax

```
IADBody Body { get; }
```

#### Property Value

IADBody



# IADCoedge.Part Property

Get the part session owning the body.

#### Syntax

```
IADPartSession Part { get; }
```

#### Property Value

IADPartSession



# IADPhysicalProperties.UniquePartsCount Property

Returns the number of unique parts in design.
For a part design, it would be just 1.

#### Syntax

```
int UniquePartsCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADEdges Interface

This interface represents the collection of edges. An edge is the topology associated
with a curve. An edge is bounded by one or more vertices, referring to one vertex at each end.

#### Syntax

```
public interface IADEdges
```

The IADEdges type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of edges in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the part session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding edge. |

#### Remarks

It is possible obtain this collection of edges by querying the property Edges on
interfaces IADBody, IADLump, IADShell
or IADFace object.



# IADPhysicalProperties.GetMomentsOfInertia Method

Returns the XX, YY, ZZ, YZ, ZX, XY values of the moment of inertia.

#### Syntax

```
void GetMomentsOfInertia(
	out double pXX,
	out double pYY,
	out double pZZ,
	out double pYZ,
	out double pZX,
	out double pXY
)
```

#### Parameters

pXX  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The second moment of inertia XX

pYY  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The second moment of inertia YY

pZZ  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The second moment of inertia ZZ

pYZ  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The second moment of inertia YZ

pZX  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The second moment of inertia ZX

pXY  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The second moment of inertia XY



# IADLump.Body Property

Get the owning body for this lump.

#### Syntax

```
IADBody Body { get; }
```

#### Property Value

IADBody



# IADEdge.Coedge Method

Get one Coedge of the Edge on the given face.

#### Syntax

```
IADCoedge Coedge(
	IADFace face
)
```

#### Parameters

face  IADFace
:   The face upon which to get a Coedge.

#### Return Value

IADCoedge  
Returns IADCoedge

#### Remarks

An edge can belong to more than one face. In each of these faces, a coedge represents this edge.
So, given the face, this property gets the coedge for this edge on the given face.



# IADBsplineSurface.GetData Method

Get b-spline surface's data.

#### Syntax

```
void GetData(
	out Array pKnotsU,
	out Array pKnotsV,
	out Array pPoles,
	out Array pWeights
)
```

#### Parameters

pKnotsU  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   A double array of knot values in the U direction.

pKnotsV  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   A double array of knot values in the V direction.

pPoles  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   Coordinates of the control points/poles. Its size is three times the number of poles.

pWeights  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   A double array of weights at each of the control points.

#### Remarks

B-Spline data is represented in the form of NURBS representation. The knot vector is a
sequence of parameter values that determine the continuity along the NURBS curve. The number of knots
is always equal to the number of control points plus the order of the curve. The poles are the
coordinates of the control points and weights are the homogeneous coordinates which provide extra
blending ability. The higher the weights at a control point the higher the pulling/clamping effect
of that control point on the b-spline surface. These are surface forms of the b-spline curves and
have two parameter directions u and v.

To initialize an array of the correct size to pass to this function, use the
GetDefinition method to first determine the number of poles, etc.

#### Example

This Visual Basic sample shows how to call the GetData method.

```
Dim objADBsplineSurface As AlibreX.IADBsplineSurface
Set objADBsplineSurface = objSurface

Dim lngOrderU As Long
Dim lngOrderV As Long
Dim lngNumPolesU As Long
Dim lngNumPolesV As Long
Dim lngNumKnotsU As Long
Dim lngNumKnotsV As Long
Dim blnIsRational As Boolean
Dim blnIsClosedU As Boolean
Dim blnIsClosedV As Boolean
Dim blnIsPlanar As Boolean

Call objADBsplineSurface.GetDefinition( _
        lngOrderU, _
        lngOrderV, _
        lngNumPolesU, _

        lngNumPolesV, _
        lngNumKnotsU, _
        lngNumKnotsV, _
        blnIsRational, _
        blnIsClosedU, _
        blnIsClosedV, _
        blnIsPlanar)

Dim a_dblKnotsU() As Double
Dim a_dblKnotsV() As Double
Dim a_dblPoles() As Double
Dim a_dblWeights() As Double

ReDim a_dblKnotsU(lngNumKnotsU - 1) As Double
ReDim a_dblKnotsV(lngNumKnotsV - 1) As Double
ReDim a_dblPoles(lngNumPolesU * lngNumPolesV * 3 - 1) As Double
ReDim a_dblWeights(lngNumPolesU * lngNumPolesV - 1) As Double

Call objADBsplineSurface.GetData( _
        a_dblKnotsU(), _
        a_dblKnotsV(), _
        a_dblPoles(), _
        a_dblWeights())
```



# IADSurface.GetParamAtPoint Method

Gets the u,v parameters at the given point on the parametric surface.

#### Syntax

```
void GetParamAtPoint(
	IADPoint pPoint,
	out double pParamU,
	out double pParamV
)
```

#### Parameters

pPoint  IADPoint
:   Point at which the parameters are to be evaluated.

pParamU  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   u parameter for the given point on the parametric surface.

pParamV  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   v parameter for the given point on the parametric surface.

#### Example

This Visual Basic sample shows how to call the GetParamAtPoint method.

```
Dim objADPoint As AlibreX.IADPoint
Set objADPoint = objSurface.PointAtParam(0.5, 0.5)

Dim dblU As Double
Dim dblV As Double
Call objSurface.GetParamAtPoint(objADPoint, dblU, dblV)
```



# IADCircularArc.End Property

Returns the end point of the circular arc.

#### Syntax

```
IADPoint End { get; }
```

#### Property Value

IADPoint

#### Example

This Visual Basic sample shows how to call the End property.

```
Dim objADCircularArc As AlibreX.IADCircularArc
Dim objADPoint As AlibreX.IADPoint

If objCurve.CurveType = AD_CIRCULAR_ARC Then
    Set objADCircularArc = objCurve
    Set objADPoint = objADCircularArc.End()
End If
```



# IADVertices Interface

This interface represents the collection of vertices. A vertex is the corner of
either a face or a wire. Vertex refers to a point in object space and to the edges
that it bounds.

#### Syntax

```
public interface IADVertices
```

The IADVertices type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of vertices in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the part session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding vertex. |

#### Remarks

It is possible to obtain this collection of edges by querying the property
Vertices on interfaces IADBody or IADFace object.



# IADFace.Geometry Property

Get the surface geometry associated with this face.

#### Syntax

```
IADSurface Geometry { get; }
```

#### Property Value

IADSurface



# IADCurve.PointAtParam Method

Gets the point at the given parameter.

#### Syntax

```
IADPoint PointAtParam(
	double pParam
)
```

#### Parameters

pParam  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Parameter value at which to perform the evaluation.

#### Return Value

IADPoint  
Returns IADPoint



# IADFace.Vertices Property

Get all Vertices in a Face.

#### Syntax

```
IADVertices Vertices { get; }
```

#### Property Value

IADVertices



# IADLumps.Item Method

Given a numerical index into the collection, returns the corresponding lump.

#### Syntax

```
IADLump Item(
	int index
)
```

#### Parameters

index  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   This is a number representing the item number in the collection.

#### Return Value

IADLump  
Returns IADLump

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INDEX\_OUT\_OF\_BOUNDS | The specified index is outside of the bounds of the collection. |
| AD\_E\_OBJECT\_NOT\_FOUND\_AT\_INDEX | No object exists at the specified index. |



# IADLump.TopologyType Property

Returns a pre-defined constant that identifies the topology type (AD\_LUMP) of this object.

#### Syntax

```
ADTopologyType TopologyType { get; }
```

#### Property Value

ADTopologyType



# IADPhysicalProperties.PartsCount Property

Returns the number of parts in design. For a part
design, it would be just 1.

#### Syntax

```
int PartsCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADShells Methods

The IADShells type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding shell. |



# IADLump.Edges Property

Get all the edges in the lump.

#### Syntax

```
IADEdges Edges { get; }
```

#### Property Value

IADEdges



# IADLoops Properties

The IADLoops type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of loops in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the part session for the collection. |



# IADEllipticalArc.MinorMajorRatio Property

Gets the ratio of the minor axis to the major axis.

#### Syntax

```
double MinorMajorRatio { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Example

This Visual Basic sample shows how to call the MinorMajorRatio property.

```
Dim objADEllipticalArc As AlibreX.IADEllipticalArc

If objCurve.CurveType = AD_ELLIPTICAL_ARC Then
    Set objADEllipticalArc = objCurve
    Debug.Print objADEllipticalArc.MinorMajorRatio()
End If
```



# IADShell Properties

The IADShell type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Body | Get the owning body. |
|  | Edges | Get all the edges in the shell. |
|  | Faces | Get all the faces in the shell. |
|  | Lump | Get the owning lump. |
|  | Part | Get the part session owning the body. |
|  | TopologyType | Returns a pre-defined constant that identifies the topology type (AD\_SHELL) of this object. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object. |



# IADPhysicalProperties.Volume Property

Returns the volume of design.

#### Syntax

```
double Volume { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADSurface.GetClosestPoint Method

Returns closest point and distance from given point.

#### Syntax

```
bool GetClosestPoint(
	double pointX,
	double pointY,
	double pointZ,
	out IADPoint ppClosestPoint,
	out double pDistance
)
```

#### Parameters

pointX  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the query point.

pointY  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the query point.

pointZ  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Z coordinate of the query point.

ppClosestPoint  IADPoint
:   Closest point.

pDistance  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Distance between query point and closest point.

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADShell.Lump Property

Get the owning lump.

#### Syntax

```
IADLump Lump { get; }
```

#### Property Value

IADLump



# IADLumps.Count Property

Returns the number of lumps in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

In general a body will have just one lump, but it's not required.



# IADEdge.Body Property

Get the owning body.

#### Syntax

```
IADBody Body { get; }
```

#### Property Value

IADBody



# IADCircularArc.Radius Property

Gets the radius of the circular arc.

#### Syntax

```
double Radius { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Example

This Visual Basic sample shows how to call the Radius property.

```
Dim objADCircularArc As AlibreX.IADCircularArc

If objCurve.CurveType = AD_CIRCULAR_ARC Then
    Set objADCircularArc = objCurve
    Debug.Print objADCircularArc.Radius
End If
```



# IADLoop.Edges Property

Get all the edges in the loop.

#### Syntax

```
IADEdges Edges { get; }
```

#### Property Value

IADEdges



# IADShells.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADFaces.Count Property

Returns the number of faces in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADFaces.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADBody.TopologyType Property

Returns a pre-defined constant that identifies the topology type (AD\_BODY) of this object.

#### Syntax

```
ADTopologyType TopologyType { get; }
```

#### Property Value

ADTopologyType



# IADEdge.Geometry Property

Get the curve geometry associated with this edge.

#### Syntax

```
IADCurve Geometry { get; }
```

#### Property Value

IADCurve



# IADFace.Loops Property

Get all Loops in a Face.

#### Syntax

```
IADLoops Loops { get; }
```

#### Property Value

IADLoops



# IADBsplineCurve.GetDefinition Method

Get the spline definition.

#### Syntax

```
void GetDefinition(
	out int pOrder,
	out int pNumPoles,
	out int pNumKnots,
	out bool pIsRational,
	out bool pIsClosed,
	out bool pIsPlanar
)
```

#### Parameters

pOrder  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The order of the b-spline curve. It is equal to degree of the curve
    plus 1 and hence determines the continuity of the curve.

pNumPoles  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The number of control points in the spline.

pNumKnots  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The number of knot values in the spline.

pIsRational  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Whether the spline is rational or not.

pIsClosed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Whether the spline is closed or not.

pIsPlanar  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Whether the spline is planar or not.

#### Remarks

The basic defining parameters of a b-spline curve are order, number of control points
and the knot vector. The control points are also called poles. Given the number of control
points(n+1) and the order(k) the number of knot vectors(m) can be computed as m = n + 1 + k,
but it is given here for convenience. The actual values of the control points and the knot
vector can be obtained using the method GetData on b-spline curve. In addition to these, this
method also tells about rationality, closeness and planarity of the curve.

#### Example

This Visual Basic sample demonstrates usage of the GetData method.

```
' Holds Order of Bspline curve
Dim lngOrder As Long

' Holds Poles count
Dim lngNumPoles As Long

' Holds Knots count
Dim lngNumKnots As Long

' Holds IsRational Flag
Dim blnIsRational As Boolean

' Holds IsClosed Flag
Dim blnIsClosed As Boolean

' Holds IsPlanar Flag
Dim blnIsPlanar As Boolean

' Get Bspline Definition
Call objADBsplineCurve.GetDefinition( _
                    lngOrder, _
                    lngNumPoles, _
                    lngNumKnots, _

                    blnIsRational, _
                    blnIsClosed, _
                    blnIsPlanar)
```



# IADTopologySummary.VerticesCount Property

Returns the number of vertices.

#### Syntax

```
int VerticesCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADVertices.Session Property

Returns the part session for the collection.

#### Syntax

```
IADPartSession Session { get; }
```

#### Property Value

IADPartSession



# IADCone.IsExpanding Property

Gets whether the radius is increasing in the axis direction.

#### Syntax

```
bool IsExpanding { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADTopologySummary.LumpsCount Property

Returns the number of lumps.

#### Syntax

```
int LumpsCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADLump.Type Property

Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADShell.TopologyType Property

Returns a pre-defined constant that identifies the topology type (AD\_SHELL) of this object.

#### Syntax

```
ADTopologyType TopologyType { get; }
```

#### Property Value

ADTopologyType



# IADBody.Part Property

Get the part session owning the body.

#### Syntax

```
IADPartSession Part { get; }
```

#### Property Value

IADPartSession



# IADEdges.Session Property

Returns the part session for the collection.

#### Syntax

```
IADPartSession Session { get; }
```

#### Property Value

IADPartSession



# IADLine Properties

The IADLine type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CurveType | Returns a pre-defined constant that identifies the curve type of this object.  (Inherited from IADCurve) |
|  | DirectionVector | Gets the vector representing the direction of the line. |
|  | IsClosed | Returns true if this curve is closed.  (Inherited from IADCurve) |
|  | StartPoint | Gets the starting point of the line. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADCurve) |



# IADLoops Interface

This interface represents the collection of all the loops. A loop represents a connected
portion of the boundary of a face. It consists of a set of coedges linked in a doubly-linked
chain which may be circular or open-ended.

#### Syntax

```
public interface IADLoops
```

The IADLoops type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of loops in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the part session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding loop. |

#### Remarks

It is possible to obtain this collection of loops by querying the property Loops
on an IADFace object.



# IADCylinder Properties

The IADCylinder type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Gets a vector along the cylinder's height whose magnitude measures the cylinder's height. |
|  | BasePoint | Gets the center point of the circle at the bottom of the cylinder. |
|  | Radius | Gets the radius of the cylinder. |
|  | SurfaceType | Returns a pre-defined constant that identifies the surface type of this object.  (Inherited from IADSurface) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADSurface) |



# IADSurface Interface

IADSurface represents the interface for a Surface object in a Part or Sheet Metal workspace.
The geometry of a face is a surface. This interface represents a generic surface and the
specific surface can be obtained by typecasting this after checking the specific surface type.

#### Syntax

```
public interface IADSurface
```

The IADSurface type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | SurfaceType | Returns a pre-defined constant that identifies the surface type of this object. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetClosestPoint | Returns closest point and distance from given point. |
|  | GetFirstDerivative | Gets the first derivative for the given parameter. |
|  | GetParamAtPoint | Gets the u,v parameters at the given point on the parametric surface. |
|  | GetParameterExtents | Gets the parameter range in u and v directions. |
|  | GetRayIntersectionPoint | Returns intersection point and distance from given ray. |
|  | GetSecondDerivative | Gets the second order derivatives on the parametric surface for the given parameter values. There are three second order derivatives Xuu, Xuv and Xvv. |
|  | NormalAtParam | Gets the normal to the parametric surface at the point with given parameters. |
|  | NormalAtPoint | Gets the normal to the surface at the given point. |
|  | PointAtParam | Gets the point corresponding to the given parameter values on the parametric surface. |



# IADFace.Shell Property

Get the owning shell.

#### Syntax

```
IADShell Shell { get; }
```

#### Property Value

IADShell



# IADCylinder.Axis Property

Gets a vector along the cylinder's height whose magnitude measures the cylinder's height.

#### Syntax

```
IADVector Axis { get; }
```

#### Property Value

IADVector

#### Example

This Visual Basic sample shows how to get the Axis property.

```
Dim objADCylinder As AlibreX.IADCylinder
Dim objADVector As AlibreX.IADVector

If objSurface.SurfaceType = AD_CYLINDER Then
    Set objADCylinder = objSurface
    Set objADVector = objADCylinder.Axis()
End If
```



# IADFaces Methods

The IADFaces type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding face. |



# IADLine.DirectionVector Property

Gets the vector representing the direction of the line.

#### Syntax

```
IADVector DirectionVector { get; }
```

#### Property Value

IADVector

#### Example

This Visual Basic sample shows how to call the DirectionVector property.

```
Dim objADLine As AlibreX.IADLine
Dim objADVector As AlibreX.IADVector

If objCurve.CurveType = AD_LINE Then
    Set objADLine = objCurve
    Set objADVector = objADLine.DirectionVector()
End If
```



# IADVertices Properties

The IADVertices type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of vertices in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the part session for the collection. |



# IADBody.Lumps Property

Returns a collection of all the lumps in the body.

#### Syntax

```
IADLumps Lumps { get; }
```

#### Property Value

IADLumps



# IADFace.Type Property

Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADShells Properties

The IADShells type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of shells in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the part session for the collection. |



# IADCoedge.PartnerCoedge Property

An edge can be associated with more than one face and is represented by a coedge in all
these faces. Hence, the partner coedge gives the coedge for the same edge on other face.

#### Syntax

```
IADCoedge PartnerCoedge { get; }
```

#### Property Value

IADCoedge



# IADEdge.Key Property

Gets the Persistent Key property of this Edge. This Key is unique for this Edge and can be used to access the edge.

#### Syntax

```
Array Key { get; }
```

#### Property Value

[Array](https://learn.microsoft.com/dotnet/api/system.array)



# IADTopologySummary Interface

IADTopologySummary is an interface for a summary of the topological properties associated with an object.
These properties include the number of faces, edges, vertices, lumps, shells, coedges, and loops.

#### Syntax

```
public interface IADTopologySummary
```

The IADTopologySummary type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CoedgesCount | Returns the number of coedges. |
|  | EdgesCount | Returns the number of edges. |
|  | FacesCount | Returns the number of faces. |
|  | LoopsCount | Returns the number of loops. |
|  | LumpsCount | Returns the number of lumps. |
|  | ShellsCount | Returns the number of shells. |
|  | VerticesCount | Returns the number of vertices. |
|  | WiresCount | Returns the number of wires. |



# IADLoop.TopologyType Property

Returns a pre-defined constant that identifies the topology type (AD\_LOOP) of this object.

#### Syntax

```
ADTopologyType TopologyType { get; }
```

#### Property Value

ADTopologyType



# IADEllipse.Axis Property

Outputs the unit vector perpendicular to the plane of the ellipse according to right hand rule.

#### Syntax

```
IADVector Axis { get; }
```

#### Property Value

IADVector

#### Example

This Visual Basic sample shows how to call the Axis property.

```
Dim objADEllipse As AlibreX.IADEllipse
Dim objADVector As AlibreX.IADVector

If objCurve.CurveType = AD_ELLIPSE Then
    Set objADEllipse = objCurve
    Set objADVector = objADEllipse.Axis()
End If
```



# IADEdge.IsSenseReversed Property

Returns the sense of the edge with respect to the underlying curve.
It returns true if the direction of the underlying curve and the edge are in opposite direction.

#### Syntax

```
bool IsSenseReversed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPhysicalProperties Properties

The IADPhysicalProperties type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgesCount | Returns the number of edges in design. If the design is an Assembly, then number of edges returned is the total number of edges in all the parts in the assembly. |
|  | FacesCount | Returns the number of faces in design. If the design is an Assembly, then number of faces returned is the total number of faces in all the parts in the assembly. |
|  | LumpsCount | Returns the number of lumps in design. If the design is an Assembly, then number of lumps returned is the total number of lumps in all the parts in the assembly. |
|  | Mass | Returns the mass of the design. |
|  | Material | Returns name of the material used for the design. |
|  | PartsCount | Returns the number of parts in design. For a part design, it would be just 1. |
|  | SurfaceArea | Returns the surface-area of design. |
|  | UniquePartsCount | Returns the number of unique parts in design. For a part design, it would be just 1. |
|  | VerticesCount | Returns the number of vertices in design. If the design is an Assembly, then number of vertices returned is the total number of vertices in all the parts in the assembly. |
|  | Volume | Returns the volume of design. |



# IADEdges Methods

The IADEdges type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding edge. |



# IADLoops.Session Property

Returns the part session for the collection.

#### Syntax

```
IADPartSession Session { get; }
```

#### Property Value

IADPartSession



# IADPhysicalProperties.GetExtents Method

Returns the range box that denotes the max/min of a 3D box surrounding the design.

#### Syntax

```
void GetExtents(
	out IADPoint ppLower,
	out IADPoint ppUpper
)
```

#### Parameters

ppLower  IADPoint
:   The lower point of the extents.

ppUpper  IADPoint
:   The upper point of the extents.

#### Example

This Visual Basic sample shows how to get the extents of a design.

```
' Get the physical properties
Dim objPhysicalProperties As AlibreX.IADPhysicalProperties
Set objPhysicalProperties = m_objAlibreDesignSession.PhysicalProperties(AD_VERY_HIGH)

Dim objSession As AlibreX.IADSession
Set objSession = m_objAlibreDesignSession

' Get the Geometry factory
Dim objGeometryFactory As AlibreX.IADGeometryFactory
Set objGeometryFactory = objSession.GeometryFactory

' Create two points that holds the range box
Dim objPoint1 As AlibreX.IADPoint
Dim objPoint2 As AlibreX.IADPoint

Set objPoint1 = objGeometryFactory.CreatePoint(0#, 0#, 0#)
Set objPoint2 = objGeometryFactory.CreatePoint(0#, 0#, 0#)

' Calculate the extents
objPhysicalProperties.GetExtents(objPoint1, objPoint2)

MsgBox "Lower (" & objPoint1.X & ", " & objPoint1.Y & ", " & objPoint1.Z & ") " & _
        "Upper (" & objPoint2.X & ", " & objPoint2.Y & ", " & objPoint2.Z & ")"
```



# IADLumps Properties

The IADLumps type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of lumps in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the part session for the collection. |



# IADEdges.Item Method

Given a numerical index into the collection, returns the corresponding edge.

#### Syntax

```
IADEdge Item(
	int index
)
```

#### Parameters

index  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   This is a number representing the item number in the collection.

#### Return Value

IADEdge  

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INDEX\_OUT\_OF\_BOUNDS | The specified index is outside of the bounds of the collection. |
| AD\_E\_OBJECT\_NOT\_FOUND\_AT\_INDEX | No object exists at the specified index. |



# IADFace.TopologyType Property

Returns a pre-defined constant that identifies the topology type (AD\_FACE) of this object.

#### Syntax

```
ADTopologyType TopologyType { get; }
```

#### Property Value

ADTopologyType



# IADLoops.Item Method

Given a numerical index into the collection, returns the corresponding loop.

#### Syntax

```
IADLoop Item(
	int index
)
```

#### Parameters

index  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   This is a number representing the item number in the collection.

#### Return Value

IADLoop  
Returns IADLoop

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INDEX\_OUT\_OF\_BOUNDS | The specified index is outside of the bounds of the collection. |
| AD\_E\_OBJECT\_NOT\_FOUND\_AT\_INDEX | No object exists at the specified index. |



# IADTopologySummary.CoedgesCount Property

Returns the number of coedges.

#### Syntax

```
int CoedgesCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADBsplineSurface.GetDefinition Method

Get b-spline surface's definition.

#### Syntax

```
void GetDefinition(
	out int pOrderU,
	out int pOrderV,
	out int pNumPolesU,
	out int pNumPolesV,
	out int pNumKnotsU,
	out int pNumKnotsV,
	out bool pIsRational,
	out bool pIsClosedU,
	out bool pvIsClosedV,
	out bool pIsPlanar
)
```

#### Parameters

pOrderU  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   Order of the spline surface in the U direction.

pOrderV  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   Order of the spline surface in the V direction.

pNumPolesU  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The number of control points/poles in the U direction.

pNumPolesV  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The number of control points/poles in the V direction.

pNumKnotsU  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The number of knot values in the U direction.

pNumKnotsV  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The number of knot values in the V direction.

pIsRational  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Whether the spline surface is rational or not.

pIsClosedU  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Whether the spline surface is closed in the U direction or not.

pvIsClosedV  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Whether the spline surface is closed in the V direction or not.

pIsPlanar  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Whether the spline surface is planar or not.

#### Remarks

The basic defining parameters of a b-spline curve are order, number
of control points and the knot vector. The control points are also called poles. Since for a surface
there are two parametric directions u and v, the b-spline data in each direction is given. Given the
number of control points(n+1) and the order(k) the number of knot vectors(m) can be computed as
m = n + 1 + k, but it is given here for convenience. The actual values of the control points and the
knot vector can be obtained using the method GetData on the b-spline
surface. In addition to these, this method also tells about rationality, closeness and planarity
of the curve.

#### Example

This Visual Basic sample shows how to call the GetDefinition method.

```
Dim objADBsplineSurface As AlibreX.IADBsplineSurface
Set objADBsplineSurface = objSurface

Dim lngOrderU As Long
Dim lngOrderV As Long
Dim lngNumPolesU As Long
Dim lngNumPolesV As Long
Dim lngNumKnotsU As Long
Dim lngNumKnotsV As Long
Dim blnIsRational As Boolean
Dim blnIsClosedU As Boolean
Dim blnIsClosedV As Boolean
Dim blnIsPlanar As Boolean

Call objADBsplineSurface.GetDefinition( _
        lngOrderU, _
        lngOrderV, _
        lngNumPolesU, _

        lngNumPolesV, _
        lngNumKnotsU, _
        lngNumKnotsV, _
        blnIsRational, _
        blnIsClosedU, _
        blnIsClosedV, _
        blnIsPlanar)
```



# IADLoop Interface

This interface represents the Loop in Alibre Design. A loop represents a connected
portion of the boundary of a face. It consists of a set of coedges linked in a
doubly-linked chain which may be circular or open-ended.

#### Syntax

```
public interface IADLoop
```

The IADLoop type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Body | Get the owning body. |
|  | Coedges | Get all the Co-edges in the loop. |
|  | Edges | Get all the edges in the loop. |
|  | Face | Get the owning face. |
|  | IsOuter | Returns true if this loop is an outer loop. |
|  | Part | Get the part session owning the loop |
|  | TopologyType | Returns a pre-defined constant that identifies the topology type (AD\_LOOP) of this object. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object. |



# IADCoedges.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADShell.Part Property

Get the part session owning the body.

#### Syntax

```
IADPartSession Part { get; }
```

#### Property Value

IADPartSession



# IADBody.Faces Property

Returns a collection of all the faces in the body.

#### Syntax

```
IADFaces Faces { get; }
```

#### Property Value

IADFaces



# IADTorus Interface

IADTorus interface represents a toroidal surface geometry and can be obtained by typecasting the
Surface Object which is of type AD\_TORUS. A torus is defined
as a circular spine and a circular cross-section at each point on the spine.

#### Syntax

```
public interface IADTorus : IADSurface
```

The IADTorus type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Gets the normal of the torus. |
|  | Center | Gets the center point of the torus. |
|  | MajorRadius | Gets the radius of the circular spine curve of the torus. |
|  | MinorRadius | Gets the radius of the circular cross section used to create the torus. |
|  | SurfaceType | Returns a pre-defined constant that identifies the surface type of this object.  (Inherited from IADSurface) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADSurface) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADSurface) |
|  | GetFirstDerivative | Gets the first derivative for the given parameter.  (Inherited from IADSurface) |
|  | GetParamAtPoint | Gets the u,v parameters at the given point on the parametric surface.  (Inherited from IADSurface) |
|  | GetParameterExtents | Gets the parameter range in u and v directions.  (Inherited from IADSurface) |
|  | GetRayIntersectionPoint | Returns intersection point and distance from given ray.  (Inherited from IADSurface) |
|  | GetSecondDerivative | Gets the second order derivatives on the parametric surface for the given parameter values. There are three second order derivatives Xuu, Xuv and Xvv.  (Inherited from IADSurface) |
|  | NormalAtParam | Gets the normal to the parametric surface at the point with given parameters.  (Inherited from IADSurface) |
|  | NormalAtPoint | Gets the normal to the surface at the given point.  (Inherited from IADSurface) |
|  | PointAtParam | Gets the point corresponding to the given parameter values on the parametric surface.  (Inherited from IADSurface) |

#### Remarks

The normal of the torus is the normal to the plane of the circular spine and is also called
the axis of the torus. The radius of the circular spine is called the major radius and that of the
circular cross-section is called the minor radius. The center point of the torus is the center of
the circular spine of the torus.



# IADCurve Properties

The IADCurve type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CurveType | Returns a pre-defined constant that identifies the curve type of this object. |
|  | IsClosed | Returns true if this curve is closed. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY) |



# IADVertex Properties

The IADVertex type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Body | Get the owning body. |
|  | Edges | A vertex can belong to more than one edge. This property returns all the edges which are incident on this vertex. |
|  | Faces | A vertex can belong to more than one face. This property returns all the faces which are incident on this vertex. |
|  | Key | Gets the Persistent Key property of this vertex. This Key is unique for this Vertex and can be used to access the vertex. |
|  | Part | Get the part session owning the vertex. |
|  | Point | A vertex is a topological entity on top of a point. This property gets that underlying point. |
|  | TopologyType | Returns a pre-defined constant that identifies the topology type (AD\_VERTEX) of this object. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object. |



# IADSurface.PointAtParam Method

Gets the point corresponding to the given parameter values on the parametric surface.

#### Syntax

```
IADPoint PointAtParam(
	double pParamU,
	double pParamV
)
```

#### Parameters

pParamU  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   u parameter for the point to be evaluated.

pParamV  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   v parameter for the point to be evaluated.

#### Return Value

IADPoint  
Returns IADPoint

#### Example

This Visual Basic sample shows how to call the PointAtParam method.

```
Dim objADPoint As AlibreX.IADPoint
Set objADPoint = objSurface.PointAtParam(0.5, 0.5)
```



# IADPhysicalProperties.VerticesCount Property

Returns the number of vertices in design. If the design is an Assembly,
then number of vertices returned is the total number of vertices in all the parts in the assembly.

#### Syntax

```
int VerticesCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADTopologySummary.WiresCount Property

Returns the number of wires.

#### Syntax

```
int WiresCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADVertex Interface

This interface represents the Vertex in Alibre Design. A vertex is the corner of either
a face or a wire. Vertex refers to a point in object space and to the edges that it bounds.

#### Syntax

```
public interface IADVertex
```

The IADVertex type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Body | Get the owning body. |
|  | Edges | A vertex can belong to more than one edge. This property returns all the edges which are incident on this vertex. |
|  | Faces | A vertex can belong to more than one face. This property returns all the faces which are incident on this vertex. |
|  | Key | Gets the Persistent Key property of this vertex. This Key is unique for this Vertex and can be used to access the vertex. |
|  | Part | Get the part session owning the vertex. |
|  | Point | A vertex is a topological entity on top of a point. This property gets that underlying point. |
|  | TopologyType | Returns a pre-defined constant that identifies the topology type (AD\_VERTEX) of this object. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object. |



# IADLoops Methods

The IADLoops type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding loop. |



# IADFace Methods

The IADFace type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | FacetData | Returns triangular mesh data for the face given the maximum deviation of a facet from the surface. |
|  | FacetDataEx | Returns triangular mesh data for the face given the maximum deviation of a facet from the surface. |
|  | GetAlibreMeshData | Returns the raw mesh data for the face using the facet settings in the corresponding part session. |
|  | GetBSplineCurvesData |  |
|  | GetColorForConfiguration | Returns the color applied to this face for a given configuration. This color can be the color applied using the feature color or the face color feature. |
|  | GetExtents | Returns Range Box that denotes the max/min of a 3D box for this face. |
|  | GetMeshData | Returns the raw mesh data for the face given the maximum deviation of a facet from the surface. |
|  | PointOnFace | Tests the point's position with respect to the surface within the system tolerance limit. The limit is normally equal to 1e-6. Returns true of the input point lies on the face. |



# IADEdge Methods

The IADEdge type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Coedge | Get one Coedge of the Edge on the given face. |
|  | GetExtents | Returns Range Box that denotes the max/min of a 3D box for this edge. |



# IADLump.Faces Property

Get all the faces in the lump.

#### Syntax

```
IADFaces Faces { get; }
```

#### Property Value

IADFaces



# IADCurve.Type Property

Returns a pre-defined constant that identifies the type of this object.
(AD\_GEOMETRY)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADEdges Properties

The IADEdges type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of edges in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the part session for the collection. |



# IADPhysicalProperties.GetPrincipalMomentsOfInertia Method

Returns the principal moments of inertia.

#### Syntax

```
void GetPrincipalMomentsOfInertia(
	out double pM1,
	out double pM2,
	out double pM3
)
```

#### Parameters

pM1  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Holds the moment of inertia along first principal axis.

pM2  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Holds the moment of inertia along second principal axis.

pM3  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Holds the moment of inertia along third principal axis.



# IADSphere Properties

The IADSphere type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Center | Gets the center point of the sphere. |
|  | Radius | Gets the radius of the sphere. |
|  | SurfaceType | Returns a pre-defined constant that identifies the surface type of this object.  (Inherited from IADSurface) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADSurface) |



# IADTopologySummary.ShellsCount Property

Returns the number of shells.

#### Syntax

```
int ShellsCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADCircularArc Properties

The IADCircularArc type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Outputs the unit vector perpendicular to the plane of the circular arc according to right hand rule. |
|  | Center | Gets the center point of the circular arc. |
|  | CurveType | Returns a pre-defined constant that identifies the curve type of this object.  (Inherited from IADCurve) |
|  | End | Returns the end point of the circular arc. |
|  | IsClosed | Returns true if this curve is closed.  (Inherited from IADCurve) |
|  | Radius | Gets the radius of the circular arc. |
|  | Start | Returns the start point of the circular arc. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADCurve) |



# IADLine Methods

The IADLine type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Curvature | Gets the curvature at the given parameter as a vector.  (Inherited from IADCurve) |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADCurve) |
|  | GetParameterExtents | Gets the Parameter Extents: Start Param and End Param.  (Inherited from IADCurve) |
|  | ParamAtPoint | Gets the parameter at the given point.  (Inherited from IADCurve) |
|  | PointAtParam | Gets the point at the given parameter.  (Inherited from IADCurve) |
|  | Tangent | Gets the tangent at the given parameter.  (Inherited from IADCurve) |



# IADTopologySummary.LoopsCount Property

Returns the number of loops.

#### Syntax

```
int LoopsCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADCurve.GetClosestPoint Method

Returns closest point and distance from given point.

#### Syntax

```
bool GetClosestPoint(
	double pointX,
	double pointY,
	double pointZ,
	out IADPoint ppClosestPoint,
	out double pDistance
)
```

#### Parameters

pointX  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the query point.

pointY  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the query point.

pointZ  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Z coordinate of the query point.

ppClosestPoint  IADPoint
:   Closest point.

pDistance  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Distance between query point and closest point.

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADEllipse Properties

The IADEllipse type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Outputs the unit vector perpendicular to the plane of the ellipse according to right hand rule. |
|  | Center | Gets the center point of the ellipse. |
|  | CurveType | Returns a pre-defined constant that identifies the curve type of this object.  (Inherited from IADCurve) |
|  | IsClosed | Returns true if this curve is closed.  (Inherited from IADCurve) |
|  | MajorAxis | Gets length of major axis. |
|  | MinorMajorRatio | Gets the ratio of minor axis ot the major axis. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADCurve) |



# IADCoedge Properties

The IADCoedge type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Body | Get the owning body. |
|  | Edge | Each coedge is associated with an edge and is basically a representative for that edge in a loop. This method returns that underlying edge for this coedge. |
|  | IsSenseReversed | Returns the sense of the coedge with respect to the underlying edge. It returns true if the direction of the underlying edge and coedge are in opposite direction. |
|  | Loop | Gets the loop of the coedge. |
|  | Part | Get the part session owning the body. |
|  | PartnerCoedge | An edge can be associated with more than one face and is represented by a coedge in all these faces. Hence, the partner coedge gives the coedge for the same edge on other face. |
|  | TopologyType | Returns a pre-defined constant that identifies the topology type (AD\_COEDGE) of this object. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object. |



# IADFace.Part Property

Get the part session owning the body.

#### Syntax

```
IADPartSession Part { get; }
```

#### Property Value

IADPartSession



# IADBsplineCurve Interface

IADBsplineCurve interface represents a b-spline curve geometry and can be obtained by
typecasting the Curve object which is of type AD\_BSPLINE. As all b-splines can be represented
by NURBS, this interface returns all the data pertaining to NURBS. It is possible to check
whether the spline is actually rational (NURBS) or non-rational, by checking the definition
data which also returns a flag for rationality of the curve. In addition, the closed and
planar properties of the curve can also be obtained.

#### Syntax

```
public interface IADBsplineCurve : IADCurve
```

The IADBsplineCurve type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CurveType | Returns a pre-defined constant that identifies the curve type of this object.  (Inherited from IADCurve) |
|  | IsClosed | Returns true if this curve is closed.  (Inherited from IADCurve) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADCurve) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Curvature | Gets the curvature at the given parameter as a vector.  (Inherited from IADCurve) |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADCurve) |
|  | GetData | Get the spline data. |
|  | GetDefinition | Get the spline definition. |
|  | GetParameterExtents | Gets the Parameter Extents: Start Param and End Param.  (Inherited from IADCurve) |
|  | ParamAtPoint | Gets the parameter at the given point.  (Inherited from IADCurve) |
|  | PointAtParam | Gets the point at the given parameter.  (Inherited from IADCurve) |
|  | Tangent | Gets the tangent at the given parameter.  (Inherited from IADCurve) |

#### Remarks

The key parameters required to define a b-spline curve are knot vectors, control
points (also referred to as poles) and the weights at each of these control points. The
order of the curve is the degree of the curve plus one and hence determines the continuity
of the curve. The knot vector is a sequence of parameter values in ascending order that
determine the continuity along the NURBS curve. The number of knots is always equal to the
number of control points plus the order of the curve. Weights, also called the homogeneous
coordinates, provide extra blending ability in a b-spline curve. The higher the weights at
a control point the higher the pulling/clamping effect of that control point on the b-spline curve.



# IADCircle.Center Property

Gets the center point of the circle.

#### Syntax

```
IADPoint Center { get; }
```

#### Property Value

IADPoint

#### Example

This Visual Basic sample shows how to call the Center property.

```
Dim objADCircle As AlibreX.IADCircle
Dim objADPoint As AlibreX.IADPoint

If objCurve.CurveType = AD_CIRCLE Then
    Set objADCircle = objCurve
    Set objADPoint = objADCircle.Center()
End If
```



# IADVertices.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADTopologySummary.EdgesCount Property

Returns the number of edges.

#### Syntax

```
int EdgesCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADCone Interface

IADCone interface represents a conical surface geometry and can be obtained by typecasting the
Surface Object which is of type AD\_CONE. The cone is defined
by the axis, a point on the bottom circle of the cone, the radius, and the half angle at the top vertex.

#### Syntax

```
public interface IADCone : IADSurface
```

The IADCone type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Gets a vector along the cone's height whose magnitude measures the cone height. |
|  | BasePoint | Gets the center point of the circle at the bottom of the cone. |
|  | HalfAngle | Gets the half angle for the cone. |
|  | IsExpanding | Gets whether the radius is increasing in the axis direction. |
|  | Radius | Gets the radius of the bottom face of the cone. |
|  | SurfaceType | Returns a pre-defined constant that identifies the surface type of this object.  (Inherited from IADSurface) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADSurface) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADSurface) |
|  | GetFirstDerivative | Gets the first derivative for the given parameter.  (Inherited from IADSurface) |
|  | GetParamAtPoint | Gets the u,v parameters at the given point on the parametric surface.  (Inherited from IADSurface) |
|  | GetParameterExtents | Gets the parameter range in u and v directions.  (Inherited from IADSurface) |
|  | GetRayIntersectionPoint | Returns intersection point and distance from given ray.  (Inherited from IADSurface) |
|  | GetSecondDerivative | Gets the second order derivatives on the parametric surface for the given parameter values. There are three second order derivatives Xuu, Xuv and Xvv.  (Inherited from IADSurface) |
|  | NormalAtParam | Gets the normal to the parametric surface at the point with given parameters.  (Inherited from IADSurface) |
|  | NormalAtPoint | Gets the normal to the surface at the given point.  (Inherited from IADSurface) |
|  | PointAtParam | Gets the point corresponding to the given parameter values on the parametric surface.  (Inherited from IADSurface) |

#### Remarks

The magnitude of the axis is equal to the height of the cone and an additional flag is
provided to denote whether the cone is expanding in the axis direction. Note that the cone does
not include the end cap.



# IADCoedge.Type Property

Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADPhysicalProperties.EdgesCount Property

Returns the number of edges in design. If the design is an Assembly,
then number of edges returned is the total number of edges in all the parts in the assembly.

#### Syntax

```
int EdgesCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADShells.Count Property

Returns the number of shells in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADCurve.Tangent Method

Gets the tangent at the given parameter.

#### Syntax

```
IADVector Tangent(
	double pParam
)
```

#### Parameters

pParam  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Parameter value at which to perform the evaluation.

#### Return Value

IADVector  
Returns IADVector

#### Example

This Visual Basic sample shows how to call the Tangent method.

```
Dim objADVector As AlibreX.IADVector
Set objADVector = objCurve.Tangent(0.5)
```



# IADCone Properties

The IADCone type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Gets a vector along the cone's height whose magnitude measures the cone height. |
|  | BasePoint | Gets the center point of the circle at the bottom of the cone. |
|  | HalfAngle | Gets the half angle for the cone. |
|  | IsExpanding | Gets whether the radius is increasing in the axis direction. |
|  | Radius | Gets the radius of the bottom face of the cone. |
|  | SurfaceType | Returns a pre-defined constant that identifies the surface type of this object.  (Inherited from IADSurface) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADSurface) |



# IADSurface.GetRayIntersectionPoint Method

Returns intersection point and distance from given ray.

#### Syntax

```
bool GetRayIntersectionPoint(
	double pointX,
	double pointY,
	double pointZ,
	double rayDirX,
	double rayDirY,
	double rayDirZ,
	bool bBidrection,
	out IADPoint ppXPoint,
	out double pDistance
)
```

#### Parameters

pointX  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the ray origin.

pointY  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the ray origin.

pointZ  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Z coordinate of the ray origin.

rayDirX  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the ray direction.

rayDirY  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the ray direction.

rayDirZ  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Z coordinate of the ray direction.

bBidrection  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Flag for indicating whether it searches bidirectinoally or not.

ppXPoint  IADPoint
:   Intersection point.

pDistance  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Distance between ray origin and Intersection point.

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADEdge.Type Property

Returns a pre-defined constant that identifies the type (AD\_TOPOLOGY) of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADFace.FacetDataEx Method

Returns triangular mesh data for the face given the maximum deviation of a facet from the surface.

#### Syntax

```
Array FacetDataEx(
	double surfaceTol,
	double normalTol,
	double maxEdgeLength
)
```

#### Parameters

surfaceTol  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The maximum deviation of a facet from the surface.

normalTol  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The maximum angle (in degrees) between surface normals at points on a facet.

maxEdgeLength  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Maximum length of the facet edge.

#### Return Value

[Array](https://learn.microsoft.com/dotnet/api/system.array)  
A double array of the triangular mesh data for the face.

#### Remarks

The array contains triplets of double values representing (x,y,z) co-ordinates
corresponding to triangle vertices.



# IADFace.GetBSplineCurvesData Method

#### Syntax

```
void GetBSplineCurvesData(
	out Array surfaceOrderUVArray,
	out Array surfaceInfoArray,
	out Array surfaceNumControlPointsUV,
	out Array surfaceNoOfKnotsUV,
	out Array surfaceControlPoints,
	out Array surfaceWeights,
	out Array surfaceKnotVectorU,
	out Array surfaceKnotVectorV,
	out Array regionInfoForLoopsArray,
	out Array noOfTrimmedCurvesForLoopsArray,
	out Array noOfControlPointsArray,
	out Array noOfKnotsArray,
	out Array surfaceIndicesArray,
	out Array controlPointsArray,
	out Array knotsArray,
	out Array weightsArray
)
```

#### Parameters

surfaceOrderUVArray  [Array](https://learn.microsoft.com/dotnet/api/system.array)

surfaceInfoArray  [Array](https://learn.microsoft.com/dotnet/api/system.array)

surfaceNumControlPointsUV  [Array](https://learn.microsoft.com/dotnet/api/system.array)

surfaceNoOfKnotsUV  [Array](https://learn.microsoft.com/dotnet/api/system.array)

surfaceControlPoints  [Array](https://learn.microsoft.com/dotnet/api/system.array)

surfaceWeights  [Array](https://learn.microsoft.com/dotnet/api/system.array)

surfaceKnotVectorU  [Array](https://learn.microsoft.com/dotnet/api/system.array)

surfaceKnotVectorV  [Array](https://learn.microsoft.com/dotnet/api/system.array)

regionInfoForLoopsArray  [Array](https://learn.microsoft.com/dotnet/api/system.array)

noOfTrimmedCurvesForLoopsArray  [Array](https://learn.microsoft.com/dotnet/api/system.array)

noOfControlPointsArray  [Array](https://learn.microsoft.com/dotnet/api/system.array)

noOfKnotsArray  [Array](https://learn.microsoft.com/dotnet/api/system.array)

surfaceIndicesArray  [Array](https://learn.microsoft.com/dotnet/api/system.array)

controlPointsArray  [Array](https://learn.microsoft.com/dotnet/api/system.array)

knotsArray  [Array](https://learn.microsoft.com/dotnet/api/system.array)

weightsArray  [Array](https://learn.microsoft.com/dotnet/api/system.array)



# IADPlane Interface

IADPlane interface represents a planar surface geometry, which can be obtained by
typecasting a Surface object which is of type AD\_PLANE.

#### Syntax

```
public interface IADPlane : IADSurface
```

The IADPlane type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Normal | Gets the plane's normal. |
|  | RootPoint | Gets the root point of the plane. |
|  | SurfaceType | Returns a pre-defined constant that identifies the surface type of this object.  (Inherited from IADSurface) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY)  (Inherited from IADSurface) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetClosestPoint | Returns closest point and distance from given point.  (Inherited from IADSurface) |
|  | GetFirstDerivative | Gets the first derivative for the given parameter.  (Inherited from IADSurface) |
|  | GetParamAtPoint | Gets the u,v parameters at the given point on the parametric surface.  (Inherited from IADSurface) |
|  | GetParameterExtents | Gets the parameter range in u and v directions.  (Inherited from IADSurface) |
|  | GetRayIntersectionPoint | Returns intersection point and distance from given ray.  (Inherited from IADSurface) |
|  | GetSecondDerivative | Gets the second order derivatives on the parametric surface for the given parameter values. There are three second order derivatives Xuu, Xuv and Xvv.  (Inherited from IADSurface) |
|  | NormalAtParam | Gets the normal to the parametric surface at the point with given parameters.  (Inherited from IADSurface) |
|  | NormalAtPoint | Gets the normal to the surface at the given point.  (Inherited from IADSurface) |
|  | PointAtParam | Gets the point corresponding to the given parameter values on the parametric surface.  (Inherited from IADSurface) |

#### Remarks

Note that this plane is different from the reference geometry
DesignPlane and it represents the geometry of a planar face
of the model. In contrast ot the DesignPlane, the object for
this interface cannot be created stand alone and can only be obtained from a planar face. This
interface defines the plane as a point on it and the normal to the plane. The point on the plane
is called the root point.



# IADCurve Interface

IADCurve represents the interface for a Curve object in a Part or Sheet Metal workspace.
The geometry of an edge is a curve. This interface represents a generic curve and the
specific curve can be obtained by typecasting this after checking the specific curve type.

#### Syntax

```
public interface IADCurve
```

The IADCurve type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CurveType | Returns a pre-defined constant that identifies the curve type of this object. |
|  | IsClosed | Returns true if this curve is closed. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_GEOMETRY) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Curvature | Gets the curvature at the given parameter as a vector. |
|  | GetClosestPoint | Returns closest point and distance from given point. |
|  | GetParameterExtents | Gets the Parameter Extents: Start Param and End Param. |
|  | ParamAtPoint | Gets the parameter at the given point. |
|  | PointAtParam | Gets the point at the given parameter. |
|  | Tangent | Gets the tangent at the given parameter. |



# IADEdge.TopologyType Property

Returns a pre-defined constant that identifies the topology type (AD\_EDGE) of this object.

#### Syntax

```
ADTopologyType TopologyType { get; }
```

#### Property Value

ADTopologyType



# IADFace.TimeStamp Property

Returns time stamp of this face; the time stamp changes when the face is modified.

#### Syntax

```
int TimeStamp { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

This is not a time stamp in the sense of giving the time at which the face was last modified,
but rather an int which can quickly be compared to the previous value to determine if the face has changed.
By using this property, more performance-costly query of the face can be avoided when it is unnecessary.



# IADCoedges Interface

This interface represents a collection of coedges. Loops from different faces may
come together along a common coedge. That coedge represents the coincident edges,
one from each face.

#### Syntax

```
public interface IADCoedges
```

The IADCoedges type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of Co-Edges in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the part session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding Co-edge. |

#### Remarks

You can obtain the coedges for a loop using the Coedges property
of IADLoop. If an edge belongs to more than two faces,
these faces do not belong to a manifold solid. This API assumes you are working
with manifold solids.

