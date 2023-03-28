using System;
using Npgsql;
using System.Data.SqlClient;
using System.Data;

namespace SuperTelegram.Db.Ship
{
	public class DbRelation
	{
		public int Account;
		public string user;
		public string connString = "Host=localhost;Port=5432;Username=postgres;Password=123456;Database=super_telegram";
		public DbRelation(int account)
		{
			Account = account;

			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select username from telegram.information where account={0}", Account);
			var cmd = new NpgsqlCommand(sql, con);
			var read = cmd.ExecuteReader();
			read.Read();
			user ="telegram."+read[0].ToString();
			read.Close();
			con.Close();
		}

		public void AddFriend(int number)//添加好友(同步名称，图片)
        {
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("insert into {0} (friendaccount,blacklist,remark) values ({1},'{2}','{3}')", user,number,true,null);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			var rsql = string.Format("update {0} set realname = (select name from telegram.information where friendaccount=account) where friendaccount = {1}", user, number);
			var rcmd = new NpgsqlCommand(rsql, con);
			rcmd.ExecuteNonQuery();
			var usql = string.Format("update {0} set url = (select photo from telegram.information where friendaccount=account) where friendaccount = {1}", user, number);
			var ucmd = new NpgsqlCommand(usql, con);
			ucmd.ExecuteNonQuery();
			con.Close();
		}
		public void UpdateRemark(int number,string name)//添加备注
        {
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("update {0} set remark = '{1}' where friendaccount = {2}", user, name,number);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}
		public void UpdateWhere(int number,int where)//添加分组
        {
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("update {0} set block = {1} where friendaccount = {2}", user, where, number);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}

		public void DeleteFriend(int number)//删除好友
        {
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("delete from {0} where friendaccount={1}", user,number);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}


		public List<int> GetAllFriend()//获取全部好友列表
        {
			var member = new List<int>();
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select friendaccount from {0}", user);
			var cmd = new NpgsqlCommand(sql, con);
			var read = cmd.ExecuteReader();
			while (read.Read())
            {
				member.Add(Convert.ToInt32(read[0]));
            }
			return member;
		}

		public bool? GetFriendState(int number)//获取好友状态
        {
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select state from {0} where friendaccount={1}",user, number);
			var cmd = new NpgsqlCommand(sql, con);
			var read = cmd.ExecuteReader();
			if (read.Read())
			{
				try
				{
					return (bool)read[0];
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
		public int? GetBlock(int number)//获取好友分组
        {
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select block from {0} where friendaccount={1}", user, number);
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
		public string? GetRemark(int number)//获取好友备注
        {
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select remark from {0} where friendaccount={1}", user, number);
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

		public string? GetRealName(int number)//获取好友备注
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select realname from {0} where friendaccount={1}", user, number);
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

		public string? GetPhoto(int number)
        {
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select url from {0} where friendaccount={1}", user, number);
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


		public bool? GetBlackList(int number)
        {
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select blacklist from {0} where friendaccount={1}", user, number);
			var cmd = new NpgsqlCommand(sql, con);
			var read = cmd.ExecuteReader();
			if (read.Read())
			{
				try
				{
					return (bool)read[0];
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

		public void UpdateBlackList(int number)//修改是否是黑名单
        {
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select blacklist from {0} where friendaccount={1}", user, number);
			var cmd = new NpgsqlCommand(sql, con);
			var read = cmd.ExecuteReader();
			read.Read();
			if (read[0].ToString() == "False")
			{
				try
				{
					con.Close();
					con.Open();
					var Fsql = string.Format("update {0} set blacklist='{1}' where friendaccount={2}", user, true, number);
					var Fcmd = new NpgsqlCommand(Fsql, con);
					Fcmd.ExecuteNonQuery();
				}
				finally
				{
					con.Close();
				}
			}
			else
			{
				try
				{
					con.Close();
					con.Open();
					var Tsql = string.Format("update {0} set blacklist='{1}' where friendaccount={2}", user, false, number);
					var Tcmd = new NpgsqlCommand(Tsql, con);
					Tcmd.ExecuteNonQuery();
				}
				finally
				{
					con.Close();
				}
			}
		}

		public void SynchronousState(int number)//同步状态
        {
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("update {0} set state = (select realstate from telegram.information where friendaccount=account) where friendaccount = {1}", user, number);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}
	}

}
