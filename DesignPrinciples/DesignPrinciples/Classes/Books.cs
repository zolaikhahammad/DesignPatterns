using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class Books:IBook
    {
        /// <summary>
        /// Using composition
        /// </summary>
        /// 
        public BookPersistence bookPersistence { get; set; }
        public int NumberOfPages { get; set; }
        public string AuthorName { get; set; }
        public Books(int _nopages,string _authorName)
        {
            this.NumberOfPages = _nopages;
            this.AuthorName = _authorName;
            this.bookPersistence = new BookPersistence();

        }
        public void SetNumberOfPages(int numberofPages)
        {
            NumberOfPages = numberofPages;
        }
        public int GetNumberOfPages()
        {
            return NumberOfPages;
        }
        public void SetAuthorName(string _authorName)
        {
            AuthorName = _authorName;
        }
        public string GetAuthorName()
        {
            return AuthorName;
        }

        /// <summary>
        ///sometimes it is not a good idea to use
        ///interfaces because what if we want to save 
        ///the book in xml, pdf format 
        ///then save function will be restricted to this class only
        ///we will use composition in this case
        /// </summary>
        public void Save()
        {
            bookPersistence.Save(this);
        }
        public override string ToString()
        {
            return AuthorName + " - " + NumberOfPages;
        }

        public void Print()
        {
           
        }
    }
}
