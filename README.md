# 🏃‍♀️ Infinite Trails

**Trilha Infinita** é um jogo estilo *infinite runner* desenvolvido com Unity.  
O jogador percorre trilhas naturais infinitas enquanto coleta objetos e desvia de obstáculos. A cada nova partida, o desafio aumenta com a geração contínua de cenário e obstáculos.

---

## 🎮 Mecânica Principal

- O personagem corre automaticamente.
- O jogador pode se mover lateralmente para desviar de obstáculos.
- Itens colecionáveis (como latas) aumentam a pontuação.
- Ao colidir com obstáculos, o jogador perde e é levado para a tela de Game Over.
- A pontuação final é exibida ao fim da partida.

---

## ▶️ Como Rodar o Jogo

1. **Pré-requisitos**:
   - Unity 2021.3 ou superior
   - Sistema Windows/Mac com .NET instalado

2. **Passos**:
   - Clone este repositório:
     ```bash
     git clone https://github.com/SEU_USUARIO/trilha-infinita.git
     ```
   - Abra a pasta do projeto no Unity Hub
   - Clique em "Abrir"
   - Pressione o botão ▶ (Play) dentro da Unity para testar

---

## 🧠 Planejamento e Arquitetura

- O projeto foi dividido em **módulos simples** para facilitar a manutenção:
  - `PlayerController`: gerencia o movimento e entrada do jogador.
  - `ScoreManager`: sistema de pontos e exibição em UI.
  - `Spawner`: geração infinita de chão e obstáculos.
  - `Vida`: detecta colisões e envia o jogador à cena de Game Over.

- Utilizamos o padrão **`Singleton`** para gerenciamento global de score.
- Os dados são salvos entre cenas com `PlayerPrefs`.

---

## 🎨 Assets Utilizados

| Asset | Fonte | Licença |
|-------|-------|---------|
| Personagem | Unity Asset Store – Low Poly Character | Gratuito |
| Obstáculos (Pedras, latas) | Kenney.nl | CC0 |
| Sons (coleta, colisão) | freesound.org | CC0 |
| Fonte da UI | Google Fonts – Press Start 2P | Open Font License |
| Música de fundo | OpenGameArt.org | CC-BY 4.0 |

---

## 🤖 Uso de Inteligência Artificial

- Nome do jogo e ideias de título: **Gerado com auxílio do ChatGPT**
- Texto do README e organização da estrutura: **ChatGPT**
- Geração de código base para UI, score, colisão e spawn infinito: **ChatGPT**
- Sugestões de arquitetura e refatoração: **ChatGPT**

---

## 📂 Estrutura do Projeto

```bash
Assets/
├── Scripts/
│   ├── PlayerController.cs
│   ├── ScoreManager.cs
│   ├── Spawner.cs
│   └── Vida.cs
├── Prefabs/
├── Scenes/
│   ├── Menu
│   ├── Jogo
│   └── GameOver

