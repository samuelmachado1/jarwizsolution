﻿using CentralDeErro.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using System;

namespace CentralDeErro.Tests._3_InfrastructureTests.Data
{
    public class FakeUserManager : UserManager<User>
    {
        public FakeUserManager()
            : base(new Mock<IUserStore<User>>().Object,
                new Mock<IOptions<IdentityOptions>>().Object,
                new Mock<IPasswordHasher<User>>().Object,
                new IUserValidator<User>[0],
                new IPasswordValidator<User>[0],
                new Mock<ILookupNormalizer>().Object,
                new Mock<IdentityErrorDescriber>().Object,
                new Mock<IServiceProvider>().Object,
                new Mock<ILogger<UserManager<User>>>().Object)
        {
        }
    }

    //public override Task<IdentityResult> CreateAsync(ApplicationUser user, string password)
    //{
    //    return Task.FromResult(IdentityResult.Success);
    //}

    //public override Task<IdentityResult> AddToRoleAsync(ApplicationUser user, string role)
    //{
    //    return Task.FromResult(IdentityResult.Success);
    //}

    //public override Task<string> GenerateEmailConfirmationTokenAsync(ApplicationUser user)
    //{
    //    return Task.FromResult(Guid.NewGuid().ToString());
    //}


}
