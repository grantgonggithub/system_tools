using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CRM.Dto;
using CRM.Model;

using SuperGMS.Protocol.RpcProtocol;
using SuperGMS.Rpc;
using SuperGMS.Rpc.Server;

namespace CRM.Service
{
    public class SendVerificationCode : RpcBaseServer<SendVerificationCodeArgs, Nullables>
    {
        protected override Nullables Process(SendVerificationCodeArgs valueArgs, out StatusCode code)
        {
            if (string.IsNullOrWhiteSpace(valueArgs.Tel))
            {
                code = new StatusCode(9001, "请输入手机号");
                return null;
            }
            var ctx = Context.GetDbContext<my_system_dataContext>();
            var rps = ctx.GetRepository<Verificationcode>();
            var vCode = rps.GetQueryableByQuery(x => x.Tel == valueArgs.Tel).OrderByDescending(x=>x.CreatedDate).FirstOrDefault();
            if (vCode != null)
            {
                if (vCode.CreatedDate.AddMinutes(1) > DateTime.Now)
                {
                    code = new StatusCode(9002, "验证码在1分钟内有效，请不要重复发送");
                    return Nullables.NullValue;
                }
            }
            if (valueArgs.CodeType == CodeType.Register)
            {
                var rpsUserInfo = ctx.GetRepository<Userinfo>();

            }
            var codeNum =getCode();
            // send msg

            code = StatusCode.OK;
            return Nullables.NullValue;
        }

        private string[] orgCode = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private string getCode()
        {
            string[] codeArr = new string[6];
            for(int i=0;i<codeArr.Length;i++)
            {
                Random random = new Random((int)DateTime.Now.Millisecond);
                codeArr[i] = orgCode[random.Next(0, orgCode.Length - 1)];
            }
            return string.Join("",codeArr);
        }

        protected override bool Check(SendVerificationCodeArgs args, out StatusCode code)
        {
            return base.CheckLogin(args, out code);
        }
    }
}
