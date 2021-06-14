using SuperGMS.Rpc.Server;

namespace SXCRM.Service
{
    /// <summary>
    /// 引用程序初始化入口
    /// <see cref="AppInitlize" langword="" />
    /// </summary>
    [InitlizeMethod]
    public class AppInitlize
    {
        [InitlizeMethod]
        public static void Start()
        {
            // 初始化AutoMapper
            AutoMapperRegister.Initlize();
        }
    }
}