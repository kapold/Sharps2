using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Command
{
    class ApplicationsViewModel
    {
        private RelayCommand addBook;

        public RelayCommand AddBook
        {
            get
            {
                return addBook ?? (addBook = new RelayCommand(obj =>
                {
                    BookAddForm.AddBook create = new BookAddForm.AddBook(MainWindow.mainForm.languagePath);
                    create.Show();
                }));
            }
        }

        private RelayCommand searchBook;

        public RelayCommand SearchBook
        {
            get
            {
                return searchBook ?? (searchBook = new RelayCommand(obj =>
                {
                    Search.Search search = new Search.Search(MainWindow.mainForm.languagePath);
                    search.Show();
                }));
            }
        }

        private RelayCommand searchByName;

        public RelayCommand SearchByName
        {
            get
            {
                return searchByName ?? (searchByName = new RelayCommand(obj =>
                {
                    SearchNameWnd.SearchName searchN = new SearchNameWnd.SearchName(MainWindow.mainForm.languagePath);
                    searchN.Show();
                }));
            }
        }

        private RelayCommand saveInXML;
        public RelayCommand SaveInXML
        {
            get
            {
                return saveInXML ?? (saveInXML = new RelayCommand(obj =>
                {
                    MainWindow.mainForm.SaveInXML();
                }));
            }
        }

        private RelayCommand loadFromXML;
        public RelayCommand LoadFromXML
        {
            get
            {
                return loadFromXML ?? (loadFromXML = new RelayCommand(obj =>
                {
                    MainWindow.mainForm.LoadFromXML();
                }));
            }
        }

        private RelayCommand switchLanguageRussian;
        public RelayCommand SwitchLanguageRussian
        {
            get
            {
                return switchLanguageRussian ?? (switchLanguageRussian = new RelayCommand(obj =>
                {
                    MainWindow.mainForm.SwitchLanguageRussian();
                }));
            }
        }

        private RelayCommand switchLanguageEng;
        public RelayCommand SwitchLanguageEng
        {
            get
            {
                return switchLanguageEng ?? (switchLanguageEng = new RelayCommand(obj =>
                {
                    MainWindow.mainForm.SwitchLanguageEng();
                }));
            }
        }

        private RelayCommand switchCornsilkStyle;
        public RelayCommand SwitchCornsilkStyle
        {
            get
            {
                return switchCornsilkStyle ?? (switchCornsilkStyle = new RelayCommand(obj =>
                {
                    MainWindow.mainForm.SetCornsilkStyle();
                }));
            }
        }

        private RelayCommand switchBlackStyle;
        public RelayCommand SwitchBlackStyle
        {
            get
            {
                return switchBlackStyle ?? (switchBlackStyle = new RelayCommand(obj =>
                {
                    MainWindow.mainForm.SetBlackStyle();
                }));
            }
        }

        private RelayCommand priceSort;
        public RelayCommand PriceSort
        {
            get
            {
                return priceSort ?? (priceSort = new RelayCommand(obj =>
                {
                    MainWindow.mainForm.PriceSort();
                }));

            }
        }

        private RelayCommand countSort;
        public RelayCommand CountSort
        {
            get
            {
                return countSort ?? (countSort = new RelayCommand(obj =>
                {
                    MainWindow.mainForm.CountSort();
                }));

            }
        }

        private RelayCommand redoButton;

        public RelayCommand RedoButton
        {
            get
            {
                return redoButton ?? (redoButton = new RelayCommand(obj =>
                {
                    MainWindow.mainForm.RedoB();
                }));
            }
        }

        private RelayCommand undoButton;

        public RelayCommand UndoButton
        {
            get
            {
                return undoButton ?? (undoButton = new RelayCommand(obj =>
                {
                    MainWindow.mainForm.UndoB();
                }));
            }
        }

        private RelayCommand openUserControl;

        public RelayCommand OpenUserControl
        {
            get
            {
                return openUserControl ?? (openUserControl = new RelayCommand(obj =>
                {
                    RandomBook randomBook = new RandomBook();
                    randomBook.Show();
                }));
            }
        }
    }
}
