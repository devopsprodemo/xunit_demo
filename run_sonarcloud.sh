#!/bin/bash
set -e

# Set these variables before running the script
SONAR_TOKEN=${SONAR_TOKEN:-"cd9676f64a9b1c52d8f62845a3d1fec32cdda255"}
SONAR_PROJECT_KEY=${SONAR_PROJECT_KEY:-"devopsprodemo_xunit_demo"}
SONAR_ORG=${SONAR_ORG:-"devopsprodemo"}

if [[ "$SONAR_TOKEN" == "<your-sonarcloud-token>" || "$SONAR_PROJECT_KEY" == "<your-sonarcloud-project-key>" || "$SONAR_ORG" == "<your-sonarcloud-organization>" ]]; then
  echo "Please set SONAR_TOKEN, SONAR_PROJECT_KEY, and SONAR_ORG as environment variables or edit this script."
  exit 1
fi

echo "Starting SonarCloud analysis..."
dotnet sonarscanner begin \
  /k:"$SONAR_PROJECT_KEY" \
  /o:"$SONAR_ORG" \
  /d:sonar.login="$SONAR_TOKEN" \
  /d:sonar.host.url="https://sonarcloud.io" \
  /d:sonar.cs.opencover.reportsPaths="MyLibrary.Tests/TestResults/**/coverage.opencover.xml"

echo "Building the solution..."
dotnet build

echo "Running tests and collecting coverage..."
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput=TestResults/coverage.opencover.xml

echo "Finishing SonarCloud analysis..."
dotnet sonarscanner end /d:sonar.login="$SONAR_TOKEN"

echo "SonarCloud analysis complete. Check your project dashboard on https://sonarcloud.io/ for results." 