﻿namespace SlackNet.Events.Messages
{
    /// <summary>
    /// Sent when the purpose for a channel is changed.
    /// </summary>
    public class ChannelPurpose : MessageEvent
    {
        public string Purpose { get; set; }
    }
}