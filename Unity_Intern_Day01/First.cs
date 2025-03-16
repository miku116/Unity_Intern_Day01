using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace Unity_Intern_Day01
{
    /*需要 正确做法：

    1.确保代码文件位于 Unity 项目的 Assets 文件夹内
    2.在 Unity 编辑器中右键点击项目窗口 -> Create -> C# Script
    3.使用 Unity 自带的脚本模板新建脚本（会自动包含必要引用）
    4.不要手动添加 using UnityEngine;（Unity 会自动生成）*/
    public class First : MonoBehaviour // 继承 MonoBehaviour
    {
        void Start() // 使用 Unity 的生命周期函数
        {
            int playerScore = 100;
            if (playerScore >= 60)
            {
                Debug.Log("成功了..."); // 现在不会标红
            }
        }
    }
}
}
