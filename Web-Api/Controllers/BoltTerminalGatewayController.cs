using System;
using System.Web.Http;
using CardPointeBoltTerminal.Implementations;
using CardPointeBoltTerminal.Dtos;

namespace WebApi.Controllers
{
    public class CardPointeGatewayController: ApiController
    {
        private BoltTerminalGateway _boltTerminalGateway;
        private PingRequestDto _pingRequestDto;
        private ConnectRequestDto _connectRequestDto;
        private DisconnectRequestDto _disconnectRequestDto;
        private AuthCardRequestDto _authCardRequestDto;

        public CardPointeGatewayController(
            BoltTerminalGateway boltTerminalGateway,
            PingRequestDto pingRequestDto,
            ConnectRequestDto connectRequestDto,
            DisconnectRequestDto disconnectRequestDto,
            AuthCardRequestDto authCardRequestDto)
        {
            this._boltTerminalGateway = boltTerminalGateway;
            this._pingRequestDto = pingRequestDto;
            this._connectRequestDto = connectRequestDto;
            this._disconnectRequestDto = disconnectRequestDto;
            this._authCardRequestDto = authCardRequestDto;
        }

        [HttpPost]
        public IHttpActionResult Ping()
        {
            var obj = _pingRequestDto;
            obj.pingBody.merchantId = "0012";

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
            var obj = _connectRequestDto;
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
            var obj = _disconnectRequestDto;
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
            var obj = _authCardRequestDto;
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
