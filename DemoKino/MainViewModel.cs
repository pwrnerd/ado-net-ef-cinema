using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKino
{
    public class MainViewModel
    {
        public event EventHandler ModelChanged;

        public MainViewModel(System.Collections.ObjectModel.ObservableCollection<Film> film,
            System.Collections.ObjectModel.ObservableCollection<Vorfuehrung> vorfuehrung,
            System.Collections.ObjectModel.ObservableCollection<Buchung> buchung,
            System.Collections.ObjectModel.ObservableCollection<Saal> saal)
        {
            this.FilmCollection = film;
            this.VorfuehrungCollection = vorfuehrung;
            this.BuchungCollection = buchung;
            this.SaalCollection = saal;

            this.FilmCollection.CollectionChanged += FilmCollection_CollectionChanged;
            this.VorfuehrungCollection.CollectionChanged += VorfuehrungCollection_CollectionChanged;
            this.BuchungCollection.CollectionChanged += BuchungCollection_CollectionChanged;
            this.SaalCollection.CollectionChanged += SaalCollection_CollectionChanged;
        }

        private void SaalCollection_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        private void VorfuehrungCollection_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        private void FilmCollection_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        private void BuchungCollection_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        public System.Collections.ObjectModel.ObservableCollection<Film> FilmCollection { get; set; }
        public System.Collections.ObjectModel.ObservableCollection<Vorfuehrung> VorfuehrungCollection
        {
            get; set;
        }
        public System.Collections.ObjectModel.ObservableCollection<Buchung> BuchungCollection { get; set; }
        public System.Collections.ObjectModel.ObservableCollection<Saal> SaalCollection { get; set; }
    }
}
