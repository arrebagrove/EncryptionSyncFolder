// lindexi
// 21:07

using System.Collections.Generic;
using System.Linq;
using Windows.Storage;

namespace EncryptionSyncFolder.Model
{
    /// <summary>
    ///     �����ļ�
    /// </summary>
    public class VirtualFile : VirtualStorage
    {
        public VirtualFile()
        {
            VirtualFileFolder=VirtualFileFolderEnum.File;
        }

        public StorageFile File
        {
            set
            {
                _file = value;
                OnPropertyChanged();
            }
            get
            {
                return _file;
            }
        }
        /// <summary>
        /// �ַ��������ļ���
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool AreFileName(string str)
        {
            List<string> notStr=new List<string>()
            {
                "\\",
                "/",
                ":",
                "?",
                "\"",
                "<",
                ">",
                "|"
            };

            //foreach (var temp in notStr)
            //{
            //    if (str.IndexOf(temp) > -1)
            //    {
            //        return false;
            //    }
            //}
            //return true;
            return notStr.All(temp => str.IndexOf(temp) <= -1);
        }

        private StorageFile _file;
       
    }
}