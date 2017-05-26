open System.Drawing
open System.IO

[<EntryPoint>]
let main argv = 
    let bitmap = new Bitmap(16, 16)
    let path = Path.Combine(__SOURCE_DIRECTORY__, "bitmap.png")
    bitmap.Save(path, Imaging.ImageFormat.Png)
    printfn "Hello, World"
    0
