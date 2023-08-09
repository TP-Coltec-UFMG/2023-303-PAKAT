
# PAKAT
Jogo criado para o trabalho de Unity de Tecnologias de Programação

## Menu Inicial 

Nosso jogo começa com um menu, que tem como tela de fundo um possível cenário do jogo, que vai ser sobre trekking. Nesse cenário se encontram 5 personagens que representam os 5 criadores do jogo (que possivelmente vão estar dentro do jogo também).  
No Menu existem 3 opções:  
  Jogar - entra no jogo  
  Ajustes - entra em outra tela com configurações (vai ser explicada depois)  
  Sair - sai do jogo   
 
![menuPrincipal](https://raw.githubusercontent.com/TP-Coltec-UFMG/2023-303-PAKAT/main/MenuPrincipal.png)

## Ajustes 

Nesse cenário uma tela de configurações é aberta e nela existem as seguintes opções:
  Modo daltonismo: coloca a configuração visual do jogo de acordo com o tipo de daltonismo do usuário, sendo acromático, dicromático ou tricomático.  
  Dificuldade: Define a dificuldade do jogo em medio difícil e fácil   
  Volume: barra de arrastar que aumenta ou diminiu o volume  
  Contraste: Muda o contraste do jogo, deixando mais claro ou escuro  
  Fonte: Muda o tamanho das fontes deixando as mesmas maiores para pessoas que enxergam mal.  
  Voltar: retorna a tela inicial
  ![menuAjustes](https://raw.githubusercontent.com/TP-Coltec-UFMG/2023-303-PAKAT/main/MenuAjuste.png)

  ## CutScenes
Essas são cenas introdutória do nosso game, na primeira há uma cena em que uma van anda por um cenário inicial, e após isso aparece uma tela preta escrita algumas horas depois, já na segunda os 6 personagens do jogo são apresentados e andam para a direita, a segunda cena vai ter uma pequena legenda que ainda não foi implementada 
## scripts 



## Menu das Fases 
Nesse menu os 5 personagens são mostrados e clicando em cima do icone de cada um você é direcionado para a respectiva página desse personagem, após você fazer cada fase o incone do personagem não vai mais estar disponível para ser jogado, e quando você completar todas as fazes vai liberar uma cena final.


## Fase 1 Zinchenko 
  Nessa fase existem duas cenas, na primeira acontece uma introdução com legenda e um pequeno dialogo do personagem Zinchenko consigo mesmo, já na segunda entra no jogo dele, onde existe um fundio azul e ele nada por ele como se estivesse surfando, nesse caminho ele tem que desviar de alguns objetos que estão boiando no rio, a fase ainda está incompleta, no final ele vai vencer se passar mais de um minuto seguido desviando dos objetos 
  ## scripts 
  Na cena inicial existe o script controlador de dialogos, que vai pegar as os um array de strings e passar eles na tela, alterando de um para o outro por meio de um clique na tela, que vai 
  Ja na segunda cena existem 3 scripts 
    1- User, movimenta o usuário
    2-Obstacle, movimenta os obstaculos 
    3- geneterater- Gera obstáculos infinitos para o surfista movimentar

  ## Fase 2 Prates 
  Nessa Fase o personagem prates vai entrar em uma cena incial introdutória como a da fase do zinckenko, e após isso vai passar por um labirinto onde vai ter a visão reduzida, tendo que passar pelo mapa todo para ir coletando recompensas nos cantos e terminar a fase vencedor.
  ## scripts 
   O script até então é basicamente de movimentação, o personagem pode se movimentar para cima, baixo, direita e esquerda. 
     
  ## Fase 3 tm 
   Nessa fase o personagem tm vai se perder e para conseguir sair ele precisará nadar e desviar de pedras no fundo do do rio
  ## scripts 
   Os scripts relacionados são, movimentação do personagem, gerador de obstaculos, obstaculos, e contador de pontuação.

  ## Fase 4 Waltin 
  ## scripts 

  ## Fase 5 kaio 
   A fase faz com que o personagem corra em procura do honda o qual sumiu com isso possui alguns obstaculos como pedras e poças de agua , a missão acaba quando o honda é encontrado.
  ## scripts 
   O script utilizado ate o momento foi o de jump para desviar ds obstaculos

  ## CutScenes final 
    Os 5 personagens vão se encontrar conversar um pouco e sair andando juntos, no final vai mostrar a van saindo como na cena inicial 





