# AlibreX API — Conceptual Guides & Overviews

> Part of the split AlibreX reference. See `00_index.md` for the full map.

**Sections in this file:** 12

---


# Introduction to Add-Ons

Introduction to Alibre Add-On Development

#### What is an Add-On?

An Add-On is any third party software that wants integration with Alibre.
This add-on gets launched from within Alibre when the end user wants to use
the third party product. This add-on can be of one of the following categories:

1. Complete stand-alone Add-On
2. Add-On using Alibre CAD data
3. Add-On completely integrated with Alibre

Depending on what your needs are, you can choose one of the above options.
The one common thing that is shared by all of them is that, the add-on is
always launched from within the running instance of Alibre. Depending on the add-on's
configuration, one can find that Add-on on Alibre's Home Window in 'Utilities' tab
under 'Add-ons...' or on the Part or Assembly workspace's Ribbon under 'Add-on' tab.
The add-on can be launched from here by clicking the add-on you want to launch.
The add-on infrastructure is based on Microsoft's COM
(Component Object Model) and .NET technologies. It is recommended to have a basic
knowledge of COM before creating new add-Ons. This infrastructure provides
the flexibility to code your add-on in one of many supported programming
languages (e.g. Visual C++, Visual Basic, C#). Having said
that, lets look at the add-on categories and other details of add-on development

#### Complete stand-alone Add-On

This is the simplest of the three types. When user clicks on the
add-on in the Home Window under 'Utilities -> Add-ons...', this launches the
Add-on (in a separate GUI if provided by the add-on or executes whatever the
add-on was created for). An example of this could be an add-on that just
opens a new Internet browser. It need not use any of the Alibre APIs if
it does not want to query or create any CAD data.

#### Add-On using Alibre CAD data

This is fundamentally similar to the above type. The main difference
being, though this also launches the add-on in a stand-alone mode it
uses Alibre APIs to query and/or create CAD data from Alibre. It can then uses this
CAD data to perform whatever task it has to.

#### Add-On completely integrated with Alibre

These types of add-ons are more involved from a programming point
of view, but on the other hand they give add-on creator the flexibility to
integrate the add-on completely within Alibre Design. By this it means

- The add-on can display its menu structure within Alibre Design's
  menubar and Ribbon in order to expose its user interface.
- A new tab window is created for the add-on within Alibre Design's
  Design Explorer. The Add-on can show its own controls in this tab's
  panel window.
- The add-on can display its graphics in Alibre Design's canvas.
- Also, the add-on gets notified of the various events such as
  keyboard and mouse events or the events such as when user selects a
  part or a face in Alibre.
- The add-on can save its own data in the Alibre file (part,
  assembly, drawing) as a separate data stream. This data can be loaded
  the next time the file is opened.

More details on programming such add-ons can be found in document
titled Integrated\_AddOns\_in\_Alibre Design.PDF

#### Under the Hood

On the programming side these three types of add-ons share one basic
infrastructure that is discussed below. If you want to create one of the
first two types of add-ons this is all that you need to read and you should
be ready to go!

Before getting into how Alibre recognizes the Add-on application and
how it loads the add-on applications lets start with how one can create an
add-on application. An add-on application is a simple dll
application that gets launched when Alibre is launched (and the pre-requisites,
that will be discussed in due course, are taken care of before hand).

To begin with, create a simple Win32 Dynamic Link Library (usually in
Visual Studio using VC++). In the main header file of the application, the
following are the functions that would be needed to create an add-on.

#### Three important functions

These are the prototypes of the main functions that need to be present
in any add-on application irrespective of its type.

1. ```
   void AddOnLoad (HWND windowHandle,
                   VOID *pAutomationHook,
                   VOID *reserved);
   ```
2. ```
   void AddOnInvoke (HWND windowHandle,
                     VOID *pAutomationHook,
                     LPCSTR sessionName,
                     BOOL isLicensed,
                     VOID *reserved1,
                     VOID *reserved2);
   ```
3. ```
   void AddOnUnload (HWND windowHandle,
                     BOOL forceUnload,
                     BOOL *cancel,       // set TRUE to cancel
                     VOID *reserved1,
                     VOID *reserved2);
   ```

#### AddOnLoad

As the name suggests this function this function gets called when
the end user launches Alibre.

#### Argument Descriptions:

| Parameter | Description |
| --- | --- |
| HWND windowHandle | This is a handle to the main window that is passed to the AddOn application on launch. |
| VOID \*pAutomationHook | This is the **most important** interface pointer as far as the add-on integration is concerned. As the name suggests this pointer is the hook into the Alibre running object. Anything and everything that needs to be queried from Alibre has to start from this pointer. For the first type of Add-On this would be insignificant as the add-on doesn't use the CAD data from Alibre or doesn't get connected to Alibre. |
| VOID \*reserved | This is a reserved parameter and should always be NULL. |

#### AddOnInvoke

This function is called when user selects the Add-On from the
Tools->Add-Ons menu either on the home window or from the an
open session.

#### Argument Descriptions:

| Parameter | Description |
| --- | --- |
| HWND windowHandle | Refer to AddOnLoad |
| VOID \*pAutomationHook | Refer to AddOnLoad |
| LPCSTR sessionName | If the Add-on is invoked from the Home window this parameter will be an empty string. But if the add-on is invoked from any of the open sessions, the name of that session is passed as a parameter to the function. |
| BOOL isLicensed | Depending upon whether the user has a valid license for the add-on this flag is set. Add-on developers can use this flag to allow or block the user from using the add-on. Or they can simply neglect it. |
| VOID \*reserved1 | This is a reserved parameter and should always be NULL. |
| VOID \*reserved2 | This is a reserved parameter and should always be NULL. |

#### AddOnUnload

The function is called when the users closes Alibre or when the
user unchecks the Add-On's entry in the Add-On Manager window.

#### Argument Descriptions:

| Parameter | Description |
| --- | --- |
| HWND windowHandle | Refer to AddOnLoad |
| BOOL forceUnload | This parameter will notify the Add-on if the Add-on is getting unloaded forcibly because of some unexpected failure or not. |
| BOOL \*cancel | This parameter can be changed by the add-on to notify Alibre whether to cancel unloading of the add-on or not. If returned true add-on will not be unloaded. The default value for this variable would be false. |
| VOID \*reserved1 | This is a reserved parameter and should always be NULL. |
| VOID \*reserved2 | This is a reserved parameter and should always be NULL. |

#### Integration Side:

For making Alibre aware of the presence of add-on and so that Alibre
can load the dll for the add-on there are some important guidelines that need
to be followed. This section deals with that integration aspect of the add-on.
It is required to have a basic knowledge of the windows registry and how to
create a key in the registry to understand the procedure completely.

Each add-on folder on the end-user’s machine will typically resemble
the following structure.

Main folder with name of the Add-On containing:

- [Add-On Name].adc (AddOn Configuration File)
- [Add-On Name].ico
- [Add-On Name].dll

#### ADC File

The .adc file is read when Alibre loads the add-on. This is just
an XML file with the extension .adc. This needs to
be created by the add-on developer. A typical .adc file is shown next.

```
<AlibreDesignAddOn specificationVersion="1" friendlyName="My AddOn">
   <Author name="MyName" link="http://URL"/>
   <DLL loadedWhen="Startup" location="MyAddOnName.dll"/>
   <Copyright> My CopyRight Information</Copyright>
   <Icon location="MyAddOn.ico"/> 
   <Menu text="My AddOn"/>
   <Description> XYZ </Description>
   <Workspace type="Part"/>
   <Property name="Identifier" value="{DA8322C2-CE32-450C-2E43-5CG77C52D4B4}"/>
</AlibreDesignAddOn>
```

#### <AlibreDesignAddOn>

|  |  |
| --- | --- |
| **specificationVersion** | You can update this as and when a newer version of the add-on is developed. |
| **FriendlyName** | This is just a friendly name for the add-on and not used anywhere else. |

#### <Author>

|  |  |
| --- | --- |
| **AuthorName** | Name of the owner of the Add-On. |
| **Link** | Link to website for the Add-On. |

#### <DLL>

|  |  |
| --- | --- |
| **Lodedwhen** | This tells Alibre when to load the Add-On dll. There are two options to specify i.e. StartUp or Invoke. This means the add-on will either be loaded when Alibre is launched or when user actually selects the Add-On from the Tools->Add-Ons menu. |
| **Location** | This specifies the location of the dll on the end user’s machine where the dll for this Add-on can be found. This is the responsibility of the Add-On developer to lay the dll file on the user’s machine on the same path as mentioned here. Though any path is valid as long as it exists its always good to have the dll in the same folder as .adc file. |

#### <AlibreDesignAddOn>

|  |  |
| --- | --- |
| **specificationVersion** | You can update this as and when a newer version of the add-on is developed. |
| **FriendlyName** | This is just a friendly name for the add-on and not used anywhere else. |

#### <Copyright>

Copyright information if any.

#### <Icon location>

Path of the icon file for the Add-On if any.

#### <Menu text>

Name of the Add-On as you want it to appear on the Alibre
menu.

#### <Description>

A brief description about what this add-on does.

#### <Workspace>

Type of the workspace for the Add-On. The available choices
are:

- Part
- SheetMetal
- Assembly
- Drawing
- Home
- Always
- Never

#### <Property>

|  |  |
| --- | --- |
| **name** | For this item, name should always be Identifier. |
| **value** | This is a unique identifier for the add-on. The number is a GUID (Globally Unique Identifier). This needs to be generated by the Add-on developer. |

#### ICO file

This file is the icon file created for the add-on. The path of
this file is provided in the adc file. This icon is shown beside the
Add-On name under the list of Add-Ons. It’s up to the Add-On developer
whether he/she wants to have an icon with the Add-On.

#### DLL File

This is the main Add-On dll file which is loaded at the time of
launch of Alibre or during the invoke of the Add-On (depending on what
the adc file contains). The path of the dll is also mentioned in the
adc file and it's the responsibility of the Add-On developer to have the
right path in the adc file and then have it laid at the right location
on the user’s machine.

#### Registration

For Alibre Design to be able to locate the presence of your
add-on installed on your computer, you should 'register' the
add-on in Windows System Registry as follows:

- Create the key 'Alibre Design Add-Ons' under
  'HKEY\_LOCAL\_MACHINE\SOFTWARE' if it does not already exist
- Under this key, add a new String Value. Set its name
  to your add-on's id (from add-on's .ADC file).
  Example: {DA8322C2-CE32-450C-2E43-5CG77C52D4B4}
- Set the Value Data to the Windows folder where the
  add-on's .ADC file resides.
  Example: C:\ProgramData\Alibre AddOns\MyAddOn



# General Properties

These interfaces permit some general interaction with Alibre Design.

#### General Properties

- Query the Version of the Alibre Design.
  (Version)
- Get the View Transform of the model
  (ViewTransform,
  IADTransformation)
- Create a new empty Part or Sheet Metal workspace
  (CreateEmptyPart(String, Boolean))
- Create a new empty Assembly workspace
  (CreateEmptyAssembly(String))
- Get Units
  - Length Model Units (ModelUnits)
  - Length Display Units (LengthDisplayUnits)
  - Angle Display Units (AngleDisplayUnits)
- Get\Set Part Number (Number),
  Part Description (Description)
- React to Alibre Design events
  (EventManager)
- Work with parameters and equations (IADParameter,
  IADParameters)
- Refer to topology or reference geometry in same or other workspace
  (IADTargetProxy)



# AlibreX Namespace

The AlibreX namespace contains all of the Alibre API.

#### Classes

|  | Class | Description |
| --- | --- | --- |
|  | AutomationHook | Alibre Design automation hook |
|  | EventManager | Alibre Automation Event Manager |

#### Interfaces

|  | Interface | Description |
| --- | --- | --- |
|  | DIEnum | DIEnum is an enumerator which can be used to get the contents of collection objects. |
|  | IAD2DPoint | IAD2DPoint represents a point in a 2D coordinate system. |
|  | IAD3DSketch | IAD3DSketch interface |
|  | IAD3DSketchBspline | This interface represents a B-Spline figure in the 3D sketching environment. |
|  | IAD3DSketchCircle | This interface represents a circle figure in the 3D sketching environment. |
|  | IAD3DSketchCircularArc | This interface represents a circular arc figure in the 3D sketching environment. |
|  | IAD3DSketchEllipse | This interface represents an ellipse figure in the 3D sketching environment. |
|  | IAD3DSketchEllipticArc | This interface represents an elliptic arc figure in the 3D sketching environment. |
|  | IAD3DSketches | IAD3DSketches interface |
|  | IAD3DSketchFigure | IAD3DSketchFigure is the interface for a 3D Sketch Figure object in a Part or Sheet Metal workspace. |
|  | IAD3DSketchFigures | IAD3DSketchFigures interface |
|  | IAD3DSketchLine | This interface represents a line figure in the 3D sketching environment. |
|  | IAD3DSketchPoint | This interface represents a point figure or node in the 3D sketching environment. |
|  | IADAddOns |  |
|  | IADAlignConstraint | IADAlignConstraint interface |
|  | IADAngleConstraint | IADAngleConstraint interface |
|  | IADAssemblyConstraint | IADAssemblyConstraint represents a single assembly constraint, which supports all the necessary and common functionalities of a constraint. |
|  | IADAssemblyConstraints | IADAssemblyConstraints represents a collection of all constraints in a particular assembly session. |
|  | IADAssemblyExtrusionFeature | This interface represents an assembly Extrude Cut feature. Extrusion features either create or remove material by extending a sketch in a linear direction by a specified distance. |
|  | IADAssemblyFeature | IADAssemblyFeature interface |
|  | IADAssemblyFeatures | IADAssemblyFeatures interface represents the collection of assembly features present in an assembly session. |
|  | IADAssemblyHoleFeature | This interface represents a Hole feature. Hole features are created by removing material to create one or more holes. A large number of parameters are available for specifying the details of the hole. The hole's thread information can be used in its callout in 2D Drawings. |
|  | IADAssemblyPath | IADAssemblyPath represents the path from the root assembly to the selected assembly. |
|  | IADAssemblySession | IADAssemblySession interface |
|  | IADAutoBrepImportSummary |  |
|  | IADBodies | This collection is needed for querying the model held by the design. This interface represents the collection of all the bodies held by the design. However, as per current architecture, the design holds only one solid body and hence this collection has only a single IADBody. |
|  | IADBody | This interface represents the Body in Alibre Design. This is the topmost level topological entity. |
|  | IADBOMColumn | IADBOMColumn interface |
|  | IADBOMColumns | IADBOMColumns interface |
|  | IADBOMRow | IADBOMRow interface |
|  | IADBOMRows | IADBOMRows interface |
|  | IADBOMTableSession | IADBOMTableSession interface |
|  | IADBsplineCurve | IADBsplineCurve interface represents a b-spline curve geometry and can be obtained by typecasting the Curve object which is of type AD\_BSPLINE. As all b-splines can be represented by NURBS, this interface returns all the data pertaining to NURBS. It is possible to check whether the spline is actually rational (NURBS) or non-rational, by checking the definition data which also returns a flag for rationality of the curve. In addition, the closed and planar properties of the curve can also be obtained. |
|  | IADBsplineSurface | IADBsplineSurface interface represents a b-spline surface geometry and can be obtained by typecasting the Surface object which is of type AD\_BSURF. A bspline surface is a b-spline curve swept along another b-spline curve. Thus a b-spline surface has two parametric directions represented as u and v. |
|  | IADChamferFeature | This interface represents an edge Chamfer Feature. Chamfer features create a beveled face on a selected edge or face. |
|  | IADCircle | IADCircle interface represents a circular curve geometry and can be obtained by typecasting the Curve Object which is of type AD\_CIRCLE. This interface defines a circle by the center point, radius and the normal unit vector perpendicular to the plane of the circle. |
|  | IADCircularArc | IADCircularArc interface represents a circular arc geometry and can be obtained by typecasting the Curve Object which is of type AD\_CIRCULAR\_ARC. In addition to the properties of the circle namely, center point, radius and unit normal vector, this interface gives the start and end point of the arc to uniquely locate the circular arc. |
|  | IADCoedge | This interface represents the Coedge in Alibre Design. A coedge records the occurrence of an edge in a loop of a face. The introduction of coedges permits edges to occur in one, two or more faces, and so makes possible the modeling of sheets and solids (manifold or not). A loop refers to one coedge in the loop, from which pointers lead to the other coedges of the loop. Coedges in a loop are ordered in a continuous path around the loop and are doubly-linked. If a loop is not a circular list, the loop points to the first coedge. |
|  | IADCoedges | This interface represents a collection of coedges. Loops from different faces may come together along a common coedge. That coedge represents the coincident edges, one from each face. |
|  | IADComplexSketchFigure | IADSketchShapePattern represents Shape or Shape Pattern sketch figures. In the GUI these are the figures under the Sketch->Shape menu. The shape has an underlying composite figure, which is a collection of the sketch figures which compose the shape. |
|  | IADCompositeFigure | IADCompositeFigure represents a collection of figures which compose an IADSketchShapePattern. These consituent figures can be any IADSketchFigure, including another IADSketchShapePattern. |
|  | IADCone | IADCone interface represents a conical surface geometry and can be obtained by typecasting the Surface Object which is of type AD\_CONE. The cone is defined by the axis, a point on the bottom circle of the cone, the radius, and the half angle at the top vertex. |
|  | IADConfiguration | IADConfiguration represents a single configuration in a design session. |
|  | IADConfigurations | IADConfigurations represents a collection of all configurations in a particular part, assembly or a sheetmetal part. |
|  | IADCurve | IADCurve represents the interface for a Curve object in a Part or Sheet Metal workspace. The geometry of an edge is a curve. This interface represents a generic curve and the specific curve can be obtained by typecasting this after checking the specific curve type. |
|  | IADCylinder | IADCylinder interface represents a cylindrical surface geometry and can be obtained by typecasting the Surface Object which is of type AD\_CYLINDER. The cylinder is defined by the axis, a point on the bottom circle of the cylinder and the radius. |
|  | IADDataFont | IADDataFont interface |
|  | IADDeleteLumpsFeature | IADDeleteLumpsFeature interface |
|  | IADDesignAxes | This interface represents a collection of IADDesignAxis. |
|  | IADDesignAxis | IADDesignAxis repesents the interface for a Design Axis object in a Design. |
|  | IADDesignBooleanFeature | IADDesignBooleanFeature interface |
|  | IADDesignMesh | IADDesignMesh represents the interface for a Design Mesh object in a Design. |
|  | IADDesignMeshes |  |
|  | IADDesignPlane | IADDesignPlane represents the interface for a Design Plane object in a Design. |
|  | IADDesignPlanes | IADDesignPlanes represents the interface for a Collection of Planes in the Design. |
|  | IADDesignPoint | IADDesignPoint represents the interface for a Design Point object in a Design. |
|  | IADDesignPoints | IADDesignPoints represent the interface for a Collection of Points in a Design. |
|  | IADDesignProperties | IADDesignProperties is an interface for properties that are associated with the workspace. These properties include display units, and file information for the design. |
|  | IADDesignSelectionFilter | IADDesignSelectionFilter provides an interface to change the active selection filters for a design session. |
|  | IADDesignSession | IADDesignSession interface |
|  | IADDesignSurface | IADDesignSurface is the interface for a Design Surface body in a Design. For example, if the user inserts a surface or surfaces into the Part design, each of those surface bodies is represented by an IADDesignSurface interface. This interface is similar to IADBody. While IADBody represents a body of the Part design, IADDesignSurface represents a surface body inserted into the Part design. |
|  | IADDesignSurfaces | IADDesignSurfaces is the interface for a collection of Surfaces in the Part workspace. |
|  | IADDimension | IADDimension represents a sketch dimension. |
|  | IADDimensions | IADDimensions represents a collection of a sketch's dimensions. |
|  | IADDraftFeature | This interface represents a Draft Feature. Draft Features create or remove material from a solid body by rotating faces outward or inward, respectively. |
|  | IADDrawingProperties | IADDrawingProperties is an interface for properties that are associated with the workspace. These properties include display units, and file information for the drawing. |
|  | IADDrawingSelectionFilter | IADDrawingSelectionFilter provides an interface to change the active selection filters for a Drawing session. |
|  | IADDrawingSession | IADDrawingSession interface |
|  | IADDrawingView | This interface represents a drawing view. |
|  | IADDrawingViews | This interface represents the collection of all the views in a Drawing sheet. |
|  | IADEdge | This interface represents the Edge in Alibre Design. An edge is the topology associated with a curve. An edge is bounded by one or more vertices, referring to one vertex at each end. |
|  | IADEdges | This interface represents the collection of edges. An edge is the topology associated with a curve. An edge is bounded by one or more vertices, referring to one vertex at each end. |
|  | IADEllipse | IADEllipse interface represents an elliptical curve geometry and can be obtained by typecasting the Curve Object which is of type AD\_ELLIPSE. This interface defines an ellipse by its center, a unit normal vector, a major-axis vector, and a double specifying the eccentricity ratio of the ellipse. |
|  | IADEllipticalArc | IADEllipticalArc interface represents an elliptical arc geometry and can be obtained by typecasting the Curve Object which is of type AD\_ELLIPTICAL\_ARC. This interface defines an elliptical arc by its center, a unit normal vector, a major-axis vector, and a double specifying the eccentricity ratio of the ellipse and the start and the end points of the arc. |
|  | IADEventsCallback | Automation event callback interface for Alibre Design. |
|  | IADExplodedView | IADExplodedView represents an exploded view of an assembly, which can subsequently be used as views in drawings. Exploded views affect the display only, constraints are not modified. |
|  | IADExplodedViews | IADExplodedViews represents the collection of Exploded Views that can be obtained from an IADAssemblySession by querying its ExplodedViews property. |
|  | IADExplodedViewStep | IADExplodedViewStep represents a single step of an exploded view of an assembly. Each step is composed of one or more occurrence with one or more transformation applied to make up the segments of the step. Each step will move a part from its initial position to its exploded position or from its exploded position to its initial position. |
|  | IADExplodedViewSteps | IADExplodedViewSteps represents the collection of exploded view steps that make up a particular exploded view. You can get these steps by querying the exploded view's ExplodedViewSteps property. |
|  | IADExternalThreadFeature | This interface represents an External Thread feature. External Thread features create a basic representation of a thread on an existing cylindrical solid model. |
|  | IADExtrusionFeature | This interface represents an Extrude Boss or Cut feature. Extrusion features either create or remove material by extending a sketch in a linear direction by a specified distance. |
|  | IADFace | This interface represents the Face in Alibre Design. A Face represents a bounded portion of the surface and is the 2D analogue for the body. |
|  | IADFaces | This interface represents the collection of faces. A face is a bounded portion of single surface. |
|  | IADFastenerConstraint | IADFastenerConstraint interface |
|  | IADFilletFeature | This interface represents a Fillet feature. |
|  | IADFolder | IADFolder interface. This interface is obsolete as of V11 of Alibre Design. |
|  | IADFolderItem | IADFolderItem interface. This interface is obsolete as of V11 of Alibre Design. |
|  | IADFolderItems | IADFolderItems Interface. This interface is obsolete as of V11 of Alibre Design. |
|  | IADFolders | IADFolders Interface. This interface is obsolete as of V11 of Alibre Design. |
|  | IADGearConstraint | IADGearConstraint interface |
|  | IADGeometryFactory | IADGeometryFactory allows for the creation of points, vectors, and transformations, which can be passed as arguments to other methods in the Alibre API. |
|  | IADGlobalParameterSession | IADGlobalParameterSession interface represents an instance of a Global Parameters workspace. |
|  | IADHelicalFeature | This interface represents a Helical Boss or Cut feature. Helical features, often referred to as helixes, either create or remove material by automatically sweeping a cross section, represented by a sketch, along a helical path. The helical path is automatically created by the software and is driven by user specified parameters. |
|  | IADHoleFeature | This interface represents a Hole feature. Hole features are created by removing material to create one or more holes. A large number of parameters are available for specifying the details of the hole. The hole's thread information can be used in its callout in 2D Drawings. |
|  | IADIGESOptions | IADIGESOptions represents the IGES File Type options that are available in the Options dialog in the Alibre Design GUI. Setting the properties on this interface will change the setting for these options. Currently, only the Write section of the IGES options is supported by the API. |
|  | IADImportFileFeature | IADImportFileFeature interface |
|  | IADInterference | IADInterference interface |
|  | IADInterferences | IADInterferences interface |
|  | IADLine | IADLine interface represents the straight line geometry and can be obtained by typecasting the Curve object which is of type AD\_LINE. This interface defines the line as a start point and a vector denoting the length and direction of the line. Using this data it is possible to find the end point of the line. |
|  | IADLoftFeature | This interface represents a Loft Feature. |
|  | IADLoop | This interface represents the Loop in Alibre Design. A loop represents a connected portion of the boundary of a face. It consists of a set of coedges linked in a doubly-linked chain which may be circular or open-ended. |
|  | IADLoops | This interface represents the collection of all the loops. A loop represents a connected portion of the boundary of a face. It consists of a set of coedges linked in a doubly-linked chain which may be circular or open-ended. |
|  | IADLump | This interface represents the Lump in Alibre Design. This is the second level topological entity. A lump represents a collection of bounded, connected region in space. A Body can have zero, one, or more lumps. |
|  | IADLumps | This interface represents the collection of all the lumps in a Body. A lump represents a collection of connected region in space. A Body can have zero, one, two or more lumps. |
|  | IADMateConstraint | IADMateConstraint interface |
|  | IADMaterial | IADMaterial represents the interface for a Material object in the Material library. |
|  | IADMaterialLibraries | IADMaterialLibraries represents the interface for a Collection of Material Library. |
|  | IADMaterialLibrary | IADMaterialLibrary represents the interface for a Library object in the Material library. |
|  | IADMaterialLibraryFolder | IADMaterialLibraryFolder represents the interface for a Folder in the Material Library. |
|  | IADMaterialLibraryFolders | IADMaterialLibraryFolders represents the interface for a Collection of Folders in the Material Library. |
|  | IADMaterials | IADMaterials represents the interface for a Collection of Materials in the Material Library. |
|  | IADMeshBooleanFeature | IAMeshBooleanFeature interface |
|  | IADMirrorFeature | IADMirrorFeature interface |
|  | IADMoveFaceFeature | This interface represents a Move Face feature. |
|  | IADOccurrence | IADOccurrence interface |
|  | IADOccurrences | IADOccurrences interface |
|  | IADOffsetFaceFeature | This interface represents an Offset Face feature. This feature offsets selected faces of a solid model by a specified distance. |
|  | IADOrientConstraint | IADOrientConstraint interface |
|  | IADParameter | IADParameter interface |
|  | IADParameters | IADParameters Interface |
|  | IADPartFeature | IADPartFeature interface |
|  | IADPartFeatures | IADPartFeatures interface |
|  | IADPartSession | IADPartSession interface |
|  | IADPatternFeature | IADPatternFeature interface |
|  | IADPDMClass | IADPDMClass provides access to an Class item. |
|  | IADPDMClassDataItem | IADPDMClassDataItem provides access to an Class Data item. |
|  | IADPDMClassDataItems | IADPDMClassDataItems provides access to the Class Data items. |
|  | IADPDMClasses | IADPDMClasses provides access to the Class items. |
|  | IADPDMFileItem | IADPDMFileItem provides access to a file item. |
|  | IADPDMFileItems | IADPDMFileItems provides access to a collecion of file items. |
|  | IADPDMFolder | IADPDMFolder provides access to a folder. |
|  | IADPDMFolders | IADPDMFolders provides access to the collection of folder items. |
|  | IADPDMProperties | IADPDMProperties provides access to the item properties. |
|  | IADPDMProperty | IADPDMProperty provides access to a property item. |
|  | IADPDMPropertyDefinition | IADPDMPropertyDefinition provides access to a Property Definition. |
|  | IADPDMPropertyDefinitions | IADPDMPropertyDefinitions provides access to the Property Definition items. |
|  | IADPDMSafe | IADPDMSafe provides access to various items in the PDM Safe. |
|  | IADPDMSafeLibraries | IADPDMSafeLibraries represents the libraries item in the PDM Safe. |
|  | IADPDMSafeLibrary | IADPDMSafeLibrary represents an library item in the PDM Safe. |
|  | IADPDMSafeProject | IADPDMSafeProject represents an project item in the PDM Safe. |
|  | IADPDMSafeProjects | IADPDMSafeProjects represents the projects item in the PDM Safe. |
|  | IADPDMSafeRecycleBin | IADPDMSafeRecycleBin provides access to the items under the Recycle Bin. |
|  | IADPDMSafes | IADPDMSafes represents the Active Safes in the PDM Server. |
|  | IADPDMServerConnection | This interface provides access to various Safes in a PDM Server. |
|  | IADPDMTaskCallback | IADPDMTaskCallback provides callback for a Task. |
|  | IADPDMTemplate | IADPDMTemplate provides access to an template item. |
|  | IADPDMTemplateLevel | IADPDMTemplateLevel provides access to a level item in a template. |
|  | IADPDMTemplateLevels | IADPDMTemplateLevels provides access to the template levels. |
|  | IADPDMTemplates | IADPDMTemplates provides access to the template items. |
|  | IADPDMVersionFileItem | IADPDMVersionFileItem provides access to a particular version of an file item. |
|  | IADPDMVersionFileItems | IADPDMVersionFileItems provides access to the older versions of file items. |
|  | IADPhysicalProperties | IADPhysicalProperties is an interface for physical properties that are associated with the design. These properties include the Number of faces, Number of edges, Number of vertices, Volume, Mass, Center of mass, etc., of the design. |
|  | IADPlane | IADPlane interface represents a planar surface geometry, which can be obtained by typecasting a Surface object which is of type AD\_PLANE. |
|  | IADPoint | This interface represents a point in the 3-dimensional space and is obtained by getting the geometry of a vertex. Note that this point is different from the reference geometry IADDesignPoint. In contrast to the DesignPoint, the object for this interface cannot be created stand alone and can only be obtained from geometry of a topology. This interface defines the point by the x, y and z coordinates. |
|  | IADPrintabilityCheckResults | IADPrintabilityCheckResults is an interface for printability checked result that are associated with the design. This interface is obsolete as of v2018.1 of Alibre Design. |
|  | IADProjectFeature | This interface represents a Project feature. Project features either create or remove material. |
|  | IADRackConstraint | IADRackConstraint interface |
|  | IADRemoveFaceFeature | IADRemoveFaceFeature interface |
|  | IADRepositories | IADRepositories Interface. This interface is obsolete as of V11 of Alibre Design. |
|  | IADRepository | IADRepository interface. This interface is obsolete as of V11 of Alibre Design. |
|  | IADRevolutionFeature | This interface represents a Revolution Feature. |
|  | IADRoot | The root object of the automation hierarchy. |
|  | IADSavedView | IADSavedView represents a saved view of a design session; also known as an orientation. A saved view can be a predefined view such as "Front (XY)" or a custom user-created view of the design. |
|  | IADSavedViews | IADSavedViews represents the collection of pre-defined and user-created views for a design session. The views in this collection mirror the list in the Orientations window of the Alibre GUI. You can get this collection by querying the SavedViews property of IADDesignSession. |
|  | IADScaleFeature | This interface represents a Scale Feature. A Scale Feature increases or decreases the size of a part. |
|  | IADScrewConstraint | IADScrewConstraint interface |
|  | IADSession | IADSession interface |
|  | IADSessions | IADSessions represents the collection of all open sessions in Alibre Design. |
|  | IADSheet | This interface represents a drawing sheet. |
|  | IADSheets | This interface represents the collection of all the sheets in a Drawing session. |
|  | IADShell | This interface represents the Shell in Alibre Design. A shell is an entire connected set of faces and/or wires, including connections through a non-manifold vertex. Typically, a body with a cavity inside has multiple shells. Hence, shells can represent absence of matter in addition to representing presence of matter. |
|  | IADShellFeature | This interface represents a Shell Feature. The Shell feature operation creates a walled model from a solid model. |
|  | IADShells | This interface represents the collection of all the shells in a Body/Lump. A shell is an entire connected set of faces and/or wires, including connections through a non-manifold vertex. Faces are connected together along common edges or at common vertices; wires may be connected to faces at end vertices. |
|  | IADSketch | IADSketch represents the interface for a Sketch object in a Part or Sheet Metal workspace. |
|  | IADSketchBspline | This interface represents a 2D Bspline curve in the Sketching environment. |
|  | IADSketchCircle | This interface represents a 2D Circular Figure in the sketching environment. |
|  | IADSketchCircularArc | This interface represents a 2D Circular Arc in the sketching environment. |
|  | IADSketchConstraint | IADSketchConstraint represents a sketch constraint. |
|  | IADSketchConstraints | IADSketchConstraints represents a collection of a sketch's cosntraints. |
|  | IADSketchEllipse | This interface represents a 2D Elliptical Figure in the sketching environment. |
|  | IADSketchEllipticArc | This interface represents a 2D Elliptical Arc Figure in the sketching environment. |
|  | IADSketches | IADSketches represents interface for a collection of Sketch objects. |
|  | IADSketchFigure | IADSketchFigure is the interface for a Sketch Figure object in a Part or Sheet Metal workspace. |
|  | IADSketchFigures | This interface represents a collection of Sketch Figure objects. |
|  | IADSketchLine | This interface represents the 2D Line Figure in the sketching environment. |
|  | IADSketchPoint | This interface represents 2D Point figure in a sketching environment. |
|  | IADSketchShapePattern | IADSketchShapePattern represents Shape or Shape Pattern sketch figures. In the GUI these are the figures under the Sketch->Shape menu. The shape has an underlying composite figure, which is a collection of the sketch figures which compose the shape. |
|  | IADSketchText | IADSketchShapePattern represents Shape or Shape Pattern sketch figures. In the GUI these are the figures under the Sketch->Shape menu. The shape has an underlying composite figure, which is a collection of the sketch figures which compose the shape. |
|  | IADSMClosedCornerFeature | IADSMClosedCornerFeature interface |
|  | IADSMCornerChamferFeature | IADSMCornerChamferFeature interface |
|  | IADSMCornerRoundFeature | IADSMCornerRoundFeature interface |
|  | IADSMDimpleFeature | IADSMDimpleFeature interface |
|  | IADSMFlangeFeature | IADSMFlangeFeature interface |
|  | IADSMPunchFeature | IADSMPunchFeature interface |
|  | IADSMRebendFeature | IADSMRebendFeature interface |
|  | IADSMTabFeature | IADSMTabFeature interface |
|  | IADSMUnbendFeature | IADSMUnbendFeature interface |
|  | IADSphere | IADSphere interface represents a spherical surface geometry and can be obtained by typecasting the Surface Object which is of type AD\_SPHERE. A sphere is defined by the center and the radius. |
|  | IADSurface | IADSurface represents the interface for a Surface object in a Part or Sheet Metal workspace. The geometry of a face is a surface. This interface represents a generic surface and the specific surface can be obtained by typecasting this after checking the specific surface type. |
|  | IADSweepFeature | This interface represents a Sweep Feature. |
|  | IADTangentInsideConstraint | IADTangentInsideConstraint interface |
|  | IADTangentOutsideConstraint | IADTangentOutsideConstraint interface |
|  | IADTappedThreadInfo | IADTappedThreadInfo represents the specifications of a thread for a Hole feature. You can get this information about an existing hole feature by querying its TappedThread property. An IADTappedThreadInfo object can also be created using the CreateTappedThreadInfo method, which can then be passed to one of the Hole feature creation methods on IADPartFeatures to create a hole using that tapped thread. |
|  | IADTargetProxy | IADTargetProxy represents a wrapper to a specific elemental object. This wrapper wraps the "native object" (called target) and the Occurrence to which this target belongs. The target retrieved from this Proxy will be in the local space of the Occurrence, where it naturally lives. The Client should look upon this Proxy object as the instance of the target as seen in this Occurrence. |
|  | IADTeam | IADTeam interface. This interface is obsolete as of V11 of Alibre Design. |
|  | IADTeamRole | IADTeamRole interface. This interface is obsolete as of V11 of Alibre Design. |
|  | IADTeamRoles | IADTeamRoles interface. This interface is obsolete as of V11 of Alibre Design. |
|  | IADTeams | IADTeams interface. This interface is obsolete as of V11 of Alibre Design. |
|  | IADThickenSurfaceFeature | IADThickenSurfaceFeature interface |
|  | IADThinWallExtrusionFeature | IADThinWallExtrusionFeature interface |
|  | IADThinWallRevolutionFeature | IADThinWallRevolutionFeature interface |
|  | IADThinWallSweepFeature | IADThinWallSweepFeature interface |
|  | IADTopologySummary | IADTopologySummary is an interface for a summary of the topological properties associated with an object. These properties include the number of faces, edges, vertices, lumps, shells, coedges, and loops. |
|  | IADTorus | IADTorus interface represents a toroidal surface geometry and can be obtained by typecasting the Surface Object which is of type AD\_TORUS. A torus is defined as a circular spine and a circular cross-section at each point on the spine. |
|  | IADTransformation | The IADTransformation interface represents a general 3D affine homogeneous transformation (e.g. a rotation and a translation). This interface is used for getting the view transformation of a session, specifying the transformation of a part being inserted into an assembly, getting the transformation of Occurrences, etc. Internally, the transform is stored as a 4 X 4 matrix. |
|  | IADTrimModelFeature | IADTrimModelFeature interface |
|  | IADUser | IADUser interface. This interface is obsolete as of V11 of Alibre Design. |
|  | IADUsers | IADUsers interface. This interface is obsolete as of V11 of Alibre Design. |
|  | IADVaultInfo | The Alibre Vault information class. |
|  | IADVector | IADVector interface represents a vector in 3-dimensional space. This interface defines a vector by its x, y and z components. |
|  | IADVertex | This interface represents the Vertex in Alibre Design. A vertex is the corner of either a face or a wire. Vertex refers to a point in object space and to the edges that it bounds. |
|  | IADVertexChamferFeature | This interface represents a vertex Chamfer Feature. Vertex Chamfer features create a beveled face on selected vertices. |
|  | IADVertices | This interface represents the collection of vertices. A vertex is the corner of either a face or a wire. Vertex refers to a point in object space and to the edges that it bounds. |
|  | IADWrapFeature | This interface represents a Wrap feature. Wrap features either create or remove material. |
|  | IAnalyzedSketchData | IAnalyzedSketchData represents the results of an analysis of a 2D sketch for possible errors. These errors are things which could cause a feature created with the sketch to fail. To get this information for a sketch, use that sketch's Analyze method. |
|  | IAutomationHook | IAutomationHook interface |
|  | IDecomposedTransformData | IDecomposedTransformData contains properties for querying the components of a transformation without directly working with the transformation matrix. You can get decomposed transformation data for any IADTransformation by calling its Decompose method. |
|  | INotificationSelector | INotificationSelector interface. This interface is obsolete as of V11 of Alibre Design. |
|  | IObjectCollector | The IObjectCollector interface represents a collection object. Several Methods in the Alibre Automation Type Library take a list of values or elements as collections, and several Properties return such lists. A new collection can be created by calling IADRoot.NewObjectCollector, and adding the desired elements to the newly created collection. Then that collection can be passed to Methods. |
|  | IPermissionSelector | IPermissionSelector interface. This interface is obsolete as of V11 of Alibre Design. |
|  | ISketchDegenerateFigure | ISketchDegenerateFigure interface |
|  | ISketchFigureDisjointEnd | ISketchFigureDisjointEnd interface |
|  | ISketchFigureIntersection | ISketchFigureIntersection interface |
|  | ISketchFigureOpenLoop | ISketchFigureOpenLoop interface |
|  | ISketchFigureOverlap | ISketchFigureOverlap interface |

#### Delegates

|  | Delegate | Description |
| --- | --- | --- |
|  | EventManagerInitializeHandler |  |
|  | EventManagerSessionChangeHandler |  |
|  | EventManagerSessionCloseHandler |  |
|  | EventManagerSessionLoadCompleteHandler |  |
|  | EventManagerSessionOpenHandler |  |
|  | EventManagerTerminateHandler |  |

#### Enumerations

|  | Enumeration | Description |
| --- | --- | --- |
|  | ADAccuracySetting | This enumeration describes different levels of precision which can be used to calculate the physical properties of a design with the method PhsyicalProperties. |
|  | ADAssemblyConstraintBoundType | This enumeration identifies the different types of Assembly constraint bounds. |
|  | ADAssemblyConstraintParameterRole | This enumeration identifies the different roles a parameter may play in an Assembly constraints. The enum can be use to obtained the parameter which plays the roll for a particular constraint. ParameterEx property. |
|  | ADAssemblyConstraintType | This enumeration identifies the different types of Assembly constraints. This information can be obtained for a constraint by querying its ConstraintType property. |
|  | ADAssemblyFeatureType | This enumeration describes the different types of Features available in an Assembly. By querying the FeatureType property of IADAssemblyFeature, you can which derived type to cast it to, which will have additional methods and properties to query the feature. |
|  | ADBOMDataType |  |
|  | ADBOMTableStyle |  |
|  | ADBOMTextAlignment |  |
|  | ADBooleanOperator |  |
|  | ADConfigurationLockType |  |
|  | ADDesignGeometryType | This enumeration is used to describe how design geometry geometry (IADDesignPlane, IADDesignAxis, IADDesignPoint) was created. This information can be used to determine what parameters or source objects to query to find the definition of the design geometry. |
|  | ADDetailingOption | This enumeration allows specification of which drawing view detailing options to use during view creation. Use bitwise OR operations to specify any combination of the options. Detailing options which are not available for the design or view type which is being created will be ignored. |
|  | ADDimensionType |  |
|  | ADDirectionType | This enumeration identifies the different possible direction types for creating extrude boss or extrude cut features. |
|  | ADDrawingViewType | This enumeration identifies the different drawing view display modes. |
|  | ADEdgeChamferType |  |
|  | ADEntityPointRelation | This enumeration identifies the different possible spatial relationships between a point and a face. The PointOnFace method uses this enumeration as a return value. |
|  | ADEventChangeType |  |
|  | ADExtendedDesignProperty |  |
|  | ADFaceProcessingType |  |
|  | ADGeometryType |  |
|  | ADHelixConditionType | This enumeration describes the different start/end condition types available for Helical Boss/Cut features. |
|  | ADHelixType | This enumeration describes the different types of helices which are used to create Helical Features. The HelixType determines which parameters must be queried to find the definition of the helix. |
|  | ADHoleDepthCondition | An enumeration of possible depth conditions for Hole features, returned by their DepthConditionType property. This is also used by the Hole feature creation methods on IADPartFeatures. |
|  | ADHoleType | The ADHoleType enumeration identifies the different types of holes which a Hole Feature can create. You can get this for a hole feature by querying its HoleType property. |
|  | ADLoftGuideType | This enumeration identifies the different options available for guide curves in a Loft feature. |
|  | ADMaterialPropertyKey | This enumeration lists the possible sub types or derived types of a Alibre object. These types describe the property of the material. All the Material Properties are represented in SI unit. |
|  | ADObjectSubType | This enumeration lists the possible sub types or derived types of a Alibre object. In particular, this is used for the SessionType property. |
|  | ADObjectType |  |
|  | ADParameterType | This enumeration identifies the different types of parameters that an IADParameter can represent. These types describe what the value of the parameter represents, and also indicate what units are possible for the parameter. |
|  | ADPartFeatureEndCondition | This enumeration identifies different possible end conditions for a number of part features. |
|  | ADPartFeatureType | This enumeration describes the different types of Features available in a Part. By querying the FeatureType property of IADPartFeature, you can which derived type to cast it to, which will have additional methods and properties to query the feature. |
|  | ADPDMPropertyValueType | This enumeration describes the different types of user input in the Property Definition. |
|  | ADPitchType | This enumeration describes the different pitch types available for Helical Boss/Cut features. |
|  | ADSecureObjectType |  |
|  | ADSelectionFilterOption | This enumeration describes different options available for selection filters with more than an on/off setting. It is used by the Solid and Surface properties of IADDesignSelectionFilter. |
|  | ADSketchConstraintType |  |
|  | ADTappedThreadType |  |
|  | ADTopologyType | The ADTopologyType enumeration contains items for each of the different types of Topology objects in the Alibre API. Each object whose Type property returns AD\_TOPOLOGY also has a TopologyType property which returns a value from this enumeration. |
|  | ADUnits |  |
|  | ADViewOrientation | This enumeration identifies the different standard orientations which can be used to create Standard Views in drawings. |
|  | ADWrapFocusType | This enumeration describes the different types of focus used by Wrap Features. The FocusType controls how the sketch is wrapped.. |
|  | CustomError | An enumeration of custom error values that are used in exceptions. |
|  | StdError | The standard error enumeration. |



# Assemblies

The Occurrences collection can be obtained by using the
Occurrences
property on the IADOccurrence
interface. This method adds an occurrence to the ActiveOccurrence holding this
Occurrence collection. An active occurrence must be set, to which the Add method
will add an occurrence as per the input. By default the RootOccurrence will be
the active occurrence, any call to this method without setting the active occurrence
will add the Occurrence Item to the root occurrence.

It is possible to traverse the Assembly hierarchy. And, it is possible
to query data on each Part Instance (Occurrence) to get Color, Nest Level,
Transformation information, etc. The following interfaces permit creation of
Assemblies.

#### IADOccurrences

It is possible to add a new empty Part or new empty subassembly.
It is also possible to add an existing part or assembly by passing
IADDesignSession or a
Windows File-Path string.

#### IADOccurrence

The following are provided on the IADOccurrence interface.

- Get/Set Color, Transparency, Reflectivity on Occurrence.
- Get/Apply Transformation on Occurrence.
- Get/Set Hide Occurrence.
- Get/Set Anchored status of Occurrence.
- Get Persistent Key on Occurrence.

#### IADAssemblySession

- Get/Set Active Occurrence.

#### IADSession

BindKeyToItem(Array, ADObjectType)
is used to get the item associated with the Key. This, together with the
Key property on IADOccurrence
can be used to uniquely identify and remember the occurrences of an assembly.
This information is persistent and can be used across sessions.

Supporting interfaces:

- IADAssemblyPath

#### Assembly Constraints

We can query for Assembly constraints and the parts/subassemblies involved
in a constraint using the following:

#### IADAssemblySession.AssemblyConstraints

The AssemblyConstraints
Property gets constraints from Assembly Session.

#### IADAssemblyConstraints

This interface represents the collection of all constraints
in an assembly.

#### IADAssemblyConstraint

This interface represents a single assembly constraint, which
supports all the necessary and common functionalities of a constraint,
like the name of a constraint, participants involved in a constraint etc.

#### Checking for Interferences in Assemblies

It is also possible to check for Interferences in Assemblies using the
CheckInterference(Object, Object)
method provided on the IADAssemblySession Interface.



# Tips and Tricks

Alibre recommends a reading of the following topics:

#### Understanding Units

Each workspace in Alibre Design has a set of units associated with it.

- Model Units

  These are the internal units used to represent the model, and are
  never made visible to the user. For new workspaces, these are centimeters.
  For workspaces imported from other sources, these may be any of the other
  4 supported units (millimeters, inches, feet, meters).

  | Caution |
  | --- |
  | All properties and methods in the API use Model Units. |
- Length Display Units

  These are the units used to display lengths in the workspace.
  By default, these are inches for English systems, and millimeters for
  other locales. The user can override this to any of the 5 supported
  units (millimeters, centimeters, inches, feet, meters).
- Angle Display Units

  Internally, model angles are represented in radians, but are
  displayed in degrees by default. The user can override this back to
  radians.
- Parameter Units

  Each distance and angle parameter has its own units, separate
  from those defined in the model, and separate from other parameters.
- Mass Units

  Possible mass units are grams, kilograms, and poundmass.
- Length Unit Conversions

  1 cm = 10 mm

  1 ft = 304.8 mm

  1 in = 25.4 mm

  1 m = 1000 mm
- Angle Unit Conversion

  1 deg = 1.74532925199433E-02 rad
- Angle Unit Conversion

  1 g = 0.001 kg

  1 lbm = 0.453592374 kg

#### Making Your Program Work In Other Locales

If your program is to work in other locales, some things you take for
granted may no longer be true for those locales. In addition to using
different units, the names of some objects will be different. For example,
the X-Axis may be named Eje-X or
X-axel for other locales.

Instead of looking for primary reference geometry by name, you can
search for them by their properties.

```
Dim objPlane As AlibreX.IADDesignPlane
Dim objXYPlane As AlibreX.IADDesignPlane
Dim objYZPlane As AlibreX.IADDesignPlane
Dim objZXPlane As AlibreX.IADDesignPlane
Dim objAxis As AlibreX.IADDesignAxis
Dim objXAxis As AlibreX.IADDesignAxis
Dim objYAxis As AlibreX.IADDesignAxis
Dim objZAxis As AlibreX.IADDesignAxis
Dim objPoint1 As AlibreX.IADPoint
Dim objPoint2 As AlibreX.IADPoint

' assuming objDesign has already been obtained
For Each objPlane In objDesign.DesignPlanes
    If objPlane.PlaneType = ADDesignGeometryType.AD_PRIMARY_PLANE Then
        If objPlane.Normal.Z <> 0 Then
            Set objXYPlane = objPlane
        ElseIf objPlane.Normal.Y <> 0 Then
            Set objZXPlane = objPlane
        Else
            Set objYZPlane = objPlane
        End If
    End If
Next objPlane

For Each objAxis In objDesign.DesignAxes
    If objAxis.AxisType = ADDesignGeometryType.AD_PRIMARY_AXIS Then
        Call objAxis.GetGeometry(objPoint1, objPoint2)
        If objPoint1.X <> objPoint2.X Then
            Set objXAxis = objAxis
        ElseIf objPoint1.Y <> objPoint2.Y Then
            Set objYAxis = objAxis
        Else
            Set objZAxis = objAxis
        End If
    End If
Next objAxis
```

#### Checking the Alibre Design Version

Your program should check to see that it is working with the correct
version of Alibre Design. The API will grow over time adding more classes,
methods, and properties. If a program written for one version of the API
is run with an older version of Alibre Design, it may fail. It's a good
idea to add a check similar to this:

```
Dim intBuild As Integer
Dim strVersion As String

' assuming objRoot has already been obtained
strVersion = objRoot.Version  
intBuild = CInt(Mid(strVersion, InStrRev(strVersion, ",") + 1))
If intBuild < 8066 Then
    MsgBox "You have Alibre Design build " & intBuild & _
           ".  But this application needs 8066."
    End
End If
```

#### Understanding TargetProxy and Keys

In Alibre Design, it is possible to delete features on which other
features depend. Consider the following example, which attempts to learn
the axis of a revolution feature.

The objRevolve.Axis is an IADTargetProxy. This is a layer of abstraction
that permits modification of the actual target (axis or edge in this case)
without losing its relationship to dependent features. To determine what
type of object the Target actually is, use the late-bound Type property.
If the Type is AD\_TOPOLOGY, additionally use the late-bound TopologyType
property. Also note that the target need not belong to the same occurrence.
The IADTargetProxy also has an Occurrence which tells you which part or
subassembly contains the target (axis or edge). If Nothing, the target is
in the same Occurrence as the feature.

Faces, Edges, and Vertices have no names, and their numbers usually
will change when features are changed. To display the number of the edge
you have (valid only until the next feature change) you need to iterate
through the Edges collection and compare the Key of each edge with the Key
of the edge you have until you find the match. The Key is a variable-length
byte array and is best compared by treating it as a Unicode string.

| Note |
| --- |
| The code fragment below does not work if the revolution axis is an edge of a surface. The API does not support detailed queries on surfaces. |

```
Dim strAxis As String
Dim strOcc As String
Dim objAxis As AlibreX.IADDesignAxis
Dim objEdge As AlibreX.IADEdge
Dim intEdge As Integer
Dim objPart2 As AlibreX.IADPartSession
Dim objEdges As AlibreX.IADEdges

' assuming objRevolve and objPart have already been obtained

If objRevolve.Axis Is Nothing Then
    strAxis = "No axis"
Else
    If objRevolve.Axis.Occurrence Is Nothing Then
        strOcc = ""
    Else 
        strOcc = objRevolve.Axis.Occurrence.Name & ":"
    End If
    Select Case objRevolve.Axis.Target.Type ' Type is late-bound
        Case ADObjectType.AD_DESIGN_AXIS
            Set objAxis = objRevolve.Axis.Target
            strAxis = "About " & strOcc & objAxis.Name 
        Case ADObjectType.AD_TOPOLOGY
            Select Case objRevolve.Axis.Target.TopologyType
                        ' TopologyType is late-bound
                Case ADTopologyType.AD_EDGE
                    Set objEdge = objRevolve.Axis.Target
                    If objRevolve.Axis.Occurrence Is Nothing Then
                        Set objEdges = objPart.Bodies.Item(0).Edges
                    Else  ' we know this is a part because it has an edge
                        Set objPart2 = objRevolve.Axis.Occurrence.DesignSession
                        Set objEdges = objPart2.Bodies.Item(0).Edges
                    End If
                    For intEdge = 1 To objEdges.Count
                        ' only 1 solid body in a part
                        If StrConv(objEdges.Item(intEdge - 1).Key, vbUnicode) = StrConv(objEdge.Key, vbUnicode) Then
                            strAxis = "About " & strOcc & "Edge<" & intEdge & ">"
                        End If ' assumes feature creating edge not suppressed
                    Next
                Case Else
                    strAxis = "Unknown axis topology"
            End Select
        Case Else
            strAxis = "Unknown axis"
    End Select
End If
```

#### Alibre Design Registry Keys

If you want your program to launch Alibre Design, as if launched from
the Start Menu, it needs to launch the program "Alibre Design.exe" which is found
in the "Program" folder of the folder stored in the HomeDirectory in the key
HKEY\_LOCAL\_MACHINE\SOFTWARE\Alibre, Inc.\Alibre Design.

One way to obtain a registry value (using a reference to Windows
Script Host Object Model) is shown below:

```
Dim objShell As WshShell
Dim strInstallPath As String
Set objShell = New WshShell
strInstallPath = objShell.RegRead("HKEY_LOCAL_MACHINE\Software\" & _
                 & "Alibre, Inc.\Alibre Design\HomeDirectory")
```



# Reference Geometry

Reference geometry consists of plane, axis, and point features that are
primarily used to aid solid feature construction. These interfaces permit
creation of planes, axes, and points. Reference geometry also includes
inserted surfaces.

#### Planes

- It is possible to get the Planes collection
  (IADDesignPlanes) by
  querying for property DesignPlanes
  on IADDesignSession.
  This gives a collection of all the Planes existing in the Design.
- Three built-in objects to represent XY-Plane, YZ-Plane, and
  ZX-Plane are provided. These three objects will be the first three items
  in the Planes collection.
- It is possible to create a new Plane
  (IADDesignPlane) by
  using either these built-in planes or any planes created by him. The
  following three different ways are provided to create a new Plane:
  1. At an Angle to a given existing Plane
     (CreateAtAngleToPlane(IADOccurrence, Object, IADOccurrence, Object, Object, String))
  2. At an Offset to a given Plane
     (CreateAtOffsetToPlane(IADOccurrence, Object, Object, String))
  3. Using three 3 Points
     (CreateBy3Points(IADOccurrence, Object, IADOccurrence, Object, IADOccurrence, Object, String))
- It is possible to delete any reference geometry that is not
  built-in.
- It is possible to query the reference geometry properties.

#### Axes

- It is possible to get the Axes collection
  (IADDesignAxes) by
  querying for property DesignAxes
  on IADDesignSession.
  This gives a collection of all the Axes existing in the Design.
- Three built-in objects to represent X-Axis, Y-Axis, and Z-Axis
  are provided. These three objects will be the first three items in the
  Axes collection.
- It is possible to create a new Axis
  (IADDesignAxis).
  The following three different ways are provided to create a new Axis:
  1. Using two existing Planes
     (CreateBy2Planes(IADOccurrence, Object, IADOccurrence, Object, String))
  2. Using two existing Points
     (CreateBy2Points(IADOccurrence, Object, IADOccurrence, Object, String))
  3. Using a cylindrical Face
     (CreateFromCylindricalFace(IADOccurrence, IADFace, String))
- It is possible to delete any reference geometry that is not
  built-in.
- It is possible to query the reference geometry properties.

#### Points

- It is possible to get the Points collection
  (IADDesignPoints) by
  querying for property DesignPoints
  on IADDesignSession.
  This gives a collection of all the Points existing in the Design.
- One built-in object to represent Origin is provided. This
  object will be the first item in the Points collection.
- It is possible to create a new Point
  (IADDesignPoint) by
  using either built-in point or any points created by him. The following
  three different ways are provided to create a new Axis:
  1. By giving the actual X, Y, Z location
     (CreatePoint(Double, Double, Double, String))
  2. Using a cylindrical Edge
     (CreatePointFromCircularEdge(IADOccurrence, IADEdge, String))
- It is possible to delete any reference geometry that is not
  built-in.
- It is possible to query the reference geometry properties.

#### Surfaces

- It is possible to get the Surfaces collection
  (IADDesignSurfaces)
  by querying for property
  DesignSurfaces
  on IADPartSession.
  This gives a collection of all the Surfaces existing in the Part.
- It is possible to insert a new Surface
  (IADDesignSurface)
  from a file (InsertFromFile(String, ADFaceProcessingType, Boolean, Boolean, ADUnits))



# Side-by-side Installations of Alibre Design and API

We disucss here the impact of side-by-side installations of Alibre Design versions on API programs.

Alibre Design V25 and later versions can be installed side by
side. However, importantly, only one of the installed versions of Alibre Design
can register its AlibreX API types to the Windows
registry. This is usually the very last version that was installed on the computer.
This can have consequences for API and add-on programs
installed on that computer.

Additionally, starting with V25, Alibre Design
will not register its private COM classes in the Windows registry.
The consequence of this is that API programs that drive Alibre Design in
GUI-less or head-less mode will not work properly unless these private COM
classes are manually registered by the user.

This topic provides information on how to address these issues.

*NOTE: You will need administrator privileges to perform the steps listed below.*

#### What to do after installing a side-by-side version of Alibre Design

API and add-on programs will automatically target the last installed
version of Alibre Design. If you want to target another version of
that is installed on this computer, follow the steps below

1. From the Windows Start menu or Desktop, launch the desired version
   of Alibre Design as Administrator. Running as administrator will result in
   the AlibreX types of that version to get registered into Windows Registry
2. After the Home Window is displayed, you can close Alibre Design. At this
   point, the API programs you run on your machine will target this
   version of Alibre Design

#### What to do after uninstalling a side-by-side version of Alibre Design

Uninstalling a version of Alibre Design that is currently insalled on your computer
is likely to remove entries related to AlibreX from Windows registry. This may
cause your API and add-on programs to malfunction. To avoid this, manually register
the AlibreX of the version of Alibre Design that you want the API to target

1. From the Windows Start menu or Desktop, launch the desired version
   of Alibre Design as Administrator. Running as administrator will result in
   the AlibreX types of that version to get registered into Windows Registry
2. After the Home Window is displayed, you can close Alibre Design. At this
   point, the API programs you run on your machine will target this
   version of Alibre Design

#### What to do in order to get GUI-less (head-less) API programs to work

Starting V25, API programs that drive Alibre Design in GUI-less mode will not
work unless some private COM DLLs in Alibre Design are explicitly registered into
Windows registry. This has be done manually by running a BAT file as follows:

1. On Windows Explorer, navigate to the 'Program' subfolder under the
   installation folder of the Alibre Design version you want to target
2. Locate the file named 'registerCOMdlls.BAT' in this sub-folder
3. Right click on this BAT file and select 'Run as adminsitrator' item
   from the context menu. This will register the required COM DLLs needed for
   Alibre Design to be executed in GUI-less mode

IMPORTANT: You may also have to follow the above steps anytime you
install or uninstall a version of Aliber Design on your computer. This will
ensure that you have registered the correct COM and AlibreX classes that target
the desired version of Alibre Design that is present on your computer.



# Sketching

A sketch is a non-solid feature made up of one or more figures and aids
in the creation of solid features. These interfaces permit creation of various
figures in 2D sketches. 3D sketching is not yet supported in the API.

#### Sketching

- It is possible to get the Sketches collection
  (IADSketches) by
  querying the property Sketches
  on IADPartSession.
  This gives a collection of all the Sketches existing in the Part Model.
- It is possible to create a new Sketch
  (IADSketch) by making
  a call to the AddSketch(IADOccurrence, Object, String)
  method on the sketches collection IADSketches.
- Figures can be added to the sketch by calling several of the methods
  on IADSketchFigures,
  such as AddLine(Double, Double, Double, Double).
- Only the following IADSketchFigure
  figure types are provided as of now:
  1. IADSketchLine
     (Line, also the result of adding a rectangle, or an existing regular polygon)
  2. IADSketchCircle
     (Circle)
  3. IADSketchCircularArc
     (Circular Arc)
  4. IADSketchBspline
     (BSpline)
  5. IADSketchPoint
     (Node)

     | Note |
     | --- |
     | The following figures currently only support querying and do not have methods for creation with the API. |
  6. IADSketchEllipse
     (Ellipse)
  7. IADSketchEllipticArc
     (Elliptical Arc)
  8. IADSketchShapePattern
     (Shape or a pattern of shapes)
- Each of the figure types provide methods to return the data
  associated with that figure.
- It is possible to delete the Sketch by calling
  Delete on
  IADSketch.
- Some supporting interfaces

  - IAD2DPoint
  - IADDimensions
  - IADDimension
  - IADCompositeFigure



# Getting Started

Alibre exposes the runtime Alibre model to the external world through
the various API’s for designs that can be created from Alibre. API’s provide
an interface for anyone to create the various Alibre features programmatically
that one can create by using the Alibre product directly. This document provides
a step-by-step guide for anyone who wishes to handle Alibre feature creation
programmatically. The document begins with the introduction to the basic
architecture of the Alibre API’s, followed by the details of implementation.

The API’s are exposed to the user by the type library that comes with
the product. The Alibre API architecture is COM (Component Object Model) based
and therefore any language (such as VC++, Java, VB, C#), which supports COM, can
be used for implementation of API’s. The name of this library is "AlibreX.dll".
.NET languages should reference this dll, and other languages should reference
the file AlibreX\_64.tlb.
You can find these library files under \Alibre Design\Program folder. To view
the various API’s and interfaces you can view this library using Visual Studio's
object browser which enlists all the interfaces and various methods exposed
on those interfaces along with a help string to give the details of the method.

#### Referencing the Alibre API

To add a reference to AlibreX to your project:

#### VC++ users:

Use #import "AlibreX\_64.tlb" preprocessor
in your header file.

| Note |
| --- |
| This is the usage when you are using unmanaged C++, as in, not using .NET CLR. |

| Note |
| --- |
| Use AlibreX\_64.tlb for 64-bit clients. Alibre Design itself is 64-bit |

#### C# users:

1. Open a C# project in **Visual Studio**.
2. From the Project menu, select Add Reference...
3. Go to the Browse tab and browse to the directory where
   **Alibre Design** is installed.
4. Open the *Program* folder, select
   *AlibreX.dll*, and click the OK button.
5. Optionally add using AlibreX; to code
   files where you will be working with the Alibre API.

#### The interfaces you will need to be familiar with first in order to get started are:

1. The AlibreX Automation hook.
   (AutomationHook)
2. The root object.
   (IADRoot)
3. Various kinds of workspaces and Workspace collection
   (IADSessions)

#### AutomationHook:

The core object through which one can traverse through the various
Alibre components is called "AutomationHook". As the name suggests
this object provides an entry point or "hook" to the Alibre product.
So let’s get into further details of this object and how one can use
this object to connect to Alibre.

AutomationHook is the ActiveX object exposed by the Alibre. There
are two ways a user can use AutomationHook. Both these cases are discussed
below with a snippet in VB and C++.

#### Case 1:

Using a Running Instance of Alibre.

In this case the user has the Alibre product running on
his/her machine. In this case AutomationHook object can be obtained
from the windows "Running Object Table (ROT)". The following snippets
demonstrate this:

```
IAutomationHook hook;
try
{
    //Connecting to Alibre
    hook = (IAutomationHook)Marshal.GetActiveObject("AlibreX.AutomationHook");
    Console.WriteLine("Connected to Alibre.");
}
catch
{
    Console.WriteLine("Failed to connect to Alibre.");
}
```

As Alibre is running on user’s machine this call to
GetObject (VB) or
GetActiveObject (VC++, C#) should return
a non-null value for the object.

#### Case 2:

If Alibre is not running on user’s machine and you need to work
with Alibre in GUI less mode; you can do that too. Following are
the snippets in VB, VC++, and C#:

```
Set m_objADHook = New AlibreX.AutomationHook      
Call m_objADHook.Initialize("", "", "", True, 0)
```

If you take a look at the Object Browser and look for the
Initialize(String, String, String, Boolean, Int32)
method on the AutomationHook interface you would see the signature
of the method in the window at the bottom. The string arguments
of the function are no longer used and can all be Nothing
or empty strings. The last parameter is a reserved parameter
and should always be 0.

```
IAutomationHook hook = new AutomationHook();
hook.Initialize(null, null, null, false, 0);
```

This call will initialize the Alibre in GUI-less mode.

Thus one can connect to running instance of Alibre or start
Alibre in GUI less mode using the AutomationHook object exposed
by the Alibre API infrastructure.

#### IADRoot:

Once we have the AutomationHook, next task is to get the root
object for the Alibre features tree. These features include Assemblies,
Part, Part Features, various sessions and various such Alibre objects,
which you will find when you run Alibre.

In the object browser you would find one more property (Get Property)
exposed on AutomationHook, named "Root". This property gives you the
root object in the Alibre product. This root object can be then used
to create numerous standard Alibre features. For instance one of many
such features one could be, starting of new part session, adding new sketch,
adding different features and then saving part, all programmatically!

The following snippets show how to get the root from AutomationHook.

```
IADRoot root = hook.Root;
```

Various methods exposed on the IADRoot
interface can be seen in the object browser. This is the starting point
for using any other functionality and manipulating or adding features
via API’s.



# PDM API Overview

V28 introduced PDM functionality with the PDM Browser
providing the UI for connecting to a PDM Server and managing data
stored in a Safe. In V29, the AlibreX API framework was extended to
allow external client programs to access this data.

This document briefly discusses how to use the PDM API’s for
connecting to a Safe, fetching the active Safes, saving files
to PDM, working with Metadata, etc.

As we already know, Alibre Design API’s can be used by client
programs in a few different ways:

1. Program using API after connecting to a running instance
   of Alibre Design
2. Program using API when running in headless (GUI-less) mode
3. DLL implemented as an add-on running inside Alibre Design
   instance and driving the latter using API

In each case, obtaining the IADRoot interface from Alibre Design
will be one of the first steps. See Getting Started.

#### Key Interfaces

The following interfaces in the AlibreX
namespace provide the core functionality for PDM module:

- AlibreXIADRoot

  This interface serves as the primary gateway for establishing a connection with the PDM Server and interacting with data stored within a *Safe*.

  To obtain an active connection to server, you can utilize one of two primary workflows:

  - **New Connection:** Use the
    ConnectToPDM(String, String, String, String)
    method by providing the necessary server and credential parameters.
  - **Active Connection:** To hook into the last connected Server from a running instance of the Alibre Design client, use the
    GetActiveServerConnection method.

  | Note |
  | --- |
  | Both of these methods return an IADPDMServerConnection interface object, which is documened below. |
- AlibreXIADPDMServerConnection

  Once a connection is established via IADRoot, this interface manages the active session with the PDM server.

  - **List Active Safes:** Use the Safes property to retrieve the IADPDMSafes collection.
  - **Termination:** To securely close the session and remove the safe connection, call the Logout method.
- AlibreXIADPDMSafes

  Provides the necessary methods to iterate over the collection of Safes available on the connected server. Each iteration returns an IADPDMSafe interface object.
- AlibreXIADPDMSafe

  The core container for PDM data, allowing navigation through Projects, Libraries, the Recycle Bin and other top-level collections.

  | Note |
  | --- |
  | The PDM APIs are designed to replicate the standard Alibre Design UI workflow. To list files and folders, you should first iterate through the top-level Projects or Libraries and then traverse their respective folder hierarchies. |

  Use the following api to access specific data silos within the Safe:

  - Libraries: Enumerate through various Libraries.
  - Projects: Enumerate through various Projects.
  - RecycleBin: Access deleted items.
  - Templates: Access Template items.
  - Classes: Access Class definitions.
  - PropertyDefinitions: Access custom Property Definitions.

#### Container and File Operations

- **Working with Containers**

  After obtaining an interface to any of the containers, like say a Folder, its content can be traversed or modified using its Methods and Properties.

  The IADPDMSafeProject, IADPDMSafeLibrary, and IADPDMFolder interfaces all provide standard properties for traversal:

  - **Folders:** Used to enumerate sub-folders.
  - **FileItems:** Used to enumarate files.

  To upload arbitrary non-Alibre files from Windows file system to a Safe Folder, use UploadDocuments(String, Boolean, IADPDMTaskCallback).
  You will see later (below) how to save native Alibre files into the Safe.

  To create a sub-folder within, say, a folder, use CreateFolder(String).

  Along expected lines, there are methods available to perform standard operations like Rename, Delete, Restore, and Purge a project, library or a Folder.
- **Working with Files**

  The IADPDMFileItem interface handles the core file operations. This includes methods to Open, OpenNonNativeFileItem,
  Copy, Rename, Move, Delete, Restore as well as other actions such as Lock, CheckIn, Shelve, UnShelve,
  Revert, Purge, PurgeWithConstituents etc.

  **Opening Files:**  
  Use Open(Boolean) to opan a native Alibre Design file.

  Use OpenNonNativeFileItem(Boolean, Boolean) to open a non-native file (say, a STEP file).

  **Saving Alibre Design Files:**  
  To Save a native workspace in PDM, just use the standard 'Save' API methods on IADSession interface
  like IADSession::SaveNew(), IADSession::Save(), IADSession::SaveAs() and IADSession::SaveAll().

  Some of these methods require a destination parameter. For inforamtion on this, read Remarks in
  SaveAs(Object, String)  

  NOTE:  
  The files will always be saved to the working directory on the client machine and so the CheckIn(String)
  has to be called later to actually push the files to the PDM Server.
- **Working with Properties**

  Both IADPDMFolder and IADPDMFileItem expose a Properties collection
  to retrieve the properties of a folder or file item.

  To set a property, use the SetProperty(IADPDMProperty) method.
  This requires an IADPDMProperty object to be input. This must be constructed using
  CreatePropertyInstance(IADPDMPropertyDefinition, Object).

  The two parameters to CreatePropertyInstance are:

  1. IADPDMPropertyDefinition -
     These are enumerated by IADPDMPropertyDefinitions collection that can be obtained from IADPDMSafe
  2. System.Object - The actual type of this object depends on PropertyValueType of the PropertyDefinition in question.

     For more information, read Remarks in CreatePropertyInstance(IADPDMPropertyDefinition, Object)

  To remove a property, use the RemoveProperty(IADPDMProperty). Here, the IADPDMProperty can be obtained
  from the Properties collection.
  Or, simply pass in a new property instance constructed using the previously noted IADPDMSafe::CreatePropertyInstance method without
  specifying 'value' parameter (i.e., can be null); this is because specifying the IADPDMPropertyDefinition alone is sufficient to identify
  the property to be removed from the Properies collection of IADPDMFileItem (or IADPDMFolder) in question.

#### Accessing File Versions

History returns IADPDMVersionFileItems.
From this collection, you can enumerate its IADPDMVersionFileItem objects. Using IADPDMVersionFileItem interface,
you can perform various operations such as:

- AddRevision(String, Boolean)
- RemoveRevision(Boolean)
- UpdateRevision(String)
- UpdateVersionComment(String)
- RestoreVersion(Boolean)
- PurgeVersion

#### Managing Metadata

In the 'Working with Properties' section above, we saw how to construct a property instance from a property definition and setting it on a File item.
In this section, we will see how to create a new "Property Definition", itself. A IADPDMPropertyDefinition
describes the characterestics of a Property - such as its name,its data type (string or integer or date etc.). We call this metadata.

We also introduce the notion of a "Class" that allows you to define a structure that encapsulates relevant properties of a real world concept. An example of this would be a 'Vendor' Class.
The property definitions associated with the Vendor class could be a title, vendor address, phone number and a contact person. We can see that these property definitions
need to be created before we can create this Vendor class. The first three property definitions (for title, address and phone number) can be thought of as simple properties that
are of 'text' or 'string' type. The contact person on the other hand is a more complex data type because it conceptualizes a "person". That implies that a "Person" Class needs to exist
before we can create our Vendor Class. For example, assume this Person Class encapsulates two property definitions, namely, person's full name and their email address. Both these are simple 'text'
based properties that need to be created before we can create the Person Class. For easy comprehension, lets list the meta-data creation process in a chronological sequence as follows:

1. Create all the "simple" property definitions for Full Name, Email Address, Title, Mailing Address, Phone Number if they do not already exist.
   A new property definition can be created as follows:

   a) Get the Safe's IADPDMPropertyDefinitions collection using
   PropertyDefinitions  
   b) Call CreateDefinitionByUserInput(String, ADPDMPropertyValueType) passing in AD\_PDM\_TEXT for
   the definition's *type*  

   Let's say we created these property definitions with the names "FullName", "EmailAddress", "Title", "MailingAddress" and "Phone" respectively
2. Create the Person Class and associate the required property definitions as follows:

   a) Get the Safe's IADPDMClasses collection using
   Classes  
   b) Call CreateClass(String)  
   c) On the IADPDMClass obtained, call the method
   AddDefaultProperty(IADPDMPropertyDefinition) twice, once each
   to associate the FullName and EmailAddress property definitions respectively that we created in the previous step.
3. Create a property definition named ContactPerson using the Person class that we created in the previous step as follows:

   On the Safe's PropertyDefinitions collection, call CreateDefinitionByClass(String, IADPDMClass, Boolean, Boolean) passing in the IADPDMClass
   we created for Person in the previous step.

   For the sake of this example, let's just assume there can only be one contact person (multiSelect=false) and users and populate contact persons on the fly (allowValuesOnTheFly=true).
4. Create the Vendor Class and associate the required property definitions:

   a) On the Safe's Classes collection, call CreateClass(String)  
   b) On the IADPDMClass obtained, call the method
   AddDefaultProperty(IADPDMPropertyDefinition) four times, once each
   to associate the Title, MailingAddress, Phone and ContactPerson property definitions respectively that we created in earlier steps.
5. Create a property definition named Vendor using the Vendor class that we created in the previous step as follows:

   On the Safe's PropertyDefinitions collection, call CreateDefinitionByClass(String, IADPDMClass, Boolean, Boolean) passing in the IADPDMClass
   we created for Vendor in the previous step.

   For the sake of this example, say, this Vendor property will be set on a IADPDMFileItem so that user can associate a specific vendor with a file item in the Safe.
   Further, assume there can be more than one vendors (multiSelect=true) and users can populate contact persons on the fly (allowValuesOnTheFly=true).
6. At this point, we have created the meta-data we needed for our example. However, we are yet to create instances of Person and Vendor classes. This too can be done using API.
   To use an example, to create a person instance called John Smith via API, we would do the following:

   1. On the IADPDMClass for Person class, call AddDataItem(String). This will return a
      IADPDMClassDataItem
   2. Construct property instances for FullName and EmailAddress property definitions using CreatePropertyInstance(IADPDMPropertyDefinition, Object) passing in
      "John Smith" and "John.Smith@someEmail.com" as the value parameters respectively.
   3. Set the above two property instances on the data item using SetProperty(IADPDMProperty). Creation of "Person" data item, John Smith, is now complete.

   Similarly, you would create an instance of "Vendor" by calling AddDataItem(String) on Vendor class. Then, construct property instances for the four properties Vendor requires. The first three
   are simple properties of string type. The fourth one (ContactPerson) is an instance of a "pick from list" property. You would assign the 'John Smith' Person object as the value of this property instance.
   Let's say the Vendor data item you created above has the title "Acme Manufacturing Inc."

   Now, you may set "Acme Manufacturing Inc.", as the 'vendor' property on a file as follows:

   Using "Acme Manufacturing Inc." data item as value object, construct a new property instance on Vendor Property Definition by calling CreatePropertyInstance(IADPDMPropertyDefinition, Object). Then, set this property on a file using SetProperty(IADPDMProperty). Refer earlier section, 'Working with Properties'.



# Solid Features

Parts are modeled by creating features:

- Reference Geometry features
  (Reference Geometry)
- Sketching features
  (Sketching)
- Solid Features

Solid Features are individual 3D shapes representing common mechanical
design elements, like bosses and holes, which either create material or remove
material in a part.

#### Solid Features

The Solid Features collection (IADPartFeatures)
is obtained by querying Features.

This collection provides several creation methods, such as:

- AddExtrudedBoss(IADSketch, Object, ADPartFeatureEndCondition, IADOccurrence, Object, Double, ADDirectionType, IADOccurrence, Object, Boolean, Object, Boolean, String, String, String)
- AddExtrudedCutout(IADSketch, Object, ADPartFeatureEndCondition, IADOccurrence, Object, Double, ADDirectionType, IADOccurrence, Object, Boolean, Object, Boolean, String, String, String)
- AddRevolvedBoss(IADSketch, IADOccurrence, Object, Object, String)
- AddRevolvedCutout(IADSketch, IADOccurrence, Object, Object, String)
- AddSweptBoss(IADSketch, IObjectCollector, Boolean, ADPartFeatureEndCondition, IADOccurrence, Object, Double, Object, Boolean, String)
- AddSweptCutout(IADSketch, IObjectCollector, Boolean, ADPartFeatureEndCondition, IADOccurrence, Object, Double, Object, Boolean, String)

Topology, Reference Geometry, and 2D Sketches can be used as input for
feature creation. Parameters like Depth and Angle can be supplied as equation
strings.

Each IADPartFeature
in the collection can be queried and manipulated:

- Solid Features can be deleted.
  (Delete)
- Each Solid Feature has a type and name.
  (FeatureType,
  Name)
- Each Solid Feature has a bounding box.
  (GetExtents(IADPoint, IADPoint))
- Solid Features can be suppressed.
  (IsSuppressed)

All the Solid Features for an IADPartSession
can be unsuppressed at once by using UnSuppressAll.
All the Features (including Reference Geometry and Sketches) for an
IADPartSession can be
regenerated at once by using RegenerateAll.

For some Solid Features, that feature's data can be queried.

- Extrude Boss, Extrude Cut
  (IADExtrusionFeature)
- Sweep Boss, Sweep Cut
  (IADSweepFeature)
- Revolve Boss, Revolve Cut
  (IADRevolutionFeature)
- Chamfer Edge, Chamfer Vertex
  (IADChamferFeature,
  IADVertexChamferFeature)
- Draft
  (IADDraftFeature)
- Fillet
  (IADFilletFeature)
- Hole
  (IADHoleFeature)
- Shell
  (IADShellFeature)
- Helical Boss, Helical Cut
  (IADHelicalFeature)
- Scale
  (IADScaleFeature)
- Offset Face
  (IADOffsetFaceFeature)
- External Thread
  (IADExternalThreadFeature)

The following features are not yet fully supported, but some placeholders
exist for future expansion of the API:

- Boolean Unite, Boolean Subtract, Boolean Intersect
  (IADDesignBooleanFeature)
- Loft Boss, Loft Cut
  (IADLoftFeature)
- Mirror
  (IADMirrorFeature)
- Linear Pattern, Circular Pattern
  (IADPatternFeature)
- Extrude Thin Wall Boss, Extrude Thin Wall Cut
  (IADThinWallExtrusionFeature)
- Revolve Thin Wall Boss, Revolve Thin Wall Cut
  (IADThinWallRevolutionFeature)
- Sweep Thin Wall Boss, Sweep Thin Wall Cut
  (IADThinWallSweepFeature)
- Trim Model
  (IADTrimModelFeature)
- Thicken Surface
  (IADThickenSurfaceFeature)
- Remove Face
  (IADRemoveFaceFeature)
- Move Face
  (IADMoveFaceFeature)
- Imported File
  (IADImportFileFeature)

Sheet Metal Features are not yet supported, but some placeholders exist
for future expansion of the API.

- Tab
  (IADSMTabFeature)
- Closed Corner
  (IADSMClosedCornerFeature)
- Corner Chamfer
  (IADSMCornerChamferFeature)
- Corner Round
  (IADSMCornerRoundFeature)
- Dimple
  (IADSMDimpleFeature)
- Flange
  (IADSMFlangeFeature)
- Punch
  (IADSMPunchFeature)
- Rebend
  (IADSMRebendFeature)
- Unbend
  (IADSMUnbendFeature)



# Topology and Geometry

[Geometry](#Geometry) refers
to the physical items represented by the model (such as points, curves, and
surfaces), independent of their relationships to each other. NOTE: These
points and surfaces are geometric items, not to be confused with the
similarly-named reference geometry points and surfaces.

[Topology](#Topology) refers
to the relationships between the various entities in a model. Topology
describes how geometric entities are connected. A topological entity's
position is fixed in space when it is associated with a geometric entity.

The same topology can represent a variety of different 3D shapes,
depending on the geometry associated with that topology. For example, an
edge is topological entity representing the geometry of a curve with two end
points. The curve could be any curve (line, circular arc, etc.) without
changing the topology. Associating one particular curve to the edge fixes
the edge in space.

The topological elements of a model from largest to smallest are Body,
Lump, Shell, Face, Loop, Coedge, Edge and Vertex. The corresponding geometric
elements are Surface obtained from a face, Curve obtained from an edge, and
Point obtained from a vertex. Each of these geometries is then further
classified based on their specific type.

NOTE: The shell is a topological item, not to be confused with the
similarly-named feature shell.

#### Topology

![bodylumpshell](../media/bodylumpshell.png)

![faceedgevertex](../media/faceedgevertex.png)

![coedgesloops](../media/coedgesloops.png)

![coedgesloops 2](../media/coedgesloops2.png)

The object type for all the topology elements is AD\_TOPOLOGY
 and the specific topology types are
[AD\_BODY](#Bodies),
[AD\_LUMP](#Lumps),
[AD\_SHELL](#Shells),
[AD\_FACE](#Faces),
[AD\_LOOP](#Loops),
[AD\_COEDGE](#Coedges),
[AD\_EDGE](#Edges), and
[AD\_VERTEX](#Vertices).
A brief overview of these topology elements is as follows:

#### Bodies

- It is possible to get the Bodies collection
  (IADBodies)
  by querying the property Bodies
  on IADPartSession.
  This gives a collection of all the bodies existing in the Design
  Part.
- Currently the collection obtained above has just one
  Body and doesn't include the surface bodies.
- It is only possible to query the model body. It
  cannot be directly changed or deleted.

#### Lumps

- It is possible to get the Lumps collection
  (IADLumps)
  by querying the property Lumps
  on IADBody.
  This gives a collection of all the lumps in the body.
- Normally, a body has only one lump but it's not a
  necessary condition.
- It is only possible to query the lump. It cannot be
  directly changed or deleted.

#### Shells

- It is possible to get the Shells collection
  (IADShells)
  by querying the property Shells
  on IADLump.
  This gives a collection of all the shells in the lump.
- This interface is different from
  IADShellFeature.
  The shell feature is a feature. In contrast,
  IADShell
  can be obtained by querying topology elements.
- It is only possible to query the shell. It cannot be
  directly changed or deleted.

#### Faces

- It is possible to get the Faces collection
  (IADFaces)
  by querying the property Faces
  on IADBody.
  The same property is also available on
  IADLump and
  IADShell.
  Additionally we can also get the faces related to an edge or a
  vertex by querying for property Faces
  on IADEdge
  or IADVertex.
- The geometry of a face is a surface
  (IADSurface)
  and can be obtained by using the property
  Geometry
  on IADFace.
- It is only possible to query the face. It cannot be
  directly changed or deleted.

#### Loops

- It is possible to get the Loops collection
  (IADLoops)
  by querying the property Loops
  on IADFace.
  This gives the collection of all the loops on a face.
- It is only possible to query the loop. It cannot be
  directly changed or deleted.

#### Coedges

- It is possible to get the Coedges collection
  (IADCoedges)
  by querying the property Coedges
  on IADLoop.
  This gives the collection of all the coedges in a loop.
- A coedge encapsulates an edge and it aids participation
  of same edge in multiple faces. Thus there is a coedge for each
  face in which an edge participates.
- It is only possible to query the coedge. It cannot
  be directly changed or deleted.

#### Edges

- It is possible to get the Edges collection
  (IADEdges)
  by querying the property Edges
  on IADBody,
  IADLump,
  IADShell,
  or IADFace.
  This gives the collection of all the edges in the topology on
  which the method is called.
- The edge(s) can also be obtained from the coedge or
  vertex.
- The geometry of an edge is a curve
  (IADCurve)
  and can be obtained by using the property
  Geometry
  on IADEdge.
- It is only possible to query the edge. It cannot be
  directly changed or deleted.

#### Vertices

- It is possible to get the Vertices collection
  (IADVertices)
  by querying the property Vertices
  on IADBody,
  or IADFace.
  This gives the collection of all the vertices in the topology
  on which the method is called.
- It is only possible to query the vertex. It cannot
  be directly changed or deleted.

#### Geometry

![geometrytopology](../media/geometrytopology.png)

![geometrytopology 2](../media/geometrytopology2.png)

It is possible to access the geometries of the relevant topology element
(face, edge, or vertex) while traversing along the topology hierarchy. The
object type for each of these interfaces is AD\_GEOMETRY.
See below for the specific geometry types. A brief overview of the geometry
elements is as follows:

#### Surface

- The underlying geometry of a face is a surface and can
  be obtained by querying for the property Geometry
  on IADFace
  returning IADSurface.
- This interface is different from
  IADDesignSurface.
  The design surface is a reference geometry which can be created.
  In contrast, IADSurface
  can be obtained by querying topology elements only and cannot
  be created or deleted.
- This interface can be used to query generic properties
  on the surface. To get the specific surface type, query the property
  SurfaceType
  and then cast this object to the appropriate type.
- The various geometry types for surfaces are
  AD\_PLANE (IADPlane),
  AD\_CYLINDER (IADCylinder),
  AD\_CONE (IADCone),
  AD\_SPHERE (IADSphere),
  AD\_TORUS (IADTorus),
  and AD\_BSURF (IADBsplineSurface).
  There is a separate interface representing all these surface types.
  For details go to these interface definitions.
- It is only possible to query the surface. It cannot
  be directly changed or deleted.

#### Curve

- The underlying geometry of an edge is a curve and can
  be obtained by querying for the property
  Geometry
  on (IADEdge)
  returning IADCurve.
- This interface can be used to query generic properties
  on the curve. To get the specific curve type, query the property
  CurveType
  and then cast this object to the appropriate type.
- The various geometry types for curves are AD\_LINE
  (IADLine),
  AD\_CIRCLE (IADCircle),
  AD\_ELLIPSE (IADEllipse),
  AD\_CIRCULAR\_ARC (IADCircularArc),
  AD\_ELLIPTICAL\_ARC (IADEllipticalArc),
  and AD\_BSPLINE (IADBsplineCurve).
  There is a separate interface representing all these curve types.
  For details go to these interface definitions.
- It is only possible to query the curve. It cannot be
  directly changed or deleted.

#### Point

- The underlying geometry of a vertex is a point and can
  be obtained by querying the property
  Point
  on IADVertex.
- This interface is different from
  IADDesignPoint.
  The design point is a reference geometry which can be created.
  In contrast, IADPoint
  can be obtained by querying topology elements only and cannot
  be created or deleted.
- The geometry type for a point is AD\_POINT
  (IADPoint).
- It is only possible to query the point. It cannot
  be directly changed or deleted.

