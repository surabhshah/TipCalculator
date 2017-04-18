using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TipCalculator
{
    [Activity(Label = "TipCalculator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        EditText inputBillText;
        Button calculateTipButton;
        TextView outputTipText, outputTotalText;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            inputBillText = FindViewById<EditText>(Resource.Id.inputBill);
            calculateTipButton = FindViewById<Button>(Resource.Id.calculateButton);
            outputTipText = FindViewById<TextView>(Resource.Id.outputTip);
            outputTotalText = FindViewById<TextView>(Resource.Id.outputTotal);

            calculateTipButton.Click += CalculateTipButton_Click;
        }

        private void CalculateTipButton_Click(object sender, EventArgs e)
        {
            double.TryParse(inputBillText.Text, out double bill);
            var tip = bill * 0.15;
            var total = bill + tip;

            outputTipText.Text = tip.ToString();
            outputTotalText.Text = total.ToString();
        }
    }
}

