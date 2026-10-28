# AlibreX API — Part Features

> Part of the split AlibreX reference. See `00_index.md` for the full map.

**Sections in this file:** 426

---


# IADSMFlangeFeature Properties

The IADSMFlangeFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADSMUnbendFeature Methods

The IADSMUnbendFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADMirrorFeature Interface

IADMirrorFeature interface

#### Syntax

```
public interface IADMirrorFeature : IADPartFeature
```

The IADMirrorFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future expansion
of the API, to include information about Mirror features. For general information about a
feature, use the IADPartFeature interface.



# IADScaleFeature.UniformScaleFactorY Property

Returns the parameter driving the Y-direction component of the scale factor if
uniform scaling is not used for this feature.

#### Syntax

```
IADParameter UniformScaleFactorY { get; }
```

#### Property Value

IADParameter



# IADSMTabFeature Methods

The IADSMTabFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADSMFlangeFeature Interface

IADSMFlangeFeature interface

#### Syntax

```
public interface IADSMFlangeFeature : IADPartFeature
```

The IADSMFlangeFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future expansion
of the API, to include information about Flange features. For general information about a
feature, use the IADPartFeature interface.



# IADSMPunchFeature Properties

The IADSMPunchFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADScaleFeature.UniformScaleFactorZ Property

Returns the parameter driving the Z-direction component of the scale factor if
uniform scaling is not used for this feature.

#### Syntax

```
IADParameter UniformScaleFactorZ { get; }
```

#### Property Value

IADParameter



# IADThinWallRevolutionFeature Interface

IADThinWallRevolutionFeature interface

#### Syntax

```
public interface IADThinWallRevolutionFeature : IADPartFeature
```

The IADThinWallRevolutionFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future expansion
of the API, to include information about Thin Wall Revolution features. For general information about
a feature, use the IADPartFeature interface.



# IADProjectFeature.IsIntoSketchPlane Property

Gets if project direction is into sketch plane.

#### Syntax

```
bool IsIntoSketchPlane { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADScaleFeature Interface

This interface represents a Scale Feature. A Scale Feature increases or decreases
the size of a part.

#### Syntax

```
public interface IADScaleFeature : IADPartFeature
```

The IADScaleFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | IsUniformScaling | Returns whether Uniform Scaling was chosen or not. If true, the part is scaled by the same factor in all 3 directions. Otherwise the scale factors for the X, Y, and Z directions are specified individually. |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | ScaleAboutCenteroid | Returns true if scaled about the centeroid. If false, it means that it was scaled about the Origin of the part workspace. |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UniformScaleFactor | Returns the parameter driving the scale factor if uniform scaling is used for this feature. |
|  | UniformScaleFactorX | Returns the parameter driving the X-direction component of the scale factor if uniform scaling is not used for this feature. |
|  | UniformScaleFactorY | Returns the parameter driving the Y-direction component of the scale factor if uniform scaling is not used for this feature. |
|  | UniformScaleFactorZ | Returns the parameter driving the Z-direction component of the scale factor if uniform scaling is not used for this feature. |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADDraftFeature Properties

The IADDraftFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DraftAngleParameter | Returns the angle parameter of how much a given face or faces must be drafted. |
|  | DraftFaces | Returns the faces used for drafting. |
|  | DraftNeutralPlane | Returns the draft neutral plane. The neutral plane is the starting point for the draft, and the plane or face from which the draft angle is calculated. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsOutwardDraft | Returns True if the direction of the draft is outward; otherwise, it is inward. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADAssemblyExtrusionFeature Properties

The IADAssemblyExtrusionFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FeatureType | Returns the feature type (extrusion, hole etc.)  (Inherited from IADAssemblyFeature) |
|  | Name | Returns the name of this design feature.  (Inherited from IADAssemblyFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADAssemblyFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADAssemblyFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_FEATURE)  (Inherited from IADAssemblyFeature) |



# IADHoleFeature.MajorDiameter Property

Returns the major diameter of hole(s).

#### Syntax

```
double MajorDiameter { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

Valid only for holes with the following
HoleTypes:

- AD\_TAPERED\_HOLE
- AD\_TAPERED\_DRILLED\_HOLE



# IADPartFeatures.AddDrilledHoleEx Method

Creates a drilled simple Hole feature.

#### Syntax

```
IADHoleFeature AddDrilledHoleEx(
	IADSketch pSketch,
	Object depth,
	Object diameter,
	Object drillAngle,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = "",
	string diameterParameterName = "",
	string drillAngleParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

diameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the diameter.

drillAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the angle for the drill end.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

diameterParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the diameter parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

drillAngleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the drill angle parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADThinWallSweepFeature Interface

IADThinWallSweepFeature interface

#### Syntax

```
public interface IADThinWallSweepFeature : IADPartFeature
```

The IADThinWallSweepFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future expansion
of the API, to include information about Thin Wall Sweep features. For general information about
a feature, use the IADPartFeature interface.



# IADChamferFeature Interface

This interface represents an edge Chamfer Feature. Chamfer features create a
beveled face on a selected edge or face.

#### Syntax

```
public interface IADChamferFeature : IADPartFeature
```

The IADChamferFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Angle | Returns the parameter driving the chamfer angle if it exists. |
|  | Distance1 | Returns the parameter driving the chamfer distance 1. |
|  | Distance2 | Returns the parameter driving the chamfer distance 2 if it exists. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | EdgesAndFaces | Returns the collection of Chamfered Edges and Faces. |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | TangentPropagate | Returns whether the Tangent Propagate option was chosen. The Tangent Propagate option creates a chamfer on each selected edge as well as any other edges that form a path in which a tangent condition can be resolved. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADExtrusionFeature.DirectionVector Property

Gets the direction vector.

#### Syntax

```
IADVector DirectionVector { get; }
```

#### Property Value

IADVector



# IADWrapFeature.IsCutout Property

Returns True if wrap is a cutout.

#### Syntax

```
bool IsCutout { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADLoftFeature.IsTangentSpecified Method

Returns True if the input cross section of the loft has a specified Tangent Magnitude
indicating the weight of the tangent. If the cross section object is a sketch, it may
also have a Tangent Angle specified.

#### Syntax

```
bool IsTangentSpecified(
	Object crossSection
)
```

#### Parameters

crossSection  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The cross section of this loft feature to check. This can
    be an IADSketch, IADFace, or IADDesignPoint that is in this loft feature's
    CrossSections property or the numerical index of the cross section.

#### Return Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADHelicalFeature.StartFlatAngle Property

Returns the parameter driving the flat angle at the start of the helix, if the
start condition is
Flat.

#### Syntax

```
IADParameter StartFlatAngle { get; }
```

#### Property Value

IADParameter



# IADExternalThreadFeature.CalloutRTF Property

Returns a rich text format string containing the callout for the external thread feature.

#### Syntax

```
string CalloutRTF { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPartFeatures.AddVertexChamferFeature Method

Creates a Vertex Chamfer feature by chamfering a specified distance along each of the edges which
meet at the vertex.

#### Syntax

```
IADVertexChamferFeature AddVertexChamferFeature(
	IObjectCollector colVertices,
	Object distance1,
	Object distance2,
	Object distance3,
	string dist1ParameterName = "",
	string dist2ParameterName = "",
	string dist3ParameterName = "",
	string name
)
```

#### Parameters

colVertices  IObjectCollector
:   A collection containing one or more vertices
    which will be chamfered by this feature.

distance1  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the first distance parameter; can be a number or an
    equation obtained from a parameter.

distance2  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the second distance parameter; can be a number or an
    equation obtained from a parameter.

distance3  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the third distance parameter; can be a number or an
    equation obtained from a parameter.

dist1ParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the first distance parameter
    that will be created for the chamfer feature. If no name is provided, a default name will
    be generated.

dist2ParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the second distance parameter
    that will be created for the chamfer feature. If no name is provided, a default name will
    be generated.

dist3ParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the third distance parameter
    that will be created for the chamfer feature. If no name is provided, a default name will
    be generated.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the chamfer feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADVertexChamferFeature  
Returns the new vertex chamfer feature.

#### Example

This sample demonstrates creating a Vertex Chamfer feature.

```
Debug.Print "***********Add Vertex Chamfer*****************"

Dim objSession As AlibreX.IADPartSession
Dim objPartFeatures As IADPartFeatures
Dim objVertexChamfer As IADChamferFeature
Dim objVertices As IObjectCollector
Dim objVertex As IADVertex

Set m_Alibreobjsessions = m_Alibreobjroot.Sessions
If m_Alibreobjsessions.Item(0).SessionType = ADObjectSubType_AD_PART Then
    Set objSession = m_Alibreobjsessions.Item(0)
Else
    Debug.Print "This is not a part session"
    Exit Function
End If

Set objPartFeatures = objSession.Features
Set objVertices = m_Alibreobjroot.NewObjectCollector

Dim objBody As IADBody
Set objBody = objSession.Bodies.Item(0)

' Add the vertices to fillet to the collection.
If (Not objBody Is Nothing) Then
    Call objVertices.Add(objBody.Vertices.Item(0))
    Call objVertices.Add(objBody.Vertices.Item(4))
End If

' Specify the distances along each edge touching the vertex to chamfer.
Dim objDist1 As Double
Dim objDist2 As Double
Dim objDist3 As Double
objDist1 = 0.25
objDist2 = 0.25
objDist3 = 0.25

' Create the Vertex Chamfer
Set objVertexChamfer = objPartFeatures.AddVertexChamferFeature(objVertices, _
        objDist1, objDist2, objDist3, "mydist1", "mydist2", "mydist3", "MyVertexChamferfromAPI")
Debug.Print "Vertex Chamfer from API Created Successfully"

Debug.Print "****************************"
```



# IADTappedThreadInfo.Name Property

Returns the name of the thread.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADHelicalFeature.Height Property

Returns the parameter driving the height of the helix. This parameter is used by helices with
HelixType AD\_Height\_Pitch or
AD\_Height\_Revolution.

#### Syntax

```
IADParameter Height { get; }
```

#### Property Value

IADParameter



# IADPartFeatures.Count Property

Returns the number of features in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADDesignBooleanFeature Methods

The IADDesignBooleanFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADPartFeatures.AddSimpleHoleEx Method

Creates a simple Hole feature.

#### Syntax

```
IADHoleFeature AddSimpleHoleEx(
	IADSketch pSketch,
	Object depth,
	Object diameter,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = "",
	string diameterParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

diameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the diameter.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

diameterParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the diameter parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADMirrorFeature Properties

The IADMirrorFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADHoleFeature.OffsetFromLimitingGeometry Property

Returns the offset distance from limiting face for holes with a
DepthConditionType of
AD\_HOLE\_TO\_OFFSET\_FACE.

#### Syntax

```
double OffsetFromLimitingGeometry { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADExtrusionFeature.IsOutwardDraft Property

Gets/sets if draft is outward or not.

#### Syntax

```
bool IsOutwardDraft { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADAssemblyFeature.Name Property

Returns the name of this design feature.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADPartFeatures.CreateTappedThreadInfo Method

Returns IADTappedThreadInfo containing the Tapped Thread information to be used for Hole feature creation.

#### Syntax

```
IADTappedThreadInfo CreateTappedThreadInfo(
	ADTappedThreadType threadType,
	string name,
	string threadClass,
	double pitch,
	double tapDrillDiameter,
	double majorDiameter,
	double minorDiameter,
	double pitchDiameter,
	double threadLength
)
```

#### Parameters

threadType  ADTappedThreadType
:   Denotes the series of the thread.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Denotes the name of the thread.

threadClass  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Denotes the class of the thread.

pitch  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the pitch.

tapDrillDiameter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the tap drill diameter.

majorDiameter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the major diameter.

minorDiameter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the minor diameter.

pitchDiameter  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the pitch diameter.

threadLength  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the length of the thread.

#### Return Value

IADTappedThreadInfo  
Returns an IADTappedThreadInfo object containing
the specified information.



# IADRevolutionFeature Properties

The IADRevolutionFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | AngleParameter | Returns the parameter driving the angle of revolution. |
|  | Axis | Gets the target proxy containing the axis of revolution and its occurrence if it has one. The axis can be a design axis or linear edge. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsCutout | Returns True if revolved feature is a cutout. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Sketch | Returns the sketch used to create revolution. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADRemoveFaceFeature Interface

IADRemoveFaceFeature interface

#### Syntax

```
public interface IADRemoveFaceFeature : IADPartFeature
```

The IADRemoveFaceFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADExternalThreadFeature.MajorDiameter Property

The major diameter of the external thread feature.

#### Syntax

```
double MajorDiameter { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADShellFeature.IsShellOutward Property

Returns true if shell is created outward. If true, the shell is created by forming
the shell on the outside of the solid, then removing the original model. Whereas, an
inward shell is created by cutting away the inside of the model.

#### Syntax

```
bool IsShellOutward { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADMoveFaceFeature Interface

This interface represents a Move Face feature.

#### Syntax

```
public interface IADMoveFaceFeature : IADPartFeature
```

The IADMoveFaceFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future
expansion of the API, to include information about Move Face features. For general
information about a feature, use the IADPartFeature
interface.



# IADExternalThreadFeature Methods

The IADExternalThreadFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADLoftFeature.IsMinimizeTwist Property

Returns True if the "Minimize Twist" loft option is enabled.

#### Syntax

```
bool IsMinimizeTwist { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADHoleFeature.HoleType Property

Returns the type of hole(s), e.g.
"Counter Bored Hole".

#### Syntax

```
ADHoleType HoleType { get; }
```

#### Property Value

ADHoleType



# IADPartFeatures.AddExtrudedCutout Method

Adds an extruded cut feature, which removes material by extending a sketch in a
linear direction by a specified distance. It is possible to specify a draft angle to taper
the extrusion. 'To Geometry' can specify any face in an assembly context.
'Along Edge' can specify any edge in assembly context.

#### Syntax

```
IADExtrusionFeature AddExtrudedCutout(
	IADSketch pSketch,
	Object depth,
	ADPartFeatureEndCondition endCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	ADDirectionType direction,
	IADOccurrence pDirectionOcc,
	Object pDirectionObject,
	bool isDirectionReversed,
	Object draftAngle,
	bool IsOutwardDraft,
	string name,
	string depthParameterName = "",
	string angleParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch to extrude.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

endCondition  ADPartFeatureEndCondition
:   Denotes the end condition of the feature to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if endCondition is not AD\_TO\_GEOMETRY
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if endCondition is
    not AD\_TO\_GEOMETRY.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the extrusion up to
    a specified distance from the Target (toGeometryObject).

direction  ADDirectionType
:   Denotes the direction of extrusion.

pDirectionOcc  IADOccurrence
:   Denotes an instance of pDirectionObject in an assembly.
    This can be null if pDirectionObject belongs to a part.

pDirectionObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the direction object along which the extrusion
    will be created. This can be null if direction is AD\_ALONG\_NORMAL.

isDirectionReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the extrusion in a direction
    opposite to normal to the sketch plane.

draftAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   This can be a number or an equation from a parameter. Pass zero,
    or a number to create a tapered extrusion.

IsOutwardDraft  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If this is true, the extrusion will be drafted outwards else
    it will be drafted inwards.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the extruded object. If no name is provided, a default name will
    be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the extrusion feature. If no name is provided, a default name will
    be generated.

angleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the angle parameter
    that will be created for the extrusion feature if a draft angle is present. If no name is
    provided, a default name will be generated.

#### Return Value

IADExtrusionFeature  
Returns the new extrusion feature.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INVALID\_ENDCONDITION | The specified endCondition is not valid for an Extruded Boss feature |
| AD\_E\_ZERO\_DEPTH | If endContion is AD\_TO\_DEPTH, depth's value cannot be zero. |

#### Remarks

- depth - The depth cannot be zero if endCondition is AD\_TO\_DEPTH.
- endCondition - Create the extrusion using the following end condition types:
  1. AD\_TO\_DEPTH - Creates an extrusion of a specified length on one side of the
     sketching plane.
  2. AD\_MID\_PLANE - Creates an extrusion of a specified length on both sides of the
     sketching plane. Half the extrusion length is proportioned to each side of the sketching plane.
  3. AD\_TO\_NEXT - Creates an extrusion to the next available face in the model in
     direction of the extrusion.
  4. AD\_TO\_GEOMETRY - Creates an extrusion up to a specified reference plane or face.
  5. AD\_THROUGH\_ALL - Creates the cut through the entire solid in the specified direction
- direction - The direction can be:
  1. AD\_ALONG\_NORMAL - Creates the extrusion normal to the sketch plane.
  2. AD\_ALONG\_AXIS - Creates the extrusion along a Design Axis.
  3. AD\_ALONG\_EDGE - Creates the extrusion along a Design Edge.
- This method will throw an exception under the following situations:
  1. If pSketch is already used by any other feature.
  2. If draftAngle falls outside the range -60 to 60.
  3. If endContion is AD\_TO\_DEPTH and depth's value is zero.
- Note that the newly created Part Feature is not added to the Collection on which this
  method is called. Query for the Collection again to get the updated Collection.
- If the created feature has an error, an error is thrown and the feature still remains
  in the features list.

#### Example

This Visual Basic sample demonstrates adding an Extrude Cut Feature to the Part Features Collection.

```
' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session from Session
Set objADPartSession = m_objADSession

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Part Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a sketch on "XY-Plane"
Set objADSketch = objADSketches.AddSketch(Nothing, _
        objADDesignSession.DesignPlanes("XY-Plane"), _
        "NewSketch")

' Initialize Edit Mode
Call objADSketch.BeginChange

' Add a Circle to the Sketch Figures
Call objADSketch.Figures.AddCircle(0, 0, 5)

' Exit Edit Mode
Call objADSketch.EndChange

' Holds Part Features object
Dim objADPartFeatures As AlibreX.IADPartFeatures

' Get Part Features object from Part Session
Set objADPartFeatures = objADPartSession.Features

' Holds Extrusion Feature Object
Dim objExtrusionBossFeature As AlibreX.IADExtrusionFeature

' Add an Extruded Boss to the Part Features collection
Set objExtrusionBossFeature = objADPartFeatures.AddExtrudedBoss( _
        objADSketch, _
        5, _
        AD_TO_DEPTH, _
        Nothing, _
        Nothing, _
        0, _
        AD_ALONG_NORMAL, _
        Nothing, _
        Nothing, _
        False, _
        0.15, _
        False, _
        "NewExtrusionBossFeature")

' Holds Sketch Object
Dim objADSketch1 As AlibreX.IADSketch

' Add a sketch on "XY-Plane"
Set objADSketch1 = objADSketches.AddSketch(Nothing, _
        objADDesignSession.DesignPlanes("XY-Plane"), _
        "NewSketch1")

' Initialize Edit Mode
Call objADSketch1.BeginChange

' Add a Circle to the Sketch Figures
Call objADSketch1.Figures.AddCircle(0, 0, 4)

' Exit Edit Mode
Call objADSketch1.EndChange

' Holds Extrusion Feature Object
Dim objExtrusionCutFeature As AlibreX.IADExtrusionFeature

' Add an Extruded Cut to the Part Features collection
Set objExtrusionBossFeature = objADPartFeatures.AddExtrudedCutout( _
        objADSketch1, _
        5, _
        AD_TO_DEPTH, _
        Nothing, _
        Nothing, _
        0, _
        AD_ALONG_NORMAL, _
        Nothing, _
        Nothing, _
        False, _
        0.15, _
        False, _
        "NewExtrusionCutFeature")
```



# IADAssemblyFeature.Session Property

Returns the session to which this feature belongs.

#### Syntax

```
IADSession Session { get; }
```

#### Property Value

IADSession



# IADPartFeatures.AddSweptCutout Method

Creates a sweep cut feature, which removes material by moving a sketch along a path
defined by a second sketch.

#### Syntax

```
IADSweepFeature AddSweptCutout(
	IADSketch pProfileSketch,
	IObjectCollector pPathSketch,
	bool IsRigid,
	ADPartFeatureEndCondition endCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	Object draftAngle,
	bool IsOutwardDraft,
	string name
)
```

#### Parameters

pProfileSketch  IADSketch
:   Denotes the sketch which will be swept along pPathSketch.

pPathSketch  IObjectCollector
:   Denotes the sketch used as a path for sweeping pProfileSketch.

IsRigid  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If this is set to true, pProfileSketch remains parallel to the
    profile's sketching plane throughout the sweep.

endCondition  ADPartFeatureEndCondition
:   Denotes how to terminate the sweep.

toGeometryOcc  IADOccurrence
:   Denotes an instance of toGeometryObject from an assembly.
    This can be null if toGeometryObject represents a feature obtained from a
    Part Session

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane or a
    Face. This can be null if endCondition is not
    AD\_TO\_GEOMETRY.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the sweep up to a specified
    distance from the Target (toGeometryObject).

draftAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   This can be a number or an equation from a
    parameter. Pass zero, or a number to create a tapered sweep.

IsOutwardDraft  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If this is set to true, the draft will be created outwards.
    The end face of the created feature will be larger than the starting face.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the Part Feature created. If there is no name, a default name
    will be created for the newly created Part Feature.

#### Return Value

IADSweepFeature  
Returns the new sweep feature.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INVALID\_PATHOBJECT | The specified sweep path is not valid. |
| AD\_E\_INVALID\_ENDCONDITION | Only the AD\_TO\_GEOMETRY and AD\_ENTIRE\_PATH end conditions are valid for sweep features. |
| AD\_E\_INVALID\_GEOMETRY | toGeometryObject was not valid plane or face. |
| AD\_E\_INVALID\_ANGLE | The specified angle is not valid. |

#### Remarks

The following guidelines should be followed when creating swept features.

- The sketch that defines the profile must be closed.
- The sketch that defines the path can be open or closed but cannot be self-intersecting.
- The sketch path cannot lie on the same sketching plane as the profile.
- The sketch path must either start on the profile plane or pass through the profile plane.
- Valid values for the endCondition parameter are:
  - AD\_TO\_GEOMETRY
  - AD\_ENTIRE\_PATH
- pProfileSketch should be an unconsumed sketch.

Note that the newly created Part Feature is not added to the Collection on which this
method is called. Query for the Collection again to get the updated Collection.

If the created feature has an error, an error is thrown and the feature still remains
in the features list.

#### Example

This Visual Basic sample demonstrates adding a Sweep Cut Feature to the Part Features Collection.

```
' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session from Session
Set objADPartSession = m_objADSession

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Part Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADPathSketch As AlibreX.IADSketch

' Add a sketch on "XY-Plane"
Set objADPathSketch = objADSketches.AddSketch(Nothing, _
        objADDesignSession.DesignPlanes("XY-Plane"), _
        "PathSketch")

' Initialize Edit Mode
Call objADPathSketch.BeginChange

' Add a Rectangle to the Sketch Figures
Call objADPathSketch.Figures.AddCircle(0, 0, 10)

' Exit Edit Mode
Call objADPathSketch.EndChange

' Holds Object Collector
Dim objPathCollector As AlibreX.IObjectCollector

' Create new Object Collector
Set objPathCollector = m_objADRoot.NewObjectCollector

' Add Path Sketch to the Object Collector
objPathCollector.Add objADPathSketch

' Holds Sketch Object
Dim objADSweepSketch As AlibreX.IADSketch

' Add a sketch on "XY-Plane"
Set objADSweepSketch = objADSketches.AddSketch(Nothing, _
        objADDesignSession.DesignPlanes("ZX-Plane"), _
        "SweepSketch")

' Initialize Edit Mode
Call objADSweepSketch.BeginChange

' Add a Rectangle to the Sketch Figures
Call objADSweepSketch.Figures.AddCircle(10, 0, 2)

' Exit Edit Mode
Call objADSweepSketch.EndChange

' Holds Part Features object
Dim objADPartFeatures As AlibreX.IADPartFeatures

' Get Part Features object from Part Session
Set objADPartFeatures = objADPartSession.Features

' Holds Sweep Feature Object
Dim objSweeptBossFeature As AlibreX.IADSweepFeature

' Add an Revolved Boss to the Part Features collection
Set objSweeptBossFeature = objADPartFeatures.AddSweptBoss( _
        objADSweepSketch, _
        objPathCollector, _
        False, _
        AD_ENTIRE_PATH, _
        Nothing, _
        Nothing, _
        0, _
        0, _
        False, _
        "NewSweepBossFeature")

' Holds Sketch Object
Dim objADPathSketch1 As AlibreX.IADSketch

' Add a sketch on "XY-Plane"
Set objADPathSketch1 = objADSketches.AddSketch(Nothing, _
        objADDesignSession.DesignPlanes("XY-Plane"), _
        "PathSketch1")

' Initialize Edit Mode
Call objADPathSketch1.BeginChange

' Add a Rectangle to the Sketch Figures
Call objADPathSketch1.Figures.AddCircle(0, 0, 10)

' Exit Edit Mode
Call objADPathSketch1.EndChange

' Holds Object Collector
Dim objPathCollector1 As AlibreX.IObjectCollector

' Create new Object Collector
Set objPathCollector1 = m_objADRoot.NewObjectCollector

' Add Path Sketch to the Object Collector
objPathCollector1.Add objADPathSketch1

' Holds Sketch Object
Dim objADSweepSketch1 As AlibreX.IADSketch

' Add a sketch on "XY-Plane"
Set objADSweepSketch1 = objADSketches.AddSketch(Nothing, _
        objADDesignSession.DesignPlanes("ZX-Plane"), _
        "SweepSketch1")

' Initialize Edit Mode
Call objADSweepSketch1.BeginChange

' Add a Rectangle to the Sketch Figures
Call objADSweepSketch1.Figures.AddRectangle(9, 0, 11, 5)

' Exit Edit Mode
Call objADSweepSketch1.EndChange

' Holds Sweep Feature Object
Dim objSweeptCutFeature As AlibreX.IADSweepFeature

' Add an Sweept Cut to the Part Features collection
Set objSweeptCutFeature = objADPartFeatures.AddSweptCutout( _
        objADSweepSketch1, _
        objPathCollector1, _
        False, _
        AD_ENTIRE_PATH, _
        Nothing, _
        Nothing, _
        0, _
        0, _
        False, _
        "NewSweeptCutFeature")
```



# IADSweepFeature.EndCondition Property

Gets the end condition information.

#### Syntax

```
IADTargetProxy EndCondition { get; }
```

#### Property Value

IADTargetProxy

#### Remarks

The IADTargetProxy object contains the EndCondtion object and
its occurrence. If the target object doesn't
belong to an assembly, the occurrence object will be null.



# IADScaleFeature.ScaleAboutCenteroid Property

Returns true if scaled about the centeroid. If false, it means that it was scaled
about the Origin of the part workspace.

#### Syntax

```
bool ScaleAboutCenteroid { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

The centroid is the center of the solid model, rather than the workspace.



# IADTappedThreadInfo.ThreadClass Property

Returns the class of the thread.

#### Syntax

```
string ThreadClass { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADHoleFeature.CounterBoreDiameter Property

Returns the counter bore diameter of hole(s).

#### Syntax

```
double CounterBoreDiameter { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

Valid only for holes with the following
HoleTypes:

- AD\_COUNTER\_BORED\_HOLE
- AD\_COUNTER\_BORED\_DRILLED\_HOLE



# IADHelicalFeature.IsParallelOriented Property

Returns true if the helix's profile is oriented parallel to the Axis; otherwise, it is
oriented normal to the helical path.

#### Syntax

```
bool IsParallelOriented { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPartFeatures.AddConstantRadiusFilletFeature Method

Creates a fillet feature on the given Edges and/or
Faces with the given constant radius.

#### Syntax

```
IADFilletFeature AddConstantRadiusFilletFeature(
	IObjectCollector colEdgesAndFaces,
	Object vConstantRadius,
	bool bTangentPropagate,
	string strConstRadParameterName,
	string name
)
```

#### Parameters

colEdgesAndFaces  IObjectCollector
:   A collection of edges and/or
    faces to which the fillet will be applied.

vConstantRadius  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the radius parameter; can be a number or an
    equation obtained from a parameter.

bTangentPropagate  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If the Tangent Propogate option is true, the fillet will
    be created along the selected edge as well as any other edges that form a path
    in which a tangent condition can be resolved.

strConstRadParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the radius parameter
    that will be created for the fillet feature. If no name is provided, a default name will
    be generated.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the fillet feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADFilletFeature  
Returns the new fillet feature.

#### Example

This sample demonstrates creating a Vertex Chamfer feature.

```
Debug.Print "***********Add Vertex Chamfer*****************"

Dim objSession As AlibreX.IADPartSession
Dim objPartFeatures As IADPartFeatures
Dim objVertexChamfer As IADChamferFeature
Dim objVertices As IObjectCollector
Dim objVertex As IADVertex

Set m_Alibreobjsessions = m_Alibreobjroot.Sessions
If m_Alibreobjsessions.Item(0).SessionType = ADObjectSubType_AD_PART Then
    Set objSession = m_Alibreobjsessions.Item(0)
Else
    Debug.Print "This is not a part session"
    Exit Function
End If

Set objPartFeatures = objSession.Features
Set objVertices = m_Alibreobjroot.NewObjectCollector

Dim objBody As IADBody
Set objBody = objSession.Bodies.Item(0)

' Add the vertices to fillet to the collection.
If (Not objBody Is Nothing) Then
    Call objVertices.Add(objBody.Vertices.Item(0))
    Call objVertices.Add(objBody.Vertices.Item(4))
End If

' Specify the distances along each edge touching the vertex to chamfer.
Dim objDist1 As Double
Dim objDist2 As Double
Dim objDist3 As Double
objDist1 = 0.25
objDist2 = 0.25
objDist3 = 0.25

' Create the Vertex Chamfer
Set objVertexChamfer = objPartFeatures.AddVertexChamferFeature(objVertices, _
        objDist1, objDist2, objDist3, "mydist1", "mydist2", "mydist3", "MyVertexChamferfromAPI")
Debug.Print "Vertex Chamfer from API Created Successfully"

Debug.Print "****************************"
```



# IADSMDimpleFeature Interface

IADSMDimpleFeature interface

#### Syntax

```
public interface IADSMDimpleFeature : IADPartFeature
```

The IADSMDimpleFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future
expansion of the API, to include information about Dimple features. For general
information about a feature, use the IADPartFeature interface.



# IADHoleFeature.CounterSinkDiameter Property

Returns the counter sink diameter of hole(s).

#### Syntax

```
double CounterSinkDiameter { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

Valid only for holes with the following
HoleTypes:

- AD\_COUNTER\_SUNK\_HOLE
- AD\_COUNTER\_SUNK\_DRILLED\_HOLE



# IADTappedThreadInfo.TapDrillDiameter Property

Returns the tap drill diameter of the thread.

#### Syntax

```
double TapDrillDiameter { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADPartFeature.HasError Property

Returns True if error was encountered in computing the feature.

#### Syntax

```
bool HasError { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPartFeature.IsSuppressed Property

Gets/Sets the suppression state of this feature.

#### Syntax

```
bool IsSuppressed { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

If another feature depends (directly or indirectly) on this feature, then
suppressing this feature may cause the dependent feature to fail.



# IADWrapFeature.DepthParameter Property

Returns the parameter driving the wrap depth.

#### Syntax

```
IADParameter DepthParameter { get; }
```

#### Property Value

IADParameter



# IADSweepFeature.IsOutwardDraft Property

Gets/sets if the draft is outward or not.

#### Syntax

```
bool IsOutwardDraft { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADExternalThreadFeature.MinorDiameter Property

The IADParameter which defines the minor diameter of this external thread feature.

#### Syntax

```
IADParameter MinorDiameter { get; }
```

#### Property Value

IADParameter



# IADVertexChamferFeature.Distance2 Property

Returns the distance which the chamfer will extend along the second edge.

#### Syntax

```
IADParameter Distance2 { get; }
```

#### Property Value

IADParameter



# IADImportFileFeature Methods

The IADImportFileFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADMirrorFeature Methods

The IADMirrorFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADAssemblyFeatures Interface

IADAssemblyFeatures interface represents the collection of assembly features present
in an assembly session.

#### Syntax

```
public interface IADAssemblyFeatures
```

The IADAssemblyFeatures type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of features in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the parent assembly session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given a numerical index/name into the collection, returns the corresponding assembly feature. |



# IADWrapFeature.Sketch Property

Returns the sketch used to create wrap.

#### Syntax

```
IADSketch Sketch { get; }
```

#### Property Value

IADSketch



# IADSweepFeature.IsCutout Property

Returns True if the sweep feature is a cutout.

#### Syntax

```
bool IsCutout { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADWrapFeature Properties

The IADWrapFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DepthParameter | Returns the parameter driving the wrap depth. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | FocusType | Gets the focus type. |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsCutout | Returns True if wrap is a cutout. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Sketch | Returns the sketch used to create wrap. |
|  | TargetFace | Gets the target face. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADPartFeatures.AddLoftCut Method

Creates Loft Cut feature.

#### Syntax

```
IADLoftFeature AddLoftCut(
	IObjectCollector CrossSections,
	IObjectCollector Tangents,
	IObjectCollector TangentMagnitudes,
	IObjectCollector TangentAngles,
	IObjectCollector GuideCurves,
	ADLoftGuideType GuideCurveType,
	bool MinimizeTwist,
	bool MinimizeCurvature,
	bool SimplifySurface,
	bool ConnectEnds,
	string Name
)
```

#### Parameters

CrossSections  IObjectCollector
:   A collection of the cross sections which will define the loft.
    Cross sections must be either IADSketch, IADFace, or IADDesignPoint types.

Tangents  IObjectCollector
:   A collection of boolean values, to indicate whether the cross sections will
    have a specified tangency. Must either contain the same number of elements
    as CrossSections, or be null or empty to indicate that no tangency control will
    be used. If GuideCurves are specified, this parameter will be ignored.

TangentMagnitudes  IObjectCollector
:   A collection of double values, to indicate the tangent magnitude for particular
    cross sections. Must either contain the same number of elements as CrossSections,
    or be null or empty to indicate that no tangency control will be used.
    If GuideCurves are specified, this parameter will be ignored.

TangentAngles  IObjectCollector
:   A collection of double values, to indicate the tangent angles for particular
    cross sections. Must either contain the same number of elements as CrossSections,
    or be null or empty to indicate that no tangency control will be used.
    If GuideCurves are specified, this parameter will be ignored.

GuideCurves  IObjectCollector
:   A collection of guide curves to further define the results of the loft. Guide curves
    must be of type IAD3DSketch. To indicate the loft should not use guide curves, pass
    a null or empty array.

GuideCurveType  ADLoftGuideType
:   The type of guide curves to be used with the loft feature. Will be ignored
    if no guide curves are specified.

MinimizeTwist  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Minimize twisting of the loft surface.

MinimizeCurvature  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Minimize the curvature of the loft surface.
    Not available when using Guide Curves.

SimplifySurface  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Simplify the surface of the loft.

ConnectEnds  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Connect the start and end cross sections of the Loft.

Name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optionally, specify a name for the new Loft feature.

#### Return Value

IADLoftFeature  
Returns the newly created loft feature.



# IADHoleFeature Methods

The IADHoleFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADPartFeatures.AddVariableRadiusFilletFeature Method

Creates a fillet feature on the given Edges and/or Faces with the given variable radius.
Note that no. of Start/End Radii should match the number of Edges and Faces in the given
colEdgesAndFaces.

#### Syntax

```
IADFilletFeature AddVariableRadiusFilletFeature(
	IObjectCollector colEdgesAndFaces,
	in Array pStartRadiui,
	in Array pEndRadiui,
	bool bTangentPropagate,
	string name
)
```

#### Parameters

colEdgesAndFaces  IObjectCollector
:   A collection of edges and/or
    faces to which the fillet will be applied.

pStartRadiui  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   An array of start radius parameters; each can be a number or an
    equation obtained from a parameter. This array should contain a start radius for each
    edge or face in colEdgesAndFaces.

pEndRadiui  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   An array of end radius parameters; each can be a number or an
    equation obtained from a parameter. This array should contain a start radius for each
    edge or face in colEdgesAndFaces.

bTangentPropagate  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If the Tangent Propogate option is true, the fillet will
    be created along the selected edge as well as any other edges that form a path
    in which a tangent condition can be resolved.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the fillet feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADFilletFeature  
Returns the new fillet feature.

#### Example

This sample demonstrates creating a Variable Radius Fillet feature and then querying it.

```
Debug.Print "**********Add Variable Radius Fillet feature******************"

Dim objFilletTargets As IObjectCollector
Dim objPartFeatures As IADPartFeatures
Dim objVarFillet As IADFilletFeature
Dim objIADBodies As IADBodies
Dim objIADBody As IADBody
Dim objIADFaces As IADFaces
Dim objSessions As IADSessions
Dim objSession As IADSession
Dim startRad() As Variant
Dim endRad() As Variant
Dim startRadCollection As IObjectCollector
Dim endRadCollection As IObjectCollector
Dim objStartRad As IADParameter
Dim objEndRad As IADParameter
Dim objPartSession As IADPartSession

Set objSessions = m_Alibreobjroot.Sessions
If objSessions.Item(0).SessionType = ADObjectSubType_AD_PART Then
    Set objSession = objSessions.Item(0)
Else
    Debug.Print "This is not a part session."
    Exit Sub
End If

Set objPartSession = objSession
Set objPartFeatures = objPartSession.Features
Set objIADBodies = objPartSession.Bodies
Set objIADBody = objIADBodies.Item(0)
Set objIADFaces = objIADBody.Faces

Set objFilletTargets = m_Alibreobjroot.NewObjectCollector
Call objFilletTargets.Add(objIADBody.Edges.Item(8))
Call objFilletTargets.Add(objIADFaces.Item(1))

ReDim startRad(0 To objFilletTargets.count - 1)
ReDim endRad(0 To objFilletTargets.count - 1)

startRad(0) = 0.7
endRad(0) = 0.5
startRad(1) = 0.8
endRad(1) = 0.4

Set objVarFillet = objPartFeatures.AddVariableRadiusFilletFeature(objFilletTargets, _ 
        startRad, endRad, True, "var Radius fillet from API")
Set startRadCollection = objVarFillet.StartRadiusParams
Set objStartRad = startRadCollection.Item(0)
Set endRadCollection = objVarFillet.EndRadiusParams
Set objEndRad = endRadCollection.Item(0)

Debug.Print "The fillet's start radius is " & objStartRad.Value
Debug.Print "The fillet's end radius is " & objEndRad.Value

Debug.Print "****************************"
```



# IADPartFeature.FeatureType Property

Returns the feature type (extrusion, revolution etc.)

#### Syntax

```
ADPartFeatureType FeatureType { get; }
```

#### Property Value

ADPartFeatureType

#### Remarks

See the help page for ADPartFeatureType
to get a list of possible return values and their corresponding types.



# IADPartFeature.Type Property

Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADSMCornerRoundFeature Methods

The IADSMCornerRoundFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADPartFeature.EdgeColor Property

Sets/Gets the feature Edge Color.

#### Syntax

```
int EdgeColor { get; set; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADThinWallExtrusionFeature Properties

The IADThinWallExtrusionFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADPartFeatures.AddDraftFeature Method

Creates a Draft Feature for given faces corresponding to a given plane or face.

#### Syntax

```
IADDraftFeature AddDraftFeature(
	IObjectCollector draftFaces,
	IADOccurrence toDraftPlaneOcc,
	Object draftNeutralPlane,
	Object draftAngle,
	bool isOutwardDraft,
	string angleParameterName = "",
	string name
)
```

#### Parameters

draftFaces  IObjectCollector
:   A collection of faces which will be
    drafted.

toDraftPlaneOcc  IADOccurrence
:   Denotes an instance of the draftNeutralPlane in
    an assembly. This can be null if the draftNeutralPlane belongs to a part.

draftNeutralPlane  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The neutral plane is the starting point for the draft,
    and the plane or face from which the draft angle is calculated. It can be any
    design plane or planar face
    which intersects with the draft faces.

draftAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the angle parameter; can be a number or an
    equation obtained from a parameter.

isOutwardDraft  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, the face will be drafted in an outward direction,
    expanding the solid.

angleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the angle parameter
    that will be created for the draft feature. If no name is provided, a default name will
    be generated.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the draft feature. If no name is provided, a default name
    will be generated.

#### Return Value

IADDraftFeature  
Returns the new draft feature.



# IADFilletFeature Properties

The IADFilletFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ConstantRadius | Returns the parameter driving the Constant Radius if available. Query IsConstantRadius to determine if this fillet is using a constant radius. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | EdgesOrFaces | Returns the collection of Edges/Faces selected to fillet. |
|  | EndRadiusParams | Returns the collection of End Radius parameters if available. There will be a parameter in this collection for each edge or face in the EdgesOrFaces collection. |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsConstantRadius | Returns true if this fillet is created with a constant radius, available from the property ConstantRadius. Otherwise, the fillet has start and end radii, which can be queried with the StartRadiusParams and EndRadiusParams properties. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | StartRadiusParams | Returns the collection of Start Radius parameters if available. There will be a parameter in this collection for each edge or face in the EdgesOrFaces collection. |
|  | TangentPropagate | Returns whether the Tangent Propagate option was chosen. The Tangent Propagate option creates a fillet on each selected edge as well as any other edges that form a path in which a tangent condition can be resolved. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADMeshBooleanFeature Interface

IAMeshBooleanFeature interface

#### Syntax

```
public interface IADMeshBooleanFeature : IADPartFeature
```

The IADMeshBooleanFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADSweepFeature.EndConditionType Property

Gets the end conditon type.

#### Syntax

```
ADPartFeatureEndCondition EndConditionType { get; }
```

#### Property Value

ADPartFeatureEndCondition

#### Remarks

Possible values are:

- AD\_TO\_GEOMETRY
- AD\_ENTIRE\_PATH



# IADPartFeatures.AddCounterSunkHoleEx Method

Creates a counter sunk Hole feature.

#### Syntax

```
IADHoleFeature AddCounterSunkHoleEx(
	IADSketch pSketch,
	Object depth,
	Object diameter,
	Object counterSinkDiameter,
	Object counterSinkAngle,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = "",
	string diameterParameterName = "",
	string counterSinkDiameterParameterName = "",
	string counterSinkAngleParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

diameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the diameter.

counterSinkDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-sink diameter.

counterSinkAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-sink angle.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

diameterParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the diameter parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

counterSinkDiameterParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the counter sink diameter parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

counterSinkAngleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the counter sink angle parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADScaleFeature.UniformScaleFactor Property

Returns the parameter driving the scale factor if uniform scaling
is used for this feature.

#### Syntax

```
IADParameter UniformScaleFactor { get; }
```

#### Property Value

IADParameter



# IADPartFeatures.AddRevolvedCutout Method

Creates a revolved cut feature using the input sketch that is revolved around a design
axis or a linear edge.

#### Syntax

```
IADRevolutionFeature AddRevolvedCutout(
	IADSketch pSketch,
	IADOccurrence axisOcc,
	Object axisObject,
	Object revolveAngle,
	string name
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch to revolve.

axisOcc  IADOccurrence
:   Denotes an "instance" of a Part or Assembly, to which the given
    pAxis belongs to. For specifying the Axis in a standalone Part, axisOcc
    should be null.

axisObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes an axis or
    edge. If an edge is specified, it must be a linear edge.

revolveAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the rotation angle in radians for creating the
    revolved feature.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the Part Feature created. If there is no name, a default name
    will be created for the newly created Part Feature.

#### Return Value

IADRevolutionFeature  
Returns the new revolution feature.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INVALID\_AXIS | The specified axis object is not valid. |
| AD\_E\_AXIS\_PARALELL\_SKETCH | The axis and the sketch plane must be parallel. |
| AD\_E\_INVALID\_ANGLE | The specified angle is not valid. |

#### Remarks

- This method will throw an exception under the following situations:
  1. If pSketch is already used by any other feature.
- Note that the newly created Part Feature is not added to the Collection on which this
  method is called. Query for the Collection again to get the updated Collection.
- If the created feature has an error, an error is thrown and the feature still remains
  in the features list.

#### Example

This Visual Basic sample demonstrates adding a Revolve Cut Feature to the Part Features Collection.

```
' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session from Session
Set objADPartSession = m_objADSession

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Part Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a sketch on "XY-Plane"
Set objADSketch = objADSketches.AddSketch(Nothing, _
        objADDesignSession.DesignPlanes("XY-Plane"), _
        "NewSketch")

' Initialize Edit Mode
Call objADSketch.BeginChange

' Add a Rectangle to the Sketch Figures
Call objADSketch.Figures.AddRectangle(1, 0, 5, 5)

' Exit Edit Mode
Call objADSketch.EndChange

' Holds Part Features object
Dim objADPartFeatures As AlibreX.IADPartFeatures

' Get Part Features object from Part Session
Set objADPartFeatures = objADPartSession.Features

' Holds Revolved Feature Object
Dim objRevolvedBossFeature As AlibreX.IADRevolutionFeature

' Add an Revolved Boss to the Part Features collection
Set objRevolvedBossFeature = objADPartFeatures.AddRevolvedBoss( _
        objADSketch, _
        Nothing, _
        objADDesignSession.DesignAxes("Y-Axis"), _
        3.14, _
        "NewRevolutionBossFeature")

' Holds Sketch Object
Dim objADSketch1 As AlibreX.IADSketch

' Add a sketch on "XY-Plane"
Set objADSketch1 = objADSketches.AddSketch(Nothing, _
        objADDesignSession.DesignPlanes("XY-Plane"), _
        "NewSketch1")

' Initialize Edit Mode
Call objADSketch1.BeginChange

' Add a Rectangle to the Sketch Figures
Call objADSketch1.Figures.AddRectangle(1.2, 0.2, 4.8, 5)

' Exit Edit Mode
Call objADSketch1.EndChange

' Holds Revolved Feature Object
Dim objRevolvedCutFeature As AlibreX.IADRevolutionFeature

' Add an Revolved Cut to the Part Features collection
Set objRevolvedCutFeature = objADPartFeatures.AddRevolvedCutout( _
        objADSketch1, _
        Nothing, _
        objADDesignSession.DesignAxes("Y-Axis"), _
        3.14, _
        "NewRevolutionCutFeature")
```



# IADRevolutionFeature Interface

This interface represents a Revolution Feature.

#### Syntax

```
public interface IADRevolutionFeature : IADPartFeature
```

The IADRevolutionFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | AngleParameter | Returns the parameter driving the angle of revolution. |
|  | Axis | Gets the target proxy containing the axis of revolution and its occurrence if it has one. The axis can be a design axis or linear edge. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsCutout | Returns True if revolved feature is a cutout. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Sketch | Returns the sketch used to create revolution. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADHoleFeature.Diameter Property

Returns the normal diameter of hole(s).

#### Syntax

```
double Diameter { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADPartFeatures.AddExtrudedBoss Method

Adds an extruded boss feature, which add material by extending a sketch in a
linear direction by a specified distance. It is possible to specify a draft angle to taper
the extrusion. 'To Geometry' can specify any face in an assembly context.
'Along Edge' can specify any edge in assembly context.

#### Syntax

```
IADExtrusionFeature AddExtrudedBoss(
	IADSketch pSketch,
	Object depth,
	ADPartFeatureEndCondition endCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	ADDirectionType direction,
	IADOccurrence pDirectionOcc,
	Object pDirectionObject,
	bool isDirectionReversed,
	Object draftAngle,
	bool IsOutwardDraft,
	string name,
	string depthParameterName = "",
	string angleParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch to extrude.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

endCondition  ADPartFeatureEndCondition
:   Denotes the end condition of the feature to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if endCondition is not AD\_TO\_GEOMETRY
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if endCondition is
    not AD\_TO\_GEOMETRY.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the extrusion up to
    a specified distance from the Target (toGeometryObject).

direction  ADDirectionType
:   Denotes the direction of extrusion.

pDirectionOcc  IADOccurrence
:   Denotes an instance of pDirectionObject in an assembly.
    This can be null if pDirectionObject belongs to a part.

pDirectionObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the direction object along which the extrusion
    will be created. This can be null if direction is AD\_ALONG\_NORMAL.

isDirectionReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the extrusion in a direction
    opposite to normal to the sketch plane.

draftAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   This can be a number or an equation from a parameter. Pass zero,
    or a number to create a tapered extrusion.

IsOutwardDraft  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If this is true, the extrusion will be drafted outwards else
    it will be drafted inwards.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the extruded object. If no name is provided, a default name will
    be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the extrusion feature. If no name is provided, a default name will
    be generated.

angleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the angle parameter
    that will be created for the extrusion feature if a draft angle is present. If no name is
    provided, a default name will be generated.

#### Return Value

IADExtrusionFeature  
Returns the new extrusion feature.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INVALID\_ENDCONDITION | The specified endCondition is not valid for an Extruded Boss feature |
| AD\_E\_ZERO\_DEPTH | If endContion is AD\_TO\_DEPTH, depth's value cannot be zero. |

#### Remarks

- depth - The depth cannot be zero if endCondition is AD\_TO\_DEPTH.
- endCondition - Create the extrusion using the following end condition types:
  1. AD\_TO\_DEPTH - Creates an extrusion of a specified length on one side of the
     sketching plane.
  2. AD\_MID\_PLANE - Creates an extrusion of a specified length on both sides of the
     sketching plane. Half the extrusion length is proportioned to each side of the sketching plane.
  3. AD\_TO\_NEXT - Creates an extrusion to the next available face in the model in
     direction of the extrusion.
  4. AD\_TO\_GEOMETRY - Creates an extrusion up to a specified reference plane or face.
- direction - The direction can be:
  1. AD\_ALONG\_NORMAL - Creates the extrusion normal to the sketch plane.
  2. AD\_ALONG\_AXIS - Creates the extrusion along a Design Axis.
  3. AD\_ALONG\_EDGE - Creates the extrusion along a Design Edge.
- This method will throw an exception under the following situations:
  1. If pSketch is already used by any other feature.
  2. If draftAngle falls outside the range -60 to 60.
  3. If endContion is AD\_TO\_DEPTH and depth's value is zero.
- Note that the newly created Part Feature is not added to the Collection on which this
  method is called. Query for the Collection again to get the updated Collection.
- If the created feature has an error, an error is thrown and the feature still remains
  in the features list.

#### Example

This Visual Basic sample demonstrates adding an Extrude Boss Feature to the Part Features Collection.

```
' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session from Session
Set objADPartSession = m_objADSession

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Part Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a sketch on "XY-Plane"
Set objADSketch = objADSketches.AddSketch(Nothing, _
        objADDesignSession.DesignPlanes("XY-Plane"), _
        "NewSketch")

' Initialize Edit Mode
Call objADSketch.BeginChange

' Add a Circle to the Sketch Figures
Call objADSketch.Figures.AddCircle(0, 0, 5)

' Exit Edit Mode
Call objADSketch.EndChange

' Holds Part Features object
Dim objADPartFeatures As AlibreX.IADPartFeatures

' Get Part Features object from Part Session
Set objADPartFeatures = objADPartSession.Features

' Holds Extrusion Feature Object
Dim objExtrusionBossFeature As AlibreX.IADExtrusionFeature

' Add an Extruded Boss to the Part Features collection
Set objExtrusionBossFeature = objADPartFeatures.AddExtrudedBoss( _
        objADSketch, _
        5, _
        AD_TO_DEPTH, _
        Nothing, _
        Nothing, _
        0, _
        AD_ALONG_NORMAL, _
        Nothing, _
        Nothing, _
        False, _
        0.15, _
        False, _
        "NewExtrusionBossFeature")
```



# IADSweepFeature Interface

This interface represents a Sweep Feature.

#### Syntax

```
public interface IADSweepFeature : IADPartFeature
```

The IADSweepFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DraftParameter | Returns the parameter driving the draft angle if it exists. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | EndCondition | Gets the end condition information. |
|  | EndConditionType | Gets the end conditon type. |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsCutout | Returns True if the sweep feature is a cutout. |
|  | IsOutwardDraft | Gets/sets if the draft is outward or not. |
|  | IsRigid | Gets/sets if rigid mode is used. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Path | Returns the path sketch used to create the sweep feature. |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Sketch | Returns the profile sketch that is swept along a path. |
|  | ToGeometryOffset | Returns the distance of the To Geometry Offset if it exists. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADDeleteLumpsFeature Properties

The IADDeleteLumpsFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADPartFeatures.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADPartFeatures.AddCounterDrilledDrilledHole Method

Creates a drilled counter drilled Hole feature.

#### Syntax

```
IADHoleFeature AddCounterDrilledDrilledHole(
	IADSketch pSketch,
	Object depth,
	Object diameter,
	Object drillAngle,
	Object counterDrillDepth,
	Object counterDrillDiameter,
	Object counterDrillAngle,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

diameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the diameter.

drillAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the angle for the drill end.

counterDrillDepth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-drill depth.

counterDrillDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-drill diameter.

counterDrillAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-drill angle.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADExtrusionFeature.EndCondition Property

Gets the end condition information.

#### Syntax

```
IADTargetProxy EndCondition { get; }
```

#### Property Value

IADTargetProxy



# IADWrapFeature Interface

This interface represents a Wrap feature. Wrap features either create
or remove material.

#### Syntax

```
public interface IADWrapFeature : IADPartFeature
```

The IADWrapFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DepthParameter | Returns the parameter driving the wrap depth. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | FocusType | Gets the focus type. |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsCutout | Returns True if wrap is a cutout. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Sketch | Returns the sketch used to create wrap. |
|  | TargetFace | Gets the target face. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADPartFeatures.AddCounterBoredDrilledHole Method

Creates a drilled counter bored Hole feature.

#### Syntax

```
IADHoleFeature AddCounterBoredDrilledHole(
	IADSketch pSketch,
	Object depth,
	Object diameter,
	Object drillAngle,
	Object counterBoreDepth,
	Object counterBoreDiameter,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

diameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the diameter.

drillAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the angle for the drill end.

counterBoreDepth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-bore depth.

counterBoreDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-bore diameter.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADHelicalFeature Properties

The IADHelicalFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Returns the reference sketch figure used to define the axis of the Helix. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | EndConditionType | Returns the End condition type of the helix. |
|  | EndFlatAngle | Returns the parameter driving the flat angle at the end of the helix, if the end condition is Flat. |
|  | EndTransitionAngle | Returns the parameter driving the transition angle at the end of the helix, if the end condition is Flat. |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | Height | Returns the parameter driving the height of the helix. This parameter is used by helices with HelixType AD\_Height\_Pitch or AD\_Height\_Revolution. |
|  | HelixType | Gets the helix type. This allows you to determine which properties to query to find the definition of the helix. |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsClockwise | Returns true if the rotation direction of the helix is clockwise. |
|  | IsCutout | Returns True if helical feature is a cutout. |
|  | IsParallelOriented | Returns true if the helix's profile is oriented parallel to the Axis; otherwise, it is oriented normal to the helical path. |
|  | IsReverse | Returns true if the helix is reversed. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Pitch | Returns the parameter driving the pitch of the helix. This parameter is used by helices with HelixType AD\_Height\_Pitch, AD\_Revolution\_Pitch or AD\_Spiral. |
|  | PitchEnd | Returns the parameter driving the pitch end of the helix. This parameter will only exist for helices with HelixType AD\_Height\_Pitch or AD\_Revolution\_Pitch and PitchType AD\_VariableEnd. |
|  | PitchRatio | Returns the parameter driving the pitch ratio of the helix. This parameter will only exist for helices with HelixType AD\_Height\_Pitch or AD\_Revolution\_Pitch and PitchType AD\_VariableRatio. |
|  | PitchType | Gets the pitch type of the helix. |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Revolutions | Returns the parameter driving the number of revolutions of the helix. This parameter is used by helices with HelixType AD\_Height\_Revolution, AD\_Revolution\_Pitch or AD\_Spiral. |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Sketch | Returns the sketch used to create the Helical feature. This sketch is the cross section that is swept along the helical path. |
|  | StartConditionType | Returns the Start condition type of the helix. |
|  | StartFlatAngle | Returns the parameter driving the flat angle at the start of the helix, if the start condition is Flat. |
|  | StartTransitionAngle | Returns the parameter driving the transition angle at the start of the helix, if the start condition is Flat. |
|  | Taper | Returns the parameter driving the taper angle of the helix. This parameter does not exist for helices with HelixType AD\_Spiral. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADExtrusionFeature Properties

The IADExtrusionFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DepthParameter | Returns the parameter driving the extrusion depth. |
|  | Direction | Gets the direction proxy with the occurrence and direction object. (edge/Axis) |
|  | DirectionType | Gets the direction type used for creating this extrusion. |
|  | DirectionVector | Gets the direction vector. |
|  | DraftParameter | Returns the parameter driving the draft angle if it exists. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | EndCondition | Gets the end condition information. |
|  | EndConditionType | Gets the end conditon type. |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsCutout | Returns True if extrusion is a cutout. |
|  | IsDirectionReversed | Gets if the direction of the Extrusion is in the opposite direction to the normal to the extruded sketch plane. |
|  | IsOutwardDraft | Gets/sets if draft is outward or not. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Sketch | Returns the sketch used to create extrusion. |
|  | ToGeometryOffset | Returns the distance of the To Geometry Offset if it exists. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADLoftFeature.GuideCurveType Property

Returns a predefined constant indicating the type of the guide curves used for the loft.

#### Syntax

```
ADLoftGuideType GuideCurveType { get; }
```

#### Property Value

ADLoftGuideType



# IADHelicalFeature Interface

This interface represents a Helical Boss or Cut feature. Helical features, often referred to
as helixes, either create or remove material by automatically sweeping a cross section, represented
by a sketch, along a helical path. The helical path is automatically
created by the software and is driven by user specified parameters.

#### Syntax

```
public interface IADHelicalFeature : IADPartFeature
```

The IADHelicalFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Returns the reference sketch figure used to define the axis of the Helix. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | EndConditionType | Returns the End condition type of the helix. |
|  | EndFlatAngle | Returns the parameter driving the flat angle at the end of the helix, if the end condition is Flat. |
|  | EndTransitionAngle | Returns the parameter driving the transition angle at the end of the helix, if the end condition is Flat. |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | Height | Returns the parameter driving the height of the helix. This parameter is used by helices with HelixType AD\_Height\_Pitch or AD\_Height\_Revolution. |
|  | HelixType | Gets the helix type. This allows you to determine which properties to query to find the definition of the helix. |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsClockwise | Returns true if the rotation direction of the helix is clockwise. |
|  | IsCutout | Returns True if helical feature is a cutout. |
|  | IsParallelOriented | Returns true if the helix's profile is oriented parallel to the Axis; otherwise, it is oriented normal to the helical path. |
|  | IsReverse | Returns true if the helix is reversed. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Pitch | Returns the parameter driving the pitch of the helix. This parameter is used by helices with HelixType AD\_Height\_Pitch, AD\_Revolution\_Pitch or AD\_Spiral. |
|  | PitchEnd | Returns the parameter driving the pitch end of the helix. This parameter will only exist for helices with HelixType AD\_Height\_Pitch or AD\_Revolution\_Pitch and PitchType AD\_VariableEnd. |
|  | PitchRatio | Returns the parameter driving the pitch ratio of the helix. This parameter will only exist for helices with HelixType AD\_Height\_Pitch or AD\_Revolution\_Pitch and PitchType AD\_VariableRatio. |
|  | PitchType | Gets the pitch type of the helix. |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Revolutions | Returns the parameter driving the number of revolutions of the helix. This parameter is used by helices with HelixType AD\_Height\_Revolution, AD\_Revolution\_Pitch or AD\_Spiral. |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Sketch | Returns the sketch used to create the Helical feature. This sketch is the cross section that is swept along the helical path. |
|  | StartConditionType | Returns the Start condition type of the helix. |
|  | StartFlatAngle | Returns the parameter driving the flat angle at the start of the helix, if the start condition is Flat. |
|  | StartTransitionAngle | Returns the parameter driving the transition angle at the start of the helix, if the start condition is Flat. |
|  | Taper | Returns the parameter driving the taper angle of the helix. This parameter does not exist for helices with HelixType AD\_Spiral. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Example

This Visual Basic sample demonstrates querying helical features.

```
Debug.Print "***********Query Helix feature*****************"

Dim objIADpartfeatures As IADPartFeatures
Dim objIADPartfeature As IADPartFeature
Dim objHelix As IADHelicalFeature
Dim objsessions As IADSessions
Dim objsession As IADSession
Dim objPartSession As IADPartSession
Dim axis As IADSketchLine
Dim pitch As IADParameter
Dim revolutions As IADParameter
Dim pitchratio As IADParameter
Dim pitchend As IADParameter
Dim taper As IADParameter
Dim startTransitionAngle As IADParameter
Dim endTransitionAngle As IADParameter
Dim startFlatAngle As IADParameter
Dim endFlatAngle As IADParameter
Dim height As IADParameter
Dim startConditiontype As Integer
Dim endConditiontype As Integer

Set objsessions = m_Alibreobjroot.Sessions

If objsessions.Item(0).SessionType = ADObjectSubType_AD_PART Then
    Set objsession = objsessions.Item(0)
Else
    Debug.Print "This is not a part session"
    Exit Sub
End If

Set objPartSession = objsession
Set objIADpartfeatures = objPartSession.Features
If objIADpartfeatures.CurrentFeature.FeatureType = ADPartFeatureType_AD_HELICAL_FEATURE Then
   Set objHelix = objIADpartfeatures.CurrentFeature
Else
    Debug.Print "No Helix Feature found!"
    Exit Sub
End If

If objHelix.HelixType = ADHelixType_AD_Height_Pitch Then
    Debug.Print "The helix type is Height & Pitch"
    Set height = objHelix.height
    Debug.Print " The height is " & height.Value

    Set pitch = objHelix.pitch
    Debug.Print " The pitch is " & pitch.Value

    If objHelix.PitchType = ADPitchType_AD_VariableEnd Then
        Debug.Print "The pitch type is Variable End"
        Set taper = objHelix.taper
        Debug.Print " The taper is " & taper.Value
        Set pitchend = objHelix.pitchend
        Debug.Print " The end pitch is " & pitchend.Value
    ElseIf objHelix.PitchType = ADPitchType_AD_VariableRatio Then
        Debug.Print "The pitch type is Variable Ratio"
        Set taper = objHelix.taper
        Debug.Print " The taper is " & taper.Value
        Set pitchratio = objHelix.pitchratio
        Debug.Print " The pitch ratio is " & pitchratio.Value
    ElseIf objHelix.PitchType = ADPitchType_AD_Constant Then
        Debug.Print "The pitch type is Constant"
        Set taper = objHelix.taper
        Debug.Print " The taper is " & taper.Value
    End If

ElseIf objHelix.HelixType = ADHelixType_AD_Height_Revolution Then

    Debug.Print "The helix type is Height & Revolution"
    Set height = objHelix.height
    Debug.Print " The height is " & height.Value
    Set revolutions = objHelix.revolutions
    Debug.Print " The number of revolutions is " & revolutions.Value

ElseIf objHelix.HelixType = ADHelixType_AD_Revolution_Pitch Then

    Debug.Print "The helix type is Revolution & Pitch"
    Set pitch = objHelix.pitch
    Debug.Print " The pitch is " & pitch.Value
        Set revolutions = objHelix.revolutions
    Debug.Print " The number of revolutions is " & revolutions.Value

    If objHelix.PitchType = ADPitchType_AD_VariableEnd Then

        Debug.Print "The pitch type is Variable End"
        Set taper = objHelix.taper
        Debug.Print " The taper is " & taper.Value
        Set pitchend = objHelix.pitchend
        Debug.Print " The end pitch is " & pitchend.Value

    ElseIf objHelix.PitchType = ADPitchType_AD_VariableRatio Then

        Debug.Print "The pitch type is Variable Ratio"
        Set taper = objHelix.taper
        Debug.Print " The taper is " & taper.Value
        Set pitchratio = objHelix.pitchratio
        Debug.Print " The pitch ratio is " & pitchratio.Value

    ElseIf objHelix.PitchType = ADPitchType_AD_Constant Then

        Debug.Print "The pitch type is Constant"
        Set taper = objHelix.taper
        Debug.Print " The taper is " & taper.Value
    End If

ElseIf objHelix.HelixType = ADHelixType_AD_Spiral Then

    Debug.Print "The helix type is Spiral"
    Set pitch = objHelix.pitch
    Debug.Print " The pitch is " & pitch.Value
    Set revolutions = objHelix.revolutions
    Debug.Print " The number of revolutions is " & revolutions.Value

End If

If objHelix.startConditiontype = ADHelixConditionType_AD_Natural Then
    Debug.Print "The start condition type is natural"
ElseIf objHelix.startConditiontype = ADHelixConditionType_AD_Flat Then
    Debug.Print "The start condition type is flat"
    Set startFlatAngle = objHelix.startFlatAngle
    Set startTransitionAngle = objHelix.startTransitionAngle
    Debug.Print "The start flat angle is " & startFlatAngle.Value
    Debug.Print "The start transition angle is " & startTransitionAngle.Value
End If

If objHelix.endConditiontype = ADHelixConditionType_AD_Natural Then
    Debug.Print "The end condition type is natural"

ElseIf objHelix.endConditiontype = ADHelixConditionType_AD_Flat Then
    Debug.Print "The end condition type is flat"
    Set endFlatAngle = objHelix.endFlatAngle
    Set endTransitionAngle = objHelix.endTransitionAngle
    Debug.Print "The end flat angle is " & endFlatAngle.Value
    Debug.Print "The end transition angle is " & endTransitionAngle.Value
End If

If objHelix.IsParallelOriented = True Then
    Debug.Print " The helix is oriented parallel"
Else
    Debug.Print " The helix is oriented normal"
End If

If objHelix.IsReverse = True Then
    Debug.Print " The direction is reversed"
Else
    Debug.Print " The direction is not reversed"
End If

If objHelix.IsClockwise = True Then
    Debug.Print " The helix is clockwise"
Else
    Debug.Print " The helix is counter-clockwise"
End If

Set axis = objHelix.axis
Debug.Print "Axis Length: " & axis.Length

Debug.Print "Is Cutout: " & objHelix.IsCutout
Debug.Print "****************************"
```



# IADPartFeatures Properties

The IADPartFeatures type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of features in this collection. |
|  | CurrentFeature | Returns/Sets the last active feature. |
|  | CurrentState | Sets/Returns the current active feature. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the parent part session for the collection. |



# IADShellFeature.MultiThicknessFaces Property

Returns the faces with overridden thickness values, if any are present in the feature.

#### Syntax

```
IObjectCollector MultiThicknessFaces { get; }
```

#### Property Value

IObjectCollector



# IADVertexChamferFeature Interface

This interface represents a vertex Chamfer Feature. Vertex Chamfer features create a
beveled face on selected vertices.

#### Syntax

```
public interface IADVertexChamferFeature : IADPartFeature
```

The IADVertexChamferFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Distance1 | Returns the distance which the chamfer will extend along the first edge. |
|  | Distance2 | Returns the distance which the chamfer will extend along the second edge. |
|  | Distance3 | Returns the distance which the chamfer will extend along the third edge. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |
|  | Vertices | Returns the vertices selected to be chamfered. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADHoleFeature.CounterBoreDepth Property

Returns the counter bore depth of hole(s).

#### Syntax

```
double CounterBoreDepth { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

Valid only for holes with the following
HoleTypes:

- AD\_COUNTER\_BORED\_HOLE
- AD\_COUNTER\_BORED\_DRILLED\_HOLE



# IADProjectFeature Properties

The IADProjectFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DepthParameter | Returns the parameter driving the project depth. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsCutout | Returns True if project is a cutout. |
|  | IsIntoSketchPlane | Gets if project direction is into sketch plane. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Sketch | Returns the sketch used to create project. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADChamferFeature.Distance2 Property

Returns the parameter driving the chamfer distance 2 if it exists.

#### Syntax

```
IADParameter Distance2 { get; }
```

#### Property Value

IADParameter

#### Remarks

Only Chamfer Features created using the Distance-Distance option
will have this parameter.



# IADSMUnbendFeature Interface

IADSMUnbendFeature interface

#### Syntax

```
public interface IADSMUnbendFeature : IADPartFeature
```

The IADSMUnbendFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future
expansion of the API, to include information about Unbend features. For general
information about a feature, use the IADPartFeature interface.



# IADRevolutionFeature Methods

The IADRevolutionFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADPartFeatures.AddEdgeChamferFeature Method

Creates an Edge Chamfer Feature by chamfering the given Edges and Faces.

#### Syntax

```
IADChamferFeature AddEdgeChamferFeature(
	IObjectCollector colEdgesAndFaces,
	ADEdgeChamferType chamferType,
	Object chamferDistance1,
	Object chamferDistance2,
	Object chamferAngle,
	bool tangentPropagate,
	string dist1ParameterName,
	string dist2ParameterName,
	string chamferAngleParameterName,
	string name
)
```

#### Parameters

colEdgesAndFaces  IObjectCollector
:   A collection of edges and
    faces to which the chamfer will be applied.

chamferType  ADEdgeChamferType
:   The chamfer type determines what parameters will be used
    to create the chamfer. Distance-Distance,
    Angle-Distance, and
    Equal distance are available.

chamferDistance1  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the first distance parameter; can be a number or an
    equation obtained from a parameter. This parameter is required for all chamfer types.

chamferDistance2  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the second distance parameter; can be a number or an
    equation obtained from a parameter. This parameter is required for the chamfer type
    AD\_DISTANCE\_TO\_DISTANCE; other chamfer types may pass a null value.

chamferAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the angle parameter; can be a number or an
    equation obtained from a parameter. This parameter is required for the chamfer type
    AD\_ANGLE\_DISTANCE; other chamfer types may pass a null value.

tangentPropagate  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If the Tangent Propogate option is true, the chamfer will
    be created along the selected edge as well as any other edges that form a path
    in which a tangent condition can be resolved.

dist1ParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the first distance parameter
    that will be created for the chamfer feature. If no name is provided, a default name will
    be generated.

dist2ParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the second distance parameter
    that will be created for the chamfer feature. If no name is provided, a default name will
    be generated. Only used for AD\_DISTANCE\_TO\_DISTANCE chamfer types.

chamferAngleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the angle parameter
    that will be created for the chamfer feature. If no name is provided, a default name will
    be generated. Only used for AD\_ANGLE\_DISTANCE chamfer types.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the chamfer feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADChamferFeature  
Returns the new edge chamfer feature.



# IADPartFeature.Delete Method

Removes the feature from the design.

#### Syntax

```
void Delete()
```

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_CANNOT\_DELETE\_FEATURE | This feature currently cannot be deleted. |



# IADPartFeatures.AddCounterBoredHoleEx Method

Creates a counter bored Hole feature.

#### Syntax

```
IADHoleFeature AddCounterBoredHoleEx(
	IADSketch pSketch,
	Object depth,
	Object diameter,
	Object counterBoreDepth,
	Object counterBoreDiameter,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = "",
	string diameterParameterName = "",
	string counterBoreDepthParameterName = "",
	string counterBoreDiameterParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

diameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the diameter.

counterBoreDepth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-bore depth.

counterBoreDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-bore diameter.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

diameterParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the diameter parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

counterBoreDepthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the counter bore depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

counterBoreDiameterParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the coutner bore diameter parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADDeleteLumpsFeature Interface

IADDeleteLumpsFeature interface

#### Syntax

```
public interface IADDeleteLumpsFeature : IADPartFeature
```

The IADDeleteLumpsFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADMeshBooleanFeature Properties

The IADMeshBooleanFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADExternalThreadFeature.Callout Property

Returns a plain text string containing the callout for the external thread feature.

#### Syntax

```
string Callout { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)

#### Remarks

If the callout contained one of the special Symbols it will be changed to a regular character.
Use the CalloutRTF property to get the rich text string if needed.



# IADPartFeatures Interface

IADPartFeatures interface

#### Syntax

```
public interface IADPartFeatures
```

The IADPartFeatures type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of features in this collection. |
|  | CurrentFeature | Returns/Sets the last active feature. |
|  | CurrentState | Sets/Returns the current active feature. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the parent part session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddConstantRadiusFilletFeature | Creates a fillet feature on the given Edges and/or Faces with the given constant radius. |
|  | AddCounterBoredDrilledHole | Creates a drilled counter bored Hole feature. |
|  | AddCounterBoredDrilledHoleEx | Creates a drilled counter bored Hole feature. |
|  | AddCounterBoredHole | Creates a counter bored Hole feature. |
|  | AddCounterBoredHoleEx | Creates a counter bored Hole feature. |
|  | AddCounterDrilledDrilledHole | Creates a drilled counter drilled Hole feature. |
|  | AddCounterDrilledDrilledHoleEx | Creates a drilled counter drilled Hole feature. |
|  | AddCounterDrilledHole | Creates a counter drilled Hole feature. |
|  | AddCounterDrilledHoleEx | Creates a counter drilled Hole feature. |
|  | AddCounterSunkDrilledHole | Creates a drilled counter sunk Hole feature. |
|  | AddCounterSunkDrilledHoleEx | Creates a drilled counter sunk Hole feature. |
|  | AddCounterSunkHole | Creates a counter sunk Hole feature. |
|  | AddCounterSunkHoleEx | Creates a counter sunk Hole feature. |
|  | AddDraftFeature | Creates a Draft Feature for given faces corresponding to a given plane or face. |
|  | AddDrilledHole | Creates a drilled simple Hole feature. |
|  | AddDrilledHoleEx | Creates a drilled simple Hole feature. |
|  | AddEdgeChamferFeature | Creates an Edge Chamfer Feature by chamfering the given Edges and Faces. |
|  | AddExtrudedBoss | Adds an extruded boss feature, which add material by extending a sketch in a linear direction by a specified distance. It is possible to specify a draft angle to taper the extrusion. 'To Geometry' can specify any face in an assembly context. 'Along Edge' can specify any edge in assembly context. |
|  | AddExtrudedCutout | Adds an extruded cut feature, which removes material by extending a sketch in a linear direction by a specified distance. It is possible to specify a draft angle to taper the extrusion. 'To Geometry' can specify any face in an assembly context. 'Along Edge' can specify any edge in assembly context. |
|  | AddLoftBoss | Creates Loft Boss feature. |
|  | AddLoftCut | Creates Loft Cut feature. |
|  | AddMeshBooleanFeature | Creates a mesh boolean feature. |
|  | AddOffsetFaceFeature | Creates an offset face feature. |
|  | AddProject | Creates a project feature using the input sketch. |
|  | AddRevolvedBoss | Creates a revolved boss feature using the input sketch that is revolved around a design axis or a linear edge. |
|  | AddRevolvedCutout | Creates a revolved cut feature using the input sketch that is revolved around a design axis or a linear edge. |
|  | AddScaleFeature | The scale feature is used to transform the entire part as required. |
|  | AddShellFeature | Creates Shell Feature, which hollows out the body of a solid model. When shelling, the entire part is shelled, not just a feature of it. |
|  | AddSimpleHole | Creates a simple Hole feature. |
|  | AddSimpleHoleEx | Creates a simple Hole feature. |
|  | AddSweptBoss | Creates a sweep boss feature, which creates material by moving a sketch along a path defined by a second sketch. |
|  | AddSweptCutout | Creates a sweep cut feature, which removes material by moving a sketch along a path defined by a second sketch. |
|  | AddTaperedDrilledHole | Creates a drilled tapered Hole feature. |
|  | AddTaperedDrilledHoleEx | Creates a drilled tapered Hole feature. |
|  | AddTaperedHole | Creates a tapered Hole feature. |
|  | AddTaperedHoleEx | Creates a tapered Hole feature. |
|  | AddVariableRadiusFilletFeature | Creates a fillet feature on the given Edges and/or Faces with the given variable radius. Note that no. of Start/End Radii should match the number of Edges and Faces in the given colEdgesAndFaces. |
|  | AddVertexChamferFeature | Creates a Vertex Chamfer feature by chamfering a specified distance along each of the edges which meet at the vertex. |
|  | AddWrap | Creates a wrap feature using the input sketch and target face. |
|  | CreateTappedThreadInfo | Returns IADTappedThreadInfo containing the Tapped Thread information to be used for Hole feature creation. |
|  | Item | Given a numerical index/name into the collection, returns the corresponding part feature. |



# IADWrapFeature.FocusType Property

Gets the focus type.

#### Syntax

```
ADWrapFocusType FocusType { get; }
```

#### Property Value

ADWrapFocusType



# IADLoftFeature.GetTangentMagnitude Method

Returns the magnitude of the tangent for the input cross section of the loft feature.

#### Syntax

```
double GetTangentMagnitude(
	Object crossSection
)
```

#### Parameters

crossSection  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The cross section of this loft feature to check. This can
    be an IADSketch, IADFace, or IADDesignPoint that is in this loft feature's
    CrossSections property or the numerical index of the cross section.

#### Return Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADPartFeatures.AddOffsetFaceFeature Method

Creates an offset face feature.

#### Syntax

```
IADOffsetFaceFeature AddOffsetFaceFeature(
	IObjectCollector pFaces,
	Object vOffset,
	string name,
	string strOffsetParameterName
)
```

#### Parameters

pFaces  IObjectCollector
:   A collection of faces which will be offset.

vOffset  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the offset distance parameter; can be a number or an
    equation obtained from a parameter.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the offset face feature. If no name is provided, a default name
    will be generated.

strOffsetParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the offset parameter
    that will be created for the offset face feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADOffsetFaceFeature  
Returns the new Offset Face feature.

#### Example

This sample demonstrates creating an Offset Face feature and then querying it.

```
Debug.Print "***********Add Offset Face feature *****************"

Dim objObject As Object
Dim objIObjectCollector As IObjectCollector
Dim objIADpartfeatures As IADPartFeatures
Dim objIADoffsetface As IADOffsetFaceFeature
Dim objIADBodies As IADBodies
Dim objIADBody As IADBody
Dim objIADFaces As IADFaces
Dim objIADFace As IADFace
Dim objsessions As IADSessions
Dim objsession As IADSession
Dim objParameter As IADParameter
Dim objFaces As IObjectCollector
Dim objPartSession As IADPartSession

' For this sample, it is assumed that there is an open part with solid features present.
Set objsessions = m_Alibreobjroot.Sessions
If objsessions.Item(0).SessionType = ADObjectSubType_AD_PART Then
    Set objsession = objsessions.Item(0)
Else
    Debug.Print "This is not a part session"
    Exit Sub
End If

Set objPartSession = objsession
Set objIADpartfeatures = objPartSession.Features
Set objIADBodies = objPartSession.Bodies
Set objIADBody = objIADBodies.Item(0)
Set objIADFaces = objIADBody.Faces

' Get the first face, which will be used for the offset face feature.
Set objIObjectCollector = m_Alibreobjroot.NewObjectCollector
Set objIADFace = objIADFaces.Item(0)
Set objObject = objIADFace
Call objIObjectCollector.Add(objObject)

' Create the offset face feature
Set objIADoffsetface = objIADpartfeatures.AddOffsetFaceFeature(objIObjectCollector, 2, "Offset Feature From API", "OffsetDistance")

' Querying the new feature
Set objFaces = objIADoffsetface.OffsetFaces
Set objIADFace = objFaces.Item(0)
Set objParameter = objIADoffsetface.OffsetParameter

Debug.Print "The count of offset faces is " & objFaces.count
Debug.Print "The topology type of the face is " & objIADFace.TopologyType
Debug.Print "The offset value is " & objParameter.Value

Debug.Print "****************************"
```



# IADOffsetFaceFeature Properties

The IADOffsetFaceFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | OffsetFaces | Returns the faces selected to offset if available. |
|  | OffsetParameter | Returns the parameter driving the offset distance. |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADHelicalFeature.PitchEnd Property

Returns the parameter driving the pitch end of the helix. This parameter will only exist
for helices with HelixType AD\_Height\_Pitch or AD\_Revolution\_Pitch and PitchType AD\_VariableEnd.

#### Syntax

```
IADParameter PitchEnd { get; }
```

#### Property Value

IADParameter



# IADHoleFeature.DepthConditionType Property

Returns the type of the depth condition for hole(s), e.g.
"Through All"

#### Syntax

```
ADHoleDepthCondition DepthConditionType { get; }
```

#### Property Value

ADHoleDepthCondition



# IADHelicalFeature.EndFlatAngle Property

Returns the parameter driving the flat angle at the end of the helix, if the
end condition is
Flat.

#### Syntax

```
IADParameter EndFlatAngle { get; }
```

#### Property Value

IADParameter



# IADAssemblyFeatures.GetEnumerator Method

Returns an enumerator for the collection.

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADAssemblyFeature Properties

The IADAssemblyFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FeatureType | Returns the feature type (extrusion, hole etc.) |
|  | Name | Returns the name of this design feature. |
|  | Root | Returns the automation root object. |
|  | Session | Returns the session to which this feature belongs. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_FEATURE) |



# IADPartFeatures.AddTaperedDrilledHole Method

Creates a drilled tapered Hole feature.

#### Syntax

```
IADHoleFeature AddTaperedDrilledHole(
	IADSketch pSketch,
	Object depth,
	Object majorDiameter,
	Object minorDiameter,
	Object drillAngle,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

majorDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the major diameter.

minorDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the minor diameter.

drillAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the angle for the drill end.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADSMClosedCornerFeature Properties

The IADSMClosedCornerFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADHelicalFeature.Sketch Property

Returns the sketch used to create the Helical feature. This sketch is the cross section that
is swept along the helical path.

#### Syntax

```
IADSketch Sketch { get; }
```

#### Property Value

IADSketch



# IADHoleFeature.StartPoints Property

Returns the collection of IADPoint for starting points for all the holes in this feature.

#### Syntax

```
Array StartPoints { get; }
```

#### Property Value

[Array](https://learn.microsoft.com/dotnet/api/system.array)

#### Remarks

These starting points are on the start plane.



# IADDesignBooleanFeature Properties

The IADDesignBooleanFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADMoveFaceFeature Methods

The IADMoveFaceFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADExternalThreadFeature.ThreadLength Property

The IADParameter which defines the thread length of this external thread feature.

#### Syntax

```
IADParameter ThreadLength { get; }
```

#### Property Value

IADParameter



# IADThickenSurfaceFeature Methods

The IADThickenSurfaceFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADTappedThreadInfo.ThreadType Property

Returns the thread type. This is also known as the Series of the thread.

#### Syntax

```
ADTappedThreadType ThreadType { get; }
```

#### Property Value

ADTappedThreadType



# IADPartFeatures.CurrentFeature Property

Returns/Sets the last active feature.

#### Syntax

```
IADPartFeature CurrentFeature { get; set; }
```

#### Property Value

IADPartFeature

#### Remarks

Returns the last active feature if the current feature is Part Feature type
(i.e. not reference geometry or a sketch), else returns the last active Part Feature
from the features collection.



# IADExtrusionFeature.DraftParameter Property

Returns the parameter driving the draft angle if it exists.

#### Syntax

```
IADParameter DraftParameter { get; }
```

#### Property Value

IADParameter



# IADThickenSurfaceFeature Properties

The IADThickenSurfaceFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADPartFeature Properties

The IADPartFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color. |
|  | FaceColor | Sets/Gets the feature Face Color. |
|  | Faces | Returns all the faces that comprise this feature. |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.) |
|  | HasError | Returns True if error was encountered in computing the feature. |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature. |
|  | IsSuppressed | Gets/Sets the suppression state of this feature. |
|  | Name | Sets/Returns the name of this part feature. |
|  | Opacity | Sets/Gets the feature Opacity. |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity. |
|  | Root | Returns the automation root object. |
|  | Session | Returns the session to which this feature belongs. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE) |
|  | UsePartColor | Use the default part color or not. |



# IADHoleFeature.DrillAngle Property

Returns the drill angle of hole(s).

#### Syntax

```
double DrillAngle { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

Valid only for holes with the following
HoleTypes:

- AD\_SIMPLE\_DRILLED\_HOLE
- AD\_TAPERED\_DRILLED\_HOLE
- AD\_COUNTER\_SUNK\_DRILLED\_HOLE
- AD\_COUNTER\_BORED\_DRILLED\_HOLE
- AD\_COUNTER\_DRILLED\_DRILLED\_HOLE



# IADFilletFeature Methods

The IADFilletFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADSMRebendFeature Interface

IADSMRebendFeature interface

#### Syntax

```
public interface IADSMRebendFeature : IADPartFeature
```

The IADSMRebendFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future
expansion of the API, to include information about Rebend features. For general
information about a feature, use the IADPartFeature interface.



# IADPartFeature.IsActive Property

Gets whether the part feature is active. A value of 'true' indicates that the part feature is
visible. ie. Neither suppressed nor below the rollback bar in the design explorer.

#### Syntax

```
bool IsActive { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADAssemblyFeature Interface

IADAssemblyFeature interface

#### Syntax

```
public interface IADAssemblyFeature
```

The IADAssemblyFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FeatureType | Returns the feature type (extrusion, hole etc.) |
|  | Name | Returns the name of this design feature. |
|  | Root | Returns the automation root object. |
|  | Session | Returns the session to which this feature belongs. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_FEATURE) |



# IADSMRebendFeature Properties

The IADSMRebendFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADPatternFeature Properties

The IADPatternFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADExternalThreadFeature Properties

The IADExternalThreadFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Callout | Returns a plain text string containing the callout for the external thread feature. |
|  | CalloutRTF | Returns a rich text format string containing the callout for the external thread feature. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasEdgeChamfer | Returns true if the external thread feature is creating a chamfer on the circular edge. |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | MajorDiameter | The major diameter of the external thread feature. |
|  | MinorDiameter | The IADParameter which defines the minor diameter of this external thread feature. |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | ThreadLength | The IADParameter which defines the thread length of this external thread feature. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADShellFeature.RemovedFaces Property

Returns the faces selected for removal if available.

#### Syntax

```
IObjectCollector RemovedFaces { get; }
```

#### Property Value

IObjectCollector



# IADPartFeatures.AddProject Method

Creates a project feature using the input sketch.

#### Syntax

```
IADProjectFeature AddProject(
	IADSketch pSketch,
	Object depth,
	ADBooleanOperator BooleanOperator,
	bool IsIntoSketchPlane,
	string name
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch to project.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the project depth.

BooleanOperator  ADBooleanOperator
:   Indicates if the feature adds or removes material.

IsIntoSketchPlane  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Indicates the direction of the project.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the Part Feature created. If there is no name, a default name
    will be created for the newly created Part Feature.

#### Return Value

IADProjectFeature  
Returns the new project feature.

#### Remarks

- This method will throw an exception under the following situations:
  1. If pSketch is already used by any other feature.
- Note that the newly created Part Feature is not added to the Collection on which this
  method is called. Query for the Collection again to get the updated Collection.
- If the created feature has an error, an error is thrown and the feature still remains
  in the features list.



# IADPartFeatures.AddCounterBoredDrilledHoleEx Method

Creates a drilled counter bored Hole feature.

#### Syntax

```
IADHoleFeature AddCounterBoredDrilledHoleEx(
	IADSketch pSketch,
	Object depth,
	Object diameter,
	Object drillAngle,
	Object counterBoreDepth,
	Object counterBoreDiameter,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = "",
	string diameterParameterName = "",
	string drillAngleParameterName = "",
	string counterBoreDepthParameterName = "",
	string counterBoreDiameterParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

diameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the diameter.

drillAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the angle for the drill end.

counterBoreDepth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-bore depth.

counterBoreDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-bore diameter.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

diameterParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the diameter parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

drillAngleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the drill angle parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

counterBoreDepthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the counter bore depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

counterBoreDiameterParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the coutner bore diameter parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADFilletFeature.TangentPropagate Property

Returns whether the Tangent Propagate option was chosen. The Tangent Propagate option creates a
fillet on each selected edge as well as any other edges that form a path in which a tangent
condition can be resolved.

#### Syntax

```
bool TangentPropagate { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADHelicalFeature.HelixType Property

Gets the helix type. This allows you to determine which properties to query to find the
definition of the helix.

#### Syntax

```
ADHelixType HelixType { get; }
```

#### Property Value

ADHelixType



# IADFilletFeature.IsConstantRadius Property

Returns true if this fillet is created with a constant radius, available from the
property ConstantRadius.
Otherwise, the fillet has start and end radii, which can be queried with the
StartRadiusParams and
EndRadiusParams properties.

#### Syntax

```
bool IsConstantRadius { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADAssemblyHoleFeature Properties

The IADAssemblyHoleFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FeatureType | Returns the feature type (extrusion, hole etc.)  (Inherited from IADAssemblyFeature) |
|  | Name | Returns the name of this design feature.  (Inherited from IADAssemblyFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADAssemblyFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADAssemblyFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_FEATURE)  (Inherited from IADAssemblyFeature) |



# IADHoleFeature.HasThread Property

Returns true if the hole feature has threads. If it does, you can get that
information using the TappedThread
property.

#### Syntax

```
bool HasThread { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADExternalThreadFeature Interface

This interface represents an External Thread feature. External Thread features create
a basic representation of a thread on an existing cylindrical solid model.

#### Syntax

```
public interface IADExternalThreadFeature : IADPartFeature
```

The IADExternalThreadFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Callout | Returns a plain text string containing the callout for the external thread feature. |
|  | CalloutRTF | Returns a rich text format string containing the callout for the external thread feature. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasEdgeChamfer | Returns true if the external thread feature is creating a chamfer on the circular edge. |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | MajorDiameter | The major diameter of the external thread feature. |
|  | MinorDiameter | The IADParameter which defines the minor diameter of this external thread feature. |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | ThreadLength | The IADParameter which defines the thread length of this external thread feature. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADAssemblyFeatures Properties

The IADAssemblyFeatures type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of features in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the parent assembly session for the collection. |



# IADPartFeatures.AddScaleFeature Method

The scale feature is used to transform the entire part as required.

#### Syntax

```
IADScaleFeature AddScaleFeature(
	bool scaleAboutCenteroid,
	bool uniformScaling,
	Object uniformScaleFactor,
	Object scaleFactorX,
	Object scaleFactorY,
	Object scaleFactorZ,
	string uniformScaleParamName,
	string scaleFactorXParameterName,
	string scaleFactorYParameterName,
	string scaleFactorZParameterName,
	string name
)
```

#### Parameters

scaleAboutCenteroid  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If this parameter is true, the scale will be performed
    about the center of the solid body of the part. If it is false, the center point of
    the scale will be the Origin.

uniformScaling  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   To scale a uniform distance in the X, Y, and Z directions, set
    this parameter to true.

uniformScaleFactor  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the uniform scale factor parameter; can be a number
    or an equation obtained from a parameter. If uniformScaling is true, this parameter
    is required; otherwise, a null value may be passed for this parameter.

scaleFactorX  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the scale factor parameter for the X direction; can be a
    number or an equation obtained from a parameter. If uniformScaling is false, this
    parameter is required; otherwise, a null value may be passed for this parameter.

scaleFactorY  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the scale factor parameter for the Y direction; can be a
    number or an equation obtained from a parameter. If uniformScaling is false, this
    parameter is required; otherwise, a null value may be passed for this parameter.

scaleFactorZ  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the scale factor parameter for the Z direction; can be a
    number or an equation obtained from a parameter. If uniformScaling is false, this
    parameter is required; otherwise, a null value may be passed for this parameter.

uniformScaleParamName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the uniform scale factor
    parameter that will be created for the scale feature.
    If no name is provided, a default name will be generated. If uniformScaling is false,
    this parameter is unused.

scaleFactorXParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the X-direction scale factor
    parameter that will be created for the scale feature.
    If no name is provided, a default name will be generated. If uniformScaling is true,
    this parameter is unused.

scaleFactorYParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the Y-direction scale factor
    parameter that will be created for the scale feature.
    If no name is provided, a default name will be generated. If uniformScaling is true,
    this parameter is unused.

scaleFactorZParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the Z-direction scale factor
    parameter that will be created for the scale feature.
    If no name is provided, a default name will be generated. If uniformScaling is true,
    this parameter is unused.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the scale feature. If no name is provided, a default name
    will be generated.

#### Return Value

IADScaleFeature  
Returns the new Offset Face feature.

#### Example

This sample demonstrates creating a uniform and non-uniform Scale features.

```
Dim objPartFeatures As IADPartFeatures
Dim objScaleFeature As IADScaleFeature
Dim objSessions As IADSessions
Dim objSession As IADSession
Dim objPartSession As IADPartSession
Dim uniformparam As IADParameter
Dim uniformScaleX As IADParameter
Dim uniformScaleY As IADParameter
Dim uniformScaleZ As IADParameter

Set objSessions = m_Alibreobjroot.Sessions
If objSessions.Item(0).SessionType = ADObjectSubType_AD_PART Then
    Set objSession = objSessions.Item(0)
Else
    Debug.Print "This is not a part session."
    Exit Sub
End If

Set objPartSession = objSession
Set objPartFeatures = objPartSession.Features
' Create a scale feature which doubles the size in the Y-direction
Set objScaleFeature = objPartFeatures.AddScaleFeature(False, False, Nothing, 1, 2, 1, _
        "", "xScaleParam", "yScaleParam", "zScaleParam", "Scale feature from API")

' Query the new scale feature
If objScaleFeature.ScaleAboutCenteroid = True Then
    Debug.Print "The scale is performed about the centroid."
Else
    Debug.Print "The scale is performed about the origin."
End If

If objScaleFeature.IsUniformScaling = True Then
    Debug.Print "The scaling is uniform"
    Set uniformparam = objScaleFeature.UniformScaleFactor
    Debug.Print "The uniform scale factor is " & uniformparam.Value
Else
    Set uniformScaleX = objScaleFeature.UniformScaleFactorX
    Set uniformScaleY = objScaleFeature.UniformScaleFactorY
    Set uniformScaleZ = objScaleFeature.UniformScaleFactorZ
    Debug.Print "The scale factor in the X-direction is " & uniformScaleX.Value
    Debug.Print "The scale factor in the Y-direction is " & uniformScaleY.Value
    Debug.Print "The scale factor in the Z-direction is " & uniformScaleZ.Value
End If

Set objScaleFeature = Nothing
' Create another scale feature which uniformly increases the size by 50%
Set objScaleFeature = objPartFeatures.AddScaleFeature(True, True, 1.5, Nothing, Nothing, _
    Nothing, "uScaleParam", "", "", "", "Scale2")

' Query the new scale feature
If objScaleFeature.ScaleAboutCenteroid = True Then
    Debug.Print "The scale is performed about the centroid"
Else
    Debug.Print "The scale is performed about the origin"
End If

If objScaleFeature.IsUniformScaling = True Then
    Debug.Print "The scaling is uniform"
    Set uniformparam = objScaleFeature.UniformScaleFactor
    Debug.Print "The uniform scale factor is " & uniformparam.Value
Else
    Set uniformScaleX = objScaleFeature.UniformScaleFactorX
    Set uniformScaleY = objScaleFeature.UniformScaleFactorY
    Set uniformScaleZ = objScaleFeature.UniformScaleFactorZ
    Debug.Print "The scale factor in the X-direction is " & uniformScaleX.Value
    Debug.Print "The scale factor in the Y-direction is " & uniformScaleY.Value
    Debug.Print "The scale factor in the Z-direction is " & uniformScaleZ.Value
End If

Debug.Print "****************************"
```



# IADSMClosedCornerFeature Methods

The IADSMClosedCornerFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADHoleFeature Interface

This interface represents a Hole feature. Hole features are created by removing
material to create one or more holes. A large number of parameters are available
for specifying the details of the hole. The hole's thread information can be
used in its callout in 2D Drawings.

#### Syntax

```
public interface IADHoleFeature : IADPartFeature
```

The IADHoleFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CounterBoreDepth | Returns the counter bore depth of hole(s). |
|  | CounterBoreDiameter | Returns the counter bore diameter of hole(s). |
|  | CounterDrillAngle | Returns the counter drill angle of hole(s). |
|  | CounterDrillDepth | Returns the counter drill depth of hole(s). |
|  | CounterDrillDiameter | Returns the counter drill diameter of hole(s). |
|  | CounterSinkAngle | Returns the counter sink angle of hole(s). |
|  | CounterSinkDiameter | Returns the counter sink diameter of hole(s). |
|  | Depth | Returns the blind depth of hole(s). Valid only for holes with a DepthConditionType of AD\_HOLE\_TO\_DEPTH. |
|  | DepthConditionType | Returns the type of the depth condition for hole(s), e.g. "Through All" |
|  | Diameter | Returns the normal diameter of hole(s). |
|  | DrillAngle | Returns the drill angle of hole(s). |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | HasThread | Returns true if the hole feature has threads. If it does, you can get that information using the TappedThread property. |
|  | HoleType | Returns the type of hole(s), e.g. "Counter Bored Hole". |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | LimitingGeometry | Returns the limiting face for holes with a DepthConditionType of AD\_HOLE\_TO\_OFFSET\_FACE. |
|  | MajorDiameter | Returns the major diameter of hole(s). |
|  | MinorDiameter | Returns the minor diameter of hole(s). |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | NumberOfHoles | Returns total number of holes in this feature. |
|  | OffsetFromLimitingGeometry | Returns the offset distance from limiting face for holes with a DepthConditionType of AD\_HOLE\_TO\_OFFSET\_FACE. |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Sketch | Returns the sketch used to create the hole(s). The Nodes in the sketch are the locations where holes are placed. |
|  | StartPlane | Returns the starting plane for all holes in this feature. |
|  | StartPoints | Returns the collection of IADPoint for starting points for all the holes in this feature. |
|  | TappedThread | Returns an IADTappedThreadInfo object containing the hole’s thread information if the hole feature has threads. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADChamferFeature.EdgesAndFaces Property

Returns the collection of Chamfered Edges and Faces.

#### Syntax

```
IObjectCollector EdgesAndFaces { get; }
```

#### Property Value

IObjectCollector

#### Remarks

For faces in the collection, all the edges adjoining the face are chamfered.
Note that any Edge/Face consumed by either this feature or any other
subsequent feature operation will not be available.



# IADPartFeatures.AddCounterDrilledDrilledHoleEx Method

Creates a drilled counter drilled Hole feature.

#### Syntax

```
IADHoleFeature AddCounterDrilledDrilledHoleEx(
	IADSketch pSketch,
	Object depth,
	Object diameter,
	Object drillAngle,
	Object counterDrillDepth,
	Object counterDrillDiameter,
	Object counterDrillAngle,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = "",
	string diameterParameterName = "",
	string drillAngleParameterName = "",
	string counterDrillDepthParameterName = "",
	string counterDrillDiameterParameterName = "",
	string counterDrillAngleParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

diameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the diameter.

drillAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the angle for the drill end.

counterDrillDepth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-drill depth.

counterDrillDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-drill diameter.

counterDrillAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-drill angle.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

diameterParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the diameter parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

drillAngleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the drill angle parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

counterDrillDepthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the counter drill depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

counterDrillDiameterParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the counter drill diameter parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

counterDrillAngleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the counter drill angle parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADShellFeature.MultiThicknesses Property

Returns an array the thicknesses of Multi-Thickness faces. The values in this array
correspond to the faces in the MultiThicknessFaces property, and override the
standard thickness for those faces.

#### Syntax

```
Array MultiThicknesses { get; }
```

#### Property Value

[Array](https://learn.microsoft.com/dotnet/api/system.array)



# IADExtrusionFeature.DirectionType Property

Gets the direction type used for creating this extrusion.

#### Syntax

```
ADDirectionType DirectionType { get; }
```

#### Property Value

ADDirectionType



# IADVertexChamferFeature Methods

The IADVertexChamferFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADSMCornerChamferFeature Interface

IADSMCornerChamferFeature interface

#### Syntax

```
public interface IADSMCornerChamferFeature : IADPartFeature
```

The IADSMCornerChamferFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future
expansion of the API, to include information about Corner Chamfer features. For general
information about a feature, use the IADPartFeature interface.



# IADPartFeatures.AddCounterBoredHole Method

Creates a counter bored Hole feature.

#### Syntax

```
IADHoleFeature AddCounterBoredHole(
	IADSketch pSketch,
	Object depth,
	Object diameter,
	Object counterBoreDepth,
	Object counterBoreDiameter,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

diameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the diameter.

counterBoreDepth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-bore depth.

counterBoreDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-bore diameter.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADDraftFeature Interface

This interface represents a Draft Feature. Draft Features create or remove
material from a solid body by rotating faces outward or inward, respectively.

#### Syntax

```
public interface IADDraftFeature : IADPartFeature
```

The IADDraftFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DraftAngleParameter | Returns the angle parameter of how much a given face or faces must be drafted. |
|  | DraftFaces | Returns the faces used for drafting. |
|  | DraftNeutralPlane | Returns the draft neutral plane. The neutral plane is the starting point for the draft, and the plane or face from which the draft angle is calculated. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsOutwardDraft | Returns True if the direction of the draft is outward; otherwise, it is inward. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADPartFeature.GetExtents Method

Returns lower left and upper right corners of a 3D box enclosing the feature.

#### Syntax

```
void GetExtents(
	out IADPoint ppLower,
	out IADPoint ppUpper
)
```

#### Parameters

ppLower  IADPoint
:   The lower left back corner of the extents.

ppUpper  IADPoint
:   The upper right front corner of the extents.

#### Remarks

Y-Axis is vertical.
Low, left, back corners have lower Y,X,Z coordinates respectively.

#### Example

This Visual Basic sample shows how to call the GetExtents method.

```
' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session from Session
Set objADPartSession = m_objADSession

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Part Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a sketch on "XY-Plane"
Set objADSketch = objADSketches.AddSketch(Nothing, _
        objADDesignSession.DesignPlanes("XY-Plane"), _
        "NewSketch")

' Initialize Edit Mode
Call objADSketch.BeginChange

' Add a Circle to the Sketch Figures
Call objADSketch.Figures.AddCircle(0, 0, 5)

' Exit Edit Mode
Call objADSketch.EndChange

' Holds Part Features object
Dim objADPartFeatures As AlibreX.IADPartFeatures

' Get Part Features object from Part Session
Set objADPartFeatures = objADPartSession.Features

' Holds Part Feature Object
Dim objPartFeature As AlibreX.IADPartFeature

' Add aPart Feature to Part Features collection
Set objPartFeature = objADPartFeatures.AddExtrudedBoss( _
        objADSketch, _
        5, _
        AD_TO_DEPTH, _
        Nothing, _
        Nothing, _
        0, _
        AD_ALONG_NORMAL, _
        Nothing, _
        Nothing, _
        False, _
        0.15, _
        False, _
        "NewExtrusionBossFeature")

' Points to hold Extents data
Dim objLowerPoint As AlibreX.IADPoint
Dim objUpperPoint As AlibreX.IADPoint

' Get Part Feature Extents
Call objPartFeature.GetExtents(objLowerPoint, objUpperPoint)
```



# IADPartFeatures.AddWrap Method

Creates a wrap feature using the input sketch and target face.

#### Syntax

```
IADWrapFeature AddWrap(
	IADSketch pSketch,
	Object targetFaceObject,
	Object depth,
	ADWrapFocusType FocusType,
	ADBooleanOperator BooleanOperator,
	string name
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch to wrap.

targetFaceObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a face.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the wrap depth.

FocusType  ADWrapFocusType
:   The type of focus used for transfering the sketch to the target face.

BooleanOperator  ADBooleanOperator
:   Indicates if the feature adds or removes material.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the Part Feature created. If there is no name, a default name
    will be created for the newly created Part Feature.

#### Return Value

IADWrapFeature  
Returns the new wrap feature.

#### Remarks

- This method will throw an exception under the following situations:
  1. If pSketch is already used by any other feature.
- Note that the newly created Part Feature is not added to the Collection on which this
  method is called. Query for the Collection again to get the updated Collection.
- If the created feature has an error, an error is thrown and the feature still remains
  in the features list.



# IADThickenSurfaceFeature Interface

IADThickenSurfaceFeature interface

#### Syntax

```
public interface IADThickenSurfaceFeature : IADPartFeature
```

The IADThickenSurfaceFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future expansion
of the API, to include information about Thicken Surface features. For general information about
a feature, use the IADPartFeature interface.



# IADSweepFeature Properties

The IADSweepFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DraftParameter | Returns the parameter driving the draft angle if it exists. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | EndCondition | Gets the end condition information. |
|  | EndConditionType | Gets the end conditon type. |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsCutout | Returns True if the sweep feature is a cutout. |
|  | IsOutwardDraft | Gets/sets if the draft is outward or not. |
|  | IsRigid | Gets/sets if rigid mode is used. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Path | Returns the path sketch used to create the sweep feature. |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Sketch | Returns the profile sketch that is swept along a path. |
|  | ToGeometryOffset | Returns the distance of the To Geometry Offset if it exists. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADHoleFeature.Sketch Property

Returns the sketch used to create the hole(s). The
Nodes in the sketch are the
locations where holes are placed.

#### Syntax

```
IADSketch Sketch { get; }
```

#### Property Value

IADSketch



# IADWrapFeature.TargetFace Property

Gets the target face.

#### Syntax

```
IADTargetProxy TargetFace { get; }
```

#### Property Value

IADTargetProxy



# IADLoftFeature.GuideCurves Property

Returns an IObjectCollector containing all of the objects that define the guide curves
for the loft feature. The guide curve objects can be either a 2D sketch,
or a 3D sketch.

#### Syntax

```
IObjectCollector GuideCurves { get; }
```

#### Property Value

IObjectCollector



# IADThinWallRevolutionFeature Properties

The IADThinWallRevolutionFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADAssemblyFeatures Methods

The IADAssemblyFeatures type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given a numerical index/name into the collection, returns the corresponding assembly feature. |



# IADRevolutionFeature.IsCutout Property

Returns True if revolved feature is a cutout.

#### Syntax

```
bool IsCutout { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADChamferFeature Properties

The IADChamferFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Angle | Returns the parameter driving the chamfer angle if it exists. |
|  | Distance1 | Returns the parameter driving the chamfer distance 1. |
|  | Distance2 | Returns the parameter driving the chamfer distance 2 if it exists. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | EdgesAndFaces | Returns the collection of Chamfered Edges and Faces. |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | TangentPropagate | Returns whether the Tangent Propagate option was chosen. The Tangent Propagate option creates a chamfer on each selected edge as well as any other edges that form a path in which a tangent condition can be resolved. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADLoftFeature.CrossSections Property

Returns an IObjectCollector containing all of the objects that define the
cross section for each stage of the loft. The cross sections can be sketches,
faces, or design points.

#### Syntax

```
IObjectCollector CrossSections { get; }
```

#### Property Value

IObjectCollector

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_LOFT\_CROSS\_SECTIONS\_UNAVAILABLE | One or more of the cross sections of this loft is a Face which is not currently available. Generally this is because the face is either removed or changed by the loft feature itself. The current state of the design needs to be before the loft feature to query the Face. |



# IADExtrusionFeature.DepthParameter Property

Returns the parameter driving the extrusion depth.

#### Syntax

```
IADParameter DepthParameter { get; }
```

#### Property Value

IADParameter

#### Remarks

Valid only for blind (AD\_TO\_DEPTH) and mid-plane (AD\_MID\_PLANE)
end conditions.



# IADOffsetFaceFeature.OffsetParameter Property

Returns the parameter driving the offset distance.

#### Syntax

```
IADParameter OffsetParameter { get; }
```

#### Property Value

IADParameter



# IADPartFeature.Session Property

Returns the session to which this feature belongs.

#### Syntax

```
IADSession Session { get; }
```

#### Property Value

IADSession



# IADAssemblyFeatures.Session Property

Returns the parent assembly session for the collection.

#### Syntax

```
IADAssemblySession Session { get; }
```

#### Property Value

IADAssemblySession



# IADSMRebendFeature Methods

The IADSMRebendFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADHelicalFeature.PitchRatio Property

Returns the parameter driving the pitch ratio of the helix. This parameter will only exist
for helices with HelixType AD\_Height\_Pitch or AD\_Revolution\_Pitch and PitchType AD\_VariableRatio.

#### Syntax

```
IADParameter PitchRatio { get; }
```

#### Property Value

IADParameter



# IADExtrusionFeature Methods

The IADExtrusionFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADExtrusionFeature.EndConditionType Property

Gets the end conditon type.

#### Syntax

```
ADPartFeatureEndCondition EndConditionType { get; }
```

#### Property Value

ADPartFeatureEndCondition

#### Remarks

Possible values are:

- AD\_TO\_DEPTH
- AD\_MID\_PLANE
- AD\_TO\_NEXT
- AD\_TO\_GEOMETRY



# IADExternalThreadFeature.HasEdgeChamfer Property

Returns true if the external thread feature is creating a chamfer on the circular edge.

#### Syntax

```
bool HasEdgeChamfer { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADSMTabFeature Properties

The IADSMTabFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADDraftFeature.DraftFaces Property

Returns the faces used for drafting.

#### Syntax

```
IObjectCollector DraftFaces { get; }
```

#### Property Value

IObjectCollector



# IADSMFlangeFeature Methods

The IADSMFlangeFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADSMClosedCornerFeature Interface

IADSMClosedCornerFeature interface

#### Syntax

```
public interface IADSMClosedCornerFeature : IADPartFeature
```

The IADSMClosedCornerFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future
expansion of the API, to include information about Closed Corner features. For general
information about a feature, use the IADPartFeature interface.



# IADLoftFeature Methods

The IADLoftFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |
|  | GetTangentAngle | Returns the angle of the tangent for the input cross section of the loft feature. |
|  | GetTangentMagnitude | Returns the magnitude of the tangent for the input cross section of the loft feature. |
|  | IsTangentSpecified | Returns True if the input cross section of the loft has a specified Tangent Magnitude indicating the weight of the tangent. If the cross section object is a sketch, it may also have a Tangent Angle specified. |



# IADTrimModelFeature Interface

IADTrimModelFeature interface

#### Syntax

```
public interface IADTrimModelFeature : IADPartFeature
```

The IADTrimModelFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future expansion
of the API, to include information about Trim Model features. For general information about
a feature, use the IADPartFeature interface.



# IADImportFileFeature Properties

The IADImportFileFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADShellFeature Properties

The IADShellFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsShellOutward | Returns true if shell is created outward. If true, the shell is created by forming the shell on the outside of the solid, then removing the original model. Whereas, an inward shell is created by cutting away the inside of the model. |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | MultiThicknesses | Returns an array the thicknesses of Multi-Thickness faces. The values in this array correspond to the faces in the MultiThicknessFaces property, and override the standard thickness for those faces. |
|  | MultiThicknessFaces | Returns the faces with overridden thickness values, if any are present in the feature. |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | RemovedFaces | Returns the faces selected for removal if available. |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | StandardThickness | Returns the standard wall thickness of this shell feature. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADHelicalFeature.Pitch Property

Returns the parameter driving the pitch of the helix. This parameter is used by helices with
HelixType AD\_Height\_Pitch,
AD\_Revolution\_Pitch or AD\_Spiral.

#### Syntax

```
IADParameter Pitch { get; }
```

#### Property Value

IADParameter



# IADSweepFeature.Path Property

Returns the path sketch used to create the sweep feature.

#### Syntax

```
IObjectCollector Path { get; }
```

#### Property Value

IObjectCollector



# IADDesignBooleanFeature Interface

IADDesignBooleanFeature interface

#### Syntax

```
public interface IADDesignBooleanFeature : IADPartFeature
```

The IADDesignBooleanFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future
expansion of the API, to include information about Boolean Unite, Boolean Subtract, and Boolean
Intersect features.

For general information about a feature, use the
IADPartFeature interface.



# IADSweepFeature.DraftParameter Property

Returns the parameter driving the draft angle if it exists.

#### Syntax

```
IADParameter DraftParameter { get; }
```

#### Property Value

IADParameter



# IADExtrusionFeature.IsDirectionReversed Property

Gets if the direction of the Extrusion is in the opposite direction to the normal to
the extruded sketch plane.

#### Syntax

```
bool IsDirectionReversed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADSweepFeature Methods

The IADSweepFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADChamferFeature.Angle Property

Returns the parameter driving the chamfer angle if it exists.

#### Syntax

```
IADParameter Angle { get; }
```

#### Property Value

IADParameter

#### Remarks

Only Chamfer Features created using the Angle-Distance option
will have this parameter.



# IADPartFeature Methods

The IADPartFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design. |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature. |



# IADChamferFeature.TangentPropagate Property

Returns whether the Tangent Propagate option was chosen. The Tangent Propagate option creates a
chamfer on each selected edge as well as any other edges that form a path in which a tangent
condition can be resolved.

#### Syntax

```
bool TangentPropagate { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADSMDimpleFeature Methods

The IADSMDimpleFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADHelicalFeature.Taper Property

Returns the parameter driving the taper angle of the helix. This parameter does not
exist for helices with HelixType AD\_Spiral.

#### Syntax

```
IADParameter Taper { get; }
```

#### Property Value

IADParameter



# IADHoleFeature.CounterDrillDepth Property

Returns the counter drill depth of hole(s).

#### Syntax

```
double CounterDrillDepth { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

Valid only for holes with the following
HoleTypes:

- AD\_COUNTER\_DRILLED\_HOLE
- AD\_COUNTER\_DRILLED\_DRILLED\_HOLE



# IADAssemblyFeature.Root Property

Returns the automation root object.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADHelicalFeature.Axis Property

Returns the reference sketch figure used to define the axis of the Helix.

#### Syntax

```
IADSketchLine Axis { get; }
```

#### Property Value

IADSketchLine



# IADSMTabFeature Interface

IADSMTabFeature interface

#### Syntax

```
public interface IADSMTabFeature : IADPartFeature
```

The IADSMTabFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future
expansion of the API, to include information about Tab features. For general
information about a feature, use the IADPartFeature interface.



# IADScaleFeature Properties

The IADScaleFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | IsUniformScaling | Returns whether Uniform Scaling was chosen or not. If true, the part is scaled by the same factor in all 3 directions. Otherwise the scale factors for the X, Y, and Z directions are specified individually. |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | ScaleAboutCenteroid | Returns true if scaled about the centeroid. If false, it means that it was scaled about the Origin of the part workspace. |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UniformScaleFactor | Returns the parameter driving the scale factor if uniform scaling is used for this feature. |
|  | UniformScaleFactorX | Returns the parameter driving the X-direction component of the scale factor if uniform scaling is not used for this feature. |
|  | UniformScaleFactorY | Returns the parameter driving the Y-direction component of the scale factor if uniform scaling is not used for this feature. |
|  | UniformScaleFactorZ | Returns the parameter driving the Z-direction component of the scale factor if uniform scaling is not used for this feature. |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADSMUnbendFeature Properties

The IADSMUnbendFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADPartFeature.FaceColor Property

Sets/Gets the feature Face Color.

#### Syntax

```
int FaceColor { get; set; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADLoftFeature Properties

The IADLoftFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CrossSections | Returns an IObjectCollector containing all of the objects that define the cross section for each stage of the loft. The cross sections can be sketches, faces, or design points. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | GuideCurves | Returns an IObjectCollector containing all of the objects that define the guide curves for the loft feature. The guide curve objects can be either a 2D sketch, or a 3D sketch. |
|  | GuideCurveType | Returns a predefined constant indicating the type of the guide curves used for the loft. |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsConnectEnds | Returns True if the "Connect Ends" loft option is enabled. |
|  | IsCutout | Returns True if the loft feature is a cutout. |
|  | IsMinimizeCurvature | Returns True if the "Minimize Curvature" loft option is enabled. |
|  | IsMinimizeTwist | Returns True if the "Minimize Twist" loft option is enabled. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSimplifySurface | Returns True if the "Simplify Surface" loft option is enabled. |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | IsUsingGuideCurves | Returns True if the loft feature is using any guide curves. |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADPartFeatures.AddDrilledHole Method

Creates a drilled simple Hole feature.

#### Syntax

```
IADHoleFeature AddDrilledHole(
	IADSketch pSketch,
	Object depth,
	Object diameter,
	Object drillAngle,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

diameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the diameter.

drillAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the angle for the drill end.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADAssemblyFeature.Type Property

Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_FEATURE)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADHelicalFeature.PitchType Property

Gets the pitch type of the helix.

#### Syntax

```
ADPitchType PitchType { get; }
```

#### Property Value

ADPitchType



# IADPartFeatures.AddSweptBoss Method

Creates a sweep boss feature, which creates material by moving a sketch along a path
defined by a second sketch.

#### Syntax

```
IADSweepFeature AddSweptBoss(
	IADSketch pProfileSketch,
	IObjectCollector pPathSketch,
	bool IsRigid,
	ADPartFeatureEndCondition endCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	Object draftAngle,
	bool IsOutwardDraft,
	string name
)
```

#### Parameters

pProfileSketch  IADSketch
:   Denotes the sketch which will be swept along pPathSketch.

pPathSketch  IObjectCollector
:   Denotes the sketch used as a path for sweeping pProfileSketch.

IsRigid  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If this is set to true, pProfileSketch remains parallel to the
    profile's sketching plane throughout the sweep.

endCondition  ADPartFeatureEndCondition
:   Denotes how to terminate the sweep.

toGeometryOcc  IADOccurrence
:   Denotes an instance of toGeometryObject from an assembly.
    This can be null if toGeometryObject represents a feature obtained from a
    Part Session

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane or a
    Face. This can be null if endCondition is not
    AD\_TO\_GEOMETRY.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the sweep up to a specified
    distance from the Target (toGeometryObject).

draftAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   This can be a number or an equation from a
    parameter. Pass zero, or a number to create a tapered sweep.

IsOutwardDraft  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If this is set to true, the draft will be created outwards.
    The end face of the created feature will be larger than the starting face.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the Part Feature created. If there is no name, a default name
    will be created for the newly created Part Feature.

#### Return Value

IADSweepFeature  
Returns the new sweep feature.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INVALID\_PATHOBJECT | The specified sweep path is not valid. |
| AD\_E\_INVALID\_ENDCONDITION | Only the AD\_TO\_GEOMETRY and AD\_ENTIRE\_PATH end conditions are valid for sweep features. |
| AD\_E\_INVALID\_GEOMETRY | toGeometryObject was not valid plane or face. |
| AD\_E\_INVALID\_ANGLE | The specified angle is not valid. |

#### Remarks

The following guidelines should be followed when creating swept features.

- The sketch that defines the profile must be closed.
- The sketch that defines the path can be open or closed but cannot be self-intersecting.
- The sketch path cannot lie on the same sketching plane as the profile.
- The sketch path must either start on the profile plane or pass through the profile plane.
- Valid values for the endCondition parameter are:
  - AD\_TO\_GEOMETRY
  - AD\_ENTIRE\_PATH
- pProfileSketch should be an unconsumed sketch.

Note that the newly created Part Feature is not added to the Collection on which this
method is called. Query for the Collection again to get the updated Collection.

If the created feature has an error, an error is thrown and the feature still remains
in the features list.

#### Example

This Visual Basic sample demonstrates adding a Sweep Boss Feature to the Part Features Collection.

```
' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session from Session
Set objADPartSession = m_objADSession

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Part Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADPathSketch As AlibreX.IADSketch

' Add a sketch on "XY-Plane"
Set objADPathSketch = objADSketches.AddSketch(Nothing, _
        objADDesignSession.DesignPlanes("XY-Plane"), _
        "PathSketch")

' Initialize Edit Mode
Call objADPathSketch.BeginChange

' Add a Rectangle to the Sketch Figures
Call objADPathSketch.Figures.AddCircle(0, 0, 10)

' Exit Edit Mode
Call objADPathSketch.EndChange

' Holds Object Collector
Dim objPathCollector As AlibreX.IObjectCollector

' Create new Object Collector
Set objPathCollector = m_objADRoot.NewObjectCollector

' Add Path Sketch to the Object Collector
objPathCollector.Add objADPathSketch

' Holds Sketch Object
Dim objADSweepSketch As AlibreX.IADSketch

' Add a sketch on "XY-Plane"
Set objADSweepSketch = objADSketches.AddSketch(Nothing, _
        objADDesignSession.DesignPlanes("ZX-Plane"), _
        "SweepSketch")

' Initialize Edit Mode
Call objADSweepSketch.BeginChange

' Add a Rectangle to the Sketch Figures
Call objADSweepSketch.Figures.AddCircle(10, 0, 2)

' Exit Edit Mode
Call objADSweepSketch.EndChange

' Holds Part Features object
Dim objADPartFeatures As AlibreX.IADPartFeatures

' Get Part Features object from Part Session
Set objADPartFeatures = objADPartSession.Features

' Holds Sweep Feature Object
Dim objSweeptBossFeature As AlibreX.IADSweepFeature

' Add an Revolved Boss to the Part Features collection
Set objSweeptBossFeature = objADPartFeatures.AddSweptBoss( _
        objADSweepSketch, _
        objPathCollector, _
        False, _
        AD_ENTIRE_PATH, _
        Nothing, _
        Nothing, _
        0, _
        0, _
        False, _
        "NewSweepBossFeature")
```



# IADLoftFeature Interface

This interface represents a Loft Feature.

#### Syntax

```
public interface IADLoftFeature : IADPartFeature
```

The IADLoftFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CrossSections | Returns an IObjectCollector containing all of the objects that define the cross section for each stage of the loft. The cross sections can be sketches, faces, or design points. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | GuideCurves | Returns an IObjectCollector containing all of the objects that define the guide curves for the loft feature. The guide curve objects can be either a 2D sketch, or a 3D sketch. |
|  | GuideCurveType | Returns a predefined constant indicating the type of the guide curves used for the loft. |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsConnectEnds | Returns True if the "Connect Ends" loft option is enabled. |
|  | IsCutout | Returns True if the loft feature is a cutout. |
|  | IsMinimizeCurvature | Returns True if the "Minimize Curvature" loft option is enabled. |
|  | IsMinimizeTwist | Returns True if the "Minimize Twist" loft option is enabled. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSimplifySurface | Returns True if the "Simplify Surface" loft option is enabled. |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | IsUsingGuideCurves | Returns True if the loft feature is using any guide curves. |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |
|  | GetTangentAngle | Returns the angle of the tangent for the input cross section of the loft feature. |
|  | GetTangentMagnitude | Returns the magnitude of the tangent for the input cross section of the loft feature. |
|  | IsTangentSpecified | Returns True if the input cross section of the loft has a specified Tangent Magnitude indicating the weight of the tangent. If the cross section object is a sketch, it may also have a Tangent Angle specified. |



# IADVertexChamferFeature Properties

The IADVertexChamferFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Distance1 | Returns the distance which the chamfer will extend along the first edge. |
|  | Distance2 | Returns the distance which the chamfer will extend along the second edge. |
|  | Distance3 | Returns the distance which the chamfer will extend along the third edge. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |
|  | Vertices | Returns the vertices selected to be chamfered. |



# IADPartFeature.Name Property

Sets/Returns the name of this part feature.

#### Syntax

```
string Name { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADAssemblyFeatures.Item Method

Given a numerical index/name into the collection, returns the corresponding assembly feature.

#### Syntax

```
IADAssemblyFeature Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The numerical index or name of a assembly feature.

#### Return Value

IADAssemblyFeature  
Returns IADAssemblyFeature



# IADPartFeatures.AddCounterSunkDrilledHoleEx Method

Creates a drilled counter sunk Hole feature.

#### Syntax

```
IADHoleFeature AddCounterSunkDrilledHoleEx(
	IADSketch pSketch,
	Object depth,
	Object diameter,
	Object drillAngle,
	Object counterSinkDiameter,
	Object counterSinkAngle,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = "",
	string diameterParameterName = "",
	string drillAngleParameterName = "",
	string counterSinkDiameterParameterName = "",
	string counterSinkAngleParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

diameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the diameter.

drillAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the angle for the drill end.

counterSinkDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-sink diameter.

counterSinkAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-sink angle.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

diameterParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the diameter parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

drillAngleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the drill angle parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

counterSinkDiameterParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the counter sink diameter parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

counterSinkAngleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the counter sink angle parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADOffsetFaceFeature.OffsetFaces Property

Returns the faces selected to offset if available.

#### Syntax

```
IObjectCollector OffsetFaces { get; }
```

#### Property Value

IObjectCollector



# IADLoftFeature.GetTangentAngle Method

Returns the angle of the tangent for the input cross section of the loft feature.

#### Syntax

```
double GetTangentAngle(
	Object crossSection
)
```

#### Parameters

crossSection  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The cross section of this loft feature to check. This can
    be an IADSketch, IADFace, or IADDesignPoint that is in this loft feature's
    CrossSections property or the numerical index of the cross section.

#### Return Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

For cross sections based on a face, rather than a sketch, the angle between the adjoining
faces is used. For sketch cross sections, the tangent angle specified here is with respect to the
normal of the sketch plane upon which the sketch is defined.



# IADPartFeatures.AddTaperedHoleEx Method

Creates a tapered Hole feature.

#### Syntax

```
IADHoleFeature AddTaperedHoleEx(
	IADSketch pSketch,
	Object depth,
	Object majorDiameter,
	Object minorDiameter,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = "",
	string majorDiameterParameterName = "",
	string minorDiameterParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

majorDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the major diameter.

minorDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the minor diameter.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

majorDiameterParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the major diameter parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

minorDiameterParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the minor diameter parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADLoftFeature.IsCutout Property

Returns True if the loft feature is a cutout.

#### Syntax

```
bool IsCutout { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADWrapFeature Methods

The IADWrapFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADHoleFeature.NumberOfHoles Property

Returns total number of holes in this feature.

#### Syntax

```
int NumberOfHoles { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADSMCornerChamferFeature Properties

The IADSMCornerChamferFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADHelicalFeature.StartTransitionAngle Property

Returns the parameter driving the transition angle at the start of the helix, if the
start condition is
Flat.

#### Syntax

```
IADParameter StartTransitionAngle { get; }
```

#### Property Value

IADParameter



# IADScaleFeature.IsUniformScaling Property

Returns whether Uniform Scaling was chosen or not. If true, the part is scaled by
the same factor in all 3 directions.
Otherwise the scale factors for the X,
Y, and
Z directions are specified individually.

#### Syntax

```
bool IsUniformScaling { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADTappedThreadInfo.MinorDiameter Property

Returns the minor diameter of the thread.

#### Syntax

```
double MinorDiameter { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADExtrusionFeature.Direction Property

Gets the direction proxy with the occurrence and direction object.
(edge/Axis)

#### Syntax

```
IADTargetProxy Direction { get; }
```

#### Property Value

IADTargetProxy



# IADHelicalFeature Methods

The IADHelicalFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADSweepFeature.ToGeometryOffset Property

Returns the distance of the To Geometry Offset if it exists.

#### Syntax

```
double ToGeometryOffset { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADSMDimpleFeature Properties

The IADSMDimpleFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADHoleFeature Properties

The IADHoleFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CounterBoreDepth | Returns the counter bore depth of hole(s). |
|  | CounterBoreDiameter | Returns the counter bore diameter of hole(s). |
|  | CounterDrillAngle | Returns the counter drill angle of hole(s). |
|  | CounterDrillDepth | Returns the counter drill depth of hole(s). |
|  | CounterDrillDiameter | Returns the counter drill diameter of hole(s). |
|  | CounterSinkAngle | Returns the counter sink angle of hole(s). |
|  | CounterSinkDiameter | Returns the counter sink diameter of hole(s). |
|  | Depth | Returns the blind depth of hole(s). Valid only for holes with a DepthConditionType of AD\_HOLE\_TO\_DEPTH. |
|  | DepthConditionType | Returns the type of the depth condition for hole(s), e.g. "Through All" |
|  | Diameter | Returns the normal diameter of hole(s). |
|  | DrillAngle | Returns the drill angle of hole(s). |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | HasThread | Returns true if the hole feature has threads. If it does, you can get that information using the TappedThread property. |
|  | HoleType | Returns the type of hole(s), e.g. "Counter Bored Hole". |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | LimitingGeometry | Returns the limiting face for holes with a DepthConditionType of AD\_HOLE\_TO\_OFFSET\_FACE. |
|  | MajorDiameter | Returns the major diameter of hole(s). |
|  | MinorDiameter | Returns the minor diameter of hole(s). |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | NumberOfHoles | Returns total number of holes in this feature. |
|  | OffsetFromLimitingGeometry | Returns the offset distance from limiting face for holes with a DepthConditionType of AD\_HOLE\_TO\_OFFSET\_FACE. |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Sketch | Returns the sketch used to create the hole(s). The Nodes in the sketch are the locations where holes are placed. |
|  | StartPlane | Returns the starting plane for all holes in this feature. |
|  | StartPoints | Returns the collection of IADPoint for starting points for all the holes in this feature. |
|  | TappedThread | Returns an IADTappedThreadInfo object containing the hole’s thread information if the hole feature has threads. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADPartFeatures.AddShellFeature Method

Creates Shell Feature, which hollows out the body of a solid model. When shelling,
the entire part is shelled, not just a feature of it.

#### Syntax

```
IADShellFeature AddShellFeature(
	IObjectCollector colFacesToRemove,
	Object vStandardThickness,
	bool isShellOutward,
	IObjectCollector colMultiThickFaces,
	in Array multiThicknesses,
	string thicknessParameterName = "",
	string name
)
```

#### Parameters

colFacesToRemove  IObjectCollector
:   A collection of faces which will be
    removed by the shell.

vStandardThickness  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the standard thickness parameter; can be a number
    or an equation obtained from a parameter. This thickness will be used for all faces which
    are not passed in the colMultiThickFaces collection.

isShellOutward  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, the shell will be performed outward, by forming the
    shell on the outside of the solid and removing the original model. Otherwise, the shell
    is performed inward, cutting away the inside of the model.

colMultiThickFaces  IObjectCollector
:   A collection of faces for which
    the standard thickness will be overridden. Each face in this collection should have a
    corresponding thickness in the multiThicknesses array. If you do not wish to
    override the standard thickness, this parameter can be null.

multiThicknesses  [Array](https://learn.microsoft.com/dotnet/api/system.array)
:   A double array of thickness values, which will be used for
    the faces specified in the parameter colMultiThickFaces. The size of this array
    should be the same as that of colMultiThickFaces, with an override thickness for
    each face in the collection. If you do not wish to override the standard thickness for
    any faces, this parameter can be null.

thicknessParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the thickness parameter
    that will be created for the shell feature. If no name is provided, a default name will
    be generated.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the shell feature. If no name is provided, a default name
    will be generated.

#### Return Value

IADShellFeature  
Returns the new shell feature.

#### Example

This sample demonstrates creating a Shell feature and then querying it.

```
Debug.Print "********** Add Shell feature ******************"

Dim objRemoveFaceCollector As IObjectCollector
Dim objMultiThickCollector As IObjectCollector
Dim objIADpartfeatures As IADPartFeatures
Dim objIADshellfeature As IADShellFeature
Dim objIADBodies As IADBodies
Dim objIADBody As IADBody
Dim objIADFaces As IADFaces
Dim objsessions As IADSessions
Dim objsession As IADSession
Dim multiThickness(0) As Double
Dim objthickness As IADParameter
Dim objPartSession As IADPartSession

Set objsessions = m_Alibreobjroot.Sessions
If objsessions.Item(0).SessionType = ADObjectSubType_AD_PART Then
    Set objsession = objsessions.Item(0)
Else
    Debug.Print "This is not a part session."
    Exit Sub
End If

Set objPartSession = objsession
Set objIADpartfeatures = objPartSession.Features
Set objIADBodies = objPartSession.Bodies
Set objIADBody = objIADBodies.Item(0)
Set objIADFaces = objIADBody.Faces

Set objRemoveFaceCollector = m_Alibreobjroot.NewObjectCollector
Set objMultiThickCollector = m_Alibreobjroot.NewObjectCollector

multiThickness(0) = 1
Call objRemoveFaceCollector.Add(objIADFaces.Item(0))
Call objMultiThickCollector.Add(objIADFaces.Item(1))
Set objIADshellfeature = objIADpartfeatures.AddShellFeature(objRemoveFaceCollector, 1, True, _
        objMultiThickCollector, multiThickness, "Shell param from API", "Shell feature from API")

Set objthickness = objIADshellfeature.StandardThickness
Debug.Print "The thickness is " & objthickness.Value
Debug.Print "The number of faces with overridden thickness is " _
        & objIADshellfeature.MultiThicknessFaces().count
Debug.Print "The removed faces count is " & objIADshellfeature.RemovedFaces().count

If objIADshellfeature.IsShellOutward = True Then
    Debug.Print "The shell direction is outward."
Else
    Debug.Print "The shell direction is inward."
End If

Debug.Print "****************************"
```



# IADDraftFeature Methods

The IADDraftFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADSweepFeature.Sketch Property

Returns the profile sketch that is swept along a path.

#### Syntax

```
IADSketch Sketch { get; }
```

#### Property Value

IADSketch



# IADPartFeature.Root Property

Returns the automation root object.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADPartFeature.Faces Property

Returns all the faces that comprise this feature.

#### Syntax

```
IADFaces Faces { get; }
```

#### Property Value

IADFaces



# IADSMCornerRoundFeature Properties

The IADSMCornerRoundFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADLoftFeature.IsUsingGuideCurves Property

Returns True if the loft feature is using any guide curves.

#### Syntax

```
bool IsUsingGuideCurves { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPartFeatures.AddSimpleHole Method

Creates a simple Hole feature.

#### Syntax

```
IADHoleFeature AddSimpleHole(
	IADSketch pSketch,
	Object depth,
	Object diameter,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

diameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the diameter.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADTappedThreadInfo.IsValidThread Property

Returns true if the thread is valid.

#### Syntax

```
bool IsValidThread { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDeleteLumpsFeature Methods

The IADDeleteLumpsFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADHoleFeature.StartPlane Property

Returns the starting plane for all holes in this feature.

#### Syntax

```
Object StartPlane { get; }
```

#### Property Value

[Object](https://learn.microsoft.com/dotnet/api/system.object)

#### Remarks

This plane could be an IADFace or
IADDesignPlane.



# IADDraftFeature.DraftAngleParameter Property

Returns the angle parameter of how much a given face or faces must be drafted.

#### Syntax

```
IADParameter DraftAngleParameter { get; }
```

#### Property Value

IADParameter

#### Remarks

The maximum draft angle is 59 degrees.



# IADPartFeatures.AddTaperedDrilledHoleEx Method

Creates a drilled tapered Hole feature.

#### Syntax

```
IADHoleFeature AddTaperedDrilledHoleEx(
	IADSketch pSketch,
	Object depth,
	Object majorDiameter,
	Object minorDiameter,
	Object drillAngle,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = "",
	string majorDiameterParameterName = "",
	string minorDiameterParameterName = "",
	string drillAngleParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

majorDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the major diameter.

minorDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the minor diameter.

drillAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the angle for the drill end.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

majorDiameterParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the major diameter parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

minorDiameterParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the minor diameter parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

drillAngleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the drill angle parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADShellFeature.StandardThickness Property

Returns the standard wall thickness of this shell feature.

#### Syntax

```
IADParameter StandardThickness { get; }
```

#### Property Value

IADParameter



# IADLoftFeature.IsSimplifySurface Property

Returns True if the "Simplify Surface" loft option is enabled.

#### Syntax

```
bool IsSimplifySurface { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADExtrusionFeature.ToGeometryOffset Property

Returns the distance of the To Geometry Offset if it exists.

#### Syntax

```
double ToGeometryOffset { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADOffsetFaceFeature Interface

This interface represents an Offset Face feature. This feature offsets selected
faces of a solid model by a specified distance.

#### Syntax

```
public interface IADOffsetFaceFeature : IADPartFeature
```

The IADOffsetFaceFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | OffsetFaces | Returns the faces selected to offset if available. |
|  | OffsetParameter | Returns the parameter driving the offset distance. |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADImportFileFeature Interface

IADImportFileFeature interface

#### Syntax

```
public interface IADImportFileFeature : IADPartFeature
```

The IADImportFileFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future expansion
of the API, to include information about Imported File features. For general information about
a feature, use the IADPartFeature interface.



# IADAssemblyFeatures.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADHelicalFeature.IsReverse Property

Returns true if the helix is reversed.

#### Syntax

```
bool IsReverse { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADRemoveFaceFeature Properties

The IADRemoveFaceFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADSweepFeature.IsRigid Property

Gets/sets if rigid mode is used.

#### Syntax

```
bool IsRigid { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

If true, the profile Sketch is swept parallel
to the profile's sketching plane.



# IADHoleFeature.LimitingGeometry Property

Returns the limiting face for holes with a
DepthConditionType of
AD\_HOLE\_TO\_OFFSET\_FACE.

#### Syntax

```
IADFace LimitingGeometry { get; }
```

#### Property Value

IADFace



# IADRevolutionFeature.Axis Property

Gets the target proxy containing the axis of revolution and its
occurrence if it has one. The axis can be a
design axis or linear edge.

#### Syntax

```
IADTargetProxy Axis { get; }
```

#### Property Value

IADTargetProxy

#### Remarks

The IADTargetProxy object contains the Axis
object and its occurrence. If the Axis object doesn't
belong to an assembly, the occurrence object
will be null.



# IADDraftFeature.IsOutwardDraft Property

Returns True if the direction of the draft is outward; otherwise, it is inward.

#### Syntax

```
bool IsOutwardDraft { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

An inward draft removes material from a face at a specified angle. An
outward draft adds material to a face.



# IADSMCornerRoundFeature Interface

IADSMCornerRoundFeature interface

#### Syntax

```
public interface IADSMCornerRoundFeature : IADPartFeature
```

The IADSMCornerRoundFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future
expansion of the API, to include information about Corner Round features. For general
information about a feature, use the IADPartFeature interface.



# IADHelicalFeature.EndTransitionAngle Property

Returns the parameter driving the transition angle at the end of the helix, if the
end condition is
Flat.

#### Syntax

```
IADParameter EndTransitionAngle { get; }
```

#### Property Value

IADParameter



# IADTappedThreadInfo.PitchDiameter Property

Returns the pitch diameter of the thread.

#### Syntax

```
double PitchDiameter { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADHoleFeature.CounterDrillAngle Property

Returns the counter drill angle of hole(s).

#### Syntax

```
double CounterDrillAngle { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

Valid only for holes with the following
HoleTypes:

- AD\_COUNTER\_DRILLED\_HOLE
- AD\_COUNTER\_DRILLED\_DRILLED\_HOLE



# IADProjectFeature.DepthParameter Property

Returns the parameter driving the project depth.

#### Syntax

```
IADParameter DepthParameter { get; }
```

#### Property Value

IADParameter



# IADVertexChamferFeature.Vertices Property

Returns the vertices selected to be chamfered.

#### Syntax

```
IObjectCollector Vertices { get; }
```

#### Property Value

IObjectCollector

#### Remarks

Note that any Vertex consumed by either this feature or any other subsequent
feature will not be available.



# IADChamferFeature Methods

The IADChamferFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADDraftFeature.DraftNeutralPlane Property

Returns the draft neutral plane. The neutral plane is the starting point
for the draft, and the plane or
face from which the draft angle is calculated.

#### Syntax

```
IADTargetProxy DraftNeutralPlane { get; }
```

#### Property Value

IADTargetProxy



# IADProjectFeature.IsCutout Property

Returns True if project is a cutout.

#### Syntax

```
bool IsCutout { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADSMPunchFeature Interface

IADSMPunchFeature interface

#### Syntax

```
public interface IADSMPunchFeature : IADPartFeature
```

The IADSMPunchFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future
expansion of the API, to include information about Punch features. For general
information about a feature, use the IADPartFeature interface.



# IADChamferFeature.Distance1 Property

Returns the parameter driving the chamfer distance 1.

#### Syntax

```
IADParameter Distance1 { get; }
```

#### Property Value

IADParameter

#### Remarks

All Chamfer Features will have this parameter.



# IADPartFeatures.AddCounterSunkDrilledHole Method

Creates a drilled counter sunk Hole feature.

#### Syntax

```
IADHoleFeature AddCounterSunkDrilledHole(
	IADSketch pSketch,
	Object depth,
	Object diameter,
	Object drillAngle,
	Object counterSinkDiameter,
	Object counterSinkAngle,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

diameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the diameter.

drillAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the angle for the drill end.

counterSinkDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-sink diameter.

counterSinkAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-sink angle.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADPartFeatures.Session Property

Returns the parent part session for the collection.

#### Syntax

```
IADPartSession Session { get; }
```

#### Property Value

IADPartSession



# IADRevolutionFeature.AngleParameter Property

Returns the parameter driving the angle of revolution.

#### Syntax

```
IADParameter AngleParameter { get; }
```

#### Property Value

IADParameter



# IADPartFeatures.AddCounterSunkHole Method

Creates a counter sunk Hole feature.

#### Syntax

```
IADHoleFeature AddCounterSunkHole(
	IADSketch pSketch,
	Object depth,
	Object diameter,
	Object counterSinkDiameter,
	Object counterSinkAngle,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

diameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the diameter.

counterSinkDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-sink diameter.

counterSinkAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-sink angle.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADProjectFeature Interface

This interface represents a Project feature. Project features either create
or remove material.

#### Syntax

```
public interface IADProjectFeature : IADPartFeature
```

The IADProjectFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DepthParameter | Returns the parameter driving the project depth. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsCutout | Returns True if project is a cutout. |
|  | IsIntoSketchPlane | Gets if project direction is into sketch plane. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Sketch | Returns the sketch used to create project. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADFilletFeature.ConstantRadius Property

Returns the parameter driving the Constant Radius if available. Query
IsConstantRadius to determine
if this fillet is using a constant radius.

#### Syntax

```
IADParameter ConstantRadius { get; }
```

#### Property Value

IADParameter



# IADPartFeature Interface

IADPartFeature interface

#### Syntax

```
public interface IADPartFeature
```

The IADPartFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color. |
|  | FaceColor | Sets/Gets the feature Face Color. |
|  | Faces | Returns all the faces that comprise this feature. |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.) |
|  | HasError | Returns True if error was encountered in computing the feature. |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature. |
|  | IsSuppressed | Gets/Sets the suppression state of this feature. |
|  | Name | Sets/Returns the name of this part feature. |
|  | Opacity | Sets/Gets the feature Opacity. |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity. |
|  | Root | Returns the automation root object. |
|  | Session | Returns the session to which this feature belongs. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE) |
|  | UsePartColor | Use the default part color or not. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design. |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature. |

#### Remarks

Having an existing feature, it is possible to make only these changes to that
feature through the API:

- Toggle suppression
- Rename it
- Delete it
- Toggle draft inward/outward
- Toggle sweep rigidity
- Change values of parameters



# IADProjectFeature.Sketch Property

Returns the sketch used to create project.

#### Syntax

```
IADSketch Sketch { get; }
```

#### Property Value

IADSketch



# IADRemoveFaceFeature Methods

The IADRemoveFaceFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADMoveFaceFeature Properties

The IADMoveFaceFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADTappedThreadInfo.ThreadLength Property

Returns the length of the thread.

#### Syntax

```
double ThreadLength { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADPartFeatures.AddCounterDrilledHole Method

Creates a counter drilled Hole feature.

#### Syntax

```
IADHoleFeature AddCounterDrilledHole(
	IADSketch pSketch,
	Object depth,
	Object diameter,
	Object counterDrillDepth,
	Object counterDrillDiameter,
	Object counterDrillAngle,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

diameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the diameter.

counterDrillDepth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-drill depth.

counterDrillDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-drill diameter.

counterDrillAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-drill angle.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADVertexChamferFeature.Distance1 Property

Returns the distance which the chamfer will extend along the first edge.

#### Syntax

```
IADParameter Distance1 { get; }
```

#### Property Value

IADParameter



# IADPartFeatures.Item Method

Given a numerical index/name into the collection, returns the corresponding part feature.

#### Syntax

```
IADPartFeature Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The numerical index or name of a part feature.

#### Return Value

IADPartFeature  
Returns IADPartFeature



# IADPatternFeature Interface

IADPatternFeature interface

#### Syntax

```
public interface IADPatternFeature : IADPartFeature
```

The IADPatternFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future expansion
of the API, to include information about Linear Pattern and Circular Pattern features. For
general information about a feature, use the IADPartFeature interface.



# IADProjectFeature Methods

The IADProjectFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADLoftFeature.IsMinimizeCurvature Property

Returns True if the "Minimize Curvature" loft option is enabled.

#### Syntax

```
bool IsMinimizeCurvature { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADSMPunchFeature Methods

The IADSMPunchFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADSMCornerChamferFeature Methods

The IADSMCornerChamferFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADTappedThreadInfo.Pitch Property

Returns the pitch of the thread.

#### Syntax

```
double Pitch { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADPartFeature.Opacity Property

Sets/Gets the feature Opacity.

#### Syntax

```
int Opacity { get; set; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADAssemblyHoleFeature Interface

This interface represents a Hole feature. Hole features are created by removing
material to create one or more holes. A large number of parameters are available
for specifying the details of the hole. The hole's thread information can be
used in its callout in 2D Drawings.

#### Syntax

```
public interface IADAssemblyHoleFeature : IADAssemblyFeature
```

The IADAssemblyHoleFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FeatureType | Returns the feature type (extrusion, hole etc.)  (Inherited from IADAssemblyFeature) |
|  | Name | Returns the name of this design feature.  (Inherited from IADAssemblyFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADAssemblyFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADAssemblyFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_FEATURE)  (Inherited from IADAssemblyFeature) |

#### Remarks

This is currently a stub for future implementation.



# IADExtrusionFeature.IsCutout Property

Returns True if extrusion is a cutout.

#### Syntax

```
bool IsCutout { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADTappedThreadInfo Interface

IADTappedThreadInfo represents the specifications of a thread for a
Hole feature. You can get this information
about an existing hole feature by querying its
TappedThread property. An IADTappedThreadInfo
object can also be created using the CreateTappedThreadInfo
method, which can then be passed to one of the Hole feature creation methods on
IADPartFeatures to create a hole using that tapped thread.

#### Syntax

```
public interface IADTappedThreadInfo
```

The IADTappedThreadInfo type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | IsValidThread | Returns true if the thread is valid. |
|  | MajorDiameter | Returns the major diameter of the thread. |
|  | MinorDiameter | Returns the minor diameter of the thread. |
|  | Name | Returns the name of the thread. |
|  | Pitch | Returns the pitch of the thread. |
|  | PitchDiameter | Returns the pitch diameter of the thread. |
|  | TapDrillDiameter | Returns the tap drill diameter of the thread. |
|  | ThreadClass | Returns the class of the thread. |
|  | ThreadLength | Returns the length of the thread. |
|  | ThreadType | Returns the thread type. This is also known as the Series of the thread. |



# IADPartFeature.Reflectivity Property

Sets/Gets the feature Color Reflectivity.

#### Syntax

```
int Reflectivity { get; set; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADPartFeature.UsePartColor Property

Use the default part color or not.

#### Syntax

```
bool UsePartColor { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPartFeatures.AddTaperedHole Method

Creates a tapered Hole feature.

#### Syntax

```
IADHoleFeature AddTaperedHole(
	IADSketch pSketch,
	Object depth,
	Object majorDiameter,
	Object minorDiameter,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

majorDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the major diameter.

minorDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the minor diameter.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADAssemblyFeatures.Count Property

Returns the number of features in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADHoleFeature.MinorDiameter Property

Returns the minor diameter of hole(s).

#### Syntax

```
double MinorDiameter { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

Valid only for holes with the following
HoleTypes:

- AD\_TAPERED\_HOLE
- AD\_TAPERED\_DRILLED\_HOLE



# IADAssemblyFeature.FeatureType Property

Returns the feature type (extrusion, hole etc.)

#### Syntax

```
ADAssemblyFeatureType FeatureType { get; }
```

#### Property Value

ADAssemblyFeatureType

#### Remarks

See the help page for ADAssemblyFeatureType
to get a list of possible return values and their corresponding types.



# IADHelicalFeature.IsClockwise Property

Returns true if the rotation direction of the helix is clockwise.

#### Syntax

```
bool IsClockwise { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADHoleFeature.Depth Property

Returns the blind depth of hole(s). Valid only for holes with a
DepthConditionType
of AD\_HOLE\_TO\_DEPTH.

#### Syntax

```
double Depth { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADFilletFeature.StartRadiusParams Property

Returns the collection of Start Radius parameters if available. There will be a
parameter in this collection for each edge or face
in the EdgesOrFaces collection.

#### Syntax

```
IObjectCollector StartRadiusParams { get; }
```

#### Property Value

IObjectCollector



# IADScaleFeature.UniformScaleFactorX Property

Returns the parameter driving the X-direction component of the scale factor if
uniform scaling is not used for this feature.

#### Syntax

```
IADParameter UniformScaleFactorX { get; }
```

#### Property Value

IADParameter



# IADHoleFeature.CounterDrillDiameter Property

Returns the counter drill diameter of hole(s).

#### Syntax

```
double CounterDrillDiameter { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

Valid only for holes with the following
HoleTypes:

- AD\_COUNTER\_DRILLED\_HOLE
- AD\_COUNTER\_DRILLED\_DRILLED\_HOLE



# IADOffsetFaceFeature Methods

The IADOffsetFaceFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADHoleFeature.CounterSinkAngle Property

Returns the counter sink angle of hole(s).

#### Syntax

```
double CounterSinkAngle { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

Valid only for holes with the following
HoleTypes:

- AD\_COUNTER\_SUNK\_HOLE
- AD\_COUNTER\_SUNK\_DRILLED\_HOLE



# IADHelicalFeature.StartConditionType Property

Returns the Start condition type of the helix.

#### Syntax

```
ADHelixConditionType StartConditionType { get; }
```

#### Property Value

ADHelixConditionType



# IADThinWallExtrusionFeature Interface

IADThinWallExtrusionFeature interface

#### Syntax

```
public interface IADThinWallExtrusionFeature : IADPartFeature
```

The IADThinWallExtrusionFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

This interface has no methods or properties. It is a placeholder for future expansion
of the API, to include information about Thin Wall Extrusion features. For general information about
a feature, use the IADPartFeature interface.



# IADTrimModelFeature Properties

The IADTrimModelFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADExtrusionFeature.Sketch Property

Returns the sketch used to create extrusion.

#### Syntax

```
IADSketch Sketch { get; }
```

#### Property Value

IADSketch



# IADPartFeatures.AddCounterDrilledHoleEx Method

Creates a counter drilled Hole feature.

#### Syntax

```
IADHoleFeature AddCounterDrilledHoleEx(
	IADSketch pSketch,
	Object depth,
	Object diameter,
	Object counterDrillDepth,
	Object counterDrillDiameter,
	Object counterDrillAngle,
	bool isReversed,
	IADTappedThreadInfo tappedThread,
	ADHoleDepthCondition depthCondition,
	IADOccurrence toGeometryOcc,
	Object toGeometryObject,
	double toGeometryOffset,
	string name,
	string depthParameterName = "",
	string diameterParameterName = "",
	string counterDrillDepthParameterName = "",
	string counterDrillDiameterParameterName = "",
	string counterDrillAngleParameterName = ""
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch of hole locations. A hole will be created at
    each Node present in the sketch.

depth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the depth; can be a number or an equation obtained from
    a parameter.

diameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the diameter.

counterDrillDepth  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-drill depth.

counterDrillDiameter  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-drill diameter.

counterDrillAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the counter-drill angle.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set this to true to create the hole in a direction normal to the
    sketch plane.

tappedThread  IADTappedThreadInfo
:   If you wish to specify tapped thread information for the hole,
    pass an IADTappedThreadInfo object for this parameter
    with the desired thread. These can be created using the
    CreateTappedThreadInfo method.
    If you do not want threads, pass a null value.

depthCondition  ADHoleDepthCondition
:   Denotes the depth condition of the hole to be created.

toGeometryOcc  IADOccurrence
:   Denotes an instance of the toGeometryObject in
    an assembly. This can be null if depthCondition is not AD\_HOLE\_TO\_OFFSET\_FACE
    or if the toGeometryObject belongs to a part.

toGeometryObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes a Design Plane
    or a Face. This can be null if depthCondition is
    not AD\_HOLE\_TO\_OFFSET\_FACE.

toGeometryOffset  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   Denotes the offset value to create the hole up to
    a specified distance from the Target (toGeometryObject).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the hole feature. If no name is provided, a default name
    will be generated.

depthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

diameterParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the diameter parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

counterDrillDepthParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the counter drill depth parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

counterDrillDiameterParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the counter drill diameter parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

counterDrillAngleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)  (Optional)
:   Name of the counter drill angle parameter
    that will be created for the hole feature. If no name is provided, a default name will
    be generated.

#### Return Value

IADHoleFeature  
Returns the new hole feature.



# IADLoftFeature.IsConnectEnds Property

Returns True if the "Connect Ends" loft option is enabled.

#### Syntax

```
bool IsConnectEnds { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADHelicalFeature.IsCutout Property

Returns True if helical feature is a cutout.

#### Syntax

```
bool IsCutout { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADHelicalFeature.Revolutions Property

Returns the parameter driving the number of revolutions of the helix. This parameter is used by helices with
HelixType AD\_Height\_Revolution,
AD\_Revolution\_Pitch or AD\_Spiral.

#### Syntax

```
IADParameter Revolutions { get; }
```

#### Property Value

IADParameter



# IADRevolutionFeature.Sketch Property

Returns the sketch used to create revolution.

#### Syntax

```
IADSketch Sketch { get; }
```

#### Property Value

IADSketch



# IADFilletFeature.EndRadiusParams Property

Returns the collection of End Radius parameters if available. There will be a
parameter in this collection for each edge or face
in the EdgesOrFaces collection.

#### Syntax

```
IObjectCollector EndRadiusParams { get; }
```

#### Property Value

IObjectCollector



# IADPartFeatures.AddRevolvedBoss Method

Creates a revolved boss feature using the input sketch that is revolved around a design
axis or a linear edge.

#### Syntax

```
IADRevolutionFeature AddRevolvedBoss(
	IADSketch pSketch,
	IADOccurrence axisOcc,
	Object axisObject,
	Object revolveAngle,
	string name
)
```

#### Parameters

pSketch  IADSketch
:   Denotes the sketch to revolve.

axisOcc  IADOccurrence
:   Denotes an "instance" of a Part or Assembly, to which the given
    pAxis belongs to. For specifying the Axis in a standalone Part, axisOcc
    should be null.

axisObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes an axis or
    edge. If an edge is specified, it must be a linear edge.

revolveAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Denotes the rotation angle in radians for creating the
    revolved feature.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Name of the Part Feature created. If there is no name, a default name
    will be created for the newly created Part Feature.

#### Return Value

IADRevolutionFeature  
Returns the new revolution feature.

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INVALID\_AXIS | The specified axis object is not valid. |
| AD\_E\_AXIS\_PARALELL\_SKETCH | The axis and the sketch plane must be parallel. |
| AD\_E\_INVALID\_ANGLE | The specified angle is not valid. |

#### Remarks

- This method will throw an exception under the following situations:
  1. If pSketch is already used by any other feature.
- Note that the newly created Part Feature is not added to the Collection on which this
  method is called. Query for the Collection again to get the updated Collection.
- If the created feature has an error, an error is thrown and the feature still remains
  in the features list.

#### Example

This Visual Basic sample demonstrates adding a Revolve Boss Feature to the Part Features Collection.

```
' Holds Part Session object
Dim objADPartSession  As AlibreX.IADPartSession

' Get Part Session from Session
Set objADPartSession = m_objADSession

' Holds Design Session object
Dim objADDesignSession  As AlibreX.IADDesignSession

' Get Part Session object from existing session
Set objADDesignSession = m_objADSession

' Holds Sketches object
Dim objADSketches As AlibreX.IADSketches

' Get Sketches collection from Part Session object
Set objADSketches = objADPartSession.Sketches()

' Holds Sketch Object
Dim objADSketch As AlibreX.IADSketch

' Add a sketch on "XY-Plane"
Set objADSketch = objADSketches.AddSketch(Nothing, _
        objADDesignSession.DesignPlanes("XY-Plane"), _
        "NewSketch")

' Initialize Edit Mode
Call objADSketch.BeginChange

' Add a Rectangle to the Sketch Figures
Call objADSketch.Figures.AddRectangle(1, 0, 5, 5)

' Exit Edit Mode
Call objADSketch.EndChange

' Holds Part Features object
Dim objADPartFeatures As AlibreX.IADPartFeatures

' Get Part Features object from Part Session
Set objADPartFeatures = objADPartSession.Features

' Holds Revolved Feature Object
Dim objRevolvedBossFeature As AlibreX.IADRevolutionFeature

' Add an Revolved Boss to the Part Features collection
Set objRevolvedBossFeature = objADPartFeatures.AddRevolvedBoss( _
        objADSketch, _
        Nothing, _
        objADDesignSession.DesignAxes("Y-Axis"), _
        3.14, _
        "NewRevolutionBossFeature")
```



# IADPartFeatures.CurrentState Property

Sets/Returns the current active feature.

#### Syntax

```
IADPartFeature CurrentState { get; set; }
```

#### Property Value

IADPartFeature

#### Remarks

Returns the last active feature if the current feature is Part Feature type
(i.e. not reference geometry or a sketch), else returns the last active Part Feature from
the features collection.

**WARNING: This Property is OBSOLETE.** Please use
CurrentFeature



# IADThinWallRevolutionFeature Methods

The IADThinWallRevolutionFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADExtrusionFeature Interface

This interface represents an Extrude Boss or Cut feature. Extrusion features either create
or remove material by extending a sketch in a linear direction by a specified distance.

#### Syntax

```
public interface IADExtrusionFeature : IADPartFeature
```

The IADExtrusionFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DepthParameter | Returns the parameter driving the extrusion depth. |
|  | Direction | Gets the direction proxy with the occurrence and direction object. (edge/Axis) |
|  | DirectionType | Gets the direction type used for creating this extrusion. |
|  | DirectionVector | Gets the direction vector. |
|  | DraftParameter | Returns the parameter driving the draft angle if it exists. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | EndCondition | Gets the end condition information. |
|  | EndConditionType | Gets the end conditon type. |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsCutout | Returns True if extrusion is a cutout. |
|  | IsDirectionReversed | Gets if the direction of the Extrusion is in the opposite direction to the normal to the extruded sketch plane. |
|  | IsOutwardDraft | Gets/sets if draft is outward or not. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Sketch | Returns the sketch used to create extrusion. |
|  | ToGeometryOffset | Returns the distance of the To Geometry Offset if it exists. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADThinWallSweepFeature Properties

The IADThinWallSweepFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADHelicalFeature.EndConditionType Property

Returns the End condition type of the helix.

#### Syntax

```
ADHelixConditionType EndConditionType { get; }
```

#### Property Value

ADHelixConditionType



# IADVertexChamferFeature.Distance3 Property

Returns the distance which the chamfer will extend along the third edge.

#### Syntax

```
IADParameter Distance3 { get; }
```

#### Property Value

IADParameter



# IADFilletFeature.EdgesOrFaces Property

Returns the collection of Edges/Faces selected to fillet.

#### Syntax

```
IObjectCollector EdgesOrFaces { get; }
```

#### Property Value

IObjectCollector

#### Remarks

For faces in the collection, all the edges adjoining the face are filleted.
Note that if the original Edges/Faces were consumed by this feature or any other, it
can not be obtained.



# IADFilletFeature Interface

This interface represents a Fillet feature.

#### Syntax

```
public interface IADFilletFeature : IADPartFeature
```

The IADFilletFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ConstantRadius | Returns the parameter driving the Constant Radius if available. Query IsConstantRadius to determine if this fillet is using a constant radius. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | EdgesOrFaces | Returns the collection of Edges/Faces selected to fillet. |
|  | EndRadiusParams | Returns the collection of End Radius parameters if available. There will be a parameter in this collection for each edge or face in the EdgesOrFaces collection. |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsConstantRadius | Returns true if this fillet is created with a constant radius, available from the property ConstantRadius. Otherwise, the fillet has start and end radii, which can be queried with the StartRadiusParams and EndRadiusParams properties. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | StartRadiusParams | Returns the collection of Start Radius parameters if available. There will be a parameter in this collection for each edge or face in the EdgesOrFaces collection. |
|  | TangentPropagate | Returns whether the Tangent Propagate option was chosen. The Tangent Propagate option creates a fillet on each selected edge as well as any other edges that form a path in which a tangent condition can be resolved. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADAssemblyExtrusionFeature Interface

This interface represents an assembly Extrude Cut feature. Extrusion features either create
or remove material by extending a sketch in a linear direction by a specified distance.

#### Syntax

```
public interface IADAssemblyExtrusionFeature : IADAssemblyFeature
```

The IADAssemblyExtrusionFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | FeatureType | Returns the feature type (extrusion, hole etc.)  (Inherited from IADAssemblyFeature) |
|  | Name | Returns the name of this design feature.  (Inherited from IADAssemblyFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADAssemblyFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADAssemblyFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_ASSEMBLY\_FEATURE)  (Inherited from IADAssemblyFeature) |

#### Remarks

This is currently a stub for future implementation.



# IADMeshBooleanFeature Methods

The IADMeshBooleanFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADPartFeatures.AddLoftBoss Method

Creates Loft Boss feature.

#### Syntax

```
IADLoftFeature AddLoftBoss(
	IObjectCollector CrossSections,
	IObjectCollector Tangents,
	IObjectCollector TangentMagnitudes,
	IObjectCollector TangentAngles,
	IObjectCollector GuideCurves,
	ADLoftGuideType GuideCurveType,
	bool MinimizeTwist,
	bool MinimizeCurvature,
	bool SimplifySurface,
	bool ConnectEnds,
	string Name
)
```

#### Parameters

CrossSections  IObjectCollector
:   A collection of the cross sections which will define the loft.
    Cross sections must be either IADSketch, IADFace, or IADDesignPoint types.

Tangents  IObjectCollector
:   A collection of boolean values, to indicate whether the cross sections will
    have a specified tangency. Must either contain the same number of elements
    as CrossSections, or be null or empty to indicate that no tangency control will
    be used. If GuideCurves are specified, this parameter will be ignored.

TangentMagnitudes  IObjectCollector
:   A collection of double values, to indicate the tangent magnitude for particular
    cross sections. Must either contain the same number of elements as CrossSections,
    or be null or empty to indicate that no tangency control will be used.
    If GuideCurves are specified, this parameter will be ignored.

TangentAngles  IObjectCollector
:   A collection of double values, to indicate the tangent angles for particular
    cross sections. Must either contain the same number of elements as CrossSections,
    or be null or empty to indicate that no tangency control will be used.
    If GuideCurves are specified, this parameter will be ignored.

GuideCurves  IObjectCollector
:   A collection of guide curves to further define the results of the loft. Guide curves
    must be of type IAD3DSketch. To indicate the loft should not use guide curves, pass
    a null or empty array.

GuideCurveType  ADLoftGuideType
:   The type of guide curves to be used with the loft feature. Will be ignored
    if no guide curves are specified.

MinimizeTwist  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Minimize twisting of the loft surface.

MinimizeCurvature  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Minimize the curvature of the loft surface.
    Not available when using Guide Curves.

SimplifySurface  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Simplify the surface of the loft.

ConnectEnds  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Connect the start and end cross sections of the Loft.

Name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optionally, specify a name for the new Loft feature.

#### Return Value

IADLoftFeature  
Returns the newly created loft feature.



# IADTrimModelFeature Methods

The IADTrimModelFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADPartFeature.IsSheetMetalFeature Property

Returns whether this feature is a sheet metal feature.

#### Syntax

```
bool IsSheetMetalFeature { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADPartFeatures Methods

The IADPartFeatures type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | AddConstantRadiusFilletFeature | Creates a fillet feature on the given Edges and/or Faces with the given constant radius. |
|  | AddCounterBoredDrilledHole | Creates a drilled counter bored Hole feature. |
|  | AddCounterBoredDrilledHoleEx | Creates a drilled counter bored Hole feature. |
|  | AddCounterBoredHole | Creates a counter bored Hole feature. |
|  | AddCounterBoredHoleEx | Creates a counter bored Hole feature. |
|  | AddCounterDrilledDrilledHole | Creates a drilled counter drilled Hole feature. |
|  | AddCounterDrilledDrilledHoleEx | Creates a drilled counter drilled Hole feature. |
|  | AddCounterDrilledHole | Creates a counter drilled Hole feature. |
|  | AddCounterDrilledHoleEx | Creates a counter drilled Hole feature. |
|  | AddCounterSunkDrilledHole | Creates a drilled counter sunk Hole feature. |
|  | AddCounterSunkDrilledHoleEx | Creates a drilled counter sunk Hole feature. |
|  | AddCounterSunkHole | Creates a counter sunk Hole feature. |
|  | AddCounterSunkHoleEx | Creates a counter sunk Hole feature. |
|  | AddDraftFeature | Creates a Draft Feature for given faces corresponding to a given plane or face. |
|  | AddDrilledHole | Creates a drilled simple Hole feature. |
|  | AddDrilledHoleEx | Creates a drilled simple Hole feature. |
|  | AddEdgeChamferFeature | Creates an Edge Chamfer Feature by chamfering the given Edges and Faces. |
|  | AddExtrudedBoss | Adds an extruded boss feature, which add material by extending a sketch in a linear direction by a specified distance. It is possible to specify a draft angle to taper the extrusion. 'To Geometry' can specify any face in an assembly context. 'Along Edge' can specify any edge in assembly context. |
|  | AddExtrudedCutout | Adds an extruded cut feature, which removes material by extending a sketch in a linear direction by a specified distance. It is possible to specify a draft angle to taper the extrusion. 'To Geometry' can specify any face in an assembly context. 'Along Edge' can specify any edge in assembly context. |
|  | AddLoftBoss | Creates Loft Boss feature. |
|  | AddLoftCut | Creates Loft Cut feature. |
|  | AddMeshBooleanFeature | Creates a mesh boolean feature. |
|  | AddOffsetFaceFeature | Creates an offset face feature. |
|  | AddProject | Creates a project feature using the input sketch. |
|  | AddRevolvedBoss | Creates a revolved boss feature using the input sketch that is revolved around a design axis or a linear edge. |
|  | AddRevolvedCutout | Creates a revolved cut feature using the input sketch that is revolved around a design axis or a linear edge. |
|  | AddScaleFeature | The scale feature is used to transform the entire part as required. |
|  | AddShellFeature | Creates Shell Feature, which hollows out the body of a solid model. When shelling, the entire part is shelled, not just a feature of it. |
|  | AddSimpleHole | Creates a simple Hole feature. |
|  | AddSimpleHoleEx | Creates a simple Hole feature. |
|  | AddSweptBoss | Creates a sweep boss feature, which creates material by moving a sketch along a path defined by a second sketch. |
|  | AddSweptCutout | Creates a sweep cut feature, which removes material by moving a sketch along a path defined by a second sketch. |
|  | AddTaperedDrilledHole | Creates a drilled tapered Hole feature. |
|  | AddTaperedDrilledHoleEx | Creates a drilled tapered Hole feature. |
|  | AddTaperedHole | Creates a tapered Hole feature. |
|  | AddTaperedHoleEx | Creates a tapered Hole feature. |
|  | AddVariableRadiusFilletFeature | Creates a fillet feature on the given Edges and/or Faces with the given variable radius. Note that no. of Start/End Radii should match the number of Edges and Faces in the given colEdgesAndFaces. |
|  | AddVertexChamferFeature | Creates a Vertex Chamfer feature by chamfering a specified distance along each of the edges which meet at the vertex. |
|  | AddWrap | Creates a wrap feature using the input sketch and target face. |
|  | CreateTappedThreadInfo | Returns IADTappedThreadInfo containing the Tapped Thread information to be used for Hole feature creation. |
|  | Item | Given a numerical index/name into the collection, returns the corresponding part feature. |



# IADThinWallSweepFeature Methods

The IADThinWallSweepFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADPatternFeature Methods

The IADPatternFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADTappedThreadInfo Properties

The IADTappedThreadInfo type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | IsValidThread | Returns true if the thread is valid. |
|  | MajorDiameter | Returns the major diameter of the thread. |
|  | MinorDiameter | Returns the minor diameter of the thread. |
|  | Name | Returns the name of the thread. |
|  | Pitch | Returns the pitch of the thread. |
|  | PitchDiameter | Returns the pitch diameter of the thread. |
|  | TapDrillDiameter | Returns the tap drill diameter of the thread. |
|  | ThreadClass | Returns the class of the thread. |
|  | ThreadLength | Returns the length of the thread. |
|  | ThreadType | Returns the thread type. This is also known as the Series of the thread. |



# IADThinWallExtrusionFeature Methods

The IADThinWallExtrusionFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADPartFeatures.AddMeshBooleanFeature Method

Creates a mesh boolean feature.

#### Syntax

```
IADMeshBooleanFeature AddMeshBooleanFeature(
	IADDesignMesh designMesh,
	IADOccurrence designMeshOcc,
	ADBooleanOperator adBooleanOperator,
	string name
)
```

#### Parameters

designMesh  IADDesignMesh

designMeshOcc  IADOccurrence

adBooleanOperator  ADBooleanOperator

name  [String](https://learn.microsoft.com/dotnet/api/system.string)

#### Return Value

IADMeshBooleanFeature



# IADTappedThreadInfo.MajorDiameter Property

Returns the major diameter of the thread.

#### Syntax

```
double MajorDiameter { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADShellFeature Interface

This interface represents a Shell Feature. The Shell feature operation creates a walled
model from a solid model.

#### Syntax

```
public interface IADShellFeature : IADPartFeature
```

The IADShellFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsShellOutward | Returns true if shell is created outward. If true, the shell is created by forming the shell on the outside of the solid, then removing the original model. Whereas, an inward shell is created by cutting away the inside of the model. |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | MultiThicknesses | Returns an array the thicknesses of Multi-Thickness faces. The values in this array correspond to the faces in the MultiThicknessFaces property, and override the standard thickness for those faces. |
|  | MultiThicknessFaces | Returns the faces with overridden thickness values, if any are present in the feature. |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | RemovedFaces | Returns the faces selected for removal if available. |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | StandardThickness | Returns the standard wall thickness of this shell feature. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |

#### Remarks

A Shell Feature creates a shell out of the entire part, not specific features of
it.



# IADShellFeature Methods

The IADShellFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADHoleFeature.TappedThread Property

Returns an IADTappedThreadInfo object
containing the hole’s thread information if the hole feature has threads.

#### Syntax

```
IADTappedThreadInfo TappedThread { get; }
```

#### Property Value

IADTappedThreadInfo



# IADScaleFeature Methods

The IADScaleFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |


# IADMirrorFeature.IsEntirePart Property

Returns true if the mirror feature mirrors the entire part.

#### Syntax

```
bool IsEntirePart { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADMirrorFeature.MirrorPlane Property

Returns the plane across which the feature was mirrored.

#### Syntax

```
IADDesignPlane MirrorPlane { get; }
```

#### Property Value

IADDesignPlane



# IADMirrorFeature.PatternGeometry Property

Returns true if geometry patterning is enabled.

#### Syntax

```
bool PatternGeometry { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADMirrorFeature.TargetFeatures Property

Returns the collection of target features mirrored.

#### Syntax

```
IObjectCollector TargetFeatures { get; }
```

#### Property Value

IObjectCollector


# IADAlongPathPatternFeature Interface

This interface represents an Along Path Pattern Feature.

#### Syntax

```
public interface IADAlongPathPatternFeature : IADPatternFeature, IADPartFeature
```

The IADAlongPathPatternFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | InstanceDistance | Returns the parameter driving the distance between pattern instances. |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsReversed | Returns true if the pattern direction is reversed. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | NumInstances | Returns the parameter driving the number of pattern instances. |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | PathObjects | Returns the collection of path objects defining the pattern path. |
|  | PatternGeometry | Returns true if geometry patterning is enabled. |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | StartPoint | Returns the start point on the path. |
|  | TargetFeatures | Returns the collection of target features being patterned. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADAlongPathPatternFeature Properties

The IADAlongPathPatternFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | InstanceDistance | Returns the parameter driving the distance between pattern instances. |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsReversed | Returns true if the pattern direction is reversed. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | NumInstances | Returns the parameter driving the number of pattern instances. |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | PathObjects | Returns the collection of path objects defining the pattern path. |
|  | PatternGeometry | Returns true if geometry patterning is enabled. |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | StartPoint | Returns the start point on the path. |
|  | TargetFeatures | Returns the collection of target features being patterned. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADAlongPathPatternFeature Methods

The IADAlongPathPatternFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADAlongPathPatternFeature.InstanceDistance Property

Returns the parameter driving the distance between pattern instances.

#### Syntax

```
IADParameter InstanceDistance { get; }
```

#### Property Value

IADParameter



# IADAlongPathPatternFeature.IsReversed Property

Returns true if the pattern direction is reversed.

#### Syntax

```
bool IsReversed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADAlongPathPatternFeature.NumInstances Property

Returns the parameter driving the number of pattern instances.

#### Syntax

```
IADParameter NumInstances { get; }
```

#### Property Value

IADParameter



# IADAlongPathPatternFeature.PathObjects Property

Returns the collection of path objects defining the pattern path.

#### Syntax

```
IObjectCollector PathObjects { get; }
```

#### Property Value

IObjectCollector



# IADAlongPathPatternFeature.PatternGeometry Property

Returns true if geometry patterning is enabled.

#### Syntax

```
bool PatternGeometry { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADAlongPathPatternFeature.StartPoint Property

Returns the start point on the path.

#### Syntax

```
IADDesignPoint StartPoint { get; }
```

#### Property Value

IADDesignPoint



# IADAlongPathPatternFeature.TargetFeatures Property

Returns the collection of target features being patterned.

#### Syntax

```
IObjectCollector TargetFeatures { get; }
```

#### Property Value

IObjectCollector


# IADCircularPatternFeature Interface

This interface represents a Circular Feature Pattern.

#### Syntax

```
public interface IADCircularPatternFeature : IADPatternFeature, IADPartFeature
```

The IADCircularPatternFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Returns the axis of rotation for the pattern. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | InstanceAngle | Returns the parameter driving the angle between pattern instances. |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsReversed | Returns true if the rotation direction is reversed. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | NumInstances | Returns the parameter driving the number of pattern instances. |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | PatternGeometry | Returns true if geometry patterning is enabled. |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | TargetFeatures | Returns the collection of target features being patterned. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADCircularPatternFeature Properties

The IADCircularPatternFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Returns the axis of rotation for the pattern. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | InstanceAngle | Returns the parameter driving the angle between pattern instances. |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsReversed | Returns true if the rotation direction is reversed. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | NumInstances | Returns the parameter driving the number of pattern instances. |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | PatternGeometry | Returns true if geometry patterning is enabled. |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | TargetFeatures | Returns the collection of target features being patterned. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADCircularPatternFeature Methods

The IADCircularPatternFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADCircularPatternFeature.Axis Property

Returns the axis of rotation for the pattern.

#### Syntax

```
IADDesignAxis Axis { get; }
```

#### Property Value

IADDesignAxis



# IADCircularPatternFeature.InstanceAngle Property

Returns the parameter driving the angle between pattern instances.

#### Syntax

```
IADParameter InstanceAngle { get; }
```

#### Property Value

IADParameter



# IADCircularPatternFeature.IsReversed Property

Returns true if the rotation direction is reversed.

#### Syntax

```
bool IsReversed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADCircularPatternFeature.NumInstances Property

Returns the parameter driving the number of pattern instances.

#### Syntax

```
IADParameter NumInstances { get; }
```

#### Property Value

IADParameter



# IADCircularPatternFeature.PatternGeometry Property

Returns true if geometry patterning is enabled.

#### Syntax

```
bool PatternGeometry { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADCircularPatternFeature.TargetFeatures Property

Returns the collection of target features being patterned.

#### Syntax

```
IObjectCollector TargetFeatures { get; }
```

#### Property Value

IObjectCollector


# IADCircularTopologyPatternFeature Interface

This interface represents a Circular Topology Pattern Feature.

#### Syntax

```
public interface IADCircularTopologyPatternFeature : IADPatternFeature, IADPartFeature
```

The IADCircularTopologyPatternFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Returns the axis of rotation for the pattern. |
|  | CheckResults | Returns true if result checking is enabled. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | Face | Returns the face being patterned. |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | InstanceAngle | Returns the parameter driving the angle between pattern instances. |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsReversed | Returns true if the rotation direction is reversed. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | NumInstances | Returns the parameter driving the number of pattern instances. |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADCircularTopologyPatternFeature Properties

The IADCircularTopologyPatternFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Axis | Returns the axis of rotation for the pattern. |
|  | CheckResults | Returns true if result checking is enabled. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | Face | Returns the face being patterned. |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | InstanceAngle | Returns the parameter driving the angle between pattern instances. |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsReversed | Returns true if the rotation direction is reversed. |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | NumInstances | Returns the parameter driving the number of pattern instances. |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADCircularTopologyPatternFeature Methods

The IADCircularTopologyPatternFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADCircularTopologyPatternFeature.Axis Property

Returns the axis of rotation for the pattern.

#### Syntax

```
IADDesignAxis Axis { get; }
```

#### Property Value

IADDesignAxis



# IADCircularTopologyPatternFeature.CheckResults Property

Returns true if result checking is enabled.

#### Syntax

```
bool CheckResults { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADCircularTopologyPatternFeature.Face Property

Returns the face being patterned.

#### Syntax

```
IADFace Face { get; }
```

#### Property Value

IADFace



# IADCircularTopologyPatternFeature.InstanceAngle Property

Returns the parameter driving the angle between pattern instances.

#### Syntax

```
IADParameter InstanceAngle { get; }
```

#### Property Value

IADParameter



# IADCircularTopologyPatternFeature.IsReversed Property

Returns true if the rotation direction is reversed.

#### Syntax

```
bool IsReversed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADCircularTopologyPatternFeature.NumInstances Property

Returns the parameter driving the number of pattern instances.

#### Syntax

```
IADParameter NumInstances { get; }
```

#### Property Value

IADParameter


# IADLinearPatternFeature Interface

This interface represents a Linear Feature Pattern.

#### Syntax

```
public interface IADLinearPatternFeature : IADPatternFeature, IADPartFeature
```

The IADLinearPatternFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | FirstAxis | Returns the primary direction axis for the pattern. |
|  | FirstInstanceDistance | Returns the parameter driving the distance between instances in the primary direction. |
|  | FirstIsReversed | Returns true if the primary pattern direction is reversed. |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | NumFirstInstances | Returns the parameter driving the number of instances in the primary direction. |
|  | NumSecondInstances | Returns the parameter driving the number of instances in the secondary direction. |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | PatternGeometry | Returns true if geometry patterning is enabled. |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | SecondAxis | Returns the secondary direction axis for the pattern. |
|  | SecondInstanceDistance | Returns the parameter driving the distance between instances in the secondary direction. |
|  | SecondIsReversed | Returns true if the secondary pattern direction is reversed. |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | TargetFeatures | Returns the collection of target features being patterned. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADLinearPatternFeature Properties

The IADLinearPatternFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | FirstAxis | Returns the primary direction axis for the pattern. |
|  | FirstInstanceDistance | Returns the parameter driving the distance between instances in the primary direction. |
|  | FirstIsReversed | Returns true if the primary pattern direction is reversed. |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | NumFirstInstances | Returns the parameter driving the number of instances in the primary direction. |
|  | NumSecondInstances | Returns the parameter driving the number of instances in the secondary direction. |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | PatternGeometry | Returns true if geometry patterning is enabled. |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | SecondAxis | Returns the secondary direction axis for the pattern. |
|  | SecondInstanceDistance | Returns the parameter driving the distance between instances in the secondary direction. |
|  | SecondIsReversed | Returns true if the secondary pattern direction is reversed. |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | TargetFeatures | Returns the collection of target features being patterned. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADLinearPatternFeature Methods

The IADLinearPatternFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADLinearPatternFeature.FirstAxis Property

Returns the primary direction axis for the pattern.

#### Syntax

```
IADDesignAxis FirstAxis { get; }
```

#### Property Value

IADDesignAxis



# IADLinearPatternFeature.FirstInstanceDistance Property

Returns the parameter driving the distance between instances in the primary direction.

#### Syntax

```
IADParameter FirstInstanceDistance { get; }
```

#### Property Value

IADParameter



# IADLinearPatternFeature.FirstIsReversed Property

Returns true if the primary pattern direction is reversed.

#### Syntax

```
bool FirstIsReversed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADLinearPatternFeature.NumFirstInstances Property

Returns the parameter driving the number of instances in the primary direction.

#### Syntax

```
IADParameter NumFirstInstances { get; }
```

#### Property Value

IADParameter



# IADLinearPatternFeature.NumSecondInstances Property

Returns the parameter driving the number of instances in the secondary direction.

#### Syntax

```
IADParameter NumSecondInstances { get; }
```

#### Property Value

IADParameter



# IADLinearPatternFeature.PatternGeometry Property

Returns true if geometry patterning is enabled.

#### Syntax

```
bool PatternGeometry { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADLinearPatternFeature.SecondAxis Property

Returns the secondary direction axis for the pattern.

#### Syntax

```
IADDesignAxis SecondAxis { get; }
```

#### Property Value

IADDesignAxis



# IADLinearPatternFeature.SecondInstanceDistance Property

Returns the parameter driving the distance between instances in the secondary direction.

#### Syntax

```
IADParameter SecondInstanceDistance { get; }
```

#### Property Value

IADParameter



# IADLinearPatternFeature.SecondIsReversed Property

Returns true if the secondary pattern direction is reversed.

#### Syntax

```
bool SecondIsReversed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADLinearPatternFeature.TargetFeatures Property

Returns the collection of target features being patterned.

#### Syntax

```
IObjectCollector TargetFeatures { get; }
```

#### Property Value

IObjectCollector


# IADLinearTopologyPatternFeature Interface

This interface represents a Linear Topology Pattern Feature.

#### Syntax

```
public interface IADLinearTopologyPatternFeature : IADPatternFeature, IADPartFeature
```

The IADLinearTopologyPatternFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CheckResults | Returns true if result checking is enabled. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | Face | Returns the face being patterned. |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | FirstAxis | Returns the primary direction axis for the pattern. |
|  | FirstInstanceDistance | Returns the parameter driving the distance between instances in the primary direction. |
|  | FirstIsReversed | Returns true if the primary pattern direction is reversed. |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | NumFirstInstances | Returns the parameter driving the number of instances in the primary direction. |
|  | NumSecondInstances | Returns the parameter driving the number of instances in the secondary direction. |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | SecondAxis | Returns the secondary direction axis for the pattern. |
|  | SecondInstanceDistance | Returns the parameter driving the distance between instances in the secondary direction. |
|  | SecondIsReversed | Returns true if the secondary pattern direction is reversed. |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADLinearTopologyPatternFeature Properties

The IADLinearTopologyPatternFeature type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CheckResults | Returns true if result checking is enabled. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | Face | Returns the face being patterned. |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | FirstAxis | Returns the primary direction axis for the pattern. |
|  | FirstInstanceDistance | Returns the parameter driving the distance between instances in the primary direction. |
|  | FirstIsReversed | Returns true if the primary pattern direction is reversed. |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | NumFirstInstances | Returns the parameter driving the number of instances in the primary direction. |
|  | NumSecondInstances | Returns the parameter driving the number of instances in the secondary direction. |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | SecondAxis | Returns the secondary direction axis for the pattern. |
|  | SecondInstanceDistance | Returns the parameter driving the distance between instances in the secondary direction. |
|  | SecondIsReversed | Returns true if the secondary pattern direction is reversed. |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADLinearTopologyPatternFeature Methods

The IADLinearTopologyPatternFeature type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADLinearTopologyPatternFeature.CheckResults Property

Returns true if result checking is enabled.

#### Syntax

```
bool CheckResults { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADLinearTopologyPatternFeature.Face Property

Returns the face being patterned.

#### Syntax

```
IADFace Face { get; }
```

#### Property Value

IADFace



# IADLinearTopologyPatternFeature.FirstAxis Property

Returns the primary direction axis for the pattern.

#### Syntax

```
IADDesignAxis FirstAxis { get; }
```

#### Property Value

IADDesignAxis



# IADLinearTopologyPatternFeature.FirstInstanceDistance Property

Returns the parameter driving the distance between instances in the primary direction.

#### Syntax

```
IADParameter FirstInstanceDistance { get; }
```

#### Property Value

IADParameter



# IADLinearTopologyPatternFeature.FirstIsReversed Property

Returns true if the primary pattern direction is reversed.

#### Syntax

```
bool FirstIsReversed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADLinearTopologyPatternFeature.NumFirstInstances Property

Returns the parameter driving the number of instances in the primary direction.

#### Syntax

```
IADParameter NumFirstInstances { get; }
```

#### Property Value

IADParameter



# IADLinearTopologyPatternFeature.NumSecondInstances Property

Returns the parameter driving the number of instances in the secondary direction.

#### Syntax

```
IADParameter NumSecondInstances { get; }
```

#### Property Value

IADParameter



# IADLinearTopologyPatternFeature.SecondAxis Property

Returns the secondary direction axis for the pattern.

#### Syntax

```
IADDesignAxis SecondAxis { get; }
```

#### Property Value

IADDesignAxis



# IADLinearTopologyPatternFeature.SecondInstanceDistance Property

Returns the parameter driving the distance between instances in the secondary direction.

#### Syntax

```
IADParameter SecondInstanceDistance { get; }
```

#### Property Value

IADParameter



# IADLinearTopologyPatternFeature.SecondIsReversed Property

Returns true if the secondary pattern direction is reversed.

#### Syntax

```
bool SecondIsReversed { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)


# IADConstantRadiusFilletFeatureEx Interface

This interface represents an advanced Constant Radius Fillet feature.

#### Syntax

```
public interface IADConstantRadiusFilletFeatureEx : IADPartFeature
```

The IADConstantRadiusFilletFeatureEx type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BlendVertices | Returns whether vertex blending is enabled. |
|  | Bulge | Returns the parameter driving the fillet bulge. |
|  | ConstantRadius | Returns the parameter driving the constant fillet radius. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | EdgesOrFaces | Returns the collection of edges or faces filleted by this feature. |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | ManualSetback | Returns whether manual setback is enabled. |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | SetbackValue | Returns the parameter driving the setback distance. |
|  | SizeByChordLength | Returns whether sizing by chord length is enabled. |
|  | TangentPropagate | Returns whether tangent propagation is enabled. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADConstantRadiusFilletFeatureEx Properties

The IADConstantRadiusFilletFeatureEx type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | BlendVertices | Returns whether vertex blending is enabled. |
|  | Bulge | Returns the parameter driving the fillet bulge. |
|  | ConstantRadius | Returns the parameter driving the constant fillet radius. |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | EdgesOrFaces | Returns the collection of edges or faces filleted by this feature. |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | ManualSetback | Returns whether manual setback is enabled. |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | SetbackValue | Returns the parameter driving the setback distance. |
|  | SizeByChordLength | Returns whether sizing by chord length is enabled. |
|  | TangentPropagate | Returns whether tangent propagation is enabled. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADConstantRadiusFilletFeatureEx Methods

The IADConstantRadiusFilletFeatureEx type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |



# IADConstantRadiusFilletFeatureEx.BlendVertices Property

Returns whether vertex blending is enabled.

#### Syntax

```
bool BlendVertices { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADConstantRadiusFilletFeatureEx.Bulge Property

Returns the parameter driving the fillet bulge.

#### Syntax

```
IADParameter Bulge { get; }
```

#### Property Value

IADParameter



# IADConstantRadiusFilletFeatureEx.ConstantRadius Property

Returns the parameter driving the constant fillet radius.

#### Syntax

```
IADParameter ConstantRadius { get; }
```

#### Property Value

IADParameter



# IADConstantRadiusFilletFeatureEx.EdgesOrFaces Property

Returns the collection of edges or faces filleted by this feature.

#### Syntax

```
IObjectCollector EdgesOrFaces { get; }
```

#### Property Value

IObjectCollector



# IADConstantRadiusFilletFeatureEx.ManualSetback Property

Returns whether manual setback is enabled.

#### Syntax

```
bool ManualSetback { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADConstantRadiusFilletFeatureEx.SetbackValue Property

Returns the parameter driving the setback distance.

#### Syntax

```
IADParameter SetbackValue { get; }
```

#### Property Value

IADParameter



# IADConstantRadiusFilletFeatureEx.SizeByChordLength Property

Returns whether sizing by chord length is enabled.

#### Syntax

```
bool SizeByChordLength { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADConstantRadiusFilletFeatureEx.TangentPropagate Property

Returns whether tangent propagation is enabled.

#### Syntax

```
bool TangentPropagate { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)


# IADVariableRadiusFilletFeatureEx Interface

This interface represents an advanced Variable Radius Fillet feature.

#### Syntax

```
public interface IADVariableRadiusFilletFeatureEx : IADPartFeature
```

The IADVariableRadiusFilletFeatureEx type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | Edges | Returns the collection of edges filleted by this feature. |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | NumRadiusLocations | Returns the number of radius parameter locations along the edge. |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |
|  | GetRadiusParameters | Returns the radius parameters along the filleted edge. |



# IADVariableRadiusFilletFeatureEx Properties

The IADVariableRadiusFilletFeatureEx type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | EdgeColor | Sets/Gets the feature Edge Color.  (Inherited from IADPartFeature) |
|  | Edges | Returns the collection of edges filleted by this feature. |
|  | FaceColor | Sets/Gets the feature Face Color.  (Inherited from IADPartFeature) |
|  | Faces | Returns all the faces that comprise this feature.  (Inherited from IADPartFeature) |
|  | FeatureType | Returns the feature type (extrusion, revolution etc.)  (Inherited from IADPartFeature) |
|  | HasError | Returns True if error was encountered in computing the feature.  (Inherited from IADPartFeature) |
|  | IsActive | Gets whether the part feature is active. A value of 'true' indicates that the part feature is visible. ie. Neither suppressed nor below the rollback bar in the design explorer.  (Inherited from IADPartFeature) |
|  | IsSheetMetalFeature | Returns whether this feature is a sheet metal feature.  (Inherited from IADPartFeature) |
|  | IsSuppressed | Gets/Sets the suppression state of this feature.  (Inherited from IADPartFeature) |
|  | Name | Sets/Returns the name of this part feature.  (Inherited from IADPartFeature) |
|  | NumRadiusLocations | Returns the number of radius parameter locations along the edge. |
|  | Opacity | Sets/Gets the feature Opacity.  (Inherited from IADPartFeature) |
|  | Reflectivity | Sets/Gets the feature Color Reflectivity.  (Inherited from IADPartFeature) |
|  | Root | Returns the automation root object.  (Inherited from IADPartFeature) |
|  | Session | Returns the session to which this feature belongs.  (Inherited from IADPartFeature) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PART\_FEATURE)  (Inherited from IADPartFeature) |
|  | UsePartColor | Use the default part color or not.  (Inherited from IADPartFeature) |



# IADVariableRadiusFilletFeatureEx Methods

The IADVariableRadiusFilletFeatureEx type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Delete | Removes the feature from the design.  (Inherited from IADPartFeature) |
|  | GetExtents | Returns lower left and upper right corners of a 3D box enclosing the feature.  (Inherited from IADPartFeature) |
|  | GetRadiusParameters | Returns the radius parameters along the filleted edge. |



# IADVariableRadiusFilletFeatureEx.Edges Property

Returns the collection of edges filleted by this feature.

#### Syntax

```
IObjectCollector Edges { get; }
```

#### Property Value

IObjectCollector



# IADVariableRadiusFilletFeatureEx.NumRadiusLocations Property

Returns the number of radius parameter locations along the edge.

#### Syntax

```
int NumRadiusLocations { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADVariableRadiusFilletFeatureEx.GetRadiusParameters Method

Returns the radius parameters along the filleted edge.

#### Syntax

```
IObjectCollector GetRadiusParameters()
```

#### Return Value

IObjectCollector  
A collection of IADParameter objects representing the radius at each location along the edge.


# IADPartFeatures.AddAlongPathFeaturePattern Method

Creates an along path feature pattern.

#### Syntax

```
IADAlongPathPatternFeature AddAlongPathFeaturePattern(
	IObjectCollector pFeatures,
	IObjectCollector pPathObjects,
	object pStartPoint,
	object pNumInstances,
	object pInstanceDistance,
	bool isReversed,
	bool patternGeometry,
	string name
)
```

#### Parameters

pFeatures  IObjectCollector
:   A collection of IADPartFeature objects to pattern.

pPathObjects  IObjectCollector
:   A collection of edges or sketch figures forming the continuous pattern path.

pStartPoint  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The start point on the path (IADDesignPoint or IADVertex).

pNumInstances  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The number of pattern instances (integer or numeric string).

pInstanceDistance  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The distance between adjacent pattern instances.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to reverse the direction of the pattern along the path.

patternGeometry  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to pattern geometry directly rather than re-evaluating feature parameters.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the feature to create.

#### Return Value

IADAlongPathPatternFeature  
The newly created along path pattern feature.



# IADPartFeatures.AddCircularFeaturePattern Method

Creates a circular feature pattern.

#### Syntax

```
IADCircularPatternFeature AddCircularFeaturePattern(
	IObjectCollector pFeatures,
	object pAxis,
	object pNumInstances,
	object pInstanceAngle,
	bool isReversed,
	bool patternGeometry,
	string name
)
```

#### Parameters

pFeatures  IObjectCollector
:   A collection of IADPartFeature objects to pattern.

pAxis  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The axis of rotation (IADDesignAxis or linear IADEdge).

pNumInstances  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The number of pattern instances (integer or numeric string).

pInstanceAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The angle between adjacent pattern instances in radians.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to reverse the angular rotation direction.

patternGeometry  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to pattern geometry directly.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the feature to create.

#### Return Value

IADCircularPatternFeature  
The newly created circular pattern feature.



# IADPartFeatures.AddCircularTopologyPattern Method

Creates a circular topology pattern.

#### Syntax

```
IADCircularTopologyPatternFeature AddCircularTopologyPattern(
	IADFace pFace,
	object pAxis,
	object pNumInstances,
	object pInstanceAngle,
	bool isReversed,
	bool checkResults,
	string name
)
```

#### Parameters

pFace  IADFace
:   The face topology to pattern.

pAxis  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The axis of rotation (IADDesignAxis or linear IADEdge).

pNumInstances  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The number of pattern instances (integer or numeric string).

pInstanceAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The angle between adjacent pattern instances in radians.

isReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to reverse the angular rotation direction.

checkResults  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to enable result topology checking.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the feature to create.

#### Return Value

IADCircularTopologyPatternFeature  
The newly created circular topology pattern feature.



# IADPartFeatures.AddConstantRadiusFilletFeatureEx Method

Creates an advanced constant radius fillet feature with tangent propagation, chord length sizing, blend vertices, bulge, and setback options.

#### Syntax

```
IADConstantRadiusFilletFeatureEx AddConstantRadiusFilletFeatureEx(
	IObjectCollector colEdgesAndFaces,
	object radius,
	bool tangentPropagate,
	bool sizeByChordLength,
	bool blendVertices,
	object bulge,
	bool manualSetback,
	object setbackValue,
	IObjectCollector pSetbackVertices,
	IObjectCollector pSetbackEdges,
	IObjectCollector pSetbackDistances,
	string name
)
```

#### Parameters

colEdgesAndFaces  IObjectCollector
:   A collection of IADEdge or IADFace objects to fillet.

radius  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The fillet radius (double or numeric string).

tangentPropagate  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to automatically extend the fillet along tangent continuous edges.

sizeByChordLength  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to specify fillet size by chord length rather than radius.

blendVertices  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to blend corner vertices.

bulge  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The conic bulge parameter.

manualSetback  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to enable manual setback control at corner vertices.

setbackValue  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The default setback distance.

pSetbackVertices  IObjectCollector
:   A collection of corner vertices for custom setback.

pSetbackEdges  IObjectCollector
:   A collection of setback edges meeting at the setback vertices.

pSetbackDistances  IObjectCollector
:   A collection of setback distances corresponding to the setback edges.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the feature to create.

#### Return Value

IADConstantRadiusFilletFeatureEx  
The newly created constant radius fillet feature.



# IADPartFeatures.AddEntirePartMirrorFeature Method

Mirrors the entire part across a specified plane.

#### Syntax

```
IADMirrorFeature AddEntirePartMirrorFeature(
	object pPlane,
	string name
)
```

#### Parameters

pPlane  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The plane across which to mirror the entire part (IADDesignPlane or planar IADFace).

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the feature to create.

#### Return Value

IADMirrorFeature  
The newly created mirror feature.



# IADPartFeatures.AddHelicalBoss Method

Creates a helical boss feature using a sketch revolved along a helical path.

#### Syntax

```
IADHelicalFeature AddHelicalBoss(
	IADSketch pSketch,
	bool bParallelOriented,
	object pAxisObject,
	ADHelixType helixType,
	bool bClockwise,
	bool bReverse,
	object height,
	object pitch,
	object revolutions,
	ADPitchType pitchType,
	object pitchRatio,
	object pitchEnd,
	object taper,
	ADHelixConditionType startConditionType,
	object startFlatAngle,
	object startTransitionAngle,
	ADHelixConditionType endConditionType,
	object endFlatAngle,
	object endTransitionAngle,
	string name,
	string heightParameterName,
	string pitchParameterName,
	string revolutionsParameterName,
	string pitchRatioParameterName,
	string taperParameterName,
	string startFlatAngleParameterName,
	string startTransitionAngleParameterName,
	string endFlatAngleParameterName,
	string endTransitionAngleParameterName
)
```

#### Parameters

pSketch  IADSketch
:   The sketch profile to extrude along the helix.

bParallelOriented  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to orient the sketch profile parallel to the helical axis.

pAxisObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The axis of the helix (IADDesignAxis or linear IADEdge).

helixType  ADHelixType
:   The type of helix definition (pitch and revolutions, height and revolutions, etc.).

bClockwise  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True for a right-handed (clockwise) helix; False for left-handed.

bReverse  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to reverse the axial extrusion direction.

height  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The height of the helix.

pitch  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The start pitch of the helix.

revolutions  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The number of revolutions.

pitchType  ADPitchType
:   The pitch variation type (constant or variable).

pitchRatio  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The pitch ratio for variable pitch helices.

pitchEnd  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The ending pitch for variable pitch helices.

taper  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The taper angle of the helix.

startConditionType  ADHelixConditionType
:   The start condition type (natural or flat).

startFlatAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The flat angle at the start of the helix.

startTransitionAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The transition angle at the start of the helix.

endConditionType  ADHelixConditionType
:   The end condition type (natural or flat).

endFlatAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The flat angle at the end of the helix.

endTransitionAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The transition angle at the end of the helix.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the feature to create.

heightParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optional custom name for the height parameter.

pitchParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optional custom name for the pitch parameter.

revolutionsParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optional custom name for the revolutions parameter.

pitchRatioParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optional custom name for the pitch ratio parameter.

taperParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optional custom name for the taper angle parameter.

startFlatAngleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optional custom name for the start flat angle parameter.

startTransitionAngleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optional custom name for the start transition angle parameter.

endFlatAngleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optional custom name for the end flat angle parameter.

endTransitionAngleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optional custom name for the end transition angle parameter.

#### Return Value

IADHelicalFeature  
The newly created helical boss feature.



# IADPartFeatures.AddHelicalCutout Method

Creates a helical cut feature using a sketch revolved along a helical path.

#### Syntax

```
IADHelicalFeature AddHelicalCutout(
	IADSketch pSketch,
	bool bParallelOriented,
	object pAxisObject,
	ADHelixType helixType,
	bool bClockwise,
	bool bReverse,
	object height,
	object pitch,
	object revolutions,
	ADPitchType pitchType,
	object pitchRatio,
	object pitchEnd,
	object taper,
	ADHelixConditionType startConditionType,
	object startFlatAngle,
	object startTransitionAngle,
	ADHelixConditionType endConditionType,
	object endFlatAngle,
	object endTransitionAngle,
	string name,
	string heightParameterName,
	string pitchParameterName,
	string revolutionsParameterName,
	string pitchRatioParameterName,
	string taperParameterName,
	string startFlatAngleParameterName,
	string startTransitionAngleParameterName,
	string endFlatAngleParameterName,
	string endTransitionAngleParameterName
)
```

#### Parameters

pSketch  IADSketch
:   The sketch profile to cut along the helix.

bParallelOriented  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to orient the sketch profile parallel to the helical axis.

pAxisObject  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The axis of the helix (IADDesignAxis or linear IADEdge).

helixType  ADHelixType
:   The type of helix definition (pitch and revolutions, height and revolutions, etc.).

bClockwise  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True for a right-handed (clockwise) helix; False for left-handed.

bReverse  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to reverse the axial cut direction.

height  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The height of the helix.

pitch  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The start pitch of the helix.

revolutions  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The number of revolutions.

pitchType  ADPitchType
:   The pitch variation type (constant or variable).

pitchRatio  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The pitch ratio for variable pitch helices.

pitchEnd  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The ending pitch for variable pitch helices.

taper  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The taper angle of the helix.

startConditionType  ADHelixConditionType
:   The start condition type (natural or flat).

startFlatAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The flat angle at the start of the helix.

startTransitionAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The transition angle at the start of the helix.

endConditionType  ADHelixConditionType
:   The end condition type (natural or flat).

endFlatAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The flat angle at the end of the helix.

endTransitionAngle  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The transition angle at the end of the helix.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the feature to create.

heightParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optional custom name for the height parameter.

pitchParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optional custom name for the pitch parameter.

revolutionsParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optional custom name for the revolutions parameter.

pitchRatioParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optional custom name for the pitch ratio parameter.

taperParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optional custom name for the taper angle parameter.

startFlatAngleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optional custom name for the start flat angle parameter.

startTransitionAngleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optional custom name for the start transition angle parameter.

endFlatAngleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optional custom name for the end flat angle parameter.

endTransitionAngleParameterName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   Optional custom name for the end transition angle parameter.

#### Return Value

IADHelicalFeature  
The newly created helical cutout feature.



# IADPartFeatures.AddLinearFeaturePattern Method

Creates a linear feature pattern in one or two directions.

#### Syntax

```
IADLinearPatternFeature AddLinearFeaturePattern(
	IObjectCollector pFeatures,
	object pFirstAxis,
	object pNumFirstInstances,
	object pFirstInstanceDistance,
	bool firstIsReversed,
	object pSecondAxis,
	object pNumSecondInstances,
	object pSecondInstanceDistance,
	bool secondIsReversed,
	bool patternGeometry,
	string name
)
```

#### Parameters

pFeatures  IObjectCollector
:   A collection of IADPartFeature objects to pattern.

pFirstAxis  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The primary direction axis (IADDesignAxis or linear IADEdge).

pNumFirstInstances  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The number of pattern instances along the primary direction.

pFirstInstanceDistance  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The spacing between instances along the primary direction.

firstIsReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to reverse the primary pattern direction.

pSecondAxis  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Optional secondary direction axis (IADDesignAxis or linear IADEdge). Pass null for a 1D pattern.

pNumSecondInstances  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The number of pattern instances along the secondary direction (or 1 for 1D pattern).

pSecondInstanceDistance  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The spacing between instances along the secondary direction.

secondIsReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to reverse the secondary pattern direction.

patternGeometry  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to pattern geometry directly.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the feature to create.

#### Return Value

IADLinearPatternFeature  
The newly created linear pattern feature.



# IADPartFeatures.AddLinearTopologyPattern Method

Creates a linear topology pattern in one or two directions.

#### Syntax

```
IADLinearTopologyPatternFeature AddLinearTopologyPattern(
	IADFace pFace,
	object pFirstAxis,
	object pNumFirstInstances,
	object pFirstInstanceDistance,
	bool firstIsReversed,
	object pSecondAxis,
	object pNumSecondInstances,
	object pSecondInstanceDistance,
	bool secondIsReversed,
	bool checkResults,
	string name
)
```

#### Parameters

pFace  IADFace
:   The face topology to pattern.

pFirstAxis  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The primary direction axis (IADDesignAxis or linear IADEdge).

pNumFirstInstances  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The number of pattern instances along the primary direction.

pFirstInstanceDistance  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The spacing between instances along the primary direction.

firstIsReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to reverse the primary pattern direction.

pSecondAxis  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   Optional secondary direction axis (IADDesignAxis or linear IADEdge). Pass null for a 1D pattern.

pNumSecondInstances  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The number of pattern instances along the secondary direction.

pSecondInstanceDistance  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The spacing between instances along the secondary direction.

secondIsReversed  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to reverse the secondary pattern direction.

checkResults  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to enable result topology checking.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the feature to create.

#### Return Value

IADLinearTopologyPatternFeature  
The newly created linear topology pattern feature.



# IADPartFeatures.AddMirrorFeaturePattern Method

Creates a mirror feature pattern of one or more features across a plane.

#### Syntax

```
IADMirrorFeature AddMirrorFeaturePattern(
	IObjectCollector pFeatures,
	object pPlane,
	bool patternGeometry,
	string name
)
```

#### Parameters

pFeatures  IObjectCollector
:   A collection of IADPartFeature objects to mirror.

pPlane  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The plane across which to mirror the features (IADDesignPlane or planar IADFace).

patternGeometry  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   True to pattern geometry directly.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the feature to create.

#### Return Value

IADMirrorFeature  
The newly created mirror feature.



# IADPartFeatures.AddVariableRadiusFilletFeatureEx Method

Creates an advanced variable radius fillet feature on the given edges.

#### Syntax

```
IADVariableRadiusFilletFeatureEx AddVariableRadiusFilletFeatureEx(
	IObjectCollector colEdges,
	IObjectCollector colLocationParams,
	IObjectCollector colRadiusParams,
	string name
)
```

#### Parameters

colEdges  IObjectCollector
:   A collection of IADEdge objects to fillet.

colLocationParams  IObjectCollector
:   A collection of normalized parameter locations along each edge (0.0 to 1.0).

colRadiusParams  IObjectCollector
:   A collection of fillet radius values corresponding to each location parameter.

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the feature to create.

#### Return Value

IADVariableRadiusFilletFeatureEx  
The newly created variable radius fillet feature.

