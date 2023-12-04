using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EamenDiapps2.ViewModel
{
    public class VMCalorias : BaseViewModel
    {
        #region VARIABLES
        public string _Mensaje;
        public double _Duracion;
        public double _Peso;
        public double _Resultado;
        public bool _MostrarGordo;
        public bool _MostrarNormal;
        public bool _MostrarFitoFuerte;

        #endregion
        #region CONSTRUCTOR
        public VMCalorias(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        public double Resultado
        {
            get { return _Resultado; }
            set { SetValue(ref _Resultado, value);}
        }

        public double Duracion
        {
            get { return _Duracion; }
            set { SetValue(ref _Duracion, value); }
        }
        public double Peso
        {
            get { return _Peso; }
            set { SetValue(ref _Peso, value); }
        }
        public bool MostrarGordo
        {
            get { return _MostrarGordo; }
            set { SetValue(ref _MostrarGordo, value); }
        }

        public bool MostrarNormal
        {
            get { return _MostrarNormal; }
            set { SetValue(ref _MostrarNormal, value); }
        }

        public bool MostrarFitoFuerte
        {
            get { return _MostrarFitoFuerte; }
            set { SetValue(ref _MostrarFitoFuerte, value); }
        }

        #endregion
        #region PROCESO 
        public async Task ProcesoAsyncrono()
        {

        }
        public void Calcular()
        {
            Resultado = (Duracion * 10) * (Peso / 200);
        }
        public async void CalcularCalorias()
        {
            Calcular();
            if(Resultado < 250)
            {
                Mensaje = "Corre más tiempo";
                MostrarGordo= true;
                MostrarNormal= false;
                MostrarFitoFuerte = false;
            }
            else if (Resultado > 250 && Resultado < 500)
            {
                Mensaje = "Vas por bien camino";
                MostrarNormal= true;
                MostrarFitoFuerte= false;
                MostrarGordo= false;
            }
            else if (Resultado > 499)

            {
                Mensaje = "Felicidades";
                MostrarNormal= false;
                MostrarFitoFuerte = true;
                MostrarGordo= false;
            }
            await DisplayAlert("Resultado", Mensaje, "Ok");
        }

        #endregion

        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand CalcularCaloriascomand => new Command(CalcularCalorias);
        #endregion
    }
}
