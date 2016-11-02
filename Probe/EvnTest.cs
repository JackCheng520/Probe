using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

// ================================
//* 功能描述：EvnTest  
//* 创 建 者：chenghaixiao
//* 创建日期：2016/7/18 14:09:19
// ================================
namespace Assets.JackCheng.Probe
{
    public class EvnTest : MonoBehaviour
    {
        J_Echo probeSystem = new J_Echo();
        string textFieldStr = "0";

        void Start() {

            probeSystem.Clear();
            for (int i = 0; i < 100; i++)
            {
                probeSystem.Add(Setp, 0.1f);
            }
        }

        void Update() 
        {
            probeSystem.Update();
        }

        void OnGUI()
        {
            //textFieldStr = GUI.TextField(new Rect(10, 10, 200, 30), textFieldStr);
            //if (GUI.Button(new Rect(10, 50, 100, 60), "添加事件"))
            //{
            //    float t = float.Parse(textFieldStr);
            //    probeSystem.Add(CallBack, t);
            //}

            //if (GUI.Button(new Rect(10, 50, 100, 60), "开始"))
            //{
            //    GoNext();
            //}
        }

        void Setp() 
        {
            Debug.Log("Setp0 -- " + Time.realtimeSinceStartup);
            GoNext();
        }

        void GoNext() {
            //probeSystem.Go();
        }
    }
}
