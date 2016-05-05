using System.Web;
using Carriers.MVC.ViewModels;

namespace Carriers.MVC.Helpers
{
    public static class GerenciadorSessao 
    {
        //Todo:
        /**
        * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        *  Infelizmente não tive tempo de implementar o Identity :(       * 
        * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        **/

        public static UserViewModel User
        {
            get { return Get<UserViewModel>("User"); }
            set { Set<UserViewModel>("User", value); }
        }

        /// <summary> Gets. </summary>
        /// <typeparam name="T"> Generic type parameter. </typeparam>
        /// <param name="key"> The key. </param>
        /// <returns> . </returns>
        private static T Get<T>(string key)
        {
            object o = HttpContext.Current.Session[key];
            if (o is T)
            {
                return (T)o;
            }

            return default(T);
        }

        /// <summary> Sets. </summary>
        /// <typeparam name="T"> Generic type parameter. </typeparam>
        /// <param name="key">  The key. </param>
        /// <param name="item"> The item. </param>
        private static void Set<T>(string key, T item)
        {
            HttpContext.Current.Session[key] = item;
        }
    }
}
