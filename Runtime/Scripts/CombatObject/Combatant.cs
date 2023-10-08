using System;
using System.Collections.Generic;
using UnityEngine;

namespace Combat.Runtime.CombatObject
{
    /// <summary>
    /// 战斗人员
    /// </summary>
    public class Combatant : MonoBehaviour, IAssailable
    {
        /// <summary>
        /// 所有buff 列表
        /// </summary>
        private readonly List<IBuff> buffs = new List<IBuff>();

        public void AddBuff(IBuff buff)
        {
            buffs.Add(buff);
            
        }
        
        private void Update()
        {
            foreach (var buff in buffs)
            {
                buff.Update();
            }
        }

        public void Assailable()
        {
        }
    }
}