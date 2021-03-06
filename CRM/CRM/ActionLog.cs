/*----------------------------------------------------------------
Copyright (C) 2014 宏图会员管理系统（Grant 巩建春）

项目名称： 宏图会员管理系统
创建者：   grant (巩建春 emaill : nnn987@126.com ; QQ:406333743;Tel:+86 15619212255)
CLR版本：  4.0.30319.42000
时间：     2014/8/28 18:16:22

功能描述：本软件为本人业余时间所写，其所有源码都可以进行免费的学习交流，切勿用于商业用途

----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tools;


namespace CRM
{
   public class ActionLog
    {
       public static bool Add(ActionName actName, string actContent)
       {
           try
           {
               string sql = "Insert into ActionLog(ID,ActionName,ActionTime,AdminId,ActionContent)values(@ID,@ActionName,@ActionTime,@AdminId,@ActionContent)";
               if (DBHelper.ExecuteNonQuery(sql, new string[] { "@ID", "@ActionName", "@ActionTime", "@AdminId", "@ActionContent" },
                   new object[] { Guid.NewGuid().ToString("N"), actName.ToString(), DateTime.Now, CommStatic.MyCache.Login.Id, actContent }) > 0)
                   return true;
               return false;
           }
           catch (Exception ex)
           {
               TracingHelper.Error(ex, typeof(ActionLog));
               return false;
           }
       }
    }
}
