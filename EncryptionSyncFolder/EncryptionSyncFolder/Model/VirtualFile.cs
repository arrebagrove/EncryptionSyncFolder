// lindexi
// 21:07

using Windows.Storage;
using EncryptionSyncFolder.ViewModel;

namespace EncryptionSyncFolder.Model
{
    /// <summary>
    ///     �����ļ�
    /// </summary>
    public class VirtualFile : NotifyProperty
    {
        public VirtualFile()
        {
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
        ///     �ļ���
        /// </summary>
        public string Name
        {
            set
            {
                _name = value;
                OnPropertyChanged();
            }
            get
            {
                return _name;
            }
        }

        /// <summary>
        ///     �ļ�·��
        /// </summary>
        public string Path
        {
            set
            {
                _path = value;
                OnPropertyChanged();
            }
            get
            {
                return _path;
            }
        }

        /// <summary>
        ///     �ļ���С
        /// </summary>
        public string Size
        {
            set
            {
                _size = value;
                OnPropertyChanged();
            }
            get
            {
                return _size;
            }
        }

        /// <summary>
        ///     ����ʱ��
        /// </summary>
        public string NewTime
        {
            set
            {
                _newTime = value;
                OnPropertyChanged();
            }
            get
            {
                return _newTime;
            }
        }

        private StorageFile _file;
        private string _name;
        private string _newTime;
        private string _path;
        private string _size;
    }
}