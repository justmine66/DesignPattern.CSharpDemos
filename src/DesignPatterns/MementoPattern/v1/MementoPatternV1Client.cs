using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MementoPattern.v1
{
    /// <summary>
    /// 
    /// </summary>
    public class MementoPatternV1Client
    {
        public void Main()
        {
            var lixiaoyao = new GameRole();

            //大战Boss前
            lixiaoyao.GetInitState();
            lixiaoyao.StateDisplay();

            //保存进度
            var backup = new GameRole();
            backup.Vitality = lixiaoyao.Vitality;
            backup.Attack = lixiaoyao.Attack;
            backup.Defense = lixiaoyao.Defense;

            //大战Boss，损耗严重
            lixiaoyao.Fight();
            lixiaoyao.StateDisplay();

            //恢复之前的状态
            lixiaoyao.Vitality = backup.Vitality;
            lixiaoyao.Attack = backup.Attack;
            lixiaoyao.Defense = backup.Defense;

            lixiaoyao.StateDisplay();
        }
    }
}
