<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" />

  # GameFrameX GameAnalytics TalkingData

  [![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata)](https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata/releases)
  [![License](https://img.shields.io/badge/license-MIT-orange.svg)](LICENSE.md)
  [![Documentation](https://img.shields.io/badge/docs-gameframex-blue.svg)](https://gameframex.doc.alianblank.com)

  獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

  [文檔](https://gameframex.doc.alianblank.com) | [快速開始](#快速開始)

  [English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)
</div>

---

## 項目簡介

GameFrameX GameAnalytics TalkingData 元件 - 提供遊戲開發者整合和使用基於 TalkingData 的遊戲資料分析功能的介面。該元件封裝了 TalkingData 分析 SDK，可與 GameFrameX 框架無縫整合。

## 特性

- **TalkingData 整合** - 與 TalkingData 分析 SDK 無縫整合
- **事件追蹤** - 上報遊戲事件和使用者行為
- **框架相容** - 完全相容 GameFrameX.GameAnalytics 介面

## 安裝

### 透過 Git URL 安裝（推薦）

1. 在 Unity 編輯器中開啟 Package Manager
2. 點擊 "+" 按鈕選擇 "Add package from git URL"
3. 輸入以下 URL：
   ```
   https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata.git
   ```

### 透過 manifest.json 安裝

在專案的 `Packages/manifest.json` 檔案中新增：

```json
{
  "dependencies": {
    "com.gameframex.unity.gameanalytics.talkingdata": "https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata.git"
  }
}
```

### 手動安裝

1. 下載最新版本發佈包
2. 解壓縮到專案的 `Packages` 目錄下
3. Unity 會自動辨識並載入包

## 快速開始

```csharp
using GameFrameX.GameAnalytics.Runtime;

public class TalkingDataExample : MonoBehaviour
{
    private void Awake()
    {
        // 取得 GameAnalyticsComponent 並初始化
        var gameAnalyticsComponent = GameEntry.GetComponent<GameAnalyticsComponent>();
        gameAnalyticsComponent.Init();
    }
}
```

## 更新日誌

詳見 [CHANGELOG.md](CHANGELOG.md)。

## 開源協議

本專案基於 MIT 協議開源，詳見 [LICENSE.md](LICENSE.md)。
