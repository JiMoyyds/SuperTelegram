using System;
using SuperTelegram.Db.Ship;

namespace SuperTelegram.Op.Ship
{
	public class OpShip
	{
		public struct message
		{
			public int number;
			public string remark;
			public string photo;
		};


        public int Account;

		public OpShip(int account)
		{
			Account = account;
		}

		public void AddFriend(int friend)//添加好友
        {
			DbRelation mdb = new DbRelation(Account);
			DbRelation fdb = new DbRelation(friend);
			mdb.AddFriend(friend);
			fdb.AddFriend(Account);
        }
		public void ReviseRemark(int number,string name)//修改备注
        {
			DbRelation db = new DbRelation(Account);
			db.UpdateRemark(number,name);
        }
		public void SetUpWhere()//设定在那个分组
        {

        }

		public bool ReviseState()//修改状态
        {
			return false;
        }

		public string GetOneName(int number)
        {
			DbRelation db = new DbRelation(Account);
			if (db.GetRemark(number) == "null")
            {
				return db.GetRealName(number);
            }
			else
            {
				return db.GetRemark(number);
            }
        }

		public string GetRealName(int number)
        {
			DbRelation db = new DbRelation(Account);
			return db.GetRealName(number);
        }

		public List<message> GetAllFriend()//获取好友列表
        {
			DbRelation db = new DbRelation(Account);
			var number = db.GetAllFriend();
			List<message> list = new List<message>();
			for (int i = 0; i < number.Count; i++)
            {
				message people = new message();
				people.number = number[i];
				people.remark = GetOneName(number[i]);
				people.photo=db.GetPhoto(people.number);

				list.Add(people);
            }
			return list;
        }
	}

}
