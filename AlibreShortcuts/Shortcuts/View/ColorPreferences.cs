using System;
using System.Drawing;
using System.Windows.Forms;


namespace Bolsover.Shortcuts.View
{
    public partial class ColorPreferences : UserControl
    {
        
    //   Prop
        
       
        public ColorPreferences()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                this.button1.BackColor = colorDialog.Color;
        }
    }
}