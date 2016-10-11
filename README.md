# Unity-Assetbundles-CLI-Example
A sweet example of using assetbundles in unity

#### Purpose: Using Command line construct different Assetbundles after copying different assets into project folder
<br />
# How to Use
### Before you clone project and start, you may need to change:<br /><br />
1. Create An folder to store assetbundles, named waht ever you like<br /><br />
2. Open Unity Project "Instantiate Assetbundles", Click "Main Camera", you'll find a component called "test(Script)" in Inspector,
change the paramter to the path of the folder you just create. However leave <code>/testbundle</code> at bottom.<br /><br />
3. Open "buildAssetbundle.bat" and modified parameters above<br /><br />
<pre>
SET UNITYPATH= Where you installed Unity
SET CREATEPROJECTPATH= Path of project "Create Asset bundles"
SET BUILDPATH= Path of builds of project "Create Asset bundles"
SET UNITYUSER= you Unity Account
</pre>
4. Done <br /><br />

### Demo
5. Click "buildAssetbundle.bat", wait for console disappear (it may last for seconds)<br /><br />
6. open the build path, you shall see a folder "StreamingAssets", copy the file "testbundle" and "testbundle.manifest" into the folder you created in Step 1 in "Before you clone..."<br />(Or you may change the parameter in Step2 in "Before you clone..." to <code>your_build_path/StreamingAssets/testbundle</code>, though I don't recommend it)<br /><br />
7. Build Unity Project "Instantiate Assetbundles" (this step only need to be done once), Open executable build, you will see a big white covered model in the scene. <br /><br />
8. (Optional) Usage : <br />
  4-1. copy you model into <code>path_of_"Create Asset bundles"/Assets/Pinocchio.fbx</code><br />
  4-2. click "buildAssetbundle.bat", copy <code>path_of_build_of_"Create Asset bundles"/StreamingAssets/testbundle</code> to <code>parameters you've set in Step2 in "Before you clone..."</code><br />
  4-3.  open "Instantiate Assetbundles" executables, you will see another model<br /><br />

### How it's Done
Well, it it no big deal but using unity command line parameter : <code>-executeMethod</code>, this parameter allows you executing <code>Editor class</code> function when compiling.

### Special Thanks
Mr. 秉宜
