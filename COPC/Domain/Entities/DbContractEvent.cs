using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COPC.Domain.Entities
{
    public class DbContractEvent : DbEntity
    {
        /// <summary>
        /// 序列化后的事件数据
        /// </summary>
        public string JsonData { get; set; }
    }
}
