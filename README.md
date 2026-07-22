# FindDups — Technical Overview

FindDups is a local-first duplicate and similarity detection engine built with:
- SHA256 hashing
- Local AI models (vision, text embeddings, name similarity)
- SQLite history tracking
- Enterprise deployment scripts
- Integrity verification (SHA256)

## Components
### Core
- FindDups.exe
- Models (bin)
- SQLite DB
- Logs

### Enterprise
- updater.exe
- enterprise.json (auto-generated)
- defaults.json (auto-generated)
- updater.json (auto-generated)
- silent install/uninstall scripts
- SCCM / Intune / PDQ deployment scripts

### Portable
- settings.json (editable)
- portable runtime

## Folder Structure
- Enterprise/
- Portable/
- Models/
- Scripts/
- Integrity/
- Docs/

## Editable Files
Only:
- Enterprise/settings.json
- Portable/settings.json

## Non-editable Files
Executables, models, integrity files, scripts.

## Requirements
- Windows 10/11
- .NET 8
- Local execution

## Status
Documentation complete.  
Next step: testing and validation.
