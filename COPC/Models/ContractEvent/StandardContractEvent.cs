using System;

namespace COPC.Models
{
    /// <summary>
    /// 标准合约事件
    /// </summary>
    public class StandardContractEvent : IContractEvent
    {
        /// <summary>
        /// 唯一标识Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public IContractEventData ContractEventData { get; set; }
        /// <summary>
        /// 克隆
        /// </summary>
        public IContractEvent Clone(IContractEvent contractEvent)
        {
            IContractEvent returnContractEvent = null;
            if (contractEvent is StandardContractEvent)
            {
                returnContractEvent = new StandardContractEvent()
                {
                    Id = Guid.NewGuid().ToString(),
                    ContractEventData = contractEvent.ContractEventData
                };

            }
            return returnContractEvent;
        }
    }
}
