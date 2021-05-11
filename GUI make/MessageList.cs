using Renci.SshNet.Messages.Authentication;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_make
{
    class MessageList
    {

        public Hashtable hash;

        public static string SUCCESS = "SUCCESS";
        public static string FAIL = "FAIL";
        public MessageList(){
            hash = new Hashtable();
            hash.Add(MessageList.HintType.HINT_TYPE_1, 1);
            hash.Add(MessageList.HintType.HINT_TYPE_2, 2);
            hash.Add(MessageList.HintType.HINT_TYPE_3, 3);
            hash.Add(MessageList.HintType.HINT_TYPE_4, 4);
            hash.Add(MessageList.HintType.HINT_TYPE_5, 5);
        }
        public class HintType
        {
            public static string HINT_TYPE_1 = "어릴적 별명은 무엇입니까?";
            public static string HINT_TYPE_2 = "태어난 고향은 어디입니까?";
            public static string HINT_TYPE_3 = "출신초등학교 이름은 무엇입니까?";
            public static string HINT_TYPE_4 = "좋아하는 색깔은 무엇입니까?";
            public static string HINT_TYPE_5 = "가장 좋아하는 영화는 무엇입니까?";
        }
    }
}
