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

        public static UserVac ParseJsonToDB<UserVac>(string fileName, string dataToUpdate)
        {
            var context = File.ReadAllText(Path.Combine(PathToFolderDB, fileName));

            GetUsers respUsers = JsonConvert.DeserializeObject<GetUsers>(context);
            UserVac resp = JsonConvert.DeserializeObject<UserVac>(dataToUpdate);


           foreach(var user in respUsers.Users)
            {
                if(user.Id == Guid.Empty)
                {
                    //user.UserVac.Add(resp);

                }
            }



           //joks13131313@gmail.comFile.WriteAllText()


            return resp;
        }
    }
}
