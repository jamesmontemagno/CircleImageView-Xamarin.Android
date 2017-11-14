cd src\original_circleimageview_submodule\
.\gradlew circleimageview:clean circleimageview:assembleRelease -x lint --stacktrace
cp circleimageview\build\outputs\aar\circleimageview-release.aar ..\CircleImageView\Jars\
cd ..\..\
.\build.ps1 -Target Default -Verbosity diagnostic
