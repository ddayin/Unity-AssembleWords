using UnityEngine;
using WanzyeeStudio;
using Photon.Chat;

namespace AssembleWords
{
    public class NetworkManager : BaseSingleton<NetworkManager>
    {
        private Photon.Chat.ChatClient m_ChatClient;
        private string userID;
        private string chatAppId;
        private string chatAppVersion;
        
        protected override void Awake()
        {
            base.Awake();
        }

        public void Init()
        {
            // In the C# SDKs, the callbacks are defined in the `IChatClientListener` interface.
            // In the demos, we instantiate and use the ChatClient class to implement the IChatClientListener interface.
            //m_ChatClient = new ChatClient( this );
            
            // Set your favourite region. "EU", "US", and "ASIA" are currently supported.
            m_ChatClient.ChatRegion = "EU";
            m_ChatClient.Connect(chatAppId, chatAppVersion, new AuthenticationValues(userID));
        }
    }
}