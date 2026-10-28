# AlibreX API — 2D Sketching

> Part of the split AlibreX reference. See `00_index.md` for the full map.

**Sections in this file:** 168

---


# IADSketch.IsSuppressed Property

Gets the suppression state of this sketch.

#### Syntax

```
bool IsSuppressed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADSketchCircle Interface

This interface represents a 2D Circular Figure in the sketching environment.

#### Syntax

```
public interface IADSketchCircle : IADSketchFigure
```

The IADSketchCircle type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Center | Returns the center point of the circle. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | Radius | Returns the radius of the circle. |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |

#### Example

This Visual Basic sample demonstrates adding a sketch cirlce of five units radius with (0,0) as the origin and querying the radius and center.

```
' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Holds XY-Plane
Set objADDesignPlane = objADDesignSession.DesignPlanes("XY-Plane")

' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session object from existing session
Set objADPartSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a new sketch to the above Design Plane.
Set objADSketch = objADSketches.AddSketch( _
        Nothing, objADDesignPlane, "NewSketch")

' Initiate Sketch edit mode
Call objADSketch.BeginChange

' Holds Sketch Figures object
Dim objADSketchFigures As AlibreX.IADSketchFigures

' Get Sketch Figures from Sketch object
Set objADSketchFigures = objADSketch.Figures

' Holds Sketch Circle
Dim objADSketchCircle As AlibreX.IADSketchCircle

' Add Sketch Circle
Set objADSketchCircle = objADSketchFigures.AddCircle(0, 0, 5)

' Exit Sketch edit mode
Call objADSketch.EndChange

' Holds radius
Dim dblRadius As Double

' Get Circle Radius
dblRadius = objADSketchCircle.Radius()

' Holds Sketch Point
Dim objSketchPoint As IADSketchPoint

' Get Circle Center
Set objSketchPoint = objADSketchCircle.Center()
```



# IADSketchFigure.IsReference Property

Gets/Sets the flag indicating if this figure is a reference figure.

#### Syntax

```
bool IsReference { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADSketchCircularArc Interface

This interface represents a 2D Circular Arc in the sketching environment.

#### Syntax

```
public interface IADSketchCircularArc : IADSketchFigure
```

The IADSketchCircularArc type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Center | Returns the center point of the arc. |
|  | End | Returns the End point of the arc. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IncludedAngle | Returns the included angle of the arc in radians. |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | IsRightHandRule | Indicates whether the arc is drawn about the center from the start point to end point using right-hand rule or not. |
|  | Radius | Returns the radius of the arc. |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | Start | Returns the Start point of the arc. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |

#### Example

This Visual Basic demonstrates the usage of sketch circular arc related properties and methods.

```
' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Holds XY-Plane
Set objADDesignPlane = objADDesignSession.DesignPlanes("XY-Plane")

' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session object from existing session
Set objADPartSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a new sketch to the above Design Plane.
Set objADSketch = objADSketches.AddSketch( _
        Nothing, objADDesignPlane, "NewSketch")

' Initiate Sketch edit mode
Call objADSketch.BeginChange

' Holds Sketch Figures object
Dim objADSketchFigures As AlibreX.IADSketchFigures

' Get Sketch Figures from Sketch object
Set objADSketchFigures = objADSketch.Figures

' Holds Sketch Circular Arc
Dim objADSketchCircularArc As AlibreX.IADSketchCircularArc

' Add Circular Arc
Set objADSketchCircularArc = objADSketchFigures.AddCircularArc(0, 0, 1, 0, 3.14)

' Exit Sketch edit mode
Call objADSketch.EndChange

' Holds Center
Dim objCenterPoint As AlibreX.IADSketchPoint

' Get Center
Set objCenterPoint = objADSketchCircularArc.Center()

' Holds Start Point
Dim objStartPoint As AlibreX.IADSketchPoint

' Get Start Point
Set objStartPoint = objADSketchCircularArc.Start()

' Holds End Point
Dim objEndPoint As AlibreX.IADSketchPoint

' Get End Point
Set objEndPoint = objADSketchCircularArc.End()

' Holds included angle
Dim dblIncludedAngle As Double

' Get Included angle
dblIncludedAngle = objADSketchCircularArc.IncludedAngle()

' Holds Radius
Dim dblRadius As Double

' Get Radius
dblRadius = objADSketchCircularArc.Radius()
```



# IADSketchFigure.Root Property

Returns the automation root.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# ISketchDegenerateFigure Interface

ISketchDegenerateFigure interface

#### Syntax

```
public interface ISketchDegenerateFigure
```



# IADSketchConstraint.Session Property

Returns the part session for the collection.

#### Syntax

```
IADDesignSession Session { get; }
```

#### Property Value

IADDesignSession



# IADSketch.SketchConstraints Property

Returns the collection of constraints associated with this sketch.

#### Syntax

```
IADSketchConstraints SketchConstraints { get; }
```

#### Property Value

IADSketchConstraints



# IADSketches.Item Method

Given a name or index, returns the corresponding design sketch.

#### Syntax

```
IADSketch Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The integer index or name string for the sketch.

#### Return Value

IADSketch  
Returns IADSketch



# IADComplexSketchFigure Methods

The IADComplexSketchFigure type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |



# IADSketchEllipse.Center Property

Returns the center point of the ellipse.

#### Syntax

```
IADSketchPoint Center { get; }
```

#### Property Value

IADSketchPoint



# IADSketchCircularArc Methods

The IADSketchCircularArc type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |



# IADSketchFigure.Sketch Property

Returns the sketch to which this figure belongs.

#### Syntax

```
IADSketch Sketch { get; }
```

#### Property Value

IADSketch



# IADSketch.EndChange Method

Method to signal that changes to sketch are to be committed and the sketch is to exit 'edit' mode.

#### Syntax

```
void EndChange()
```



# IADSketchFigure Interface

IADSketchFigure is the interface for a Sketch Figure object in a Part or Sheet Metal workspace.

#### Syntax

```
public interface IADSketchFigure
```

The IADSketchFigure type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure. |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure. |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored. |
|  | IsOwned | Returns true if the sketch figure is owned by a shape. |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure. |
|  | Root | Returns the automation root. |
|  | Sketch | Returns the sketch to which this figure belongs. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure. |



# IADSketchEllipse Methods

The IADSketchEllipse type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |



# IADSketchFigure.Delete Method

Deletes this sketch figure.

#### Syntax

```
void Delete()
```

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INVALD\_CURRENT\_SKETCHSESSION | The sketch containing this figure is not valid. |

#### Remarks

- BeginChange or BeginChangeEx must be called on IADSketch
  before calling this method to set the appropriate current sketch session.
- The IADSketchFigures collection held by the automation client
  will not be updated after Adding/Deleting an item. Get a fresh collection from the Sketch to
  get the updated items of the Sketch Figures.
- If any query is executed on a deleted Sketch Figure, an exception will be thrown with
  CustomError.AD\_E\_INVALID\_OBJECT.



# IADSketchLine.Length Property

The length of the line.

#### Syntax

```
double Length { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADSketchEllipticArc.MinorMajorRatio Property

Gets the ratio of minor axis ot the major axis.

#### Syntax

```
double MinorMajorRatio { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADSketchFigures.AddCircularArcByCenterStartAngle Method

Adds a circular arc to the sketch given the arc center point, arc start point and an arc
angle which follows right hand rule.

#### Syntax

```
IADSketchCircularArc AddCircularArcByCenterStartAngle(
	double XCenter,
	double YCenter,
	double XStartPt,
	double YStartPt,
	double ArcAngle
)
```

#### Parameters

XCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the center point.

YCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the center point.

XStartPt  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the start point.

YStartPt  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the start point.

ArcAngle  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The included angle of the arc in radians following the right hand rule.

#### Return Value

IADSketchCircularArc  
If successful returns the created Sketch Circular Arc
else returns null.

#### Remarks

- If the Arc angle is negative the Arc will be created in opposite direction to
  the right hand rule.
- BeginChange or BeginChangeEx must be called on the current
  Sketch before adding any Sketch Figures to it.
- The default units for the coordinates are Centimeters and for Angle the default
  units are radians. If the Display Units are other than these, apply the corresponding conversion
  factor to compare the results.

#### Example

This Visual Basic sample shows how to call the AddCircularArcByCenterStartAngle method.

```
' Example Description: Demonstrates adding a sketch
' Circular arc with (0, 0) as origin, (1, 0) as Start Point
' and 3.14 radians as included angle.

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Holds XY-Plane
Set objADDesignPlane = objADDesignSession.DesignPlanes("XY-Plane")

' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session object from existing session
Set objADPartSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a new sketch to the above Design Plane.
Set objADSketch = objADSketches.AddSketch( _
        Nothing, objADDesignPlane, "NewSketch")

' Initiate Sketch edit mode
Call objADSketch.BeginChange

' Holds Sketch Figures object
Dim objADSketchFigures As AlibreX.IADSketchFigures

' Get Sketch Figures from Sketch object
Set objADSketchFigures = objADSketch.Figures

' Holds Sketch Circular Arc
Dim objADSketchCircularArc As AlibreX.IADSketchCircularArc

' Add Circular Arc
Set objADSketchCircularArc = objADSketchFigures.AddCircularArc(0, 0, 1, 0, 3.14)

' Exit Sketch edit mode
Call objADSketch.EndChange
```



# IADSketchCircularArc.Center Property

Returns the center point of the arc.

#### Syntax

```
IADSketchPoint Center { get; }
```

#### Property Value

IADSketchPoint



# IADSketch.MapFromWorldToSketch Method

Method to transform a point defined in 3D world coordinate system into the sketch's 2D local coordinate system.

#### Syntax

```
void MapFromWorldToSketch(
	IADPoint xyzPoint,
	out double uCoord,
	out double vCoord
)
```

#### Parameters

xyzPoint  IADPoint
:   The input 3D world coordinate system point.

uCoord  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The output u coordinate of the 3D point's location in the 2D sketch.

vCoord  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The output v coordinate of the 3D point's location in the 2D sketch.

#### Example

This Visual Basic sample shows how to call the MapFromWorldToSketch method.

```
' Example Description: Demonstrates mapping of world coordinate system to a
' Sketch coordinate system and creation of a circle at the obtained coordinates.

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Holds ZX-Plane
Set objADDesignPlane = objADDesignSession.DesignPlanes("ZX-Plane")

' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session object from existing session
Set objADPartSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a new sketch to the above Design Plane.
Set objADSketch = objADSketches.AddSketch( _
        Nothing, objADDesignPlane, "NewSketch")

' Holds Geometry Factory
Dim objADGeometryFactory As AlibreX.IADGeometryFactory

' Get Geometry Factory from Session object
Set objADGeometryFactory = m_objADSession.GeometryFactory

' Holds Point
Dim objADPoint As AlibreX.IADPoint

' Create a point at (1, 2, 3)
Set objADPoint = objADGeometryFactory.CreatePoint(1, 2, 3)

' Holds U Co-Ordinate
Dim dblU As Double

' Holds V Co-Ordinate
Dim dblV As Double

' Get the location of the created point in 2D sketch coordinates
Call objADSketch.MapFromWorldToSketch(objADPoint, dblU, dblV)

' Initiate Sketch edit mode
Call objADSketch.BeginChange

' Holds Sketch Circle
Dim objADSketchCircle As AlibreX.IADSketchCircle

' Add a Sketch Circle with its center at location of the point we created
Set objADSketchCircle = objADSketch.Figures.AddCircle(dblU, dblV, 5)

' Exit Sketch edit mode
Call objADSketch.EndChange
```



# IADSketchCircularArc.IsRightHandRule Property

Indicates whether the arc is drawn about the center from the start point to end point using right-hand rule or not.

#### Syntax

```
bool IsRightHandRule { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADSketch.GetExtents Method

Returns lower left corner and upper right corner of the 3D Range Box for this sketch.

#### Syntax

```
void GetExtents(
	out IAD2DPoint ppLower,
	out IAD2DPoint ppUpper
)
```

#### Parameters

ppLower  IAD2DPoint
:   Lower left corner of the range box bounding the sketch.

ppUpper  IAD2DPoint
:   Upper right corner of the range box bounding the sketch.

#### Example

This Visual Basic sample shows how to call the GetExtents method.

```
' Example Description: Demonstrates accessing Sketch Extents information.
' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Holds XY-Plane
Set objADDesignPlane = objADDesignSession.DesignPlanes("XY-Plane")

' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session object from existing session
Set objADPartSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a new sketch to the above Design Plane.
Set objADSketch = objADSketches.AddSketch( _
        Nothing, objADDesignPlane, "NewSketch")

' Initiate Sketch edit mode
Call objADSketch.BeginChange

' Holds Sketch Circle
Dim objADSketchCircle As AlibreX.IADSketchCircle

' Add Sketch Circle
Set objADSketchCircle = objADSketch.Figures.AddCircle(0, 0, 5)

' Exit Sketch edit mode
Call objADSketch.EndChange

' Points to hold Sketch extents
Dim objLowerPoint As AlibreX.IAD2DPoint
Dim objUpperPoint As AlibreX.IAD2DPoint

' Get Extents of the Sketch
Call objADSketch.GetExtents(objLowerPoint, objUpperPoint)
```



# IADCompositeFigure.Item Method

Given a numerical index into the collection, returns the corresponding constituent sketch figure.

#### Syntax

```
IADSketchFigure Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The index of the constituent figure.

#### Return Value

IADSketchFigure  
Returns IADSketchFigure



# IADSketchBspline.GetDefinition Method

Get the Bspline's Definition

#### Syntax

```
void GetDefinition(
	out int pOrder,
	out int pNumCtlPoints,
	out int pNumKnots,
	out bool pIsRational,
	out bool pIsClosed,
	out bool pIsPeriodic
)
```

#### Parameters

pOrder  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The order of the spline.

pNumCtlPoints  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The number of control points in the spline.
    This will be greater than or equal to the order of the curve.

pNumKnots  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The number of knot vectors in the spline.

pIsRational  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Whether the spline is rational or not.

pIsClosed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Whether the spline is closed or not.

pIsPeriodic  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Whether the spline is periodic or not.



# IADSketchFigures.AddCircularArc Method

Adds a circular arc to the sketch given the arc center point, arc start point and an arc angle which follows right hand rule.

#### Syntax

```
IADSketchCircularArc AddCircularArc(
	double XCenter,
	double YCenter,
	double XStartPt,
	double YStartPt,
	double ArcAngle
)
```

#### Parameters

XCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the center point of the circular arc.

YCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the center point of the circular arc.

XStartPt  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the start point of the circular arc.

YStartPt  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the start point of the circular arc.

ArcAngle  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The included angle of the arc in radians.

#### Return Value

IADSketchCircularArc  
If successful returns the created Sketch Circular Arc
else returns null.

#### Remarks

WARNING: This Method is OBSOLETE. Please use
AddCircularArcByCenterStartAngle instead.



# IAnalyzedSketchData Interface

IAnalyzedSketchData represents the results of an analysis of a 2D sketch for possible
errors. These errors are things which could cause a feature created with the sketch
to fail. To get this information for a sketch, use that sketch's
Analyze method.

#### Syntax

```
public interface IAnalyzedSketchData
```

The IAnalyzedSketchData type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DegenerateFigures | Returns an IObjectCollector of ISketchDegenerateFigure. |
|  | DisjointEnds | Returns an IObjectCollector of ISketchFigureDisjointEnd. |
|  | Intersections | Returns an IObjectCollector of ISketchFigureOverlap. |
|  | OpenLoops | Returns an IObjectCollector of ISketchFigureOpenLoops. |
|  | OverLaps | Returns an IObjectCollector of ISketchFigureIntersection. |



# IADSketchShapePattern Interface

IADSketchShapePattern represents Shape or Shape Pattern sketch figures. In the GUI these
are the figures under the Sketch->Shape menu. The shape has an underlying
composite figure, which is a collection of the
sketch figures which compose the shape.

#### Syntax

```
public interface IADSketchShapePattern : IADComplexSketchFigure, 
	IADSketchFigure
```

The IADSketchShapePattern type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CompositeFigure | Returns the IADCompositeFigure containing the collection of sketch figures which make up the shape. It is possible for the composite figure to contain shape pattern figures as well. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |

#### Remarks

Currently only the CompositeFigure property is available to allow the
shape's geometry to be queried. In the future, properties to get the parameters of
the shape and its pattern will be added as well.



# IADSketchLine.Start Property

The start point of the line.

#### Syntax

```
IADSketchPoint Start { get; }
```

#### Property Value

IADSketchPoint



# IADSketches Interface

IADSketches represents interface for a collection of Sketch objects.

#### Syntax

```
public interface IADSketches
```

The IADSketches type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of design sketches in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the design session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddSketch | Adds a new Sketch in the Part workspace and returns the newly created Sketch. |
|  | Item | Given a name or index, returns the corresponding design sketch. |



# IADSketch.Type Property

Returns a pre-defined constant that identifies the type (AD\_SKETCH) of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADSketchConstraints Methods

The IADSketchConstraints type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddConstraint | Creates a new constraint. |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given a numerical index into the collection, returns the corresponding constraint. |



# IADSketch.Session Property

Returns the design session containing this sketch.

#### Syntax

```
IADDesignSession Session { get; }
```

#### Property Value

IADDesignSession



# IADSketchConstraint.SketchConstraintType Property

Returns the constraint type. (Horizontal/Vertical/Coincident/etc...)

#### Syntax

```
ADSketchConstraintType SketchConstraintType { get; }
```

#### Property Value

ADSketchConstraintType



# IADSketchFigure.Type Property

Returns a pre-defined constant that identifies the type of this object.
(AD\_SKETCH\_FIGURE)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADSketchConstraints.Sketch Property

Returns the parent sketch for the collection.

#### Syntax

```
IADSketch Sketch { get; }
```

#### Property Value

IADSketch



# IADSketch.MapFromSketchToWorld Method

Method to transform a point defined in the sketch's 2D local coordinate system into 3D world coordinate system.

#### Syntax

```
void MapFromSketchToWorld(
	double uCoord,
	double vCoord,
	out IADPoint xyzPoint
)
```

#### Parameters

uCoord  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The input local u coordinate.

vCoord  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The input local v coordinate.

xyzPoint  IADPoint
:   The output 3D world coordinate system point.



# IADSketchConstraint Interface

IADSketchConstraint represents a sketch constraint.

#### Syntax

```
public interface IADSketchConstraint
```

The IADSketchConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Root | Returns the automation root object. |
|  | Session | Returns the part session for the collection. |
|  | SketchConstraintType | Returns the constraint type. (Horizontal/Vertical/Coincident/etc...) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_CONSTRAINT) |



# IADSketchFigures Properties

The IADSketchFigures type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of figures in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Sketch | Returns the parent sketch for the collection. |



# IADSketchConstraints.AddConstraint Method

Creates a new constraint.

#### Syntax

```
bool AddConstraint(
	IObjectCollector targets,
	ADSketchConstraintType type
)
```

#### Parameters

targets  IObjectCollector
:   A collection of sketch figure to add the constraint upon.

type  ADSketchConstraintType
:   The type of constraint to be created.

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)  
The newly created constraint.



# IADSketchConstraints.GetEnumerator Method

Returns an enumerator for the collection.

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADSketchEllipticArc.MajorAxisAngle Property

Gets the angle in radians, made by major axis with x-axis.

#### Syntax

```
double MajorAxisAngle { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADSketchBspline.GetBsplineData Method

Get the Bspline's Data

#### Syntax

```
void GetBsplineData(
	out Array pCtlPoints,
	out Array pKnotVector,
	out Array pWeights
)
```

#### Parameters

pCtlPoints  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   Memory must be allocated for this array.
    The size of this array can be derived using the properties returned
    from the GetDefinition method

pKnotVector  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   Array of Knot values. The size of this array is
    pNumKnots - 1.

pWeights  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   Array of Weights at the Control points. The size of this
    array is pNumCtlPoints - 1.

#### Remarks

To initialize an array of the correct size to pass to this function, use the
GetDefinition method to first determine the number of control points, etc. The
pWeights array can be omitted if the curve is not rational.



# IADSketchConstraint Properties

The IADSketchConstraint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Root | Returns the automation root object. |
|  | Session | Returns the part session for the collection. |
|  | SketchConstraintType | Returns the constraint type. (Horizontal/Vertical/Coincident/etc...) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_CONSTRAINT) |



# ISketchFigureIntersection Interface

ISketchFigureIntersection interface

#### Syntax

```
public interface ISketchFigureIntersection
```



# IADSketch.Name Property

Gets/sets the name of this design sketch.

#### Syntax

```
string Name { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADSketchFigure.IsAnchored Property

Gets/Sets the flag indicating if this figure is anchored.

#### Syntax

```
bool IsAnchored { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# ISketchFigureOpenLoop Interface

ISketchFigureOpenLoop interface

#### Syntax

```
public interface ISketchFigureOpenLoop
```



# IADCompositeFigure.ShapePattern Property

Returns the sketch shape pattern which owns this composite figure.

#### Syntax

```
IADSketchShapePattern ShapePattern { get; }
```

#### Property Value

IADSketchShapePattern



# IADSketchCircularArc.End Property

Returns the End point of the arc.

#### Syntax

```
IADSketchPoint End { get; }
```

#### Property Value

IADSketchPoint



# IADSketchEllipse.MajorAxis Property

Gets the length of the major axis.

#### Syntax

```
double MajorAxis { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADComplexSketchFigure Properties

The IADComplexSketchFigure type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CompositeFigure | Returns the IADCompositeFigure containing the collection of sketch figures which make up the shape. It is possible for the composite figure to contain shape pattern figures as well. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |



# IADSketch.IsConsumed Property

Returns true if sketch has been consumed by a part feature.

#### Syntax

```
bool IsConsumed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADSketchFigure Properties

The IADSketchFigure type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure. |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure. |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored. |
|  | IsOwned | Returns true if the sketch figure is owned by a shape. |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure. |
|  | Root | Returns the automation root. |
|  | Sketch | Returns the sketch to which this figure belongs. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE) |



# IADSketchConstraints.Count Property

Returns the number of constraints in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADSketchText Properties

The IADSketchText type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Bold | Sets/Returns the Bold property of the font associated with this SketchText |
|  | CompositeFigure | Returns the IADCompositeFigure containing the collection of sketch figures which make up the shape. It is possible for the composite figure to contain shape pattern figures as well.  (Inherited from IADComplexSketchFigure) |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | FontName | Sets/Returns the font name associated with this SketchText |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | Italic | Sets/Returns the Italic property of the font associated with this SketchText |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | TextString | Sets/Returns the text string associated with this SketchText |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |



# IADSketch Interface

IADSketch represents the interface for a Sketch object in a Part or Sheet Metal workspace.

#### Syntax

```
public interface IADSketch
```

The IADSketch type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ConsumingFeature | Returns part feature consuming this sketch. |
|  | Dimensions | Returns the collection of dimensions associated with this sketch. |
|  | Figures | Returns the collection of primitive figures in this sketch. |
|  | IsActive | Gets whether the sketch is active. A value of 'true' indicates that the sketch is visible. ie. Neither suppressed nor below the rollback bar in the design explorer. |
|  | IsClosed | Returns True if the sketch is geometrically closed. |
|  | IsConsumed | Returns true if sketch has been consumed by a part feature. |
|  | IsSuppressed | Gets the suppression state of this sketch. |
|  | Key | Gets the Persistent Key property of this sketch. This Key is unique for this sketch and can be used to access the sketch. |
|  | Name | Gets/sets the name of this design sketch. |
|  | OriginPoint | Gets the origin point. |
|  | Root | Returns the automation root. |
|  | Session | Returns the design session containing this sketch. |
|  | SketchConstraints | Returns the collection of constraints associated with this sketch. |
|  | SketchPlane | Gets the target proxy containing the object used to define sketch plane. The sketch plane can be a design plane or a planar face and occurrence, if any. |
|  | SketchPlaneNormal | Gets the normal of the sketch plane. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_SKETCH) of this object. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Analyze | Analyzes the sketch for various possible sketch errors and optionally attempts to heal the errors found in the sketch. |
|  | BeginChange | Method to signal that the sketch is to enter 'edit' mode. This method must be called to add or delete any figures on the sketch. After completing the modifications on the sketch, the user needs to call the EndChange method to save the changes done to the sketch. |
|  | BeginChangeEx | Method to signal that the sketch is entering 'edit' mode. A local 2D sketch coordinate system to be used for duration of the edit is also passed in. |
|  | Delete | Removes sketch from design if it is not consumed by a feature. |
|  | EndChange | Method to signal that changes to sketch are to be committed and the sketch is to exit 'edit' mode. |
|  | GetExtents | Returns lower left corner and upper right corner of the 3D Range Box for this sketch. |
|  | MapFromSketchToWorld | Method to transform a point defined in the sketch's 2D local coordinate system into 3D world coordinate system. |
|  | MapFromWorldToSketch | Method to transform a point defined in 3D world coordinate system into the sketch's 2D local coordinate system. |



# IADSketchLine.End Property

The end point of the line.

#### Syntax

```
IADSketchPoint End { get; }
```

#### Property Value

IADSketchPoint



# IAnalyzedSketchData.OpenLoops Property

Returns an IObjectCollector of ISketchFigureOpenLoops.

#### Syntax

```
IObjectCollector OpenLoops { get; }
```

#### Property Value

IObjectCollector



# IADSketchBspline.StartPoint Property

The start point of the BSpline sketch figure.

#### Syntax

```
IAD2DPoint StartPoint { get; }
```

#### Property Value

IAD2DPoint



# IADSketchFigures.AddEllipse Method

Adds a ellipse to the sketch given the center point, major axis length, minor axis length and major axis angle.

#### Syntax

```
IADSketchEllipse AddEllipse(
	double XCenter,
	double YCenter,
	double majorAxis,
	double minorMajorRatio,
	double majorAxisAngle
)
```

#### Parameters

XCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the center point of the ellipse.

YCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the center point of the ellipse.

majorAxis  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The length of the major axis.

minorMajorRatio  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Ratio of the minor axis to the major axis.

majorAxisAngle  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The angle in radians, made by major axis with x-axis.

#### Return Value

IADSketchEllipse  
If successful returns the created Sketch Ellipse else returns null.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_NO\_ACTIVE\_SKETCHSESSION | The sketch to which this collection belongs does not have 2D sketch mode activated. |
| AD\_E\_INVALD\_CURRENT\_SKETCHSESSION | The sketch to which this collection belongs is no longer valid. |

#### Remarks

- BeginChange or BeginChangeEx must be called on the current
  Sketch before adding any Sketch Figures to it.
- The default units for the coordinates are Centimeters and for Angle the default
  units are radians. If the Display Units are other than these, apply the corresponding conversion
  factor to compare the results.



# IADSketchEllipticArc.End Property

Returns end point of the elliptical arc.

#### Syntax

```
IADSketchPoint End { get; }
```

#### Property Value

IADSketchPoint



# IADCompositeFigure Properties

The IADCompositeFigure type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of constituent sketch figures in this composite figure. |
|  | Enum | Returns an enumerator for the collection. |
|  | ShapePattern | Returns the sketch shape pattern which owns this composite figure. |
|  | SketchFigure | Returns the SketchFigure owning this composite figure. |



# IADSketchPoint.Y Property

Returns the Y coordinate of the point.

#### Syntax

```
double Y { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IAnalyzedSketchData Properties

The IAnalyzedSketchData type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DegenerateFigures | Returns an IObjectCollector of ISketchDegenerateFigure. |
|  | DisjointEnds | Returns an IObjectCollector of ISketchFigureDisjointEnd. |
|  | Intersections | Returns an IObjectCollector of ISketchFigureOverlap. |
|  | OpenLoops | Returns an IObjectCollector of ISketchFigureOpenLoops. |
|  | OverLaps | Returns an IObjectCollector of ISketchFigureIntersection. |



# IADSketchCircularArc.Radius Property

Returns the radius of the arc.

#### Syntax

```
double Radius { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADSketches.Count Property

Returns the number of design sketches in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

The count property for the Sketches object held by automation clients will not get
updated automatically when a sketch is added or deleted. Get the current Sketches collection
by querying the Part Session.



# IADSketchBspline.EndPoint Property

The end point of the BSpline sketch figure.

#### Syntax

```
IAD2DPoint EndPoint { get; }
```

#### Property Value

IAD2DPoint



# IADSketchFigures.AddCircle Method

Adds a circle figure to the sketch given circle's center point and radius.

#### Syntax

```
IADSketchCircle AddCircle(
	double XCenter,
	double YCenter,
	Object Radius
)
```

#### Parameters

XCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the center point of the circle.

YCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the center point of the circle.

Radius  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The radius of the circle. Must be greater than zero. The radius can be
    an equation obtained from a Parameter or a number

#### Return Value

IADSketchCircle  
If successful returns the created Sketch Circle else returns null.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_NO\_ACTIVE\_SKETCHSESSION | The sketch to which this collection belongs does not have 2D sketch mode activated. |
| AD\_E\_INVALD\_CURRENT\_SKETCHSESSION | The sketch to which this collection belongs is no longer valid. |

#### Remarks

- BeginChange or BeginChangeEx must be called on the current
  Sketch before adding any Sketch Figures to it.
- The default units for the coordinates are Centimeters and for Angle the default
  units are radians. If the Display Units are other than these, apply the corresponding conversion
  factor to compare the results.

#### Example

This Visual Basic sample shows how to call the AddCircle method.

```
' Example Description: Demonstrates adding a sketch
' circle of five units radius with (0,0) as origin.

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Holds XY-Plane
Set objADDesignPlane = objADDesignSession.DesignPlanes("XY-Plane")

' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session object from existing session
Set objADPartSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a new sketch to the above Design Plane.
Set objADSketch = objADSketches.AddSketch( _
        Nothing, objADDesignPlane, "NewSketch")

' Initiate Sketch edit mode
Call objADSketch.BeginChange

' Holds Sketch Figures object
Dim objADSketchFigures As AlibreX.IADSketchFigures

' Get Sketch Figures from Sketch object
Set objADSketchFigures = objADSketch.Figures

' Holds Sketch Circle
Dim objADSketchCircle As AlibreX.IADSketchCircle

' Add Sketch Circle
Set objADSketchCircle = objADSketchFigures.AddCircle(0, 0, 5)

' Exit Sketch edit mode
Call objADSketch.EndChange
```



# IADSketchShapePattern Methods

The IADSketchShapePattern type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |



# ISketchFigureOverlap Interface

ISketchFigureOverlap interface

#### Syntax

```
public interface ISketchFigureOverlap
```



# IADSketch.Root Property

Returns the automation root.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADSketchCircularArc.IncludedAngle Property

Returns the included angle of the arc in radians.

#### Syntax

```
double IncludedAngle { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADCompositeFigure Interface

IADCompositeFigure represents a collection of figures which compose an
IADSketchShapePattern. These consituent
figures can be any IADSketchFigure, including
another IADSketchShapePattern.

#### Syntax

```
public interface IADCompositeFigure
```

The IADCompositeFigure type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of constituent sketch figures in this composite figure. |
|  | Enum | Returns an enumerator for the collection. |
|  | ShapePattern | Returns the sketch shape pattern which owns this composite figure. |
|  | SketchFigure | Returns the SketchFigure owning this composite figure. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding constituent sketch figure. |



# IADSketchCircle.Center Property

Returns the center point of the circle.

#### Syntax

```
IADSketchPoint Center { get; }
```

#### Property Value

IADSketchPoint



# IADSketch Methods

The IADSketch type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Analyze | Analyzes the sketch for various possible sketch errors and optionally attempts to heal the errors found in the sketch. |
|  | BeginChange | Method to signal that the sketch is to enter 'edit' mode. This method must be called to add or delete any figures on the sketch. After completing the modifications on the sketch, the user needs to call the EndChange method to save the changes done to the sketch. |
|  | BeginChangeEx | Method to signal that the sketch is entering 'edit' mode. A local 2D sketch coordinate system to be used for duration of the edit is also passed in. |
|  | Delete | Removes sketch from design if it is not consumed by a feature. |
|  | EndChange | Method to signal that changes to sketch are to be committed and the sketch is to exit 'edit' mode. |
|  | GetExtents | Returns lower left corner and upper right corner of the 3D Range Box for this sketch. |
|  | MapFromSketchToWorld | Method to transform a point defined in the sketch's 2D local coordinate system into 3D world coordinate system. |
|  | MapFromWorldToSketch | Method to transform a point defined in 3D world coordinate system into the sketch's 2D local coordinate system. |



# IADSketchShapePattern.CompositeFigure Property

Returns the IADCompositeFigure containing the collection of sketch figures which
make up the shape. It is possible for the composite figure to contain shape pattern
figures as well.

#### Syntax

```
IADCompositeFigure CompositeFigure { get; }
```

#### Property Value

IADCompositeFigure

#### Implements

IADComplexSketchFigureCompositeFigure



# IADSketchPoint.IsSketchNode Property

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



# IADSketchPoint Interface

This interface represents 2D Point figure in a sketching environment.

#### Syntax

```
public interface IADSketchPoint : IADSketchFigure
```

The IADSketchPoint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | IsSketchNode | Returns True if this figure is a sketch node. |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |
|  | X | Returns the X coordinate of the point. |
|  | Y | Returns the Y coordinate of the point. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |

#### Example

This Visual Basic sample demonstrates usage of Sketch Point related properties and methods.

```
' Example Description: Demonstrates usage of Sketch Point related
' properties and methods

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Holds XY-Plane
Set objADDesignPlane = objADDesignSession.DesignPlanes("XY-Plane")

' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session object from existing session
Set objADPartSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a new sketch to the above Design Plane.
Set objADSketch = objADSketches.AddSketch( _
        Nothing, objADDesignPlane, "NewSketch")

' Initiate Sketch edit mode
Call objADSketch.BeginChange

' Holds Sketch Figures object
Dim objADSketchFigures As AlibreX.IADSketchFigures

' Get Sketch Figures from Sketch object
Set objADSketchFigures = objADSketch.Figures

' Holds Sketch Point
Dim objADSketchPoint As AlibreX.IADSketchPoint

' Add Sketch Point
Set objADSketchPoint = objADSketchFigures.AddSketchPoint(1, 1)

' Exit Sketch edit mode
Call objADSketch.EndChange

' Print IsSketchNode property
Debug.Print objADSketchPoint.IsSketchNode

' Print X co-ordinate
Debug.Print objADSketchPoint.X

' Print Y co-ordinate
Debug.Print objADSketchPoint.Y
```



# IADSketchEllipticArc.MajorAxis Property

Gets length of major axis.

#### Syntax

```
double MajorAxis { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADSketchFigures.AddLine Method

Adds a Line figure created with the X1, Y1 as the Start Point and X2, Y2 as the End Point.

#### Syntax

```
IADSketchLine AddLine(
	double X1,
	double Y1,
	double X2,
	double Y2
)
```

#### Parameters

X1  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the start of the line.

Y1  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the start of the line.

X2  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the end of the line.

Y2  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the end of the line.

#### Return Value

IADSketchLine  
If successful returns the created Sketch Line else returns null.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_NO\_ACTIVE\_SKETCHSESSION | The sketch to which this collection belongs does not have 2D sketch mode activated. |
| AD\_E\_INVALD\_CURRENT\_SKETCHSESSION | The sketch to which this collection belongs is no longer valid. |
| AD\_E\_COLLINEAR\_POINTS | The start and end points cannot be the same. |

#### Remarks

- BeginChange or BeginChangeEx must be called on the current
  Sketch before adding any Sketch Figures to it.
- The default units for the coordinates are Centimeters and for Angle the default
  units are radians. If the Display Units are other than these, apply the corresponding conversion
  factor to compare the results.

#### Example

This Visual Basic sample shows how to call the AddLine method.

```
' Example Description: Demonstrates adding a sketch
' Line with (0, 0) as Start Point, (1, 1) as End Point.

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Holds XY-Plane
Set objADDesignPlane = objADDesignSession.DesignPlanes("XY-Plane")

' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session object from existing session
Set objADPartSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a new sketch to the above Design Plane.
Set objADSketch = objADSketches.AddSketch( _
        Nothing, objADDesignPlane, "NewSketch")

' Initiate Sketch edit mode
Call objADSketch.BeginChange

' Holds Sketch Figures object
Dim objADSketchFigures As AlibreX.IADSketchFigures

' Get Sketch Figures from Sketch object
Set objADSketchFigures = objADSketch.Figures

' Holds Sketch Line
Dim objADSketchLine As AlibreX.IADSketchLine

' Add Sketch Line
Set objADSketchLine = objADSketchFigures.AddLine(0, 0, 1, 1)

' Exit Sketch edit mode
Call objADSketch.EndChange
```



# IADSketchFigures Interface

This interface represents a collection of Sketch Figure objects.

#### Syntax

```
public interface IADSketchFigures
```

The IADSketchFigures type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of figures in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Sketch | Returns the parent sketch for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddBspline | Adds a Bspline to the sketch given arrays of control points, knot vectors and weights. |
|  | AddBsplineByInterpolation | Creates a Bspline defined by an array of interpolation points. |
|  | AddCircle | Adds a circle figure to the sketch given circle's center point and radius. |
|  | AddCircularArc | Adds a circular arc to the sketch given the arc center point, arc start point and an arc angle which follows right hand rule. |
|  | AddCircularArcBy3Points | Adds a circular arc to the sketch given the arc center point, start point and end point. |
|  | AddCircularArcByCenterStartAngle | Adds a circular arc to the sketch given the arc center point, arc start point and an arc angle which follows right hand rule. |
|  | AddCircularArcByCenterStartEnd | Adds a circular arc to the sketch given the arc center point, start point and end point. |
|  | AddEllipse | Adds a ellipse to the sketch given the center point, major axis length, minor axis length and major axis angle. |
|  | AddEllipseBy3Points | Adds a ellipse to the sketch given the center point, major axis point and minor axis point. |
|  | AddEllipticArc | Adds an elliptic arc to the sketch given the center point, major axis length, minor axis length, start and end points of the arc and the major axis angle. NOTE: Flip the Start and End points if the curve needs to be in the opposite direction. This should be based on the right hand rule. |
|  | AddLine | Adds a Line figure created with the X1, Y1 as the Start Point and X2, Y2 as the End Point. |
|  | AddRectangle | Adds four sketch lines that form a rectangle with horizontal and vertical sides. |
|  | AddSketchPoint | Adds a Skech point using the given coordinates. |
|  | GetFigureByID | Returns the sketch figure for the input figure ID. |
|  | Item | Given a numerical index into the collection, returns the corresponding sketch figure. |



# IADSketchPoint Methods

The IADSketchPoint type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |



# IADSketchEllipse.MajorAxisAngle Property

Gets the angle in radians, made by major axis with x-axis.

#### Syntax

```
double MajorAxisAngle { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADSketchCircle.Radius Property

Returns the radius of the circle.

#### Syntax

```
double Radius { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADSketchEllipticArc Interface

This interface represents a 2D Elliptical Arc Figure in the sketching environment.

#### Syntax

```
public interface IADSketchEllipticArc : IADSketchFigure
```

The IADSketchEllipticArc type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Center | Gets the center point of the elliptical arc. |
|  | End | Returns end point of the elliptical arc. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | IsRightHandRule | Indicates whether the arc is drawn about the center from the start point to end point using right-hand rule or not. |
|  | MajorAxis | Gets length of major axis. |
|  | MajorAxisAngle | Gets the angle in radians, made by major axis with x-axis. |
|  | MinorMajorRatio | Gets the ratio of minor axis ot the major axis. |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | Start | Returns start point of the elliptical arc. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |

#### Example

This sample will query all the properties of each sketch elliptical arc contained in open parts.

```
foreach (IADSession session in root.Sessions)
{
    if (session.SessionType == ADObjectSubType.AD_PART || 
        session.SessionType == ADObjectSubType.AD_SHEET_METAL)
    {
        IADPartSession partSession = (IADPartSession)session;
        Console.WriteLine("==================================");
        Console.WriteLine("Session: " + session.Name);
        foreach (IADSketch sketch in partSession.Sketches)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Sketch: " + sketch.Name);
            foreach (IADSketchFigure figure in sketch.Figures)
            {
                try
                {
                    if (figure.FigureType == ADGeometryType.AD_ELLIPTICAL_ARC)
                    {
                        IADSketchEllipticArc sketchEllipticArc = (IADSketchEllipticArc)figure;
                        Console.WriteLine("Sketch elliptic arc: Center:(" + sketchEllipticArc.Center.X +
                            "," + sketchEllipticArc.Center.Y + ") Start:(" + sketchEllipticArc.Start.X +
                            "," + sketchEllipticArc.Start.Y + ") End:(" + sketchEllipticArc.End.X + "," +
                            sketchEllipticArc.End.Y + ") Major axis:" + sketchEllipticArc.MajorAxis + " Axis angle:" +
                            sketchEllipticArc.MajorAxisAngle + " Axis ratio:" + sketchEllipticArc.MinorMajorRatio);
                        break;
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Exception encountered: " + exception.Message);
                }
            }
        }
    }
}
```



# IADSketchFigures.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADSketchBspline Interface

This interface represents a 2D Bspline curve in the Sketching environment.

#### Syntax

```
public interface IADSketchBspline : IADSketchFigure
```

The IADSketchBspline type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EndPoint | The end point of the BSpline sketch figure. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | StartPoint | The start point of the BSpline sketch figure. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |
|  | GetBsplineData | Get the Bspline's Data |
|  | GetDefinition | Get the Bspline's Definition |

#### Example

This Visual Basic sample demonstrates querying a Bspline with GetDefinition and GetBsplineData.

```
' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Holds XY-Plane
Set objADDesignPlane = objADDesignSession.DesignPlanes("XY-Plane")

' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session object from existing session
Set objADPartSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a new sketch to the above Design Plane.
Set objADSketch = objADSketches.AddSketch( _
        Nothing, objADDesignPlane, "NewSketch")

' Initiate Sketch edit mode
Call objADSketch.BeginChange

' Holds Sketch Figures object
Dim objADSketchFigures As AlibreX.IADSketchFigures

' Get Sketch Figures from Sketch object
Set objADSketchFigures = objADSketch.Figures

' Holds Number of Knots
Dim lngNumKnotVector As Long
lngNumKnotVector = 12

' Holds Order of the bspline
Dim lngOrder As Long

' Bspline sketch order
lngOrder = 4

' Number of control
Dim lngNumCtrlPoints As Long
lngNumCtrlPoints = 8

' Allocate memory for X & Y point co-ordinates based on Number of control
Dim dblCtrlPoints() As Double
ReDim dblCtrlPoints(2 * lngNumCtrlPoints - 1) As Double

' Allocate memory for knot vector data
Dim dblKnotVector() As Double
ReDim dblKnotVector(lngNumKnotVector - 1) As Double

' Populate control point data
dblCtrlPoints(0) = 8.51186370849609
dblCtrlPoints(1) = 6.99780511856079
dblCtrlPoints(2) = 8.17882033581046
dblCtrlPoints(3) = 6.94976745716925
dblCtrlPoints(4) = 7.4561830417737
dblCtrlPoints(5) = 6.84553537063978
dblCtrlPoints(6) = 6.74456190752469
dblCtrlPoints(7) = 5.81435730131809
dblCtrlPoints(8) = 6.52782774895632
dblCtrlPoints(9) = 4.66411669565958
dblCtrlPoints(10) = 5.54729016867033
dblCtrlPoints(11) = 4.07984012807058
dblCtrlPoints(12) = 4.95126996822612
dblCtrlPoints(13) = 4.1095473709045
dblCtrlPoints(14) = 4.69674873352051
dblCtrlPoints(15) = 4.1222333908081

' Populate knot vector data
dblKnotVector(0) = 0
dblKnotVector(1) = 0
dblKnotVector(2) = 0
dblKnotVector(3) = 0
dblKnotVector(4) = 0.983174799451358
dblKnotVector(5) = 2.13329204214884
dblKnotVector(6) = 3.38226409165226
dblKnotVector(7) = 4.40411570159471
dblKnotVector(8) = 5.16570785718433
dblKnotVector(9) = 5.16570785718433
dblKnotVector(10) = 5.16570785718433
dblKnotVector(11) = 5.16570785718433

' Holds weights data
Dim dblWeights() As Double
ReDim dblWeights(lngNumCtrlPoints - 1) As Double

' Populate weights data
Dim lngIndex As Long
For lngIndex = 0 To lngNumCtrlPoints - 1
    dblWeights(lngIndex) = 0
Next lngIndex

' Holds Sketch Bspline
Dim objADSketchBspline As AlibreX.IADSketchBspline

' Add Sketch Bspline
Set objADSketchBspline = objADSketchFigures.AddBspline( _
        lngOrder, lngNumCtrlPoints, _
        dblCtrlPoints(), dblKnotVector(), dblWeights())

' Exit Sketch edit mode
Call objADSketch.EndChange

' Flags Defining Bspline
Dim blnIsRational As Boolean
Dim blnIsClosed As Boolean
Dim blnIsPeriodic As Boolean

'Re-initialise variables
lngOrder = 0
lngNumCtrlPoints = 0
lngNumKnotVector = 0

' Get Bspline Definition
Call objADSketchBspline.GetDefinition(lngOrder, lngNumCtrlPoints, _
        lngNumKnotVector, blnIsRational, blnIsClosed, blnIsPeriodic)

' Re-initialize and allocate memory for data
ReDim dblCtrlPoints(2 * lngNumCtrlPoints - 1) As Double
ReDim dblKnotVector(lngNumKnotVector - 1) As Double
ReDim dblWeights(lngNumCtrlPoints - 1) As Double

' Get Bspline Data
Call objADSketchBspline.GetBsplineData(dblCtrlPoints, dblKnotVector, dblWeights)
```



# IADSketchEllipse.MinorMajorRatio Property

Gets the ratio of minor axis to the major axis.

#### Syntax

```
double MinorMajorRatio { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADSketch.Dimensions Property

Returns the collection of dimensions associated with this sketch.

#### Syntax

```
IADDimensions Dimensions { get; }
```

#### Property Value

IADDimensions



# IADSketchCircularArc Properties

The IADSketchCircularArc type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Center | Returns the center point of the arc. |
|  | End | Returns the End point of the arc. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IncludedAngle | Returns the included angle of the arc in radians. |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | IsRightHandRule | Indicates whether the arc is drawn about the center from the start point to end point using right-hand rule or not. |
|  | Radius | Returns the radius of the arc. |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | Start | Returns the Start point of the arc. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |



# IADSketches.AddSketch Method

Adds a new Sketch in the Part workspace
and returns the newly created Sketch.

#### Syntax

```
IADSketch AddSketch(
	IADOccurrence pOccurrence,
	Object pSketchPlane,
	string name
)
```

#### Parameters

pOccurrence  IADOccurrence
:   If pSketchPlane belongs to an assembly, input the Occurrence
    to which the plane belongs.

pSketchPlane  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The plane on which the Sketch will be added. This can be an instance
    of a Design Plane or a Planar Face.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name for the new sketch. If an empty string or null value are passed, Alibre will
    automatically name the sketch.

#### Return Value

IADSketch  
The interface to the new sketch.

#### Remarks

- Note that the newly created Sketch object is not added to the Collection on which
  this method is called. Query for the Collection again to get the updated Collection.
- If already in Sketching mode in Part workspace, then the changes made to current sketch
  are discarded before creating the new sketch.

#### Example

This Visual Basic sample shows how to call the AddSketch method.

```
' Example Description: Demonstrates Adding a new Sketch to the Sketches Collection
' A new sketch with "NewSketch" as Name is added to XY-Plane here.

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Holds XY-Plane
Set objADDesignPlane = objADDesignSession.DesignPlanes("XY-Plane")

' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session object from existing session
Set objADPartSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a new sketch to the above Design Plane.
Set objADSketch = objADSketches.AddSketch( _
        Nothing, objADDesignPlane, "NewSketch")
```



# IADSketchText Interface

IADSketchShapePattern represents Shape or Shape Pattern sketch figures. In the GUI these
are the figures under the Sketch->Shape menu. The shape has an underlying
composite figure, which is a collection of the
sketch figures which compose the shape.

#### Syntax

```
public interface IADSketchText : IADComplexSketchFigure, 
	IADSketchFigure
```

The IADSketchText type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Bold | Sets/Returns the Bold property of the font associated with this SketchText |
|  | CompositeFigure | Returns the IADCompositeFigure containing the collection of sketch figures which make up the shape. It is possible for the composite figure to contain shape pattern figures as well.  (Inherited from IADComplexSketchFigure) |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | FontName | Sets/Returns the font name associated with this SketchText |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | Italic | Sets/Returns the Italic property of the font associated with this SketchText |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | TextString | Sets/Returns the text string associated with this SketchText |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |

#### Remarks

Currently only the CompositeFigure property is available to allow the
shape's geometry to be queried. In the future, properties to get the parameters of
the shape and its pattern will be added as well.



# IADSketchLine Methods

The IADSketchLine type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |



# IAnalyzedSketchData.DegenerateFigures Property

Returns an IObjectCollector of ISketchDegenerateFigure.

#### Syntax

```
IObjectCollector DegenerateFigures { get; }
```

#### Property Value

IObjectCollector



# IADSketchFigures.AddCircularArcBy3Points Method

Adds a circular arc to the sketch given the arc center point, start point and end point.

#### Syntax

```
IADSketchCircularArc AddCircularArcBy3Points(
	double XCenter,
	double YCenter,
	double XStartPt,
	double YStartPt,
	double XEndPt,
	double YEndPt
)
```

#### Parameters

XCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the center point of the circular arc.

YCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the center point of the circular arc.

XStartPt  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the start point of the circular arc.

YStartPt  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the start point of the circular arc.

XEndPt  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the end point of the circular arc.

YEndPt  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the end point of the circular arc.

#### Return Value

IADSketchCircularArc  
If successful returns the created Sketch Circular Arc
else returns null.

#### Remarks

WARNING: This Method is OBSOLETE. Please use
AddCircularArcByCenterStartEnd instead.



# IADSketchLine Properties

The IADSketchLine type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | End | The end point of the line. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | Length | The length of the line. |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | Start | The start point of the line. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |



# IADSketchEllipticArc.Start Property

Returns start point of the elliptical arc.

#### Syntax

```
IADSketchPoint Start { get; }
```

#### Property Value

IADSketchPoint



# IADSketchFigures.GetFigureByID Method

Returns the sketch figure for the input figure ID.

#### Syntax

```
IADSketchFigure GetFigureByID(
	string ID
)
```

#### Parameters

ID  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The ID of the sketch figure to be obtained.

#### Return Value

IADSketchFigure  
The figure corresponding to the input ID, or null if no figure matches the ID.



# IAnalyzedSketchData.OverLaps Property

Returns an IObjectCollector of ISketchFigureIntersection.

#### Syntax

```
IObjectCollector OverLaps { get; }
```

#### Property Value

IObjectCollector



# IADSketches.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum

#### Example

This Visual Basic sample shows how to get and use the Enum property.

```
Dim objPart As AlibreX.IADPartSession
Dim objSketch As AlibreX.IADSketch
Dim objSketchEnum As AlibreX.DIEnum
Dim strSketches as String

' In here, assume some means to obtain the
' part workspace objPart

strSketches = "Sketches" & vbCrLf
Set objSketchEnum = objPart.Sketches.Enum
Do While objSketchEnum.HasMoreElements
    Set objSketch = objSketchEnum.NextElement

    strSketches = strSketches & objSketch.Name & vbCrLf
Loop 
strSketches = strSketches & vbCrLf
```



# ISketchFigureDisjointEnd Interface

ISketchFigureDisjointEnd interface

#### Syntax

```
public interface ISketchFigureDisjointEnd
```



# IADSketchFigure Methods

The IADSketchFigure type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure. |



# IADSketchText.TextString Property

Sets/Returns the text string associated with this SketchText

#### Syntax

```
string TextString { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADSketchBspline Methods

The IADSketchBspline type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |
|  | GetBsplineData | Get the Bspline's Data |
|  | GetDefinition | Get the Bspline's Definition |



# IAnalyzedSketchData.Intersections Property

Returns an IObjectCollector of ISketchFigureOverlap.

#### Syntax

```
IObjectCollector Intersections { get; }
```

#### Property Value

IObjectCollector



# IADSketch.OriginPoint Property

Gets the origin point.

#### Syntax

```
IADSketchPoint OriginPoint { get; }
```

#### Property Value

IADSketchPoint



# IADSketch.Delete Method

Removes sketch from design if it is not consumed by a feature.

#### Syntax

```
void Delete()
```

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_CANNOT\_DELETE\_SKETCH | The sketch could not be deleted. |

#### Remarks

The sketch cannot be deleted if it is consumed by a feature.
Currently, if you want to delete a consumed sketch, you must first delete the consuming
feature.



# IADSketch.SketchPlane Property

Gets the target proxy containing the object used to define sketch plane. The sketch plane
can be a design plane or a planar face
and occurrence, if any.

#### Syntax

```
IADTargetProxy SketchPlane { get; }
```

#### Property Value

IADTargetProxy

#### Remarks

IADTargetProxy object wraps the dependent object,
and also its occurrence if the object belongs to an assembly.
Otherwise the occurrence will be null.



# IADSketchFigures.Sketch Property

Returns the parent sketch for the collection.

#### Syntax

```
IADSketch Sketch { get; }
```

#### Property Value

IADSketch



# IADSketches Properties

The IADSketches type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of design sketches in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the design session for the collection. |



# IADSketch.SketchPlaneNormal Property

Gets the normal of the sketch plane.

#### Syntax

```
IADVector SketchPlaneNormal { get; }
```

#### Property Value

IADVector



# IADComplexSketchFigure.CompositeFigure Property

Returns the IADCompositeFigure containing the collection of sketch figures which
make up the shape. It is possible for the composite figure to contain shape pattern
figures as well.

#### Syntax

```
IADCompositeFigure CompositeFigure { get; }
```

#### Property Value

IADCompositeFigure



# IADSketchFigures.Item Method

Given a numerical index into the collection, returns the corresponding sketch figure.

#### Syntax

```
IADSketchFigure Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The numerical index of the sketch figure.

#### Return Value

IADSketchFigure  
Returns IADSketchFigure



# IADSketch Properties

The IADSketch type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ConsumingFeature | Returns part feature consuming this sketch. |
|  | Dimensions | Returns the collection of dimensions associated with this sketch. |
|  | Figures | Returns the collection of primitive figures in this sketch. |
|  | IsActive | Gets whether the sketch is active. A value of 'true' indicates that the sketch is visible. ie. Neither suppressed nor below the rollback bar in the design explorer. |
|  | IsClosed | Returns True if the sketch is geometrically closed. |
|  | IsConsumed | Returns true if sketch has been consumed by a part feature. |
|  | IsSuppressed | Gets the suppression state of this sketch. |
|  | Key | Gets the Persistent Key property of this sketch. This Key is unique for this sketch and can be used to access the sketch. |
|  | Name | Gets/sets the name of this design sketch. |
|  | OriginPoint | Gets the origin point. |
|  | Root | Returns the automation root. |
|  | Session | Returns the design session containing this sketch. |
|  | SketchConstraints | Returns the collection of constraints associated with this sketch. |
|  | SketchPlane | Gets the target proxy containing the object used to define sketch plane. The sketch plane can be a design plane or a planar face and occurrence, if any. |
|  | SketchPlaneNormal | Gets the normal of the sketch plane. |
|  | Type | Returns a pre-defined constant that identifies the type (AD\_SKETCH) of this object. |



# IADSketchFigure.FigureType Property

Returns a pre-defined constant that identifies the type of this sketch figure.

#### Syntax

```
ADGeometryType FigureType { get; }
```

#### Property Value

ADGeometryType

#### Remarks

Possible values for this property and their corresponding types include:

- AD\_LINE
- AD\_CIRCLE
- AD\_ELLIPSE
- AD\_BSPLINE
- AD\_CIRCULAR\_ARC
- AD\_ELLIPTICAL\_ARC
- AD\_SHAPEPATTERN

This property depends on the Geometry maintained by ACIS. ACIS may maintain full geometry even for Arcs,
as a result of this, this property may return AD\_CIRCLE for a Circular Arc or AD\_ELLIPSE for
an Elliptical Arc.



# IADComplexSketchFigure Interface

IADSketchShapePattern represents Shape or Shape Pattern sketch figures. In the GUI these
are the figures under the Sketch->Shape menu. The shape has an underlying
composite figure, which is a collection of the
sketch figures which compose the shape.

#### Syntax

```
public interface IADComplexSketchFigure : IADSketchFigure
```

The IADComplexSketchFigure type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CompositeFigure | Returns the IADCompositeFigure containing the collection of sketch figures which make up the shape. It is possible for the composite figure to contain shape pattern figures as well. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |

#### Remarks

Currently only the CompositeFigure property is available to allow the
shape's geometry to be queried. In the future, properties to get the parameters of
the shape and its pattern will be added as well.



# IADSketchCircle Properties

The IADSketchCircle type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Center | Returns the center point of the circle. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | Radius | Returns the radius of the circle. |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |



# IADSketchEllipse Interface

This interface represents a 2D Elliptical Figure in the sketching environment.

#### Syntax

```
public interface IADSketchEllipse : IADSketchFigure
```

The IADSketchEllipse type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Center | Returns the center point of the ellipse. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | MajorAxis | Gets the length of the major axis. |
|  | MajorAxisAngle | Gets the angle in radians, made by major axis with x-axis. |
|  | MinorMajorRatio | Gets the ratio of minor axis to the major axis. |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |

#### Example

This sample will query all the properties of each sketch ellipse contained in open parts.

```
foreach (IADSession session in root.Sessions)
{
    if (session.SessionType == ADObjectSubType.AD_PART || session.SessionType == ADObjectSubType.AD_SHEET_METAL)
    {
        IADPartSession partSession = (IADPartSession)session;
        Console.WriteLine("==================================");
        Console.WriteLine("Session: " + session.Name);
        foreach (IADSketch sketch in partSession.Sketches)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Sketch: " + sketch.Name);
            foreach (IADSketchFigure figure in sketch.Figures)
            {
                try
                {
                    if (figure.FigureType == ADGeometryType.AD_ELLIPSE)
                    {
                        IADSketchEllipse sketchEllipse = (IADSketchEllipse)figure;
                        Console.WriteLine("Sketch ellipse: Center:(" + sketchEllipse.Center.X + "," + sketchEllipse.Center.Y +
                            ") Major axis:" + sketchEllipse.MajorAxis + " Axis angle:" + sketchEllipse.MajorAxisAngle +
                            " Axis ratio:" + sketchEllipse.MinorMajorRatio);
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Exception encountered: " + exception.Message);
                }
            }
        }
    }
}
```



# IADSketchEllipticArc Methods

The IADSketchEllipticArc type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |



# IADSketchText.Italic Property

Sets/Returns the Italic property of the font associated with this SketchText

#### Syntax

```
bool Italic { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADSketches Methods

The IADSketches type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddSketch | Adds a new Sketch in the Part workspace and returns the newly created Sketch. |
|  | Item | Given a name or index, returns the corresponding design sketch. |



# IADSketchFigure.ID Property

Gets the ID property of this sketch figure. This ID is unique for
the sketch figure and can be used to access the sketch figure.

#### Syntax

```
string ID { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADSketchConstraints Properties

The IADSketchConstraints type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of constraints in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Sketch | Returns the parent sketch for the collection. |



# IADSketchConstraints Interface

IADSketchConstraints represents a collection of a sketch's cosntraints.

#### Syntax

```
public interface IADSketchConstraints
```

The IADSketchConstraints type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of constraints in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Sketch | Returns the parent sketch for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddConstraint | Creates a new constraint. |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given a numerical index into the collection, returns the corresponding constraint. |



# IADSketch.BeginChange Method

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
| AD\_E\_ACTIVE\_SKETCHSESSION\_EXISTS | 2D Sketch mode is already active. |

#### Remarks

This method throws an exception if an active Sketch Session already exists. EndChange
must be called to close the current Sketch Session.



# IAnalyzedSketchData.DisjointEnds Property

Returns an IObjectCollector of ISketchFigureDisjointEnd.

#### Syntax

```
IObjectCollector DisjointEnds { get; }
```

#### Property Value

IObjectCollector



# IADSketchConstraints.Item Method

Given a numerical index into the collection, returns the corresponding constraint.

#### Syntax

```
IADSketchConstraint Item(
	int index
)
```

#### Parameters

index  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The numerical index of the constraint.

#### Return Value

IADSketchConstraint  
Returns IADSketchConstraint



# IADSketchConstraints.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADSketchFigures.AddBsplineByInterpolation Method

Creates a Bspline defined by an array of interpolation points.

#### Syntax

```
IADSketchBspline AddBsplineByInterpolation(
	in Array pInterpolationPoints
)
```

#### Parameters

pInterpolationPoints  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   A double array of 2D interpolation points, in the form of
    X and Y coordinates for each point.

#### Return Value

IADSketchBspline  
If successful returns the created 2D Sketch Bspline
else returns null.



# IADSketch.BeginChangeEx Method

Method to signal that the sketch is entering 'edit' mode. A local 2D sketch coordinate
system to be used for duration of the edit is also passed in.

#### Syntax

```
void BeginChangeEx(
	IADPoint pOrigin,
	IADVector pXAxis,
	IADVector pYDirection
)
```

#### Parameters

pOrigin  IADPoint
:   The origin of the local coordinate system to be used.

pXAxis  IADVector
:   The X-Axis of the local coordinate system to be used.

pYDirection  IADVector
:   The Y-Direction of the local coordinate system to be used.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_ACTIVE\_SKETCHSESSION\_EXISTS | 2D Sketch mode is already active. |

#### Remarks

This method throws an exception if an active Sketch Session already exists. EndChange
must be called to close the current Sketch Session.

#### Example

This Visual Basic sample shows how to call the BeginChangeEx method.

```
' Example Description: Demonstrates usage of BeginChangeEx.
' Local Sketch Origin is shifted by ten units in X-Axis and Y-Axis
' direction in this example.
' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Holds XY-Plane
Set objADDesignPlane = objADDesignSession.DesignPlanes("XY-Plane")

' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session object from existing session
Set objADPartSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a new sketch to the above Design Plane.
Set objADSketch = objADSketches.AddSketch( _
        Nothing, objADDesignPlane, "NewSketch")

' Holds Geometry Factory
Dim objADGeometryFactory As AlibreX.IADGeometryFactory

' Get Geometry Factory from Session object
Set objADGeometryFactory = m_objADSession.GeometryFactory

' Holds Point
Dim objADNewOriginPoint As AlibreX.IADPoint

' Create point at (10, 10, 0) to be used as new origin using Geometry Factory
Set objADNewOriginPoint = objADGeometryFactory.CreatePoint(10, 10, 0)

' Holds X Direction Vector
Dim objADXDirVector As AlibreX.IADVector

' Create Vector along X direction
Set objADXDirVector = objADGeometryFactory.CreateVector(1, 0, 0)

' Holds Y Direction Vector
Dim objADYDirVector As AlibreX.IADVector

' Create Vector along Y direction
Set objADYDirVector = objADGeometryFactory.CreateVector(0, 1, 0)

' Change the local origin of the sketch in the edit mode
Call objADSketch.BeginChangeEx(objADNewOriginPoint, _
        objADXDirVector, objADYDirVector)
```



# IADSketchShapePattern Properties

The IADSketchShapePattern type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CompositeFigure | Returns the IADCompositeFigure containing the collection of sketch figures which make up the shape. It is possible for the composite figure to contain shape pattern figures as well. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |



# IADSketchFigures Methods

The IADSketchFigures type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddBspline | Adds a Bspline to the sketch given arrays of control points, knot vectors and weights. |
|  | AddBsplineByInterpolation | Creates a Bspline defined by an array of interpolation points. |
|  | AddCircle | Adds a circle figure to the sketch given circle's center point and radius. |
|  | AddCircularArc | Adds a circular arc to the sketch given the arc center point, arc start point and an arc angle which follows right hand rule. |
|  | AddCircularArcBy3Points | Adds a circular arc to the sketch given the arc center point, start point and end point. |
|  | AddCircularArcByCenterStartAngle | Adds a circular arc to the sketch given the arc center point, arc start point and an arc angle which follows right hand rule. |
|  | AddCircularArcByCenterStartEnd | Adds a circular arc to the sketch given the arc center point, start point and end point. |
|  | AddEllipse | Adds a ellipse to the sketch given the center point, major axis length, minor axis length and major axis angle. |
|  | AddEllipseBy3Points | Adds a ellipse to the sketch given the center point, major axis point and minor axis point. |
|  | AddEllipticArc | Adds an elliptic arc to the sketch given the center point, major axis length, minor axis length, start and end points of the arc and the major axis angle. NOTE: Flip the Start and End points if the curve needs to be in the opposite direction. This should be based on the right hand rule. |
|  | AddLine | Adds a Line figure created with the X1, Y1 as the Start Point and X2, Y2 as the End Point. |
|  | AddRectangle | Adds four sketch lines that form a rectangle with horizontal and vertical sides. |
|  | AddSketchPoint | Adds a Skech point using the given coordinates. |
|  | GetFigureByID | Returns the sketch figure for the input figure ID. |
|  | Item | Given a numerical index into the collection, returns the corresponding sketch figure. |



# IADSketchFigures.Count Property

Returns the number of figures in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

The count property for the Sketch Figures object held by automation clients will
not get updated automatically when a Sketch Figure is added or deleted. Get the current
Sketch Figures collection by querying the Sketch.



# IADSketchBspline Properties

The IADSketchBspline type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EndPoint | The end point of the BSpline sketch figure. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | StartPoint | The start point of the BSpline sketch figure. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |



# IADSketch.ConsumingFeature Property

Returns part feature consuming this sketch.

#### Syntax

```
IADPartFeature ConsumingFeature { get; }
```

#### Property Value

IADPartFeature



# IADSketch.Figures Property

Returns the collection of primitive figures in this sketch.

#### Syntax

```
IADSketchFigures Figures { get; }
```

#### Property Value

IADSketchFigures



# IADSketchText Methods

The IADSketchText type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |



# IADCompositeFigure Methods

The IADCompositeFigure type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding constituent sketch figure. |



# IADSketches.Session Property

Returns the design session for the collection.

#### Syntax

```
IADDesignSession Session { get; }
```

#### Property Value

IADDesignSession



# IADSketchEllipticArc.IsRightHandRule Property

Indicates whether the arc is drawn about the center from the start point to end point using right-hand rule or not.

#### Syntax

```
bool IsRightHandRule { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADSketchConstraint.Type Property

Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_CONSTRAINT)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADSketch.IsClosed Property

Returns True if the sketch is geometrically closed.

#### Syntax

```
bool IsClosed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADSketchPoint Properties

The IADSketchPoint type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | IsSketchNode | Returns True if this figure is a sketch node. |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |
|  | X | Returns the X coordinate of the point. |
|  | Y | Returns the Y coordinate of the point. |



# IADSketchEllipticArc Properties

The IADSketchEllipticArc type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Center | Gets the center point of the elliptical arc. |
|  | End | Returns end point of the elliptical arc. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | IsRightHandRule | Indicates whether the arc is drawn about the center from the start point to end point using right-hand rule or not. |
|  | MajorAxis | Gets length of major axis. |
|  | MajorAxisAngle | Gets the angle in radians, made by major axis with x-axis. |
|  | MinorMajorRatio | Gets the ratio of minor axis ot the major axis. |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | Start | Returns start point of the elliptical arc. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |



# IADSketchFigures.AddRectangle Method

Adds four sketch lines that form a rectangle with horizontal and vertical sides.

#### Syntax

```
IObjectCollector AddRectangle(
	double Xlow,
	double Ylow,
	double Xhigh,
	double Yhigh
)
```

#### Parameters

Xlow  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the lower left corner of the rectangle.

Ylow  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the lower left corner of the rectangle.

Xhigh  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the upper right corner of the rectangle.

Yhigh  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the upper right corner of the rectangle.

#### Return Value

IObjectCollector  
Returns a collection of the four
lines that compose the rectangle.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_NO\_ACTIVE\_SKETCHSESSION | The sketch to which this collection belongs does not have 2D sketch mode activated. |
| AD\_E\_INVALD\_CURRENT\_SKETCHSESSION | The sketch to which this collection belongs is no longer valid. |
| AD\_E\_COLLINEAR\_POINTS | The start and end points cannot be the same. |

#### Remarks

- The AddRectangle method returns a collection of four Sketch
  lines that form a rectangle as rectangles are represented as a series of Lines in Alibre Design.
- BeginChange or BeginChangeEx must be called on the current
  Sketch before adding any Sketch Figures to it.
- The default units for the coordinates are Centimeters and for Angle the default
  units are radians. If the Display Units are other than these, apply the corresponding conversion
  factor to compare the results.
- The rectangle will still be created successfully even if the "low" and "high"
  parameters are reversed.

#### Example

This Visual Basic sample shows how to call the AddRectangle method.

```
' Example Description: Demonstrates adding a Rectangular sketch
' with (0, 0) as lower Point, (1, 1) as upper Point.

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Holds XY-Plane
Set objADDesignPlane = objADDesignSession.DesignPlanes("XY-Plane")

' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session object from existing session
Set objADPartSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a new sketch to the above Design Plane.
Set objADSketch = objADSketches.AddSketch( _
        Nothing, objADDesignPlane, "NewSketch")

' Initiate Sketch edit mode
Call objADSketch.BeginChange

' Holds Sketch Figures object
Dim objADSketchFigures As AlibreX.IADSketchFigures

' Get Sketch Figures from Sketch object
Set objADSketchFigures = objADSketch.Figures

' Holds object collector
Dim objObjectCollector As AlibreX.IObjectCollector

' Add Rectangle
Set objObjectCollector = objADSketchFigures.AddRectangle(0, 0, 1, 1)

' Exit Sketch edit mode
Call objADSketch.EndChange
```



# IADSketch.Analyze Method

Analyzes the sketch for various possible sketch errors and optionally attempts to heal the
errors found in the sketch.

#### Syntax

```
IAnalyzedSketchData Analyze(
	bool bDisjointEnds,
	bool bOpenLoops,
	bool bOverLaps,
	bool bSelfIntersections,
	bool bDegenerateFigures,
	bool bHealSketch,
	double dblHealingTolerance
)
```

#### Parameters

bDisjointEnds  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, disjoint end errors will be included in the analysis.

bOpenLoops  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, open loop errors will be included in the analysis.

bOverLaps  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, figure overlap errors will be included in the analysis.

bSelfIntersections  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, self-intersection errors will be included in the analysis.

bDegenerateFigures  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, degenerate figure errors will be included in the analysis.

bHealSketch  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, errors found in the sketch will try to be healed.

dblHealingTolerance  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The tolerance with which figures may be changed to heal them.

#### Return Value

IAnalyzedSketchData  
A container for the results of the sketch analysis.



# IADSketchFigure.IsOwned Property

Returns true if the sketch figure is owned by a shape.

#### Syntax

```
bool IsOwned { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADSketch.Key Property

Gets the Persistent Key property of this sketch. This Key is unique for
this sketch and can be used to access the sketch.

#### Syntax

```
Array Key { get; }
```

#### Property Value

[Array](https://learn.microsoft.com/dotnet/api/system.array)



# IADSketch.IsActive Property

Gets whether the sketch is active. A value of 'true' indicates that the sketch is
visible. ie. Neither suppressed nor below the rollback bar in the design explorer.

#### Syntax

```
bool IsActive { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADCompositeFigure.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADSketchConstraint.Root Property

Returns the automation root object.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADSketchPoint.X Property

Returns the X coordinate of the point.

#### Syntax

```
double X { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADSketchFigures.AddCircularArcByCenterStartEnd Method

Adds a circular arc to the sketch given the arc center point, start point and end point.

#### Syntax

```
IADSketchCircularArc AddCircularArcByCenterStartEnd(
	double XCenter,
	double YCenter,
	double XStartPt,
	double YStartPt,
	double XEndPt,
	double YEndPt
)
```

#### Parameters

XCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the center point.

YCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the center point.

XStartPt  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the start point.

YStartPt  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the start point.

XEndPt  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the end point.

YEndPt  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the end point.

#### Return Value

IADSketchCircularArc  
If successful returns the created Sketch Circular Arc
else returns null.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_NO\_ACTIVE\_SKETCHSESSION | The sketch to which this collection belongs does not have 2D sketch mode activated. |
| AD\_E\_INVALD\_CURRENT\_SKETCHSESSION | The sketch to which this collection belongs is no longer valid. |
| AD\_E\_COLLINEAR\_POINTS | The start and end points cannot be the same. |

#### Remarks

- BeginChange or BeginChangeEx must be called on the current
  Sketch before adding any Sketch Figures to it.
- The default units for the coordinates are Centimeters and for Angle the default
  units are radians. If the Display Units are other than these, apply the corresponding conversion
  factor to compare the results.

#### Example

This Visual Basic sample shows how to call the AddCircularArcByCenterStartEnd method.

```
' Example Description: Demonstrates adding a sketch
' Circular arc with (0, 0) as origin, (1, 0) as Start Point
' and (-1, 0) as End Point.

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Holds XY-Plane
Set objADDesignPlane = objADDesignSession.DesignPlanes("XY-Plane")

' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session object from existing session
Set objADPartSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a new sketch to the above Design Plane.
Set objADSketch = objADSketches.AddSketch( _
        Nothing, objADDesignPlane, "NewSketch")

' Initiate Sketch edit mode
Call objADSketch.BeginChange

' Holds Sketch Figures object
Dim objADSketchFigures As AlibreX.IADSketchFigures

' Get Sketch Figures from Sketch object
Set objADSketchFigures = objADSketch.Figures

' Holds Sketch Circular Arc
Dim objADSketchCircularArc As AlibreX.IADSketchCircularArc

' Add Sketch Circular Arc By Center Point, Start Point, Point on End Ray
Set objADSketchCircularArc = objADSketchFigures.AddCircularArcByCenterStartEnd(0, 0, 1, 0, -1, 0)

' Exit Sketch edit mode
Call objADSketch.EndChange
```



# IADSketchEllipticArc.Center Property

Gets the center point of the elliptical arc.

#### Syntax

```
IADSketchPoint Center { get; }
```

#### Property Value

IADSketchPoint



# IADSketchCircle Methods

The IADSketchCircle type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |



# IADSketchEllipse Properties

The IADSketchEllipse type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Center | Returns the center point of the ellipse. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | MajorAxis | Gets the length of the major axis. |
|  | MajorAxisAngle | Gets the angle in radians, made by major axis with x-axis. |
|  | MinorMajorRatio | Gets the ratio of minor axis to the major axis. |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |



# IADSketchCircularArc.Start Property

Returns the Start point of the arc.

#### Syntax

```
IADSketchPoint Start { get; }
```

#### Property Value

IADSketchPoint



# IADSketchText.FontName Property

Sets/Returns the font name associated with this SketchText

#### Syntax

```
string FontName { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADSketchText.Bold Property

Sets/Returns the Bold property of the font associated with this SketchText

#### Syntax

```
bool Bold { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADSketchLine Interface

This interface represents the 2D Line Figure in the sketching environment.

#### Syntax

```
public interface IADSketchLine : IADSketchFigure
```

The IADSketchLine type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | End | The end point of the line. |
|  | FigureType | Returns a pre-defined constant that identifies the type of this sketch figure.  (Inherited from IADSketchFigure) |
|  | ID | Gets the ID property of this sketch figure. This ID is unique for the sketch figure and can be used to access the sketch figure.  (Inherited from IADSketchFigure) |
|  | IsAnchored | Gets/Sets the flag indicating if this figure is anchored.  (Inherited from IADSketchFigure) |
|  | IsOwned | Returns true if the sketch figure is owned by a shape.  (Inherited from IADSketchFigure) |
|  | IsReference | Gets/Sets the flag indicating if this figure is a reference figure.  (Inherited from IADSketchFigure) |
|  | Length | The length of the line. |
|  | Root | Returns the automation root.  (Inherited from IADSketchFigure) |
|  | Sketch | Returns the sketch to which this figure belongs.  (Inherited from IADSketchFigure) |
|  | Start | The start point of the line. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SKETCH\_FIGURE)  (Inherited from IADSketchFigure) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Deletes this sketch figure.  (Inherited from IADSketchFigure) |

#### Example

This Visual Basic demonstrates usage of sketch line related properties and methods.

```
' Example Description: Demonstrates usage of Sketch Line related 
' properties and methods

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Holds XY-Plane
Set objADDesignPlane = objADDesignSession.DesignPlanes("XY-Plane")

' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session object from existing session
Set objADPartSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a new sketch to the above Design Plane.
Set objADSketch = objADSketches.AddSketch( _
        Nothing, objADDesignPlane, "NewSketch")

' Initiate Sketch edit mode
Call objADSketch.BeginChange

' Holds Sketch Figures object
Dim objADSketchFigures As AlibreX.IADSketchFigures

' Get Sketch Figures from Sketch object
Set objADSketchFigures = objADSketch.Figures

' Holds Sketch Line
Dim objADSketchLine As AlibreX.IADSketchLine

' Add Sketch Line
Set objADSketchLine = objADSketchFigures.AddLine(0, 0, 1, 1)

' Exit Sketch edit mode
Call objADSketch.EndChange

' Holds Start Point
Dim objStartPoint As AlibreX.IADSketchPoint

' Get Start Point
Set objStartPoint = objADSketchLine.Start()

' Holds End Point
Dim objEndPoint As AlibreX.IADSketchPoint

' Get End Point
Set objEndPoint = objADSketchLine.End()

' Holds Length
Dim dblLength As Double

' Get Length
dblLength = objADSketchLine.Length()
```



# IADCompositeFigure.Count Property

Returns the number of constituent sketch figures in this composite figure.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADSketchFigures.AddBspline Method

Adds a Bspline to the sketch given arrays of control points, knot vectors and weights.

#### Syntax

```
IADSketchBspline AddBspline(
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
:   A double array of 2D control points.

pKnotVector  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   A double array of knot vector values.

pWeights  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   A double array representing the weights at the corresponding control points.
    The size of the pWeights is equal to the number of control points.

#### Return Value

IADSketchBspline  
If successful returns the created Sketch Bspline Curve
else returns null.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INVALID\_POLEARRAY\_SIZE | The size of pCtlPoints was invalid. Since this array contains X and Y values for each control point, it should be twice as long as the number of control points. |
| AD\_E\_INVALID\_UKNOTARRAY\_SIZE | The size of pKnotVector was invalid. |
| AD\_E\_TOOFEW\_CTRLPOINTS | The number of control points must be greater than or equal to the order of the spline. The order must also be greater than one. |
| AD\_E\_NO\_ACTIVE\_SKETCHSESSION | The sketch to which this collection belongs does not have 2D sketch mode activated. |
| AD\_E\_INVALD\_CURRENT\_SKETCHSESSION | The sketch to which this collection belongs is no longer valid. |

#### Remarks

- The created Bspline will be rational if the weights array contains some non-zero
  values, otherwise the generated curve will be non-rational.
- BeginChange or BeginChangeEx must be called on the current
  Sketch before adding any Sketch Figures to it.
- The default units for the coordinates are Centimeters and for Angle the default
  units are radians. If the Display Units are other than these, apply the corresponding conversion
  factor to compare the results.

#### Example

This Visual Basic sample shows how to call the AddBspline method.

```
' Example Description: Demonstrates adding a sketch Bspline with sample data.
' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Holds XY-Plane
Set objADDesignPlane = objADDesignSession.DesignPlanes("XY-Plane")

' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session object from existing session
Set objADPartSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a new sketch to the above Design Plane.
Set objADSketch = objADSketches.AddSketch( _
        Nothing, objADDesignPlane, "NewSketch")

' Initiate Sketch edit mode
Call objADSketch.BeginChange

' Holds Sketch Figures object
Dim objADSketchFigures As AlibreX.IADSketchFigures

' Get Sketch Figures from Sketch object
Set objADSketchFigures = objADSketch.Figures

' Holds Number of Knots
Const lngNumKnotVector = 12

' Holds Order of the bspline
Dim lngOrder As Long

' Bspline sketch order
lngOrder = 4

' Number of control
Const lngNumCtrlPoints = 8

' Allocate memory for X & Y point co-ordinates based on Number of control
Dim dblCtrlPoints(2 * lngNumCtrlPoints - 1) As Double

' Allocate memory for knot vector data
Dim dblKnotVector(lngNumKnotVector - 1) As Double

' Populate control point data
dblCtrlPoints(0) = 8.51186370849609
dblCtrlPoints(1) = 6.99780511856079
dblCtrlPoints(2) = 8.17882033581046
dblCtrlPoints(3) = 6.94976745716925
dblCtrlPoints(4) = 7.4561830417737
dblCtrlPoints(5) = 6.84553537063978
dblCtrlPoints(6) = 6.74456190752469
dblCtrlPoints(7) = 5.81435730131809
dblCtrlPoints(8) = 6.52782774895632
dblCtrlPoints(9) = 4.66411669565958
dblCtrlPoints(10) = 5.54729016867033
dblCtrlPoints(11) = 4.07984012807058
dblCtrlPoints(12) = 4.95126996822612
dblCtrlPoints(13) = 4.1095473709045
dblCtrlPoints(14) = 4.69674873352051
dblCtrlPoints(15) = 4.1222333908081

' Populate knot vector data
dblKnotVector(0) = 0
dblKnotVector(1) = 0
dblKnotVector(2) = 0
dblKnotVector(3) = 0
dblKnotVector(4) = 0.983174799451358
dblKnotVector(5) = 2.13329204214884
dblKnotVector(6) = 3.38226409165226
dblKnotVector(7) = 4.40411570159471
dblKnotVector(8) = 5.16570785718433
dblKnotVector(9) = 5.16570785718433
dblKnotVector(10) = 5.16570785718433
dblKnotVector(11) = 5.16570785718433

' Holds weights data
Dim dblWeights(lngNumCtrlPoints - 1) As Double

' Populate weights data
Dim lngIndex As Long
For lngIndex = 0 To lngNumCtrlPoints - 1
    dblWeights(lngIndex) = 0
Next lngIndex

' Holds Sketch Bspline
Dim objADSketchBspline As AlibreX.IADSketchBspline

' Add Sketch Bspline
Set objADSketchBspline = objADSketchFigures.AddBspline( _
        lngOrder, lngNumCtrlPoints, _
        dblCtrlPoints(), dblKnotVector(), dblWeights())

' Exit Sketch edit mode
Call objADSketch.EndChange
```



# IADSketchFigures.AddSketchPoint Method

Adds a Skech point using the given coordinates.

#### Syntax

```
IADSketchPoint AddSketchPoint(
	double XCoord,
	double YCoord
)
```

#### Parameters

XCoord  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the point.

YCoord  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the point.

#### Return Value

IADSketchPoint  
If successful returns IADSketchPoint else
returns null

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_NO\_ACTIVE\_SKETCHSESSION | The sketch to which this collection belongs does not have 2D sketch mode activated. |
| AD\_E\_INVALD\_CURRENT\_SKETCHSESSION | The sketch to which this collection belongs is no longer valid. |

#### Remarks

- BeginChange or BeginChangeEx must be called on the current
  Sketch before adding any Sketch Figures to it.
- The default units for the coordinates are Centimeters and for Angle the default
  units are radians. If the Display Units are other than these, apply the corresponding conversion
  factor to compare the results.

#### Example

This Visual Basic sample shows how to call the AddSketchPoint method.

```
' Example Description: Demonstrates adding a sketch Point
' at (1, 1).

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Design Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Design Plane
Dim objADDesignPlane As AlibreX.IADDesignPlane

' Holds XY-Plane
Set objADDesignPlane = objADDesignSession.DesignPlanes("XY-Plane")

' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session object from existing session
Set objADPartSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a new sketch to the above Design Plane.
Set objADSketch = objADSketches.AddSketch( _
        Nothing, objADDesignPlane, "NewSketch")

' Initiate Sketch edit mode
Call objADSketch.BeginChange

' Holds Sketch Figures object
Dim objADSketchFigures As AlibreX.IADSketchFigures

' Get Sketch Figures from Sketch object
Set objADSketchFigures = objADSketch.Figures

' Holds Sketch Point
Dim objADSketchPoint As AlibreX.IADSketchPoint

' Add Sketch Point
Set objADSketchPoint = objADSketchFigures.AddSketchPoint(1, 1)

' Exit Sketch edit mode
Call objADSketch.EndChange
```



# IADCompositeFigure.SketchFigure Property

Returns the SketchFigure owning this composite figure.

#### Syntax

```
IADComplexSketchFigure SketchFigure { get; }
```

#### Property Value

IADComplexSketchFigure



# IADSketchFigures.AddEllipseBy3Points Method

Adds a ellipse to the sketch given the center point, major axis point and minor axis point.

#### Syntax

```
IADSketchEllipse AddEllipseBy3Points(
	double XCenter,
	double YCenter,
	double XMajor,
	double YMajor,
	double XMinor,
	double YMinor
)
```

#### Parameters

XCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the center point of the ellipse.

YCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the center point of the ellipse.

XMajor  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the major axis point of the ellipse.

YMajor  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the major axis point of the ellipse.

XMinor  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the minor axis point of the ellipse.

YMinor  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the minor axis point of the ellipse.

#### Return Value

IADSketchEllipse  
If successful returns the created Sketch Ellipse else returns null.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_NO\_ACTIVE\_SKETCHSESSION | The sketch to which this collection belongs does not have 2D sketch mode activated. |
| AD\_E\_INVALD\_CURRENT\_SKETCHSESSION | The sketch to which this collection belongs is no longer valid. |

#### Remarks

- BeginChange or BeginChangeEx must be called on the current
  Sketch before adding any Sketch Figures to it.
- The default units for the coordinates are Centimeters and for Angle the default
  units are radians. If the Display Units are other than these, apply the corresponding conversion
  factor to compare the results.



# IADSketchFigures.AddEllipticArc Method

Adds an elliptic arc to the sketch given the center point, major axis length, minor axis length,
start and end points of the arc and the major axis angle.
NOTE: Flip the Start and End points if the curve needs to be in the opposite direction. This should be based on the right hand rule.

#### Syntax

```
IADSketchEllipticArc AddEllipticArc(
	double XCenter,
	double YCenter,
	double majorAxis,
	double minorMajorRatio,
	double XStart,
	double YStart,
	double XEnd,
	double YEnd,
	double majorAxisAngle
)
```

#### Parameters

XCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the center point of the elliptic arc.

YCenter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the center point of the elliptic arc.

majorAxis  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The length of the major axis.

minorMajorRatio  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Ratio of the minor axis to the major axis.

XStart  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the start point of the elliptic arc.

YStart  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the start point of the elliptic arc.

XEnd  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The X coordinate of the end point of the elliptic arc.

YEnd  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The Y coordinate of the end point of the elliptic arc.

majorAxisAngle  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The angle in radians, made by major axis with x-axis.

#### Return Value

IADSketchEllipticArc  
If successful returns the created Sketch EllipticArc else returns null.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_NO\_ACTIVE\_SKETCHSESSION | The sketch to which this collection belongs does not have 2D sketch mode activated. |
| AD\_E\_INVALD\_CURRENT\_SKETCHSESSION | The sketch to which this collection belongs is no longer valid. |

#### Remarks

- BeginChange or BeginChangeEx must be called on the current
  Sketch before adding any Sketch Figures to it.
- The default units for the coordinates are Centimeters and for Angle the default
  units are radians. If the Display Units are other than these, apply the corresponding conversion
  factor to compare the results.

