using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COPC.Models
{
    /// <summary>
    /// 合约数据
    /// </summary>
    public class ContractData : IContractData
    {
        /// <summary>
        /// 发起者Id
        /// </summary>
        public string[] InitiatorIds { get; set; }
        /// <summary>
        /// 参与者Id
        /// </summary>
        public string[] ActorIds { get; set; }
        /// <summary>
        /// 合约事件Id
        /// </summary>
        public string ContractEventId { get; set; }
        /// <summary>
        /// 合约筹码Id
        /// </summary>
        public string ContractChipId { get; set; }
        /// <summary>
        /// 克隆
        /// </summary>
        public IContractData Clone()
        {
            IContractData cloneContractData = new ContractData()
            {
                InitiatorIds = this.InitiatorIds,
                ActorIds = this.ActorIds,
                ContractEventId = this.ContractEventId,
                ContractChipId = this.ContractChipId
            };
            return cloneContractData;
        }
    }
}
