using System;
using System.Collections.Generic;
using System.Text;

using CRM.Dto;

using SuperGMS.Protocol.RpcProtocol;
using SuperGMS.Rpc.Server;
using CRM.Model;
using System.Linq;

namespace CRM.Service
{
    public class ClientLogin : RpcBaseServer<ClientLoginArgs, ClientLoginResult>
    {
        protected override ClientLoginResult Process(ClientLoginArgs valueArgs, out StatusCode code)
        {
            if (string.IsNullOrWhiteSpace(valueArgs.LoginName))
            {
                code = new StatusCode(8000, "请输入账号");
                return null;
            }
            if (string.IsNullOrWhiteSpace(valueArgs.PassWord))
            {
                code = new StatusCode(8001, "请输入密码");
                return null;
            }
            var ctx = Context.GetDbContext<my_system_dataContext>();
            var rps = ctx.GetRepository<Userinfo>();
            var userInfo = rps.GetQueryableByQuery(x => x.Tel == valueArgs.LoginName && x.PassWord == valueArgs.PassWord).FirstOrDefault();
            if (userInfo == null)
            {
                code = new StatusCode(8002, "用户名或者密码错误");
                return null;
            }
            code = StatusCode.OK;
            return new ClientLoginResult { Token = Guid.NewGuid().ToString() };
        }

        protected override bool Check(ClientLoginArgs args, out StatusCode code)
        {
            return base.CheckLogin(args, out code);
        }
    }
}
