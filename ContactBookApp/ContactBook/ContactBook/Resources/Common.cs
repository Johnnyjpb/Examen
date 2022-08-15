using ContactBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ContactBook.Resources
{
    public class Common
    {
        private static Common _instance = new Common();
        private BookContactDatabaseEntities _Entities;

        public Common()
        {
            _Entities = new BookContactDatabaseEntities();
        }

        public static Common Instance
        {
            get { if (_instance == null) { _instance = new Common(); } return _instance; }
        }

        public BookContactDatabaseEntities Entities
        {
            get { return _Entities; }
            set { if (_Entities != value) { _Entities = value; RaisePropertyChanged("Entities"); } }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

    }
}