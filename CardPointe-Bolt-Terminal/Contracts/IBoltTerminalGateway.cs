using System;
using CardPointeBoltTerminal.Dtos;
using RestSharp;

namespace CardPointeBoltTerminal.Contracts
{
    public interface IBoltTerminalGateway
    {
        IRestResponse PingRequest(PingRequestDto request);
        IRestResponse ConnectRequest(ConnectRequestDto request);
        IRestResponse AuthCardRequest(AuthCardRequestDto request);
        IRestResponse DisconnectRequest(DisconnectRequestDto request);
    }
}
