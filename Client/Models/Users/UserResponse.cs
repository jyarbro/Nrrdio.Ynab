namespace Nrrdio.Ynab.Client.Models.Users {
    public class UserResponse {
        public UserResponseData Data { get; set; }

        public class UserResponseData {
            public User User { get; set; }
        }
    }
}
