using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mi_proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.CenterToParent();
            //this.MaximizeBox = false;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            textBox1.BackColor = Color.Green;
            this.textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.Green;
            this.textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.cancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            bool datos_correctos = Validar();

            if (datos_correctos) {
                DialogResult result = MessageBox.Show("¿Datos correctos?","confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("DATOS GUARDADOS", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { 
                    label1.Focus();
                }
            }
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            DialogResult = DialogResult.OK;
            this.registrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.salir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            //this.CenterToScreen();

        }

        private Boolean Validar() {
            if (textBox1.Text == "" && textBox2.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                DialogResult result = MessageBox.Show("INGRESE DATOS", "confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else { 
               return true;
            }
        }
    }
}
