# Alibre Design Add-On Workspace

This workspace builds **Alibre Design add-ons** against the **AlibreX**
automation API.

- `Reference/` is a **read-only knowledge base** (API docs + Alibre's official
  sample add-ons). Never edit anything under it; treat it as source of truth.
- Put each add-on in its own top-level folder: `src/<AddOnName>/`.
- `.claude/machine.md` holds the paths discovered on *this* machine. It ships
  as a **blank template** and is filled in by discovery on first run (§0.1).
  It is machine-specific and is not shared knowledge.

---

## 0. First run — do this before writing any code

Alibre installs to a **version-stamped folder** and the add-on registration
points don't exist on a clean machine, so nothing here can be assumed. Two
things must happen before scaffolding a project.

### 0.1 Load or (re)create `.claude/machine.md`

The file ships as a **blank template** (status `UNFILLED`, no hostname) so the
kit can be copied to any machine. Trust it **only** when all three hold:

1. it exists;
2. its first line is `<!-- machine-profile status: FILLED -->`;
3. its recorded **Hostname** equals this machine's name (`$env:COMPUTERNAME`
   in PowerShell, `hostname` in Git Bash).

- **If all three hold**, read it and use those paths. Spot-check that the
  Alibre install path still exists before relying on it (the user may have
  upgraded — the folder name changes with the version). If it is gone, treat
  the file as stale and fall through to discovery.
- **Otherwise** — missing, still `UNFILLED`, or written on a different
  machine — tell the user their Alibre installation must be located, run the
  discovery below, and **overwrite** the file in the §0.3 shape with status
  `FILLED`, this machine's hostname and today's date. Every value must come
  from discovery on *this* machine; never carry values over from another
  machine, from memory, or from the examples in this document.

Discovery (PowerShell; Git Bash equivalents work too):

```powershell
# Alibre install (version-stamped -- do NOT assume "Alibre Design")
Get-ChildItem "C:\Program Files" -Filter "Alibre Design*" -Directory

# API binaries and type libraries
Get-ChildItem "C:\Program Files\Alibre Design <version>\Program" |
    Where-Object { $_.Name -match 'AlibreX|AlibreAddOn|registerCOMdlls' }

# Toolchain
& "C:\Program Files (x86)\Microsoft Visual Studio\Installer\vswhere.exe" -products * -format json
Get-ChildItem "<VS install>\VC\Tools\MSVC"                 # MSVC toolset(s)
Get-ChildItem "<VS install>\VC\Tools\MSVC\*\atlmfc"        # MFC -- see 0.2
Get-ChildItem "C:\Program Files (x86)\Windows Kits\10\Include"

# Deployment points (both are often absent on a clean machine)
Test-Path "$env:ProgramData\Alibre AddOns"
Test-Path "HKLM:\SOFTWARE\Alibre Design Add-Ons"
```

Record the results in `.claude/machine.md` — overwriting the blank template —
using the shape in §0.3.

### 0.2 Toolchain gate — check this BEFORE writing C++

Integrated add-ons are C++/MFC. **MFC is not part of the "Desktop development
with C++" workload** — it is a separate optional component, and its absence is
a hard build blocker that surfaces only at build time as a confusing MSBuild
error:

```
error MSB4019: The imported project "...\VC\v<N>\Microsoft.Cpp.Default.props" was not found.
```

That message means the C++ toolset is missing entirely. A missing *MFC* shows up
later as `afxwin.h` not found.

Verify by checking that **`<VS install>\VC\Tools\MSVC\<ver>\atlmfc`** exists. If
it doesn't, stop and tell the user to add, in the Visual Studio Installer:

1. Workload: **Desktop development with C++**
2. Individual component: **C++ MFC for latest v14x build tools (x86 & x64)**
3. A **Windows 11 SDK** (the workload selects one by default; one is enough —
   the project floats to the newest installed)

Do not scaffold a C++ project and leave the user to discover this at build time.

### 0.3 Shape of `.claude/machine.md`

Line 1 is the status marker that §0.1 keys on, followed by a small header
table and then the paths table:

```
<!-- machine-profile status: FILLED -->
```

| Field | Value |
|---|---|
| Hostname | machine name as discovered |
| Discovered on | date of discovery (YYYY-MM-DD) |

| What | Path |
|---|---|
| Alibre install root | `C:\Program Files\Alibre Design <version>\` |
| API binaries / TLBs | `…\Program\` (`AlibreX.dll`, `AlibreX_64.tlb`, `AlibreAddOn.dll`, `AlibreAddOn_64.tlb`) |
| Headless COM registration | `…\Program\registerCOMdlls.BAT` (run as admin) |
| Executable | `…\Program\Alibre Design.exe` |
| App data | `C:\ProgramData\Alibre Design\<version>\` |
| Deploy target | `C:\ProgramData\Alibre AddOns\<AddOnName>\` |
| Registry key | `HKLM\SOFTWARE\Alibre Design Add-Ons` |
| Visual Studio | edition, version, install path |
| MSVC toolset | version + whether `atlmfc` is present |
| Windows SDK | installed versions |
| MSBuild | `<VS install>\MSBuild\Current\Bin\MSBuild.exe` |

End with a **Notes** section for anything discovery turned up that affects
later steps: side-by-side Alibre installs, an unusual Visual Studio version,
existing add-on registrations. The shipped template has the same layout with
every value marked `*(unfilled)*` and status `UNFILLED`.

---

## 1. Research workflow — start here every time

Before answering API questions or writing API code, **always** consult the
documentation in this order. The type library is large (~2,000 members), so the
docs are split by domain and indexed.

1. **`Reference/API Documentation/00_index.md`** — master index. Read first. It
   maps every domain to a file and lists that file's key interfaces.
2. **`Reference/API Documentation/00_concepts.md`** — conceptual guides: add-on
   architecture, connecting via AutomationHook, units, reference geometry, PDM,
   side-by-side installs, tips & tricks.
3. The domain file the index points you to:
   - `01_core_root.md` — `IADRoot`, sessions, `AutomationHook`
   - `02_part_session.md` — `IADPartSession` / `IADDesignSession`
   - `03_features.md` — extrude/revolve/sweep/hole/fillet/etc.
   - `04_sketching_2d.md` / `05_sketching_3d.md` — sketches & figures
   - `06_geometry_brep.md` — bodies, faces, edges, topology
   - `07_assembly.md` — occurrences & constraints
   - `08_drawings.md` — sheets, views, BOM
   - `09_parameters.md` — parameters & equations
   - `10_pdm_repository.md` — PDM Safe / file ops (V29+)
   - `11_materials_users.md` — materials, (legacy) users/teams

**Rule:** don't guess at API signatures. Look the member up. If it isn't in the
docs, say so rather than inventing it.

For the integrated (C++) model, `Reference/Integrated_Addons_in_Alibre Design.pdf`
is the authoritative spec, and `Reference/Addon Samples/SelectionAddOnSample/`
is the best starting template.

---

## 2. Choose the add-on architecture

| Model | Language | Use when | Entry point |
|---|---|---|---|
| **Standalone / CAD-data app** | C# (.NET Framework, WinExe) | Its own EXE/UI, reading or writing Alibre CAD or PDM data | Connect to AutomationHook (running or headless) |
| **Fully integrated add-on** | C++ / MFC (COM DLL) | Lives inside Alibre: ribbon menus, Design Explorer tab, canvas rendering, input/selection events, per-file persistent data | `IAlibreAddOn` COM interface in a DLL |

The only **C# sample** is standalone PDM:
`Reference/Addon Samples/AlibrePdmApiSample/` (.NET Framework 4.8, references
`AlibreX.dll`). The **integrated samples are all C++/MFC**: `SelectionAddOnSample`,
`AnimationAddOn`, `DXSampleAddOn`.

Ribbon integration, in-canvas UI, or event handling ⇒ integrated C++. A tool that
just drives Alibre ⇒ C#. Confirm which the user wants before scaffolding if
it's unclear.

---

## 3. Connecting to Alibre (the entry point is always `IADRoot`)

- **Attach to a running instance (C#):**
  ```csharp
  var hook = (IAutomationHook)Marshal.GetActiveObject("AlibreX.AutomationHook");
  IADRoot root = hook.Root;
  ```
- **Headless / GUI-less (C#):**
  ```csharp
  IAutomationHook hook = new AutomationHook();
  hook.Initialize(null, null, null, false, 0); // string args unused, last arg reserved = 0
  IADRoot root = hook.Root;
  ```
  Headless on V25+ requires `registerCOMdlls.BAT` run as administrator.
- **Integrated DLL (C++):** Alibre calls your exported `AddOnLoad` and hands you
  the hook: `root = ((IAutomationHook*)pAutomationHook)->GetRoot();`

### Referencing the API — use the versioned path from `.claude/machine.md`

- **.NET (C#):** reference `AlibreX.dll` from `<Alibre>\Program\`, `using AlibreX;`.
  The PDM sample's `.csproj` HintPath points at an Alibre dev build — **fix it**.
- **Unmanaged C++:** import **both** type libraries in `StdAfx.h`:
  ```cpp
  #import "C:\Program Files\Alibre Design <version>\Program\AlibreX_64.tlb"
  using namespace AlibreX;

  #import "C:\Program Files\Alibre Design <version>\Program\AlibreAddOn_64.tlb" raw_interfaces_only
  using namespace AlibreAddOn;
  ```
  The two libraries have **different roles**:
  - **`AlibreX_64`** (namespace `AlibreX`) — the large automation API that
    *drives* Alibre: geometry, sketches, features, assemblies, sessions. This is
    what the `00_index.md` domain files document.
  - **`AlibreAddOn_64`** (namespace `AlibreAddOn`) — the small *integration*
    API: `IAlibreAddOn`, `IAlibreAddOnCommand`, `IADAddOnCommandSite`, and the
    `ADDONMenuStates` / `ADDONMouseButtons` enums. Integrated model only.

Two **expected, benign** warnings come from these imports — don't chase them:

```
warning C4278: 'SendMessage': identifier in type library ... is already a macro
warning C4192: automatically excluding 'IStream' while importing type library ...
_WIN32_WINNT not defined. Defaulting to _WIN32_WINNT_MAXVER
```

### 3.1 Side-by-side installs — do you have to ask which version to target?

V25+ versions can be installed side by side, but **only one of them registers
its AlibreX types in the registry** (normally the last installed). The two
models are affected in opposite ways, so answer this per model rather than
asking reflexively.

**Standalone C# app — yes, ask.** `Marshal.GetActiveObject("AlibreX.AutomationHook")`
and `new AutomationHook()` both resolve through that single global COM
registration, so the app silently drives whichever version won. With several
installed, ask the user which one they mean, and tell them the switch procedure:
launch the desired version **as Administrator** once, let the Home window
appear, close it — its AlibreX types are now the registered ones. The same
re-registration is needed after *uninstalling* any side-by-side version, which
can strip the AlibreX entries.

**Integrated C++ add-on — no need to ask.**
`HKLM\SOFTWARE\Alibre Design Add-Ons` is a **single, un-versioned key**: there is
no per-version scoping available, so every installed version that scans it will
load your add-on. And Alibre hands the automation hook to `AddOnLoad`, so you
bind to whichever instance loaded you — no CLSID lookup, no ambiguity.

Loading everywhere is not the same as working everywhere, though. Two things
still need a decision:

1. **Which `.tlb` to `#import`** — this bakes interface declarations into the
   DLL at compile time. Compile against the **oldest** version you intend to
   support: your `IAlibreAddOn` then implements a subset that newer versions
   extend at the end of the vtable. Building against the newest and running on
   an older one relies on the old version never calling the methods it doesn't
   know about (true for the spec-v2 additions `MenuIcon` /
   `UseDedicatedRibbonTab`, but it is an assumption, not a guarantee).
2. **A runtime version gate** — see §7. This is what actually makes an add-on
   safe across versions: it loads everywhere, then refuses to run where the API
   members it needs are missing.

> Alibre's own side-by-side page says "API *and add-on* programs will
> automatically target the last installed version." That sentence sits in a
> discussion of COM type registration, which is the standalone path; for
> integrated add-ons the hook is handed in. Treat the blanket wording with
> caution and verify on the target machine if it matters.

---

## 4. Integrated add-on contract (C++ model)

### 4.1 Pick the simplest command flavor that works

`InvokeCommand` returns an `IAlibreAddOnCommand*`, and there are three flavors:

1. **Stateless "fire-and-forget"** — do all the work inside `InvokeCommand` and
   return `NULL`. **Default to this.** No command object, no Design Explorer
   tab, no event listener, no lifetime to manage — it removes several hundred
   lines of COM boilerplate versus the sample. A command that reads or sets
   document properties, runs a calculation, or puts up a modal dialog needs
   nothing more.
2. **Two-way toggle** — two states (active/inactive), typical for an "Activate"
   command that shows the add-on's Explorer tab. After `OnShowUI`, Alibre calls
   `IsTwoWayToggle`; if `TRUE`, `OnComplete` is called and no event listener is
   attached.
3. **Regular multi-state command** — listens to canvas/user events and can
   render into the graphics window. Alibre attaches a listener that lives until
   another command is invoked, then calls `OnTerminate`.

Only reach for 2 or 3 when you actually need a persistent panel, canvas
rendering, or selection/mouse events.

### 4.2 Required pieces

- **Exported C entry points** (`extern "C"`, `__declspec(dllexport)`). The first
  three are mandatory for any add-on; `GetAddOnInterface` is additionally
  required for tight integration:
  - `AddOnLoad(HWND, void* pAutomationHook, void* reserved)` — cache the root.
  - `AddOnInvoke(...)` — called when launched from the Add-Ons menu.
  - `AddOnUnload(HWND, BOOL forceUnload, BOOL* cancel, ...)` — clean up; set
    `*cancel = TRUE` to veto unload.
  - `GetAddOnInterface()` — instantiate your `IAlibreAddOn`, store it in the app
    object, `AddRef` and return as `IUnknown*`.

  Verify these four are exported **undecorated** after building:
  `dumpbin /exports <dll>` must list exactly `AddOnLoad`, `AddOnInvoke`,
  `AddOnUnload`, `GetAddOnInterface`, and the header must say `8664 machine (x64)`.

- **`IAlibreAddOn` implementation**: `get_RootMenuItem`, `HasSubMenus`,
  `SubMenuItems`, `MenuItemText`, `MenuItemState`, `MenuItemToolTip`,
  `PopupMenu`, `InvokeCommand`, `HasPersistentDataToSave`, `LoadData`/`SaveData`,
  `setIsAddOnLicensed`, `MenuIcon`, `UseDedicatedRibbonTab`.
- **`IAlibreAddOnCommand` per leaf command** — only for flavors 2 and 3.
- Standard COM plumbing: `IUnknown` + `IDispatch` on every object. Alibre only
  uses the vtable, so `IDispatch` can return `E_NOTIMPL` with a NULL
  `ITypeInfo` — but implement it defensively rather than leaving `m_ptinfo`
  uninitialized the way the sample does.
- Add `AFX_MANAGE_STATE(AfxGetStaticModuleState())` as the **first statement**
  of every exported function and every COM method that touches MFC.

### 4.3 Menu rules that bite

- `get_RootMenuItem` must return a **non-zero** id *and* `MenuItemText` must
  return a non-empty string for Alibre to build a menu tree. If it returns **0**,
  the add-on instead appears as a single entry under *Tools → Add-Ons* and
  clicking it calls `InvokeCommand` directly.
- **Always initialize `[out]` parameters.** Alibre queries menu ids you don't
  own; leaving `*pMenuDisplayText`, `*pToolTip` or `*pSubMenuIDs` untouched
  hands it uninitialized memory. Set `NULL` at the top of every such method.
- **`MenuItemState` must enable the root menu id too**, not just the leaves —
  otherwise the entire drop-down greys out.
- Return `[out]` BSTRs with `_bstr_t(...).Detach()` so ownership transfers
  cleanly. (The official sample assigns a temporary `_bstr_t` directly, which
  dangles — don't copy that.)
- `MenuIcon` and `UseDedicatedRibbonTab` are honoured **only** when the `.adc`
  sets `specificationVersion="2"` (current spec version). `"1"` disables them.
  For `MenuIcon`, resolve the icon path from your own module via
  `GetModuleHandleEx(GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS, ...)` — never from
  the working directory.

### 4.4 `sessionIdentifier` — critical

There is **only one loaded DLL and one `IAlibreAddOn` instance** even with many
workspaces open. The `sessionIdentifier` BSTR passed to most methods says which
workspace the call is about. Resolve it each time; never cache "the current
session" globally, and key any per-document state by this string:

```cpp
VARIANT v; VariantInit(&v);
v.vt = VT_BSTR;
v.bstrVal = sessionIdentifier;              // borrowed, do not free
IADSessionPtr session = root->GetSessions()->GetItem(&v);
ADObjectSubType type = session->GetSessionType();
```

- The Home window (and transient states) pass an **empty** identifier, and an
  unknown identifier **throws** out of `GetItem` — guard both.
- `AD_PART` **and** `AD_SHEET_METAL` both expose `IADPartSession`. Accept both.
- Assigning `IADSessionPtr` to a derived `…Ptr` performs a QueryInterface that
  throws `_com_error` on failure — wrap it.

### 4.5 Command site, rendering, persistence (flavors 2 and 3)

- `putref_CommandSite` hands you `IADAddOnCommandSite` — **store it**. It offers
  `UpdateCanvas` / `InvalidateCanvas`, `Terminate`, and
  `LegacyRenderingEngine(&bLegacy)` (DirectX9 vs Hoops — affects how you render).
  It can also host a panel docked to the graphics window, not just an Explorer tab.
- `OnRender` / `On3DRender` fire only while a command is active and the graphics
  are **transient** — ideal for previews.
- Per-file data: add `<PersistentData StreamName="..."/>` to the `.adc`. On save
  Alibre calls `HasPersistentDataToSave(sessionId, &hasData)`; if `TRUE` it
  creates the named `IStream` and calls `SaveData`. On open it calls `LoadData`
  if the stream exists.
- Command lifecycle: `InvokeCommand` → `AddTab` → `OnShowUI(hWnd)` →
  `IsTwoWayToggle` → `putref_CommandSite` → events → `OnTerminate`.

---

## 5. Packaging, registration & deployment (hard requirements)

Every add-on loaded by Alibre needs all three of these.

### 5.1 `.adc` config file (XML)

```xml
<AlibreDesignAddOn specificationVersion="2" friendlyName="My AddOn">
   <Author name="..." link="..."/>
   <DLL loadedWhen="Startup" location="MyAddOn.dll"/>   <!-- Startup | Invoke -->
   <Icon location="MyAddOn.ico"/>
   <Menu text="My AddOn"/>
   <Description>...</Description>
   <Workspace type="Part"/>   <!-- Part|SheetMetal|Assembly|Drawing|Home|Always|Never -->
   <PersistentData StreamName="MyAddOn_Data"/>   <!-- only if persisting per-file data -->
   <Property name="Identifier" value="{NEW-GUID-HERE}"/>
</AlibreDesignAddOn>
```

- **Generate a fresh GUID per add-on.** It must match the registry value name.
- `<Workspace>` takes **one** type. `Always` plus `MenuItemState` filtering is
  usually better than `Part`, which excludes sheet metal.

### 5.2 Deploy folder

`%PROGRAMDATA%\Alibre AddOns\<AddOnName>\` containing the `.dll`, `.adc` and
`.ico`. Keep the DLL beside the `.adc`. **The `Alibre AddOns` folder does not
exist on a machine that has never had a third-party add-on** — create it.

### 5.3 Registry registration

Under `HKEY_LOCAL_MACHINE\SOFTWARE\Alibre Design Add-Ons`, a **String value**
whose **name = the add-on's GUID** and **data = the deploy folder path**. This
key also does not exist on a clean machine.

The key is **global and un-versioned** — one registration serves every installed
Alibre version, and there is no way to scope it to one of them (§3.1). Plan for
the add-on being loaded by all of them and gate on `IADRoot.Version` instead.

> **Trap:** creating it with PowerShell's
> `New-Item -Path 'HKLM:\SOFTWARE\Alibre Design Add-Ons' -Force` fails with
> *"Requested registry access is not allowed"* **even from an elevated prompt**,
> because `-Force` opens `HKLM\SOFTWARE` itself for write. Use the .NET API,
> which only needs create-subkey rights:
>
> ```powershell
> $key = [Microsoft.Win32.Registry]::LocalMachine.CreateSubKey('SOFTWARE\Alibre Design Add-Ons')
> $key.SetValue($AddOnGuid, $targetDir, [Microsoft.Win32.RegistryValueKind]::String)
> $key.Close()
> ```

Both the folder and the registry value require **administrator rights**. Ship an
`install.ps1` / `uninstall.ps1` pair under `src/<AddOnName>/deploy/` that checks
for elevation up front and does both steps.

### 5.4 Build configuration

Integrated add-ons build **x64 only** — Alibre is 64-bit and will not load a
32-bit DLL. Omit Win32 configurations from the `.vcxproj` entirely so nobody can
build the wrong one by accident. Leave `PlatformToolset` as
`$(DefaultPlatformToolset)` rather than pinning `v143`, so the project follows
whatever Visual Studio is installed.

---

## 6. Build → install → verify loop

```bash
"<VS install>\MSBuild\Current\Bin\MSBuild.exe" "src\<AddOnName>\<AddOnName>.sln" /p:Configuration=Release /p:Platform=x64
```

```bash
powershell -ExecutionPolicy Bypass -File "src\<AddOnName>\deploy\install.ps1"
```
(elevated — it will raise a UAC prompt)

Then:

- **Alibre reads the registry and the `.adc` only at startup. Restart Alibre
  Design after installing or updating an add-on** — otherwise nothing changes
  and it looks like a code bug.
- **Close Alibre before redeploying**: the DLL is locked while the add-on is
  loaded, so the copy fails.
- Don't kill a running Alibre to do this — ask the user to save and restart.
- Files under `%PROGRAMDATA%\Alibre AddOns\` created by an elevated install are
  **not writable unelevated**, so redeploys need elevation too.

Runtime behaviour inside Alibre cannot be verified from outside it. After
install, ask the user what they actually see rather than reporting success.

---

## 7. Mandatory conventions & gotchas

- **Units: the entire API uses MODEL UNITS.** Internal model units are
  **centimeters**; angles are **radians**. Convert only at the UI boundary.
  (1 in = 2.54 cm, 1 mm = 0.1 cm, 1 deg = 0.01745329… rad.)
- **Colors are packed like a Win32 `COLORREF`** — `0x00BBGGRR`, red in the low
  byte. That is what the docs' VB `RGB(r,g,b)` example produces and what
  `CColorDialog` returns, so no channel swapping is needed. Applies to
  `IADPartSession.Color`, `.EdgeColor`, feature `FaceColor`, `IADOccurrence.Color`.
- **Version-gate at startup — not optional.** The API grows across versions, and
  an add-on is loaded by *every* installed Alibre (§3.1), so it will be handed
  roots it may be too new for. Read `IADRoot.Version` in `AddOnLoad` / at
  connect time, parse the trailing build number, and compare against a stated
  minimum:

  ```cpp
  // IADRoot.Version is a string; the build number is the last comma-separated field
  _bstr_t version = root->GetVersion ();
  ```

  Below the minimum, fail **legibly and once**: grey the menus out via
  `MenuItemState` and say which build is required. Do not let it load silently
  and then throw at the first API call the old build doesn't have.
- **Don't look up reference geometry by name** (names are localized: "X-Axis" →
  "Eje-X"). Find primary planes/axes by geometric properties / `*Type` enums.
- **Topology has no stable names.** Faces/edges/vertices are identified by a
  variable-length byte-array **`Key`** (compare as a Unicode string).
  `IADTargetProxy` wraps a target plus its owning occurrence; the actual type is
  **late-bound** (`Type`, then `TopologyType` if `AD_TOPOLOGY`).
- **Side-by-side installs:** only the last-installed (or last-run-as-admin)
  Alibre version registers its AlibreX types. Matters for standalone apps, not
  for integrated add-ons — see §3.1 for which model needs the user to choose.
- **Headless on V25+** needs `registerCOMdlls.BAT` run as administrator.
- **PDM API is V29+** — `IADRoot.ConnectToPDM(...)` or
  `GetActiveServerConnection()`; PDM saves go to the working dir, then
  `CheckIn(...)` pushes to the server. Legacy `IADFolder`/`IADUser`/`IADTeam` are
  obsolete as of V11 — don't use them for new work.
- **COM lifetime:** in C++ honor AddRef/Release; in C# the objects are RCWs — be
  careful releasing references on long-lived sessions.

### Authoring source files

Write C++ sources, `.rc`, `.vcxproj` and PowerShell with the **Write/Edit
tools**, not shell heredocs or `sed`. Backslash escapes get mangled in transit
through the shell — a `'\\'` char literal silently becoming `'\'` costs a whole
build cycle. This matters here because nearly every file contains Windows paths.

---

## 8. Reference map

```
Reference/
├─ Integrated_Addons_in_Alibre Design.pdf   # AUTHORITATIVE spec for the C++ integrated model
├─ API Documentation/        # split AlibreX reference — START AT 00_index.md
│   ├─ 00_index.md           #   master index + cross-domain relationships
│   ├─ 00_concepts.md        #   conceptual guides (add-ons, units, PDM, tips)
│   └─ 01..11_*.md           #   per-domain member reference
└─ Addon Samples/
    ├─ AlibrePdmApiSample/   # C# standalone PDM app (.NET 4.8) — connection + PDM
    ├─ SelectionAddOnSample/ # C++/MFC integrated add-on — BEST starting template
    ├─ AnimationAddOn/       # C++/MFC integrated add-on — assembly animation
    └─ DXSampleAddOn/        # C++/MFC integrated add-on — DirectX canvas rendering
```

Each sample's `Docs/ReadMe.txt` has its own build & install steps. The `AlibreX`
type library documented here is **v29**.

If `src/PartColorAddOn/` is present, it is a **known-good, built-and-installed
integrated add-on** (changes the active part's color) that demonstrates the
stateless-command pattern, menu state handling, session resolution and the
install scripts. Read it before writing a new one from scratch.
