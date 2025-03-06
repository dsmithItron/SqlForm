using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SqlForm.Classes
{
    internal class TestSql
    {
        public static string tableName = "";
        // This needs to be kept current with each table that needs to be accessed
        public static List<string> tableNames = new() {("Specform_all_options"),("Xml_sql_mapping")};
        private static string connectionString = "Data Source=../../../Resources/testDB.db";

        /// <summary>
        /// 
        /// </summary>
        public static void InitializeTables()
        {
            using (SqliteConnection connection = new(connectionString))
            {
                try
                {
                    connection.Open();
                    SqliteCommand command = connection.CreateCommand();
                    SqliteDataReader reader;

                    // --------------------------------------------------------------------------------------
                    // CREATE Specform_all_options
                    command.CommandText = @"DROP TABLE IF EXISTS Specform_all_options ";
                    command.ExecuteNonQuery();
                    command.CommandText = @"CREATE TABLE Specform_all_options(
                                            field TEXT, 
                                            value TEXT, 
                                            product TEXT, 
                                            options TEXT)";
                    command.ExecuteNonQuery();
                    // --------------------------------------------------------------------------------------


                    // --------------------------------------------------------------------------------------
                    // CREATE Xml_sql_mapping
                    command.CommandText = @"DROP TABLE IF EXISTS Xml_sql_mapping ";
                    command.ExecuteNonQuery();
                    command.CommandText =
                        @"CREATE TABLE Xml_sql_mapping
                        (
                           XML TEXT, 
                           SQL TEXT, 
                           Product TEXT, 
                           table_name TEXT, 
                           RATI INT, 
                           Spec_Search_Maintenance INT, 
                           RegEx TEXT, 
                           bool_to_yes_no INT, 
                           hard_value TEXT, 
                           where_clause TEXT,
                           field_priority INT, 
                           logic TEXT, 
                           common_name TEXT, 
                           persistent_field INT, 
                           Hard_Tag_Value TEXT
                        )";
                    command.ExecuteNonQuery();
                    // --------------------------------------------------------------------------------------

                    // --------------------------------------------------------------------------------------
                    // INSERT INTO Specform_all_options
                    command.CommandText =
                        @"INSERT INTO Specform_all_options (field, value, product, options) 
                          VALUES (@field, @value, @product, @options) ";
                    command.Parameters.AddWithValue("@field", "field1");
                    command.Parameters.AddWithValue("@value", "value1");
                    command.Parameters.AddWithValue("@product", "");
                    command.Parameters.AddWithValue("@options", DBNull.Value);
                    command.ExecuteNonQuery();
                    // --------------------------------------------------------------------------------------


                    // --------------------------------------------------------------------------------------
                    // INSERT INTO Xml_sql_mapping
                    command.CommandText =
                        @"INSERT INTO Xml_sql_mapping 
                          (XML, SQL, Product, table_name, RATI, Spec_Search_Maintenance, 
                           RegEx, bool_to_yes_no, hard_value, where_clause,field_priority,
                           logic, common_name, persistent_field, Hard_Tag_Value) 
                          VALUES (@XML, @SQL, @Product, @table_name, @RATI, @Spec_Search_Maintenance, @RegEx, 
                                  @bool_to_yes_no, @hard_value, @where_clause, @field_priority, @logic, @common_name, 
                                  @persistent_field, @Hard_Tag_Value) ";
                    command.Parameters.AddWithValue("@XML", "123");
                    command.Parameters.AddWithValue("@SQL", DBNull.Value);
                    command.Parameters.AddWithValue("@Product", "Cent");
                    command.Parameters.AddWithValue("@table_name", "ccgr");
                    command.Parameters.AddWithValue("@RATI", "21");
                    command.Parameters.AddWithValue("@Spec_Search_Maintenance", "");
                    command.Parameters.AddWithValue("@RegEx", "");
                    command.Parameters.AddWithValue("@bool_to_yes_no", "");
                    command.Parameters.AddWithValue("@hard_value", "");
                    command.Parameters.AddWithValue("@where_clause", "");
                    command.Parameters.AddWithValue("@field_priority", "");
                    command.Parameters.AddWithValue("@logic", "");
                    command.Parameters.AddWithValue("@common_name", " ");
                    command.Parameters.AddWithValue("@persistent_field", "test");
                    command.Parameters.AddWithValue("@Hard_Tag_Value", "val");
                    command.ExecuteNonQuery();
                    // --------------------------------------------------------------------------------------
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Type : {ex.GetType()}\nError : {ex.Message}",
                                    $"Error in testsql initialization",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Summary: <br></br>Grab all fields for a table
        /// <br></br><br></br>
        /// <remarks>Remark: <br></br>Needs to be changed when moving away from SqLite</remarks>
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns>String list of all fields found for table</returns>
        public static List<string> GetColumns(string tableName)
        {
            List<string> columns = new List<string>();

            using (SqliteConnection connection = new(connectionString))
            {
                try
                {
                    connection.Open();
                    SqliteCommand command = connection.CreateCommand();
                    command.CommandText =
                        $@" PRAGMA table_info({tableName}); ";

                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columns.Add(reader["name"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Type : {ex.GetType()}\nError : {ex.Message}",
                                    $"Error in getting {tableName} columns",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            return columns;
        }
        public static string BuildSelectQuery(string tableName, List<string> selectFields, List<string> selectConditions)
        {
            StringBuilder selectStringBuilder = new();
            selectStringBuilder.Append("SELECT ");
            if (selectFields.Count == 0)
            {
                selectStringBuilder.Append($"* FROM {tableName}");
            }
            else
            {
                selectStringBuilder.Append(string.Join(", ", selectFields));
                selectStringBuilder.Append($" FROM {tableName}");
            }
            if (selectConditions.Count > 0)
            {
                selectStringBuilder.Append(" WHERE ");
                selectStringBuilder.Append(string.Join(" AND ", selectConditions));
            }

            string selectString = selectStringBuilder.ToString();

            return selectString;
        }
        public static string BuildSelectQuery(string tableName, List<string> selectConditions)
        {
            StringBuilder selectStringBuilder = new();
            selectStringBuilder.Append("SELECT ");
            selectStringBuilder.Append($"* FROM {tableName}");
            if (selectConditions.Count > 0)
            {
                selectStringBuilder.Append(" WHERE ");
                selectStringBuilder.Append(string.Join(" AND ", selectConditions));
            }

            string selectString = selectStringBuilder.ToString();

            return selectString;
        }
        public static string BuildUpdateQuery(string tableName, List<string> updateFields, List<string> updateValues, List<string> updateConditions)
        {
            if (updateFields.Count != updateValues.Count) 
            {
                throw new Exception("The number of fields and values must be the same.");
            }

            StringBuilder updateStringBuilder = new();
            updateStringBuilder.Append($"Update {tableName} SET ");

            List<string> setClauses = new();
            for (int i = 0; i < updateFields.Count; i++)
            {
                setClauses.Add($"{updateFields[i]} = '{updateValues[i]}'");
            }
            updateStringBuilder.Append(string.Join(", ", setClauses));

            if (updateConditions.Count > 0)
            {
                updateStringBuilder.Append(" WHERE ");
                updateStringBuilder.Append(string.Join(" AND ", updateConditions));
            }

            string updateString = updateStringBuilder.ToString();

            return updateString;
        }


        /// <summary>
        /// Summary: <br></br>Get data table based on params that build query
        /// <br></br><br></br>
        /// <remarks>Remark: <br></br>Should be seperated into a querybuilder function that would pass built query to function</remarks>
        /// </summary>
        /// <param name="tableName">Table to have fields selected from</param>
        /// <param name="selectFields">Fields to be selected in query</param>
        /// <param name="selectConditions">Fields that will go after "Where" in query</param>
        /// <returns>Datatable to be used as datagrid connection in SelectForm</returns>
        public static DataTable ReaderQuery(string query)
        {
            DataTable selectTable = new();
            using (SqliteConnection connection = new(connectionString))
            {
                try
                {
                    connection.Open();
                    SqliteCommand command = connection.CreateCommand();
                    SqliteDataReader reader;

                    command.CommandText = query;
                    MessageBox.Show($"{command.CommandText}",
                                    $"Select Command",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    reader = command.ExecuteReader();

                    selectTable.Load(reader);
                    foreach (DataRow row in selectTable.Rows)
                    {
                        for (int i = 0; i < selectTable.Columns.Count; i++)
                        {
                            if (row.IsNull(i)) // Check if the value is NULL in the current DataRow
                            {
                                // Replace NULL value with "Null" string
                                row[i] = "NULL";
                            }
                        }
                    }
                    return selectTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Type : {ex.GetType()}\nError : {ex.Message}",
                                    $"Error in testsql Select",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return selectTable;
        }
        public static void NonReaderQuery(string query)
        {
            using (SqliteConnection connection = new(connectionString))
            {
                try
                {
                    connection.Open();
                    SqliteCommand command = connection.CreateCommand();
                    SqliteDataReader reader;

                    command.CommandText = query;
                    MessageBox.Show($"{command.CommandText}",
                                    $"Query Command",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Type : {ex.GetType()}\nError : {ex.Message}",
                                    $"Error in testsql NonReaderQuery",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
