open System.Drawing
open System.IO

type Plotter = {
    position: int * int
    color: Color
    direction: float
    bitmap: Bitmap
    }

let turn amount plotter =
    plotter

let move distance plotter =
    plotter

[<EntryPoint>]
let main argv = 
    use bitmap = new Bitmap(16, 16)
    use graphics = Graphics.FromImage(bitmap)
    use redPen = new Pen(Brushes.Red)
    
    graphics.DrawRectangle(redPen, Rectangle(5, 5, 10, 10))

    let path = Path.Combine(__SOURCE_DIRECTORY__, "bitmap.png")
    bitmap.Save(path, Imaging.ImageFormat.Png)
    printfn "Hello, World"
    0
