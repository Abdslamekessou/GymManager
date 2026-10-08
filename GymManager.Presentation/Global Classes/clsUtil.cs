using System;
using System.Data;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;



namespace Globla_Classes
{
    internal class clsUtil
    {

        public static string GenerateGUID()
        {

            // Generate a new GUID
            Guid newGuid = Guid.NewGuid();

            // convert the GUID to a string
            return newGuid.ToString();

        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {

            // Check if the folder exists
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    // If it doesn't exist, create the folder
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;

        }

        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            // Full file name. Change your file name   
            string fileName = sourceFile;
            FileInfo fi = new FileInfo(fileName);
            string extn = fi.Extension;
            return GenerateGUID() + extn;

        }

        public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
        {
            // this funciton will copy the image to the
            // project images foldr after renaming it
            // with GUID with the same extention, then it will update the sourceFileName with the new name.

            string DestinationFolder = @"E:\Images";
            if (!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);

            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFile = destinationFile;
            return true;
        }

        //For Gym Project
        internal static bool GenerateAndSaveExcelFile(DataTable dt, string fullPath)
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                // ==========================================
                // 1. Create worksheet
                // ==========================================

                IXLWorksheet worksheet =
                    workbook.Worksheets.Add("Notifications");


                // ==========================================
                // 2. Add title
                // ==========================================

                worksheet.Cell("A1").Value = "GYM - Notifications";

                worksheet.Range("A1:K1").Merge();

                worksheet.Range("A1:K1").Style.Font.Bold = true;

                worksheet.Range("A1:K1").Style.Font.FontSize = 16;

                worksheet.Range("A1:K1").Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center;

                worksheet.Range("A1:K1").Style.Alignment.Vertical =
                    XLAlignmentVerticalValues.Center;

                worksheet.Range("A1:K1").Style.Fill.BackgroundColor =
                    XLColor.DarkBlue;

                worksheet.Range("A1:K1").Style.Font.FontColor =
                    XLColor.White;

                worksheet.Row(1).Height = 30;


                // ==========================================
                // 3. Insert DataTable as Excel Table
                // ==========================================

                var table = worksheet.Cell("A3")
                                      .InsertTable(
                                          dt,
                                          "NotificationTable",
                                          true);


                // ==========================================
                // 4. Style the Header
                // ==========================================

                IXLRangeRow header = table.HeadersRow();

                header.Style.Font.Bold = true;

                header.Style.Font.FontColor = XLColor.White;

                header.Style.Fill.BackgroundColor =
                    XLColor.DarkBlue;

                header.Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center;

                header.Style.Alignment.Vertical =
                    XLAlignmentVerticalValues.Center;


                // ==========================================
                // 5. Style the Data
                // ==========================================

                var dataRange = table.DataRange;

                dataRange.Style.Alignment.Vertical =
                    XLAlignmentVerticalValues.Center;

                dataRange.Style.Border.InsideBorder =
                    XLBorderStyleValues.Thin;

                dataRange.Style.Border.OutsideBorder =
                    XLBorderStyleValues.Thin;


                // ==========================================
                // 6. Center columns
                // ==========================================

                // C = Numéro de Téléphone
                worksheet.Column("C").Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center;

                // D = Sport
                worksheet.Column("D").Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center;

                // E = Type d'Abonnement
                worksheet.Column("E").Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center;

                // F = DateDebut
                worksheet.Column("F").Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center;

                // G = DateFin
                worksheet.Column("G").Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center;

                // H = Status d'Abonnement
                worksheet.Column("H").Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center;

                // I = Lu Status
                worksheet.Column("I").Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center;

                // J = Exportation
                worksheet.Column("J").Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center;


                // ==========================================
                // 7. Format dates
                // ==========================================

                worksheet.Column("F").Style.DateFormat.Format =
                    "dd/MM/yyyy";

                worksheet.Column("G").Style.DateFormat.Format =
                    "dd/MM/yyyy";


                // ==========================================
                // 8. Message column
                // ==========================================

                // K = Message
                worksheet.Column("K").Style.Alignment.WrapText = true;

                worksheet.Column("K").Width = 40;


                // ==========================================
                // 9. Adjust column widths
                // ==========================================

                worksheet.Columns().AdjustToContents();

                worksheet.Column("A").Width = 15; // NotificationID
                worksheet.Column("B").Width = 25; // Adhérent
                worksheet.Column("C").Width = 20; // Numéro de Téléphone
                worksheet.Column("D").Width = 18; // Sport
                worksheet.Column("E").Width = 25; // Type d'Abonnement
                worksheet.Column("F").Width = 15; // DateDebut
                worksheet.Column("G").Width = 15; // DateFin
                worksheet.Column("H").Width = 22; // Status d'Abonnement
                worksheet.Column("I").Width = 15; // Lu Status
                worksheet.Column("J").Width = 18; // Exportation
                worksheet.Column("K").Width = 40; // Message


                // ==========================================
                // 10. Adjust row heights
                // ==========================================

                worksheet.Rows().AdjustToContents();

                worksheet.Row(1).Height = 30;


                // ==========================================
                // 11. Freeze the header
                // ==========================================

                worksheet.SheetView.FreezeRows(3);


                // ==========================================
                // 12. Save the Excel file
                // ==========================================

                workbook.SaveAs(fullPath);

                // Check whether the file exists
                return File.Exists(fullPath);
            }
        }
    }
}
