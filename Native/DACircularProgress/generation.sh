
#
# Сборка для айфона
#


xcodebuild archive \
-project DACircularProgress.xcodeproj \
-scheme DACircularProgress \
-configuration Release \
-sdk iphoneos \
-arch arm64 \
-archivePath archives/ios_device.xcarchive \
SKIP_INSTALL=NO


#
# Сборка для эмулятора
#


xcodebuild archive \
-project DACircularProgress.xcodeproj \
-scheme DACircularProgressSimulator \
-configuration Release \
-sdk iphonesimulator \
-arch arm64 -arch x86_64 \
-archivePath archives/ios_device_simulator.xcarchive \
SKIP_INSTALL=NO


#
# Объединение
#


rm -rf ./xcframeworks

xcodebuild -create-xcframework \
-archive archives/ios_device_simulator.xcarchive -framework DACircularProgress.framework \
-archive archives/ios_device.xcarchive -framework DACircularProgress.framework \
-output xcframeworks/DACircularProgress.xcframework

rm -rf ./archives
