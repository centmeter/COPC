namespace COPC.ContractModels
{
    /// <summary>
    /// 用户接口
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        string Id { get; set; }
        /// <summary>
        /// 用户数据
        /// </summary>
        IUserData UserData { get; set; }

    }
}
