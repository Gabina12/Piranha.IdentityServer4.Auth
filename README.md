# Piranha.IdentityServer4.Auth


     services.AddPiranha(options =>
                {
                    options.AddRazorRuntimeCompilation = true;
    
                    options.UseFileStorage(naming: Piranha.Local.FileStorageNaming.UniqueFolderNames);
                    options.UseImageSharp();
                    options.UseManager();
                    options.UseTinyMCE();
                    options.UseMemoryCache();
                    options.UseEF<SQLiteDb>(db =>
                        db.UseSqlite(_config.GetConnectionString("piranha")));
                    options.UseIdentityServer4Auth(ids4Options =>
                    {
                            ids4Options.SignInScheme = "Cookies";
                            ids4Options.Authority = "https://identityserver4.io";
                            ids4Options.ClientId = "client id";
                            ids4Options.RequireHttpsMetadata = false;
                            ids4Options.ResponseType = "code id_token";
                            ids4Options.SaveTokens = true;
                            ids4Options.GetClaimsFromUserInfoEndpoint = true;
                            ids4Options.UseTokenLifetime = false;
                            ids4Options.ClientSecret = "your secret key";
                            ids4Options.Scope.Add("your scope");
                            ids4Options.AuthenticationMethod = OpenIdConnectRedirectBehavior.FormPost;
                    });
                });

# Configuration

**it's a standart oidc client parameters**

    options.UseIdentityServer4Auth(ids4Options =>
                        {
                            ids4Options.SignInScheme = "Cookies";
                            ids4Options.Authority = "https://identityserver4.io";
                            ids4Options.ClientId = "client id";
                            ids4Options.RequireHttpsMetadata = false;
                            ids4Options.ResponseType = "code id_token";
                            ids4Options.SaveTokens = true;
                            ids4Options.GetClaimsFromUserInfoEndpoint = true;
                            ids4Options.UseTokenLifetime = false;
                            ids4Options.ClientSecret = "your secret key";
                            ids4Options.Scope.Add("your scope");
                            ids4Options.AuthenticationMethod = OpenIdConnectRedirectBehavior.FormPost;
                        });
