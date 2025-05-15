## HOMEPAGE

GameFrameX 的 GameAnalytics 游戏数据分析的组件

**GameAnalytics 游戏数据分析的组件 (Game Frame X Game Analytics(Talking Data))** - 提供游戏开发者集成和使用游戏数据分析的功能的接口。

# 使用文档(文档编写于GPT4)

## 简介

`GameAnalyticsComponent`是一个用于游戏数据分析的组件，它包含了不同类型的事件上报和计时器功能。该组件作为游戏框架的一部分，便于游戏开发者集成和使用游戏数据分析的功能。

# 使用方式(任选其一)

1. 直接在 `manifest.json` 的文件中的 `dependencies` 节点下添加以下内容
   ```json
      {"com.gameframex.unity.gameanalytics.talkingdata": "https://github.com/gameframex/com.gameframex.unity.gameanalytics.talkingdata.git"}
    ```
2. 在Unity 的`Packages Manager` 中使用`Git URL` 的方式添加库,地址为：https://github.com/gameframex/com.gameframex.unity.gameanalytics.talkingdata.git

3. 直接下载仓库放置到Unity 项目的`Packages` 目录下。会自动加载识别