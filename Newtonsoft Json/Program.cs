using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Newtonsoft_Json
{
    class JSon2CSharp
    {
        static void Main(string[] args)
        {
            var client = new WebClient();
            var text = client.DownloadString(@"https://jsonplaceholder.typicode.com/posts/1");

            //Use http://json2csharp.com/ to convert Json to Csharp class
            //or Also you can convert, copy JSon Text --> Visual Studio --> File --> Edit --> Paste Special --> Paste JSON as Classes
            //https://www.youtube.com/watch?v=Tfavg5PTus0
            //Converting JSon to Csharp Class
            JsonClass jsonDeSerObj = JsonConvert.DeserializeObject<JsonClass>(text);

            Console.WriteLine(jsonDeSerObj.id+"\r\n"+jsonDeSerObj.title);

            //Csharp Class to JSON
            string jsonSerializeObj = JsonConvert.SerializeObject(jsonDeSerObj);
  
        }
    }
}
