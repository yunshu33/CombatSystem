
namespace Combat.Runtime
{
    /// <summary>
    /// 可以受到攻击的
    /// </summary>
    public interface IAssailable
    {
        /// <summary>
        /// 受 击
        /// </summary>
        public void Assailable(object playerData);
    }
}