open System.Drawing
open System.IO
open System

type Plotter = {
    position: int * int
    color: Color
    direction: float
    bitmap: Bitmap }

let drawLine (endX, endY) plotter =
    use graphics = Graphics.FromImage(plotter.bitmap)
    use pen = new Pen(plotter.color)
    let startX, startY = plotter.position
    graphics.DrawLine(pen, startX, startY, endX, endY)
    let updatedPlotter = { plotter with position = (endX, endY) }
    updatedPlotter

let turn amount plotter =
    let newDir = plotter.direction + amount
    let turned = { plotter with direction = newDir }
    printfn "%A" turned
    turned

let move distance plotter =
    let angle = plotter.direction
    let rads = (angle - 90.0) * Math.PI/180.0
    let startX, startY = plotter.position
    let endX = (float startX) + (float distance) * cos rads
    let endY = (float startY) + (float distance) * sin rads
    let moved = drawLine (int endX, int endY) plotter
    printfn "%A" moved
    moved

[<EntryPoint>]
let main argv = 
    use bitmap = new Bitmap(100, 100)

    let initialPlotter = {
        position = (0, 0)
        color = Color.Goldenrod
        direction = 0.0
        bitmap = bitmap }
    
    drawLine (50, 50) initialPlotter |> ignore

    let path = Path.Combine(__SOURCE_DIRECTORY__, "bitmap.png")
    bitmap.Save(path, Imaging.ImageFormat.Png)
    0
