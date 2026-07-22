{
  "app": {
    "name": "FindDups Portable",
    "version": "1.0.0",
    "author": "Plecmedia",
    "company": "Plecmedia Technologies"
  },

  "paths": {
    "runtime_dir": "./",
    "history_db": "./finddups_history.db",
    "log_file": "./logs/portable.log",
    "models_dir": "./ia_models",
    "cache_dir": "./cache",
    "config_dir": "./config"
  },

  "scan": {
    "hash_algorithm": "SHA256",
    "include_subfolders": true,
    "max_file_size_mb": 2048
  },

  "history": {
    "enabled": true,
    "save_duplicates": true,
    "save_scan_metadata": true
  },

  "logging": {
    "enabled": true,
    "level": "info"
  },

  "portable": {
    "context_menu": false,
    "updater": false,
    "installation": false
  }
}
