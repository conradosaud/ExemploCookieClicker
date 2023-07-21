namespace Aula09Coockie2
{
    public partial class Form1 : Form
    {
        // --------- VARI�VEIS GLOBAIS
        // Quantidade de Cookie atual da pessoal naquele momento
        int cookie = 0;
        // Quantidade de Cookies que s�o gerados automaticamente a cada segundo
        int gerador_por_segundo = 0;
        // Quanto custa para comprar uma vov�. Esse valor aumenta a cada compra
        int custo_vovo = 10;

        public Form1()
        {
            InitializeComponent();
        }

        // --------- MINHAS FUN��ES

        // Atualiza o valor dos labels que est�o na tela para fazer com que
        // eles mostre os valores das vari�veis
        void atualizaInterface()
        {
            lblCookies.Text = cookie.ToString();
            lblPorSegundo.Text = gerador_por_segundo.ToString();
            lblVovo.Text = custo_vovo.ToString();
        }

        // --------------------------

        // Esse comando � chamado automaticamente a cada tick do temporizador, ou seja,
        // a cada segundo ele � chamado
        private void temporizador_Tick(object sender, EventArgs e)
        {
            cookie += gerador_por_segundo;
            atualizaInterface();
        }

        // Essa fun��o � chamado ao clicar no bot�o Gerar Cookies
        private void btnGerarCookies_Click(object sender, EventArgs e)
        {

            cookie += 1; // Aumenta em 1 o n�mero de cookies atual
            atualizaInterface(); // Atualiza o novo valor na tela para o jogador
        }

        // Fun��o chamado ao clicar no bot�o Comprar Vov�
        private void btnComprarVovo_Click(object sender, EventArgs e)
        {
            if (cookie >= custo_vovo) // Verifica se o jogador tem cookie suficiente para a compra
            {
                cookie -= custo_vovo; // Paga o valor de cookies
                gerador_por_segundo += 1; // Aumenta o valor gerado por segundo na vari�vel
                
                custo_vovo *= 2;
                // ATEN��O /\ perceba que aqui a conta � diferente
                // n�o �   += (soma)
                // agora � *= (multiplica��o)
                // ou seja, est� multiplicando o valor por 2 a cada nova compra
                // � o mesmo que: custo_vovo = custo_vovo * 2;
            }
            atualizaInterface();

            /*
             Voc� tamb�m poderia fazer todo o c�digo fora do IF, desse jeito: 
                    if( cookie < custo_vovo ){
                        return;
                    }
            */
        }
    }
}