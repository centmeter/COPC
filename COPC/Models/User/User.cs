namespace COPC.ContractModels
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User : IUser
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 用户数据
        /// </summary>
        public IUserData UserData { get; set; }
    }
}
