using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// ================================
//* 功能描述：J_Echo  
//* 创 建 者：chenghaixiao
//* 创建日期：2016/7/18 13:53:04
// ================================
namespace Assets.JackCheng.Probe
{
    public class J_Echo
    {
        public delegate void Msg();
        class CallBack 
        {
            public Msg call;

            public float delay;
        }

        private bool beLock = false;

        List<CallBack> listMessage = new List<CallBack>();

        public void Clear() {
            listMessage.Clear();
        }

        public void Add(Msg _call) 
        {
            CallBack cb = new CallBack();
            cb.call = _call;
            cb.delay = 0;
            listMessage.Add(cb);
        }

        public void Add(Msg _call, float _delay) 
        {
            CallBack cb = new CallBack();
            cb.call = _call;
            cb.delay = _delay;
            listMessage.Add(cb);
        }


        public void Lock() {
            beLock = true;
        }
        public void UnLock() {
            beLock = false;
        }

        public void Update() {
            if (!beLock) 
            {
                SearchEvn();
            }
        }
        private Msg curMsg;
        private void SearchEvn() 
        {
            if (listMessage.Count > 0) {

                if (listMessage[0] != null) {
                    listMessage[0].delay -= UnityEngine.Time.fixedDeltaTime;
                    if (listMessage[0].delay <= 0) 
                    {
                        curMsg = listMessage[0].call;
                        listMessage.RemoveAt(0);

                        curMsg();
                        curMsg = null;
                    }
                }
            }
        }


    }
}
