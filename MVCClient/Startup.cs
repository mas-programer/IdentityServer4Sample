﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace MVCClient
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.Configure<CookiePolicyOptions>(options =>
			{
				// This lambda determines whether user consent for non-essential cookies is needed for a given request.
				options.CheckConsentNeeded = context => true;
				options.MinimumSameSitePolicy = SameSiteMode.None;
			});

            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();


            services.AddAuthentication(options =>
			{
				options.DefaultScheme = "Cookies";
				options.DefaultChallengeScheme = "oidc"; //open id connect
			})
			.AddCookie("Cookies")
			.AddOpenIdConnect("oidc", options =>
			{
				options.SignInScheme = "Cookies";
				options.Authority = "http://localhost:5000";
				options.RequireHttpsMetadata = false;

                options.ResponseType = OpenIdConnectResponseType.CodeIdToken; // Autherization code 、Id Token
                //options.ResponseType = OpenIdConnectResponseType.CodeIdTokenToken; //Autherization code 、Id Token、AccessToken

                options.ClientId = "mvc";
				options.ClientSecret = "secret";
				options.SaveTokens = true;

                //options.GetClaimsFromUserInfoEndpoint = true; //发起另一个请求获取Claim

                //options.ClaimActions.MapJsonKey("sub", "sub");
                //options.ClaimActions.MapJsonKey("preferred_username", "preferred_username");
                //options.ClaimActions.MapJsonKey("avatar", "avatar");
                //options.ClaimActions.MapCustomJson("role", jobj => jobj["role"].ToString());

                options.Scope.Add("offline_access");
                options.Scope.Add("openid");
                options.Scope.Add("profile");
            });

			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}

			app.UseStaticFiles();
			app.UseCookiePolicy();

			app.UseAuthentication();

			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
