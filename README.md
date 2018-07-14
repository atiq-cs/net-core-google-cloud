# Google Cloud Platform Demos using .net core
A few Google Cloud Platform APIs demo using .Net Core

## Project Descriptions
There are 4 projects under this directory.

 - [translate][2]
 - [image][3]
 - [speech][4]
 
Each of the project contains a readme file that provide explanations/details on the project.

To run any of these google cloud projects we have to set the environment variable `GOOGLE_APPLICATION_CREDENTIALS`; [cloud.google.com Authentication docs - Setting the environment variable][7] provides documentation on this. On powershell, this is how we set this variable to point to the location of json file,

    $Env:GOOGLE_APPLICATION_CREDENTIALS = 'D:\GCloud-Code\baynet-5d3100fe31x.json'

Of course, first, we have to create a project using Google Cloud Console. Then, we download json which contains credential.
 
### dump
3 projects depend on [dump][1] project. In each of them following command should be applied to add reference,

    $ dotnet add reference ..\dump\dump.csproj
    Reference `..\dump\dump.csproj` added to the project.

to use JsonDumper.

While 3 projects are EXE console application projects, `dump` is a class library project.

These demos are based on [demo source-code][5] provided by Jeffrey Rennie at Google during [South Bay .Net Google Cloud Platform event][6].

  [1]: https://github.com/atiq-cs/net-core-google-cloud/tree/master/dump
  [2]: https://github.com/atiq-cs/net-core-google-cloud/tree/master/translate
  [3]: https://github.com/atiq-cs/net-core-google-cloud/tree/master/image
  [4]: https://github.com/atiq-cs/net-core-google-cloud/tree/master/speech
  [5]: https://github.com/SurferJeffAtGoogle/demos
  [6]: https://www.meetup.com/BayNET/events/249062607/
  [7]: https://cloud.google.com/docs/authentication/getting-started#setting_the_environment_variable
