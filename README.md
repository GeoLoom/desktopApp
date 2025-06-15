# 🎯 WPF Deployment Automation

Application **WPF (.NET 8)** pour projet professionnel avec **déploiement automatisé** via **GitHub Actions**.

---

## 🔧 Contexte

Ce projet vise à fournir une application WPF prête à être déployée automatiquement à l'aide d'une pipeline CI/CD complète.  
L'accent est mis sur la fiabilité, la traçabilité (snapshots) et la facilité de rollback.

---

## 🧪 Technologies utilisées

- **WPF** (.NET 8)
- **GitHub Actions** – CI/CD automatisé
- **GitFlow** – gestion des branches
- **PowerShell** – snapshots, rollback
- **Terraform** – infrastructure
- **Ansible** – configuration des serveurs

---

## 🌱 GitFlow – Stratégie de branches

| Branche      | Rôle                         |
|--------------|------------------------------|
| `main`       | Version stable               |
| `develop`    | En cours de développement    |
| `feature/*`  | Nouvelles fonctionnalités    |
| `release/*`  | Préparations pour la release |
| `hotfix/*`   | Corrections urgentes         |

---

## ⚙️ CI/CD – Pipeline GitHub Actions

### Fichier
`.github/workflows/build.yml`

### Étapes principales

- `dotnet build`
- `dotnet publish`
- Génération d’**artifacts**
- **Notification e-mail** via **SendGrid HTTP API**

### Déclencheurs

- `push` ou `pull_request` sur les branches `main` ou `develop`

---

## 🍿 Versionnement

- Suivi via [SemVer](https://semver.org/lang/fr/) : `v1.0.0`, `v1.1.0`, etc.
- Utilisation de **Git tags**
- **Artifacts** associés à chaque release via GitHub

---

## 🔐 Secrets

Utilisation de **GitHub Secrets** pour sécuriser :

- Clés d’API (ex. SendGrid)

- Test d'une variable psw

---

## 💾 Snapshots – Sauvegardes automatisées

Scripts PowerShell disponibles dans le dossier [`snapshots/`](./snapshots/) :

- Exemple : `Create-Snapshot.ps1`  
  → Capture l’état actuel avant chaque déploiement

---

## 🔄 Rollback – Restauration d’état

Script disponible dans le dossier [`rollback/`](./rollback/) :

- `restore.ps1`  
  → Restaure une version précédente du déploiement à l’aide d’un snapshot

---

## 📢 Notifications de fin de pipeline

À la fin du processus CI/CD :

- Envoi d’un **e-mail automatique à l’équipe** via **SendGrid**

---

## 📸 Captures d’écran
![Capture d’écran 2025-06-15 154743](https://github.com/user-attachments/assets/c3aebee8-73cc-4af2-862d-89c62dc8987c)
![Capture d’écran 2025-06-15 154726](https://github.com/user-attachments/assets/3cdfa388-05d4-44e0-990b-382d4a11587c)
![Capture d’écran 2025-06-15 160525](https://github.com/user-attachments/assets/e89290fa-c94e-497b-9a9a-fff31b593923)



---

## 📁 Structure recommandée

```plaintext
.github/
└── workflows/
    └── build.yml

rollback/
└── restore.ps1

snapshots/
└── Create-Snapshot.ps1

src/
└── [Application WPF]

README.md
