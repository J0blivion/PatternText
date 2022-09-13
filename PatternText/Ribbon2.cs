using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternText
{
    public partial class Ribbon2
    {
        private void Ribbon2_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void Modify_Click(object sender, RibbonControlEventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
