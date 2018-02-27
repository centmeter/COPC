using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COPC.Models
{
    /// <summary>
    /// 合约数据接口
    /// </summary>
    public interface IContractData
    {
        /// <summary>
        /// 发起者Id
        /// </summary>
        string[] InitiatorIds { get; set; }
        /// <summary>
        /// 参与者Id
        /// </summary>
        string[] ActorIds { get; set; }
        /// <summary>
        /// 合约事件Id
        /// </summary>
        string ContractEventId { get; set; }
        /// <summary>
        /// 合约筹码Id
        /// </summary>
        string ContractChipId { get; set; }
        /// <summary>
        /// 克隆
        /// </summary>
        IContractData Clone();

    }
}
