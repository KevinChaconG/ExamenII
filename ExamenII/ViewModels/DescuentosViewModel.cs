using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ExamenII.ViewModels
{
    public partial class DescuentosViewModel : ObservableObject
    {
        [ObservableProperty]
        private double producto1;

        [ObservableProperty]
        private double producto2;

        [ObservableProperty]
        private double producto3;

        [ObservableProperty]
        private double descuento;

        [ObservableProperty]
        private double subtotal;

        [ObservableProperty]
        private double total;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Calcular()
        {
            try
            {
                if(Producto1 <1 || Producto2 <1 || Producto3 < 1)
                {
                    Alerta("Alerta", "El valor de los productos debe ser mayor a cero");
                }
                else
                {
                    Subtotal = Producto1 + Producto2 + Producto3;

                    if(Subtotal < 999.99)
                    {
                        Subtotal = Total;
                    } else if (Subtotal < 4999.99)
                    {
                        Descuento = 10;
                        Total = Subtotal - (Subtotal * .10);
                    }else if(Subtotal < 9999.99)
                    {
                        Descuento = 20;
                        Total = Subtotal - (Subtotal * .20);
                    }
                    else
                    {
                        Descuento = 30;
                        Total = Subtotal - (Subtotal * .30);
                    }
                       
                    
                }

            }catch (Exception ex)
            {
                Alerta("Error", ex.Message);
            }

        }

        [RelayCommand]

        private void Limpiar()
        {
            Producto1 = 0;
            Producto2 = 0;
            Producto3 = 0;
            Descuento = 0;
            Subtotal = 0;
            Total = 0;
        }
    }
}
