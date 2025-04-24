$TOOL = $args[0]

function run_tests {
    Write-Host "Running tests..."
    npm test
    if ($LASTEXITCODE -ne 0) {
        Write-Host "Tests failed. Aborting release."
        exit 1
    }
    Write-Host "Tests passed."
}

switch ($TOOL) {
    'standard-version' {
        run_tests
        npx standard-version
        git push --follow-tags origin main
        break
    }
    'release-it' {
        run_tests
        npx release-it
        break
    }
    default {
        Write-Host "Usage: ./release.ps1 [standard-version|release-it]"
        exit 1
    }
}
