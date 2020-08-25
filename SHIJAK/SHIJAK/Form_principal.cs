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
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
            ocultar_submenu();
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_maximizar_Click(object sender, EventArgs e)
        {
            button_maximizar.Visible = false;
            button_restaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button_restaurar_Click(object sender, EventArgs e)
        {
            button_maximizar.Visible = true;
            button_restaurar.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        int posX = 0;
        int posY = 0;

        private void panel_ventana_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void ocultar_submenu()
        {
            panel3.Visible = false; //panel de submenu usuarios
            panel5.Visible = false; //panel de submenu rutinas
            panel8.Visible = false; //panel de submenu pagos
        }

        private void button_usuarios_Click(object sender, EventArgs e)
        {
            ocultar_submenu();
            panel3.Visible = true;
        }

        private void button_rutinas_Click(object sender, EventArgs e)
        {
            ocultar_submenu();
            panel5.Visible = true;
        }

        private void button_seguimiento_Click(object sender, EventArgs e)
        {
            ocultar_submenu();
        }

        private void button_pagos_Click(object sender, EventArgs e)
        {
            ocultar_submenu();
            panel8.Visible = true;
        }

        private void button_rendimientos_Click(object sender, EventArgs e)
        {
            ocultar_submenu();
        }

        private void Form_principal_Load(object sender, EventArgs e)
        {
      
        }

        public void abrir_Form(object form_hijo)
        {
            if(this.panel_logo.Controls.Count > 0)
            {
                this.panel_logo.Controls.RemoveAt(0);
                Form fr = form_hijo as Form;
                fr.TopLevel = false;
                fr.Dock = DockStyle.Fill;
                this.panel_logo.Controls.Add(fr);
                this.panel_logo.Tag = fr;
                fr.Show();
            }
        }

        private void button_usuarios_agregar_Click(object sender, EventArgs e)
        {
            abrir_Form(new Form_agregar_usuario());
        }
    }
}
