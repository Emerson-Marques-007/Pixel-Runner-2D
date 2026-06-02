# 📚 Pixel Runner - 2D Platformer Game

## ✅ Status do Projeto

Este repositório contém o código-fonte completo do jogo de plataforma 2D **"Pixel Runner: A Fuga do Castelo"**, desenvolvido em Unity como projeto acadêmico na disciplina de Game Development.

### 📋 Checklist de Desenvolvimento

- [x] **Estrutura Base do Projeto**
  - [x] GameManager com Singleton
  - [x] AudioManager centralizado
  - [x] UIManager para HUD
  - [x] LevelManager por nível

- [x] **Mecânicas do Personagem**
  - [x] PlayerController (movimento, pulo, corrida)
  - [x] PlayerHealth (vidas, invencibilidade)
  - [x] PlayerAnimator (sincronização de animações)

- [x] **Inimigos**
  - [x] EnemyPatrol (patrulha simples)
  - [x] EnemyFlyer (movimento circular)
  - [x] BossController (fases dinâmicas)

- [x] **Ambiente**
  - [x] MovingPlatform (plataformas móveis)
  - [x] ClimbRope (escalada)
  - [x] Spike (obstáculos)
  - [x] Checkpoint (pontos de salvação)
  - [x] LevelExit (portal de saída)

- [x] **Itens**
  - [x] CoinCollectable (moedas)
  - [x] HealthPickup (vida extra)

- [x] **Documentação**
  - [x] README.md (este arquivo)
  - [x] TEORIA.md (relatório teórico)

---

## 🎮 Como Usar

### Pré-requisitos
- Unity 2021.3 LTS ou superior
- Visual Studio ou outro editor C#

### Instalação
```bash
git clone https://github.com/Emerson-Marques-007/Pixel-Runner-2D.git
cd Pixel-Runner-2D
```

Depois abra o projeto em Unity Hub.

---

## 📁 Estrutura de Pastas

```
Assets/
├── Scripts/
│   ├── Managers/
│   │   ├── GameManager.cs
│   │   ├── AudioManager.cs
│   │   ├── UIManager.cs
│   │   └── LevelManager.cs
│   ├── Player/
│   │   ├── PlayerController.cs
│   │   ├── PlayerHealth.cs
│   │   └── PlayerAnimator.cs
│   ├── Enemies/
│   │   ├── EnemyPatrol.cs
│   │   ├── EnemyFlyer.cs
│   │   └── BossController.cs
│   ├── Items/
│   │   ├── CoinCollectable.cs
│   │   └── HealthPickup.cs
│   ├── Environment/
│   │   ├── MovingPlatform.cs
│   │   ├── ClimbRope.cs
│   │   ├── Spike.cs
│   │   ├── Checkpoint.cs
│   │   └── LevelExit.cs
│   └── Utils/
│       └── GameConstants.cs
```

---

## 🏗️ Arquitetura do Jogo

### Padrões de Design Utilizados

1. **Singleton**: GameManager, AudioManager, UIManager
2. **Observer**: Sistema de eventos para pausa, coleta, etc.
3. **State Machine**: Animator com transições de estado
4. **Strategy**: Diferentes tipos de movimento para inimigos

---

## 🎯 Próximos Passos para Conclusão

- [ ] Criar sprites para personagem, inimigos e ambiente
- [ ] Implementar 5 cenas de níveis no Unity
- [ ] Adicionar áudio (música e efeitos sonoros)
- [ ] Criar prefabs dos objetos
- [ ] Configurar Animator com animações
- [ ] Testar e fazer balanceamento de dificuldade
- [ ] Gravar vídeo pitch
- [ ] Build final do executável

---

## 📖 Documentação

Para entender os conceitos teóricos aplicados, leia o arquivo **TEORIA.md**.

---

## 👤 Autor

**Emerson Marques**  
Estudante de Game Development

---

## 📅 Data

Junho 2026

---

**Desenvolvido com ❤️ em Unity**
