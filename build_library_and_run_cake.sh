#!/bin/bash
cd src/original_circleimageview_submodule/
# build release bypassing lint
./gradlew circleimageview:clean circleimageview:assembleRelease -x lint
cp circleimageview/build/outputs/aar/circleimageview-release.aar ../CircleImageView/Jars/
cd ../../
./build.sh