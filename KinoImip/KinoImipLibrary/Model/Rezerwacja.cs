
using KinoImipLibrary.Interfaces;

namespace KinoImipLibrary.Model
{
    public class Rezerwacja : IRezerwacja
    {
        public IMiejsce Pozycja { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Imie { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Nazwisko { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public ISeans Seans { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public float Kwota { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool Status { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public IBilet GenerujBilet()
        {
            throw new System.NotImplementedException();
        }
    }
}
