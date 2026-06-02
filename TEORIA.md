# 📚 Relatório Teórico: Pixel Runner - A Fuga do Castelo

## Sumário Executivo

Este documento apresenta os fundamentos teóricos aplicados no desenvolvimento do jogo de plataforma 2D "Pixel Runner: A Fuga do Castelo", desenvolvido em Unity. O projeto demonstra a aplicação prática de conceitos de Game Development, incluindo design de mecânicas, arquitetura de software e experiência do usuário em games.

---

## 1. Introdução

### 1.1 Contexto
Os jogos de plataforma 2D são fundamentais na história dos videogames, começando com clássicos como Donkey Kong (1981) e Super Mario Bros (1985). Este gênero permanece relevante até hoje, oferecendo uma excelente base para aprender game development.

### 1.2 Objetivos do Projeto
- Demonstrar domínio de Unity e C#
- Aplicar conceitos de game design e level design
- Criar uma experiência jogável e divertida
- Produzir código profissional e bem estruturado
- Gerar um portfólio de qualidade comercial

---

## 2. Princípios de Jogos de Plataforma 2D

### 2.1 Características Fundamentais

#### 2.1.1 Mecânica Core
A mecânica central de um jogo de plataforma é o **movimento e pulo do personagem**. Diferentemente de outros gêneros:
- Foco em controle preciso
- Feedback imediato de entrada do jogador
- Progressão através de habilidades de movimento

#### 2.1.2 Design de Espaço
```
Princípio: O espaço é o maestro
```
No design de plataforma, o espaço físico comunica ao jogador:
- Onde ele pode ir
- Onde não pode ir
- Quais desafios o esperam
- Qual é a progressão esperada

#### 2.1.3 Curva de Dificuldade
A dificuldade deve aumentar gradualmente, com platôs para assimilação de novas mecânicas.

### 2.2 Elementos Essenciais

| Elemento | Função | Exemplo |
|----------|--------|---------|
| Plataformas | Superfícies onde o jogador caminha | Blocos, Platforms |
| Obstáculos | Impedem movimento direto | Picos, Buracos |
| Coletáveis | Aumentam score | Moedas, Items |
| Inimigos | Desafio/Perigo | Patrulheiros |
| Checkpoint | Salvam progresso | Pontos de salvação |
| Meta | Objetivo final | Portal de Saída |

---

## 3. Planejamento do Projeto e Mecânicas

### 3.1 Visão Geral

**Conceito**: Aventureiro escapa de castelo medieval progressivamente mais desafiador

**Pilares de Design**:
1. **Acessibilidade**: Fácil começar, difícil dominar
2. **Progressão Clara**: Cada nível adiciona um novo desafio
3. **Feedback Imediato**: O jogador sempre sabe o que aconteceu
4. **Replayability**: Desafio em coletar 100% das moedas

### 3.2 Mecânicas Principais

#### 3.2.1 Movimento Horizontal
- Aceleração suave (não instantânea)
- Desaceleração ao soltar controle
- Direção visual muda com movimento

#### 3.2.2 Sistema de Pulo
```csharp
// Estrutura básica
if (CanJump && Input.GetKeyDown(KeyCode.Space))
{
    velocidadeVertical = Mathf.Sqrt(alturaDesejada * -2 * gravidade);
    CanJump = false;
}
```

**Conceitos Aplicados**:
- **Variable Jump**: Altura depende do tempo que segura botão
- **Apex Hang**: Gravidade diminui no topo para sensação de flutuação
- **Coyote Time**: Permite pulo por ~100ms após sair da plataforma

#### 3.2.3 Pulo Duplo (Double Jump)
- Introduz conceito de **movimento 2.5D**
- Permite vertical que seria impossível com pulo único
- Motiva jogador a explorar todos os caminhos

#### 3.2.4 Corrida (Sprint)
- Aumenta velocidade em 1.5x
- Permite ultrapassa gaps maiores
- Timing correto salva em momentos críticos

#### 3.2.5 Escalada
- Novo eixo de movimento (apenas Y)
- Permite alcançar áreas altas
- Diferente feel de movimento horizontal

---

## 4. Design de Níveis com Progressão de Dificuldade

### 4.1 Progressão por Nível

| Nível | Mecânicas Novas | Desafio | Moedas |
|-------|-----------------|---------|--------|
| 1 | Pulo básico | Timing simples | 10 |
| 2 | Pulo duplo | Gaps maiores | 15 |
| 3 | Inimigos | Padrões previsíveis | 20 |
| 4 | Escalada | Combinação de habilidades | 25 |
| 5 (Boss) | Tudo | Improviso e reflexo | 30 |

### 4.2 Técnicas de Level Design

#### 4.2.1 "Teach by Example"
O nível ensina sem tutoriais através do design do espaço:
```
Nível 1: [Chão] → [Pequeno Gap] → [Chão]
         Força jogador a pular

Nível 2: [Chão] → [Grande Gap] → [Chão]
         Requer pulo duplo
```

#### 4.2.2 "Signifiers"
Comunica perigo através de design:
- **Seguro**: Plataforma sólida, verde, larga
- **Perigoso**: Picos vermelhos, fogo, inimigos
- **Coletável**: Brilha, amarelo, efeito de partícula

#### 4.2.3 "Checkpoint System"
- Evita frustração excessiva
- Permite experimentação
- Feedback positivo ao progresso

---

## 5. Interatividade, HUD e Feedback

### 5.1 Hierarquia de Feedback

```
1. PRIMÁRIO: Resposta imediata ao input
   - Movimento do personagem
   - Som de pulo
   - Animação

2. SECUNDÁRIO: Contexto do jogo
   - HUD atualizado
   - Efeitos visuais (partículas)
   - Feedback de inimigo

3. TERCIÁRIO: Contexto extendido
   - Câmera shake
   - Zoom out/in
   - Transições entre cenas
```

### 5.2 HUD Design

Elementos essenciais:
- **Vidas**: Alerta visual quando baixo
- **Pontuação**: Moedas coletadas / total
- **Tempo**: Facilita speedrun
- **Checkpoint**: Último ponto de salvação

### 5.3 Feedback Visual

- **Partículas**: Ao coletar moeda
- **Animações**: Hit, Coleta, Morte
- **Cores**: Verde (seguro), Vermelho (perigo), Amarelo (item)

### 5.4 Feedback Sonoro

- **Pulo**: Som transiente (ataque rápido)
- **Coleta**: Som harmônico (brilhante)
- **Morte**: Som dissonante
- **Vitória**: Fanfarra

---

## 6. Uso de Assets, Sprites e Animações na Unity

### 6.1 Pipeline de Sprites

```
Imagem Original (PNG)
    ↓
Unity Import Settings (Point filter, no compression)
    ↓
Sprite Renderer
    ↓
Animator (FSM)
    ↓
Renderização na tela
```

### 6.2 Sprite Settings

- **Filter Mode**: Point (não suavizado)
- **Compression**: None (mantém qualidade)
- **Max Size**: 2048

### 6.3 Animator States

State Machine com transições condicionais:
```
[Idle] → [Run] → [Jump] → [Fall] → [Climb]
```

---

## 7. Lógica de Programação em C# e Estrutura do Game Loop

### 7.1 Ciclo Principal

```
1. Capturar Input
2. Update Lógica do Jogo
3. Update Física
4. Update Câmera
5. Renderizar
6. Audio Play
```

### 7.2 Arquitetura de Managers

Padrão Singleton para gerentes:
- `GameManager`: Estado global
- `LevelManager`: Controle de níveis
- `UIManager`: Atualização de HUD
- `AudioManager`: Reprodução de sons

### 7.3 Padrão MVC Adaptado

```
MODEL (Data) → VIEW (UI) → CONTROLLER (Input/Logic)
```

---

## 8. Estratégias de Inserção de Áudio e Efeitos Sonoros

### 8.1 Camadas de Áudio

```
Música de Fundo (Loop, -6dB)
Nível de Ambiente (Vento)
SFX Constantes (Passos)
SFX Ocasionais (Pulo)
SFX Impacto (Coleta, morte)
```

### 8.2 Sincronização Crítica

| Ação | Latência Máxima |
|------|-----------------|
| Pulo | 20ms |
| Coleta | 50ms |
| Morte | 100ms |
| Vitória | 200ms |

---

## 9. Conclusão

O desenvolvimento de "Pixel Runner" demonstra aplicação prática de:
- Teoria de Game Design
- Programação em C#
- Desenvolvimento em Unity
- Level Design
- UX/UI

Este projeto funciona como portfólio que mostra compreensão profunda não apenas de "como fazer", mas de "por que" cada decisão foi tomada.

---

## 10. Referências

1. **Liz England** - Game Production Handbook
2. **Marc LeBlanc** - MDA Framework
3. **Raph Koster** - Theory of Fun for Game Design
4. **Game Maker's Toolkit** - YouTube Channel
5. **Extra Credits** - Game Design Series

---

**Data**: Junho 2026 | **Autor**: Emerson Marques | **Disciplina**: Game Development
