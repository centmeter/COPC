using COPC.ContractFactories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string ContractJsonData
        {
            get { return JsonConvert.SerializeObject(ContractData); }
            set { ContractData = JsonConvert.DeserializeObject<IContractData>(value); }
        }
        [NotMapped]
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
