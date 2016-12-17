using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DAL
{
    [XmlRoot("File")]
    public class JokeFileInfo : INotifyPropertyChanged
    {
        public JokeFileInfo()
        {
            Jokes = new List<string>();
            this.CreationDate = DateTime.Now;
        }

        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Title"));
            }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set
            {
                author = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Author"));
            }
        }

        private DateTime creationDate;

        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("CreationDateuthor"));
            }
        }

        private string source;

        public string Source
        {
            get { return source; }
            set { source = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Source"));
            }
        }

        private decimal rating;

        public decimal Rating
        {
            get { return rating; }
            set { rating = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Rating"));
            }
        }

        [XmlArrayItem("Joke")]
        public List<string> Jokes { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }
    }
}