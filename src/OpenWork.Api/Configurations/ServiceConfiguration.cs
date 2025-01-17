﻿using OpenWork.DataAccess.Interfaces;
using OpenWork.DataAccess.Repositories;
using OpenWork.Services.Interfaces;
using OpenWork.Services.Interfaces.Common;
using OpenWork.Services.Interfaces.Security;
using OpenWork.Services.Services;
using OpenWork.Services.Services.Common;
using OpenWork.Services.Services.Security;

namespace OpenWork.Api.Configurations;

public static class ServiceConfiguration
{
	public static void AddService(this IServiceCollection services)
	{
		_ = services.AddHttpContextAccessor();
		_ = services.AddScoped<IUnitOfWork, UnitOfWork>();
		_ = services.AddScoped<IHasher, Hasher>();
		_ = services.AddScoped<IAuthManager, AuthManager>();
		_ = services.AddScoped<IWorkerService, WorkerService>();
		_ = services.AddScoped<IUserService, UserService>();
		_ = services.AddScoped<IEmailService, EmailService>();
		_ = services.AddScoped<IAuthManager, AuthManager>();
		_ = services.AddScoped<IWorkerService, WorkerService>();
		_ = services.AddScoped<IIdentityService, IdentityService>();
		_ = services.AddScoped<IPaginatorService, PaginatorService>();
		_ = services.AddScoped<ICategoryService, CategoryService>();
		_ = services.AddScoped<ISkillService, SkillService>();
		_ = services.AddScoped<ICommentService, CommentService>();
		_ = services.AddScoped<IBusynessService, BusynessService>();
		_ = services.AddScoped<IFileService, FileService>();


	}
}
