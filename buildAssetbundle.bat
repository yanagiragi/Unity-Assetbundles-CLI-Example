SET UNITYPATH="C:\Program Files\Unity\Editor\Unity.exe"
SET CREATEPROJECTPATH="C:\temp\Create Asset bundles"
SET BUILDPATH="C:\temp\build.exe"
SET UNITYUSER="yanagiragi"

%UNITYPATH% -batchmode -quit -projectPath %CREATEPROJECTPATH% -executeMethod CreateAssetBundles.CreateAssetBundlesMain -user %UNITYUSER% -buildWindows64Player %BUILDPATH%

rem if you can't understand the code above, you may need to take a look at 
rem https://docs.unity3d.com/Manual/CommandLineArguments.html
