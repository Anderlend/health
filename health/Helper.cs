using health.Model;
using Microsoft.Extensions.Hosting.Internal;
using Newtonsoft.Json;

namespace health
{
    public class Helper
    {
        static string PathToFolderDB = $"{System.IO.Directory.GetCurrentDirectory()}/DB/users.json";
       

        //public static Users ParseJsonFromDB(string fileName)
        //{
        //    var context = File.ReadAllText(PathToFolderDB);

        //    Users resp = JsonConvert.DeserializeObject<Users>(context);

        //    return resp;
        //}
    }
}
