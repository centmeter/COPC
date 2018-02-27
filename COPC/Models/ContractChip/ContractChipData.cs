namespace COPC.Models
{
    /// <summary>
    /// 合约筹码数据
    /// </summary>
    public class ContractChipData : IContractChipData
    {
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 克隆
        /// </summary>
        public IContractChipData Clone()
        {
            IContractChipData cloneContractChipData = new ContractChipData()
            {
                Description = this.Description
            };

            return cloneContractChipData;
        }
    }
}
