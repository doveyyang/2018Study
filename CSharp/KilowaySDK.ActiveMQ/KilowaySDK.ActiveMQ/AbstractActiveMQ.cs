using Apache.NMS;

namespace KilowaySDK.ActiveMQ.Interface
{
    /// <summary>
    /// ActiveMQ 抽象类
    /// </summary>
    public abstract class AbstractActiveMQ
    {
        #region 监听连接对象
        protected IConnection _connection;
        protected ISession _session;
        protected IMessageConsumer _consumer;
        #endregion

        /// <summary>
        /// 连接地址
        /// </summary>
        public string BrokerUri { get; set; }

        /// <summary>
        /// 用于登录的用户名,必须和密码同时指定
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 用于登录的密码,必须和用户名同时指定
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 队列名称
        /// </summary>
        public string QueueName { get; set; }

        /// <summary>
        /// 指定使用队列的模式
        /// </summary>
        public MQMode MQMode { get; set; }

    }
}
