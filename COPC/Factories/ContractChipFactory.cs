using COPC.Models;
using System;
using Newtonsoft.Json;
namespace COPC.Factories
{
    /// <summary>
    /// 合约筹码工厂
    /// </summary>
    public class ContractChipFactory
    {
        #region Singleton
        private static ContractChipFactory _instance;
        public static object _locker = new object();
        public static ContractChipFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new ContractChipFactory();
                        }
                    }
                }
                return _instance;
            }
        }
        private ContractChipFactory()
        {

        }
        #endregion
        /// <summary>
        /// 创建合约筹码
        /// </summary>
        public IContractChip CreateContractChip<T>(IContractChipData contractChipData) where T : IContractChip
        {
            IContractChip contractChip = Activator.CreateInstance<T>();
            contractChip.Id = Guid.NewGuid().ToString();
            contractChip.ContractChipData = contractChipData;
            return contractChip;
        }
        /// <summary>
        /// 解析合约筹码
        /// </summary>
        public IContractChip ParseContractChip<T1,T2>(string id,string jsonData) where T1:IContractChip where T2:IContractChipData
        {
            IContractChipData contractChipData = JsonConvert.DeserializeObject<T2>(jsonData);
            IContractChip contractChip = null;
            if(contractChipData!=null&&!string.IsNullOrEmpty(id))
            {
                contractChip = Activator.CreateInstance<T1>();
                contractChip.Id = id;
                contractChip.ContractChipData = contractChipData;
            }
            return contractChip;
        }
    }
}
