using System;
using GameFrameX.GameAnalytics.Runtime;
using UnityEngine;

namespace GameFrameX.GameAnalytics.TalkingData.Runtime
{
    [Serializable]
    [UnityEngine.Scripting.Preserve]
    public sealed class GameAnalyticsTalkingDataSetting : BaseGameAnalyticsSetting
    {
        [Header("appid")] [UnityEngine.Scripting.Preserve]
        public string appid;

        [Header("渠道名\n 如果在GooglePlay官方市场上架，channelId必须设置为GooglePlay或play.google.com，\n 如果在AppStore官方市场上架，channelId必须设置为AppStore")] [UnityEngine.Scripting.Preserve]
        public string channelId;
    }
}