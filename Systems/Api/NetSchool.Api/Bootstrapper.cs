﻿namespace NetSchool.Api;

using NetSchool.Context.Seeder;
using NetSchool.Services.Logger;
using NetSchool.Services.Settings;
using NetSchool.Api.Settings;
using NetSchool.Services.Books;
using NetSchool.Services.Points;
using NetSchool.Services.PointCategories;
using NetSchool.Services.Feedbacks;
using NetSchool.Services.Authors;
using NetSchool.Services.RabbitMq;
using NetSchool.Services.Actions;
using NetSchool.Services.UserAccount;

public static class Bootstrapper
{
    public static IServiceCollection RegisterServices (this IServiceCollection service, IConfiguration configuration = null)
    {
        service
            .AddMainSettings()
            .AddLogSettings()
            .AddSwaggerSettings()
            .AddIdentitySettings()
            .AddAppLogger()
            .AddDbSeeder()
            .AddApiSpecialSettings()
            .AddBookService()
            .AddPointService()
            .AddPointCategoryService()
            .AddFeedbackService()
            .AddAuthorService()
            .AddRabbitMq()
            .AddActions()
            .AddUserAccountService()
            ;

        return service;
    }
}
