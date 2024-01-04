module App

open Browser.Dom

let increase = document.getElementById "increase"
let decrease = document.getElementById "decrease"
let countViewer = document.getElementById "countViewer" 

let mutable currentCount = 0

increase.onclick <- fun ev ->
    currentCount <- currentCount + 1
    countViewer.innerText <- $"Count is at {currentCount}"
    
decrease.onclick <- fun ev ->
    currentCount <- currentCount + 1
    countViewer.innerText <- $"Count is at {currentCount}"
    
countViewer.innerText <- $"Count is at {currentCount}"