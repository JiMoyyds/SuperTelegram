using Npgsql;
namespace SuperTelegram.Db.SAR
{
    public class SAR
    {
        public int Mark;
        public string connString = "Host=localhost;Port=5432;Username=postgres;Password=123456;Database=super_telegram";

        public SAR(int mark)
        {
            Mark = mark;
        }
       
        public bool IsCreate()
        {
            var con = new NpgsqlConnection(connString);
            con.Open();
            var sql = string.Format("select mark from telegram.fchat where mark={0}", Mark);
            var cmd = new NpgsqlCommand(sql, con);
            var read = cmd.ExecuteReader();
            if (read.Read())
            {
                try
                {
                    return false;
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                return true;
            }
        }

        public void Create()
        {
            var con = new NpgsqlConnection(connString);
            con.Open();
            var sql = string.Format("insert into telegram.fchat (mark) values ({0})", Mark);
            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Send(string str)
        {
            var con = new NpgsqlConnection(connString);
            con.Open();
            var sql = string.Format("update telegram.fchat set content='{0}' where mark={1}", str, Mark);
            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void SendPhoto(string url)
        {
            var con = new NpgsqlConnection(connString);
            con.Open();
            var sql = string.Format("update telegram.fchat set url='{0}' where mark={1}", url, Mark);
            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void SendFile(string file)
        {
            var con = new NpgsqlConnection(connString);
            con.Open();
            var sql = string.Format("update telegram.fchat set file='{0}' where mark={1}", file, Mark);
            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string Receive()
        {
            var con = new NpgsqlConnection(connString);
            con.Open();
            var sql = string.Format("select content from telegram.fchat where mark={0}", Mark);
            var cmd = new NpgsqlCommand(sql, con);
            var read = cmd.ExecuteReader();
            if (read.Read())
            {
                try
                {
                    return read[0].ToString();
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                return "";
            }
        }

        public string ReceivePhoto()
        {
            var con = new NpgsqlConnection(connString);
            con.Open();
            var sql = string.Format("select url from telegram.fchat where mark={0}", Mark);
            var cmd = new NpgsqlCommand(sql, con);
            var read = cmd.ExecuteReader();
            if (read.Read())
            {
                try
                {
                    return read[0].ToString();
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                return null;
            }
        }

        public string ReceiveFile()
        {
            var con = new NpgsqlConnection(connString);
            con.Open();
            var sql = string.Format("select file from telegram.fchat where mark={0}", Mark);
            var cmd = new NpgsqlCommand(sql, con);
            var read = cmd.ExecuteReader();
            if (read.Read())
            {
                try
                {
                    return read[0].ToString();
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                return null;
            }
        }
    }
}