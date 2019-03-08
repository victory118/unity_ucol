## Installation Instructions for Ubuntu 16.04

1. Install UnityHub
2. Choose a version of Unity to install. I installed a 2017 version with long term support (LTS).
3. Install monodevelop: `sudo apt-get install monodevelop`
4. Go to **Edit > Preferences > External Tools**. In the **External Script Editor** select **Browse...**. Go to the `/usr/bin` directory and find select `monodevelop`.
5. Select the option to **Add .unityproj's to .sln**.
6. You may have to install an older version of Mono/.NET in order to Build correctly. To check this go to **Project > Assemply-CSharp Options**. Under **Build > General**, the **Target framework** may say something like `Mono / .NET 3.5 (Not installed)`. If this is the case go to the terminal and install the correct version: `sudo apt-get install mono-reference-assemblies-3.5`. The Monodevelop IDE still does not recognize this new .NET version, but Unity does. This means I still cannot do a build in the Monodevelop IDE to check the correctness of my code. However, in Unity I can still drag the C# script into my scene object and it will use the new Target framework to build the project.

