#!/bin/bash
set -x

if [[ $(git status -s) ]]; then
    echo "You have uncommitted files. Commit and push them before running this script."
  #  exit 1
fi

# get latest git tag for current base version
BASE_VERSION=`cat version.txt`
LAST_VERSION=`git tag --sort="v:refname" -l "${BASE_VERSION}.*" | tail -n 1`
# increase version by one (see https://stackoverflow.com/questions/4485399/how-can-i-bump-a-version-number-using-bash)
VERSION=`echo ${LAST_VERSION} | awk -F. '/[0-9]+\./{$NF+=1;OFS=".";print}'`
# if there are no versions built for the base version, fallback to x.y.0
VERSION=${VERSION:-$BASE_VERSION.0}
echo "setting version to $VERSION"

XAMARIN_TOOLS=/Library/Frameworks/Mono.framework/Versions/Current/Commands/
NUGET="$XAMARIN_TOOLS/nuget"

function publishNuGet {
  git tag -a $VERSION -m ''  || exit 1
  git push --tags || exit 1

  nuget push $1 -Source https://www.nuget.org/api/v2/package || exit 1
}

rm -r XFormsTouch.NuGet/bin/Release/
$NUGET restore InterfaceBuilder.sln || exit 1

sed -i '' "s/\(<PackageVersion>\).*\(<\/PackageVersion>\)/\1$VERSION\2/" InterfaceBuilder.NuGet/InterfaceBuilder.NuGet.nuproj
msbuild /p:Configuration=Release InterfaceBuilder.sln || exit 1

publishNuGet InterfaceBuilder.NuGet/bin/Release/InterfaceBuilder.*.nupkg
