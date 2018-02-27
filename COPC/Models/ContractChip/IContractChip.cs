namespace COPC.ContractModels
{
    /// <summary>
    /// 合约筹码接口
    /// </summary>
    public interface IContractChip
    {
        /// <summary>
        /// 唯一标识Id
        /// </summary>
        string Id { get; set; }
        /// <summary>
        /// 合约筹码数据
        /// </summary>
        IContractChipData ContractChipData { get; set; }
        /// <summary>
        /// 克隆
        /// </summary>
        IContractChip Clone();
    }
}
