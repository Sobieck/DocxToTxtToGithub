

module ConvertFile

open Spire.Doc


    let convertDocument path targetFileName extensionOfFileToConvert = 
        let doc = new Document()
        
        let fileToConvertPath = path + targetFileName + extensionOfFileToConvert
        doc.LoadFromFile(fileToConvertPath)
        

        let txtifiedFilePath = fileToConvertPath.Replace(extensionOfFileToConvert, ".txt")
        doc.SaveToFile(txtifiedFilePath, FileFormat.Txt)