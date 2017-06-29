namespace OSS.PaySdk.Wx.Pay.Mos
{
    /// <summary>
    /// 返回给App端的，直接可用的预付单数据
    /// </summary>
    public class WxAppPrepayOrderInfoMo
    {
        /// <summary>
        /// 应用的Appid
        /// </summary>
        public string appid { get; set; }
        /// <summary>
        /// 也就是mchid
        /// </summary>
        public string partnerid { get; set; }

        /// <summary>
        /// 预付订单id
        /// </summary>
        public string prepayid { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        public string noncestr { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public string timestamp { get; set; }

        /// <summary>
        /// 常量 "Sign=WXPay"
        /// </summary>
        public string package { get; set; } = "Sign=WXPay";

        /// <summary>
        /// 签名
        /// </summary>
        public string sign { get; set; }
    }
}
