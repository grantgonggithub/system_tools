/*----------------------------------------------------------------
Copyright (C) 2021 顺兴文旅版权所有

项目名称：CRM.Dto
文件名：  SendVerificationCodeArgs
创建者：  grant(巩建春)
CLR版本： 4.0.30319.42000
时间：    2021/6/15 星期二 15:50:47

功能描述：
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Dto
{
    /// <summary>
    /// SendVerificationCodeArgs
    /// </summary>
    public class SendVerificationCodeArgs
    {
        public string Tel { get; set; }

        public CodeType CodeType { get; set; }
    }

    public enum CodeType
    {
        Register = 1,
        Forget = 2,
    }
}
