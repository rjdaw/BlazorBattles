﻿using BlazorBattles.Shared;

namespace BlazorBattles.Server.Data
{
    public class AuthRepository : IAuthRepository
    {
        public Task<string> Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<int> Register(User user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExists(string email)
        {
            throw new NotImplementedException();
        }
    }
}
