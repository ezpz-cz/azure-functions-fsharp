open System

let Run (req: HttpRequestMessage, log: TraceWriter) =
    log.Info(sprintf "F# Queue trigger function processed: '%s'" input)