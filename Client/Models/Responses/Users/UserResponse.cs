﻿using Nrrdio.Ynab.Client.Models.Data.Users;

namespace Nrrdio.Ynab.Client.Models.Responses.Users {
    public class UserResponse {
        public UserResponseData? Data { get; set; }

        public class UserResponseData {
            public User? User { get; set; }
        }
    }

    /*
     * Example:
     * 
        {
          "data": {
            "user": {
              "id": "asdf1234-asdf-1234-asdf-1234asdf1234"
            }
          }
        }
    */
}
