using System;
using System.Configuration;
using System.Web.Http;
using CardPointeBoltTerminal.Implementations;
using CardPointeBoltTerminal.Dtos;

namespace WebApi.Controllers
{
    public class BoltTerminalGatewayController: ApiController
    {
        private BoltTerminalGateway _boltTerminalGateway;

        public BoltTerminalGatewayController()
        {
            _boltTerminalGateway = new BoltTerminalGateway();
        }

        [HttpPost]
        public IHttpActionResult Ping()
        {
            var obj = new PingRequestDto();
            // Setting Headers
            var config = ConfigurationManager.AppSettings;
            obj.pingHeaders.XCardConnectSessionKey = ConfigurationManager.AppSettings["X-CardConnect-SessionKey"].ToString();
            obj.pingHeaders.Authorization = ConfigurationManager.AppSettings["Bolt-Authorization"].ToString();

            // Setting Body payload
            obj.pingBody.merchantId = ConfigurationManager.AppSettings["merchantId"].ToString();
            obj.pingBody.hsn = ConfigurationManager.AppSettings["hsn"].ToString();

            var result = _boltTerminalGateway.PingRequest(obj);
            Console.WriteLine("response: ", arg0: result);
            if (result == null)
            {
                return BadRequest("Oops something went wrongQ");
            }
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Connect()
        {
            var obj = new ConnectRequestDto();
            obj.connectBody.merchantId = "0012";

            var result = _boltTerminalGateway.ConnectRequest(obj);
            Console.WriteLine("response: ", arg0: result);
            if (result == null)
            {
                return BadRequest("Oops something went wrongQ");
            }
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Disconnect()
        {
            var obj = new DisconnectRequestDto();
            obj.disconnectBody.merchantId = "0012";

            var result = _boltTerminalGateway.DisconnectRequest(obj);
            Console.WriteLine("response: ", arg0: result);
            if (result == null)
            {
                return BadRequest("Oops something went wrongQ");
            }
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult AuthCard()
        {
            var obj = new AuthCardRequestDto();
            obj.authCardBody.merchantId = "0012";

            var result = _boltTerminalGateway.AuthCardRequest(obj);
            Console.WriteLine("response: ", arg0: result);
            if (result == null)
            {
                return BadRequest("Oops something went wrongQ");
            }
            return Ok(result);
        }
    }
}
