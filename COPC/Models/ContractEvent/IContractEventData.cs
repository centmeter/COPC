namespace COPC.ContractModels
{
    /// <summary>
    /// 合约事件数据接口
    /// </summary>
    public interface IContractEventData
    {
        /// <summary>
        /// 描述
        /// </summary>
        string Description { get; set; }
        /// <summary>
        /// 克隆
        /// </summary>
        IContractEventData Clone();
    }
}
