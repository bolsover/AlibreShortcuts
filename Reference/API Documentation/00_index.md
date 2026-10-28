# AlibreX API — Master Index

> **How to use this index with Claude**
>
> This reference has been split into domain-focused files.  Always include
> this index file in every conversation.  When you need help with a specific
> area, also attach the relevant domain file(s) listed below.
>
> Typical workflow:
> 1. Paste this index into the conversation.
> 2. Describe your task.
> 3. Claude will tell you which domain file(s) to attach.
> 4. Paste those files and continue.

---

## Key Cross-Domain Relationships

- All sessions are obtained via `IADRoot.Sessions` or `IADRoot.OpenFile` → **01_core_root**
- `IADDesignSession` is the base for `IADPartSession`, `IADAssemblySession`, `IADDrawingSession`
- Sketches live on `IADPartSession.Sketches` (→ **04**) or `.Sketches3D` (→ **05**)
- Features consume sketches: **03_features** references **04/05**
- BRep geometry (→ **06**) is accessed via `IADPartSession.Bodies` or feature faces
- Parameters (→ **09**) are accessed via `IADSession.Parameters`
- Drawing BOM tables (→ **08**) reference assembly occurrences (→ **07**)

---

## Domain Files

### `00_concepts.md`  —  Conceptual Guides & Overviews

**12 sections** covering: `AlibreX`, `Assemblies`, `General`, `Getting`, `Introduction`, `PDM`, `Reference`, `Side-by-side`, `Sketching`, `Solid`, `Tips`, `Topology`

### `01_core_root.md`  —  Core / Root / Session

**228 sections** covering: `ADAccuracy`, `ADAssembly`, `ADBoolean`, `ADConfiguration`, `ADDesign`, `ADDetailing`, `ADDimension`, `ADDirection`, `ADDrawing`, `ADEdge`, `ADEntity`, `ADEvent`, `ADExtended`, `ADFace`, `ADGeometry`, `ADHelix`, `ADHole`, `ADLoft`, `ADMaterial`, `ADObject`, `ADParameter`, `ADPart`, `ADPitch`, `ADSecure`, `ADSelection`, `ADSketch`, `ADTapped`, `ADTopology`, `ADUnits`, `ADView`, … (+148 more)

### `02_part_session.md`  —  Part Session & Design Session

**278 sections** covering: `IADBodies`, `IADBodies.Count`, `IADBodies.Enum`, `IADBodies.Item`, `IADBodies.Session`, `IADConfiguration`, `IADConfiguration.DesignSession`, `IADConfiguration.ID`, `IADConfiguration.Locks`, `IADConfiguration.Name`, `IADConfiguration.Type`, `IADConfigurations`, `IADConfigurations.AddConfiguration`, `IADConfigurations.Count`, `IADConfigurations.Enum`, `IADConfigurations.Item`, `IADDesign`, `IADGlobal`, `IADIG`, `IADPart`, `IDecomposedTransformData`, `IDecomposedTransformData.RotateAngle`, `IDecomposedTransformData.RotateVector`, `IDecomposedTransformData.RotateX`, `IDecomposedTransformData.RotateY`, `IDecomposedTransformData.RotateZ`, `IDecomposedTransformData.ScaleX`, `IDecomposedTransformData.ScaleY`, `IDecomposedTransformData.ScaleZ`, `IDecomposedTransformData.ShearXY`, … (+5 more)

### `03_features.md`  —  Part Features

**426 sections** covering: `IADAlongPathPatternFeature`, `IADAssembly`, `IADChamfer`, `IADCircularPatternFeature`, `IADCircularTopologyPatternFeature`, `IADConstantRadiusFilletFeatureEx`, `IADDelete`, `IADDesign`, `IADDraft`, `IADExternal`, `IADExtrusion`, `IADFillet`, `IADHelical`, `IADHole`, `IADImport`, `IADLinearPatternFeature`, `IADLinearTopologyPatternFeature`, `IADLoft`, `IADMesh`, `IADMirror`, `IADMove`, `IADOffset`, `IADPart`, `IADPattern`, `IADProject`, `IADRemove`, `IADRevolution`, `IADSM`, `IADScale`, `IADShell`, `IADSweep`, `IADTapped`, `IADThicken`, `IADThin`, `IADTrim`, `IADVariableRadiusFilletFeatureEx`, `IADVertex`, … (+1 more)

### `04_sketching_2d.md`  —  2D Sketching

**168 sections** covering: `IADComplex`, `IADComposite`, `IADSketch`, `IADSketch.Analyze`, `IADSketch.BeginChange`, `IADSketch.BeginChangeEx`, `IADSketch.ConsumingFeature`, `IADSketch.Delete`, `IADSketch.Dimensions`, `IADSketch.EndChange`, `IADSketch.Figures`, `IADSketch.GetExtents`, `IADSketch.IsActive`, `IADSketch.IsClosed`, `IADSketch.IsConsumed`, `IADSketch.IsSuppressed`, `IADSketch.Key`, `IADSketch.MapFromSketchToWorld`, `IADSketch.MapFromWorldToSketch`, `IADSketch.Name`, `IADSketch.OriginPoint`, `IADSketch.Root`, `IADSketch.Session`, `IADSketch.SketchConstraints`, `IADSketch.SketchPlane`, `IADSketch.SketchPlaneNormal`, `IADSketch.Type`, `IADSketches`, `IADSketches.AddSketch`, `IADSketches.Count`, … (+14 more)

### `05_sketching_3d.md`  —  3D Sketching

**97 sections** covering: `IAD3DSketch`, `IAD3DSketch.BeginChange`, `IAD3DSketch.ConsumingFeature`, `IAD3DSketch.Delete`, `IAD3DSketch.EndChange`, `IAD3DSketch.Figures`, `IAD3DSketch.IsActive`, `IAD3DSketch.IsConsumed`, `IAD3DSketch.IsSuppressed`, `IAD3DSketch.Key`, `IAD3DSketch.Name`, `IAD3DSketch.Root`, `IAD3DSketch.Session`, `IAD3DSketch.Type`, `IAD3DSketchBspline`, `IAD3DSketchBspline.EndPoint`, `IAD3DSketchBspline.GetData`, `IAD3DSketchBspline.GetDefinition`, `IAD3DSketchBspline.StartPoint`, `IAD3DSketchCircle`, `IAD3DSketchCircle.Center`, `IAD3DSketchCircle.Normal`, `IAD3DSketchCircle.Radius`, `IAD3DSketchCircularArc`, `IAD3DSketchCircularArc.Center`, `IAD3DSketchCircularArc.End`, `IAD3DSketchCircularArc.IncludedAngle`, `IAD3DSketchCircularArc.IsRightHandRule`, `IAD3DSketchCircularArc.Radius`, `IAD3DSketchCircularArc.Start`, … (+52 more)

### `06_geometry_brep.md`  —  Geometry & BRep Topology

**282 sections** covering: `IADBody`, `IADBody.Edges`, `IADBody.Faces`, `IADBody.Lumps`, `IADBody.Part`, `IADBody.Shells`, `IADBody.TimeStamp`, `IADBody.TopologySummary`, `IADBody.TopologyType`, `IADBody.Type`, `IADBody.Vertices`, `IADBspline`, `IADCircle`, `IADCircle.Axis`, `IADCircle.Center`, `IADCircle.Radius`, `IADCircular`, `IADCoedge`, `IADCoedge.Body`, `IADCoedge.Edge`, `IADCoedge.IsSenseReversed`, `IADCoedge.Loop`, `IADCoedge.Part`, `IADCoedge.PartnerCoedge`, `IADCoedge.TopologyType`, `IADCoedge.Type`, `IADCoedges`, `IADCoedges.Count`, `IADCoedges.Enum`, `IADCoedges.Item`, … (+156 more)

### `07_assembly.md`  —  Assembly, Occurrences & Constraints

**190 sections** covering: `IADAlign`, `IADAngle`, `IADAssembly`, `IADExploded`, `IADFastener`, `IADGear`, `IADInterference`, `IADInterference.GetExtents`, `IADInterference.InterferenceVolume`, `IADInterference.Part1`, `IADInterference.Part2`, `IADInterferences`, `IADInterferences.Count`, `IADInterferences.Enum`, `IADInterferences.Item`, `IADMate`, `IADOccurrence`, `IADOccurrence.ApplyTransform`, `IADOccurrence.Color`, `IADOccurrence.Configuration`, `IADOccurrence.DesignSession`, `IADOccurrence.GetExtents`, `IADOccurrence.GetMeshDataForSectionView`, `IADOccurrence.GetMeshDataForSectionViewEx`, `IADOccurrence.GetMeshDefinitionForSectionView`, `IADOccurrence.GetMeshDefinitionForSectionViewEx`, `IADOccurrence.IsAnchored`, `IADOccurrence.IsFlexible`, `IADOccurrence.IsHidden`, `IADOccurrence.IsSuppressed`, … (+29 more)

### `08_drawings.md`  —  Drawings, Sheets & BOM

**166 sections** covering: `ADAutoCADVersion`, `ADBO`, `IADBO`, `IADDimension`, `IADDimension.DimensionType`, `IADDimension.Parameter`, `IADDimension.Root`, `IADDimension.Session`, `IADDimension.Type`, `IADDimensions`, `IADDimensions.Count`, `IADDimensions.Enum`, `IADDimensions.Item`, `IADDimensions.PlaceDiametricDimension`, `IADDimensions.PlaceLinearDimension`, `IADDimensions.PlaceLinearDimension(IADSketchLine,`, `IADDimensions.PlaceLinearDimension(IADSketchPoint,`, `IADDimensions.PlaceRadialDimension`, `IADDimensions.Sketch`, `IADDrawing`, `IADSaved`, `IADSheet`, `IADSheet.CreateStandardViews`, `IADSheet.DissociatedDimensionCount`, `IADSheet.GetExtents`, `IADSheet.GetSheetSize`, `IADSheet.ModifySheetBlank`, `IADSheet.ModifySheetTemplate`, `IADSheet.Name`, `IADSheet.Root`, `IADSheet.Session`, … (+11 more)

### `09_parameters.md`  —  Parameters & Equations

**27 sections** covering: `IADParameter`, `IADParameter.Equation`, `IADParameter.ExternallyDriven`, `IADParameter.IsConflictingGlobal`, `IADParameter.IsMissingGlobal`, `IADParameter.Name`, `IADParameter.ParameterType`, `IADParameter.Remove`, `IADParameter.Root`, `IADParameter.SourceDocumentID`, `IADParameter.SourceItemID`, `IADParameter.Type`, `IADParameter.Units`, `IADParameter.Value`, `IADParameter.comment`, `IADParameters`, `IADParameters.CancelParameterTransaction`, `IADParameters.CloseParameterTransaction`, `IADParameters.Count`, `IADParameters.Enum`, `IADParameters.Item`, `IADParameters.NewParameter`, `IADParameters.OpenParameterTransaction`

### `10_pdm_repository.md`  —  PDM, Repository & File Operations

**446 sections** covering: `ADPD`, `IADFolder`, `IADFolder.ClearNotification`, `IADFolder.ClearNotificationToAll`, `IADFolder.ClearPermission`, `IADFolder.ClearPermissionToAll`, `IADFolder.Copy`, `IADFolder.CreateSubFolder`, `IADFolder.Delete`, `IADFolder.Deposit`, `IADFolder.FolderItems`, `IADFolder.IsAccessibleToRole`, `IADFolder.IsAccessibleToTeam`, `IADFolder.IsAccessibleToUser`, `IADFolder.IsRecycleBin`, `IADFolder.Move`, `IADFolder.Name`, `IADFolder.ParentFolder`, `IADFolder.Reference`, `IADFolder.Rename`, `IADFolder.Repository`, `IADFolder.Root`, `IADFolder.SubFolders`, `IADFolder.Type`, `IADFolder.setNotification`, `IADFolder.setPermission`, `IADFolders`, `IADFolders.Count`, `IADFolders.Enum`, `IADFolders.Item`, … (+37 more)

### `11_materials_users.md`  —  Materials, Users, Teams & Misc

**127 sections** covering: `IADAuto`, `IADData`, `IADMaterial`, `IADMaterial.Density`, `IADMaterial.Name`, `IADMaterial.Root`, `IADMaterial.Type`, `IADMaterial.getMaterialPropertyValue`, `IADMaterials`, `IADMaterials.Count`, `IADMaterials.Enum`, `IADMaterials.GetEnumerator`, `IADMaterials.Item`, `IADPrintability`, `IADTeam`, `IADTeam.AddMember`, `IADTeam.AddRole`, `IADTeam.AssigneRoleToMember`, `IADTeam.IsMember`, `IADTeam.Name`, `IADTeam.Remove`, `IADTeam.Roles`, `IADTeam.Root`, `IADTeam.TeamMembers`, `IADTeam.Type`, `IADTeams`, `IADTeams.Count`, `IADTeams.Enum`, `IADTeams.Item`, `IADUser`, … (+8 more)


---
*Generated by split_alibre_api.py — AlibreX Automation Type Library v29*
