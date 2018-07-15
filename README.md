# Google Cloud Platform Demos using .net core
A few Google Cloud Platform APIs are demonstrated using .Net Core in this repository. Google Cloud Platform has a long list of API can be further viewed [here][10].

## Project Descriptions
There are 4 projects under this directory.

 - [translate][2]
 - [image][3]
 - [speech][4]
 
Each of the project (links above) contains a readme file that provide explanations/details on the project.

To run any of these google cloud projects we have to set the environment variable `GOOGLE_APPLICATION_CREDENTIALS`; [cloud.google.com Authentication docs - Setting the environment variable][7] provides documentation on this. On powershell, this is how we set this variable to point to the location of json file,

    $Env:GOOGLE_APPLICATION_CREDENTIALS = 'D:\GCloud-Code\baynet-5d3100fe31x.json'

Of course, first, we have to create a project using Google Cloud Console. Then, we download json which contains credential for google cloud platform account.
 
### JsonDumper (dump)
3 projects depend on [dump][1] project. In each of them following command should be applied to add reference,

    $ dotnet add reference ..\dump\dump.csproj
    Reference `..\dump\dump.csproj` added to the project.

to use JsonDumper. Addition the project directory also contains instruction how to build it.

While 3 projects are EXE console application projects, `dump` is a class library project.

#### Instructions for building dump project
Create class library project,

    $ dotnet new classlib -n dump
    $ cd dump
    $ Rename-Item Program.cs JsonDumper.cs

Add required deps,

    $ dotnet add package Google.Protobuf
      Writing C:\Users\atiqc\AppData\Local\Temp\tmp1CED.tmp
    info : Adding PackageReference for package 'Google.Protobuf' into project 'D:\baynet\dump\dump.csproj'.
    log  : Restoring packages for D:\baynet\dump\dump.csproj...
    info :   CACHE https://api.nuget.org/v3-flatcontainer/google.protobuf/index.json
    info : Package 'Google.Protobuf' is compatible with all the specified frameworks in project 'D:\baynet\dump\dump.csproj'.
    info : PackageReference for package 'Google.Protobuf' version '3.6.0' added to file 'D:\baynet\dump\dump.csproj'.

    $ dotnet add package Newtonsoft.Json
      Writing C:\Users\atiqc\AppData\Local\Temp\tmp36AF.tmp
    info : Adding PackageReference for package 'Newtonsoft.Json' into project 'D:\baynet\dump\dump.csproj'.
    log  : Restoring packages for D:\baynet\dump\dump.csproj...
    info :   CACHE https://api.nuget.org/v3-flatcontainer/newtonsoft.json/index.json
    info : Package 'Newtonsoft.Json' is compatible with all the specified frameworks in project 'D:\baynet\dump\dump.csproj'.
    info : PackageReference for package 'Newtonsoft.Json' version '11.0.2' added to file 'D:\baynet\dump\dump.csproj'.

Let's build,

    $ dotnet build
    Microsoft (R) Build Engine version 15.7.179.6572 for .NET Core
    Copyright (C) Microsoft Corporation. All rights reserved.

      Restoring packages for D:\baynet\dump\dump.csproj...
      Restore completed in 127.98 ms for D:\baynet\dump\dump.csproj.
      dump -> D:\baynet\dump\bin\Debug\netstandard2.0\dump.dll

    Build succeeded.
        0 Warning(s)
        0 Error(s)

    Time Elapsed 00:00:01.44
    
These demos are based on [demo source-code][5] provided by Jeffrey Rennie at Google during [South Bay .Net Google Cloud Platform event][6].

Also came as minor note, Google has added Kotlin to official language list; acquired [kaggle][8] and rewriting it in their official language stacks.

For who wanna have brief note at .net core intro: [.NET Standard - Demystifying .NET Core and .NET Standard - Immo Landwerth][9]. Feel free to reach me, atiqcs 'at' outlook 'dot' com if you encounter any issue while building these demos.


  [1]: https://github.com/atiq-cs/net-core-google-cloud/tree/master/dump
  [2]: https://github.com/atiq-cs/net-core-google-cloud/tree/master/translate
  [3]: https://github.com/atiq-cs/net-core-google-cloud/tree/master/image
  [4]: https://github.com/atiq-cs/net-core-google-cloud/tree/master/speech
  [5]: https://github.com/SurferJeffAtGoogle/demos
  [6]: https://www.meetup.com/BayNET/events/249062607/
  [7]: https://cloud.google.com/docs/authentication/getting-started#setting_the_environment_variable
  [8]: https://www.kaggle.com/
  [9]: https://msdn.microsoft.com/en-us/magazine/mt842506.aspx
  [10]: https://developers.google.com/api-client-library/dotnet/apis/
