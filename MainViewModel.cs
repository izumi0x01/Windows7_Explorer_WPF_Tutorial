using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace Windows7_Explorer_WPF_Tutorial
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            ObservableCollection<File> files = new ObservableCollection<File>();

            files.Add(new File() { Name = "banana.png", ImageSize = "256 × 256", Type = "PNG イメージ", Size = "256 KB", CreateDate = "20XX/XX/XX XX:XX" });
            files.Add(new File() { Name = "cherry.png", ImageSize = "256 × 256", Type = "PNG イメージ", Size = "256 KB", CreateDate = "20XX/XX/XX XX:XX" });
            files.Add(new File() { Name = "apple.png", ImageSize = "256 × 256", Type = "PNG イメージ", Size = "256 KB", CreateDate = "20XX/XX/XX XX:XX" });
            files.Add(new File() { Name = "cherry.png", ImageSize = "256 × 256", Type = "PNG イメージ", Size = "256 KB", CreateDate = "20XX/XX/XX XX:XX" });
            files.Add(new File() { Name = "pineapple.png", ImageSize = "256 × 256", Type = "PNG イメージ", Size = "256 KB", CreateDate = "20XX/XX/XX XX:XX" });
            files.Add(new File() { Name = "apple.png", ImageSize = "256 × 256", Type = "PNG イメージ", Size = "256 KB", CreateDate = "20XX/XX/XX XX:XX" });
            files.Add(new File() { Name = "banana.png", ImageSize = "256 × 256", Type = "PNG イメージ", Size = "256 KB", CreateDate = "20XX/XX/XX XX:XX" });
            files.Add(new File() { Name = "pineapple.png", ImageSize = "256 × 256", Type = "PNG イメージ", Size = "256 KB", CreateDate = "20XX/XX/XX XX:XX" });

            Files = files;
            SelectedFile = files[0];
        }

        public ObservableCollection<File> Files { get; set; }
        private File selectedFile;
        public File SelectedFile
        {
            get
            {
                return selectedFile;
            }
            set
            {
                selectedFile = value;
                NotifyPropertyChanged("SelectedFile");
            }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion
    }
}
