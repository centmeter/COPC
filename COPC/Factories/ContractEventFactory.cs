using System;
using COPC.Models;
namespace COPC.Factories
{
    /// <summary>
    /// 合约事件工厂
    /// </summary>
    public class ContractEventFactory
    {
        #region Singleton
        private static ContractEventFactory _instance;
        public static object _locker = new object();
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
        public IContractEvent CreateContractChip<T>(IContractEventData contractEventData) where T : IContractEvent
        {
            IContractEvent contractEvent = Activator.CreateInstance<T>();
            contractEvent.Id = Guid.NewGuid().ToString();
            contractEvent.ContractEventData = contractEventData;
            return contractEvent;
        }
    }
}
