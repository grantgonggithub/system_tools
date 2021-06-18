/*----------------------------------------------------------------
Copyright (C) 2021 顺兴文旅版权所有

项目名称：CRM.Dto
文件名：  ClientLoginArgs
创建者：  grant(巩建春)
CLR版本： 4.0.30319.42000
时间：    2021/6/15 星期二 15:35:00

功能描述：
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Dto
{
    /// <summary>
    /// ClientLoginArgs
    /// </summary>
    public class ClientLoginArgs
    {
        public string LoginName { get; set; }

        public string PassWord { get; set; }
    }

    public class ClientLoginResult
    { 
        public string Token { get; set; }
    }
}
