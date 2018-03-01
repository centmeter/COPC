using System;
using COPC.ContractModels;
using Newtonsoft.Json;
namespace COPC.ContractFactories
{
    public class ContractFactory
    {
        #region Singleton
        private static ContractFactory _instance;
        private static object _locker = new object();
        public static ContractFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new ContractFactory();
                        }
                    }
                }
                return _instance;
            }
        }
        private ContractFactory()
        {

        }
        #endregion
        /// <summary>
        /// 创建合约
        /// </summary>
        public IContract CreateContract<T>(IContractData contractData) where T : IContract
        {
            IContract contract = Activator.CreateInstance<T>();
            contract.Id = Guid.NewGuid().ToString();
            contract.ContractData = contractData;
            return contract;
        }
        /// <summary>
        /// 解析合约
        /// </summary>
        public IContract ParseContract<T1, T2>(string id, string jsonData) where T1 : IContract where T2 : IContractData
        {
            IContractData contractData = JsonConvert.DeserializeObject<T2>(jsonData);
            IContract contract = null;
            if (contractData != null && !string.IsNullOrEmpty(id))
            {
                contract = Activator.CreateInstance<T1>();
                contract.Id = id;
                contract.ContractData = contractData;
            }
            return contract;
        }

        /// <summary>
        /// 序列化合约数据
        /// </summary>
        public string SerializeContractData(IContract contract)
        {
            string jsonData = JsonConvert.SerializeObject(contract.ContractData);
            return jsonData;
        }
    }
}
