using COPC.Models;
using System;
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
    }
}
