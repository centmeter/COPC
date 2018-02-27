namespace COPC.Models
{
    /// <summary>
    /// 合约筹码数据接口
    /// </summary>
    public interface IContractChipData
    {
        /// <summary>
        /// 描述
        /// </summary>
        string Description { get; set; }
        /// <summary>
        /// 克隆
        /// </summary>
        IContractChipData Clone();
    }
}
