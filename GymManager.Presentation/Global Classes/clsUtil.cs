using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManager.Presentation.Global_Classes
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

            string DestinationFolder = @"C:\GYM_People_Images\";

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





        public static string HashPassword(string Password)
        {
            int iterations = 100000;

            byte[] Salt = new byte[16];

            using (RandomNumberGenerator RNG = RandomNumberGenerator.Create())
            {
                RNG.GetBytes(Salt);
            }

            byte[] Hash;

            using (var PBKDF2 = new Rfc2898DeriveBytes(Password , Salt , iterations , HashAlgorithmName.SHA256))
            {
                Hash = PBKDF2.GetBytes(32);
            }

            return $"{iterations}.{Convert.ToBase64String(Salt)}.{Convert.ToBase64String(Hash)}";
        }



        public static bool VerifyPassword(string Password , string StoredHash)
        {
            string[] Parts = StoredHash.Split('.');

            int iterations = int.Parse(Parts[0]);

            byte[] Salt = Convert.FromBase64String(Parts[1]);
            byte[] OriginalHash = Convert.FromBase64String(Parts[2]);

            byte[] NewHash;

            using (var PBKDF2 = new Rfc2898DeriveBytes(Password, Salt, iterations, HashAlgorithmName.SHA256))
            {
                NewHash = PBKDF2.GetBytes(OriginalHash.Length);
            }

            int Difference = 0;

            for (int i = 0; i < OriginalHash.Length; i++)
            {
                Difference |= OriginalHash[i] ^ NewHash[i];
            }

            return Difference == 0;
        }


    }
}
