using System.Collections.Generic;
using UnityEngine;

namespace Combat.Runtime
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

        /// <summary>
        /// 添加buff
        /// </summary>
        /// <param name="buff"></param>
        public void AddBuff(IBuff buff)
        {
            buffs.Add(buff);

            buffs.Sort((a, b) => a.Order.CompareTo(b.Order));

            buff.destroy += () => RemoveBuff(buff);
        }

        /// <summary>
        /// 移除buff
        /// </summary>
        /// <param name="buff"></param>
        public void RemoveBuff(IBuff buff)
        {
            buffs.Remove(buff);
        }

        private void Update()
        {
            foreach (var buff in buffs)
            {
                buff.Update(Time.deltaTime);
            }
        }

        public void Assailable(object playerData)
        {
        }
    }
}