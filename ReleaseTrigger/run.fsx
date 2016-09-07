open System
open System.Net
open System.Net.Http
open System.Net.Http.Headers
open System.Web
open FSharp.Data

let Run (req: HttpRequestMessage) (log: TraceWriter) = async {
    let! content = req.Content.AsyncReadAsString ()
    return req HttpStatusCode.OK
           <| ``Content-Type`` "text/plain"
           <| new StringContent(content)
}