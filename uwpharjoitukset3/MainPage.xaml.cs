﻿using System;
using System.Reflection;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace uwpharjoitukset3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        // tämä pitää kirjaa siitä mitä sivua viimeksi käytettiin
        // tätä hyödynnetään lähinnä siinä, että jos yritetään kaksi
        // kertaa navigoida samaan sivuun, jätetään se huomiotta
        private NavigationViewItem _lastItem;

        // HUOM! Vaihda tähän oman UWP-projektisi nimi! (näkyy Solution Explorerissa ylimpänä)
        private string projectName = "uwpharjoitukset3";

        // jotain painettiin valikosta, päätetään mitä tehdään
        private void NavigationView_OnItemInvoked(
            Windows.UI.Xaml.Controls.NavigationView sender,
            NavigationViewItemInvokedEventArgs args)
        {
            // haetaan klikattu NavigationViewItem
            var item = args.InvokedItemContainer as NavigationViewItem;

            // jos Itemiä ei löydy, jätetään pyyntö kesken
            if (item == null || item == _lastItem)
                return;

            // jos Itemistä ei löydy Tagia, oletuksena on silloin Settings
            // tässä tapauksessa settingsview on otettu pois käytöstä myös XAMLin puolella
            var clickedView = item.Tag?.ToString() ?? "SettingsView";

            // jos navigointi epäonnistuu, jätetään kesken
            if (!NavigateToView(clickedView)) return;

            _lastItem = item;
        }

        // suoritetaan varsinainen navigaatio, tätä kutsuu lähinnä
        // NavigationView_OnItemInvoked
        private bool NavigateToView(string clickedView)
        {
            // yritetään hakea sopiva sivu Views -kansiosta
            var view = Assembly.GetExecutingAssembly()
                .GetType($"{projectName}.Views.{clickedView}");

            // jos haluttua sivua ei löydy, jätetään navigointi kesken
            if (string.IsNullOrWhiteSpace(clickedView) || view == null)
            {
                return false;
            }

            // navigoidaan valittu sivu ContentFrameen
            ContentFrame.Navigate(view, null, new EntranceNavigationTransitionInfo());
            return true;
        }

        // jos navigointi epäonnistuu, kaadetaan ohjelma
        private void ContentFrame_OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new NavigationException(
                $"Navigation failed {e.Exception.Message} for {e.SourcePageType.FullName}");
        }

        // käsitellään Back-painike => mennään edelliseen sivuun takaisin
        private void NavView_OnBackRequested(
            Windows.UI.Xaml.Controls.NavigationView sender,
            NavigationViewBackRequestedEventArgs args)
        {
            if (ContentFrame.CanGoBack)
                ContentFrame.GoBack();
        }
    }

    // oma poikkeustyyppi navigointiongelmille
    internal class NavigationException : Exception
    {
        public NavigationException(string msg) : base(msg)
        {

        }
    }
}