using Npgsql;
using System;
using DbManaged;
using fsharper;

namespace SuperTelegram.Db.Group
{
	public class DbGroup
	{
		public int GroupNumber;
		public int a, b, c;
		public string GroupName;
		public bool Detect;

		public string connString = "Host=localhost;Port=5432;Username=postgres;Password=123456;Database=super_telegram";

		public DbGroup(int number)
		{
			GroupNumber = number;
		}

		public DbGroup()
        {

        }

		public void CreateGroup(int created, string name)//创建群组
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var url = @"F:\SuperTelegram\Photo\group.jpg";
			var sql = string.Format("insert into telegram.group (groupnumber,a,groupname,groupphoto) values ({0},{1},'{2}','{3}')", GroupNumber, created, name,url);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}
		public void DeleteGroup()//删除群组
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("delete from telegram.group where groupnumber={0}", GroupNumber);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}

		public void UpdateGroupName(string name)//修改群组名称
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("update telegram.group set groupname='{0}' where groupnumber={1}", name, GroupNumber);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}

		public void UpdatePhoto(string url)
        {
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("update telegram.group set groupphoto='{0}' where groupnumber={1}", url, GroupNumber);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}

		public void UpdateMark(int mark)//修改群组名称
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("update telegram.group set mark={0} where groupnumber={1}", mark, GroupNumber);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}

		public void AddMember(int member)//添加成员
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("UPDATE telegram.group SET b = CASE WHEN b IS NULL THEN {0} ELSE b END, c = CASE WHEN b IS NOT NULL THEN {0} ELSE c END where groupnumber={1}", member, GroupNumber);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}


		public int? GetCreated()//获取群主账号
        {
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select a from telegram.group where groupnumber={0}", GroupNumber);
			var cmd = new NpgsqlCommand(sql, con);
			var read = cmd.ExecuteReader();
			if (read.Read())
			{
				try
				{
					return Convert.ToInt32(read[0]);
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

		public string? GetPhoto()//获取群头像
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select groupphoto from telegram.group where groupnumber={0}", GroupNumber);
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

		public string? GetGroupName()//获取群头像
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select groupname from telegram.group where groupnumber={0}", GroupNumber);
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

		public List<int>? GetAllMember()
        {
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select a,b,c from telegram.group where groupnumber={0}", GroupNumber);
			var cmd = new NpgsqlCommand(sql, con);
			var read = cmd.ExecuteReader();
			read.Read();
			List<int> get()
            {
                var list = new List<int>();
				for(int i = 0; i < 3; i++)
                {
					if (read[i] != DBNull.Value)
						list.Add((int)read[i]);
				}
                return list.Count == 0 ? null : list;
            }

            var r = get();
            con.Close();
			return r;
		}

		public List<int> FindAMember(int people)
        {
			var member = new List<int>();
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select groupnumber from telegram.group where a={0} or b={0} or c={0}",people);
			var cmd = new NpgsqlCommand(sql, con);
			var read = cmd.ExecuteReader();
			while (read.Read())
			{
				member.Add(Convert.ToInt32(read[0]));
			}
			return member;
		}
	}

}
