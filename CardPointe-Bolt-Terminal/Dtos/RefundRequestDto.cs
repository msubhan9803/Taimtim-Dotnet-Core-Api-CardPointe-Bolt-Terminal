namespace CardPointeBoltTerminal.Dtos
{
    public class RefundRequestDto
    {
        public RefundHeaders refundHeaders { get; set; }
        public RefundBody refundBody { get; set; }
    }

    public class RefundHeaders
    {
        public string Authorization { get; set; }
    }

    public class RefundBody
    {
        public string merchid { get; set; }
        public string retref { get; set; }
        public string amount { get; set; }
        public string orderid { get; set; }
    }
}