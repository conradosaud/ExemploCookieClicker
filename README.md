# Cookie Clicker em C#
Este é um repositório de demonstração, criado na aula do curso de programador de sistemas do Senac em parceria com o projeto Transforme-se do Serasa para a turma da tarde. Aula do dia 20/07/2023 às 17:10h.

Trata-se de um exemplo de como pode ser desenvolvido um jogo parecido com o [Cookie Clicker](https://orteil.dashnet.org/cookieclicker/), que foi passado para os alunos em um momento recreativo do curso.

O programa foi programado em C# usando o Windows Form para montar as interfaces.

## Timer
Essa é parte principal do jogo que faz ele acontecer. Para que os __cookies__ possam ser gerados de forma automática a cada a segudo, usamos um __Timer__. Ele pode ser encontrado na lista de ferramentas do Visual Studio, basta clicar e arrasta-lo para a tela. Ele não possui recursos visuais, logo não terá nenhuma alteração na tela. Ele é uma ferramente puramente programada.

É necessário __configurar__ o _timer_ para que ele possa se tornar um temporizador que roda de forma automática no tempo que você precisa.
Depois de adicionar o _timer_ ao seu projeto, nas propriedades, configure:
- name: o padrão é _timer1_ e você pode alterar para outra coisa se preferir. Neste exemplo eu renomeei para _temporizador_
- interval: é o tempo que o _timer_ vai ser acionado. O tempo aqui é calculado em milisegundos, logo, você deve adicionar o valor 1000 (mil) para que o temporizador rode a cada 1 segundo.
- enabled: seu temporizador começa desativado. Troque essa opção para _true_ para que o temporizador inicie junto da sua aplicação.

Com o timer configurado, você pode acessar sua função de _tick_. Basta clicar duas vezes no temporizador que você será redirecionado para a tela de códigos.

A função *timer1_click* (ou *temporizador_click* se você mudou o nome) é chamada a cada momento do _interval_ que você configurou anteriormente. Logo, se você configurou o _interval_ para 1000, essa função será chamada a cada 1 segundo. É aqui que ficará a lógica de adicionar os cookies automáticos por segundo na conta do jogador.

## Variáveis globais
Essas são as variáveis que vão controlar a produção de cookies do jogo. A variável _cookies_ é a quantidade atual de cookies do jogador, que também vale como moeda, enquanto *gerador_por_segundo* é o quanto a variável _cookies_ vai aumenta a cada segundo. Esse conta é realizada dentro da função _tick_ do _temporizador_.

## Atividades extras
Você também pode criar novas variáveis globais para adicionar funções novas no seu jogo e tornar ele mais interessante. Aqui estão algumas sugestões de variáveis que você pode ter:

#### Aumentar o valor do clique
Variável chamada **valor_clique** que dita o quanto você ganha de cookie cada vez que clica no botão *Gerar Cookies*. O padrão é gerar apenas 1 Cookie por clique, mas dentro do botão *Gerar Cookies* você pode fazer algo assim: `cookies += valor_clique;`.

Você pode ter uma opção de compra na sua loja que permite aumentar esse valor, igual a vovó.

#### Contador de vovós
Você pode criar uma variável global chamado **contador_vovos** que conta quantas vovós o usuário já comprou até agora.

#### Mais melhorias
Você também pode adicionar outras melhorias além da vovó. Você pode colocar uma fábrica também. Ela deve gerar mais Cookies do que a vovó. Para ficar ainda mais interessante, a fábrica só deve aparecer na tela depois que o usuário tem um número mínimo de vovós compradas.










