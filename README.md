# ConvertFaust2Unity
Use a Faust musical instrument in Unity parametericing its variables easily 

[![SC2 Video](https://img.youtube.com/vi/X0OCmDB-Occ/0.jpg)](http://www.youtube.com/watch?v=X0OCmDB-Occ)


Steps:

0. Select a physical model from FAUST
1. Export from Faust to UnityPackage
2. Create a “dummy” project in Unity
3. Import Faust package to Unity
4. Assign plugin script to object
5. Play and control the instruments parameter through unity GUI
6. Get access to parameters and change them through C#



Files you need to make everything work: 

      - Find them in: https://github.com/chachipirulin/ConvertFaust2Unity/archive/main.zip
      - FaustVariableController.cs
      - Some audio file in wav format
 
0. Select a physical model from FAUST

       https://github.com/grame-cncm/faust/t...​

1. Export from Faust to UnityPackage

        - Go to https://faustide.grame.fr/​
        - Write the instrument/code you like
        - Choose export as (yellow button) and select:

        Platform: Unity
        Architecture: Depends if you have a Mac or windows

        - Select Compile and wait
        - Select Download

2. Create a “dummy” project in Unity

        - Select 2D or 3D
        - Create a folder called Plugins
        - Create a folder called Scripts
        - Create a folder called Resources
        - Place the audio file that you want in Resources folder
        - Create an object in the scene and call it DummyObject
        - In the inspector, add AudioSource as a Component
        - Drag and drop your audio file into “AudioClip” property of the AudioSource

3. Import Faust package to Unity

        - Click Assets tab— Import package — Custom Package
        - Select your FAUST unity package
        - Select everything and click “Import”
        - Make sure, that the package can be found in your “Plugins” folder
        - Go into the folder Plugins— YourFAUSTPlugin— Windows— x64 and select your plugin

        - Look at the inspector and:

         - Unselect the square “Any platform”
         - In ”Platform settings”, click the Unity symbol, click OS — Select “Windows and Apply”

4. Assign plugin script to object

        - In ”Scripts” folder, select your FaustPlugin_nameOfYourPlugin script
          (DO NOT confuse WITH FaustUTILITIES_nameOfYourPlugin) 
        - Drag and drop the script into the inspector of the DummyObject

5. Play and control the instruments parameter through unity GUI

        - Click Play on the scene and make sure you hear a sound
        - Make sure everything is working when you change the Plugin parameters

6. Get access to parameters and change them through C#

        - Copy paste the C# script called FaustVariableController into script folder

        - Overwrite two classes of the C#:
         -  Substitute "FaustPlugin_freeverbPlugin" BY THE NAME OF YOUR 
          FaustPlugin_NAME_OF_YOUR_PLUGIN.cs
         - Save the script
        - Assign the C# to the DummyObject in the inspector

        - Drag and drop DummyObject into the inspector script FaustVariableController, in the “this_Object” property
        - By default, this script accesses the first parameter value of Faust and sets its value to 0.9f,
          overwrite the script to get and set the Faust values of the plugin as you consider
