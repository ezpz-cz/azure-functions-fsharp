#r "c:\Program Files\dotnet\shared\Microsoft.NETCore.App\1.0.0\System.Net.Primitives.dll"
#r "c:\Program Files\dotnet\shared\Microsoft.NETCore.App\1.0.0\System.Net.Http.dll"
#r "c:\Program Files\dotnet\shared\Microsoft.NETCore.App\1.0.0\System.Threading.Tasks.dll"
#r "c:\Program Files\dotnet\shared\Microsoft.NETCore.App\1.0.0\System.Text.Encoding.dll"

open System
open System.Net
open System.Net.Http
open System.Net.Http.Headers
open System.Threading.Tasks
open System.Web
open System.Text
open FSharp.Data

let Run (req: HttpRequestMessage) = async {
    let! content = req.Content.ReadAsStringAsync() |> Async.AwaitTask
    let response = new HttpResponseMessage(HttpStatusCode.OK)
    response.Content <- new StringContent(content)
    return response
}