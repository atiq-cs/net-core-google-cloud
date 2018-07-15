# Google Cloud Translation API Demo using .net core
This is the readme page for Google Cloud Translation API Demo using .net core

First, we use google cloud console to enable the translation API for our project.
![Enabling translation API][1]

First, we create a console application,

    $ dotnet new console -n translate
    $ cd translate

We install required dep projects/nuget packages,
    
    $ dotnet add package Google.Cloud.Translation.V2
      Writing C:\Users\atiqc\AppData\Local\Temp\tmp2021.tmp
    info : Adding PackageReference for package 'Google.Cloud.Translation.V2' into project 'D:\baynet\translate\translate.csproj'.
    log  : Restoring packages for D:\baynet\translate\translate.csproj...
    info :   GET https://api.nuget.org/v3-flatcontainer/google.cloud.translation.v2/index.json
    info :   OK https://api.nuget.org/v3-flatcontainer/google.cloud.translation.v2/index.json 311ms
    info : Package 'Google.Cloud.Translation.V2' is compatible with all the specified frameworks in project 'D:\baynet\translate\translate.csproj'.
    info : PackageReference for package 'Google.Cloud.Translation.V2' version '1.0.0' added to file 'D:\baynet\translate\translate.csproj'.

For me, finding the right google translate package was a big deal. I seemed to be trying the wrong the package and running into issues.

![Finding right package for translation API][2]

For a simple demo, we don't need jsonDumper (dump project). We can call the API simply and print the result,

![Translation API debug output][3]

Add reference to json dumper project,
    
    $ dotnet add reference ..\dump\dump.csproj
    Reference `..\dump\dump.csproj` added to the project.
    
As we have enabled Google Cloud Translation API for our project already this is good time to go build and run the project.

Finally, we build/run the project,
    
    $ dotnet run
    Translation result ?????? ???.
    Detected source language en
    {
      "OriginalText": "Hello world.",
      "TranslatedText": "?????? ???.",
      "DetectedSourceLanguage": "en",
      "SpecifiedSourceLanguage": null,
      "TargetLanguage": "ru",
      "Model": null
    }
    
Because this Windows Console does not support Unicode, we cannot see it. However, when done on a web application or mvc or we debug (example above) it works great.


  [1]: https://github.com/atiq-cs/atiqcs-wp-com/raw/master/images/2018/07/06_cloud_translation_enable.png
  [2]: https://github.com/atiq-cs/atiqcs-wp-com/raw/master/images/2018/07/07_cloud_translation_package.png
  [3]: https://github.com/atiq-cs/atiqcs-wp-com/raw/master/images/2018/07/08_cloud_translation_simple_demo.png
