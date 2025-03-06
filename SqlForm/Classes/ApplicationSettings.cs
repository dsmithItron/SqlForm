
using System.Text.Json;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SqlForm.Classes
{
    internal static class ApplicationSettings
    {
        public static string Username = "";
        public static string Password = "";
        public static int MaxSqlSelection = 1;

        /// <summary>
        /// Summary: <br></br>Fill Setting data using SqlFormSettings.json
        /// <br></br><br></br>
        /// <remarks>Remark: Needs to be changed if more fields are added</remarks>
        /// </summary>
        public static void LoadSettings()
        {
            if (File.Exists("SqlFormSettings.json"))
            {
                string json = File.ReadAllText("SqlFormSettings.json");
                JsonDocument doc = JsonDocument.Parse(json);
                var settingsArray = doc.RootElement.GetProperty("Settings").EnumerateArray();
                // Should only run once as settings only has one object 
                foreach (var settings in settingsArray)
                {
                    Username = settings.GetProperty("Username").ToString();
                    Password = settings.GetProperty("Password").ToString();
                    MaxSqlSelection = Int32.Parse(settings.GetProperty("MaxSqlSelection").ToString());
                }
            }
        }
        /// <summary>
        /// Summary: <br></br>Checks if SqlFormSettings.json exists
        /// <br></br><br></br>
        /// <remarks>Remark: <br></br>Needs to be updated if location of SqlFormSettings.json changes</remarks>
        /// </summary>
        /// <returns>True if SqlFormSettings.json exists</returns>
        public static bool CheckForSettings()
        {
            if (File.Exists("SqlFormSettings.json"))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Summary: <br></br>Writes to SqlFormSettings.json
        /// <br></br><br></br>
        /// <remarks>Remark: <br></br>Needs to be updated if wanting to add or update settings fields</remarks>
        /// </summary>
        /// <returns>True if SqlFormSettings.json exists after runtime</returns>
        public static bool WriteSettings()
        {
            // Changing this means prior settings file needs to be deleted
            var settings = new
            {
                Settings = new[]
                {
                    new
                    {
                        Username,
                        Password,
                        MaxSqlSelection
                    }
                }
            };

            string json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("SqlFormSettings.json", json);
            if (CheckForSettings()) { return true; }
            return false;
        }
    }
}
