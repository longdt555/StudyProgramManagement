using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lib.Common;

namespace SPM.Helpers
{
    public static class FileHandling
    {
        //public static List<AttachmentJs> GetFileUpload(IEnumerable<HttpPostedFileBase> attachment)
        //{
        //    var result = new List<AttachmentJs>();
        //    // The Name of the Upload component is "files"
        //    if (attachment != null)
        //    {
        //        foreach (var file in attachment)
        //        {
        //            //check if file exist and rename
        //            var dir = System.IO.Directory.CreateDirectory(System.Configuration.ConfigurationManager.AppSettings["UploadFolder"]);
        //            string newFileName = file.FileName;
        //            var path = Path.Combine(dir.FullName, newFileName);
        //            var index = 0;
        //            {
        //                string fName = Path.GetFileNameWithoutExtension(file.FileName);
        //                string fExt = Path.GetExtension(file.FileName);
        //                newFileName = String.Concat(fName, string.Format("_{0}", index), fExt);
        //                path = Path.Combine(dir.FullName, newFileName);
        //                index++;
        //            }
        //            file.SaveAs(path);
        //            result.Add(new AttachmentJs()
        //            {
        //                Id = 0,
        //                Realname = newFileName,
        //                Name = file.FileName,
        //                Extension = Path.GetExtension(file.FileName),
        //                Size = file.ContentLength,
        //                CreatedDate = DateTime.Now.ToString("yyyy-MM-dd"),
        //            });
        //        }
        //    }
        //    return result;
        //}
        //public static List<AttachmentJs> GetImageUpload(PhotoAlbumViewModel model)
        //{
        //    var result = new List<AttachmentJs>();
        //    // The Name of the Upload component is "files"
        //    if (model.Files != null)
        //    {
        //        foreach (var file in model.Files)
        //        {
        //            //check if file exist and rename
        //            var dir = HttpContext.Current.ApplicationInstance.Server.MapPath("~/Content/images/bills/");
        //            string fExt = Path.GetExtension(file.FileName);
        //            string fileName = model.TimeStamp + file.FileName.ToString();
        //            var path = Path.Combine(dir, fileName);
        //            file.SaveAs(path);
        //            result.Add(new AttachmentJs()
        //            {
        //                Realname = fileName
        //            });
        //        }
        //    }
        //    return result;
        //}
        //public static List<AttachmentJs> GetImageUpload(IEnumerable<HttpPostedFileBase> attachment)
        //{
        //    var result = new List<AttachmentJs>();
        //    // The Name of the Upload component is "files"
        //    if (attachment != null)
        //    {
        //        foreach (var file in attachment)
        //        {
        //            //check if file exist and rename
        //            var dir = HttpContext.Current.ApplicationInstance.Server.MapPath("~/Content/images/bills/");
        //            string fExt = Path.GetExtension(file.FileName);
        //            string fileName = file.FileName.ToString();
        //            var path = Path.Combine(dir, fileName);
        //            file.SaveAs(path);
        //            result.Add(new AttachmentJs()
        //            {
        //                Realname = fileName
        //            });
        //        }
        //    }
        //    return result;
        //}
        //public static List<AttachmentJs> SaveFile(IEnumerable<HttpPostedFileBase> attachment)
        //{
        //    var result = new List<AttachmentJs>();
        //    // The Name of the Upload component is "files"
        //    if (attachment != null)
        //    {
        //        foreach (var file in attachment)
        //        {
        //            //check if file exist and rename
        //            var dir = System.IO.Directory.CreateDirectory(System.Configuration.ConfigurationManager.AppSettings["UploadFolder"]);
        //            string fExt = Path.GetExtension(file.FileName);
        //            string fileName = (Guid.NewGuid() + fExt).ToString();
        //            var path = Path.Combine(dir.FullName, fileName);
        //            file.SaveAs(path);
        //            result.Add(new AttachmentJs()
        //            {
        //                Realname = fileName,
        //                Name = file.FileName,
        //                Size = file.ContentLength
        //            });
        //        }
        //    }
        //    return result;
        //}
        //public static bool RemoveFileUpload(string realName)
        //{
        //    bool isSuccess = false;
        //    if (!string.IsNullOrEmpty(realName))
        //    {
        //        var dir = System.Configuration.ConfigurationManager.AppSettings["UploadFolder"].Replace("\\", "/");
        //        var path = Path.Combine(dir, realName);
        //        if (System.IO.File.Exists(path))
        //        {
        //            System.IO.File.Delete(path);
        //            isSuccess = true;
        //        }
        //    }
        //    return isSuccess;
        //}
        //public static string ReadFileByPath(string name)
        //{
        //    String file = string.Empty;
        //    var path = System.Web.HttpContext.Current.ApplicationInstance.Server.MapPath("~/Content/images/avatar/") + "\\" + name.ToString();
        //    if (!string.IsNullOrEmpty(name))
        //    {
        //        var extension = name.Substring(name.LastIndexOf('.'), name.Count() - name.LastIndexOf('.'));
        //        var fileName = name.Substring(0, name.LastIndexOf('.'));
        //        try
        //        {
        //            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
        //            byte[] filebytes = new byte[fs.Length];
        //            fs.Read(filebytes, 0, Convert.ToInt32(fs.Length));
        //            file = string.Format("data:image/{0};base64, " + Convert.ToBase64String(filebytes, Base64FormattingOptions.InsertLineBreaks), extension.ToLower());
        //        }
        //        catch (Exception)
        //        {
        //            return null;
        //        }

        //    }
        //    return file;
        //}
    }
}
