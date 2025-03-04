﻿using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SqlForm.Classes
{
    internal class TestSql
    {
        public static string tableName = "";
        private static string connectionString = "Data Source=../../../Resources/testDB.db";
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
                        @"
                          PRAGMA table_info(Specform_all_options); 
                        ";
                    reader = command.ExecuteReader();
                    DataTable specformOptionsTable = new();
                    specformOptionsTable.Load(reader);
                    // --------------------------------------------------------------------------------------


                    // --------------------------------------------------------------------------------------
                    // SELECT XmlSqlMapping
                    command.CommandText =
                        @"
                          PRAGMA table_info(Xml_sql_mapping);
                        ";
                    reader = command.ExecuteReader();
                    DataTable xmlSqlMappingTable = new();
                    xmlSqlMappingTable.Load(reader);
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
                            // For example, to get the column name, you can use reader["name"]
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

        public static DataTable Select(string tableName, List<string> selectFields, List<string> selectConditions)
        {
            DataTable selectTable = new();
            using (SqliteConnection connection = new(connectionString))
            {
                try
                {
                    connection.Open();
                    SqliteCommand command = connection.CreateCommand();
                    SqliteDataReader reader;

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
                    command.CommandText = selectString;
                    MessageBox.Show($"{command.CommandText}",
                                    $"Select Command",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public static void Insert(string tableName, List<string> insertFields, List<string> insertFieldValues)
        {
            using (SqliteConnection connection = new(connectionString))
            {
                try
                {
                    connection.Open();
                    SqliteCommand command = connection.CreateCommand();
                    SqliteDataReader reader;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Type : {ex.GetType()}\nError : {ex.Message}",
                                    $"Error in testsql Select",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void Delete(string tableName, List<string> deleteFields, List<string> deleteConditions)
        {
            using (SqliteConnection connection = new(connectionString))
            {
                try
                {
                    connection.Open();
                    SqliteCommand command = connection.CreateCommand();
                    SqliteDataReader reader;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Type : {ex.GetType()}\nError : {ex.Message}",
                                    $"Error in testsql Select",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void Update(string tableName, List<string> updateFields, List<string> updateConditions)
        {
            using (SqliteConnection connection = new(connectionString))
            {
                try
                {
                    connection.Open();
                    SqliteCommand command = connection.CreateCommand();
                    SqliteDataReader reader;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Type : {ex.GetType()}\nError : {ex.Message}",
                                    $"Error in testsql Select",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
