# QA Automation Portfolio - Guía de ejecución

Este documento recoge los pasos para ejecutar el proyecto en entorno local.

---

## 🚀 Requisitos

### Windows
- .NET SDK 6 o superior
- Visual Studio 2022 o Visual Studio Code

### macOS (MacBook)
- .NET SDK 6 o superior
- Visual Studio Code o terminal (zsh/bash)

Comprobar instalación:
```bash
dotnet --version

📌 1. Ir a la carpeta del proyecto
Windows (PowerShell / CMD)
cd ruta\del\proyecto\UserManagementApp
macOS (Terminal)
cd /ruta/del/proyecto/UserManagementApp
📌 2. Restaurar dependencias (opcional pero recomendado)
dotnet restore
📌 3. Ejecutar el proyecto
dotnet run --project UserManagementApp
📌 4. Abrir en navegador

Normalmente:

http://localhost:5167