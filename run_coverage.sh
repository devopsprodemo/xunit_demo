#!/bin/bash
set -e

echo "Running tests with code coverage..."
dotnet test --collect:"XPlat Code Coverage"

COVERAGE_FILE=$(find MyLibrary.Tests/TestResults -name 'coverage.cobertura.xml' | head -n 1)

if [ -z "$COVERAGE_FILE" ]; then
  echo "Coverage file not found!"
  exit 1
fi

echo "Generating HTML coverage report..."
reportgenerator -reports:"$COVERAGE_FILE" -targetdir:"coveragereport" -reporttypes:Html

echo "Opening coverage report in browser..."
open coveragereport/index.html 