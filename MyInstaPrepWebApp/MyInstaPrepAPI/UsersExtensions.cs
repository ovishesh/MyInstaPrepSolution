// Code generated by Microsoft (R) AutoRest Code Generator 0.9.6.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using MyInstaPrepWebApp;
using MyInstaPrepWebApp.Models;

namespace MyInstaPrepWebApp
{
    public static partial class UsersExtensions
    {
        /// <param name='operations'>
        /// Reference to the MyInstaPrepWebApp.IUsers.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static User DeleteUser(this IUsers operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IUsers)s).DeleteUserAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the MyInstaPrepWebApp.IUsers.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<User> DeleteUserAsync(this IUsers operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<MyInstaPrepWebApp.Models.User> result = await operations.DeleteUserWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the MyInstaPrepWebApp.IUsers.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static User GetUser(this IUsers operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IUsers)s).GetUserAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the MyInstaPrepWebApp.IUsers.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<User> GetUserAsync(this IUsers operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<MyInstaPrepWebApp.Models.User> result = await operations.GetUserWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the MyInstaPrepWebApp.IUsers.
        /// </param>
        public static IList<User> GetUsers(this IUsers operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IUsers)s).GetUsersAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the MyInstaPrepWebApp.IUsers.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<User>> GetUsersAsync(this IUsers operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<MyInstaPrepWebApp.Models.User>> result = await operations.GetUsersWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the MyInstaPrepWebApp.IUsers.
        /// </param>
        /// <param name='user'>
        /// Required.
        /// </param>
        public static User PostUser(this IUsers operations, User user)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IUsers)s).PostUserAsync(user);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the MyInstaPrepWebApp.IUsers.
        /// </param>
        /// <param name='user'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<User> PostUserAsync(this IUsers operations, User user, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<MyInstaPrepWebApp.Models.User> result = await operations.PostUserWithOperationResponseAsync(user, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the MyInstaPrepWebApp.IUsers.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='user'>
        /// Required.
        /// </param>
        public static object PutUser(this IUsers operations, int id, User user)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IUsers)s).PutUserAsync(id, user);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the MyInstaPrepWebApp.IUsers.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='user'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PutUserAsync(this IUsers operations, int id, User user, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PutUserWithOperationResponseAsync(id, user, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
