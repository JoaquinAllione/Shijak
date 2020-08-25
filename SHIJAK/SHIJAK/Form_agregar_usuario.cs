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
    public partial class Form_agregar_usuario : Form
    {
        public Form_agregar_usuario()
        {
            InitializeComponent();
        }

        private void Form_agregar_usuario_Load(object sender, EventArgs e)
        {
            panel_agregar_usuario_1.Width = 566;
            panel_agregar_usuario_2.Width = 0;
            panel_agregar_usuario_3.Width = 0;

            textBox_nombre.Text = "NOMBRE";
            textBox_apellido.Text = "APELLIDO";
            textBox_celular.Text = "CELULAR";
            textBox_dni.Text = "D.N.I";
            textBox_domicilio.Text = "DOMICILIO";
            textBox_edad.Text = "EDAD";
            textBox_email.Text = "EMAIL";
            textBox_fecha_nac.Text = "FECHA NAC.";
            textBox_localidad.Text = "LOCALIDAD";
            textBox_telefono.Text = "TELEFONO";
            textBox_obra_social.Text = "OBRA SOCIAL";
            textBox_Id.Text = "Nº SOCIO";
        }

        private void button_siguiente_Click(object sender, EventArgs e)
        {
            panel_agregar_usuario_1.Width = 0;
            panel_agregar_usuario_2.Width = 566;
            panel_agregar_usuario_3.Width = 0;
        }

        private void button_siguiente_2_Click(object sender, EventArgs e)
        {
            panel_agregar_usuario_1.Width = 0;
            panel_agregar_usuario_2.Width = 0;
            panel_agregar_usuario_3.Width = 566;
        }

        private void button_anterior_Click(object sender, EventArgs e)
        {
            panel_agregar_usuario_1.Width = 566;
            panel_agregar_usuario_2.Width = 0;
            panel_agregar_usuario_3.Width = 0;
        }

        private void button_anterior_2_Click(object sender, EventArgs e)
        {
            button_siguiente_Click(sender, e);
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            Form_agregar_usuario_Load(sender, e);
        }

        public void limpiar_textbox(TextBox text, string str)
        {
            if (text.Text == str)
            {
                text.Text = "";
            }
        }

        public void default_textbox(TextBox text, string str)
        {
            if (text.Text == "")
            {
                text.Text = str;
            }
        }

        private void textBox_nombre_Click(object sender, EventArgs e)
        {
            limpiar_textbox(textBox_nombre, "NOMBRE");
        }

        private void textBox_nombre_Leave(object sender, EventArgs e)
        {
            default_textbox(textBox_nombre,"NOMBRE");
        }

        private void textBox_apellido_Click(object sender, EventArgs e)
        {
            limpiar_textbox(textBox_apellido, "APELLIDO");
        }

        private void textBox_apellido_Leave(object sender, EventArgs e)
        {
            default_textbox(textBox_apellido, "APELLIDO");
        }

        private void textBox_dni_Click(object sender, EventArgs e)
        {
            limpiar_textbox(textBox_dni, "D.N.I");
        }

        private void textBox_dni_Leave(object sender, EventArgs e)
        {
            default_textbox(textBox_dni, "D.N.I");
        }

        private void textBox_localidad_Click(object sender, EventArgs e)
        {
            limpiar_textbox(textBox_localidad, "LOCALIDAD");
        }

        private void textBox_localidad_Leave(object sender, EventArgs e)
        {
            default_textbox(textBox_localidad, "LOCALIDAD");
        }

        private void textBox_celular_Leave(object sender, EventArgs e)
        {
            default_textbox(textBox_celular, "CELULAR");
        }

        private void textBox_celular_Click(object sender, EventArgs e)
        {
            limpiar_textbox(textBox_celular, "CELULAR");
        }

        private void textBox_email_Click(object sender, EventArgs e)
        {
            limpiar_textbox(textBox_email, "EMAIL");
        }

        private void textBox_email_Leave(object sender, EventArgs e)
        {
            default_textbox(textBox_email, "EMAIL");
        }

        private void textBox_fecha_nac_Leave(object sender, EventArgs e)
        {
            default_textbox(textBox_fecha_nac, "FECHA NAC.");
        }

        private void textBox_fecha_nac_Click(object sender, EventArgs e)
        {
            limpiar_textbox(textBox_fecha_nac, "FECHA NAC.");
        }

        private void textBox_edad_Click(object sender, EventArgs e)
        {
            limpiar_textbox(textBox_edad, "EDAD");
        }

        private void textBox_edad_Leave(object sender, EventArgs e)
        {
            default_textbox(textBox_edad, "EDAD");
        }

        private void textBox_domicilio_Click(object sender, EventArgs e)
        {
            limpiar_textbox(textBox_domicilio, "DOMICILIO");
        }

        private void textBox_domicilio_Leave(object sender, EventArgs e)
        {
            default_textbox(textBox_domicilio, "DOMICILIO");
        }

        private void textBox_telefono_Click(object sender, EventArgs e)
        {
            limpiar_textbox(textBox_telefono, "TELEFONO");
        }

        private void textBox_telefono_Leave(object sender, EventArgs e)
        {
            default_textbox(textBox_telefono, "TELEFONO");
        }

        private void textBox_obra_social_Click(object sender, EventArgs e)
        {
            limpiar_textbox(textBox_obra_social, "OBRA SOCIAL");
        }

        private void textBox_obra_social_Leave(object sender, EventArgs e)
        {
            default_textbox(textBox_obra_social, "OBRA SOCIAL");
        }

        private void textBox_Id_Click(object sender, EventArgs e)
        {
            limpiar_textbox(textBox_Id, "Nº SOCIO");
        }

        private void textBox_Id_Leave(object sender, EventArgs e)
        {
            default_textbox(textBox_Id, "Nº SOCIO");
        }
    }
}
