//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;using System.ComponentModel;
    using System.Collections.Generic;
    
    public partial class Film : INotifyPropertyChanged
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Film()
        {
            this.Vorfuehrung = new HashSet<Vorfuehrung>();
        }
    
        private System.Guid _ID; public System.Guid ID { get{ return _ID;} set{ if (_ID != value){ _ID = value; OnPropertyChanged("ID");} } }
        private string _Bezeichnung; public string Bezeichnung { get{ return _Bezeichnung;} set{ if (_Bezeichnung != value){ _Bezeichnung = value; OnPropertyChanged("Bezeichnung");} } }
        private decimal _Dauer; public decimal Dauer { get{ return _Dauer;} set{ if (_Dauer != value){ _Dauer = value; OnPropertyChanged("Dauer");} } }
        private bool _FSK18; public bool FSK18 { get{ return _FSK18;} set{ if (_FSK18 != value){ _FSK18 = value; OnPropertyChanged("FSK18");} } }
        private decimal _Preis; public decimal Preis { get{ return _Preis;} set{ if (_Preis != value){ _Preis = value; OnPropertyChanged("Preis");} } }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vorfuehrung> Vorfuehrung { get; set; }
    
        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
    
        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
    
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
        #endregion
    
    }
}
