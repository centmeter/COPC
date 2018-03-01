using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COPC.ContractModels
{
    /// <summary>
    /// 用户数据接口
    /// </summary>
    public interface IUserData
    {
        /// <summary>
        /// 合约Id集合
        /// </summary>
        string[] ContractIds { get; set; }
    }
}
