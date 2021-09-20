using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M226A_B01_1b
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      
      Rechteck r = new Rechteck(Convert.ToDouble(txtSeiteA.Text),Convert.ToDouble(txtSeiteB.Text));
      double f = r.getFlaeche();
      txtFlaeche.Text = f.ToString();
    }

    private void btnStatic_Click(object sender, EventArgs e)
    {
      double f = Rechteck.getFlaeche(Convert.ToDouble(txtSeiteA.Text), Convert.ToDouble(txtSeiteB.Text));
      txtFlaeche.Text = Convert.ToString(f);
    }
  }
}
