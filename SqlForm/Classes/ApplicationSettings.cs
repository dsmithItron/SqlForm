
using System.Text.Json;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static SqlForm.Classes.ApplicationSettings;

namespace SqlForm.Classes
{
    internal static class ApplicationSettings
    {
        public static List<Profile> Profiles = new();

        public class Profile
        {
            public string ProfileName { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public bool HideToolTips { get; set; }
            public int MaxSqlSelection { get; set; }

            public Profile()
            {
                ProfileName = "";
                Username = "";
                Password = "";
            }
        }

        public static string ProfileName = "";
        public static string Username = "";
        public static string Password = "";
        public static bool HideToolTips = false;
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
                try
                {
                    string json = File.ReadAllText("SqlFormSettings.json");
                    JsonDocument doc = JsonDocument.Parse(json);
                    var profilesArray = doc.RootElement.GetProperty("Profiles").EnumerateArray();
                    // Should only run once as settings only has one object 
                    foreach (var profile in profilesArray)
                    {
                        Profiles.Add(new Profile
                        {
                            ProfileName = profile.GetProperty("ProfileName").ToString(),
                            Username = profile.GetProperty("Username").ToString(),
                            Password = profile.GetProperty("Password").ToString(),
                            HideToolTips = bool.Parse(profile.GetProperty("HideToolTips").ToString()),
                            MaxSqlSelection = int.Parse(profile.GetProperty("MaxSqlSelection").ToString())
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in Loading Settings: {ex}");
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
                Profiles = new List<Profile>
                {
                    new Profile
                    {
                        ProfileName = ProfileName,
                        Username = Username,
                        Password = Password,
                        HideToolTips = HideToolTips,
                        MaxSqlSelection = MaxSqlSelection
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
