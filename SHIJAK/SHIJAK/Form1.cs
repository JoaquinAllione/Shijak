using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHIJAK
{
    public partial class Form_carga_inicial : Form
    {
        public Form_carga_inicial()
        {
            InitializeComponent();
        }

        private void timer_aparicion_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            progressBar_carga.Value += 1;
            if (progressBar_carga.Value == 100)
            {
                timer_aparicion.Stop();
                timer_desaparicion.Start();
            }
        }

        private void timer_desaparicion_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer_desaparicion.Stop();
                Form_principal form = new Form_principal();
                form.Show();
                this.Close();
            }
        }

        private void Form_carga_inicial_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer_aparicion.Start();
            progressBar_carga.Value = 0;
        }
    }
}
