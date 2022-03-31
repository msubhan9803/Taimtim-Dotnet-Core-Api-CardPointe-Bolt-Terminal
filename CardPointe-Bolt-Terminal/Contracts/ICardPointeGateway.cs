using System;
using CardPointeBoltTerminal.Dtos;
using RestSharp;

namespace CardPointeBoltTerminal.Contracts
{
    public interface ICardPointeGateway
    {
        IRestResponse AuthorizationRequest(AuthorizationRequestDto request);
        IRestResponse RefundRequest(RefundRequestDto request);
    }
}
