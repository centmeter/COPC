using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COPC.Domain.Entities
{
    public class DbContract : DbEntity
    {
        /// <summary>
        /// 序列化后的合约数据
        /// </summary>
        public string JsonData { get; set; }
    }
}
