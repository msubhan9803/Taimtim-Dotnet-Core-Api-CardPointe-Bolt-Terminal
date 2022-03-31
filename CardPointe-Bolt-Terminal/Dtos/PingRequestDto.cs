using System;
namespace CardPointeBoltTerminal.Dtos
{
    public class PingRequestDto
    {
        public PingHeaders pingHeaders { get; set; }
        public PingBody pingBody { get; set; }
    }

    public class PingHeaders
    {
        public string Authorization { get; set; }
        public string XCardConnectSessionKey { get; set; }
    }

    public class PingBody
    {
        public string merchantId { get; set; }
        public string hsn { get; set; }
    }
}