🟣 1. Secció de configuració bàsica
pascal
[Setup]
AppName=FindDups
AppVersion=1.0.0
AppPublisher=Plecmedia Tech Solutions
DefaultDirName={pf}\FindDups
DefaultGroupName=FindDups
DisableProgramGroupPage=yes
OutputDir=.
OutputBaseFilename=FindDupsInstaller
Compression=lzma
SolidCompression=yes
ArchitecturesInstallIn64BitMode=x64
PrivilegesRequired=admin
SignedUninstaller=yes
SignedUninstallerDir={app}
🟢 2. Fitxers que s’instal·len
pascal
[Files]
; Executable principal
Source: "runtime\FindDups.exe"; DestDir: "{app}"; Flags: ignoreversion

; Models IA
Source: "runtime\ia_models\vision_model.bin"; DestDir: "{app}\ia_models"; Flags: ignoreversion
Source: "runtime\ia_models\text_embeddings.bin"; DestDir: "{app}\ia_models"; Flags: ignoreversion
Source: "runtime\ia_models\name_similarity.bin"; DestDir: "{app}\ia_models"; Flags: ignoreversion

; Configuració
Source: "runtime\config\enterprise.json"; DestDir: "{app}\config"; Flags: ignoreversion
Source: "runtime\config\defaults.json"; DestDir: "{app}\config"; Flags: ignoreversion

; Logs (carpeta buida)
Source: "runtime\logs\*"; DestDir: "{app}\logs"; Flags: ignoreversion recursesubdirs createallsubdirs

; Historial IA
Source: "runtime\finddups_history.db"; DestDir: "{app}"; Flags: ignoreversion

; Context menu tools
Source: "RegisterContextMenu.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "UnregisterContextMenu.exe"; DestDir: "{app}"; Flags: ignoreversion

; Actualitzador
Source: "updater\updater.exe"; DestDir: "{app}\updater"; Flags: ignoreversion

; Documentació
Source: "docs\Manual_Tecnic.pdf"; DestDir: "{app}\docs"; Flags: ignoreversion
Source: "docs\Whitepaper_IA.pdf"; DestDir: "{app}\docs"; Flags: ignoreversion
Source: "docs\Manual_Seguretat.pdf"; DestDir: "{app}\docs"; Flags: ignoreversion

; Fitxer de versió
Source: "version.txt"; DestDir: "{app}"; Flags: ignoreversion
🟡 3. Registre del context menu (clic dret)
pascal
[Registry]
Root: HKCR; Subkey: "*\shell\FindDups"; ValueType: string; ValueName: ""; ValueData: "Escanejar duplicats amb FindDups"; Flags: uninsdeletekey
Root: HKCR; Subkey: "*\shell\FindDups\command"; ValueType: string; ValueName: ""; ValueData: """{app}\FindDups.exe"" ""%1"""; Flags: uninsdeletekey
🔵 4. Accions post-instal·lació
pascal
[Run]
; Registre del context menu
Filename: "{app}\RegisterContextMenu.exe"; Description: "Registrar context menu"; Flags: runhidden

; Crear logs inicials
Filename: "{app}\FindDups.exe"; Parameters: "/init"; Flags: runhidden
🟠 5. Accions de desinstal·lació
pascal
[UninstallRun]
Filename: "{app}\UnregisterContextMenu.exe"; Flags: runhidden
🟤 6. Entrades del menú Inici (opcional)
pascal
[Icons]
Name: "{group}\FindDups"; Filename: "{app}\FindDups.exe"
Name: "{group}\Desinstal·lar FindDups"; Filename: "{uninstallexe}"
⚫ 7. Permisos i ACLs corporatives
pascal
[Dirs]
Name: "{app}\logs"; Permissions: users-modify
Name: "{app}\config"; Permissions: users-readexec
Name: "{app}\ia_models"; Permissions: users-readexec