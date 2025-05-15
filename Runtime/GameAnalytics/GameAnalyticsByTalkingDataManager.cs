using System.Collections.Generic;
using GameFrameX.GameAnalytics.Runtime;
using GameFrameX.Runtime;

namespace GameFrameX.GameAnalytics.TalkingData.Runtime
{
    /// <summary>
    /// 
    /// </summary>
    [UnityEngine.Scripting.Preserve]
    public sealed class GameAnalyticsByTalkingDataManager : BaseGameAnalyticsManager
    {
        private readonly Dictionary<string, object> m_publicProperties = new Dictionary<string, object>();
        private readonly Dictionary<string, string> Args = new Dictionary<string, string>();
        private GameAnalyticsTalkingDataSetting m_GameAnalyticsSetting;

        [UnityEngine.Scripting.Preserve]
        public override void Init(Dictionary<string, string> args)
        {
            foreach (var arg in args)
            {
                Args[arg.Key] = arg.Value;
            }

            Log.Info("GameAnalyticsByTalkingDataManager Init, args:" + Utility.Json.ToJson(args));
            m_GameAnalyticsSetting = Utility.Json.ToObject<GameAnalyticsTalkingDataSetting>(Utility.Json.ToJson(args));

            if (m_GameAnalyticsSetting == null)
            {
                Log.Error("GameAnalyticsByTalkingDataManager Init: GameAnalyticsTalkingDataSetting is null");
                return;
            }

            TalkingDataSDKConfig config = TalkingDataSDKConfig.CreateConfig();
            config.SetIMEIAndMEIDEnabled(true) //允许收集IMEI和MEID
                  .SetMACEnabled(true) //允许收集MAC
                  .SetAppListEnabled(false) //不允许收集应用列表
                  .SetLocationEnabled(true) //允许收集位置信息
                  .SetWifiEnabled(true); //允许收集网络信息
            TalkingDataSDK.SetConfig(config);
#if UNITY_IOS
            TalkingDataSDK.BackgroundSessionEnabled();
#endif
            TalkingDataSDK.InitSDK(m_GameAnalyticsSetting.appid, m_GameAnalyticsSetting.channelId, string.Empty);
            TalkingDataSDK.StartA();
        }

        [UnityEngine.Scripting.Preserve]
        public override void ManualInit(Dictionary<string, string> args)
        {
            Init(args);
        }

        [UnityEngine.Scripting.Preserve]
        public override bool IsManualInit()
        {
            return true;
        }

        [UnityEngine.Scripting.Preserve]
        public override void SetPublicProperties(string key, object value)
        {
            m_publicProperties[key] = value;
            foreach (var kv in m_publicProperties)
            {
                TalkingDataSDK.SetGlobalKV(kv.Key, kv.Value);
            }
        }

        [UnityEngine.Scripting.Preserve]
        public override void ClearPublicProperties()
        {
            foreach (var kv in m_publicProperties)
            {
                TalkingDataSDK.RemoveGlobalKV(kv.Key);
            }

            m_publicProperties.Clear();
        }

        [UnityEngine.Scripting.Preserve]
        public override Dictionary<string, object> GetPublicProperties()
        {
            return m_publicProperties;
        }

        [UnityEngine.Scripting.Preserve]
        public override void StartTimer(string eventName)
        {
            Log.Warning("GameAnalyticsByTalkingDataManager StartTimer is not supported");
        }

        [UnityEngine.Scripting.Preserve]
        public override void PauseTimer(string eventName)
        {
            Log.Warning("GameAnalyticsByTalkingDataManager PauseTimer is not supported");
        }

        [UnityEngine.Scripting.Preserve]
        public override void ResumeTimer(string eventName)
        {
            Log.Warning("GameAnalyticsByTalkingDataManager ResumeTimer is not supported");
        }

        [UnityEngine.Scripting.Preserve]
        public override void StopTimer(string eventName)
        {
            Log.Warning("GameAnalyticsByTalkingDataManager StopTimer is not supported");
        }

        [UnityEngine.Scripting.Preserve]
        public override void Event(string eventName)
        {
            TalkingDataSDK.OnEvent(eventName, null, null);
        }

        [UnityEngine.Scripting.Preserve]
        public override void Event(string eventName, float eventValue)
        {
            var parameters = new Dictionary<string, object>
            {
                ["eventValue"] = eventValue,
            };
            TalkingDataSDK.OnEvent(eventName, parameters);
        }

        [UnityEngine.Scripting.Preserve]
        public override void Event(string eventName, Dictionary<string, object> customF)
        {
            TalkingDataSDK.OnEvent(eventName, customF);
        }

        [UnityEngine.Scripting.Preserve]
        public override void Event(string eventName, float eventValue, Dictionary<string, object> customF)
        {
            customF["eventValue"] = eventValue;
            TalkingDataSDK.OnEvent(eventName, customF);
        }

        [UnityEngine.Scripting.Preserve]
        public override void SetPlayerId(string playerId)
        {
            var profile = new TalkingDataProfile();
            profile.SetName(playerId);
            TalkingDataSDK.OnProfileUpdate(profile);
        }
    }
}