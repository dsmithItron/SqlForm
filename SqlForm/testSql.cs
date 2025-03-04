using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;

namespace SqlForm
{
    internal class TestSql
    {
        public static string tableName = "";
        public static void InitializeTables()
        {
            var connectionString = "Data Source=:memory:;Version=3;New=True;";


            using (var connection = new SqliteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqliteCommand command = connection.CreateCommand();
                    SqliteDataReader reader;


                    // --------------------------------------------------------------------------------------
                    // CREATE Specform_all_options
                    command.CommandText = "CREATE TABLE Specform_all_options (field TEXT, value TEXT, product TEXT, options TEXT)";
                    command.ExecuteNonQuery();
                    // --------------------------------------------------------------------------------------


                    // --------------------------------------------------------------------------------------
                    // CREATE Xml_sql_mapping
                    command.CommandText = 
                        @"CREATE TABLE Xml_sql_mapping 
                          (XML TEXT, SQL TEXT, Product TEXT, table_name TEXT, RATI INT, Spec_Search_Maintenance INT, RegEx TEXT, bool_to_yes_no INT, hard_value TEXT, where_clause TEXT,
                           field_priority INT, logic TEXT, common_name TEXT, persistent_field INT, Hard_Tag_Value TEXT)
                        ";
                    command.ExecuteNonQuery();
                    // --------------------------------------------------------------------------------------


                    // --------------------------------------------------------------------------------------
                    // INSERT INTO Specform_all_options
                    command.CommandText =
                        @"INSERT INTO Specform_all_options (field, value, product, options) 
                          VALUES (@field, @value, @product, @options) ";
                    command.Parameters.AddWithValue("@field", "field1");
                    command.Parameters.AddWithValue("@value", "value1");
                    command.Parameters.AddWithValue("@product", "product1");
                    command.Parameters.AddWithValue("@options", "option1");
                    command.ExecuteNonQuery();
                    // --------------------------------------------------------------------------------------


                    // --------------------------------------------------------------------------------------
                    // INSERT INTO Xml_sql_mapping
                    command.CommandText =
                        @"INSERT INTO Xml_sql_mapping 
                          (XML, SQL, Product, table_name, RATI, Spec_Search_Maintenance, RegEx, bool_to_yes_no, hard_value, where_clause,
                           field_priority, logic, common_name, persistent_field, Hard_Tag_Value) 
                          VALUES (@XML, @SQL, @Product, @table_name, @RATI, @Spec_Search_Maintenance, @RegEx, 
                                  @bool_to_yes_no, @hard_value, @where_clause, @field_priority, @logic, @common_name, 
                                  @persistent_field, @Hard_Tag_Value) ";
                    command.Parameters.AddWithValue("@XML", "");
                    command.Parameters.AddWithValue("@SQL", "");
                    command.Parameters.AddWithValue("@Product", "");
                    command.Parameters.AddWithValue("@table_name", "");
                    command.Parameters.AddWithValue("@RATI", "");
                    command.Parameters.AddWithValue("@Spec_Search_Maintenance", "");
                    command.Parameters.AddWithValue("@RegEx", "");
                    command.Parameters.AddWithValue("@bool_to_yes_no", "");
                    command.Parameters.AddWithValue("@hard_value", "");
                    command.Parameters.AddWithValue("@where_clause", "");
                    command.Parameters.AddWithValue("@field_priority", "");
                    command.Parameters.AddWithValue("@logic", "");
                    command.Parameters.AddWithValue("@common_name", "");
                    command.Parameters.AddWithValue("@persistent_field", "");
                    command.Parameters.AddWithValue("@Hard_Tag_Value", "");
                    command.ExecuteNonQuery();
                    // --------------------------------------------------------------------------------------


                    // --------------------------------------------------------------------------------------
                    // SELECT SpecformAllOptions
                    command.CommandText =
                        "SELECT * FROM Specform_all_options ";
                    reader = command.ExecuteReader();
                    DataTable specformOptionsTable = new ();
                    specformOptionsTable.Load(reader);
                    // --------------------------------------------------------------------------------------


                    // --------------------------------------------------------------------------------------
                    // SELECT XmlSqlMapping
                    command.CommandText =
                        "SELECT * FROM Xml_sql_mapping ";
                    reader = command.ExecuteReader();
                    DataTable xmlSqlMappingTable = new ();
                    xmlSqlMappingTable.Load(reader);
                    // --------------------------------------------------------------------------------------
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex}");
                }
            }
        }
        public static void Select(string tableName, List<string> selectFields, List<string> selectConditions)
        {

        }
        public static void Insert(string tableName, List<string> insertFields, List<string> insertFieldValues)
        {

        }
        public static void Delete(string tableName, List<string> deleteFields, List<string> deleteConditions)
        {

        }
        public static void Update(string tableName, List<string> updateFields, List<string> updateConditions)
        {

        }
    }
}
