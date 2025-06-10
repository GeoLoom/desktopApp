$timestamp = Get-Date -Format "yyyyMMdd_HHmmss"
$backupPath = "C:\Backups\MyApp_$timestamp"
Copy-Item -Path "C:\Deploy\MyApp" -Destination $backupPath -Recurse
Write-Host "Backup created at $backupPath"


--tourne pas encore donc je ne met pas de vrais chemin
