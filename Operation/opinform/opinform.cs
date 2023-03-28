using System;
using SuperTelegram.Db.Information;
using System.Security.Cryptography;
using System.Text;

namespace SuperTelegram.Op.Information
{
	public class OpInformation
	{
		public struct Message
		{
			int account;
			string password;
			string email;
			string phone;
			string name;
			string introduction;
			bool realstate;
			string pipename;
			string photo;
			string groupname;
		};

		public struct message_Acc_Name_Photo
        {
			public int acc;
			public string name;
			public string url;
        };

        public int Account;

		public OpInformation(int account)
		{
			Account = account;
		}

		public string HashPassWord(string pass)//哈希值转换
        {
			byte[] bytes = Encoding.UTF8.GetBytes(pass);
			byte[] hash = SHA256.Create().ComputeHash(bytes);

			StringBuilder builder = new StringBuilder();
			for (int i = 0; i < hash.Length; i++)
			{
				builder.Append(hash[i].ToString("x2"));
			}
			return builder.ToString();
		}

		public void CreatMessage(string pass,string email,int phone,string name)//创建新用户
        {
			DbSever Db = new DbSever(Account);
			var hash = HashPassWord(pass);
			Db.AddAccount(hash, email, phone,name);
			Db.UpdateIntroduce("请写一个介绍");
			Db.UpdatePhoto(@"F:\SuperTelegram\Photo\white.jpg");
        }

		public bool ComparePassWord(string pass)//密码验证
        {
			DbSever Db = new DbSever(Account);
			var now = HashPassWord(pass);
			var old = Db.GetPassWord();
			if (old != null)
            {
				if (now == old)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
            {
				return false;
            }
        }

		public void RevisePassWord(string pass)
        {
			DbSever db = new DbSever(Account);
			var password = HashPassWord(pass);
			db.UpdatePassWord(password);
        }

		public bool CompareMessage(int ph,string em)//判断邮箱和手机号是不是对
		{
			DbSever db = new DbSever(Account);
			if (db.GetEmail() == em && db.GetPhone() == ph)
            {
				return true;
            }
			else
            {
				return false;
            }
		}

		public int GetPipename()
        {
			DbSever db = new DbSever(Account);
			return (int)db.GetPipeName()!;
        }
		public string GetName()
        {
			DbSever db = new DbSever(Account);
			var name = db.GetName();
			if (name == null)
            {
				return null;
            }
			else
            {
				return name;
            }
        }

		public string GetPhoto()
        {
			DbSever db = new DbSever(Account);
			return db.GetPhoto()!;
        }

		public string GetIntroduce()
        {
			DbSever db = new DbSever(Account);
			return db.GetIntroduce()!;
        }

		public int GetPhone()
        {
			DbSever db = new DbSever(Account);
			return (int)db.GetPhone()!;
        }

		public int GetMark()
		{
			DbSever db = new DbSever(Account);
			return (int)db.GetMark()!;
		}

		public string GetEmail()
        {
			DbSever db = new DbSever(Account);
			return db.GetEmail()!;
        }

		public void RevisePhoto(string file)//修改头像
		{
			DbSever db = new DbSever(Account);
			db.UpdatePhoto(file);
		}

		public void SetUpRealState()//建立状态
		{
			DbSever db= new DbSever(Account);
			db.UpdateState();
		}

		public void ReviseMessage(string name,string introduce,int phone,string email)
        {
			DbSever db = new DbSever(Account);
			db.UpdateIntroduce(introduce);
			db.UpdateName(name);
			db.UpdatePhone(phone);
			db.UpdateEmail(email);
        }

		public message_Acc_Name_Photo? GetSomeMessage(int findinform)
        {
			DbSever db = new DbSever(Account);
			if (db.FindAccount(findinform) != null)
            {
				var find = db.FindAccount(findinform);
				DbSever ndb = new DbSever((int)find);
				message_Acc_Name_Photo findmessage = new message_Acc_Name_Photo();
				findmessage.acc = (int)find;
				findmessage.name = ndb.GetName();
				findmessage.url = ndb.GetPhoto();
				return findmessage;
			}
			else
            {
				return null;
            }
        }

		public List<Message> GetAllMessage()//获取该用户所有信息
        {
			var message = new List<Message>();
			return message;
        }
	}

}
