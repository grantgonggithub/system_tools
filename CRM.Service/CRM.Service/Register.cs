using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

using CRM.Dto;
using CRM.Model;

using SuperGMS.Protocol.RpcProtocol;
using SuperGMS.Rpc;
using SuperGMS.Rpc.Server;

namespace CRM.Service
{
    public class Register : RpcBaseServer<RegisterArgs, Nullables>
    {
        protected override Nullables Process(RegisterArgs valueArgs, out StatusCode code)
        {
            code = checkModel(valueArgs);
            if (!code.IsSuccess)
                return Nullables.NullValue;
            var ctx = Context.GetDbContext<my_system_dataContext>();
            var rps = ctx.GetRepository<Verificationcode>();
            var rpsUserInfo = ctx.GetRepository<Userinfo>();
            var user = rpsUserInfo.GetQueryableByQuery(x => x.Tel == valueArgs.Tel);
            if (user?.Any()??false)
            {
                code = new StatusCode(9011, "当前手机号已经注册");
                return Nullables.NullValue;
            }
            var vCode = rps.GetQueryableByQuery(x => x.Tel == valueArgs.Tel && x.VerificationCode1 == valueArgs.VerificationCode).FirstOrDefault();
            if (vCode == null)
            {
                code = new StatusCode(9010, "验证码错误");
                return Nullables.NullValue;
            }
            valueArgs.DeviceNo = MD5(valueArgs.DeviceInfo);
            var model = new Userinfo
            {
                Ip = valueArgs.Ip,
                DeviceInfo = valueArgs.DeviceInfo,
                DeviceNo = valueArgs.DeviceNo,
                PassWord = valueArgs.PassWord,
                Tel = valueArgs.Tel,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
            rpsUserInfo.Insert(model);
            code = StatusCode.OK;
            return Nullables.NullValue;
        }

        private StatusCode checkModel(RegisterArgs args)
        {
            if (string.IsNullOrWhiteSpace(args.Tel))
            {
                return new StatusCode(9005,"请输入手机号");
            }
            if (string.IsNullOrWhiteSpace(args.VerificationCode))
            {
                return new StatusCode(9006, "请输入验证码");
            }
            if (string.IsNullOrWhiteSpace(args.PassWord))
            {
                return new StatusCode(9007, "请输入密码");
            }
            if (args.PassWord != args.RepetPassWord)
            {
                return new StatusCode(9008, "两次输入的密码不一致");
            }
            if (string.IsNullOrWhiteSpace(args.DeviceInfo))
            {
                return new StatusCode(9009, "参数错误");
            }
            return StatusCode.OK;
        }

        /// <summary>
        /// MD5函数
        /// </summary>
        /// <param name="str">原始字符串</param>
        /// <returns>MD5结果</returns>
        public string MD5(string str)
        {
            byte[] b = Encoding.Default.GetBytes(str);
            b = new MD5CryptoServiceProvider().ComputeHash(b);
            string ret = "";
            for (int i = 0; i < b.Length; i++)
                ret += b[i].ToString("x").PadLeft(2, '0');
            return ret;
        }

        protected override bool Check(RegisterArgs args, out StatusCode code)
        {
            return base.CheckLogin(args, out code);
        }
    }
}
