# Match3c - Unity Match-3 Puzzle Game

A polished match-3 puzzle game built in Unity, showcasing core gameplay mechanics and clean code architecture. This project demonstrates fundamental game development concepts including board management, tile swapping, match detection, and scoring systems.

## 🎮 Game Overview

Match3c is a classic match-3 puzzle game where players swap adjacent tiles to create matches of 3 or more identical items. The game features smooth animations, satisfying sound effects, and an intuitive scoring system.

## ✨ Features Implemented

### Core Gameplay
- **Grid-based Board System**: 2D grid layout with customizable dimensions
- **Tile Swapping**: Smooth animated swapping of adjacent tiles
- **Match Detection**: Flood-fill algorithm for finding connected tiles
- **Scoring System**: Points awarded based on match size and item values
- **Audio Feedback**: Sound effects for tile collection

### Technical Features
- **Singleton Pattern**: Efficient board and score management
- **Event-driven Input**: Click-based tile selection system
- **Smooth Animations**: DOTween integration for polished tile movements
- **Scriptable Objects**: Flexible item system with sprite and value properties
- **Responsive UI**: Real-time score display updates

## 🏗️ Project Structure

```
Assets/
├── Scripts/           # Core game logic
│   ├── Board.cs      # Main game board controller
│   ├── Tile.cs       # Individual tile behavior
│   ├── Item.cs       # Item data structure
│   ├── ScoreCounter.cs # Score tracking system
│   ├── ItemDatabase.cs # Item management
│   └── Row.cs        # Row container for tiles
├── Scenes/           # Game scenes
│   └── SampleScene.unity
├── Resources/        # Runtime-loaded assets
│   └── Items/       # Item scriptable objects
├── Tile_Types/      # Tile type definitions
├── Prefabs/         # Reusable game objects
├── Spirites/        # Game sprites and textures
└── Audio/           # Sound effects and music
```

## 🎯 Core Gameplay Loop

1. **Board Initialization**: Random tile generation with various item types
2. **Player Input**: Click to select tiles for swapping
3. **Tile Validation**: Ensure selected tiles are adjacent
4. **Swap Animation**: Smooth movement of tile icons
5. **Match Detection**: Flood-fill algorithm finds connected tiles
6. **Match Resolution**: Remove matched tiles and award points
7. **Board Refill**: Generate new tiles to maintain gameplay

## 🔧 Technical Implementation

### Board Management (`Board.cs`)
- Singleton pattern for global access
- 2D array structure for efficient tile storage
- Neighbor validation for legal moves
- Match detection and resolution logic

### Tile System (`Tile.cs`)
- Individual tile behavior and state
- Neighbor relationship management
- Flood-fill algorithm for match detection
- Click event handling

### Item System (`Item.cs`)
- ScriptableObject-based design
- Configurable sprites and point values
- Runtime loading from Resources folder

### Animation System
- DOTween integration for smooth tile movements
- Coordinated sequences for swap and pop animations
- Configurable animation durations

## 🎨 Game Assets

The game includes various item types with unique sprites and point values:
- **Vegetables**: Tomato, Pepper, Onion, Leaf
- **Grains**: Corn, Bean
- **Other**: Zucchini

Each item has configurable properties for easy balancing and expansion.

## 🚀 Getting Started

### Prerequisites
- Unity 2022.3 LTS or later
- Basic C# knowledge
- DOTween package (included in project)

### Installation
1. Clone or download the project
2. Open `Match3c.sln` in Unity Hub
3. Open the project in Unity
4. Navigate to `Assets/Scenes/SampleScene.unity`
5. Press Play to test the game

### Controls
- **Mouse Click**: Select tiles for swapping
- **Select 2 adjacent tiles**: Automatically swap and check for matches

## 🎯 Game Rules

- Swap adjacent tiles to create matches of 3 or more
- Matches are automatically detected and removed
- Points are awarded based on match size × item value
- New tiles are generated to fill empty spaces
- Game continues indefinitely for high score chasing

## 🔮 Future Enhancements

While the core gameplay is complete, potential additions could include:
- Level progression system
- Special tile types (bombs, line clearers)
- Time-based challenges
- Power-ups and combos
- Multiple difficulty modes
- Mobile touch support
- Particle effects and visual polish

## 🛠️ Development Notes

### Architecture Decisions
- **Singleton Pattern**: Used for Board and ScoreCounter for global access
- **Event-driven Design**: Click events drive the game flow
- **Separation of Concerns**: Clear separation between data, logic, and presentation
- **Scriptable Objects**: Flexible item system for easy content creation

### Performance Considerations
- Efficient 2D array access for tile operations
- Minimal object allocation during gameplay
- Optimized flood-fill algorithm for match detection

## 📱 Build Information

- **Unity Version**: 2022.3.16f1 LTS
- **Target Platforms**: Windows, macOS, Linux (expandable)
- **Input System**: Unity's new Input System
- **Rendering**: Universal Render Pipeline compatible

## 👨‍💻 Portfolio Showcase

This project demonstrates:
- **Game Design**: Understanding of core gameplay loops
- **Programming**: Clean C# code with proper architecture
- **Unity Knowledge**: Proficiency with Unity's core systems
- **Problem Solving**: Efficient algorithms for game mechanics
- **User Experience**: Smooth animations and responsive controls

## 📄 License

This project is created for portfolio purposes. Feel free to use as reference for learning Unity game development concepts.

---

**Developer**: Esat Arslan 
**Project Type**: Portfolio Game  
**Genre**: Puzzle/Match-3  
**Development Time**: 1 Day  
**Status**: Core Gameplay Complete
