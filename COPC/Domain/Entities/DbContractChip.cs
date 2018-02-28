using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COPC.Domain.Entities
{
    public class DbContractChip : DbEntity
    {
        /// <summary>
        /// 序列化后的筹码数据
        /// </summary>
        public string JsonData { get; set; }
    }
}
