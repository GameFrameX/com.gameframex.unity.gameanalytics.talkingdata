<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" />

  # GameFrameX GameAnalytics TalkingData

  [![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata)](https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata/releases)
  [![License](https://img.shields.io/badge/license-MIT-orange.svg)](LICENSE.md)
  [![Documentation](https://img.shields.io/badge/docs-gameframex-blue.svg)](https://gameframex.doc.alianblank.com)

  インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

  [ドキュメント](https://gameframex.doc.alianblank.com) | [クイックスタート](#クイックスタート)

  [English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)
</div>

---

## プロジェクト概要

GameFrameX GameAnalytics TalkingData コンポーネント - TalkingData を搭載したゲームアナリティクス機能の統合と使用のためのインターフェースを提供します。TalkingData Analytics SDK をラップし、GameFrameX フレームワークとシームレスに統合します。

## 特徴

- **TalkingData 統合** - TalkingData Analytics SDK とシームレスに統合
- **イベントトラッキング** - ゲームイベントやユーザー行動のレポート
- **フレームワーク互換** - GameFrameX.GameAnalytics インターフェースと完全互換

## インストール

### Git URL 経由（推奨）

1. Unity エディタで Package Manager を開く
2. "+" ボタンをクリックし "Add package from git URL" を選択
3. 以下の URL を入力：
   ```
   https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata.git
   ```

### manifest.json 経由

プロジェクトの `Packages/manifest.json` に以下を追加：

```json
{
  "dependencies": {
    "com.gameframex.unity.gameanalytics.talkingdata": "https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata.git"
  }
}
```

### 手動インストール

1. 最新のリリースパッケージをダウンロード
2. プロジェクトの `Packages` ディレクトリに展開
3. Unity が自動的にパッケージを認識して読み込みます

## クイックスタート

```csharp
using GameFrameX.GameAnalytics.Runtime;

public class TalkingDataExample : MonoBehaviour
{
    private void Awake()
    {
        // GameAnalyticsComponent を取得して初期化
        var gameAnalyticsComponent = GameEntry.GetComponent<GameAnalyticsComponent>();
        gameAnalyticsComponent.Init();
    }
}
```

## Bootstrap 自己登録（チャネルレジストリ）

本パッケージは `TalkingDataAnalyticsBootstrap` により `BeforeSceneLoad` フェーズでコアパッケージ（`com.gameframex.unity.gameanalytics`）の `GameAnalyticsRegistry` に自己登録します。登録は即時に有効化され、すべての統計イベントが登録済みの全チャネルへブロードキャストされます。本パッケージが未インストールの場合、コードはストリップされ登録は発生しません。

チャネル設定は起動時の強型付け代入に変わりました（マネージャーは遅延生成されるため、シーン読み込み前に代入すれば有効です）：

```csharp
GameFrameX.GameAnalytics.TalkingData.Runtime.TalkingDataAnalyticsBootstrap.Setting =
    new GameFrameX.GameAnalytics.TalkingData.Runtime.GameAnalyticsTalkingDataSetting
    {
        appid = "あなたの AppId",
        channelId = "AppStore",
    };
```

**破壊的変更 / 移行ガイド:** 従来の `GameAnalyticsComponent` Inspector でのキー値ペアによる TalkingData 設定は削除され、効果がなくなりました。上記の強型付け設定をゲームの起動コードで使用してください。

## 変更履歴

詳細は [CHANGELOG.md](CHANGELOG.md) をご覧ください。

## ライセンス

このプロジェクトは MIT ライセンスの下で公開されています。詳細は [LICENSE.md](LICENSE.md) をご覧ください。
