﻿// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =

    let client = CryptoApi.Exchanges.Cobinhood.RestClient()
    printfn "Hello World from F#!"
    0 // return an integer exit code
