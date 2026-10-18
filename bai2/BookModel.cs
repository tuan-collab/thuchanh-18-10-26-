using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BookManagement
{
    public class BookModel : INotifyPropertyChanged
    {
        private string _bookId;
        private string _title;
        private string _author;
        private string _category;
        private decimal _price;
        private int _quantity;
        private string _coverPath;

        public string BookId
        {
            get => _bookId;
            set { _bookId = value; OnPropertyChanged(); }
        }

        public string Title
        {
            get => _title;
            set { _title = value; OnPropertyChanged(); }
        }

        public string Author
        {
            get => _author;
            set { _author = value; OnPropertyChanged(); }
        }

        public string Category
        {
            get => _category;
            set { _category = value; OnPropertyChanged(); }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(TotalValue));
            }
        }

        public int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(TotalValue));
            }
        }

        public string CoverPath
        {
            get => _coverPath;
            set { _coverPath = value; OnPropertyChanged(); }
        }

        // Property tính tổng giá trị của đầu sách đó (Đơn giá * Số lượng)
        public decimal TotalValue => Price * Quantity;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}