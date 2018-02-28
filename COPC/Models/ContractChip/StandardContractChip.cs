using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace COPC.ContractModels
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
        public string ContractChipJsonData
        {
            get { return JsonConvert.SerializeObject(ContractChipData); }
            set { ContractChipData = JsonConvert.DeserializeObject<IContractChipData>(value); }
        }
        [NotMapped]
        public IContractChipData ContractChipData { get; set; }
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
