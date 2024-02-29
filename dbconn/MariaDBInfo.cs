using MySql.Data.MySqlClient;

class MariaDBInfo
{
    private string ip;
    private int port;
    private string uid;
    private string pwd;
    private string dbname;
    private MySqlConnection conn;

    public MariaDBInfo(string ip, int port, string uid, string pwd, string dbname)
    {
        this.ip = ip;
        this.port = port;
        this.uid = uid;
        this.pwd = pwd;
        this.dbname = dbname;
        this.conn = null;
    }

    public void initDB()
    {
        string connectString
            = $"Server={ip};Port={port};Database={dbname};Uid={uid};Pwd={pwd};CharSet=utf8;";
        try
        {
            conn = new MySqlConnection(connectString);
            conn.Open();
        } catch (Exception ex) {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public MySqlConnection GetConnection()
    {
        if (conn == null)
            initDB();
        return conn;
    }
}