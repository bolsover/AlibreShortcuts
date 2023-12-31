; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "AlibreShortcuts"
#define MyAppVersion "3.1.0.0"
#define MyAppPublisher "David Bolsover"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{3D9113C4-060D-4C88-9ED4-3248E1E3211A}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
DisableProgramGroupPage=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
PrivilegesRequired=admin
PrivilegesRequiredOverridesAllowed=dialog
OutputDir=D:\Repository\Jetbrains\Bolsover\AlibreShortcuts\AlibreShortcuts\bin\Setup
OutputBaseFilename=AlibreShortcutsSetup
SetupIconFile=D:\Repository\Jetbrains\Bolsover\AlibreShortcuts\AlibreShortcuts\bin\Release\shortcuts.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern
ArchitecturesAllowed=x64
ArchitecturesInstallIn64BitMode=x64

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Files]
; Source: "D:\Repository\Jetbrains\Bolsover\UtilitiesForAlibre\UtilitiesForAlibre\bin\Release\AboutForm.resx"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Repository\Jetbrains\Bolsover\AlibreShortcuts\AlibreShortcuts\bin\Release\Copyright and License.txt"; DestDir: "{app}"; Flags: ignoreversion
;Source: "D:\Repository\Jetbrains\Bolsover\AlibreShortcuts\AlibreShortcuts\bin\Release\generics_NET.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "D:\Repository\Jetbrains\Bolsover\AlibreShortcuts\AlibreShortcuts\bin\Release\System.Drawing.Common.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "D:\Repository\Jetbrains\Bolsover\AlibreShortcuts\AlibreShortcuts\bin\Release\DocumentFormat.OpenXml.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "D:\Repository\Jetbrains\Bolsover\AlibreShortcuts\AlibreShortcuts\bin\Release\System.Drawing.Common.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "D:\Repository\Jetbrains\Bolsover\AlibreShortcuts\AlibreShortcuts\bin\Release\System.IO.Packaging.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Repository\Jetbrains\Bolsover\AlibreShortcuts\AlibreShortcuts\bin\Release\AlibreShortcuts.adc"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Repository\Jetbrains\Bolsover\AlibreShortcuts\AlibreShortcuts\bin\Release\AlibreShortcuts.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Repository\Jetbrains\Bolsover\AlibreShortcuts\AlibreShortcuts\bin\Release\AlibreShortcuts.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source:  "D:\Repository\Jetbrains\Bolsover\AlibreShortcuts\AlibreShortcuts\bin\Release\shortcuts.svg";  DestDir: "{app}"; Flags: ignoreversion
Source:  "D:\Repository\Jetbrains\Bolsover\AlibreShortcuts\AlibreShortcuts\bin\Release\shortcuts.ico";  DestDir: "{app}"; Flags: ignoreversion
;Source:  "D:\Repository\Jetbrains\Bolsover\AlibreShortcuts\AlibreShortcuts\bin\Release\nexus.ico";  DestDir: "{app}"; Flags: ignoreversion

; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"

[Registry]
Root: HKLM; Subkey: "SOFTWARE\Alibre Design Add-Ons"; Flags: uninsdeletekeyifempty; Check: IsAdminInstallMode
Root: HKLM; Subkey: "SOFTWARE\Alibre Design Add-Ons"; ValueType: string; ValueName: "{{90170D0D-AF9B-4893-8967-91C980203EA2}"; ValueData: "{autopf}\{#MyAppName}"; Check: IsAdminInstallMode

;[Run]
;Filename: "{app}\AlibreShortcutsSetup.exe"; Description: "{cm:LaunchProgram,MyApp}"; Flags: runascurrentuser nowait postinstall skipifsilent; Check: returnTrue()
;Filename: "{app}\AlibreShortcutsSetup.exe"; Flags: runascurrentuser; Parameters: "-install -svcName ""AlibreShortcutsSetup"" -svcDesc ""AlibreShortcutsSetup"" -mainExe ""AlibreShortcutsSetup.exe""  "; Check: returnFalse()
