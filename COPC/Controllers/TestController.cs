using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using COPC.ContractFactories;
using COPC.ContractModels;

namespace COPC.Controllers
{
    [Route("COPCTest/[controller]")]
    public class TestController : Controller
    {
        private readonly TestDBContext _context;

        public TestController(TestDBContext context)
        {
            _context = context;

            if (_context.Contracts.Any())
            {
                return; // 已经初始化过数据，直接返回
            }
            //初始化数据
        }
          
        [HttpGet]
        public IEnumerable<string> Get()
        {
            IContractEvent contractEvent = ContractEventFactory.Instance.CreateContractEvent<StandardContractEvent>(new ContractEventData() { Description = "早上7点前起床" });
            IContractChip contractChip = ContractChipFactory.Instance.CreateContractChip<StandardContractChip>(new ContractChipData() { Description = "得到1毛钱" });
            IContractData contractData = new ContractData()
            {
                InitiatorIds = new string[] { "A" },
                ActorIds = new string[] { "B" },
                ContractEventId = contractEvent.Id,
                ContractChipId = contractChip.Id
            };
            IContract contract = ContractFactory.Instance.CreateContract<Contract>(contractData);

            //保存到数据库
            _context.StandardContractEvents.Add(contractEvent as StandardContractEvent);
            _context.StandardContractChips.Add(contractChip as StandardContractChip);
            _context.Contracts.Add(contract as Contract);

            _context.SaveChanges();

            //返回结果
            return new string[]
            {
                ContractFactory.Instance.SerializeContractData(contract),
                ContractEventFactory.Instance.SerializeContractEventData(contractEvent),
                ContractChipFactory.Instance.SerializeContractChipData(contractChip)
            };

        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
