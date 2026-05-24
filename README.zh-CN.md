<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" />

  # GameFrameX GameAnalytics TalkingData

  [![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata)](https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata/releases)
  [![License](https://img.shields.io/badge/license-MIT-orange.svg)](LICENSE.md)
  [![Documentation](https://img.shields.io/badge/docs-gameframex-blue.svg)](https://gameframex.doc.alianblank.com)

  独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使

  [文档](https://gameframex.doc.alianblank.com) | [快速开始](#快速开始)

  [English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)
</div>

---

## 项目简介

GameFrameX GameAnalytics TalkingData 组件 - 提供游戏开发者集成和使用基于 TalkingData 的游戏数据分析功能的接口。该组件封装了 TalkingData 分析 SDK，可与 GameFrameX 框架无缝集成。

## 特性

- **TalkingData 集成** - 与 TalkingData 分析 SDK 无缝集成
- **事件追踪** - 上报游戏事件和用户行为
- **框架兼容** - 完全兼容 GameFrameX.GameAnalytics 接口

## 安装

### 通过 Git URL 安装（推荐）

1. 在 Unity 编辑器中打开 Package Manager
2. 点击 "+" 按钮选择 "Add package from git URL"
3. 输入以下 URL：
   ```
   https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata.git
   ```

### 通过 manifest.json 安装

在项目的 `Packages/manifest.json` 文件中添加：

```json
{
  "dependencies": {
    "com.gameframex.unity.gameanalytics.talkingdata": "https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata.git"
  }
}
```

### 手动安装

1. 下载最新版本发布包
2. 解压到项目的 `Packages` 目录下
3. Unity 会自动识别并加载包

## 快速开始

```csharp
using GameFrameX.GameAnalytics.Runtime;

public class TalkingDataExample : MonoBehaviour
{
    private void Awake()
    {
        // 获取 GameAnalyticsComponent 并初始化
        var gameAnalyticsComponent = GameEntry.GetComponent<GameAnalyticsComponent>();
        gameAnalyticsComponent.Init();
    }
}
```

## 更新日志

详见 [CHANGELOG.md](CHANGELOG.md)。

## 开源协议

本项目基于 MIT 协议开源，详见 [LICENSE.md](LICENSE.md)。
