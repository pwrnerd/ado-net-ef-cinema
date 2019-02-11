using DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tortuga.Anchor.Collections;

namespace DemoKino
{
    public class MainViewModel
    {
        public event EventHandler ModelChanged;

        private DAO.DAO mDao = null;

        public MainViewModel(DAO.DAO dao)
        {
            this.FilmCollection = new ObservableCollectionExtended<Film>(dao.mKino.Film.Local.ToList());
            this.VorfuehrungCollection = new ObservableCollectionExtended<Vorfuehrung>(dao.mKino.Vorfuehrung.Local.ToList());
            this.BuchungCollection = new ObservableCollectionExtended<Buchung>(dao.mKino.Buchung.Local.ToList());
            this.SaalCollection = new ObservableCollectionExtended<Saal>(dao.mKino.Saal.Local.ToList());

            this.mDao = dao;

            this.FilmCollection.ItemAdded += FilmCollection_ItemAdded;
            this.FilmCollection.ItemPropertyChanged += FilmCollection_ItemPropertyChanged;
            this.FilmCollection.ItemRemoved += FilmCollection_ItemRemoved;
            this.VorfuehrungCollection.ItemAdded += VorfuehrungCollection_ItemAdded;
            this.VorfuehrungCollection.ItemPropertyChanged += VorfuehrungCollection_ItemPropertyChanged;
            this.VorfuehrungCollection.ItemRemoved += VorfuehrungCollection_ItemRemoved;
            this.BuchungCollection.ItemAdded += BuchungCollection_ItemAdded;
            this.BuchungCollection.ItemPropertyChanged += BuchungCollection_ItemPropertyChanged;
            this.BuchungCollection.ItemRemoved += BuchungCollection_ItemRemoved;
            this.SaalCollection.ItemAdded += SaalCollection_ItemAdded;
            this.SaalCollection.ItemPropertyChanged += SaalCollection_ItemPropertyChanged;
            this.SaalCollection.ItemRemoved += SaalCollection_ItemRemoved;

            this.FilmCollection.CollectionChanged += FilmCollection_CollectionChanged;
            this.VorfuehrungCollection.CollectionChanged += VorfuehrungCollection_CollectionChanged;
            this.BuchungCollection.CollectionChanged += BuchungCollection_CollectionChanged;
            this.SaalCollection.CollectionChanged += SaalCollection_CollectionChanged;

            this.FilmCollection.PropertyChanged += FilmCollection_PropertyChanged;
            this.VorfuehrungCollection.PropertyChanged += VorfuehrungCollection_PropertyChanged;
            this.BuchungCollection.PropertyChanged += BuchungCollection_PropertyChanged;
            this.SaalCollection.PropertyChanged += SaalCollection_PropertyChanged;
        }

        private void SaalCollection_ItemRemoved(object sender, Tortuga.Anchor.ComponentModel.ItemEventArgs<Saal> e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        private void SaalCollection_ItemPropertyChanged(object sender, Tortuga.Anchor.Eventing.RelayedEventArgs<System.ComponentModel.PropertyChangedEventArgs> e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        private void SaalCollection_ItemAdded(object sender, Tortuga.Anchor.ComponentModel.ItemEventArgs<Saal> e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        private void BuchungCollection_ItemRemoved(object sender, Tortuga.Anchor.ComponentModel.ItemEventArgs<Buchung> e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        private void BuchungCollection_ItemPropertyChanged(object sender, Tortuga.Anchor.Eventing.RelayedEventArgs<System.ComponentModel.PropertyChangedEventArgs> e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
            if (e.EventArgs.PropertyName == "VorfuehrungID")
            {
                Buchung buchung = e.OriginalSender as Buchung;
                if (buchung.Vorfuehrung == null)
                    buchung.Vorfuehrung = this.VorfuehrungCollection.Where(o => o.ID == buchung.VorfuehrungID).FirstOrDefault<Vorfuehrung>();
                if (buchung.Vorfuehrung.Buchung.Contains(buchung))
                    buchung.Vorfuehrung.Buchung.Remove(buchung);
                buchung.Vorfuehrung = this.VorfuehrungCollection.Where(o => o.ID == buchung.VorfuehrungID).FirstOrDefault<Vorfuehrung>();
                buchung.Vorfuehrung.Buchung.Add(buchung);
            }
        }

        private void BuchungCollection_ItemAdded(object sender, Tortuga.Anchor.ComponentModel.ItemEventArgs<Buchung> e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        private void VorfuehrungCollection_ItemRemoved(object sender, Tortuga.Anchor.ComponentModel.ItemEventArgs<Vorfuehrung> e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        private void VorfuehrungCollection_ItemPropertyChanged(object sender, Tortuga.Anchor.Eventing.RelayedEventArgs<System.ComponentModel.PropertyChangedEventArgs> e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        private void VorfuehrungCollection_ItemAdded(object sender, Tortuga.Anchor.ComponentModel.ItemEventArgs<Vorfuehrung> e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        private void FilmCollection_ItemRemoved(object sender, Tortuga.Anchor.ComponentModel.ItemEventArgs<Film> e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        private void FilmCollection_ItemPropertyChanged(object sender, Tortuga.Anchor.Eventing.RelayedEventArgs<System.ComponentModel.PropertyChangedEventArgs> e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        private void FilmCollection_ItemAdded(object sender, Tortuga.Anchor.ComponentModel.ItemEventArgs<Film> e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        private void SaalCollection_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        private void BuchungCollection_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        private void VorfuehrungCollection_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        private void FilmCollection_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            ModelChanged?.Invoke(this, new EventArgs());
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

        public ObservableCollectionExtended<Film> FilmCollection { get; set; }
        public ObservableCollectionExtended<Vorfuehrung> VorfuehrungCollection { get; set; }
        public ObservableCollectionExtended<Buchung> BuchungCollection { get; set; }        
        public ObservableCollectionExtended<Saal> SaalCollection { get; set; }

        public void Save()
        {
            ValidateBuchung(true);
            // Overwrite Modified Items (Buchung)
            foreach (Buchung buchung in BuchungCollection)
            {
                Buchung dbitem = mDao.mKino.Buchung.Where(o => o.ID == buchung.ID).FirstOrDefault<Buchung>();
                if (dbitem.Email != buchung.Email || dbitem.Name != buchung.Name || dbitem.PlatzNr != buchung.PlatzNr || dbitem.VorfuehrungID != buchung.VorfuehrungID)
                {
                    SetBuchungItem(dbitem, buchung);
                }
            }
            // Added items
            foreach (Buchung buchung in BuchungCollection)
            {
                Buchung dbitem = mDao.mKino.Buchung.Where(o => o.ID == buchung.ID).FirstOrDefault<Buchung>();
                if (dbitem == null)
                {
                    mDao.mKino.Buchung.Add(buchung);
                }
            }
            // Removed items
            List<Buchung> delItemsB = new List<Buchung>();
            foreach (Buchung dbitem in mDao.mKino.Buchung)
            {
                Buchung buchung = BuchungCollection.Where(o => o.ID == dbitem.ID).FirstOrDefault<Buchung>();
                if (buchung == null)
                {
                    delItemsB.Add(dbitem);
                }
            }
            foreach (Buchung delItem in delItemsB)
            {
                mDao.mKino.Buchung.Remove(delItem);
            }

            // Overwrite Modified Items (Vorfuehrung)
            foreach (Vorfuehrung vorfuehrung in VorfuehrungCollection)
            {
                Vorfuehrung dbitem = mDao.mKino.Vorfuehrung.Where(o => o.ID == vorfuehrung.ID).FirstOrDefault<Vorfuehrung>();
                if (dbitem.Bezeichnung != vorfuehrung.Bezeichnung || dbitem.Datum != vorfuehrung.Datum || dbitem.FilmID != vorfuehrung.FilmID || dbitem.SaalID != vorfuehrung.SaalID)
                {
                    SetVorfuehrungItem(dbitem, vorfuehrung);
                }
            }
            // Added items
            foreach (Vorfuehrung vorfuehrung in VorfuehrungCollection)
            {
                Vorfuehrung dbitem = mDao.mKino.Vorfuehrung.Where(o => o.ID == vorfuehrung.ID).FirstOrDefault<Vorfuehrung>();
                if (dbitem == null)
                {
                    mDao.mKino.Vorfuehrung.Add(vorfuehrung);
                }
            }
            // Removed items
            List<Vorfuehrung> delItemsV = new List<Vorfuehrung>();
            foreach (Vorfuehrung dbitem in mDao.mKino.Vorfuehrung)
            {
                Vorfuehrung vorfuehrung = VorfuehrungCollection.Where(o => o.ID == dbitem.ID).FirstOrDefault<Vorfuehrung>();
                if (vorfuehrung == null)
                {
                    delItemsV.Add(dbitem);
                }
            }
            foreach (Vorfuehrung delItem in delItemsV)
            {
                mDao.mKino.Vorfuehrung.Remove(delItem);
            }

            // Overwrite Modified Items
            foreach (Saal saal in SaalCollection)
            {
                Saal dbitem = mDao.mKino.Saal.Where(o => o.ID == saal.ID).FirstOrDefault<Saal>();
                if ((dbitem.AnzahlPlaetze != saal.AnzahlPlaetze) || dbitem.Bezeichnung != saal.Bezeichnung || dbitem.Dreidimensional != saal.Dreidimensional)
                {
                    SetSaalItem(dbitem, saal);
                }
            }
            // Added items
            foreach (Saal saal in SaalCollection)
            {
                Saal dbitem = mDao.mKino.Saal.Where(o => o.ID == saal.ID).FirstOrDefault<Saal>();
                if (dbitem == null)
                {
                    mDao.mKino.Saal.Add(saal);
                }
            }
            // Removed items
            List<Saal> delItemsS = new List<Saal>();
            foreach (Saal dbitem in mDao.mKino.Saal)
            {
                Saal saal = SaalCollection.Where(o => o.ID == dbitem.ID).FirstOrDefault<Saal>();
                if (saal == null)
                {
                    delItemsS.Add(dbitem);
                }
            }
            foreach (Saal delItem in delItemsS)
            {
                mDao.mKino.Saal.Remove(delItem);
            }

            // Overwrite Modified Items (Film)
            foreach (Film film in FilmCollection)
            {
                Film dbitem = mDao.mKino.Film.Where(o => o.ID == film.ID).FirstOrDefault<Film>();
                if (dbitem.Bezeichnung != film.Bezeichnung || dbitem.Dauer != film.Dauer || dbitem.FSK18 != film.FSK18 || dbitem.Preis != film.Preis)
                {
                    SetFilmItem(dbitem, film);
                }
            }
            // Added items
            foreach (Film film in FilmCollection)
            {
                Film dbitem = mDao.mKino.Film.Where(o => o.ID == film.ID).FirstOrDefault<Film>();
                if (dbitem == null)
                {
                    mDao.mKino.Film.Add(film);
                }
            }
            // Removed items
            List<Film> delItemsF = new List<Film>();
            foreach (Film dbitem in mDao.mKino.Film)
            {
                Film film = FilmCollection.Where(o => o.ID == dbitem.ID).FirstOrDefault<Film>();
                if (film == null)
                {
                    delItemsF.Add(dbitem);
                }
            }
            foreach (Film delItem in delItemsF)
            {
                mDao.mKino.Film.Remove(delItem);
            }
            mDao.Save();
        }

        private void SetFilmItem(Film dbitem, Film film)
        {
            dbitem.Bezeichnung = film.Bezeichnung;
            dbitem.Dauer = film.Dauer;
            dbitem.FSK18 = film.FSK18;
            dbitem.Preis = film.Preis;
        }

        private void SetBuchungItem(Buchung dbitem, Buchung buchung)
        {
            dbitem.Email = buchung.Email;
            dbitem.Name = buchung.Name;
            dbitem.PlatzNr = buchung.PlatzNr;
            dbitem.VorfuehrungID = buchung.VorfuehrungID;
        }

        private void SetVorfuehrungItem(Vorfuehrung dbitem, Vorfuehrung vorfuehrung)
        {
            dbitem.Bezeichnung = vorfuehrung.Bezeichnung;
            dbitem.Datum = vorfuehrung.Datum;
            dbitem.FilmID = vorfuehrung.FilmID;
            dbitem.SaalID = vorfuehrung.SaalID;
        }

        private void SetSaalItem(Saal dbitem, Saal saal)
        {
            dbitem.AnzahlPlaetze = saal.AnzahlPlaetze;
            dbitem.Bezeichnung = saal.Bezeichnung;
            dbitem.Dreidimensional = saal.Dreidimensional;
        }

        public bool ValidateBuchung(bool resolveProblems = false)
        {
            Dictionary<long, Guid> dblbookingcheck = new Dictionary<long, Guid>();

            List<DAO.Buchung> listToResolve = new List<Buchung>();

            IEnumerable<DAO.Buchung> listWithoutVF = this.BuchungCollection.Where(x => x.VorfuehrungID == null);
            if (resolveProblems)
            {
                listToResolve.AddRange(listWithoutVF);
            }
            else
            {
                return false;
            }

            foreach (Vorfuehrung vf in this.VorfuehrungCollection)
            {
                dblbookingcheck.Clear();
                foreach (DAO.Buchung buchung in vf.Buchung)
                {
                    if (buchung.PlatzNr > vf.Saal.AnzahlPlaetze)
                    {
                        // Seat Nr too high
                        if (resolveProblems)
                        {
                            listToResolve.Add(buchung);
                            continue;
                        }
                        else
                        {
                            return false;
                        }                        
                    }
                    if (dblbookingcheck.ContainsKey(buchung.PlatzNr))
                    {
                        // Double booking in Seat Nr
                        if (resolveProblems)
                        {
                            listToResolve.Add(buchung);
                            continue;
                        }
                        else
                        {
                            return false;
                        }                        
                    }
                    dblbookingcheck.Add(buchung.PlatzNr, buchung.ID);
                }
            }

            if (resolveProblems)
            {
                foreach (DAO.Buchung buchung in listToResolve)
                {
                    this.BuchungCollection.Remove(buchung);
                }
                if (listToResolve.Count() > 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
