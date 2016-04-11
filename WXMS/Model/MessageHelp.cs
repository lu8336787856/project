using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 消息处理类
    /// </summary>
    public class MessageHelp
    {
        private static MessageHelp instance = null;

        /// <summary>
        /// 单例
        /// </summary>
        /// <returns></returns>
        public static MessageHelp getInstance() 
        {
            if (instance == null) 
            {
                instance = new MessageHelp();
            }
            return instance;
        }

        /// <summary>
        /// 统一处理消息接口
        /// </summary>
        /// <param name="postStr">消息的内容 Xml格式</param>
        /// <returns></returns>
        public string HandleMessage(string postStr) 
        {

            return "";
        }
    }
}
