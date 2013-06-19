using System;

namespace TemplateMethod
{
    public sealed class UserInfoDataAccess : DataAccessBase<UserInfo>
    {
        protected override UserInfo[] QueryData()
        {
            Console.WriteLine("正在查询数据....");
            return new[]
            {
                new UserInfo {Id = 1, Name = "zhangweiwen"},
                new UserInfo {Id = 2, Name = "Raymond"}
            };
        }

        protected override void DisplayData(UserInfo[] datas)
        {
            Console.WriteLine("正在显示数据....");
            if (datas != null)
            {
                foreach (var userInfo in datas)
                {
                    Console.WriteLine("Name=> " + userInfo.Name);
                }
            }
            else
            {
                Console.WriteLine("没有数据!");
            }
        }
    }
}