using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Migrations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SqlForm.Classes
{
    internal static class ApplicationHistory
    {
        public static SortedDictionary<string, SortedDictionary<string, List<string>>> tableConditions = new();

        /// <summary>
        /// Summary: <br></br>Initalize the needed keys for the history dictionaries.
        /// <br></br><br></br>
        /// <remark>Remark: Needs to be updated when dictionaires are added or updated</remark>
        /// </summary>
        public static void InitDictionaries()
        {
            foreach (string tableName in TestSql.tableNames)
            {
                tableConditions[tableName] = new();
                tableConditions[tableName]["SelectLeft"] = new();
                tableConditions[tableName]["SelectMiddle"] = new();
                tableConditions[tableName]["SelectRight"] = new();
            }
        }
        /// <summary>
        /// Summary: <br></br>Checks to see if SqlFormHistory.json exists in current directory.
        /// <br></br><br></br>
        /// <remark>Remark: If file is moved to different location this needs to be updated</remark>
        /// </summary>
        /// <returns></returns>
        public static bool CheckForHistory()
        {
            if (File.Exists("SqlFormHistory.json"))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Summary: <br></br>Fill dictionaries with data from SqlFormHistory.json
        /// <br></br><br></br>
        /// <remarks>Remark: Everything is hard coded and needs to be updated if History process changes at all</remarks>
        /// </summary>
        public static void LoadHistory()
        {
            // If tableConditions doesn't have any fields initialized 
            if (tableConditions.Count == 0)
            {
                InitDictionaries();
            }
            if (File.Exists("SqlFormHistory.json"))
            {
                string json = File.ReadAllText("SqlFormHistory.json");
                JsonDocument doc = JsonDocument.Parse(json);
                var historyArray = doc.RootElement.GetProperty("History").EnumerateArray();
                // Load Table History
                foreach (var historyItem in historyArray)
                {
                    string tableName = historyItem.GetProperty("TableName").ToString();
                    var selectHistoryArray = historyItem.GetProperty("SelectHistory").EnumerateArray();
                    var insertHistoryArray = historyItem.GetProperty("InsertHistory").EnumerateArray();
                    var deleteHistoryArray = historyItem.GetProperty("DeleteHistory").EnumerateArray();
                    var updateHistoryArray = historyItem.GetProperty("UpdateHistory").EnumerateArray();
                    // Load Select History
                    foreach (var selectHistoryItem in selectHistoryArray)
                    {
                        var selectLeftJson = selectHistoryItem.GetProperty("selectLeft").EnumerateArray();
                        var selectMiddleJson = selectHistoryItem.GetProperty("selectMiddle").EnumerateArray();
                        var selectRightJson = selectHistoryItem.GetProperty("selectRight").EnumerateArray();
                        foreach (var left in selectLeftJson)
                        {
                            if (!tableConditions[tableName]["SelectLeft"].Contains(left.ToString()))
                            {
                                tableConditions[tableName]["SelectLeft"].Add(left.ToString());
                            }
                        }
                        foreach (var middle in selectMiddleJson)
                        {
                            if (!tableConditions[tableName]["SelectMiddle"].Contains(middle.ToString()))
                            {
                                tableConditions[tableName]["SelectMiddle"].Add(middle.ToString());
                            }
                        }
                        foreach (var right in selectRightJson)
                        {
                            if (!tableConditions[tableName]["SelectRight"].Contains(right.ToString()))
                            {
                                tableConditions[tableName]["SelectRight"].Add(right.ToString());
                            }
                        }
                    }
                    // Load Insert History
                    foreach (var insertHistoryItem in insertHistoryArray) { }
                    // Load Delete History
                    foreach (var deleteHistoryItem in deleteHistoryArray) { }
                    // Load Update History
                    foreach (var updateHistoryItem in updateHistoryArray) { }
                }
            }
        }
        /// <summary>
        /// Summary: <br></br>Write dictionary info into SqlFormHistory.json
        /// <br></br><br></br>
        /// <remarks>Remark: Changing this means that the SqlFormHistory.json file needs to be deleted to avoid exception</remarks>
        /// <br></br>
        /// <remarks>Remark: Needs to be changed if fields being written to history change in format</remarks>
        /// </summary>
        /// <returns>If the SqlFormHistory.json exists after completion return true</returns>
        public static bool WriteHistory()
        {
            var history = new
            {
                History = tableConditions.Keys.Select(tableName => new
                {
                    TableName = tableName,
                    SelectHistory = new[]
                    {
                        new
                        {
                            selectLeft = tableConditions[tableName]["SelectLeft"],
                            selectMiddle = tableConditions[tableName]["SelectMiddle"],
                            selectRight = tableConditions[tableName]["SelectRight"]
                        }
                    },
                    InsertHistory = new[]
                        {
                            new
                            {

                            }
                        },
                    DeleteHistory = new[]
                        {
                            new
                            {

                            }
                        },
                    UpdateHistory = new[]
                        {
                            new
                            {

                            }
                        }
                }).ToArray()
            };


            string json = JsonSerializer.Serialize(history, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("SqlFormHistory.json", json);
            if (CheckForHistory()) { return true; }
            return false;
        }
    }
}
