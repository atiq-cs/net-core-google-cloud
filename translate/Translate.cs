using System;
using Google.Cloud.Translation.V2;

namespace translate {
  class Program {
    static void Main(string[] args)
    {
      var client = TranslationClient.Create();
      var result = client.TranslateText("Hello world.", LanguageCodes.Russian);
      Console.WriteLine("Translation result " + result.TranslatedText);
      // another way to call it
      // client.TranslateText("Hello world.", "ru");
      Console.WriteLine($"Detected source language {result.DetectedSourceLanguage}");
      JsonDumper.Dump(result);
    }
  }
}
