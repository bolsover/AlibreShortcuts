# Alibre Shortcuts

An interactive keyboard shortcut manager and visual reference add-on for **Alibre Design**.

[![Target Framework](https://img.shields.io/badge/.NET%20Framework-4.8.1-blue.svg)](https://dotnet.microsoft.com/)
[![Platform](https://img.shields.io/badge/Platform-Windows%20x64-lightgrey.svg)]()
[![License](https://img.shields.io/badge/License-MIT-green.svg)](Shortcuts/Copyright%20and%20License.txt)

---

## Overview

**Alibre Shortcuts** is a managed add-on for Alibre Design CAD software that provides a visual, intuitive interface for viewing, managing, and customizing keyboard shortcuts across different Alibre workspaces.

Instead of navigating complex nested menus or static lists, users can interact with an on-screen keyboard, filter shortcuts by modifier combinations (Ctrl, Alt, Shift), assign new commands directly to keys with conflict detection, and generate printable HTML cheat sheets.

---

## Key Features

### 1. Interactive Visual Keyboard
- **On-Screen Keyboard Layout**: Visual representation of standard keyboard keys with real-time shortcut mapping.
- **Modifier Toggle Buttons**: Interactive toggles for `Ctrl`, `Alt`, and `Shift` combinations (`None`, `Ctrl`, `Alt`, `Shift`, `Ctrl+Shift`, `Ctrl+Alt`, `Alt+Shift`, `Ctrl+Alt+Shift`).
- **Visual Feedback**: Buttons display command icons (SVG/PNG), customizable highlight colors, and localized command hints.
- **Interactive Assignment**: Click any key to assign, edit, reassign, or remove keyboard shortcut bindings directly.

### 2. Command Picker & Conflict Resolution
- **Searchable Command Browser**: Quick-filter dialog showing all available workspace commands with names, descriptions, and icons.
- **Collision & Conflict Detection**: Warns if a selected key combination is already bound to another command, offering options to overwrite or cancel.
- **Live Synchronization**: Applies shortcut modifications immediately to the active Alibre session via `KeyboardShortcutsMediator` and persists them to `user.profile`.

### 3. HTML Shortcut Reports & Cheat Sheets
- **Formatted HTML Reports**: Clean, categorized summary table of all active shortcuts for the selected workspace profile.
- **Print & Export**: Built-in print preview/dialog and HTML export to save or print physical desk reference sheets.

### 4. Workspace & License Awareness
- **Workspace Profiles**: Full support for all Alibre Design workspaces (Part Modeling, Assembly, 2D Drawing, Sheet Metal, etc.).
- **License Detection**: Automatically detects user license type (e.g., Alibre Atom 3D vs. Alibre Design Professional/Expert) and filters available workspace profiles accordingly.

### 5. Profile Backup & Color Customization
- **Automatic Backups**: Backs up user profile shortcuts before making changes to prevent configuration loss.
- **Custom Color Preferences**: Configure individual background colors for modifier combinations, key text sizes, and font styling via the Add-on Preferences dialog.

---

## Project Structure

```text
Shortcuts/
├── .claude/                   # AI assistant context and machine configuration
├── Reference/                 # Alibre API reference documentation & sample add-ons
│   ├── API Documentation/     # Alibre Design API documentation
│   └── Addon Samples/         # Official Alibre add-on sample projects
├── Shortcuts/                 # Core Add-On source code
│   ├── Calculator/            # Shortcut calculators, profile parsing & HTML report builders
│   │   ├── HtmlReport.cs
│   │   └── ShortcutsCalculator.cs
│   ├── Model/                 # Key definitions, SVG mapping, commands & shortcut models
│   │   ├── AlibreShortcut.cs
│   │   ├── KeyButtons.cs
│   │   ├── KeyCodes.cs
│   │   ├── SvgDictionary.cs
│   │   └── WorkspaceCommand.cs
│   ├── Presenter/             # UI presenter & business logic orchestration
│   │   ├── KeyboardPresenter.cs
│   │   └── Queries.cs
│   ├── Properties/            # Assembly metadata and application settings
│   ├── Utils/                 # Image rendering and text-to-image utilities
│   ├── View/                  # Windows Forms and User Controls
│   │   ├── ColorPreferencesForm.cs
│   │   ├── CommandPickerDialog.cs
│   │   ├── KeyboardControl.cs
│   │   ├── KeyboardForm.cs
│   │   └── KeyboardShortcutForm.cs
│   ├── addon.json             # Alibre add-on package metadata
│   ├── Shortcuts.adc          # Alibre Design Add-On manifest
│   └── Shortcuts.csproj       # Project file (.NET Framework 4.8.1, x64)
├── Shortcuts.slnx             # Solution file
└── README.md                  # Project documentation
```

---

## Requirements & Prerequisites

- **CAD Software**: [Alibre Design](https://www.alibre.com/) (v27+ recommended, compatible with v28/v29)
- **Runtime**: .NET Framework 4.8.1
- **Architecture**: x64 (64-bit)
- **Development Tools**:
  - Visual Studio 2022 / JetBrains Rider
  - Alibre API assemblies (`AlibreX.dll`, `AlibreAddOn.dll`, `alibre-client.dll`, etc.)

---

## Building the Project

1. Clone or download the repository.
2. Ensure reference paths in `Shortcuts/Shortcuts.csproj` point to your Alibre Design installation folder or local reference library (`AlibreLib` directory).
3. Open `Shortcuts.slnx` in Visual Studio or JetBrains Rider.
4. Select the **Release | x64** or **Debug | x64** build configuration.
5. Build the solution. The output files (`Shortcuts.dll`, `Shortcuts.adc`, `shortcuts.svg`, `shortcuts.ico`) will be generated in `bin\Debug\` or `bin\Release\`.

---

## Installation & Deployment

1. Locate your Alibre Design Add-ons folder:
   - Per-user: `%APPDATA%\Alibre Design\Addons\`
   - Global: `C:\ProgramData\Alibre Design\Addons\` (or `Program Files\Alibre Design\Program\Addons\`)
2. Create a subfolder named `Shortcuts`.
3. Copy the following build outputs into the `Shortcuts` folder:
   - `Shortcuts.dll`
   - `Shortcuts.adc`
   - `addon.json`
   - `shortcuts.svg`
   - `shortcuts.ico`
4. Start (or restart) Alibre Design.
5. The add-on will load automatically and appear in the **Add-Ons** menu or dedicated toolbar ribbon.

---

## Usage Guide

1. **Launch Add-On**: In Alibre Design, open any workspace and select **Add-Ons > Shortcuts** from the menu.
   - Choose **Keyboard** to open the interactive virtual keyboard.
   - Choose **Shortcuts** to view the tabular report / cheat sheet.
2. **Switch Workspaces**: Select the desired workspace (e.g., Part, Assembly, Drawing) from the profile dropdown.
3. **Filter Shortcuts**: Toggle `Ctrl`, `Alt`, or `Shift` on the virtual keyboard to view assigned shortcuts for that combination.
4. **Assign / Edit Shortcuts**:
   - Click any key button.
   - Use the **Command Picker** search box to find a command.
   - Click **Assign** to save the shortcut.
5. **Print / Export Report**: Open the Shortcuts report window and click **Print** or **Save** to generate an HTML cheat sheet.
6. **Preferences**: Click the `Add-on Prefs` button (Pause/Break key) to configure colors and font sizes.

---

## License

This project is licensed under the MIT License. See [Copyright and License.txt](Shortcuts/Copyright%20and%20License.txt) for details.

Copyright (c) 2023–2026 David Bolsover.
