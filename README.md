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



