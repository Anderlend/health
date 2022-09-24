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

        public static UserVac ParseJsonToDB(string fileName, UserVac dataToUpdate, Guid id)
        {
            var context = File.ReadAllText(Path.Combine(PathToFolderDB, fileName));

            GetUsers respUsers = JsonConvert.DeserializeObject<GetUsers>(context);
            dataToUpdate.Id = Guid.NewGuid();

           foreach(var user in respUsers.Users)
            {
                if(user.Id == id)
                {
                    user.UserVac.Add(dataToUpdate);
                }
            }

            var serializedUsers = JsonConvert.SerializeObject(respUsers);
            File.WriteAllText(Path.Combine(PathToFolderDB, fileName), serializedUsers);

            return dataToUpdate;
        }
    }
}
