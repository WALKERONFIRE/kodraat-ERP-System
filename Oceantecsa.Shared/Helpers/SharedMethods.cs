using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.Helpers
{
    public static class SharedMethods
    {
        public static string GetFileContent(string filePath)
        {
            return System.IO.File.ReadAllText(filePath, Encoding.UTF8);

        }

        public static string AttachmentSize(decimal size)
        {
            if (size < 1)
            {
                var sizeInKB = Math.Round(size * 1000);
                return String.Concat(sizeInKB, "KB");
            }
            else
            {
                return String.Concat(Math.Round(size), "MB");
            }
        }

        public static string ThumbnailType(string extension)
        {
            if (extension.ToLower() == "png" || extension.ToLower() == "jpg" || extension.ToLower() == "bmp" || extension.ToLower() == "jpeg" || extension.ToLower() == "gif" || extension.ToLower() == "tiff" || extension.ToLower() == "svg")
            {
                return "Image";
            }

            if (extension.ToLower() == "pdf" || extension.ToLower() == "csv")
            {
                return "File";
            }
            return "Video";
        }

        public static string GetAttachmentType(string extension)
        {
            var type = extension.ToLower() == "png" ||
                       extension.ToLower() == "jpg" ||
                       extension.ToLower() == "bmp" ||
                       extension.ToLower() == "jpeg" ||
                       extension.ToLower() == "gif" ||
                       extension.ToLower() == "tiff" ||
                       extension.ToLower() == "svg"
                ? "Image"
                : "File";
            return type;
        }
    }
}
