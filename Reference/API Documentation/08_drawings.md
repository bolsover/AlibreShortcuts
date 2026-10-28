# AlibreX API — Drawings, Sheets & BOM

> Part of the split AlibreX reference. See `00_index.md` for the full map.

**Sections in this file:** 166

---


# IADSheet Methods

The IADSheet type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateStandardViews | Create Standard Views of the specified part or assembly on this sheet. |
|  | GetExtents | Returns the extents of all views, annotations, and figures present in this drawing sheet. |
|  | GetSheetSize | Gets the size of the sheet, as defined by the template or blank sheet size selected. In the UI this is indicated by the blue rectangular border. |
|  | ModifySheetBlank | Modify this drawing sheet to use a blank sheet with the indicated parameters. |
|  | ModifySheetTemplate | Modify this drawing sheet to use a template with the indicated parameters. |



# IADBOMTableSession.DataFontColor Property

Gets data font color in the table.

#### Syntax

```
int DataFontColor { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADBOMTableSession.Rows Method

Gets all the rows in the BOM table.

#### Syntax

```
IADBOMRows Rows(
	bool onlyVisibleOnes
)
```

#### Parameters

onlyVisibleOnes  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Return Value

IADBOMRows



# IADSavedView.Orientation Property

Gets a transformation describing the orientation of this view.

#### Syntax

```
IADTransformation Orientation { get; }
```

#### Property Value

IADTransformation



# IADDimension.Session Property

Returns the part session for the collection.

#### Syntax

```
IADDesignSession Session { get; }
```

#### Property Value

IADDesignSession



# IADDrawingSession Interface

IADDrawingSession interface

#### Syntax

```
public interface IADDrawingSession : IADSession
```

The IADDrawingSession type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ConstituentFilePaths | Returns file path strings for other Design files that are referenced by this session.  (Inherited from IADSession) |
|  | FilePath | Returns the location on disk of where the file was last saved. If unsaved, returns null.  (Inherited from IADSession) |
|  | GeometryFactory | Returns the Geometry Factory.  (Inherited from IADSession) |
|  | Identifier | Returns the session's unique identifier.  (Inherited from IADSession) |
|  | IsGUIVisible | Returns True if the GUI for this session is visible.  (Inherited from IADSession) |
|  | Name | Returns this session's name.  (Inherited from IADSession) |
|  | Parameters | Returns a collection of parameters for this session.  (Inherited from IADSession) |
|  | PreviewSnapshot | Returns a OLE picture object containing the preview snapshot bitmap for the session.  (Inherited from IADSession) |
|  | Properties | Returns the drawing properties of the drawing. |
|  | Root | Returns the automation root.  (Inherited from IADSession) |
|  | SelectedObjects | Returns all selected entities in the session's browser as a collection of target proxies.  (Inherited from IADSession) |
|  | SelectionFilter | Gets the interface to this drawing session's selection filter. The interface's properties can be queried to find the current settings or set to change the active selection filters. |
|  | SessionType | Returns a pre-defined constant that identifies whether this session is a part or assembly or drawing session.  (Inherited from IADSession) |
|  | Sheets | Gets the collection of sheets in the drawing. |
|  | TimeStamp | Returns time stamp of this session; the time stamp changes when changes are saved to the session.  (Inherited from IADSession) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SESSION)  (Inherited from IADSession) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | BindKeyToItem | Given a Persistent Key, returns the corresponding Occurrence/Topology element/Sketch.  (Inherited from IADSession) |
|  | Close | Closes the session and optionally saves before closing.  (Inherited from IADSession) |
|  | CreatePackage | (Inherited from IADSession) |
|  | ExportBOM | Export the bill of materials as a .csv file. |
|  | ExportDWG | Exports the drawing session as a AUTOCAD DWG file. |
|  | ExportDXF | Exports the drawing session as a AUTOCAD DXF file. |
|  | ExportPDF | Export the active drawing sheet to a PDF file. |
|  | ExportSTEP | Exports the drawing session as a Alibre STEP file. |
|  | Highlight | Highlights the object in the canvas.  (Inherited from IADSession) |
|  | NewTargetProxy | Creates a new TargetProxy for the given target and the occurrence  (Inherited from IADSession) |
|  | ReprojectViews | Reproject all or a set of drawing views contained in the drawing session, optionally changing their view display mode. |
|  | Save | Saves modified session and sub-sessions, if any, to their original folder locations.  (Inherited from IADSession) |
|  | SaveAll | Saves a copy of the session and all sub-sessions to the directory indicated by the destination parameter.  (Inherited from IADSession) |
|  | SaveAs | Saves the session to create a new copy with the given name.  (Inherited from IADSession) |
|  | SaveCurrentViewSnapshot | Saves the snapshot of the graphic canvas for current view in the session, at the given location and of the given size.  (Inherited from IADSession) |
|  | SaveNew | Saves a new, unsaved session to the specified folder location.  (Inherited from IADSession) |
|  | Select | Selects all objects passed in pEntities.  (Inherited from IADSession) |
|  | SelectedObjectsEx | Returns all selected entities in the session's browser as a collection of target proxies, and sets the parameter lastSelectedPoint to last point in the user clicked to make the selection.  (Inherited from IADSession) |
|  | UpdatePreviewSnaphot | Captures the canvas image displayed for this session and silently saves it as the file snapshot property  (Inherited from IADSession) |



# IADBOMColumns.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADDrawingView.Name Property

Sets/Returns the name of this view.

#### Syntax

```
string Name { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADBOMColumn.IsVisible Property

Returns true if this column is visible.

#### Syntax

```
bool IsVisible { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADSavedViews Properties

The IADSavedViews type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Gets the count of saved views in this collection. |
|  | Enum | Returns an enumerator for the collection. |



# IADDimension.DimensionType Property

Returns the dimension type. (Radial/Linear/Diametric)

#### Syntax

```
ADDimensionType DimensionType { get; }
```

#### Property Value

ADDimensionType



# IADDrawingProperties.LengthUnits Property

Returns the unit of measurement for representing lengths in the drawing.

#### Syntax

```
ADUnits LengthUnits { get; }
```

#### Property Value

ADUnits



# IADDimension Properties

The IADDimension type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DimensionType | Returns the dimension type. (Radial/Linear/Diametric) |
|  | Parameter | Returns the parameter associated with this dimension. |
|  | Root | Returns the automation root object. |
|  | Session | Returns the part session for the collection. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_DIMENSION) |



# IADBOMTableSession Properties

The IADBOMTableSession type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ColumnCount | Gets the number of coulmns in BOM table. |
|  | ConstituentFilePaths | Returns file path strings for other Design files that are referenced by this session.  (Inherited from IADSession) |
|  | DataFont | Gets the data font in the table. |
|  | DataFontColor | Gets data font color in the table. |
|  | FilePath | Returns the location on disk of where the file was last saved. If unsaved, returns null.  (Inherited from IADSession) |
|  | GeometryFactory | Returns the Geometry Factory.  (Inherited from IADSession) |
|  | HeaderFont | Gets header row font. |
|  | HeaderFontColor | Gets header font color. |
|  | HeaderRowHeight | Gets the height of header row. |
|  | Identifier | Returns the session's unique identifier.  (Inherited from IADSession) |
|  | IsBottomUpDisplay | Returns whether table is in Bottom Up Display. |
|  | IsGUIVisible | Returns True if the GUI for this session is visible.  (Inherited from IADSession) |
|  | Name | Returns this session's name.  (Inherited from IADSession) |
|  | Parameters | Returns a collection of parameters for this session.  (Inherited from IADSession) |
|  | PreviewSnapshot | Returns a OLE picture object containing the preview snapshot bitmap for the session.  (Inherited from IADSession) |
|  | Root | Returns the automation root.  (Inherited from IADSession) |
|  | RowCount | Gets the number of rows in BOM table |
|  | SelectedObjects | Returns all selected entities in the session's browser as a collection of target proxies.  (Inherited from IADSession) |
|  | SessionType | Returns a pre-defined constant that identifies whether this session is a part or assembly or drawing session.  (Inherited from IADSession) |
|  | Style | Gets the BOM table style. |
|  | TimeStamp | Returns time stamp of this session; the time stamp changes when changes are saved to the session.  (Inherited from IADSession) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SESSION)  (Inherited from IADSession) |



# IADSavedView.TargetPosition Property

Returns the position of the target that is being looked at by the camera.

#### Syntax

```
IADPoint TargetPosition { get; }
```

#### Property Value

IADPoint



# IADSavedView.OrthographicScaleFactor Property

Returns the scale factor for the orthographic projection. Scale factor is the
ratio of screen pixels/model units.

#### Syntax

```
double OrthographicScaleFactor { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADBOMRows.Item Method

Given a row's index, returns the row in the BOM table.

#### Syntax

```
IADBOMRow Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The index of the row.

#### Return Value

IADBOMRow  
Returns IADBOMRow



# IADSheets.ActiveSheet Property

Gets/sets the currently active drawing sheet.

#### Syntax

```
IADSheet ActiveSheet { get; set; }
```

#### Property Value

IADSheet



# IADBOMRow.IsVisible Property

Returns true if this row is visible.

#### Syntax

```
bool IsVisible { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDrawingProperties Interface

IADDrawingProperties is an interface for properties that are associated with the workspace.
These properties include display units, and file information for the drawing.

#### Syntax

```
public interface IADDrawingProperties
```

The IADDrawingProperties type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | AngleUnits | Returns the unit of measurement for representing angles in the drawing. |
|  | Description | Gets/sets the description for the drawing. |
|  | LengthUnits | Returns the unit of measurement for representing lengths in the drawing. |
|  | Number | Gets/Sets the number for the drawing. This is a user-specific string to denote version of the drawing. |



# IADDrawingSession Methods

The IADDrawingSession type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | BindKeyToItem | Given a Persistent Key, returns the corresponding Occurrence/Topology element/Sketch.  (Inherited from IADSession) |
|  | Close | Closes the session and optionally saves before closing.  (Inherited from IADSession) |
|  | CreatePackage | (Inherited from IADSession) |
|  | ExportBOM | Export the bill of materials as a .csv file. |
|  | ExportDWG | Exports the drawing session as a AUTOCAD DWG file. |
|  | ExportDXF | Exports the drawing session as a AUTOCAD DXF file. |
|  | ExportPDF | Export the active drawing sheet to a PDF file. |
|  | ExportSTEP | Exports the drawing session as a Alibre STEP file. |
|  | Highlight | Highlights the object in the canvas.  (Inherited from IADSession) |
|  | NewTargetProxy | Creates a new TargetProxy for the given target and the occurrence  (Inherited from IADSession) |
|  | ReprojectViews | Reproject all or a set of drawing views contained in the drawing session, optionally changing their view display mode. |
|  | Save | Saves modified session and sub-sessions, if any, to their original folder locations.  (Inherited from IADSession) |
|  | SaveAll | Saves a copy of the session and all sub-sessions to the directory indicated by the destination parameter.  (Inherited from IADSession) |
|  | SaveAs | Saves the session to create a new copy with the given name.  (Inherited from IADSession) |
|  | SaveCurrentViewSnapshot | Saves the snapshot of the graphic canvas for current view in the session, at the given location and of the given size.  (Inherited from IADSession) |
|  | SaveNew | Saves a new, unsaved session to the specified folder location.  (Inherited from IADSession) |
|  | Select | Selects all objects passed in pEntities.  (Inherited from IADSession) |
|  | SelectedObjectsEx | Returns all selected entities in the session's browser as a collection of target proxies, and sets the parameter lastSelectedPoint to last point in the user clicked to make the selection.  (Inherited from IADSession) |
|  | UpdatePreviewSnaphot | Captures the canvas image displayed for this session and silently saves it as the file snapshot property  (Inherited from IADSession) |



# IADBOMTableSession.ExportSTEP Method

Exports the BOM Table session as a Alibre STEP file.

#### Syntax

```
void ExportSTEP(
	string fileName
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the exported file.

#### Remarks

This is an obsolete function.



# IADSheets.GetEnumerator Method

Returns an enumerator for the collection.

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADSavedView Interface

IADSavedView represents a saved view of a design session; also known as an orientation.
A saved view can be a predefined view such as "Front (XY)" or a custom user-created
view of the design.

#### Syntax

```
public interface IADSavedView
```

The IADSavedView type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CameraPosition | Returns the position of the camera for this view, in the world coordinate system. |
|  | DesignSession | Gets the design session for this saved view. |
|  | FarClippingDistanceFromCamera | Returns the distance of the far clipping plane of the view frustrum from the camera. |
|  | FieldOfView | Returns the field of view angle for perspective projection. |
|  | IsPerspective | Returns true if projection is set to perspective for this view. |
|  | Name | Gets the name of this saved view. |
|  | NearClippingDistanceFromCamera | Returns the distance of the near clipping plane of the view frustrum from the camera. |
|  | Orientation | Gets a transformation describing the orientation of this view. |
|  | OrthographicScaleFactor | Returns the scale factor for the orthographic projection. Scale factor is the ratio of screen pixels/model units. |
|  | TargetPosition | Returns the position of the target that is being looked at by the camera. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SAVED\_VIEW) |
|  | UpVector | Returns the upvector of the target that is being looked at by the camera. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetExtents | Gets the extents of the view, in screen co-ordinates. |



# IADDrawingViews Methods

The IADDrawingViews type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given a name or numerical index into the collection, returns the corresponding view. |



# IADSheet.ModifySheetTemplate Method

Modify this drawing sheet to use a template with the indicated parameters.

#### Syntax

```
void ModifySheetTemplate(
	string sheetName,
	string templateName,
	double defaultScaleNumerator = 1,
	double defaultScaleDenomenator = 1,
	bool retainTemplateLayers = true,
	bool overwriteExistingDimStyles = false
)
```

#### Parameters

sheetName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the sheet will be changed to the string specified in the parameter,
    or kept the same if a null value is passed.

templateName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the template that this sheet should use.
    A list of available templates can be found using the InstalledDrawingTemplates property.

defaultScaleNumerator  [Double](https://learn.microsoft.com/dotnet/api/system.double)  (Optional)
:   The numerator of the default scale of placed drawing views.

defaultScaleDenomenator  [Double](https://learn.microsoft.com/dotnet/api/system.double)  (Optional)
:   The denominator of the default scale of placed drawing views.

retainTemplateLayers  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)  (Optional)
:   If true, layers defined in the template will be brought into the drawing.

overwriteExistingDimStyles  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)  (Optional)
:   If the template contains dimension styles with the same name as
    dimension styles already present in the drawing, this parameter will indicate which should be used.



# IADBOMColumn.Type Property

Returns a pre-defined constant that identifies the type of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADBOMTableSession.ColumnCount Property

Gets the number of coulmns in BOM table.

#### Syntax

```
int ColumnCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADBOMRow Methods

The IADBOMRow type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Value | Gets the value stored at the provided column index. |



# IADDrawingView Methods

The IADDrawingView type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetExtents | Returns the extents of this drawing view within the sheet. |



# IADDrawingProperties Properties

The IADDrawingProperties type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | AngleUnits | Returns the unit of measurement for representing angles in the drawing. |
|  | Description | Gets/sets the description for the drawing. |
|  | LengthUnits | Returns the unit of measurement for representing lengths in the drawing. |
|  | Number | Gets/Sets the number for the drawing. This is a user-specific string to denote version of the drawing. |



# IADDrawingView.Sheet Property

Returns the drawing sheet to which this view belongs.

#### Syntax

```
IADSheet Sheet { get; }
```

#### Property Value

IADSheet



# IADBOMRows Methods

The IADBOMRows type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a row's index, returns the row in the BOM table. |



# IADBOMTableSession.Columns Method

Gets all the columns in the BOM table.

#### Syntax

```
IADBOMColumns Columns(
	bool onlyVisibleOnes
)
```

#### Parameters

onlyVisibleOnes  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, only visible columns will be included
    in the returned collection.

#### Return Value

IADBOMColumns  
Returns IADBOMColumns



# IADSheet.ModifySheetBlank Method

Modify this drawing sheet to use a blank sheet with the indicated parameters.

#### Syntax

```
void ModifySheetBlank(
	string sheetName,
	double width,
	double height,
	ADUnits units,
	double defaultScaleNumerator = 1,
	double defaultScaleDenomenator = 1
)
```

#### Parameters

sheetName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the sheet will be changed to the string specified in the parameter,
    or kept the same if a null value is passed.

width  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The new width of the sheet, in units specified by the units parameter.

height  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The new width of the sheet, in units specified by the units parameter.

units  ADUnits
:   The units of the values passed to the width and height parameters.

defaultScaleNumerator  [Double](https://learn.microsoft.com/dotnet/api/system.double)  (Optional)
:   The numerator of the default scale of placed drawing views.

defaultScaleDenomenator  [Double](https://learn.microsoft.com/dotnet/api/system.double)  (Optional)
:   The denominator of the default scale of placed drawing views.



# IADDimension.Root Property

Returns the automation root object.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADSheets.CreateBlankSheet Method

Create a new blank sheet with the specified size in the drawing session which owns this collection.

#### Syntax

```
IADSheet CreateBlankSheet(
	string sheetName,
	double width,
	double height,
	ADUnits units,
	double defaultScaleNumerator = 1,
	double defaultScaleDenomenator = 1
)
```

#### Parameters

sheetName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new sheet. If null, the default automatically generated name will be used.

width  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The width of the sheet.

height  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The height of the sheet.

units  ADUnits
:   The units of the width and height parameters.

defaultScaleNumerator  [Double](https://learn.microsoft.com/dotnet/api/system.double)  (Optional)
:   The numerator of the default scale of placed drawing views.

defaultScaleDenomenator  [Double](https://learn.microsoft.com/dotnet/api/system.double)  (Optional)
:   The denominator of the default scale of placed drawing views.

#### Return Value

IADSheet  
The created sheet.



# IADBOMTableSession.RowCount Property

Gets the number of rows in BOM table

#### Syntax

```
int RowCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADSheet.GetExtents Method

Returns the extents of all views, annotations, and figures present in this drawing sheet.

#### Syntax

```
void GetExtents(
	out IAD2DPoint pLower,
	out IAD2DPoint pUpper
)
```

#### Parameters

pLower  IAD2DPoint
:   The lower extent point.

pUpper  IAD2DPoint
:   The upper extent point.

#### Remarks

These extents may be larger or smaller than the defined sheet size of the drawing. For that
information, use the GetSheetSize method.



# IADDrawingSession.ExportPDF Method

Export the active drawing sheet to a PDF file.

#### Syntax

```
void ExportPDF(
	string filePath,
	bool append
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The destination file path where the PDF should be exported. If an existing
    PDF exists at the location, the exported PDF may optionally be appended to it.

append  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   Set to true to append the output to an existing PDF file or false to overwrite.
    If there is no existing PDF in the location of the filePath parameter, this is ignored.

#### Remarks

This method requires Alibre Design running with the GUI enabled.



# IADDrawingProperties.AngleUnits Property

Returns the unit of measurement for representing angles in the drawing.

#### Syntax

```
ADUnits AngleUnits { get; }
```

#### Property Value

ADUnits



# IADBOMColumn.DataAlignment Property

Gets the data alignment under this column.

#### Syntax

```
ADBOMTextAlignment DataAlignment { get; }
```

#### Property Value

ADBOMTextAlignment



# IADBOMTableSession.Value Method

Gets the value stored at the provided row and column index.

#### Syntax

```
string Value(
	int pRowIndex,
	int pColumnIndex
)
```

#### Parameters

pRowIndex  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The row index of the value.

pColumnIndex  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The column index of the value.

#### Return Value

[String](https://learn.microsoft.com/dotnet/api/system.string)  
Returns the value of the specified cell.



# IADSheets Methods

The IADSheets type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateBlankSheet | Create a new blank sheet with the specified size in the drawing session which owns this collection. |
|  | CreateSheetFromTemplate | Create a new sheet from a template file in the drawing session which owns this collection. |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given a name or numerical index into the collection, returns the corresponding sheet. |



# IADBOMRow.IsCustomDefined Property

Returns true if this row is a custom defined row.

#### Syntax

```
bool IsCustomDefined { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADBOMColumn.Width Property

Gets the column width.

#### Syntax

```
double Width { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADSavedView Properties

The IADSavedView type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | CameraPosition | Returns the position of the camera for this view, in the world coordinate system. |
|  | DesignSession | Gets the design session for this saved view. |
|  | FarClippingDistanceFromCamera | Returns the distance of the far clipping plane of the view frustrum from the camera. |
|  | FieldOfView | Returns the field of view angle for perspective projection. |
|  | IsPerspective | Returns true if projection is set to perspective for this view. |
|  | Name | Gets the name of this saved view. |
|  | NearClippingDistanceFromCamera | Returns the distance of the near clipping plane of the view frustrum from the camera. |
|  | Orientation | Gets a transformation describing the orientation of this view. |
|  | OrthographicScaleFactor | Returns the scale factor for the orthographic projection. Scale factor is the ratio of screen pixels/model units. |
|  | TargetPosition | Returns the position of the target that is being looked at by the camera. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SAVED\_VIEW) |
|  | UpVector | Returns the upvector of the target that is being looked at by the camera. |



# IADDrawingView.Root Property

Returns the automation root object.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADDrawingViews Interface

This interface represents the collection of all the views in a Drawing sheet.

#### Syntax

```
public interface IADDrawingViews
```

The IADDrawingViews type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of views in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the drawing session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given a name or numerical index into the collection, returns the corresponding view. |



# IADDrawingSelectionFilter.Annotations Property

If true, annotations are selectable.

#### Syntax

```
bool Annotations { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDrawingSession.ExportBOM Method

Export the bill of materials as a .csv file.

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



# IADSheet.Session Property

Returns the drawing session to which this sheet belongs.

#### Syntax

```
IADDrawingSession Session { get; }
```

#### Property Value

IADDrawingSession



# IADSavedView.CameraPosition Property

Returns the position of the camera for this view, in the world coordinate
system.

#### Syntax

```
IADPoint CameraPosition { get; }
```

#### Property Value

IADPoint



# ADBOMTextAlignment Enumeration

#### Syntax

```
public enum ADBOMTextAlignment
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_LEFT | 1 |  |
| AD\_CENTER | 2 |  |
| AD\_RIGHT | 4 |  |
| AD\_UNKNOWN\_ALIGNMENT | -1 |  |



# IADDrawingSession.Sheets Property

Gets the collection of sheets in the drawing.

#### Syntax

```
IADSheets Sheets { get; }
```

#### Property Value

IADSheets



# IADDimension Interface

IADDimension represents a sketch dimension.

#### Syntax

```
public interface IADDimension
```

The IADDimension type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DimensionType | Returns the dimension type. (Radial/Linear/Diametric) |
|  | Parameter | Returns the parameter associated with this dimension. |
|  | Root | Returns the automation root object. |
|  | Session | Returns the part session for the collection. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_DIMENSION) |



# IADSavedView.FarClippingDistanceFromCamera Property

Returns the distance of the far clipping plane of the view frustrum from the
camera.

#### Syntax

```
double FarClippingDistanceFromCamera { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADSavedView.GetExtents Method

Gets the extents of the view, in screen co-ordinates.

#### Syntax

```
void GetExtents(
	out IAD2DPoint pUpperLeft,
	out IAD2DPoint pBottomRight
)
```

#### Parameters

pUpperLeft  IAD2DPoint
:   The upper left extent.

pBottomRight  IAD2DPoint
:   The bottom right extent.



# IADBOMTableSession Interface

IADBOMTableSession interface

#### Syntax

```
public interface IADBOMTableSession : IADSession
```

The IADBOMTableSession type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ColumnCount | Gets the number of coulmns in BOM table. |
|  | ConstituentFilePaths | Returns file path strings for other Design files that are referenced by this session.  (Inherited from IADSession) |
|  | DataFont | Gets the data font in the table. |
|  | DataFontColor | Gets data font color in the table. |
|  | FilePath | Returns the location on disk of where the file was last saved. If unsaved, returns null.  (Inherited from IADSession) |
|  | GeometryFactory | Returns the Geometry Factory.  (Inherited from IADSession) |
|  | HeaderFont | Gets header row font. |
|  | HeaderFontColor | Gets header font color. |
|  | HeaderRowHeight | Gets the height of header row. |
|  | Identifier | Returns the session's unique identifier.  (Inherited from IADSession) |
|  | IsBottomUpDisplay | Returns whether table is in Bottom Up Display. |
|  | IsGUIVisible | Returns True if the GUI for this session is visible.  (Inherited from IADSession) |
|  | Name | Returns this session's name.  (Inherited from IADSession) |
|  | Parameters | Returns a collection of parameters for this session.  (Inherited from IADSession) |
|  | PreviewSnapshot | Returns a OLE picture object containing the preview snapshot bitmap for the session.  (Inherited from IADSession) |
|  | Root | Returns the automation root.  (Inherited from IADSession) |
|  | RowCount | Gets the number of rows in BOM table |
|  | SelectedObjects | Returns all selected entities in the session's browser as a collection of target proxies.  (Inherited from IADSession) |
|  | SessionType | Returns a pre-defined constant that identifies whether this session is a part or assembly or drawing session.  (Inherited from IADSession) |
|  | Style | Gets the BOM table style. |
|  | TimeStamp | Returns time stamp of this session; the time stamp changes when changes are saved to the session.  (Inherited from IADSession) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SESSION)  (Inherited from IADSession) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | BindKeyToItem | Given a Persistent Key, returns the corresponding Occurrence/Topology element/Sketch.  (Inherited from IADSession) |
|  | Close | Closes the session and optionally saves before closing.  (Inherited from IADSession) |
|  | Columns | Gets all the columns in the BOM table. |
|  | CreatePackage | (Inherited from IADSession) |
|  | ExportBOM | Export the bill of materials as a .csv file. |
|  | ExportSTEP | Exports the BOM Table session as a Alibre STEP file. |
|  | Highlight | Highlights the object in the canvas.  (Inherited from IADSession) |
|  | NewTargetProxy | Creates a new TargetProxy for the given target and the occurrence  (Inherited from IADSession) |
|  | Rows | Gets all the rows in the BOM table. |
|  | Save | Saves modified session and sub-sessions, if any, to their original folder locations.  (Inherited from IADSession) |
|  | SaveAll | Saves a copy of the session and all sub-sessions to the directory indicated by the destination parameter.  (Inherited from IADSession) |
|  | SaveAs | Saves the session to create a new copy with the given name.  (Inherited from IADSession) |
|  | SaveCurrentViewSnapshot | Saves the snapshot of the graphic canvas for current view in the session, at the given location and of the given size.  (Inherited from IADSession) |
|  | SaveNew | Saves a new, unsaved session to the specified folder location.  (Inherited from IADSession) |
|  | Select | Selects all objects passed in pEntities.  (Inherited from IADSession) |
|  | SelectedObjectsEx | Returns all selected entities in the session's browser as a collection of target proxies, and sets the parameter lastSelectedPoint to last point in the user clicked to make the selection.  (Inherited from IADSession) |
|  | UpdatePreviewSnaphot | Captures the canvas image displayed for this session and silently saves it as the file snapshot property  (Inherited from IADSession) |
|  | Value | Gets the value stored at the provided row and column index. |



# IADDimension.Type Property

Returns a pre-defined constant that identifies the type of this object. (AD\_DIMENSION)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADSheets Interface

This interface represents the collection of all the sheets in a Drawing session.

#### Syntax

```
public interface IADSheets
```

The IADSheets type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ActiveSheet | Gets/sets the currently active drawing sheet. |
|  | Count | Returns the number of sheets in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the drawing session for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateBlankSheet | Create a new blank sheet with the specified size in the drawing session which owns this collection. |
|  | CreateSheetFromTemplate | Create a new sheet from a template file in the drawing session which owns this collection. |
|  | GetEnumerator | Returns an enumerator for the collection. |
|  | Item | Given a name or numerical index into the collection, returns the corresponding sheet. |



# IADDrawingView Properties

The IADDrawingView type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Name | Sets/Returns the name of this view. |
|  | Root | Returns the automation root object. |
|  | Sheet | Returns the drawing sheet to which this view belongs. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_DRAWING\_VIEW) |
|  | ViewType | The type of the view. (Standard, Draft, or Shaded) |



# IADBOMRow Properties

The IADBOMRow type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Height | Gets the height of this row. |
|  | IsCustomDefined | Returns true if this row is a custom defined row. |
|  | IsVisible | Returns true if this row is visible. |
|  | ItemNumber | Get the Row number. |
|  | Session | Gets owning BOM Table session. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. |



# IADBOMRows Properties

The IADBOMRows type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Gets the count of BOM rows in this collection. |
|  | Enum | Returns an enumerator for the collection. |



# IADSheet.Type Property

Returns a pre-defined constant that identifies the type of this object. (AD\_SHEET)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADSheet.GetSheetSize Method

Gets the size of the sheet, as defined by the template or blank sheet size selected.
In the UI this is indicated by the blue rectangular border.

#### Syntax

```
void GetSheetSize(
	out double width,
	out double height
)
```

#### Parameters

width  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The width of the drawing sheet.

height  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The height of the drawing sheet.

#### Remarks

Not all drawing sheets will have a defined sheet size. Imported DWG/DXF files and certain
legacy Drawing files will not, and instead return a sheet size of 0,0. For sheets which
return such a result, it is best to use instead the GetExtents
method to form a basis of the sheet's size.



# IADSheets.Item Method

Given a name or numerical index into the collection, returns the corresponding sheet.

#### Syntax

```
IADSheet Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The numerical index of a shell.

#### Return Value

IADSheet  
Returns IADSheet

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INDEX\_OUT\_OF\_BOUNDS | The specified index is outside of the bounds of the collection. |
| AD\_E\_OBJECT\_NOT\_FOUND\_AT\_INDEX | No object exists at the specified index. |



# IADSheets Properties

The IADSheets type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ActiveSheet | Gets/sets the currently active drawing sheet. |
|  | Count | Returns the number of sheets in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the drawing session for the collection. |



# IADBOMColumn Interface

IADBOMColumn interface

#### Syntax

```
public interface IADBOMColumn
```

The IADBOMColumn type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DataAlignment | Gets the data alignment under this column. |
|  | DataType | Gets the data type of the data stored in this column. |
|  | HeaderAlignment | Gets the header alignment of this column. |
|  | IsVisible | Returns true if this column is visible. |
|  | Name | Gets the display name of this column. |
|  | Session | Gets the owning BOM Table session. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. |
|  | Width | Gets the column width. |



# IADDrawingView.Type Property

Returns a pre-defined constant that identifies the type of this object. (AD\_DRAWING\_VIEW)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADDimension.Parameter Property

Returns the parameter associated with this dimension.

#### Syntax

```
IADParameter Parameter { get; }
```

#### Property Value

IADParameter



# IADDrawingSelectionFilter.Views Property

If true, Views are selectable.

#### Syntax

```
bool Views { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADBOMRow.ItemNumber Property

Get the Row number.

#### Syntax

```
string ItemNumber { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADDrawingSelectionFilter.Vertices Property

If true, vertices are selectable.

#### Syntax

```
bool Vertices { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADBOMTableSession.HeaderRowHeight Property

Gets the height of header row.

#### Syntax

```
double HeaderRowHeight { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADDrawingProperties.Number Property

Gets/Sets the number for the drawing. This is a user-specific string to denote version of the drawing.

#### Syntax

```
string Number { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADBOMTableSession.HeaderFontColor Property

Gets header font color.

#### Syntax

```
int HeaderFontColor { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADDimensions.PlaceRadialDimension Method

Places a radial dimension for Circle/CiruclarArc type figures.

#### Syntax

```
IADDimension PlaceRadialDimension(
	IADSketchFigure pSketchFigure,
	[OptionalAttribute] Object dimension
)
```

#### Parameters

pSketchFigure  IADSketchFigure
:   A sketch circle or
    circular arc to place the dimension upon.

dimension  [Object](https://learn.microsoft.com/dotnet/api/system.object)  (Optional)
:   The value to set the radius to. If null, the current
    dimension of the sketch figure will be used.

#### Return Value

IADDimension  
The created dimension.

#### Example

This Visual Basic sample shows how to call the PlaceRadialDimension method.

```
' Invoke Sketch Edit mode
Call objADSketch.BeginChange

' Add a sketch circle to sketch Figures
Set objADSketchFigure = objADSketch.Figures.AddCircle(0, 0, 5#)

' Holds Dimensions object
Dim objADDimensions As AlibreX.IADDimensions

' Get dimensions on the above sketch
Set objADDimensions = objADSketch.Dimensions

' Holds Dimension object
Dim objADDimension As AlibreX.IADDimension

' Place a radial dimension on the sketch circle
Set objADDimension = objADDimensions.PlaceRadialDimension(objADSketchFigure)

' Exit sketch Edit mode
Call objADSketch.EndChange
```



# IADSavedView.IsPerspective Property

Returns true if projection is set to perspective for this view.

#### Syntax

```
bool IsPerspective { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADDimensions.Sketch Property

Returns the parent sketch for the collection.

#### Syntax

```
IADSketch Sketch { get; }
```

#### Property Value

IADSketch



# IADSavedViews Methods

The IADSavedViews type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a saved view's name or index, returns the saved view. |



# IADSavedView.Type Property

Returns a pre-defined constant that identifies the type of this object.
(AD\_SAVED\_VIEW)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADSheet Interface

This interface represents a drawing sheet.

#### Syntax

```
public interface IADSheet
```

The IADSheet type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DissociatedDimensionCount |  |
|  | Name | Sets/Returns the name of this sheet. |
|  | Root | Returns the automation root object. |
|  | Session | Returns the drawing session to which this sheet belongs. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SHEET) |
|  | Views | Returns the collection of drawing views contained by this sheet. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CreateStandardViews | Create Standard Views of the specified part or assembly on this sheet. |
|  | GetExtents | Returns the extents of all views, annotations, and figures present in this drawing sheet. |
|  | GetSheetSize | Gets the size of the sheet, as defined by the template or blank sheet size selected. In the UI this is indicated by the blue rectangular border. |
|  | ModifySheetBlank | Modify this drawing sheet to use a blank sheet with the indicated parameters. |
|  | ModifySheetTemplate | Modify this drawing sheet to use a template with the indicated parameters. |



# IADBOMColumns.Item Method

Given a column's index, returns the column in the BOM table.

#### Syntax

```
IADBOMColumn Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The column's index.

#### Return Value

IADBOMColumn  
Returns IADBOMColumn



# IADSavedView.Name Property

Gets the name of this saved view.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADBOMColumn.HeaderAlignment Property

Gets the header alignment of this column.

#### Syntax

```
ADBOMTextAlignment HeaderAlignment { get; }
```

#### Property Value

ADBOMTextAlignment



# IADBOMTableSession.IsBottomUpDisplay Property

Returns whether table is in Bottom Up Display.

#### Syntax

```
bool IsBottomUpDisplay { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

For example, column headers at the bottom of the table, rather
than the top.



# IADBOMTableSession.HeaderFont Property

Gets header row font.

#### Syntax

```
IADDataFont HeaderFont { get; }
```

#### Property Value

IADDataFont



# IADDrawingSelectionFilter Properties

The IADDrawingSelectionFilter type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Annotations | If true, annotations are selectable. |
|  | Dimensions | If true, dimensions are selectable. |
|  | Parts | If true, Parts are selectable. |
|  | Redlines | If true, redlines are selectable. |
|  | Segments | If true, line segments are selectable. |
|  | Sketches2D | If true, 2D sketches are selectable. |
|  | Vertices | If true, vertices are selectable. |
|  | Views | If true, Views are selectable. |



# IADDimensions Interface

IADDimensions represents a collection of a sketch's dimensions.

#### Syntax

```
public interface IADDimensions
```

The IADDimensions type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of dimensions in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Sketch | Returns the parent sketch for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding dimension. |
|  | PlaceDiametricDimension | Places a diametric dimension. |
|  | PlaceLinearDimension(IADSketchLine, Object) | Places a linear dimension between the end points of the line. |
|  | PlaceLinearDimension(IADSketchPoint, IADSketchPoint, Object) | Places a linear dimension between two points. |
|  | PlaceRadialDimension | Places a radial dimension for Circle/CiruclarArc type figures. |



# IADDrawingViews.Count Property

Returns the number of views in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADDimensions.Count Property

Returns the number of dimensions in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADDrawingSelectionFilter.Redlines Property

If true, redlines are selectable.

#### Syntax

```
bool Redlines { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADSavedView.NearClippingDistanceFromCamera Property

Returns the distance of the near clipping plane of the view frustrum from
the camera.

#### Syntax

```
double NearClippingDistanceFromCamera { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADBOMTableSession Methods

The IADBOMTableSession type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | BindKeyToItem | Given a Persistent Key, returns the corresponding Occurrence/Topology element/Sketch.  (Inherited from IADSession) |
|  | Close | Closes the session and optionally saves before closing.  (Inherited from IADSession) |
|  | Columns | Gets all the columns in the BOM table. |
|  | CreatePackage | (Inherited from IADSession) |
|  | ExportBOM | Export the bill of materials as a .csv file. |
|  | ExportSTEP | Exports the BOM Table session as a Alibre STEP file. |
|  | Highlight | Highlights the object in the canvas.  (Inherited from IADSession) |
|  | NewTargetProxy | Creates a new TargetProxy for the given target and the occurrence  (Inherited from IADSession) |
|  | Rows | Gets all the rows in the BOM table. |
|  | Save | Saves modified session and sub-sessions, if any, to their original folder locations.  (Inherited from IADSession) |
|  | SaveAll | Saves a copy of the session and all sub-sessions to the directory indicated by the destination parameter.  (Inherited from IADSession) |
|  | SaveAs | Saves the session to create a new copy with the given name.  (Inherited from IADSession) |
|  | SaveCurrentViewSnapshot | Saves the snapshot of the graphic canvas for current view in the session, at the given location and of the given size.  (Inherited from IADSession) |
|  | SaveNew | Saves a new, unsaved session to the specified folder location.  (Inherited from IADSession) |
|  | Select | Selects all objects passed in pEntities.  (Inherited from IADSession) |
|  | SelectedObjectsEx | Returns all selected entities in the session's browser as a collection of target proxies, and sets the parameter lastSelectedPoint to last point in the user clicked to make the selection.  (Inherited from IADSession) |
|  | UpdatePreviewSnaphot | Captures the canvas image displayed for this session and silently saves it as the file snapshot property  (Inherited from IADSession) |
|  | Value | Gets the value stored at the provided row and column index. |



# IADBOMColumns Interface

IADBOMColumns interface

#### Syntax

```
public interface IADBOMColumns
```

The IADBOMColumns type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Gets count of BOM columns in this collection. |
|  | Enum | Returns an enumerator for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a column's index, returns the column in the BOM table. |



# IADDimensions.Item Method

Given a numerical index into the collection, returns the corresponding dimension.

#### Syntax

```
IADDimension Item(
	int index
)
```

#### Parameters

index  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The numerical index of the dimension.

#### Return Value

IADDimension  
Returns IADDimension



# IADDrawingView Interface

This interface represents a drawing view.

#### Syntax

```
public interface IADDrawingView
```

The IADDrawingView type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Name | Sets/Returns the name of this view. |
|  | Root | Returns the automation root object. |
|  | Sheet | Returns the drawing sheet to which this view belongs. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_DRAWING\_VIEW) |
|  | ViewType | The type of the view. (Standard, Draft, or Shaded) |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetExtents | Returns the extents of this drawing view within the sheet. |



# IADSavedViews.Count Property

Gets the count of saved views in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADDrawingSession.Properties Property

Returns the drawing properties of the drawing.

#### Syntax

```
IADDrawingProperties Properties { get; }
```

#### Property Value

IADDrawingProperties



# IADBOMTableSession.Style Property

Gets the BOM table style.

#### Syntax

```
ADBOMTableStyle Style { get; }
```

#### Property Value

ADBOMTableStyle



# IADBOMColumns Methods

The IADBOMColumns type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a column's index, returns the column in the BOM table. |



# IADBOMTableSession.ExportBOM Method

Export the bill of materials as a .csv file.

#### Syntax

```
void ExportBOM(
	string fileName,
	bool includeHiddenRows
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the exported file.

includeHiddenRows  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If true, hidden rows will also be exported.



# IADDrawingViews Properties

The IADDrawingViews type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of views in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Session | Returns the drawing session for the collection. |



# IADBOMRows.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADSheet.Root Property

Returns the automation root object.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADBOMRow.Height Property

Gets the height of this row.

#### Syntax

```
double Height { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADDimensions Properties

The IADDimensions type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of dimensions in this collection. |
|  | Enum | Returns an enumerator for the collection. |
|  | Sketch | Returns the parent sketch for the collection. |



# IADSheet.Views Property

Returns the collection of drawing views contained by this sheet.

#### Syntax

```
IADDrawingViews Views { get; }
```

#### Property Value

IADDrawingViews



# IADSheets.Session Property

Returns the drawing session for the collection.

#### Syntax

```
IADDrawingSession Session { get; }
```

#### Property Value

IADDrawingSession



# IADSavedViews.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADDrawingViews.GetEnumerator Method

Returns an enumerator for the collection.

#### Syntax

```
IEnumerator GetEnumerator()
```

#### Return Value

[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator)



# IADBOMColumn Properties

The IADBOMColumn type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DataAlignment | Gets the data alignment under this column. |
|  | DataType | Gets the data type of the data stored in this column. |
|  | HeaderAlignment | Gets the header alignment of this column. |
|  | IsVisible | Returns true if this column is visible. |
|  | Name | Gets the display name of this column. |
|  | Session | Gets the owning BOM Table session. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. |
|  | Width | Gets the column width. |



# IADBOMColumn.DataType Property

Gets the data type of the data stored in this column.

#### Syntax

```
ADBOMDataType DataType { get; }
```

#### Property Value

ADBOMDataType



# ADBOMTableStyle Enumeration

#### Syntax

```
public enum ADBOMTableStyle
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_BOM\_WITH\_NO\_LINES | 0 |  |
| AD\_BOM\_WITH\_ROW\_LINES | 1 |  |
| AD\_BOM\_WITH\_COLUMN\_LINES | 2 |  |
| AD\_BOM\_WITH\_ROW\_COLUMN\_LINES | 3 |  |
| AD\_BOM\_UNKNOWN\_TYPE | -1 |  |



# IADDrawingViews.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADDrawingSelectionFilter.Sketches2D Property

If true, 2D sketches are selectable.

#### Syntax

```
bool Sketches2D { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# ADBOMDataType Enumeration

#### Syntax

```
public enum ADBOMDataType
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD\_DATA\_TYPE\_NUMBER | 0 |  |
| AD\_DATA\_TYPE\_TEXT | 1 |  |
| AD\_DATA\_TYPE\_DATE | 2 |  |
| AD\_DATA\_TYPE\_PARAMETER | 3 |  |
| AD\_DATA\_TYPE\_UNKNOWN | -1 |  |



# IADBOMRow.Value Method

Gets the value stored at the provided column index.

#### Syntax

```
string Value(
	int pColumnIndex
)
```

#### Parameters

pColumnIndex  [Int32](https://learn.microsoft.com/dotnet/api/system.int32)
:   The index of the column to get the value from.

#### Return Value

[String](https://learn.microsoft.com/dotnet/api/system.string)  
The contents of the cell.



# IADBOMRows Interface

IADBOMRows interface

#### Syntax

```
public interface IADBOMRows
```

The IADBOMRows type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Gets the count of BOM rows in this collection. |
|  | Enum | Returns an enumerator for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a row's index, returns the row in the BOM table. |



# IADDrawingProperties.Description Property

Gets/sets the description for the drawing.

#### Syntax

```
string Description { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADDrawingSession.ExportSTEP Method

Exports the drawing session as a Alibre STEP file.

#### Syntax

```
void ExportSTEP(
	string fileName
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the exported file.



# IADSavedView.DesignSession Property

Gets the design session for this saved view.

#### Syntax

```
IADDesignSession DesignSession { get; }
```

#### Property Value

IADDesignSession



# IADDrawingSelectionFilter.Dimensions Property

If true, dimensions are selectable.

#### Syntax

```
bool Dimensions { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADBOMColumns Properties

The IADBOMColumns type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Gets count of BOM columns in this collection. |
|  | Enum | Returns an enumerator for the collection. |



# IADSheets.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADSavedView.FieldOfView Property

Returns the field of view angle for perspective projection.

#### Syntax

```
double FieldOfView { get; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADDrawingSession.SelectionFilter Property

Gets the interface to this drawing session's selection filter. The interface's properties
can be queried to find the current settings or set to change the active selection filters.

#### Syntax

```
IADDrawingSelectionFilter SelectionFilter { get; }
```

#### Property Value

IADDrawingSelectionFilter



# IADDrawingView.ViewType Property

The type of the view. (Standard, Draft, or Shaded)

#### Syntax

```
ADDrawingViewType ViewType { get; }
```

#### Property Value

ADDrawingViewType



# IADDrawingSession.ReprojectViews Method

Reproject all or a set of drawing views contained in the drawing session, optionally
changing their view display mode.

#### Syntax

```
void ReprojectViews(
	IObjectCollector views,
	ADDrawingViewType projectViewMode,
	bool retainViewType
)
```

#### Parameters

views  IObjectCollector
:   A collection of the drawing views selected for reprojection. Use IADDrawingView objects
    to specify individual views or IADSheet objects to indicate all views contained in the specified
    sheet should be reprojected. Passing a null value will select all views for reprojection.

projectViewMode  ADDrawingViewType
:   Use this parameter to select a view mode, which all of the selected views will be
    reprojected as. If retainViewType is true, this will be ignored.

retainViewType  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)
:   If set to true, the projectViewMode parameter will be ignored, and all reprojected views
    will maintain their original view mode.



# IADDrawingSession.ExportDXF Method

Exports the drawing session as a AUTOCAD DXF file.

#### Syntax

```
void ExportDXF(
	string fileName
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the exported file.



# IADDimensions.PlaceLinearDimension Method

#### Overload List

|  | Name | Description |
| --- | --- | --- |
|  | PlaceLinearDimension(IADSketchLine, Object) | Places a linear dimension between the end points of the line. |
|  | PlaceLinearDimension(IADSketchPoint, IADSketchPoint, Object) | Places a linear dimension between two points. |



# IADDrawingSelectionFilter.Parts Property

If true, Parts are selectable.

#### Syntax

```
bool Parts { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADSheets.Count Property

Returns the number of sheets in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADDrawingSelectionFilter Interface

IADDrawingSelectionFilter provides an interface to change the active selection filters for a Drawing session.

#### Syntax

```
public interface IADDrawingSelectionFilter
```

The IADDrawingSelectionFilter type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Annotations | If true, annotations are selectable. |
|  | Dimensions | If true, dimensions are selectable. |
|  | Parts | If true, Parts are selectable. |
|  | Redlines | If true, redlines are selectable. |
|  | Segments | If true, line segments are selectable. |
|  | Sketches2D | If true, 2D sketches are selectable. |
|  | Vertices | If true, vertices are selectable. |
|  | Views | If true, Views are selectable. |



# IADDimensions.PlaceLinearDimension(IADSketchLine, Object) Method

Places a linear dimension between the end points of the line.

#### Syntax

```
IADDimension PlaceLinearDimension(
	IADSketchLine pSketchLine,
	[OptionalAttribute] Object dimension
)
```

#### Parameters

pSketchLine  IADSketchLine
:   The sketch line to place
    the dimension upon.

dimension  [Object](https://learn.microsoft.com/dotnet/api/system.object)  (Optional)
:   The value to set the linear dimension to. If null, the current
    dimension of the line will be used.

#### Return Value

IADDimension  
The created dimension.

#### Example

This Visual Basic sample shows how to use the PlaceLinearDimension method.

```
' Invoke Sketch Edit mode
Call objADSketch.BeginChange

' Add a sketch Line to sketch Figures
Set objADSketchFigure = objADSketch.Figures.AddLine(0, -0.75, 0, 0.75)

' Holds Dimensions object
Dim objADDimensions As AlibreX.IADDimensions

' Get dimensions on the above sketch
Set objADDimensions = objADSketch.Dimensions

' Holds Dimension object
Dim objADDimension As AlibreX.IADDimension

' Place a linear dimension on the sketch line
Set objADDimension = objADDimensions.PlaceLinearDimension(objADSketchFigure)

' Exit sketch Edit mode
Call objADSketch.EndChange
```



# IADDrawingViews.Item Method

Given a name or numerical index into the collection, returns the corresponding view.

#### Syntax

```
IADDrawingView Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or numerical index of a view.

#### Return Value

IADDrawingView  
Returns IADDrawingView

#### Exceptions

| Exception | Condition |
| --- | --- |
| AD\_E\_INDEX\_OUT\_OF\_BOUNDS | The specified index is outside of the bounds of the collection. |
| AD\_E\_OBJECT\_NOT\_FOUND\_AT\_INDEX | No object exists at the specified index. |



# IADDimensions.PlaceLinearDimension(IADSketchPoint, IADSketchPoint, Object) Method

Places a linear dimension between two points.

#### Syntax

```
IADDimension PlaceLinearDimension(
	IADSketchPoint pStartSketchPoint,
	IADSketchPoint pEndSketchPoint,
	[OptionalAttribute] Object dimension
)
```

#### Parameters

pStartSketchPoint  IADSketchPoint
:   First point to be used for dimensioning.

pEndSketchPoint  IADSketchPoint
:   Second point to be used for dimensioning.

dimension  [Object](https://learn.microsoft.com/dotnet/api/system.object)  (Optional)
:   The value to set the linear dimension to. If null, the current
    dimension between the two points will be used.

#### Return Value

IADDimension  
The created dimension.



# IADDrawingSession Properties

The IADDrawingSession type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | ConstituentFilePaths | Returns file path strings for other Design files that are referenced by this session.  (Inherited from IADSession) |
|  | FilePath | Returns the location on disk of where the file was last saved. If unsaved, returns null.  (Inherited from IADSession) |
|  | GeometryFactory | Returns the Geometry Factory.  (Inherited from IADSession) |
|  | Identifier | Returns the session's unique identifier.  (Inherited from IADSession) |
|  | IsGUIVisible | Returns True if the GUI for this session is visible.  (Inherited from IADSession) |
|  | Name | Returns this session's name.  (Inherited from IADSession) |
|  | Parameters | Returns a collection of parameters for this session.  (Inherited from IADSession) |
|  | PreviewSnapshot | Returns a OLE picture object containing the preview snapshot bitmap for the session.  (Inherited from IADSession) |
|  | Properties | Returns the drawing properties of the drawing. |
|  | Root | Returns the automation root.  (Inherited from IADSession) |
|  | SelectedObjects | Returns all selected entities in the session's browser as a collection of target proxies.  (Inherited from IADSession) |
|  | SelectionFilter | Gets the interface to this drawing session's selection filter. The interface's properties can be queried to find the current settings or set to change the active selection filters. |
|  | SessionType | Returns a pre-defined constant that identifies whether this session is a part or assembly or drawing session.  (Inherited from IADSession) |
|  | Sheets | Gets the collection of sheets in the drawing. |
|  | TimeStamp | Returns time stamp of this session; the time stamp changes when changes are saved to the session.  (Inherited from IADSession) |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SESSION)  (Inherited from IADSession) |



# IADSheet.Name Property

Sets/Returns the name of this sheet.

#### Syntax

```
string Name { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADBOMTableSession.DataFont Property

Gets the data font in the table.

#### Syntax

```
IADDataFont DataFont { get; }
```

#### Property Value

IADDataFont



# IADDrawingSelectionFilter.Segments Property

If true, line segments are selectable.

#### Syntax

```
bool Segments { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADSheet.DissociatedDimensionCount Property

#### Syntax

```
int DissociatedDimensionCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADDimensions.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADBOMRow.Type Property

Returns a pre-defined constant that identifies the type of this object.

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADDrawingView.GetExtents Method

Returns the extents of this drawing view within the sheet.

#### Syntax

```
void GetExtents(
	out IAD2DPoint pLower,
	out IAD2DPoint pUpper
)
```

#### Parameters

pLower  IAD2DPoint
:   The lower extent point.

pUpper  IAD2DPoint
:   The upper extent point.



# IADDimensions.PlaceDiametricDimension Method

Places a diametric dimension.

#### Syntax

```
IADDimension PlaceDiametricDimension(
	IADSketchCircle pSketchCircle,
	[OptionalAttribute] Object dimension
)
```

#### Parameters

pSketchCircle  IADSketchCircle
:   A sketch circle to
    place the dimension upon.

dimension  [Object](https://learn.microsoft.com/dotnet/api/system.object)  (Optional)
:   The value to set the diameter to. If null, the current
    dimension of the sketch figure will be used.

#### Return Value

IADDimension  
The created dimension.

#### Example

This Visual Basic sample shows how to call the PlaceDiametricDimension method.

```
' Invoke Sketch Edit mode
Call objADSketch.BeginChange

' Add a sketch circle to sketch Figures
Set objADSketchFigure = objADSketch.Figures.AddCircle(0, 0, 5#)

' Holds Dimensions object
Dim objADDimensions As AlibreX.IADDimensions

' Get dimensions on the above sketch
Set objADDimensions = objADSketch.Dimensions

' Holds Dimension object
Dim objADDimension As AlibreX.IADDimension

' Place a diametric dimension on the sketch circle
Set objADDimension = objADDimensions.PlaceDiametricDimension(objADSketchFigure)

' Exit sketch Edit mode
Call objADSketch.EndChange
```



# IADSheets.CreateSheetFromTemplate Method

Create a new sheet from a template file in the drawing session which owns this collection.

#### Syntax

```
IADSheet CreateSheetFromTemplate(
	string sheetName,
	string templateName,
	double defaultScaleNumerator = 1,
	double defaultScaleDenomenator = 1,
	bool retainTemplateLayers = true,
	bool overwriteExistingLayers = false,
	bool overwriteExistingDimStyles = false
)
```

#### Parameters

sheetName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new sheet. If null, the default automatically generated name will be used.

templateName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the template to be used by the created sheet.
    A list of available templates can be found using the InstalledDrawingTemplates property.

defaultScaleNumerator  [Double](https://learn.microsoft.com/dotnet/api/system.double)  (Optional)
:   The numerator of the default scale of placed drawing views.

defaultScaleDenomenator  [Double](https://learn.microsoft.com/dotnet/api/system.double)  (Optional)
:   The denominator of the default scale of placed drawing views.

retainTemplateLayers  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)  (Optional)
:   If true, layers defined in the template will be brought into the drawing.

overwriteExistingLayers  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)  (Optional)
:   If the template contains layers with the same name as layers already present
    in the drawing, this parameter will indicate which should be used.

overwriteExistingDimStyles  [Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)  (Optional)
:   If the template contains dimension styles with the same name as dimension styles
    already present in the drawing, this parameter will indicate which should be used.

#### Return Value

IADSheet  
The created sheet.



# IADBOMColumn.Session Property

Gets the owning BOM Table session.

#### Syntax

```
IADBOMTableSession Session { get; }
```

#### Property Value

IADBOMTableSession



# IADBOMRow Interface

IADBOMRow interface

#### Syntax

```
public interface IADBOMRow
```

The IADBOMRow type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Height | Gets the height of this row. |
|  | IsCustomDefined | Returns true if this row is a custom defined row. |
|  | IsVisible | Returns true if this row is visible. |
|  | ItemNumber | Get the Row number. |
|  | Session | Gets owning BOM Table session. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Value | Gets the value stored at the provided column index. |



# IADSheet.CreateStandardViews Method

Create Standard Views of the specified part or assembly on this sheet.

#### Syntax

```
IObjectCollector CreateStandardViews(
	string designFilePath,
	ADDrawingViewType viewType,
	ADDetailingOption detailingOptions,
	double scaleNumerator,
	double scaleDenominator,
	ADViewOrientation viewOrientations,
	IAD2DPoint insertionPoint,
	IADTransformation workspaceOrientation = null,
	Object designConfiguration = null,
	Object explodedView = null
)
```

#### Parameters

designFilePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The path of the file to create views of.
    Must be a Alibre part, sheet metal, or assembly file.

viewType  ADDrawingViewType
:   The type of views to be created. Can be standard,
    draft, shaded.

detailingOptions  ADDetailingOption
:   Which detailing options should be used when creating the views. The ADDetailingOption enum uses flags,
    which may be combined using bitwise OR to indicate a particular set of multiple options.

scaleNumerator  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The numerator of the scale of the projected view.

scaleDenominator  [Double](https://learn.microsoft.com/dotnet/api/system.double)
:   The denominator of the scale of the projected view.

viewOrientations  ADViewOrientation
:   The standard view orientations which will be projected. The ADViewOrientation
    enum uses flags, which may be combined using bitwise OR to create a set of multiple
    views at once.

insertionPoint  IAD2DPoint
:   The point on the sheet where the views will be inserted. This is the centerpoint of the inserted views,
    the same as when clicking to insert standard views through the GUI.

workspaceOrientation  IADTransformation  (Optional)
:   This parameter may be used to specify a custom workspace orientation to be used as the Front
    view projetion. If null, the default Front view from the design will be used.

designConfiguration  [Object](https://learn.microsoft.com/dotnet/api/system.object)  (Optional)
:   This parameter may be used to specify a specific configuration of the design to be projected.
    It may be specified either by passing the IADConfiguration object, or a string of the configuration's name.
    If a null value is passed, the active configuration will be used.

explodedView  [Object](https://learn.microsoft.com/dotnet/api/system.object)  (Optional)
:   If the design is an assembly and contains an exploded view, this parameter may be used to indicate
    it should be projected in the drawing as such. It may be specified either by the IADExplodedView object or
    a string with the exploded view's name. For a null value, no exploded view will be used.

#### Return Value

IObjectCollector  
A collection of the created IADDrawingViews.



# IADDimensions Methods

The IADDimensions type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a numerical index into the collection, returns the corresponding dimension. |
|  | PlaceDiametricDimension | Places a diametric dimension. |
|  | PlaceLinearDimension(IADSketchLine, Object) | Places a linear dimension between the end points of the line. |
|  | PlaceLinearDimension(IADSketchPoint, IADSketchPoint, Object) | Places a linear dimension between two points. |
|  | PlaceRadialDimension | Places a radial dimension for Circle/CiruclarArc type figures. |



# IADSavedView Methods

The IADSavedView type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | GetExtents | Gets the extents of the view, in screen co-ordinates. |



# IADBOMColumn.Name Property

Gets the display name of this column.

#### Syntax

```
string Name { get; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADBOMRows.Count Property

Gets the count of BOM rows in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADDrawingViews.Session Property

Returns the drawing session for the collection.

#### Syntax

```
IADDrawingSession Session { get; }
```

#### Property Value

IADDrawingSession



# IADBOMRow.Session Property

Gets owning BOM Table session.

#### Syntax

```
IADBOMTableSession Session { get; }
```

#### Property Value

IADBOMTableSession



# IADSavedViews Interface

IADSavedViews represents the collection of pre-defined and user-created views
for a design session. The views in this collection mirror the list in the
Orientations window of the Alibre GUI. You can get this collection by querying
the SavedViews property of
IADDesignSession.

#### Syntax

```
public interface IADSavedViews
```

The IADSavedViews type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Gets the count of saved views in this collection. |
|  | Enum | Returns an enumerator for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Item | Given a saved view's name or index, returns the saved view. |



# IADBOMColumns.Count Property

Gets count of BOM columns in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADSavedViews.Item Method

Given a saved view's name or index, returns the saved view.

#### Syntax

```
IADSavedView Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or numerical index of a saved view.

#### Return Value

IADSavedView  
Returns IADSavedView



# IADDrawingSession.ExportDWG Method

Exports the drawing session as a AUTOCAD DWG file.

#### Syntax

```
void ExportDWG(
	string fileName
)
```

#### Parameters

fileName  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The filepath of the exported file.



# IADSavedView.UpVector Property

Returns the upvector of the target that is being looked at by the camera.

#### Syntax

```
IADPoint UpVector { get; }
```

#### Property Value

IADPoint



# IADSheet Properties

The IADSheet type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | DissociatedDimensionCount |  |
|  | Name | Sets/Returns the name of this sheet. |
|  | Root | Returns the automation root object. |
|  | Session | Returns the drawing session to which this sheet belongs. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_SHEET) |
|  | Views | Returns the collection of drawing views contained by this sheet. |



# ADAutoCADVersion Enumeration

This enumeration identifies the AutoCAD versions supported for DWG and DXF export.

#### Syntax

```
public enum ADAutoCADVersion
```

#### Members

| Member name | Value | Description |
| --- | --- | --- |
| AD_AUTOCAD_R14 | 0 | AutoCAD Release 14 |
| AD_AUTOCAD_2000 | 1 | AutoCAD 2000 |
| AD_AUTOCAD_2004 | 2 | AutoCAD 2004 |
| AD_AUTOCAD_2007 | 3 | AutoCAD 2007 |
| AD_AUTOCAD_2010 | 4 | AutoCAD 2010 |
| AD_AUTOCAD_2013 | 5 | AutoCAD 2013 |
| AD_AUTOCAD_2018 | 6 | AutoCAD 2018 |



# IADDrawingSession.ExportDWGVersion Method

Exports the current sheet of the drawing session as an AutoCAD DWG file with the specified version.

#### Syntax

```
void ExportDWGVersion(
	string filePath,
	ADAutoCADVersion version
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The path of the file to save the DWG drawing to.

version  ADAutoCADVersion
:   The AutoCAD version format to export.



# IADDrawingSession.ExportDXFVersion Method

Exports the current sheet of the drawing session as an AutoCAD DXF file with the specified version.

#### Syntax

```
void ExportDXFVersion(
	string filePath,
	ADAutoCADVersion version
)
```

#### Parameters

filePath  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The path of the file to save the DXF drawing to.

version  ADAutoCADVersion
:   The AutoCAD version format to export.
