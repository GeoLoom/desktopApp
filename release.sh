#!/bin/bash

set -e

TOOL=$1

function run_tests() {
  echo "Running tests..."
  # TODO: remplacer par tes vrais tests
  npm test || { echo "Tests échoués. Release annulée."; exit 1; }
}

function standard_version_release() {
  echo "Lancement avec standard-version..."
  npx standard-version
  git push --follow-tags origin main
  echo "standard-version terminé."
}

function release_it_release() {
  echo "Lancement avec release-it..."
  npx release-it
}

function gh_release() {
  echo "Publication GitHub avec gh..."
  VERSION=$(node -p "require('./package.json').version")
  gh release create "v$VERSION" --generate-notes
}

run_tests

case "$TOOL" in
  standard-version)
    standard_version_release
    ;;
  release-it)
    release_it_release
    ;;
  gh)
    gh_release
    ;;
  *)
    echo "Utilisation : ./release.sh [standard-version|release-it|gh]"
    ;;
esac
