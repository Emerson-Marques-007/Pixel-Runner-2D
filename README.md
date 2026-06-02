# 🎮 Pixel Runner - A Fuga do Castelo

## 📖 Descrição do Jogo

**Pixel Runner** é um jogo de plataforma 2D desenvolvido em **Unity** onde você encarna um aventureiro que precisa escapar de um castelo mágico repleto de perigos. Pule sobre plataformas, colete moedas, desvie de inimigos e use suas habilidades de escalada para alcançar a liberdade!

### 🎯 Tema e Narrativa
Um guerreiro destemido foi aprisionado no Castelo das Trevas. Após conseguir se libertar das correntes, ele deve agora atravessar os cinco níveis do castelo para escapar. Em cada nível, os desafios aumentam, exigindo maior maestria nos controles e compreensão dos padrões de inimigos.

---

## 🕹️ Controles do Jogo

| Ação | Tecla |
|------|-------|
| Mover Esquerda | `A` ou `Seta Esquerda` |
| Mover Direita | `D` ou `Seta Direita` |
| Pular | `Espaço` |
| Pulo Duplo | `Espaço` (2x no ar) |
| Correr | `Shift` (aumenta velocidade) |
| Escalar | `W` ou `Seta Acima` (perto de corda) |
| Pausar | `P` ou `ESC` |

---

## 🎮 Mecânicas Principais

### 1. **Movimentação do Personagem**
- **Andar**: Movimento fluido em 8 direções com aceleração suave
- **Correr**: Ativa com Shift, aumenta velocidade em 1.5x
- **Pulo**: Altura controlável (pulo mais curto ou mais longo conforme tempo de pressionamento)
- **Pulo Duplo**: Segunda ação de pulo no ar para alcançar plataformas altas

### 2. **Gravidade e Física**
- Sistema realista de gravidade com queda progressiva
- Detecção de chão para permitir pulos apenas quando em solo
- Momentum preservado em plataformas móveis

### 3. **Escalada**
- Suba por cordas e paredes especiais
- Controle vertical fluido durante escalada
- Possibilidade de pular da corda para plataformas adjacentes

### 4. **Sistema de Vidas**
- Começa com 3 vidas
- Perde 1 vida ao tocar inimigos ou cair no vazio
- Game Over ao perder todas as vidas
- Respawn automático no último checkpoint

### 5. **Coleta de Itens**
- **Moedas**: Aumentam pontuação, podem ser necessárias para desbloquear áreas
- **Vida Extra**: Restaura 1 vida perdida
- **Power-up de Velocidade**: Aumenta velocidade temporariamente

### 6. **Inimigos**
- **Patrulheiros**: Andam em rotas pré-definidas
- **Patrulheiros Aéreos**: Voam em padrões circulares
- **Boss Final**: Combina múltiplas fases com diferentes ataques
- Todos os inimigos têm padrões de movimento previsíveis (essencial para game design)

---

## 🎪 Níveis

### **Nível 1: O Calabouço Inicial** 🏰
- **Dificuldade**: Muito Fácil
- **Duração**: ~3 minutos
- **Objetivos**: Aprender controles básicos
- **Mecânicas**: Andar, pular em plataformas simples
- **Inimigos**: Nenhum
- **Moedas**: 10

### **Nível 2: Câmara das Plataformas Móveis** 🚀
- **Dificuldade**: Fácil
- **Duração**: ~4 minutos
- **Objetivos**: Dominar pulo duplo
- **Mecânicas**: Plataformas móveis, timing de pulos
- **Inimigos**: 2 patrulheiros lentos
- **Moedas**: 15

### **Nível 3: Torre dos Guardas** 👹
- **Dificuldade**: Médio
- **Duração**: ~5 minutos
- **Objetivos**: Evitar inimigos e coletar tudo
- **Mecânicas**: Inimigos diversos, plataformas instáveis
- **Inimigos**: 4 patrulheiros de diferentes velocidades
- **Moedas**: 20

### **Nível 4: Câmara das Cordas** 🔗
- **Dificuldade**: Médio-Alto
- **Duração**: ~6 minutos
- **Objetivos**: Dominar escalada
- **Mecânicas**: Escalada extensa, saltos de cordas
- **Inimigos**: 3 inimigos aéreos + 2 patrulheiros
- **Moedas**: 25

### **Nível 5: Câmara do Rei Sombrio (Boss)** 👑
- **Dificuldade**: Difícil
- **Duração**: ~8 minutos
- **Objetivos**: Vencer o boss final
- **Mecânicas**: Combina tudo dos níveis anteriores
- **Boss**: Rei Sombrio com 3 fases
- **Moedas**: 30

---

## 📊 HUD (Interface de Usuário)

### Elementos Visíveis
- **Vidas**: Ícone de coração no canto superior esquerdo
- **Pontuação**: Contador de moedas no canto superior direito
- **Temporizador**: Tempo decorrido no nível (canto superior central)
- **Indicador de Checkpoint**: Mostra status de checkpoint salvo

### Menus
- **Menu Principal**: Start, Settings, Credits, Exit
- **Pause Menu**: Resume, Settings, Main Menu
- **Game Over**: Retry, Main Menu
- **Victory Screen**: Next Level / Main Menu + Estatísticas

---

## 🎨 Arte e Animações

### Spritesheet do Personagem
| Estado | Quadros | FPS |
|--------|---------|-----|
| Idle | 4 | 8 |
| Correndo | 6 | 12 |
| Pulando | 2 | 10 |
| Caindo | 2 | 8 |
| Escalando | 4 | 10 |
| Levando Dano | 2 | 12 |
| Morrendo | 4 | 8 |

### Paleta de Cores
- **Personagem**: Azul e Branco (Pixel art 32x32)
- **Plataformas**: Verde e Terra (Tile 32x32)
- **Inimigos**: Vermelho escuro (Pixel art variado)
- **Moedas**: Amarelo brilhante (Sprite 16x16)
- **Fundo**: Degradê roxo/azul (Parallax)

---

## 🔊 Áudio

### Trilha Sonora
- **Menu**: `menu_theme.ogg` (Música ambient calma - 120 BPM)
- **Nível 1-2**: `level_easy.ogg` (Música upbeat - 140 BPM)
- **Nível 3-4**: `level_medium.ogg` (Música dinâmica - 150 BPM)
- **Nível 5**: `level_boss.ogg` (Música épica - 160 BPM)
- **Game Over**: `game_over.ogg` (Música triste - 100 BPM)
- **Vitória**: `victory.ogg` (Música alegre - 130 BPM)

### Efeitos Sonoros
| Efeito | Arquivo | Duração |
|--------|---------|---------|
| Pulo | `sfx_jump.wav` | 0.3s |
| Coleta de Moeda | `sfx_coin.wav` | 0.5s |
| Dano | `sfx_damage.wav` | 0.4s |
| Morte | `sfx_death.wav` | 0.6s |
| Vitória | `sfx_victory.wav` | 1.0s |
| Escalada | `sfx_climb.wav` | Loop |

---

## 📁 Estrutura do Projeto

```
Assets/
├── Scenes/
│   ├── MainMenu.unity
│   ├── Level_1.unity
│   ├── Level_2.unity
│   ├── Level_3.unity
│   ├── Level_4.unity
│   └── Level_5.unity
├── Scripts/
│   ├── Player/
│   │   ├── PlayerController.cs
│   │   ├── PlayerAnimator.cs
│   │   └── PlayerHealth.cs
│   ├── Managers/
│   │   ├── GameManager.cs
│   │   ├── LevelManager.cs
│   │   ├── UIManager.cs
│   │   └── AudioManager.cs
│   ├── Enemies/
│   │   ├── EnemyPatrol.cs
│   │   ├── EnemyFlyer.cs
│   │   └── BossController.cs
│   ├── Items/
│   │   ├── CoinCollectable.cs
│   │   └── HealthPickup.cs
│   ├── Platform/
│   │   └── MovingPlatform.cs
│   └── Utils/
│       └── GameConstants.cs
├── Sprites/
│   ├── Player/
│   │   ├── player_idle.png
│   │   ├── player_run.png
│   │   ├── player_jump.png
│   │   └── player_climb.png
│   ├── Enemies/
│   │   ├── enemy_patrol.png
│   │   ├── enemy_flyer.png
│   │   └── boss.png
│   ├── Items/
│   │   ├── coin.png
│   │   └── health_pickup.png
│   ├── Platforms/
│   │   ├── platform_wood.png
│   │   ├── platform_stone.png
│   │   └── platform_moving.png
│   └── Background/
│       ├── bg_level1.png
│       ├── bg_level2.png
│       └── ...
├── Audio/
│   ├── Music/
│   │   ├── menu_theme.ogg
│   │   ├── level_easy.ogg
│   │   └── ...
│   └── SFX/
│       ├── sfx_jump.wav
│       ├── sfx_coin.wav
│       └── ...
└── Prefabs/
    ├── Player.prefab
    ├── Enemy.prefab
    ├── Coin.prefab
    └── Platform.prefab
```

---

## 🛠️ Como Executar

### Requisitos
- **Unity 2021.3 LTS** ou superior
- **Git** instalado
- Qualquer sistema operacional (Windows, macOS, Linux)

### Passos
1. Clone o repositório:
   ```bash
   git clone https://github.com/Emerson-Marques-007/Pixel-Runner-2D.git
   cd Pixel-Runner-2D
   ```

2. Abra o projeto em Unity:
   - Abra o Unity Hub
   - Clique em "Open Project"
   - Selecione a pasta `Pixel-Runner-2D`

3. Execute o jogo:
   - Abra a cena `Assets/Scenes/MainMenu.unity`
   - Pressione o botão ▶️ Play no editor Unity
   - Ou build o projeto: File → Build and Run

### Build para Executável
1. File → Build Settings
2. Adicione todas as cenas (File → Build Settings → Scenes in Build)
3. Selecione a plataforma (Windows/Mac/Linux)
4. Clique em "Build" e escolha a pasta de saída
5. Execute o arquivo `.exe` gerado

---

## 📝 Créditos

### Desenvolvimento
- **Programação**: Emerson Marques
- **Design de Níveis**: Emerson Marques
- **Arte**: Assets de domínio público

### Assets Utilizados
- **Sprites**: [Itch.io](https://itch.io/) - Pixel Art Packs gratuitos
- **Áudio**: [Freesound.org](https://freesound.org/) - SFX livres
- **Música**: [OpenGameArt.org](https://opengameart.org/) - Músicas royalty-free
- **Engine**: [Unity Technologies](https://unity.com/)

---

## 📚 Documentação Técnica

Veja `TEORIA.md` para detalhes sobre:
- Arquitetura do jogo
- Padrões de design utilizados
- Algoritmos de IA para inimigos
- Sistema de partículas e efeitos
- Otimizações de performance

---

## 🚀 Melhorias Futuras

- [ ] Sistema de power-ups especiais
- [ ] Modos de dificuldade ajustáveis
- [ ] Leaderboard local
- [ ] Suporte a gamepad
- [ ] Mais níveis e desafios
- [ ] Sistema de achievements
- [ ] Versão mobile

---

## 📄 Licença

Este projeto foi desenvolvido como trabalho acadêmico na disciplina de Game Development.

---

## 🎬 Vídeo Demonstração

[Assista o vídeo pitch do jogo](https://youtube.com) *(Link será atualizado após publicação)*

---

## 💬 Feedback e Sugestões

Se você tem sugestões ou encontrou bugs, abra uma issue no repositório!

---

**Desenvolvido com ❤️ em Unity**
