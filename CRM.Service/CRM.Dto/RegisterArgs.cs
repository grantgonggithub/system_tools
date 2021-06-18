/*----------------------------------------------------------------
Copyright (C) 2021 顺兴文旅版权所有

项目名称：CRM.Dto
文件名：  RegisterArgs
创建者：  grant(巩建春)
CLR版本： 4.0.30319.42000
时间：    2021/6/15 星期二 15:09:04

功能描述：
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Dto
{
    /// <summary>
    /// RegisterArgs
    /// </summary>
    public class RegisterArgs
    {
        public string Tel { get; set; }
        public string PassWord { get; set; }
        public string RepetPassWord { get; set; }
        public string VerificationCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Ip { get; set; }
        public string DeviceInfo { get; set; }
        public string DeviceNo { get; set; }
    }
}
