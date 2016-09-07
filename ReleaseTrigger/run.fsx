#if !COMPILED
#r "c:\Program Files\dotnet\shared\Microsoft.NETCore.App\1.0.0\System.Net.Http.dll"
#r "c:\Program Files\dotnet\shared\Microsoft.NETCore.App\1.0.0\System.Net.Primitives.dll"
#r "c:\Program Files\dotnet\shared\Microsoft.NETCore.App\1.0.0\System.Threading.Tasks.dll"
#endif

open System
open System.Net
open System.Net.Http

let Run (req: HttpRequestMessage) : Async<HttpResponseMessage> = async {
    let! content = req.Content.ReadAsStringAsync() |> Async.AwaitTask
    return new HttpResponseMessage(HttpStatusCode.OK)
}