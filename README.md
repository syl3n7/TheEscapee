# TheEscapee
Final Project for CGS

O presente relatório tem como objetivo relatar o trabalho de desenvolvimento de um jogo 3D, baseado no conceito de “escape room” no âmbito da disciplina de Computação Gráfica e Simulação do Instituto Politécnico da Maia (IPMAIA).

Este trabalho foi desenvolvido pelos alunos:
Cláudio Pinheiro, Nº 040516
Margarida Ramos, Nº 040425
Mariana Cardoso, Nº 041337

A ideia do grupo foi criar um jogo com base em labirintos. O jogo é constituído por dois níveis. 
O primeiro é um labirinto enorme com três salas, que obriga o jogador antes de chegar ao fim do mesmo tem de ir as respetivas salas ativar botões para que possa passar o nível. Ao longo do caminho o jogador vai se deparar com portas que serão abertas com a aproximação do jogador e também pelo mapa tem espalhados “Slimes” e “Turtle Shell”. 

Já no nível 2 o layout é diferente; a área de jogo está dividida em 5 partes, 4 salas de puzzles e uma área central onde o jogador pode observar o seu progresso através de esferas que brilham consoante as salas desbloqueadas. O objetivo é resolver os puzzles das salas e depois uma porta para a saída abre. Sem as salas todas desbloqueadas a porta de saída não abre.

Tétrade Elementar

	Mecânicas:
Room1: No primeiro nível do jogo será um labirinto. Assim como todos os labirintos o
jogador tem o objetivo de descobrir o caminho para chegar ao fim. Ao longo deste labirinto o jogador irá deparar-se com obstáculos, como por exemplo portas. Ainda no interior do labirinto iremos encontrar pequenas salas que conterão botões, para o jogador clicar e só assim passar o nível caso chegue a porta. 
O jogador utilizará o WASD para se movimentar e, Space para saltar. Ao longo do labirinto deparar-se-á com portas que irão abrir com a aproximação do jogador. E ainda terá de saltar por cima dos Slimes e os Turtle Shell, que estarão espalhados pelo mapa e caso o jogador toque neles começara de novo. 

No segundo nível o jogador tem de resolver vários puzzles; na sala um tem que adivinhar o caminho através da combinação de portas, caso erre a combinação volta ao início para alem das portas deve também coletar uma esfera que se encontra no meio da sala. Na sala dois tem que encontrar os dois olhos da caveira e colocá-los na mesma. Na terceira sala deve contar quantas esferas existem no meio de um labirinto de paredes. E por fim na quarta e última sala deve encontrar uma esfera no meio do labirinto e trazê-la até á plataforma no início do labirinto. 

	Narrativa: 
Room1: No início do jogo o jogador já se encontra na entrada do labirinto. Ele irá decidir por qual caminho começa a explorar e no meio dessa exploração terá de encontrar as salas e clicar nos botões, para depois puder sair do maze. Quando o jogador chegar ao objetivo final, passará ao nível seguinte (Room2).
Depois de passar o labirinto e atravessar a porta final o jogador passa para o segundo nível. Ao entrar na sala o jogador pode escolher qualquer uma das quatro seções da sala para começar a resolver, sendo indicado na área central quantas salas faltam para desbloquear a porta de saída do nível.

	Estética: 
Room1: O ambiente em si com a inspiração em casas rústicas, de madeira, velas. Em termos de som, seria apenas o som de interatividade com o meio ambiente + player made sounds, para dar ambiente e realidade, e uma música de fundo.

Room2: A estética desta sala é um ambiente mais sombrio, com menos iluminação, as texturas têm aparência degradada com caracter de ambiente de terror. O som do nível é apenas o som dos paços do jogador e a música ambiente.

	Tecnologia: 
O método utilizado para movimentação será WASD + space (para saltar). Movimentação nos eixos x e z.
O método utilizado para movimentar câmara será rato em torno do eixo y.
O método utlizado para interagir com os objetos será pressionar tecla F e verificar por raycasting se está perto suficiente.

Modos de interação
O jogador controla o movimento o personagem com WASD. 
A câmara e controlada através vez do x e y do rato.
O jogador pode interagir com os objetos nomeadamente os botões e esferas, clicando com uso de raycast.
Isto tudo através do novo sistema de input do Unity.

Personagem controlável
Modelos
Nós utilizamos o asset Banana Man. 
Link: https://assetstore.unity.com/packages/3d/characters/humanoids/banana-man-196830

Comportamentos
Para movimentar o jogador irá utilizar o tradicional WASD, frente, esquerda, trás, direita, respetivamente. 
Correr no Shift. 
Space para saltar.
Mouse para mover a visão do personagem. 
Botão esquerdo do rato para fazer os cliques nos botões. 
Esc para pausar o jogo. 

Animação 
No nosso jogo visto que é um maze não seria lógico colocar o jogador em terceira pessoa, por isso falamos com o próprio docente da disciplina se poderíamos optar por jogo em first person (primeira pessoa), no qual a docente aceitou esta mudança. Por isso, devido ao facto de o personagem não aparecer para o jogador decidimos não criar uma animação. 


Outras personagens
Modelos
Nível 1 
	“RPG Monster Duo PBR Polyart”, onde contém os Slimes e Turtle Shell.
Link: https://assetstore.unity.com/packages/3d/characters/creatures/rpg-monster-duo-pbr-polyart-157762

	“Classic Interior Door Pack 1”, têm as portas utilizadas. 
Link: https://assetstore.unity.com/packages/3d/props/interior/classic-interior-door-pack-1-118744

	“Urban Night Sky”, skybox utilizada.
Link: https://assetstore.unity.com/packages/2d/textures-materials/sky/urban-night-sky-134468

	“Free Medieval Room”, utilizado na decoração em geral. 
Link: https://assetstore.unity.com/packages/3d/environments/free-medieval-room-131004

	“Hand Painted Seamless Wood Texture Vol – 6”, utilizada nas texturas.
Link: https://assetstore.unity.com/packages/2d/textures-materials/wood/hand-painted-seamless-wood-texture-vol-6-162145

Nível 2 
Texturas:
	Plaster Brick01
 Link: https://polyhaven.com/a/plaster_brick_01

	White Plaster Rough 02
Link: https://polyhaven.com/a/white_plaster_rough_02

	Stone BrickWall 01
Link: https://polyhaven.com/a/stone_brick_wall_001

	Medieval Blocks 05
Link: https://polyhaven.com/a/medieval_blocks_05

	Skull platform
Link: https://assetstore.unity.com/packages/3d/props/skull-platform-105664#description
	Creepy pumpkin monster
Link: https://assetstore.unity.com/packages/3d/characters/creatures/creepy-pumpkin-monster-158098
	Skull shield
Link: https://assetstore.unity.com/packages/3d/props/clothing/armor/skull-shield-76967#description

	Kupatka Zubarick weaponry #0: Kupatka's gift
Link: https://assetstore.unity.com/packages/3d/kupatka-zubarick-weaponry-0-kupatka-s-gift-61469#description

Comportamentos
Os personagens no nível 1 que conseguem se mexer é apenas o Slime e o Turtle Shell, que irão vaguear pelo mapa para fazer com que o jogador inicie o jogo caso lhes toque. 
Já no nível 2 não existe nenhuma entidade a perseguir o jogador, mas sim monstros espalhados que fazem o jogador voltar ao início se lhes tocar.
Animação 
Quanto a animação destes personagens, vieram no asset descarregado na Asset Store. 

Ambiente
Para do jogo para além dos assets, materiais, texturas também usamos o ProBuilder. 

Áudio 
Em termos de som foi utilizado o som do Happy Tree Friends para o menu.
Para o som ao longo do jogo no nível 1 temos “Horror Sound Atmospheres and FX” e para o nível 2, “Horror Elements”
Link nível 1: https://assetstore.unity.com/packages/audio/ambient/horror-sound-atmospheres-and-fx-96731#description
Link nível 2: https://assetstore.unity.com/packages/audio/sound-fx/horror-elements-112021#description
 
Menus e UI
Foi criado em Photoshop uma ideia de menus, contudo estas foram um pouco alteradas devido a falta de tempo para o executar por completo. 

Criação do Logótipo
Foi desenvolvido 2 logótipos, no qual o segundo é a proposta final e utilizada. 
