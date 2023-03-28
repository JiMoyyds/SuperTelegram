using System;
using SuperTelegram.Db.Group;

namespace SuperTelegram.Op.Group
{
	public class OpGroup
	{
		public int GroupNumber;
		public OpGroup(int number)
		{
			GroupNumber = number;
		}

		public OpGroup()
        {

        }

		public void CreateGroup(int member,string groupname)//创建群组，写入名称
        {
			DbGroup db = new DbGroup(GroupNumber);
			db.CreateGroup(member,groupname);
        }
		public void DeleGroup()//解散群组
        {
			DbGroup db = new DbGroup(GroupNumber);
			db.DeleteGroup();
        }
		public void JoinGroup(int newmember)//加入群组
        {
			DbGroup db = new DbGroup(GroupNumber);
			db.AddMember(newmember);
        }
		public void ExitGroup()//退出群组
        {

        }
		public void ReviseGroupName(string name)//修改群组名称,只有群主才可以修改
        {
			DbGroup db = new DbGroup(GroupNumber);
			db.UpdateGroupName(name);
		}
		public void SetUpDetect()//设置是否可以被查找
        {

        }

		public List<int> FindWhereGroup(int member)//检查该账号参加哪些群组
        {
			DbGroup db = new DbGroup();
			return db.FindAMember(member);
		}


		public int GetCreted()
        {
			DbGroup db = new DbGroup(GroupNumber);
			return (int)db.GetCreated()!;
		}

		public string GetName()
        {
			DbGroup db = new DbGroup(GroupNumber);
			return db.GetGroupName();
        }

		public string GetPhoto()
        {
			DbGroup db = new DbGroup(GroupNumber);
			return db.GetPhoto()!;
		}

		public void RevisePhoto(string url)
        {
			DbGroup db = new DbGroup(GroupNumber);
			db.UpdatePhoto(url);
		}

		public void ReviseMark(int mark)
        {
			DbGroup db = new DbGroup(GroupNumber);
			db.UpdateMark(mark);
		}
	}

}
