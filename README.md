# GeoLoom WPF – CI/CD Project
![Build Status](https://github.com/GeoLoom/desktopApp/actions/workflows/build.yml/badge.svg)

## 🔧 Contexte
Application WPF pour projet pro (je n'ai redétailler) – déploiement automatisé avec GitHub Actions.

## 🧪 Technologies
- WPF (.NET 8)
- GitHub Actions
- GitFlow
- PowerShell (rollback/snapshots)
- [Terraform/Ansible si utilisés]

## 🌱 GitFlow
Branches :
- `main` : stable
- `develop` : en dev
- `feature/*` : ajouts
- `release/*` : préprod
- `hotfix/*` : urgences

## ⚙️ CI/CD
Fichier `.github/workflows/build.yml` :
- `dotnet build`, `publish`, `artifact`
- Trigger : push/pull sur `main` ou `develop`

## 🏷️ Versionnement
- SemVer (tag_v1.0.0, tag_v1.1.0, …)
- Git tags
- Artifacts en release GitHub

## 🔐 Secrets
Utilisation de GitHub Secrets pour :
- Mots de passe
- API KEY

## 💾 Snapshots
Scripts PowerShell dans `snapshots/` pour backup automatique

## 🔁 Rollback
Voir `rollback/restore.ps1` – restauration d'une version précédente

## Notification
À la fin du pipeline, une notification est envoyée par mail à l’équipe.

## 📸 Captures d’écran à fournir

