# AlibreX API — Parameters & Equations

> Part of the split AlibreX reference. See `00_index.md` for the full map.

**Sections in this file:** 27

---


# IADParameters.OpenParameterTransaction Method

Open a parameter transaction.

#### Syntax

```
void OpenParameterTransaction()
```



# IADParameter.Units Property

Sets/Returns the units for the parameter's value.

#### Syntax

```
ADUnits Units { get; set; }
```

#### Property Value

ADUnits



# IADParameters.CancelParameterTransaction Method

Cancel a parameter transaction.

#### Syntax

```
void CancelParameterTransaction()
```



# IADParameters.CloseParameterTransaction Method

Close a parameter transaction.

#### Syntax

```
void CloseParameterTransaction()
```



# IADParameters.Item Method

Given a numerical index into the collection or name of a parameter, returns the corresponding parameter.

#### Syntax

```
IADParameter Item(
	Object index
)
```

#### Parameters

index  [Object](https://learn.microsoft.com/dotnet/api/system.object)
:   The name or numerical index of a parameter.

#### Return Value

IADParameter  
Returns IADParameter



# IADParameter.Remove Method

Removes the parameter.

#### Syntax

```
void Remove()
```



# IADParameter.Name Property

Sets/Returns the name of the parameter.

#### Syntax

```
string Name { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADParameter.Type Property

Returns a pre-defined constant that identifies the type of this object. (AD\_PARAMETER)

#### Syntax

```
ADObjectType Type { get; }
```

#### Property Value

ADObjectType



# IADParameter Interface

IADParameter interface

#### Syntax

```
public interface IADParameter
```

The IADParameter type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | comment | Sets/Returns the comment for the parameter. |
|  | Equation | Sets/Returns current equation of the parameter. |
|  | ExternallyDriven | Sets/Returns the 'externally driven' property for the parameter. |
|  | IsConflictingGlobal | Returns true if there is a conflicting global and local parameter. |
|  | IsMissingGlobal | Returns true if the file defining the global parameters is missing. |
|  | Name | Sets/Returns the name of the parameter. |
|  | ParameterType | Returns the type of the parameter. |
|  | Root | Returns the automation root object. |
|  | SourceDocumentID | Sets/Returns the source Document ID for an externally driven parameter. |
|  | SourceItemID | Sets/Returns the source Item ID for an externally driven parameter. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PARAMETER) |
|  | Units | Sets/Returns the units for the parameter's value. |
|  | Value | Sets/Returns the value of the parameter. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Remove | Removes the parameter. |



# IADParameters.Enum Property

Returns an enumerator for the collection.

#### Syntax

```
DIEnum Enum { get; }
```

#### Property Value

DIEnum



# IADParameter Methods

The IADParameter type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | Remove | Removes the parameter. |



# IADParameter.Root Property

Returns the automation root object.

#### Syntax

```
IADRoot Root { get; }
```

#### Property Value

IADRoot



# IADParameters Properties

The IADParameters type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of parameters in this collection. |
|  | Enum | Returns an enumerator for the collection. |



# IADParameter.SourceItemID Property

Sets/Returns the source Item ID for an externally driven parameter.

#### Syntax

```
string SourceItemID { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADParameters Interface

IADParameters Interface

#### Syntax

```
public interface IADParameters
```

The IADParameters type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | Count | Returns the number of parameters in this collection. |
|  | Enum | Returns an enumerator for the collection. |

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CancelParameterTransaction | Cancel a parameter transaction. |
|  | CloseParameterTransaction | Close a parameter transaction. |
|  | Item | Given a numerical index into the collection or name of a parameter, returns the corresponding parameter. |
|  | NewParameter | Creates a new parameter and returns its interface. |
|  | OpenParameterTransaction | Open a parameter transaction. |



# IADParameter.ExternallyDriven Property

Sets/Returns the 'externally driven' property for the parameter.

#### Syntax

```
bool ExternallyDriven { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADParameter.Equation Property

Sets/Returns current equation of the parameter.

#### Syntax

```
string Equation { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADParameters.NewParameter Method

Creates a new parameter and returns its interface.

#### Syntax

```
IADParameter NewParameter(
	string name,
	ADParameterType type
)
```

#### Parameters

name  [String](https://learn.microsoft.com/dotnet/api/system.string)
:   The name of the new parameter.

type  ADParameterType
:   The type of parameter to create.

#### Return Value

IADParameter  
Returns an interface to the new parameter.



# IADParameter.Value Property

Sets/Returns the value of the parameter.

#### Syntax

```
double Value { get; set; }
```

#### Property Value

[Double](https://learn.microsoft.com/dotnet/api/system.double)



# IADParameter.IsConflictingGlobal Property

Returns true if there is a conflicting global and local parameter.

#### Syntax

```
bool IsConflictingGlobal { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADParameters Methods

The IADParameters type exposes the following members.

#### Methods

|  | Name | Description |
| --- | --- | --- |
|  | CancelParameterTransaction | Cancel a parameter transaction. |
|  | CloseParameterTransaction | Close a parameter transaction. |
|  | Item | Given a numerical index into the collection or name of a parameter, returns the corresponding parameter. |
|  | NewParameter | Creates a new parameter and returns its interface. |
|  | OpenParameterTransaction | Open a parameter transaction. |



# IADParameters.Count Property

Returns the number of parameters in this collection.

#### Syntax

```
int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/dotnet/api/system.int32)



# IADParameter.ParameterType Property

Returns the type of the parameter.

#### Syntax

```
ADParameterType ParameterType { get; }
```

#### Property Value

ADParameterType



# IADParameter.comment Property

Sets/Returns the comment for the parameter.

#### Syntax

```
string comment { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADParameter.IsMissingGlobal Property

Returns true if the file defining the global parameters is missing.

#### Syntax

```
bool IsMissingGlobal { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/dotnet/api/system.boolean)



# IADParameter.SourceDocumentID Property

Sets/Returns the source Document ID for an externally driven parameter.

#### Syntax

```
string SourceDocumentID { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/dotnet/api/system.string)



# IADParameter Properties

The IADParameter type exposes the following members.

#### Properties

|  | Name | Description |
| --- | --- | --- |
|  | comment | Sets/Returns the comment for the parameter. |
|  | Equation | Sets/Returns current equation of the parameter. |
|  | ExternallyDriven | Sets/Returns the 'externally driven' property for the parameter. |
|  | IsConflictingGlobal | Returns true if there is a conflicting global and local parameter. |
|  | IsMissingGlobal | Returns true if the file defining the global parameters is missing. |
|  | Name | Sets/Returns the name of the parameter. |
|  | ParameterType | Returns the type of the parameter. |
|  | Root | Returns the automation root object. |
|  | SourceDocumentID | Sets/Returns the source Document ID for an externally driven parameter. |
|  | SourceItemID | Sets/Returns the source Item ID for an externally driven parameter. |
|  | Type | Returns a pre-defined constant that identifies the type of this object. (AD\_PARAMETER) |
|  | Units | Sets/Returns the units for the parameter's value. |
|  | Value | Sets/Returns the value of the parameter. |

