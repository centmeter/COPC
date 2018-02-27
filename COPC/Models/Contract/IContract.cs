namespace COPC.ContractModels
{
    /// <summary>
    /// 合约接口
    /// </summary>
    public interface IContract
    {
        /// <summary>
        /// 唯一标识Id
        /// </summary>
        string Id { get; set; }
        /// <summary>
        /// 合约数据
        /// </summary>
        IContractData ContractData { get; set; }
        /// <summary>
        /// 克隆
        /// </summary>
        IContract Clone();

    }
}
