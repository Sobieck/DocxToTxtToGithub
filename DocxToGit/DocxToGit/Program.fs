// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

module DocxToGit.main

open System
open ConvertFile
open UpdateRepo


 [<EntryPoint>]
let main argv = 
    printf "Hello"

    let arguments = Array.toList argv

    let extension = List.tail arguments |> List.tail |> List.head
    let fileName = List.tail arguments |> List.head

    convertDocument (List.head arguments) fileName extension
      
 
    let result = github (List.last arguments)

    let input = Console.ReadLine()

    Console.Write("You entered: {0}", input)
 
    let nextInput = Console.ReadLine() |> ignore
    0

