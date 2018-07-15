# Google Cloud Vision API Demo using .net core
This is the readme page for Google Cloud Vision API Demo using .net core

First, we use google cloud console to enable the Vision API for our project.

![Enabling Vision API][1]

If we don't enable the API, at a later stage, when we run the project we get following error,

    $ dotnet run
    Unhandled Exception: Grpc.Core.RpcException: Status(StatusCode=PermissionDenied, Detail="Cloud Vision API has not been used in project xxxxxxxxxx before or it is disabled. Enable it by visiting https://console.developers.google.com/apis/api/vision.googleapis.com/overview?project=xxxxxxxxxx then retry. If you enabled this API recently, wait a few minutes for the action to propagate to our systems and retry.")
       at Grpc.Core.Internal.AsyncCall`2.UnaryCall(TRequest msg) in Grpc.Core\Internal\AsyncCall.cs:line 75
       at Grpc.Core.DefaultCallInvoker.BlockingUnaryCall[TRequest,TResponse](Method`2 method, String host, CallOptions options, TRequest request) in Grpc.Core\DefaultCallInvoker.cs:line 46
       at Grpc.Core.Interceptors.InterceptingCallInvoker.<BlockingUnaryCall>b__3_0[TRequest,TResponse](TRequest req, ClientInterceptorContext`2 ctx) in Grpc.Core\Interceptors\InterceptingCallInvoker.cs:line 51
       at Grpc.Core.ClientBase.ClientBaseConfiguration.ClientBaseConfigurationInterceptor.BlockingUnaryCall[TRequest,TResponse](TRequest request, ClientInterceptorContext`2 context, BlockingUnaryCallContinuation`2 continuation) in Grpc.Core\ClientBase.cs:line 174
       at Grpc.Core.Interceptors.InterceptingCallInvoker.BlockingUnaryCall[TRequest,TResponse](Method`2 method, String host, CallOptions options, TRequest request) in Grpc.Core\Interceptors\InterceptingCallInvoker.cs:line 48
       at Google.Cloud.Vision.V1.ImageAnnotator.ImageAnnotatorClient.BatchAnnotateImages(BatchAnnotateImagesRequest request, CallOptions options) in Google.Cloud.Vision.V1\Google.Cloud.Vision.V1\ImageAnnotatorGrpc.cs:line 138
       at Google.Api.Gax.Grpc.ApiCall.<>c__DisplayClass0_0`2.<Create>b__1(TRequest req, CallSettings cs) in C:\Users\jon\Test\Projects\gax-dotnet\releasebuild\src\Google.Api.Gax.Grpc\ApiCall.cs:line 27
       at Google.Api.Gax.Grpc.ApiCallRetryExtensions.<>c__DisplayClass1_0`2.<WithRetry>b__0(TRequest request, CallSettings callSettings) in C:\Users\jon\Test\Projects\gax-dotnet\releasebuild\src\Google.Api.Gax.Grpc\ApiCallRetryExtensions.cs:line 84
       at Google.Cloud.Vision.V1.ImageAnnotatorClient.Annotate(AnnotateImageRequest request, CallSettings settings) in Google.Cloud.Vision.V1\Google.Cloud.Vision.V1\ImageAnnotatorClientPartial.cs:line 368
       at Google.Cloud.Vision.V1.ImageAnnotatorClient.AnnotateSingleFeatureType[T](Type featureType, Func`2 annotationExtractor, Image image, ImageContext context, Int32 maxResults, CallSettings callSettings) in Google.Cloud.Vision.V1\Google.Cloud.Vision.V1\ImageAnnotatorClientPartial.cs:line 426
       at Google.Cloud.Vision.V1.ImageAnnotatorClient.DetectLabels(Image image, ImageContext context, Int32 maxResults, CallSettings callSettings) in Google.Cloud.Vision.V1\Google.Cloud.Vision.V1\ImageAnnotatorClientPartial.cs:line 75
       at image.Program.Main(String[] args) in D:\baynet\image\Image.cs:line 23

that proves why we need to enable the API.

Here's step by step instruction of creating the project. First, we create a console application,

    $ dotnet new console -n image
    $ cd image
    $ Move-Item Program.cs Image.cs

We modify `Image.cs` to call Vision API providing our image location.
    
We install required dep projects/nuget packages,
    
    $ dotnet add package Google.Cloud.Vision.V2

After this has been taken care of, we add reference to json dumper project,
    
    $ dotnet add reference ..\dump\dump.csproj
    Reference `..\dump\dump.csproj` added to the project.
    
As we have enabled Google Cloud Vision API for our project already this is good time to go build and run the project. We put a sample image as showed below inside the project directory,

![Oracle HQ Redwood][2]

If image file does not exist it gives us an error like this,

    $ dotnet run
    Unhandled Exception: System.IO.FileNotFoundException: Could not find file 'D:\baynet\image\oracle_cw20v1-hq_3224414.jpg'.
       at System.IO.FileStream.ValidateFileHandle(SafeFileHandle fileHandle)
       at System.IO.FileStream.CreateFileOpenHandle(FileMode mode, FileShare share, FileOptions options)
       at System.IO.FileStream..ctor(String path, FileMode mode, FileAccess access, FileShare share, Int32 bufferSize, FileOptions options)
       at System.IO.FileStream..ctor(String path, FileMode mode, FileAccess access, FileShare share, Int32 bufferSize)
       at System.IO.File.ReadAllBytes(String path)
       at Google.Cloud.Vision.V1.Image.FromFile(String path) in Google.Cloud.Vision.V1\Google.Cloud.Vision.V1\ImagePartial.cs:line 139
       at image.Program.Main(String[] args) in D:\baynet\image\Image.cs:line 23

Finally, we build/run the project which runs the Vision API on provided image which gives us following result,
    
    $ dotnet run
    Microsoft (R) Build Engine version 15.7.179.6572 for .NET Core
    Copyright (C) Microsoft Corporation. All rights reserved.

      Restoring packages for D:\baynet\image\image.csproj...
      Restore completed in 33.24 ms for D:\baynet\dump\dump.csproj.
      Restore completed in 266.95 ms for D:\baynet\image\image.csproj.
      dump -> D:\baynet\dump\bin\Debug\netstandard2.0\dump.dll
      image -> D:\baynet\image\bin\Debug\netcoreapp2.1\image.dll
    [
      {
        "mid": "/m/0d9wj",
        "locale": "",
        "description": "urban design",
        "score": 0.8630108,
        "confidence": 0,
        "topicality": 0.8630108,
        "boundingPoly": null,
        "locations": [],
        "properties": []
      },
      {
        "mid": "/m/0c1vxg",
        "locale": "",
        "description": "mixed use",
        "score": 0.8601368,
        "confidence": 0,
        "topicality": 0.8601368,
        "boundingPoly": null,
        "locations": [],
        "properties": []
      },
      {
        "mid": "/m/039jbq",
        "locale": "",
        "description": "urban area",
        "score": 0.858946,
        "confidence": 0,
        "topicality": 0.858946,
        "boundingPoly": null,
        "locations": [],
        "properties": []
      },
      {
        "mid": "/m/0j_s4",
        "locale": "",
        "description": "metropolitan area",
        "score": 0.8510351,
        "confidence": 0,
        "topicality": 0.8510351,
        "boundingPoly": null,
        "locations": [],
        "properties": []
      },
      {
        "mid": "/m/08863x",
        "locale": "",
        "description": "bird's eye view",
        "score": 0.8377634,
        "confidence": 0,
        "topicality": 0.8377634,
        "boundingPoly": null,
        "locations": [],
        "properties": []
      },
      {
        "mid": "/m/020ys5",
        "locale": "",
        "description": "condominium",
        "score": 0.821502268,
        "confidence": 0,
        "topicality": 0.821502268,
        "boundingPoly": null,
        "locations": [],
        "properties": []
      },
      {
        "mid": "/m/02nfxt",
        "locale": "",
        "description": "residential area",
        "score": 0.8121722,
        "confidence": 0,
        "topicality": 0.8121722,
        "boundingPoly": null,
        "locations": [],
        "properties": []
      },
      {
        "mid": "/m/01w5c_",
        "locale": "",
        "description": "aerial photography",
        "score": 0.757819235,
        "confidence": 0,
        "topicality": 0.757819235,
        "boundingPoly": null,
        "locations": [],
        "properties": []
      },
      {
        "mid": "/m/01n32",
        "locale": "",
        "description": "city",
        "score": 0.752827168,
        "confidence": 0,
        "topicality": 0.752827168,
        "boundingPoly": null,
        "locations": [],
        "properties": []
      },
      {
        "mid": "/m/0vlys",
        "locale": "",
        "description": "tower block",
        "score": 0.749884546,
        "confidence": 0,
        "topicality": 0.749884546,
        "boundingPoly": null,
        "locations": [],
        "properties": []
      }
    ]

Looks like Vision API extracted a handful of info from the provided image. I am yet to figure out why confidence property is showing up 0 from the Vision API result.



  [1]: https://github.com/atiq-cs/atiqcs-wp-com/raw/master/images/2018/07/09_cloud_vision_enable.png
  [2]: https://github.com/atiq-cs/net-core-google-cloud/raw/master/image/oracle_cw20v1-hq_3224414.jpg
  
