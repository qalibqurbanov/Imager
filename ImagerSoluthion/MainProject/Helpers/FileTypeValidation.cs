using System.IO;

namespace MainForm.Helpers
{
    public static class FileTypeValidation
    {
        /// <summary>
        /// CheckFileExtension() : Suruklenib buraxilan fayl icaze verilen extensiona sahibdirmi ve ya suruklenib buraxilan folderdirmi?
        /// </summary>
        /// <param name="FullFileName">Fayl ve ya Folder oldugu yoxlanilan obyekt.</param>
        /// <param name="enableDirectory">Folder oldugu yoxlanilsin?</param>
        /// <returns>bool : Eger suruklenib buraxilan folderdirse ve ya icaze verilen extensiona sahib fayl suruklenib buraxilibsa TRUE donecek. Desteklenmeyen fayl suruklenib buraxilsa FALSE dondurecek</returns>
        public static bool CheckFileExtension(string FullFileName, bool enableDirectory)
        {
            if (enableDirectory)
            {
                if (FullFileName.EndsWith(".jpg")   ||
                     FullFileName.EndsWith(".jpeg") ||
                     FullFileName.EndsWith(".png")  ||
                     FullFileName.EndsWith(".bmp")  ||
                     FullFileName.EndsWith(".gif")  ||
                     FullFileName.EndsWith(".tif")  ||
                     FullFileName.EndsWith(".webp") ||
                     FullFileName.EndsWith(".heic") ||
                     FullFileName.EndsWith(".pdf")  || Directory.Exists(FullFileName))
                {
                    return true;
                }
                else { return false; }
            }
            else
            {
                if (FullFileName.EndsWith(".jpg")  ||
                    FullFileName.EndsWith(".jpeg") ||
                    FullFileName.EndsWith(".png")  ||
                    FullFileName.EndsWith(".bmp")  ||
                    FullFileName.EndsWith(".gif")  ||
                    FullFileName.EndsWith(".tif")  ||
                    FullFileName.EndsWith(".webp") ||
                    FullFileName.EndsWith(".heic") ||
                    FullFileName.EndsWith(".pdf"))
                {
                    return true;
                }
                else { return false; }
            }
        }
    }
}