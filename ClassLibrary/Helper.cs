using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;

namespace Class_Library
{
    public static class Helper
    {
        public static String GetError(Exception ex)
        {
            return ex.Message.ToString() + " " + ex.InnerException.ToString() + "";
        }

        public static String GetDataDirectory()
        {
            return Convert.ToString(ClassSettings.Default["DataDirectory"]);
        }

        public static String GetImageDirectory()
        {
            return Convert.ToString(ClassSettings.Default["ImageDirectory"]);
        }

        public static void SetQuickPlayOption(Boolean option)
        {
            ClassSettings.Default["QuickPlay"] = Convert.ToBoolean(option);
        }

        public static Boolean GetQuickPlayOption()
        {
            return Convert.ToBoolean(ClassSettings.Default["QuickPlay"]);
        }

        public static Boolean GetObstacleOption()
        {
            return Convert.ToBoolean(ClassSettings.Default["Obstacle"]);
        }

        public static void SetObstacleOption(Boolean option)
        {
            ClassSettings.Default["Obstacle"] = Convert.ToBoolean(option);
        }
        
        public static void SetVenue(Int32 option)
        {
            ClassSettings.Default["Venue"] = Convert.ToInt32(option);
        }

        public static int GetVenue()
        {
            return Convert.ToInt32(ClassSettings.Default["Venue"]);
        }

        public static String[] GetRecentImagesURLs()
        {
            try
            {
                String[] myFiles = new String[9];

                int ptr = 0;
                String ImageDirectory = Convert.ToString(ClassSettings.Default["ImageDirectory"]);
                DirectoryInfo di = new DirectoryInfo(ImageDirectory);
                FileInfo[] rgFiles = di.GetFiles("*.JPG");
                foreach (FileInfo fi in rgFiles)
                {
                    myFiles[ptr] = fi.Name;
                    ptr++;
                    if (ptr > 8)
                        return myFiles;
                }
                return myFiles;
            }
            catch (Exception ex)
            {
                throw new Exception(Helper.GetError(ex));
            }
        }

        public static Image[,] GetRecentImages()
        {
            try
            {
                Image[,] images = new Image[9, 2];
                int ptr = 0;
                String ImageDirectory = Convert.ToString(ClassSettings.Default["ImageDirectory"]);
                DirectoryInfo di = new DirectoryInfo(ImageDirectory);
                FileInfo[] rgFiles = di.GetFiles("*.JPG");
                foreach (FileInfo fi in rgFiles)
                {
                    images[ptr, 0] = GetThumbnail(ImageDirectory + "\\" + fi.Name);
                    images[ptr, 1] = Image.FromFile(ImageDirectory + "\\" + fi.Name);

                    ptr++;
                    if (ptr > 8)
                        return images;
                }
                return images;
            }
            catch (Exception ex)
            {
                throw new Exception(Helper.GetError(ex));
            }

        }

        public static String ResizeImage(string OriginalFile, int NewWidth, int MaxHeight, bool OnlyResizeIfWider)
        {
            try
            {
                Image FullsizeImage = Image.FromFile(OriginalFile);

                // Prevent using images internal thumbnail
                FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
                FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);

                if (OnlyResizeIfWider)
                {
                    if (FullsizeImage.Width <= NewWidth)
                    {
                        NewWidth = FullsizeImage.Width;
                    }
                }

                int NewHeight = FullsizeImage.Height * NewWidth / FullsizeImage.Width;
                if (NewHeight > MaxHeight)
                {
                    // Resize with height instead
                    NewWidth = FullsizeImage.Width * MaxHeight / FullsizeImage.Height;
                    NewHeight = MaxHeight;
                }

                System.Drawing.Image NewImage = FullsizeImage.GetThumbnailImage(NewWidth, NewHeight, null, IntPtr.Zero);

                // Clear handle to original file so that we can overwrite it if necessary
                FullsizeImage.Dispose();

                // Save resized picture
                String FileName = "I_" + System.IO.Path.GetFileName(OriginalFile);
                String FilePath = ClassSettings.Default["ImageDirectory"] + "\\" + FileName;
                NewImage.Save(FilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                return FilePath;
            }
            catch (Exception ex)
            {
                throw new Exception(Helper.GetError(ex));
            }


        }


        public static Image GetThumbnail(string OriginalFile)
        {
            try
            {
                Image FullsizeImage = Image.FromFile(OriginalFile);
                int NewWidth = 50;

                int MaxHeight = 100;
                // Prevent using images internal thumbnail
                FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
                FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);

                int NewHeight = FullsizeImage.Height * NewWidth / FullsizeImage.Width;

                System.Drawing.Image NewImage = FullsizeImage.GetThumbnailImage(NewWidth, NewHeight, null, IntPtr.Zero);

                // Clear handle to original file so that we can overwrite it if necessary
                FullsizeImage.Dispose();
                return NewImage;
            }
            catch (Exception ex)
            {
                throw new Exception(Helper.GetError(ex));
            }


        }
    }

    
}
