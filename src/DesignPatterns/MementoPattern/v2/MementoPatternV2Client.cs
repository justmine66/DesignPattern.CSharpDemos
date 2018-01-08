using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MementoPattern.v2
{
    public class MementoPatternV2Client
    {
        public void Main()
        {
            var lixiaoyao = new GameRole();

            //大战Boss前
            lixiaoyao.GetInitState();
            lixiaoyao.StateDisplay();

            //保存进度
            var caretaker = new RoleStateCaretaker();
            caretaker.memento = lixiaoyao.SaveState();

            //大战Boss，损耗严重
            lixiaoyao.Fight();
            lixiaoyao.StateDisplay();

            //恢复之前的状态
            lixiaoyao.RecoveryState(caretaker.memento);

            lixiaoyao.StateDisplay();
        }
    }
}
