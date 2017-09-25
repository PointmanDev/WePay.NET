using WePayApi.Shared;

namespace WePayApi.User.Response
{
    public class LookupResponse : WePayResponse
    {
        /// <summary>
        /// The unique ID of the user.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// The full name of the user.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The first name of the user.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The email of the user.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The current state of the User
        /// (Enumeration of these values can be found in WePayApi.User.Common.UserStates)
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The URI you want to receive IPNs on.
        /// </summary>
        public string CallbackUri { get; set; }
    }
}