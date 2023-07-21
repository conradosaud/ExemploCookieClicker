namespace Aula09Coockie2
{
    public partial class Form1 : Form
    {
        // --------- VARIÁVEIS GLOBAIS
        // Quantidade de Cookie atual da pessoal naquele momento
        int cookie = 0;
        // Quantidade de Cookies que são gerados automaticamente a cada segundo
        int gerador_por_segundo = 0;
        // Quanto custa para comprar uma vovó. Esse valor aumenta a cada compra
        int custo_vovo = 10;

        public Form1()
        {
            InitializeComponent();
        }

        // --------- MINHAS FUNÇÕES

        // Atualiza o valor dos labels que estão na tela para fazer com que
        // eles mostre os valores das variáveis
        void atualizaInterface()
        {
            lblCookies.Text = cookie.ToString();
            lblPorSegundo.Text = gerador_por_segundo.ToString();
            lblVovo.Text = custo_vovo.ToString();
        }

        // --------------------------

        // Esse comando é chamado automaticamente a cada tick do temporizador, ou seja,
        // a cada segundo ele é chamado
        private void temporizador_Tick(object sender, EventArgs e)
        {
            cookie += gerador_por_segundo;
            atualizaInterface();
        }

        // Essa função é chamado ao clicar no botão Gerar Cookies
        private void btnGerarCookies_Click(object sender, EventArgs e)
        {

            cookie += 1; // Aumenta em 1 o número de cookies atual
            atualizaInterface(); // Atualiza o novo valor na tela para o jogador
        }

        // Função chamado ao clicar no botão Comprar Vovó
        private void btnComprarVovo_Click(object sender, EventArgs e)
        {
            if (cookie >= custo_vovo) // Verifica se o jogador tem cookie suficiente para a compra
            {
                cookie -= custo_vovo; // Paga o valor de cookies
                gerador_por_segundo += 1; // Aumenta o valor gerado por segundo na variável
                
                custo_vovo *= 2;
                // ATENÇÃO /\ perceba que aqui a conta é diferente
                // não é   += (soma)
                // agora é *= (multiplicação)
                // ou seja, está multiplicando o valor por 2 a cada nova compra
                // é o mesmo que: custo_vovo = custo_vovo * 2;
            }
            atualizaInterface();

            /*
             Você também poderia fazer todo o código fora do IF, desse jeito: 
                    if( cookie < custo_vovo ){
                        return;
                    }
            */
        }
    }
}