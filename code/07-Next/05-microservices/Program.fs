namespace api
#nowarn "20"
open System
open System.Collections.Generic
open System.IO
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.HttpsPolicy
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.Logging

open Finance.Domain

module Program =
    open Finance.Account.Repository
    let exitCode = 0

    [<EntryPoint>]
    let main args =

        let builder = WebApplication.CreateBuilder(args)

        builder.Services.AddControllers()

        builder.Services.AddScoped<IRepository<Account>>(fun _ -> Finance.Factories.Repositories.Account.Memory)

        let app = builder.Build()

        app.MapControllers()

        app.Run()

        exitCode
