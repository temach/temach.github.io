using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDataBindingWithGUI
{
    public partial class Form1 : Form
    {
        public RandomBusinessObj rbo = new RandomBusinessObj();

        public Form1()
        {
            InitializeComponent();
            var binding = new Binding("Text", this.rbo, "CurText");
            binding.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            // formating is false by default. Set it to true to raise BindingComplete event.
            binding.FormattingEnabled = true;
            binding.BindingComplete += GenericTextBoxBindingComplete;
            this.textBox_best.DataBindings.Add(binding);
        }

        private void GenericTextBoxBindingComplete(object sender, BindingCompleteEventArgs e)
        {
            TextBox txtbox = (TextBox)(sender as Binding).Control;
            // throw an exception in the "CurText" property seeter of RandomBusinessObject
            // to get e.BindingCompleteState == BindCompleteState.Exception/DataError
            // Otherwise its always .Success
            if (e.BindingCompleteState == BindingCompleteState.Success)
            {
                txtbox.BackColor = Color.LightGreen;
            }
            else
            {
                txtbox.BackColor = Color.LightPink;
            }
        }

    }
}
