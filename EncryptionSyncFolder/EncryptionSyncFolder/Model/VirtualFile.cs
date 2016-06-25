// lindexi
// 21:07

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

      
        private StorageFile _file;
       
    }
}