using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMQTT.core
{
    public static class Logger
    {
        public enum Level
        { 
            Debug=0,
            Info=1,
            Warn=2,
            Error=3,
            Fatal=4
        }
        /// <summary>
        /// 日志记录
        /// </summary>
        /// <param name="message">所需记录的消息内容</param>
        /// <returns></returns>
        public static string TraceLog(Level level, string message)
        {
            return string.Format(">> {0} [{1}]- {2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), level.ToString(),message);
        }
    }
}
