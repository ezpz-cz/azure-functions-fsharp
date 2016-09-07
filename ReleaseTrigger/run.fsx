open System
open System.Net
open System.Net.Http

let Run (req: HttpRequestMessage) (log: TraceWriter) = async {
    let! content = req.Content.AsyncReadAsString ()
    return req HttpStatusCode.OK
           <| ``Content-Type`` "text/plain"
           <| new StringContent(content)
}