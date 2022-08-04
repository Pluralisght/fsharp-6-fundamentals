namespace MyFsharpLib
type Record = { Name: string; Age: int }
type Abc =
    | A
    | B of double
    | C of Record

module Program =
    let exitCode = 0

    [<EntryPoint>]
    let main args =

        let builder = WebApplication
                           .CreateBuilder(args)
        builder.Services.AddControllers()

        let app = builder.Build()
        app.UseHttpsRedirection()
        app.UseAuthorization()
        app.MapControllers()
        app.Run()
        0