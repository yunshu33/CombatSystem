namespace Combat.Runtime
{
    /// <summary>
    /// 负面增益
    /// </summary>
    public abstract class DeBuff : Buff
    {
        public override E_Buff_Type BuffType => E_Buff_Type.Debuff;
    }
}