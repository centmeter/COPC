using System;
using COPC.ContractModels;
using Newtonsoft.Json;
namespace COPC.ContractFactories
{
    public class UserFactory
    {
        #region Singleton
        private static UserFactory _instance;
        private static object _locker = new object();
        public static UserFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new UserFactory();
                        }
                    }
                }
                return _instance;
            }
        }
        private UserFactory()
        {

        }
        #endregion
        /// <summary>
        /// 创建用户
        /// </summary>
        public IUser CreateUser<T>(string id ,IUserData userData) where T : IUser
        {
            IUser user = Activator.CreateInstance<T>();
            user.Id = id;
            user.UserData = userData;
            return user;
        }
        /// <summary>
        /// 解析用户
        /// </summary>
        public IUser ParseUser<T1, T2>(string id, string jsonData) where T1 : IUser where T2 : IUserData
        {
            IUserData userData = JsonConvert.DeserializeObject<T2>(jsonData);
            IUser user = null;
            if (userData != null && !string.IsNullOrEmpty(id))
            {
                user = Activator.CreateInstance<T1>();
                user.Id = id;
                user.UserData = userData;
            }
            return user;
        }

        /// <summary>
        /// 序列化用户
        /// </summary>
        public string SerializeuserData(IUser user)
        {
            string jsonData = JsonConvert.SerializeObject(user.UserData);
            return jsonData;
        }
    }
}
