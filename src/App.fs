module App

open Browser.Dom

let increase = document.getElementById "increase"
let decrease = document.getElementById "decrease"
let countViewer = document.getElementById "countViewer" 

let mutable currentCount = 0

let runAfter (ms: int) callback =
    async {
        do! Async.Sleep ms
        do callback() 
    }
    |> Async.StartImmediate

let increaseDelayed = document.getElementById "increaseDelayed"
   
let rnd = System.Random()

increaseDelayed.onclick <- fun _ ->
    runAfter 1000 (fun () ->
        currentCount <- currentCount + rnd.Next(5, 10)
        countViewer.innerText <- $"Count is at {currentCount}"
        )
 
increase.onclick <- fun ev ->
    currentCount <- currentCount + rnd.Next(5, 10)
    countViewer.innerText <- $"Count is at {currentCount}"
    
decrease.onclick <- fun ev ->
    currentCount <- currentCount + rnd.Next(5, 10)
    countViewer.innerText <- $"Count is at {currentCount}"
    
countViewer.innerText <- $"Count is at {currentCount}"