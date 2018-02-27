using System;
using COPC.ContractModels;
using Newtonsoft.Json;
namespace COPC.ContractFactories
{
    /// <summary>
    /// 合约事件工厂
    /// </summary>
    public class ContractEventFactory
    {
        #region Singleton
        private static ContractEventFactory _instance;
        private static object _locker = new object();
        public static ContractEventFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new ContractEventFactory();
                        }
                    }
                }
                return _instance;
            }
        }
        private ContractEventFactory()
        {

        }
        #endregion
        /// <summary>
        /// 创建合约事件
        /// </summary>
        public IContractEvent CreateContractEvent<T>(IContractEventData contractEventData) where T : IContractEvent
        {
            IContractEvent contractEvent = Activator.CreateInstance<T>();
            contractEvent.Id = Guid.NewGuid().ToString();
            contractEvent.ContractEventData = contractEventData;
            return contractEvent;
        }
        /// <summary>
        /// 解析合约事件
        /// </summary>
        public IContractEvent ParseContractEvent<T1, T2>(string id, string jsonData) where T1 : IContractEvent where T2 : IContractEventData
        {
            IContractEventData contractEventData = JsonConvert.DeserializeObject<T2>(jsonData);
            IContractEvent contractEvent = null;
            if (contractEventData != null && !string.IsNullOrEmpty(id))
            {
                contractEvent = Activator.CreateInstance<T1>();
                contractEvent.Id = id;
                contractEvent.ContractEventData = contractEventData;
            }
            return contractEvent;
        }
        /// <summary>
        /// 序列化合约事件数据
        /// </summary>
        public string SerializeContractEventData(IContractEvent contractEvent)
        {
            string jsonData = JsonConvert.SerializeObject(contractEvent);
            return jsonData;
        }
    }
}
