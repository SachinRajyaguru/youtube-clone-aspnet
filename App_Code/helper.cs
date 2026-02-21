using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public static class helper
{
    private static readonly string conStr =
        ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

    /*
     * Boolean crud function for insert, update, delete
     */
    public static Boolean crud(string query, params SqlParameter[] parameters)
    {
        if (string.IsNullOrWhiteSpace(query))
            return false;

        try
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);

                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    /*
     * DataTable mybind function for data binding
     */
    public static DataTable mybind(string query, params SqlParameter[] parameters)
    {
        DataTable datatable = new DataTable();

        if (string.IsNullOrWhiteSpace(query))
            return datatable;

        try
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);

                adapter.Fill(datatable);
            }
        }
        catch
        {
            return datatable;
        }

        return datatable;
    }

    /*
     * getMaxID function to get next ID from table
     */
    public static string getMaxID(string fieldName, string tableName)
    {
        string maxid = "0";

        if (string.IsNullOrWhiteSpace(fieldName) || string.IsNullOrWhiteSpace(tableName))
            return maxid;

        try
        {
            string query = $"SELECT ISNULL(MAX([{fieldName}]), 0) + 1 FROM [{tableName}]";

            using (SqlConnection connection = new SqlConnection(conStr))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                object result = command.ExecuteScalar();
                maxid = result?.ToString() ?? "0";
            }
        }
        catch
        {
            return maxid;
        }

        return maxid;
    }

    /*
     * BindDropDown returns Hashtable (kept same for compatibility)
     */
    public static Hashtable BindDropDown(string query, params SqlParameter[] parameters)
    {
        Hashtable hastbl = new Hashtable();

        if (string.IsNullOrWhiteSpace(query))
            return hastbl;

        try
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        hastbl.Add(
                            reader[0]?.ToString(),
                            reader[1]?.ToString()
                        );
                    }
                }
            }
        }
        catch
        {
            return hastbl;
        }

        return hastbl;
    }
}
