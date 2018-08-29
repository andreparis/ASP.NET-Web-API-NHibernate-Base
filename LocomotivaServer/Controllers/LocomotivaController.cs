using LocomotivaServer.Models;
using LocomotivaServer.SessionManager;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace LocomotivaServer.Controllers
{
    /// <summary>
    /// Classe que recebe os dados para tabela de locomotivas.
    /// Formato com exemplo:
    /// {
    ///	   "id": "7",
    ///    "name": "update_1_1",
    ///	   "deployTimeStamp": "10/10/2018 15:10:10",
    ///    "deployVersion": "a",
    ///    "deviceKey": "a",
    ///    "hubUri": "a",
    ///    "hubProtocol": "a",
    ///    "type": "a",
    ///    "addr": "a",
    ///    "port": "1",
    ///    "poolingTime": "1",
    ///    "monitor": "true",
    ///    "opcTagMonitor": "1",
    ///     "logDir": "a",
    ///    "logLevel": "3",
    ///		"OpcServerName": "a",
    ///		"OpcNodeName": "a"
    ///}
    /// </summary>
    public class LocomotivaController : ApiController 
    {
        private Repository<LocomotivaModel> _repository = new Repository<LocomotivaModel>();
        // GET values
        public IEnumerable<LocomotivaModel> Get()
        {
            var locomotivas = _repository.GetAll<LocomotivaModel>();
            return locomotivas;
        }

        [HttpGet]
        public LocomotivaModel Get(int id)
        {
            return _repository.Get(id);
        }

        public void Post([FromBody]JToken value)
        {
            LocomotivaModel locomotivaModel = JsonConvert.DeserializeObject<LocomotivaModel>(value.ToString());
            locomotivaModel.DeployTimeStamp = DateTime.Now.ToString();
            _repository.Add(locomotivaModel);
        }

        // PUT: api/Locomotiva
        public void Put([FromBody]JToken value)
        {
            LocomotivaModel locomotivaModel = JsonConvert.DeserializeObject<LocomotivaModel>(value.ToString());
            if (locomotivaModel == null || locomotivaModel.Id < 0)
                throw new Exception("Não foi encontrada nenhuma locomotiva para o Id fornecido");
            _repository.Update(locomotivaModel);
        }

        // DELETE: api/Locomotiva/5
        public void Delete(int id)
        {
        }
    }
}
