using System;
using Npgsql;
using System.Data.SqlClient;
using System.Data;

namespace SuperTelegram.Db.Information
{
	public class DbSever
	{
		public int Account;
		public string PassWord=null;
		public string Email=null;
		public int phone;
		public string Introduce=null;
		public string Name;
		public bool State = false;
		public int PipeName;
		public string Photo = null;

		public string connString = "Host=localhost;Port=5432;Username=postgres;Password=123456;Database=super_telegram";

		//有待商确，是否需要这个元素
		public int GroupName;

		public DbSever(int account)
		{
			Account = account;
		}

		//创建用户，需要添加一个创建表的功能
		//是否有必要，函数类型是否可以更改为bool，以完成操作后，返回一个可视的结果
		public void AddAccount(string pass,string em, int ph,string name)//添加用户（含账户，密码，电话，邮箱）
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("insert into telegram.information (account,password,phone,email,name) values ({0},'{1}',{2},'{3}','{4}')", Account, pass, ph, em,name);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}
		public void UpdateName(string name)//添加用户名称以及修改
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("update telegram.information set name='{0}' where account={1}", name,Account);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}
		public void UpdateIntroduce(string introduce)//添加用户简介
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("update telegram.information set introduce='{0}' where account={1}", introduce, Account);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}

		public void UpdatePhone(int phone)//修改手机号
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("update telegram.information set phone='{0}' where account={1}", phone, Account);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}

		public void UpdateEmail(string email)//修改邮箱
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("update telegram.information set email='{0}' where account={1}", email, Account);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}

		public void UpdatePhoto(string Url)//添加用户照片URL
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("update telegram.information set photo='{0}' where account={1}", Url, Account);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}
		public void UpdatePipeName(string pipe)//加入通信管道名称
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("update telegram.information set pipe='{0}' where account={1}", pipe, Account);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}
		public void UpdateGroupName(int group)//属于哪个群组
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("update telegram.information set groupname='{0}' where account={1}", group, Account);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}
		public void UpdatePassWord(string pass)//修改密码
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("update telegram.information set password='{0}' where account={1}", pass, Account);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}
		public void UpdateState()//修改状态
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select realstate from telegram.information where account={0}",Account);
			var cmd = new NpgsqlCommand(sql, con);
			var read = cmd.ExecuteReader();
			read.Read();
			if (read[0].ToString()== "False")
            {
				con.Close();
				con.Open();
				var Fsql = string.Format("update telegram.information set realstate='{0}' where account={1}", true, Account);
				var Fcmd = new NpgsqlCommand(Fsql, con);
				Fcmd.ExecuteNonQuery();
			}
			else
            {
				con.Close();
				con.Open();
				var Tsql = string.Format("update telegram.information set realstate='{0}' where account={1}", false, Account);
				var Tcmd = new NpgsqlCommand(Tsql, con);
				Tcmd.ExecuteNonQuery();
			}
			con.Close();
		}
		public void DeleteAccount()
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("delete from telegram.information where account={0}", Account);
			var cmd = new NpgsqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}

		public int? GetAccountByEmail(string email)//找好友时，用邮件找
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select account from telegram.information where email='{0}'", email);
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

		public int? FindAccount(int number)//加好友时，用手机号找
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select account from telegram.information where account={0} or phone={0}", number);
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
		public bool? GetState()//获取用户状态
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select realstate from telegram.information where account='{0}'", Account);
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
		public string? GetEmail()
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select email from telegram.information where account='{0}'", Account);
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
		public int? GetPhone()
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select phone from telegram.information where account='{0}'", Account);
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

		public int? GetMark()
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select pipename from telegram.information where account='{0}'", Account);
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

		public string? GetIntroduce()
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select introduce from telegram.information where account='{0}'", Account);
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
		public int? GetPipeName()
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select pipename from telegram.information where account='{0}'", Account);
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
		public string? GetPhoto()
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select photo from telegram.information where account='{0}'", Account);
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
		public string? GetName()
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select name from telegram.information where account='{0}'", Account);
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
		public string? GetPassWord()
		{
			var con = new NpgsqlConnection(connString);
			con.Open();
			var sql = string.Format("select password from telegram.information where account='{0}'", Account);
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
