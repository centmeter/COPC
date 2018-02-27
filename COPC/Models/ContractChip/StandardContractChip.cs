using System;

namespace COPC.Models
{
    /// <summary>
    /// 标准合约筹码
    /// </summary>
    public class StandardContractChip : IContractChip
    {
        /// <summary>
        /// 唯一标识Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public IContractChipData ContractChipData { get; set; }
        internal StandardContractChip()
        {

        }
        /// <summary>
        /// 克隆
        /// </summary>
        public IContractChip Clone()
        {
            IContractChip cloneContractChip = new StandardContractChip()
            {
                Id = Guid.NewGuid().ToString(),
                ContractChipData = this.ContractChipData.Clone()
            };
            return cloneContractChip;
        }
    }
}
