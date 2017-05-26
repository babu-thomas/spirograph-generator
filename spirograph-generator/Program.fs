open System.Drawing

[<EntryPoint>]
let main argv = 
    let bitmap = new Bitmap(16, 16)

    let path = __SOURCE_DIRECTORY__ + @"\"

    bitmap.Save(path + "bitmap.png", Imaging.ImageFormat.Png)
    printfn "Hello, World"
    0
