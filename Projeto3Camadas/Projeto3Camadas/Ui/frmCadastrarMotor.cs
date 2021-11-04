using System;
using System.Windows.Forms;

//Importação da camada de negócio
using Projeto3Camadas.Code.BLL; 
using Projeto3Camadas.Code.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta

namespace Projeto3Camadas.Ui
{
    public partial class frmCadastroMotor : Form
    {

        //Criação dos objetos que acessam a camada de negócio
        motorBLL medbll = new motorBLL();
        MotorDTO meddto = new MotorDTO();

        public frmCadastroMotor()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            meddto.codigo = int.Parse(txtCodigo.Text);
            meddto.anoFabricacao = int.Parse(txtAnoFabricacao.Text);
            meddto.engenheiroResponsavel = txtEngResponsavel.Text;
            meddto.marca = txtMarca.Text;

            //Envio do dto preenchido para o método inserir
            medbll.Inserir(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Cadastrado com sucesso!", "Motor", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

    }
}
