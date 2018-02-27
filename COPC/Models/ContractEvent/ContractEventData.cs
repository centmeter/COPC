namespace COPC.Models
{
    /// <summary>
    /// 合约事件数据
    /// </summary>
    public class ContractEventData : IContractEventData
    {
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 克隆
        /// </summary>
        public IContractEventData Clone()
        {
            IContractEventData cloneContractEventData = new ContractEventData()
            {
                Description = this.Description
            };
            return cloneContractEventData;
        }
    }
}
