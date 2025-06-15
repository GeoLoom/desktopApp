🔧 Contexte

Application WPF pour projet pro  – déploiement automatisé avec GitHub Actions.

🧪 Technologies

WPF (.NET 8)

GitHub Actions

GitFlow

PowerShell (rollback/snapshots)

Terraform (infra)

Ansible (config)

🌱 GitFlow

Branches :

main : stable

develop : en dev

feature/* : ajouts

release/* : préprod

hotfix/* : urgences

⚙️ CI/CD

Fichier .github/workflows/build.yml :

dotnet build, publish, artifact

Notification email via SendGrid HTTP API

Trigger : push/pull sur main ou develop

🍿 Versionnement

SemVer (v1.0.0, v1.1.0, …)

Git tags

Artifacts en release GitHub

🔐 Secrets

Utilisation de GitHub Secrets pour :

Mots de passe (DB, etc.)

API KEY SendGrid

💾 Snapshots

Scripts PowerShell dans snapshots/ pour backup automatique

Exemple : Create-Snapshot.ps1

🔄 Rollback

Voir rollback/restore.ps1 – restauration d'une version précédente du déploiement

📢 Notification

À la fin du pipeline, une notification est envoyée par mail à l’équipe (via SendGrid).

📸 Captures d’écran à fournir
![Capture d’écran 2025-06-15 154726](https://github.com/user-attachments/assets/fc3fa349-a65a-4bf8-bbc6-12d230d6782a)
![Capture d’écran 2025-06-15 154743](https://github.com/user-attachments/assets/c7c39cb1-d5fb-44ab-bf96-a198053b9c52)
![Capture d’écran 2025-06-15 160525](https://github.com/user-attachments/assets/a7e92902-4188-48d0-922b-13b04bde2c7d)



