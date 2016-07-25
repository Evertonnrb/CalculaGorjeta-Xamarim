using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CalculaGorjeta
{
    [Activity(Label = "Calcula Gorjeta", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        TextView txtValor;
        Button btnCalcular;
        TextView txtGorjeta;
        TextView txtValorTotal;
        TextView txtValorGorjeta;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            txtValor = FindViewById <TextView> (Resource.Id.txtValor);
            btnCalcular = FindViewById<Button>(Resource.Id.btnCalcular);
            txtGorjeta = FindViewById<TextView>(Resource.Id.txtGorjeta);
            txtValorGorjeta = FindViewById<TextView>(Resource.Id.txtValorGorjeta);
            txtValorTotal = FindViewById<TextView>(Resource.Id.txtValorTotal);
            //criando o evento do botao tbnCalcular a gorjeta
            btnCalcular.Click += btnCalcular_Click;

        }
        void btnCalcular_Click(Object sender, EventArgs e)
        {
            //note: find the bug!
            double valor = 0;
            valor = double.Parse(txtValor.Text);
            double valorTotal = 0;

            valor = valor * .10;
            valorTotal = valorTotal + valor;
            txtValorGorjeta.Text = valor.ToString();
            txtValorTotal.Text = valorTotal.ToString();
        }
    }
}

