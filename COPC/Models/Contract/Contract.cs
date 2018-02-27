using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COPC.ContractModels
{
    /// <summary>
    /// 合约
    /// </summary>
    public class Contract : IContract
    {
        /// <summary>
        /// 唯一标识Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 合约数据
        /// </summary>
        public IContractData ContractData { get; set; }
        /// <summary>
        /// 克隆
        /// </summary>
        public IContract Clone()
        {
            IContract cloneContract = new Contract()
            {
                Id = this.Id,
                ContractData = this.ContractData.Clone()
            };
            return cloneContract;
        }
    }
}
