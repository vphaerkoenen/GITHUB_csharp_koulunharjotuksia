using System.Collections.ObjectModel;

namespace uwpharjoitukset3
{
    public class EventShowViewModel
    {// HUOM: tyyppinä on ObservableCollection, joka automaattisesti
     // huolehtii Data Bindingin vaatimasta 
     // PropertyChanged-ominaisuudesta!
        private ObservableCollection<EventShow> events = new ObservableCollection<EventShow>();

        // tehdään myös property ylläolevasta muuttujasta
        public ObservableCollection<EventShow> EventShows { get { return this.events; } }


        public EventShowViewModel()
        {// laitetaan muutama testilevy suoraan koodilla
         // jos tämä data tulisi esim. internetistä, haku- 
         // ja käsittelykoodi tulisi tähän!
            this.events.Add(new EventShow()
            {
                Nimi = "Arktinen autuus",
                Osoite = "Kulttuurikatu 12 00530",
                Päivämäärä = "12/05/2021",
                Kategoria = "näyttely"
            });
            this.events.Add(new EventShow()
            {
                Nimi = "Tulitikkuja lainaamassa",
                Osoite = "Tulkintakuja 6 00100",
                Päivämäärä = "05/10/2021",
                Kategoria = "teatteri"
            });
            this.events.Add(new EventShow()
            {
                Nimi = "Puujalkoja ja -päitä",
                Osoite = "Remakkatie 31 96300",
                Päivämäärä = "20/08/2021",
                Kategoria = "stand-up"
            });
            this.events.Add(new EventShow()
            {
                Nimi = "Baskervillen koira",
                Osoite = "Filmitie 1",
                Päivämäärä = "02/09/2021",
                Kategoria = "elokuva"
            });
            
            this.events.Add(new EventShow()
            {
                Nimi = "",
                Osoite = "",
                Päivämäärä = "",
                Kategoria = ""
            });
            this.events.Add(new EventShow()
            {
                Nimi = "Jaaha, täällä on ilmeisesti harjoiteltu bindausta",
                Osoite = "",
                Päivämäärä = "",
                Kategoria = ""
            });
        }
    }
}
