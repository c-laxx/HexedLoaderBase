# HexedLoaderBase
This is a base for VRChat to be used with HexedLoader.
I cannot provide the Assemblies/Dependencies, you will need to get those yourself from the 
(HexedWare Folder)/Settings/UnityLoader/VRChat/Dummy(and Runtime)

To do that, just run VRChat with the Unity Injector once, and it will generate all the files.
Then right click on assemblies and add a new project reference, go to browse and add ALL of the
files from Dummy, plus CoreRuntime.dll and Il2CppInterop.Runtime.dll(from the Runtime folder)

If you just build it, it should give you a tab, and an example button to start out with.
