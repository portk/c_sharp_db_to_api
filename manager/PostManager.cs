using MySql.Data.MySqlClient;

class PostManager
{
    MariaDBInfo dbinfo;

    public PostManager()
    {
        dbinfo = new MariaDBInfo("localhost",3306,"root","1234","blog");
    }

    public List<Post> selectQry(string query)
    {
        List<Post> result = new List<Post>();
        try
        {
            MySqlCommand cmd = new MySqlCommand(query, dbinfo.GetConnection());
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Post temp = new Post();
                temp.PostId = dr.GetInt32(0);
                temp.BoardId = dr.GetInt32(1);
                temp.Writer = dr.GetString(2);
                temp.PostTitle = dr.GetString(3);
                temp.PostContext = dr.GetString(4);
                temp.PostDate = dr.GetDateTime(5);
                temp.PostModify = dr.GetInt32(6);
                temp.ReadCount = dr.GetInt32(7);
                temp.PostRecommand = dr.GetInt32(8);
                result.Add(temp);
            }

            dr.Close();
        } catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }

        return result;
    }

    public void CUDQry(string query)
    {
        try
        {
            MySqlCommand cmd = new MySqlCommand(query, dbinfo.GetConnection());
            cmd.ExecuteNonQuery();
        } catch (Exception ex)
        {
            Console.WriteLine($"Error:{ex.Message}");
        }
    }
}