# AlibreX API — 3D Sketching

> Part of the split AlibreX reference. See `00_index.md` for the full map.

**Sections in this file:** 97

---


# IAD3DSketchFigures.GetFigureByID Method

Returns the 3D sketch figure for the input figure ID.

#### Syntax

```
IAD3DSketchFigure GetFigureByID(
	string ID
)
```

#### Parameters

ID  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The ID of the sketch figure to be obtained.

#### Return Value

IAD3DSketchFigure  
The figure corresponding to the input ID, or null if no figure matches the ID.



# IAD3DSketchFigures Interface

IAD3DSketchFigures interface

#### Syntax

```
public interface IAD3DSketchFigures
```

The IAD3DSketchFigures type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of figures in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Sketch | Returns the parent 3D sketch for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddBspline | Adds a 3D Bspline to the sketch given arrays of control points, knot vectors and weights. |
|  | AddBsplineByInterpolation | Creates a 3D Bspline defined by an array of interpolation points. |
|  | AddCircularArcByCenterStartEnd(IADPoint, IADPoint, IADPoint) | Adds a circular arc to the sketch given the arc center point, start point and end point. |
|  | AddCircularArcByCenterStartEnd(Double, Double, Double, Double, Double, Double, Double, Double, Double) | Adds a circular arc to the sketch given the arc center point, start point and end point. |
|  | AddLine(IADPoint, IADPoint) | Creates a line figure in the 3D sketch. |
|  | AddLine(Double, Double, Double, Double, Double, Double) | Creates a line figure in the 3D sketch. |
|  | AddPoint(IADPoint) | Creates a point figure in the 3D sketch. |
|  | AddPoint(Double, Double, Double) | Creates a point figure in the 3D sketch. |
|  | AddPolyline | Creates a 3D polyline defined by an array of points. |
|  | GetEnumerator | Returns an enumerator for the collection |
|  | GetFigureByID | Returns the 3D sketch figure for the input figure ID. |
|  | Item | Given a numerical index into the collection, returns the corresponding 3D sketch figure. |



# IAD3DSketchBspline.GetDefinition Method

Get the spline definition.

#### Syntax

```
void GetDefinition(
	out int pOrder,
	out int pNumCtlPoints,
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

pNumCtlPoints  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
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



# IAD3DSketchFigure.Type Property

Returns a pre-defined constant that identifies the type of this object.
(AD\_3D\_SKETCH\_FIGURE)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IAD3DSketchFigures.Count Property

Returns the number of figures in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

The count property for the 3D Sketch Figures object held by automation clients will
not get updated automatically when a 3D Sketch Figure is added or deleted. Get the current 3D
Sketch Figures collection by querying the 3D Sketch.



# IAD3DSketchEllipticArc.End Property

The end point of the elliptical arc.

#### Syntax

```
IAD3DSketchPoint End { get; }
```

#### Property Value

IAD3DSketchPoint



# IAD3DSketchCircle Properties

The IAD3DSketchCircle type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Center | The center point of the circle. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | ID | Gets the ID property of this 3D sketch figure. This ID is unique for the 3D sketch figure and can be used to access the 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | IsReference | Gets the flag indicating if this figure is a reference figure.  (Inherited from IAD3DSketchFigure) |
|  | Normal | The normal vector of the circle. This is the surface normal of the plane of the circle. |
|  | Radius | The radius of the circle. |
|  | Root | Returns the automation root.  (Inherited from IAD3DSketchFigure) |
|  | Sketch | Returns the 3D sketch to which this figure belongs.  (Inherited from IAD3DSketchFigure) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_3D\_SKETCH\_FIGURE)  (Inherited from IAD3DSketchFigure) |



# IAD3DSketchFigures.AddPolyline Method

Creates a 3D polyline defined by an array of points.

#### Syntax

```
IObjectCollector AddPolyline(
	in Array pPoints
)
```

#### Parameters

pPoints  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   A double array of 3D points, in the form of
    X, Y, and Z coordinates for each point.

#### Return Value

IObjectCollector  
If successful returns the created 3D Sketch Lines in
a collection, else returns null.

#### Remarks

The polyline created by this function is not a discrete figure, but rather a series of
standard line primitives with coincident constraints connecting
their endpoints.



# IAD3DSketchEllipse.MajorRadiusPoint Property

The major radius point of the ellipse.

#### Syntax

```
IAD3DSketchPoint MajorRadiusPoint { get; }
```

#### Property Value

IAD3DSketchPoint



# IAD3DSketchCircularArc.IsRightHandRule Property

Indicates whether the arc is drawn about the center from the start point to end point using right-hand rule or not.

#### Syntax

```
bool IsRightHandRule { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IAD3DSketchFigure Properties

The IAD3DSketchFigure type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FigureType | Returns a pre-defined constant that identifies the type of this 3D sketch figure. |
|  | ID | Gets the ID property of this 3D sketch figure. This ID is unique for the 3D sketch figure and can be used to access the 3D sketch figure. |
|  | IsReference | Gets the flag indicating if this figure is a reference figure. |
|  | Root | Returns the automation root. |
|  | Sketch | Returns the 3D sketch to which this figure belongs. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_3D\_SKETCH\_FIGURE) |



# IAD3DSketchFigures.AddPoint Method

#### Overload List

|  | Name | Description |
| --- | --- | --- |
|  | AddPoint(IADPoint) | Creates a point figure in the 3D sketch. |
|  | AddPoint(Double, Double, Double) | Creates a point figure in the 3D sketch. |



# IAD3DSketch.Session Property

Returns the design session for the 3D sketch.

#### Syntax

```
IADDesignSession Session { get; }
```

#### Property Value

IADDesignSession



# IAD3DSketchFigure.FigureType Property

Returns a pre-defined constant that identifies the type of this 3D sketch figure.

#### Syntax

```
ADGeometryType FigureType { get; }
```

#### Property Value

ADGeometryType

#### Remarks

Possible values for this property and their corresponding types include:

- AD\_LINE
- AD\_BSPLINE
- AD\_CIRCULAR\_ARC



# IAD3DSketch.ConsumingFeature Property

Returns the part feature consuming this sketch.

#### Syntax

```
IADPartFeature ConsumingFeature { get; }
```

#### Property Value

IADPartFeature



# IAD3DSketchFigures.AddPoint(Double, Double, Double) Method

Creates a point figure in the 3D sketch.

#### Syntax

```
IAD3DSketchPoint AddPoint(
	double x,
	double y,
	double z
)
```

#### Parameters

x  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The x-coordinate of the point.

y  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The y-coordinate of the point.

z  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The z-coordinate of the point.

#### Return Value

IAD3DSketchPoint  
If successful returns the created 3D Sketch Point
else returns null.



# IAD3DSketchLine Properties

The IAD3DSketchLine type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | End | The end point of the line. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | ID | Gets the ID property of this 3D sketch figure. This ID is unique for the 3D sketch figure and can be used to access the 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | IsReference | Gets the flag indicating if this figure is a reference figure.  (Inherited from IAD3DSketchFigure) |
|  | Length | The length of the line. |
|  | Root | Returns the automation root.  (Inherited from IAD3DSketchFigure) |
|  | Sketch | Returns the 3D sketch to which this figure belongs.  (Inherited from IAD3DSketchFigure) |
|  | Start | The start point of the line. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_3D\_SKETCH\_FIGURE)  (Inherited from IAD3DSketchFigure) |



# IAD3DSketchFigure.IsReference Property

Gets the flag indicating if this figure is a reference figure.

#### Syntax

```
bool IsReference { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IAD3DSketchCircle.Center Property

The center point of the circle.

#### Syntax

```
IAD3DSketchPoint Center { get; }
```

#### Property Value

IAD3DSketchPoint



# IAD3DSketchCircularArc.Radius Property

Returns the radius of the arc.

#### Syntax

```
double Radius { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IAD3DSketch.BeginChange Method

Method to signal that the sketch is to enter 'edit' mode. This method must be called to add or
delete any figures on the sketch. After completing the modifications on the sketch, the user needs
to call the EndChange method to save the changes done to the sketch.

#### Syntax

```
void BeginChange()
```

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_ACTIVE\_SKETCHSESSION\_EXISTS | 3D Sketch mode is already active. |

#### Remarks

This method throws an exception if an active Sketch Session already exists. EndChange
must be called to close the current Sketch Session.



# IAD3DSketches.Count Property

Returns the number of 3D design sketches in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IAD3DSketchCircularArc.End Property

Returns the End point of the arc.

#### Syntax

```
IAD3DSketchPoint End { get; }
```

#### Property Value

IAD3DSketchPoint



# IAD3DSketches Interface

IAD3DSketches interface

#### Syntax

```
public interface IAD3DSketches
```

The IAD3DSketches type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of 3D design sketches in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the design session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Add3DSketch | Creates a new 3D Sketch with the specified name. |
|  | Item | Given a numerical index or name, returns the corresponding 3D design sketch. |



# IAD3DSketchEllipse Properties

The IAD3DSketchEllipse type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Center | The center point of the ellipse. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | ID | Gets the ID property of this 3D sketch figure. This ID is unique for the 3D sketch figure and can be used to access the 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | IsReference | Gets the flag indicating if this figure is a reference figure.  (Inherited from IAD3DSketchFigure) |
|  | MajorRadiusPoint | The major radius point of the ellipse. |
|  | MinorRadiusPoint | The minor radius point of the ellipse. |
|  | Root | Returns the automation root.  (Inherited from IAD3DSketchFigure) |
|  | Sketch | Returns the 3D sketch to which this figure belongs.  (Inherited from IAD3DSketchFigure) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_3D\_SKETCH\_FIGURE)  (Inherited from IAD3DSketchFigure) |



# IAD3DSketchFigures.AddCircularArcByCenterStartEnd(IADPoint, IADPoint, IADPoint) Method

Adds a circular arc to the sketch given the arc center point, start point and end point.

#### Syntax

```
IAD3DSketchCircularArc AddCircularArcByCenterStartEnd(
	IADPoint center,
	IADPoint start,
	IADPoint end
)
```

#### Parameters

center  IADPoint
:   The center point of the arc.

start  IADPoint
:   The start point of the arc.

end  IADPoint
:   The end point of the arc.

#### Return Value

IAD3DSketchCircularArc  
If successful returns the created 3D Sketch Circular Arc
else returns null.



# IAD3DSketchFigures.AddBspline Method

Adds a 3D Bspline to the sketch given arrays of control points, knot vectors and weights.

#### Syntax

```
IAD3DSketchBspline AddBspline(
	int order,
	int numCtlPoints,
	in Array pCtlPoints,
	in Array pKnotVector,
	in Array pWeights
)
```

#### Parameters

order  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   Degree of the curve + 1. The order must be greater than one.

numCtlPoints  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The number of control points in the spline. This should be greater than the order.

pCtlPoints  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   A double array of 3D control points.

pKnotVector  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   A double array of knot vector values.

pWeights  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   A double array representing the weights at the corresponding control points.
    The size of the pWeights is equal to the number of control points.

#### Return Value

IAD3DSketchBspline  
If successful returns the created 3D Sketch Bspline Curve
else returns null.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INVALID\_POLEARRAY\_SIZE | The size of pCtlPoints was invalid. Since this array contains X, Y and Z values for each control point, it should be thrice as long as the number of control points. |
| AD\_E\_INVALID\_UKNOTARRAY\_SIZE | The size of pKnotVector was invalid. |
| AD\_E\_TOOFEW\_CTRLPOINTS | The number of control points must be greater than or equal to the order of the spline. The order must also be greater than one. |
| AD\_E\_NO\_ACTIVE\_SKETCHSESSION | The sketch to which this collection belongs does not have 3D sketch mode activated. |
| AD\_E\_INVALD\_CURRENT\_SKETCHSESSION | The sketch to which this collection belongs is no longer valid. |

#### Remarks

- The created 3D Bspline will be rational if the weights array contains some non-zero
  values, otherwise the generated curve will be non-rational.
- BeginChange must be called on the current
  3D Sketch before adding any Sketch Figures to it.
- The default units for the coordinates are Centimeters and for Angle the default
  units are radians. If the Display Units are other than these, apply the corresponding conversion
  factor to compare the results.



# IAD3DSketches Properties

The IAD3DSketches type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of 3D design sketches in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the design session for the collection. |



# IAD3DSketch Properties

The IAD3DSketch type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ConsumingFeature | Returns the part feature consuming this sketch. |
|  | Figures | Returns the collection of primitive figures in this 3D sketch. |
|  | IsActive | Gets whether the 3D sketch is active. A value of 'true' indicates that the 3D sketch is visible. ie. Neither suppressed nor below the rollback bar in the design explorer. |
|  | IsConsumed | Returns true if the 3D sketch has been consumed by a part feature. |
|  | IsSuppressed | Gets the suppression state of this 3D sketch. |
|  | Key | Gets the Persistent Key property of this 3D sketch. This Key is unique for this sketch and can be used to access the sketch. |
|  | Name | Gets/sets the name of this 3D design sketch. |
|  | Root | Returns the automation root. |
|  | Session | Returns the design session for the 3D sketch. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. |



# IAD3DSketchCircle.Normal Property

The normal vector of the circle. This is the surface normal of the plane of the circle.

#### Syntax

```
IADVector Normal { get; }
```

#### Property Value

IADVector



# IAD3DSketchBspline Methods

The IAD3DSketchBspline type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetData | Get the spline data. |
|  | GetDefinition | Get the spline definition. |



# IAD3DSketchFigures.AddPoint(IADPoint) Method

Creates a point figure in the 3D sketch.

#### Syntax

```
IAD3DSketchPoint AddPoint(
	IADPoint point
)
```

#### Parameters

point  IADPoint
:   The point where the sketch point should be created.

#### Return Value

IAD3DSketchPoint  
The newly created 3D Sketch Point.



# IAD3DSketchFigures.AddBsplineByInterpolation Method

Creates a 3D Bspline defined by an array of interpolation points.

#### Syntax

```
IAD3DSketchBspline AddBsplineByInterpolation(
	in Array pInterpolationPoints
)
```

#### Parameters

pInterpolationPoints  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   A double array of 3D interpolation points, in the form of
    X, Y, and Z coordinates for each point.

#### Return Value

IAD3DSketchBspline  
If successful returns the created 3D Sketch Bspline
else returns null.



# IAD3DSketches Methods

The IAD3DSketches type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Add3DSketch | Creates a new 3D Sketch with the specified name. |
|  | Item | Given a numerical index or name, returns the corresponding 3D design sketch. |



# IAD3DSketchPoint.IsSketchNode Property

Returns True if this figure is a sketch node.

#### Syntax

```
bool IsSketchNode { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

This property describes if the point is a standalone Node figure.
If the sketch point is the end point of a line or center point of a circle,
for instance, then this property will return false.



# IAD3DSketch Methods

The IAD3DSketch type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | BeginChange | Method to signal that the sketch is to enter 'edit' mode. This method must be called to add or delete any figures on the sketch. After completing the modifications on the sketch, the user needs to call the EndChange method to save the changes done to the sketch. |
|  | Delete | Removes the 3D sketch from the design if it is not being consumed by a feature. |
|  | EndChange | Method to signal that changes to sketch are to be committed and the sketch is to exit 'edit' mode. |



# IAD3DSketch Interface

IAD3DSketch interface

#### Syntax

```
public interface IAD3DSketch
```

The IAD3DSketch type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ConsumingFeature | Returns the part feature consuming this sketch. |
|  | Figures | Returns the collection of primitive figures in this 3D sketch. |
|  | IsActive | Gets whether the 3D sketch is active. A value of 'true' indicates that the 3D sketch is visible. ie. Neither suppressed nor below the rollback bar in the design explorer. |
|  | IsConsumed | Returns true if the 3D sketch has been consumed by a part feature. |
|  | IsSuppressed | Gets the suppression state of this 3D sketch. |
|  | Key | Gets the Persistent Key property of this 3D sketch. This Key is unique for this sketch and can be used to access the sketch. |
|  | Name | Gets/sets the name of this 3D design sketch. |
|  | Root | Returns the automation root. |
|  | Session | Returns the design session for the 3D sketch. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | BeginChange | Method to signal that the sketch is to enter 'edit' mode. This method must be called to add or delete any figures on the sketch. After completing the modifications on the sketch, the user needs to call the EndChange method to save the changes done to the sketch. |
|  | Delete | Removes the 3D sketch from the design if it is not being consumed by a feature. |
|  | EndChange | Method to signal that changes to sketch are to be committed and the sketch is to exit 'edit' mode. |



# IAD3DSketchLine.End Property

The end point of the line.

#### Syntax

```
IAD3DSketchPoint End { get; }
```

#### Property Value

IAD3DSketchPoint



# IAD3DSketchEllipticArc Properties

The IAD3DSketchEllipticArc type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Center | The center point of the elliptical arc. |
|  | End | The end point of the elliptical arc. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | ID | Gets the ID property of this 3D sketch figure. This ID is unique for the 3D sketch figure and can be used to access the 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | IsReference | Gets the flag indicating if this figure is a reference figure.  (Inherited from IAD3DSketchFigure) |
|  | IsRightHandRule | Indicates whether the arc is drawn about the center from the start point to end point using right-hand rule or not. |
|  | MajorRadiusPoint | The major radius point of the elliptical arc. |
|  | MinorRadiusPoint | The minor radius point of the elliptical arc. |
|  | Root | Returns the automation root.  (Inherited from IAD3DSketchFigure) |
|  | Sketch | Returns the 3D sketch to which this figure belongs.  (Inherited from IAD3DSketchFigure) |
|  | Start | The start point of the elliptical arc. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_3D\_SKETCH\_FIGURE)  (Inherited from IAD3DSketchFigure) |



# IAD3DSketchFigures.Item Method

Given a numerical index into the collection, returns the corresponding 3D sketch figure.

#### Syntax

```
IAD3DSketchFigure Item(
	int index
)
```

#### Parameters

index  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The numerical index of the 3D sketch figure.

#### Return Value

IAD3DSketchFigure  
Returns IAD3DSketchFigure



# IAD3DSketchFigures.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IAD3DSketchCircularArc.IncludedAngle Property

Returns the included angle of the arc in radians.

#### Syntax

```
double IncludedAngle { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IAD3DSketch.Root Property

Returns the automation root.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IAD3DSketchCircularArc.Start Property

Returns the Start point of the arc.

#### Syntax

```
IAD3DSketchPoint Start { get; }
```

#### Property Value

IAD3DSketchPoint



# IAD3DSketches.Item Method

Given a numerical index or name, returns the corresponding 3D design sketch.

#### Syntax

```
IAD3DSketch Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or numerical index of the 3D sketch.

#### Return Value

IAD3DSketch  
Returns IAD3DSketch



# IAD3DSketchCircularArc Properties

The IAD3DSketchCircularArc type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Center | Returns the center point of the arc. |
|  | End | Returns the End point of the arc. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | ID | Gets the ID property of this 3D sketch figure. This ID is unique for the 3D sketch figure and can be used to access the 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | IncludedAngle | Returns the included angle of the arc in radians. |
|  | IsReference | Gets the flag indicating if this figure is a reference figure.  (Inherited from IAD3DSketchFigure) |
|  | IsRightHandRule | Indicates whether the arc is drawn about the center from the start point to end point using right-hand rule or not. |
|  | Radius | Returns the radius of the arc. |
|  | Root | Returns the automation root.  (Inherited from IAD3DSketchFigure) |
|  | Sketch | Returns the 3D sketch to which this figure belongs.  (Inherited from IAD3DSketchFigure) |
|  | Start | Returns the Start point of the arc. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_3D\_SKETCH\_FIGURE)  (Inherited from IAD3DSketchFigure) |



# IAD3DSketchPoint Interface

This interface represents a point figure or node in the 3D sketching environment.

#### Syntax

```
public interface IAD3DSketchPoint : IAD3DSketchFigure
```

The IAD3DSketchPoint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FigureType | Returns a pre-defined constant that identifies the type of this 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | ID | Gets the ID property of this 3D sketch figure. This ID is unique for the 3D sketch figure and can be used to access the 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | IsReference | Gets the flag indicating if this figure is a reference figure.  (Inherited from IAD3DSketchFigure) |
|  | IsSketchNode | Returns True if this figure is a sketch node. |
|  | Root | Returns the automation root.  (Inherited from IAD3DSketchFigure) |
|  | Sketch | Returns the 3D sketch to which this figure belongs.  (Inherited from IAD3DSketchFigure) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_3D\_SKETCH\_FIGURE)  (Inherited from IAD3DSketchFigure) |
|  | X | Returns the X coordinate of the point. |
|  | Y | Returns the Y coordinate of the point. |
|  | Z | Returns the Z coordinate of the point. |



# IAD3DSketchFigures.AddLine(IADPoint, IADPoint) Method

Creates a line figure in the 3D sketch.

#### Syntax

```
IAD3DSketchLine AddLine(
	IADPoint start,
	IADPoint end
)
```

#### Parameters

start  IADPoint
:   The start point of the line.

end  IADPoint
:   The end point of the line.

#### Return Value

IAD3DSketchLine  
If successful returns the created 3D Sketch Line
else returns null.



# IAD3DSketches.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IAD3DSketchFigures Methods

The IAD3DSketchFigures type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddBspline | Adds a 3D Bspline to the sketch given arrays of control points, knot vectors and weights. |
|  | AddBsplineByInterpolation | Creates a 3D Bspline defined by an array of interpolation points. |
|  | AddCircularArcByCenterStartEnd(IADPoint, IADPoint, IADPoint) | Adds a circular arc to the sketch given the arc center point, start point and end point. |
|  | AddCircularArcByCenterStartEnd(Double, Double, Double, Double, Double, Double, Double, Double, Double) | Adds a circular arc to the sketch given the arc center point, start point and end point. |
|  | AddLine(IADPoint, IADPoint) | Creates a line figure in the 3D sketch. |
|  | AddLine(Double, Double, Double, Double, Double, Double) | Creates a line figure in the 3D sketch. |
|  | AddPoint(IADPoint) | Creates a point figure in the 3D sketch. |
|  | AddPoint(Double, Double, Double) | Creates a point figure in the 3D sketch. |
|  | AddPolyline | Creates a 3D polyline defined by an array of points. |
|  | GetEnumerator | Returns an enumerator for the collection |
|  | GetFigureByID | Returns the 3D sketch figure for the input figure ID. |
|  | Item | Given a numerical index into the collection, returns the corresponding 3D sketch figure. |



# IAD3DSketchEllipticArc.Start Property

The start point of the elliptical arc.

#### Syntax

```
IAD3DSketchPoint Start { get; }
```

#### Property Value

IAD3DSketchPoint



# IAD3DSketch.Key Property

Gets the Persistent Key property of this 3D sketch. This Key is unique for
this sketch and can be used to access the sketch.

#### Syntax

```
Array Key { get; }
```

#### Property Value

[Array](https://learn.microsoft.com/dotnet/api/system.array)



# IAD3DSketchBspline Properties

The IAD3DSketchBspline type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EndPoint | The end point of the BSpline sketch figure. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | ID | Gets the ID property of this 3D sketch figure. This ID is unique for the 3D sketch figure and can be used to access the 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | IsReference | Gets the flag indicating if this figure is a reference figure.  (Inherited from IAD3DSketchFigure) |
|  | Root | Returns the automation root.  (Inherited from IAD3DSketchFigure) |
|  | Sketch | Returns the 3D sketch to which this figure belongs.  (Inherited from IAD3DSketchFigure) |
|  | StartPoint | The start point of the BSpline sketch figure. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_3D\_SKETCH\_FIGURE)  (Inherited from IAD3DSketchFigure) |



# IAD3DSketch.Name Property

Gets/sets the name of this 3D design sketch.

#### Syntax

```
string Name { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IAD3DSketchCircle Interface

This interface represents a circle figure in the 3D sketching environment.

#### Syntax

```
public interface IAD3DSketchCircle : IAD3DSketchFigure
```

The IAD3DSketchCircle type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Center | The center point of the circle. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | ID | Gets the ID property of this 3D sketch figure. This ID is unique for the 3D sketch figure and can be used to access the 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | IsReference | Gets the flag indicating if this figure is a reference figure.  (Inherited from IAD3DSketchFigure) |
|  | Normal | The normal vector of the circle. This is the surface normal of the plane of the circle. |
|  | Radius | The radius of the circle. |
|  | Root | Returns the automation root.  (Inherited from IAD3DSketchFigure) |
|  | Sketch | Returns the 3D sketch to which this figure belongs.  (Inherited from IAD3DSketchFigure) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_3D\_SKETCH\_FIGURE)  (Inherited from IAD3DSketchFigure) |



# IAD3DSketch.IsConsumed Property

Returns true if the 3D sketch has been consumed by a part feature.

#### Syntax

```
bool IsConsumed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IAD3DSketchBspline.EndPoint Property

The end point of the BSpline sketch figure.

#### Syntax

```
IADPoint EndPoint { get; }
```

#### Property Value

IADPoint



# IAD3DSketch.Delete Method

Removes the 3D sketch from the design if it is not being consumed by a feature.

#### Syntax

```
void Delete()
```



# IAD3DSketchBspline.GetData Method

Get the spline data.

#### Syntax

```
void GetData(
	out Array pCtlPoints,
	out Array pKnotVector,
	out Array pWeights
)
```

#### Parameters

pCtlPoints  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   Coordinates of the control points for the b-spline curve.
    Hence its size is equal to three times the number of control points.

pKnotVector  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   Array of knot values. These are always in ascending order.
    It determines the degree of the b-spline curve.

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



# IAD3DSketchPoint.X Property

Returns the X coordinate of the point.

#### Syntax

```
double X { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IAD3DSketchFigures.Sketch Property

Returns the parent 3D sketch for the collection.

#### Syntax

```
IAD3DSketch Sketch { get; }
```

#### Property Value

IAD3DSketch



# IAD3DSketchFigures.AddLine(Double, Double, Double, Double, Double, Double) Method

Creates a line figure in the 3D sketch.

#### Syntax

```
IAD3DSketchLine AddLine(
	double x1,
	double y1,
	double z1,
	double x2,
	double y2,
	double z2
)
```

#### Parameters

x1  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The x-coordinate of the start point.

y1  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The y-coordinate of the start point.

z1  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The z-coordinate of the start point.

x2  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The x-coordinate of the end point.

y2  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The y-coordinate of the end point.

z2  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The z-coordinate of the end point.

#### Return Value

IAD3DSketchLine  
If successful returns the created 3D Sketch Line
else returns null.



# IAD3DSketchFigures Properties

The IAD3DSketchFigures type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of figures in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Sketch | Returns the parent 3D sketch for the collection. |



# IAD3DSketchEllipticArc.MinorRadiusPoint Property

The minor radius point of the elliptical arc.

#### Syntax

```
IAD3DSketchPoint MinorRadiusPoint { get; }
```

#### Property Value

IAD3DSketchPoint



# IAD3DSketchFigures.AddCircularArcByCenterStartEnd Method

#### Overload List

|  | Name | Description |
| --- | --- | --- |
|  | AddCircularArcByCenterStartEnd(IADPoint, IADPoint, IADPoint) | Adds a circular arc to the sketch given the arc center point, start point and end point. |
|  | AddCircularArcByCenterStartEnd(Double, Double, Double, Double, Double, Double, Double, Double, Double) | Adds a circular arc to the sketch given the arc center point, start point and end point. |



# IAD3DSketchFigures.AddLine Method

#### Overload List

|  | Name | Description |
| --- | --- | --- |
|  | AddLine(IADPoint, IADPoint) | Creates a line figure in the 3D sketch. |
|  | AddLine(Double, Double, Double, Double, Double, Double) | Creates a line figure in the 3D sketch. |



# IAD3DSketchEllipse.MinorRadiusPoint Property

The minor radius point of the ellipse.

#### Syntax

```
IAD3DSketchPoint MinorRadiusPoint { get; }
```

#### Property Value

IAD3DSketchPoint



# IAD3DSketchCircularArc Interface

This interface represents a circular arc figure in the 3D sketching environment.

#### Syntax

```
public interface IAD3DSketchCircularArc : IAD3DSketchFigure
```

The IAD3DSketchCircularArc type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Center | Returns the center point of the arc. |
|  | End | Returns the End point of the arc. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | ID | Gets the ID property of this 3D sketch figure. This ID is unique for the 3D sketch figure and can be used to access the 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | IncludedAngle | Returns the included angle of the arc in radians. |
|  | IsReference | Gets the flag indicating if this figure is a reference figure.  (Inherited from IAD3DSketchFigure) |
|  | IsRightHandRule | Indicates whether the arc is drawn about the center from the start point to end point using right-hand rule or not. |
|  | Radius | Returns the radius of the arc. |
|  | Root | Returns the automation root.  (Inherited from IAD3DSketchFigure) |
|  | Sketch | Returns the 3D sketch to which this figure belongs.  (Inherited from IAD3DSketchFigure) |
|  | Start | Returns the Start point of the arc. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_3D\_SKETCH\_FIGURE)  (Inherited from IAD3DSketchFigure) |



# IAD3DSketchBspline.StartPoint Property

The start point of the BSpline sketch figure.

#### Syntax

```
IADPoint StartPoint { get; }
```

#### Property Value

IADPoint



# IAD3DSketchEllipticArc.IsRightHandRule Property

Indicates whether the arc is drawn about the center from the start point to end point using right-hand rule or not.

#### Syntax

```
bool IsRightHandRule { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IAD3DSketch.IsActive Property

Gets whether the 3D sketch is active. A value of 'true' indicates that the 3D sketch is
visible. ie. Neither suppressed nor below the rollback bar in the design explorer.

#### Syntax

```
bool IsActive { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IAD3DSketchPoint.Y Property

Returns the Y coordinate of the point.

#### Syntax

```
double Y { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IAD3DSketches.Session Property

Returns the design session for the collection.

#### Syntax

```
IADDesignSession Session { get; }
```

#### Property Value

IADDesignSession



# IAD3DSketches.Add3DSketch Method

Creates a new 3D Sketch with the specified name.

#### Syntax

```
IAD3DSketch Add3DSketch(
	string name
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name for the new 3D Sketch. If blank or null a name will be automatically generated.

#### Return Value

IAD3DSketch  
The newly created 3D Sketch.



# IAD3DSketchFigure.Root Property

Returns the automation root.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IAD3DSketchLine.Start Property

The start point of the line.

#### Syntax

```
IAD3DSketchPoint Start { get; }
```

#### Property Value

IAD3DSketchPoint



# IAD3DSketchFigures.GetEnumerator Method

Returns an enumerator for the collection

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IAD3DSketchFigure.ID Property

Gets the ID property of this 3D sketch figure. This ID is unique for
the 3D sketch figure and can be used to access the 3D sketch figure.

#### Syntax

```
string ID { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IAD3DSketchLine.Length Property

The length of the line.

#### Syntax

```
double Length { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IAD3DSketchEllipticArc.Center Property

The center point of the elliptical arc.

#### Syntax

```
IAD3DSketchPoint Center { get; }
```

#### Property Value

IAD3DSketchPoint



# IAD3DSketch.Figures Property

Returns the collection of primitive figures in this 3D sketch.

#### Syntax

```
IAD3DSketchFigures Figures { get; }
```

#### Property Value

IAD3DSketchFigures



# IAD3DSketch.IsSuppressed Property

Gets the suppression state of this 3D sketch.

#### Syntax

```
bool IsSuppressed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IAD3DSketchCircularArc.Center Property

Returns the center point of the arc.

#### Syntax

```
IAD3DSketchPoint Center { get; }
```

#### Property Value

IAD3DSketchPoint



# IAD3DSketchFigure.Sketch Property

Returns the 3D sketch to which this figure belongs.

#### Syntax

```
IAD3DSketch Sketch { get; }
```

#### Property Value

IAD3DSketch



# IAD3DSketchPoint.Z Property

Returns the Z coordinate of the point.

#### Syntax

```
double Z { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IAD3DSketchCircle.Radius Property

The radius of the circle.

#### Syntax

```
double Radius { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IAD3DSketchEllipse Interface

This interface represents an ellipse figure in the 3D sketching environment.

#### Syntax

```
public interface IAD3DSketchEllipse : IAD3DSketchFigure
```

The IAD3DSketchEllipse type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Center | The center point of the ellipse. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | ID | Gets the ID property of this 3D sketch figure. This ID is unique for the 3D sketch figure and can be used to access the 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | IsReference | Gets the flag indicating if this figure is a reference figure.  (Inherited from IAD3DSketchFigure) |
|  | MajorRadiusPoint | The major radius point of the ellipse. |
|  | MinorRadiusPoint | The minor radius point of the ellipse. |
|  | Root | Returns the automation root.  (Inherited from IAD3DSketchFigure) |
|  | Sketch | Returns the 3D sketch to which this figure belongs.  (Inherited from IAD3DSketchFigure) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_3D\_SKETCH\_FIGURE)  (Inherited from IAD3DSketchFigure) |



# IAD3DSketch.Type Property

Returns a pre-defined constant that identifies the type of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IAD3DSketchPoint Properties

The IAD3DSketchPoint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FigureType | Returns a pre-defined constant that identifies the type of this 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | ID | Gets the ID property of this 3D sketch figure. This ID is unique for the 3D sketch figure and can be used to access the 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | IsReference | Gets the flag indicating if this figure is a reference figure.  (Inherited from IAD3DSketchFigure) |
|  | IsSketchNode | Returns True if this figure is a sketch node. |
|  | Root | Returns the automation root.  (Inherited from IAD3DSketchFigure) |
|  | Sketch | Returns the 3D sketch to which this figure belongs.  (Inherited from IAD3DSketchFigure) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_3D\_SKETCH\_FIGURE)  (Inherited from IAD3DSketchFigure) |
|  | X | Returns the X coordinate of the point. |
|  | Y | Returns the Y coordinate of the point. |
|  | Z | Returns the Z coordinate of the point. |



# IAD3DSketchFigures.AddCircularArcByCenterStartEnd(Double, Double, Double, Double, Double, Double, Double, Double, Double) Method

Adds a circular arc to the sketch given the arc center point, start point and end point.

#### Syntax

```
IAD3DSketchCircularArc AddCircularArcByCenterStartEnd(
	double XCenter,
	double YCenter,
	double ZCenter,
	double XStartPt,
	double YStartPt,
	double ZStartPt,
	double XEndPt,
	double YEndPt,
	double ZEndPt
)
```

#### Parameters

XCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the center point.

YCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the center point.

ZCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Z coordinate of the center point.

XStartPt  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the start point.

YStartPt  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the start point.

ZStartPt  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Z coordinate of the start point.

XEndPt  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the end point.

YEndPt  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the end point.

ZEndPt  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Z coordinate of the end point.

#### Return Value

IAD3DSketchCircularArc  
If successful returns the created 3D Sketch Circular Arc
else returns null.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_NO\_ACTIVE\_SKETCHSESSION | The sketch to which this collection belongs does not have 3D sketch mode activated. |
| AD\_E\_INVALD\_CURRENT\_SKETCHSESSION | The sketch to which this collection belongs is no longer valid. |
| AD\_E\_COLLINEAR\_POINTS | The start and end points cannot be the same. |

#### Remarks

- BeginChange must be called on the current
  3D Sketch before adding any 3D Sketch Figures to it.
- The default units for the coordinates are Centimeters and for Angle the default
  units are radians. If the Display Units are other than these, apply the corresponding conversion
  factor to compare the results.



# IAD3DSketchLine Interface

This interface represents a line figure in the 3D sketching environment.

#### Syntax

```
public interface IAD3DSketchLine : IAD3DSketchFigure
```

The IAD3DSketchLine type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | End | The end point of the line. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | ID | Gets the ID property of this 3D sketch figure. This ID is unique for the 3D sketch figure and can be used to access the 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | IsReference | Gets the flag indicating if this figure is a reference figure.  (Inherited from IAD3DSketchFigure) |
|  | Length | The length of the line. |
|  | Root | Returns the automation root.  (Inherited from IAD3DSketchFigure) |
|  | Sketch | Returns the 3D sketch to which this figure belongs.  (Inherited from IAD3DSketchFigure) |
|  | Start | The start point of the line. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_3D\_SKETCH\_FIGURE)  (Inherited from IAD3DSketchFigure) |



# IAD3DSketchFigure Interface

IAD3DSketchFigure is the interface for a 3D Sketch Figure object in a Part or Sheet Metal workspace.

#### Syntax

```
public interface IAD3DSketchFigure
```

The IAD3DSketchFigure type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FigureType | Returns a pre-defined constant that identifies the type of this 3D sketch figure. |
|  | ID | Gets the ID property of this 3D sketch figure. This ID is unique for the 3D sketch figure and can be used to access the 3D sketch figure. |
|  | IsReference | Gets the flag indicating if this figure is a reference figure. |
|  | Root | Returns the automation root. |
|  | Sketch | Returns the 3D sketch to which this figure belongs. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_3D\_SKETCH\_FIGURE) |



# IAD3DSketchEllipticArc Interface

This interface represents an elliptic arc figure in the 3D sketching environment.

#### Syntax

```
public interface IAD3DSketchEllipticArc : IAD3DSketchFigure
```

The IAD3DSketchEllipticArc type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Center | The center point of the elliptical arc. |
|  | End | The end point of the elliptical arc. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | ID | Gets the ID property of this 3D sketch figure. This ID is unique for the 3D sketch figure and can be used to access the 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | IsReference | Gets the flag indicating if this figure is a reference figure.  (Inherited from IAD3DSketchFigure) |
|  | IsRightHandRule | Indicates whether the arc is drawn about the center from the start point to end point using right-hand rule or not. |
|  | MajorRadiusPoint | The major radius point of the elliptical arc. |
|  | MinorRadiusPoint | The minor radius point of the elliptical arc. |
|  | Root | Returns the automation root.  (Inherited from IAD3DSketchFigure) |
|  | Sketch | Returns the 3D sketch to which this figure belongs.  (Inherited from IAD3DSketchFigure) |
|  | Start | The start point of the elliptical arc. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_3D\_SKETCH\_FIGURE)  (Inherited from IAD3DSketchFigure) |



# IAD3DSketchEllipse.Center Property

The center point of the ellipse.

#### Syntax

```
IAD3DSketchPoint Center { get; }
```

#### Property Value

IAD3DSketchPoint



# IAD3DSketch.EndChange Method

Method to signal that changes to sketch are to be committed and the sketch is to exit 'edit' mode.

#### Syntax

```
void EndChange()
```



# IAD3DSketchBspline Interface

This interface represents a B-Spline figure in the 3D sketching environment.

#### Syntax

```
public interface IAD3DSketchBspline : IAD3DSketchFigure
```

The IAD3DSketchBspline type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EndPoint | The end point of the BSpline sketch figure. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | ID | Gets the ID property of this 3D sketch figure. This ID is unique for the 3D sketch figure and can be used to access the 3D sketch figure.  (Inherited from IAD3DSketchFigure) |
|  | IsReference | Gets the flag indicating if this figure is a reference figure.  (Inherited from IAD3DSketchFigure) |
|  | Root | Returns the automation root.  (Inherited from IAD3DSketchFigure) |
|  | Sketch | Returns the 3D sketch to which this figure belongs.  (Inherited from IAD3DSketchFigure) |
|  | StartPoint | The start point of the BSpline sketch figure. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_3D\_SKETCH\_FIGURE)  (Inherited from IAD3DSketchFigure) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetData | Get the spline data. |
|  | GetDefinition | Get the spline definition. |



# IAD3DSketchEllipticArc.MajorRadiusPoint Property

The major radius point of the elliptical arc.

#### Syntax

```
IAD3DSketchPoint MajorRadiusPoint { get; }
```

#### Property Value

IAD3DSketchPoint

