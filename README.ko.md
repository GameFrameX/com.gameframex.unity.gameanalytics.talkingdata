<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" />

  # GameFrameX GameAnalytics TalkingData

  [![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata)](https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata/releases)
  [![License](https://img.shields.io/badge/license-MIT-orange.svg)](LICENSE.md)
  [![Documentation](https://img.shields.io/badge/docs-gameframex-blue.svg)](https://gameframex.doc.alianblank.com)

  인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현

  [문서](https://gameframex.doc.alianblank.com) | [빠른 시작](#빠른-시작)

  [English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**
</div>

---

## 프로젝트 개요

GameFrameX GameAnalytics TalkingData 컴포넌트 - TalkingData 기반 게임 분석 기능 통합 및 사용을 위한 인터페이스를 제공합니다. TalkingData Analytics SDK를 래핑하여 GameFrameX 프레임워크와 원활하게 통합합니다.

## 특징

- **TalkingData 통합** - TalkingData Analytics SDK와 원활한 통합
- **이벤트 추적** - 게임 이벤트 및 사용자 행동 보고
- **프레임워크 호환** - GameFrameX.GameAnalytics 인터페이스와 완전 호환

## 설치

### Git URL을 통해 설치 (권장)

1. Unity 에디터에서 Package Manager 열기
2. "+" 버튼을 클릭하고 "Add package from git URL" 선택
3. 다음 URL 입력:
   ```
   https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata.git
   ```

### manifest.json을 통해 설치

프로젝트의 `Packages/manifest.json`에 다음을 추가:

```json
{
  "dependencies": {
    "com.gameframex.unity.gameanalytics.talkingdata": "https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.talkingdata.git"
  }
}
```

### 수동 설치

1. 최신 릴리스 패키지 다운로드
2. 프로젝트의 `Packages` 디렉토리에 압축 해제
3. Unity가 자동으로 패키지를 인식하고 로드합니다

## 빠른 시작

```csharp
using GameFrameX.GameAnalytics.Runtime;

public class TalkingDataExample : MonoBehaviour
{
    private void Awake()
    {
        // GameAnalyticsComponent 가져오기 및 초기화
        var gameAnalyticsComponent = GameEntry.GetComponent<GameAnalyticsComponent>();
        gameAnalyticsComponent.Init();
    }
}
```

## Bootstrap 자동 등록(채널 레지스트리)

이 패키지는 `TalkingDataAnalyticsBootstrap`을 통해 `BeforeSceneLoad` 단계에서 코어 패키지(`com.gameframex.unity.gameanalytics`)의 `GameAnalyticsRegistry`에 자동 등록됩니다. 등록 즉시 활성화되며 모든 통계 이벤트가 등록된 전체 채널에 브로드캐스트됩니다. 이 패키지가 설치되지 않으면 코드가 제거되어 등록이 발생하지 않습니다.

채널 설정은 시작 시점의 강타입 할당으로 변경되었습니다(매니저는 지연 생성되므로 씬 로드 전에 할당하면 됩니다):

```csharp
GameFrameX.GameAnalytics.TalkingData.Runtime.TalkingDataAnalyticsBootstrap.Setting =
    new GameFrameX.GameAnalytics.TalkingData.Runtime.GameAnalyticsTalkingDataSetting
    {
        appid = "당신의 AppId",
        channelId = "AppStore",
    };
```

**파괴적 변경 / 마이그레이션:** 기존 `GameAnalyticsComponent` Inspector에서 키-값으로 TalkingData를 구성하던 방식은 제거되어 더 이상 적용되지 않습니다. 위의 강타입 설정을 게임 시작 코드에서 사용하세요.

## 변경 로그

자세한 내용은 [CHANGELOG.md](CHANGELOG.md)를 참조하세요.

## 라이선스

이 프로젝트는 MIT 라이선스에 따라 배포됩니다. 자세한 내용은 [LICENSE.md](LICENSE.md)를 참조하세요.
