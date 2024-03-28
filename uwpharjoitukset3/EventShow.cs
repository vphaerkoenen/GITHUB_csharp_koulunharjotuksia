namespace uwpharjoitukset3
{
    public class EventShow
    {
        public string Nimi { get; set; }
        public string Osoite { get; set; }
        public string Päivämäärä { get; set; }
        public string Kategoria { get; set; }

        public EventShow()
        {
            this.Nimi = "No value";
            this.Osoite = "No value";
            this.Päivämäärä = "No value";
            this.Kategoria = "No value";
        }

        public string WholeEvent
        {
            get
            {
                return $"{this.Nimi}" + "  " + $"{this.Osoite}" + "  " + $"{this.Päivämäärä}" + "  " + $"{this.Kategoria}";
            }
        }

    }
}
