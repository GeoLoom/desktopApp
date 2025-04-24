# Rapport de publication

## Outils testés

### 1. **standard-version**
- **Fonctionnalités** : Gestion de la version, génération de changelog, tagging Git.
- **Forces** : Facilité d'utilisation, bonne intégration avec Git.
- **Faiblesses** : Nécessite Node.js et npm installés.

### 2. **release-it**
- **Fonctionnalités** : Publication automatisée de la version, gestion des changelogs, tags et release sur GitHub.
- **Forces** : Facilité d'intégration avec GitHub.
- **Faiblesses** : Moins flexible que `standard-version` pour personnaliser les étapes de la release.

### 3. **gh (GitHub CLI)**
- **Fonctionnalités** : Création de releases GitHub directement depuis la ligne de commande.
- **Forces** : Simplicité d'utilisation.
- **Faiblesses** : Ne gère pas la génération automatique de changelog ou la mise à jour des versions.

---

## Choix des outils et explications

Pour ce projet, j'ai choisi de tester `standard-version` et `release-it` car ils fournissent un bon compromis entre simplicité et personnalisation. 

- **standard-version** : J'ai trouvé cet outil très utile pour automatiser la gestion des versions et des changelogs de manière simple et efficace.
- **release-it** : Cet outil m'a permis de créer une release complète avec une configuration minimale.

---

## Problèmes rencontrés

Lors de l'utilisation de **standard-version** sur Windows, j'ai rencontré des problèmes avec les fins de ligne (LF vs CRLF). J'ai résolu cela en configurant Git pour qu'il gère automatiquement la conversion des fins de ligne avec `git config --global core.autocrlf true`.

---

## Conclusion

Le processus de publication de version a été grandement simplifié grâce à l'automatisation avec `release.sh`. L'intégration avec GitHub Actions a permis d'automatiser l'ensemble du cycle de publication, de la mise à jour de la version à la création de la release.
