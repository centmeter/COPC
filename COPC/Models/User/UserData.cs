using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COPC.ContractModels
{
    /// <summary>
    /// 用户数据
    /// </summary>
    public class UserData : IUserData
    {
        /// <summary>
        /// 合约Id集合
        /// </summary>
        public string[] ContractIds { get; set; }
    }
}
