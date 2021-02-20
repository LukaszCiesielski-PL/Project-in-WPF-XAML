﻿using Dziennik;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace DziennikOcen
{
    /// <summary>
    /// Logika interakcji dla klasy ocena.xaml
    /// </summary>
    public partial class ocena : Page
    {
        public ocena()
        {
            InitializeComponent();
            WyswietlOceny();
        }

        public void WyswietlOceny()
        {
            using var db = new baza();
            WyswietlOcenyU(GetOcenyU(DaneU.uczenZal));
        }

        public void WyswietlOcenyU(List<Ocena> _ocena)
        {
            foreach (var x in _ocena.Where(o => o.IdPrzedmiot == 1))
            {
                Label _label = new Label { FontSize=18 ,Width=20,Height = 30, Content= $"{x.Ocena1}, " };
                Matematyka.Children.Add(_label);
            }
            foreach (var x in _ocena.Where(o => o.IdPrzedmiot == 2))
            {
                Label _label = new Label { FontSize = 18, Width = 20, Height = 30, Content = $"{x.Ocena1}, " };
                Fizyka.Children.Add(_label);
            }
            foreach (var x in _ocena.Where(o => o.IdPrzedmiot == 3))
            {
                Label _label = new Label { FontSize = 18, Width = 20, Height = 30, Content = $"{x.Ocena1}, " };
                Informatyka.Children.Add(_label);
            }
            foreach (var x in _ocena.Where(o => o.IdPrzedmiot == 4))
            {
                Label _label = new Label { FontSize = 18, Width = 20, Height = 30, Content = $"{x.Ocena1}, " };
                Programowanie.Children.Add(_label);
            }
            foreach (var x in _ocena.Where(o => o.IdPrzedmiot == 5))
            {
                Label _label = new Label { FontSize = 18, Width = 20, Height = 30, Content = $"{x.Ocena1}, " };
                JezykP.Children.Add(_label);
            }
            foreach (var x in _ocena.Where(o => o.IdPrzedmiot == 6))
            {
                Label _label = new Label { FontSize = 18, Width = 20, Height = 30, Content = $"{x.Ocena1}, " };
               JezykA.Children.Add(_label);
            }
            foreach (var x in _ocena.Where(o => o.IdPrzedmiot == 7))
            {
                Label _label = new Label { FontSize = 18, Width = 20, Height = 30, Content = $"{x.Ocena1}, " };
                AngZaw.Children.Add(_label);
            }
            foreach (var x in _ocena.Where(o => o.IdPrzedmiot == 8))
            {
                Label _label = new Label { FontSize = 18, Width = 20, Height = 30, Content = $"{x.Ocena1}, " };
                WF.Children.Add(_label);
            }
            foreach (var x in _ocena.Where(o => o.IdPrzedmiot == 9))
            {
                Label _label = new Label { FontSize = 18, Width = 20, Height = 30, Content = $"{x.Ocena1}, " };
                Religia.Children.Add(_label);
            }
            foreach (var x in _ocena.Where(o => o.IdPrzedmiot == 10))
            {
                Label _label = new Label { FontSize = 18, Width = 20, Height = 30, Content = $"{x.Ocena1}, " };
                Historia.Children.Add(_label);
            }
        }


        public List<Ocena> GetOcenyU(Uczen uczen)
        {
            using var db = new baza();
            List<Ocena> ocenas = new List<Ocena>();
            foreach (var x in db.Ocenas.Where(o => o.IdUczen == uczen.IdUczen))
            {
                ocenas.Add(x);
            }
            return ocenas;
        }
       
    }
}
