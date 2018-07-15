# Google Cloud Speech API Demo using .net core
This is the Read Me page for Google Cloud Speech API Demo using .net core

First, we use google cloud console to enable the Speech API for our project.

![Enabling Speech API][1]

If we have not enabled the API, at a later stage, when we run the project we get following error,

    $ dotnet run
    Unhandled Exception: Grpc.Core.RpcException: Status(StatusCode=PermissionDenied, Detail="Cloud Speech API has not been used in project 447936112902 before or it is disabled. Enable it by visiting https://console.developers.google.com/apis/api/speech.googleapis.com/overview?project=447936112902 then retry. If you enabled this API recently, wait a few minutes for the action to propagate to our systems and retry.")
       at Grpc.Core.Internal.AsyncCall`2.UnaryCall(TRequest msg)
       at Grpc.Core.DefaultCallInvoker.BlockingUnaryCall[TRequest,TResponse](Method`2 method, String host, CallOptions options, TRequest request)
       at Grpc.Core.Internal.InterceptingCallInvoker.BlockingUnaryCall[TRequest,TResponse](Method`2 method, String host, CallOptions options, TRequest request)
       at Google.Cloud.Speech.V1.Speech.SpeechClient.Recognize(RecognizeRequest request, CallOptions options) in Google.Cloud.Speech.V1\Google.Cloud.Speech.V1\CloudSpeechGrpc.cs:line 157
       at Google.Api.Gax.Grpc.ApiCall.<>c__DisplayClass0_0`2.<Create>b__1(TRequest req, CallSettings cs) in gax-dotnet\releasebuild\src\Google.Api.Gax.Grpc\ApiCall.cs:line 27
       at Google.Api.Gax.Grpc.ApiCallRetryExtensions.<>c__DisplayClass1_0`2.<WithRetry>b__0(TRequest request, CallSettings callSettings) in gax-dotnet\releasebuild\src\Google.Api.Gax.Grpc\ApiCallRetryExtensions.cs:line 79
       at speech.Program.Main(String[] args) in D:\baynet\speech\Speech.cs:line 25

Hence, we need to enable the API.

Here's step by step instruction of creating the project. First, we create a console application,

    $ dotnet new console -n speech
    $ cd speech
    $ Move-Item Program.cs Speech.cs
    
We modify `Speech.cs` to call Speech API providing our image location.
    
We install required dep projects/nuget packages,
    
    $ dotnet add package Google.Cloud.Speech.V1
      Writing C:\Users\atiqc\AppData\Local\Temp\tmp3D40.tmp
    info : Adding PackageReference for package 'Google.Cloud.Speech.V1' into project 'D:\baynet\speech\speech.csproj'.
    log  : Restoring packages for D:\baynet\speech\speech.csproj...
    info :   GET https://api.nuget.org/v3-flatcontainer/google.cloud.speech.v1/index.json
    info :   OK https://api.nuget.org/v3-flatcontainer/google.cloud.speech.v1/index.json 374ms
    info :   GET https://api.nuget.org/v3-flatcontainer/google.cloud.speech.v1/1.0.1/google.cloud.speech.v1.1.0.1.nupkg
    info :   OK https://api.nuget.org/v3-flatcontainer/google.cloud.speech.v1/1.0.1/google.cloud.speech.v1.1.0.1.nupkg 234ms
    info :   GET https://api.nuget.org/v3-flatcontainer/google.api.gax.grpc/index.json
    info :   GET https://api.nuget.org/v3-flatcontainer/grpc.core/index.json
    info :   OK https://api.nuget.org/v3-flatcontainer/google.api.gax.grpc/index.json 343ms
    info :   GET https://api.nuget.org/v3-flatcontainer/google.api.gax.grpc/2.1.0/google.api.gax.grpc.2.1.0.nupkg
    info :   OK https://api.nuget.org/v3-flatcontainer/grpc.core/index.json 361ms
    info :   GET https://api.nuget.org/v3-flatcontainer/grpc.core/1.6.1/grpc.core.1.6.1.nupkg
    info :   OK https://api.nuget.org/v3-flatcontainer/google.api.gax.grpc/2.1.0/google.api.gax.grpc.2.1.0.nupkg 297ms
    info :   OK https://api.nuget.org/v3-flatcontainer/grpc.core/1.6.1/grpc.core.1.6.1.nupkg 298ms
    info :   GET https://api.nuget.org/v3-flatcontainer/google.api.commonprotos/index.json
    info :   GET https://api.nuget.org/v3-flatcontainer/google.api.gax/index.json
    info :   GET https://api.nuget.org/v3-flatcontainer/grpc.auth/index.json
    info :   GET https://api.nuget.org/v3-flatcontainer/google.apis.auth/index.json
    info :   OK https://api.nuget.org/v3-flatcontainer/google.api.commonprotos/index.json 339ms
    info :   GET https://api.nuget.org/v3-flatcontainer/google.api.commonprotos/1.1.0/google.api.commonprotos.1.1.0.nupkg
    info :   OK https://api.nuget.org/v3-flatcontainer/google.api.gax/index.json 375ms
    info :   GET https://api.nuget.org/v3-flatcontainer/google.api.gax/2.1.0/google.api.gax.2.1.0.nupkg
    info :   OK https://api.nuget.org/v3-flatcontainer/grpc.auth/index.json 487ms
    info :   GET https://api.nuget.org/v3-flatcontainer/grpc.auth/1.6.1/grpc.auth.1.6.1.nupkg
    info :   OK https://api.nuget.org/v3-flatcontainer/google.apis.auth/index.json 508ms
    info :   GET https://api.nuget.org/v3-flatcontainer/google.apis.auth/1.29.1/google.apis.auth.1.29.1.nupkg
    info :   OK https://api.nuget.org/v3-flatcontainer/google.api.commonprotos/1.1.0/google.api.commonprotos.1.1.0.nupkg 268ms
    info :   OK https://api.nuget.org/v3-flatcontainer/google.api.gax/2.1.0/google.api.gax.2.1.0.nupkg 372ms
    info :   OK https://api.nuget.org/v3-flatcontainer/grpc.auth/1.6.1/grpc.auth.1.6.1.nupkg 276ms
    info :   OK https://api.nuget.org/v3-flatcontainer/google.apis.auth/1.29.1/google.apis.auth.1.29.1.nupkg 248ms
    info :   GET https://api.nuget.org/v3-flatcontainer/google.apis.core/index.json
    info :   GET https://api.nuget.org/v3-flatcontainer/google.apis/index.json
    info :   GET https://api.nuget.org/v3-flatcontainer/google.protobuf/index.json
    info :   OK https://api.nuget.org/v3-flatcontainer/google.apis/index.json 268ms
    info :   OK https://api.nuget.org/v3-flatcontainer/google.apis.core/index.json 277ms
    info :   GET https://api.nuget.org/v3-flatcontainer/google.apis/1.29.1/google.apis.1.29.1.nupkg
    info :   GET https://api.nuget.org/v3-flatcontainer/google.apis.core/1.29.1/google.apis.core.1.29.1.nupkg
    info :   OK https://api.nuget.org/v3-flatcontainer/google.protobuf/index.json 295ms
    info :   GET https://api.nuget.org/v3-flatcontainer/google.protobuf/3.3.0/google.protobuf.3.3.0.nupkg
    info :   OK https://api.nuget.org/v3-flatcontainer/google.apis/1.29.1/google.apis.1.29.1.nupkg 261ms
    info :   OK https://api.nuget.org/v3-flatcontainer/google.apis.core/1.29.1/google.apis.core.1.29.1.nupkg 273ms
    info :   OK https://api.nuget.org/v3-flatcontainer/google.protobuf/3.3.0/google.protobuf.3.3.0.nupkg 300ms
    log  : Installing Google.Protobuf 3.3.0.
    log  : Installing Google.Apis.Core 1.29.1.
    log  : Installing Google.Apis 1.29.1.
    log  : Installing Google.Api.CommonProtos 1.1.0.
    log  : Installing Google.Apis.Auth 1.29.1.
    log  : Installing Google.Api.Gax 2.1.0.
    log  : Installing Grpc.Auth 1.6.1.
    log  : Installing Grpc.Core 1.6.1.
    log  : Installing Google.Api.Gax.Grpc 2.1.0.
    log  : Installing Google.Cloud.Speech.V1 1.0.1.
    info : Package 'Google.Cloud.Speech.V1' is compatible with all the specified frameworks in project 'D:\baynet\speech\speech.csproj'.
    info : PackageReference for package 'Google.Cloud.Speech.V1' version '1.0.1' added to file 'D:\baynet\speech\speech.csproj'.

After this has been taken care of, we add reference to json dumper project,
    
    $ dotnet add reference ..\dump\dump.csproj
    Reference `..\dump\dump.csproj` added to the project.
    
As we have enabled Google Cloud Speech API for our project already this is good time to go build and run the project.

Audio file supported by Speech API single channel (mono). If audio file contains more than one channel it gives us an error like this,

    $ dotnet run
    Unhandled Exception: Grpc.Core.RpcException: Status(StatusCode=InvalidArgument, Detail="Invalid audio channel count")
       at Grpc.Core.Internal.AsyncCall`2.UnaryCall(TRequest msg)
       at Grpc.Core.DefaultCallInvoker.BlockingUnaryCall[TRequest,TResponse](Method`2 method, String host, CallOptions options, TRequest request)
       at Grpc.Core.Internal.InterceptingCallInvoker.BlockingUnaryCall[TRequest,TResponse](Method`2 method, String host, CallOptions options, TRequest request)
       at Google.Cloud.Speech.V1.Speech.SpeechClient.Recognize(RecognizeRequest request, CallOptions options) in Google.Cloud.Speech.V1\Google.Cloud.Speech.V1\CloudSpeechGrpc.cs:line 157
       at Google.Api.Gax.Grpc.ApiCall.<>c__DisplayClass0_0`2.<Create>b__1(TRequest req, CallSettings cs) in gax-dotnet\releasebuild\src\Google.Api.Gax.Grpc\ApiCall.cs:line 27
       at Google.Api.Gax.Grpc.ApiCallRetryExtensions.<>c__DisplayClass1_0`2.<WithRetry>b__0(TRequest request, CallSettings callSettings) in /gax-dotnet\releasebuild\src\Google.Api.Gax.Grpc\ApiCallRetryExtensions.cs:line 79
       at speech.Program.Main(String[] args) in D:\Code\GCloud\baynet\speech\Speech.cs:line 25   

For this demo, I have recorded an m4a audio using Voice Recorder. Then, I converted it to flac using an online tool. Google cloud speech API requires the format of the audio to be one of the following,

 - FLAC
 - LINEAR16
 - MULAW
 - AMR
 - AMR_WB
 - OGG_OPUS
 - SPEEX_WITH_HEADER_BYTE

as per [cloud.google docs - speect API Supported audio encodings][2] I have used an [online tool][3] which also has an option to select mono for channels which is exactly what Speech API requires. This [github issues: Invalid audio channel count][4] contains some info.


Finally, we build/run the project which runs the Speech API on provided image which gives us following result,
    
    $ dotnet run
    Microsoft (R) Build Engine version 15.7.179.6572 for .NET Core
    Copyright (C) Microsoft Corporation. All rights reserved.

      Restoring packages for D:\Code\GCloud\baynet\speech\speech.csproj...
      Restore completed in 68.11 ms for D:\Code\GCloud\baynet\dump\dump.csproj.
      Restore completed in 343.44 ms for D:\Code\GCloud\baynet\speech\speech.csproj.
      dump -> D:\Code\GCloud\baynet\dump\bin\Debug\netstandard2.0\dump.dll
      speech -> D:\Code\GCloud\baynet\speech\bin\Debug\netcoreapp2.1\speech.dll
      
    {
      "results": [
        {
          "alternatives": [
            {
              "transcript": "this is a Google Cloud speech recognition API test so the platform provide significant improvement over previous business on speech recognition",
              "confidence": 0.884680748,
              "words": []
            }
          ]
        },
        {
          "alternatives": [
            {
              "transcript": " you're such a struggle only a few weeks after launching imagine over all of these clouds text to speech API Google today also announced an update you that's a recent speech to text voice recognition service is new and improved Cloud speech-to-text API plumbing system if you can't leave the room",
              "confidence": 0.9430395,
              "words": []
            }
          ]
        },
        {
          "alternatives": [
            {
              "transcript": " voice recognition performance the new Epi iPhone users are reduction wardell's down",
              "confidence": 0.8793565,
              "words": []
            }
          ]
        },
        {
          "alternatives": [
            {
              "transcript": " in some areas the results are actually far better than that that's it for now",
              "confidence": 0.869719744,
              "words": []
            }
          ]
        }
      ]
    }

Looks like Speech API extracted a handful of info from the provided audio file. Audio file is also included in this github repo's project. Please play to measure the context. Speech API is good, but it had a number of mistakes for the audio. Sample might as well not been easy since I recorded that over in a noisy place.


  [1]: https://github.com/atiq-cs/atiqcs-wp-com/raw/master/images/2018/07/10_cloud_speech_enable.png
  [2]: https://cloud.google.com/speech-to-text/docs/encoding
  [3]: https://www.online-convert.com/result/52dff89c-9bc9-4d2e-acad-c5244e005e1e
  [4]: https://github.com/GoogleCloudPlatform/google-cloud-php/issues/424
