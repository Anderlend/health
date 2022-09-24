using health.Model;
using Microsoft.Extensions.Hosting.Internal;
using Newtonsoft.Json;

namespace health
{
    public class Helper
    {
        static string PathToFolderDB = "DB";//$"{System.IO.Directory.GetCurrentDirectory()}/DB/users.json";
       

        public static T ParseJsonFromDB<T>(string fileName)
        {
            var context = File.ReadAllText(Path.Combine(PathToFolderDB, fileName));

            T resp = JsonConvert.DeserializeObject<T>(context);

            return resp;
        }
    }
}
