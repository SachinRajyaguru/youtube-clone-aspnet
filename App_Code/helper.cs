using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
static public class helper
{
    static public string conStr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
    static public string query = string.Empty;

    static SqlConnection connection = new SqlConnection(conStr);
    static DataSet dataset;
    static SqlDataAdapter adapter;
    static SqlDataReader reader;

    /*
     * Boolean crud function for all insert , update or delete and retun true or false
     */
    static public Boolean crud(string query)
    {
        try
        {
            if (!string.IsNullOrEmpty(query) && !string.IsNullOrWhiteSpace(query))
            {
                connection.Open();
                new SqlCommand(query, connection).ExecuteNonQuery();
                connection.Close();
                return true;
            }
            else return false;
        }
        catch (Exception e)
        {
            return false;
        }
    }
    /*
     * DataSet mybind function for all data binding retun the dataset adjust by query
     */
    static public DataTable mybind(string query)
    {
        DataTable datatable = new DataTable();
        try
        {
            if (!string.IsNullOrEmpty(query) && !string.IsNullOrWhiteSpace(query))
            {
                new SqlDataAdapter(new SqlCommand(query, connection)).Fill(datatable);
            }
        }
        catch (Exception e)
        {
            return datatable;
        }
        return datatable;
    }
    /*
     * string getMaxID function for get fieldName,tableName retun the MAXID of the table
     */
    static public string getMaxID(string fieldName, string tableName)
    {
        string maxid = "0";
        if (!string.IsNullOrEmpty(fieldName) && !string.IsNullOrEmpty(tableName) && !string.IsNullOrWhiteSpace(fieldName) && !string.IsNullOrWhiteSpace(tableName))
        {
            try
            {
                connection.Open();
                reader = new SqlCommand("SELECT MAX(" + fieldName.ToString() + ") + 1 FROM " + tableName.ToString(), connection).ExecuteReader();
                if (reader.Read())
                    maxid = reader.GetValue(0).ToString();
                reader.Close();
                connection.Close();
                return maxid;
            }
            catch (Exception ee)
            {
                return maxid;
            }
        }
        else return maxid;
    }
    static public Hashtable BindDropDown(string query)
    {
        Hashtable hastbl = new Hashtable();
        try
        {
            connection.Open();
            reader = new SqlCommand(query, connection).ExecuteReader();
            while (reader.Read()) hastbl.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString());
            reader.Close();
            connection.Close();
        }
        catch (Exception)
        {
            return hastbl;
        }
        return hastbl;
    }
}