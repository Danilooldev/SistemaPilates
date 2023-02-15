using FichasPilates.Enumerador;
using FichasPilates.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichasPilates.Janelas
{
    public partial class FormEvolucao : Form
    {
        public FormEvolucao()
        {
            InitializeComponent();

            

            

            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void SetCheckedListBoxItems(int value)
        {

            chlEquilibrio.Items.Clear();

            foreach (int enumValue in Enum.GetValues(typeof(EEquilibrio)))
            {
                CheckState state = CheckState.Unchecked;

                if ((value & enumValue) == enumValue)
                {
                    value ^= enumValue;
                    state = CheckState.Checked;

                }

                chlEquilibrio.Items.Add(EnumPelaDescricao.Descricao((EEquilibrio)enumValue), state);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
