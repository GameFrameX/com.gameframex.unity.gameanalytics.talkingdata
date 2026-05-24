<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" />

  # GameFrameX GameAnalytics TalkingData

  [![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata)](https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata/releases)
  [![License](https://img.shields.io/badge/license-MIT-orange.svg)](LICENSE.md)
  [![Documentation](https://img.shields.io/badge/docs-gameframex-blue.svg)](https://gameframex.doc.alianblank.com)

  All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

  [Documentation](https://gameframex.doc.alianblank.com) | [Quick Start](#quick-start)

  **English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)
</div>

---

## Project Overview

GameFrameX GameAnalytics TalkingData Component - Provides game developers with an interface for integrating and using game analytics functionality powered by TalkingData. This component wraps the TalkingData analytics SDK for seamless integration with the GameFrameX framework.

## Features

- **TalkingData Integration** - Seamless integration with TalkingData analytics SDK
- **Event Tracking** - Report game events and user behaviors
- **Framework Compatible** - Fully compatible with GameFrameX.GameAnalytics interface

## Installation

### Via Git URL (Recommended)

1. Open Package Manager in Unity Editor
2. Click the "+" button and select "Add package from git URL"
3. Enter the following URL:
   ```
   https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata.git
   ```

### Via manifest.json

Add the following to your project's `Packages/manifest.json`:

```json
{
  "dependencies": {
    "com.gameframex.unity.gameanalytics.talkingdata": "https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata.git"
  }
}
```

### Manual Installation

1. Download the latest release package
2. Extract it to your project's `Packages` directory
3. Unity will automatically recognize and load the package

## Quick Start

```csharp
using GameFrameX.GameAnalytics.Runtime;

public class TalkingDataExample : MonoBehaviour
{
    private void Awake()
    {
        // Get the GameAnalyticsComponent and initialize it
        var gameAnalyticsComponent = GameEntry.GetComponent<GameAnalyticsComponent>();
        gameAnalyticsComponent.Init();
    }
}
```

## Changelog

See [CHANGELOG.md](CHANGELOG.md) for details.

## License

This project is licensed under the MIT License - see [LICENSE.md](LICENSE.md) for details.
