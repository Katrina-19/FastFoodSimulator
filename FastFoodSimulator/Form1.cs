using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodSimulator.Business;

namespace FastFoodSimulator
{
    public partial class Form1 : Form

    {
    public Form1()
    {
        InitializeComponent();
        //Simulator simulator = new Simulator();
    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label10_Click(object sender, EventArgs e)
    {

    }

    private void tb_timeOfBuyers_TextChanged(object sender, EventArgs e)
    {

    }

    private void btn_start_Click(object sender, EventArgs e)
    {
        int a = Convert.ToInt32(tb_timeOfBuyers.Text);
        int b = Convert.ToInt32(tb_timeOfOrder.Text);
        int c = Convert.ToInt32(tb_cookingTime.Text);
        Simulator simulator = new Simulator(c,b,a);
        simulator.StartFastFoodSimulator();
    }
    }
}
