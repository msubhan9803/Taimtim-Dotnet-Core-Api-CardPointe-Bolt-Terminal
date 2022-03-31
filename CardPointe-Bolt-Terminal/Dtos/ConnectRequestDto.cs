﻿namespace CardPointeBoltTerminal.Dtos
{
    public class ConnectRequestDto
    {
        public ConnectHeaders connectHeaders { get; set; }
        public ConnectBody connectBody { get; set; }
    }

    public class ConnectHeaders
    {
        public string Authorization { get; set; }
    }

    public class ConnectBody
    {
        public string merchantId { get; set; }
        public string token { get; set; }
        public string hsn { get; set; }
        public string force { get; set; }
    }
}