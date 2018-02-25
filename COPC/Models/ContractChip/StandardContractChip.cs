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
        /// <summary>
        /// 克隆
        /// </summary>
        public IContractChip Clone(IContractChip contractChip)
        {
            IContractChip returnContractChip = null;
            if (contractChip is StandardContractChip)
            {
                returnContractChip = new StandardContractChip()
                {
                    Id = Guid.NewGuid().ToString(),
                    ContractChipData = contractChip.ContractChipData
                };

            }
            return returnContractChip;
        }
    }
}
