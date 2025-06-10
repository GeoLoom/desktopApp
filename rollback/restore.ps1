$restoreSource = "C:\Backups\MyApp_20250610_150000"  # pareil pas de vrais chemin
$targetPath = "C:\Deploy\MyApp"
Copy-Item -Path $restoreSource -Destination $targetPath -Recurse -Force
Write-Host "Restored backup from $restoreSource to $targetPath"
