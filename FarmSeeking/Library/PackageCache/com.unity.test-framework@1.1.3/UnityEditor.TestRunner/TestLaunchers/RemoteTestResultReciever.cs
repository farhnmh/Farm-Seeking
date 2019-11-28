<<<<<<< HEAD
using System;
using UnityEditor.Networking.PlayerConnection;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.TestRunner.TestLaunchers;

namespace UnityEditor.TestTools.TestRunner
{
    [Serializable]
    internal class RemoteTestResultReciever
    {
        public void RunStarted(MessageEventArgs messageEventArgs)
        {
        }

        public void RunFinished(MessageEventArgs messageEventArgs)
        {
            EditorConnection.instance.Send(PlayerConnectionMessageIds.quitPlayerMessageId, null, messageEventArgs.playerId);
            EditorConnection.instance.DisconnectAll();
        }
    }
}
=======
using System;
using UnityEditor.Networking.PlayerConnection;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.TestRunner.TestLaunchers;

namespace UnityEditor.TestTools.TestRunner
{
    [Serializable]
    internal class RemoteTestResultReciever
    {
        public void RunStarted(MessageEventArgs messageEventArgs)
        {
        }

        public void RunFinished(MessageEventArgs messageEventArgs)
        {
            EditorConnection.instance.Send(PlayerConnectionMessageIds.quitPlayerMessageId, null, messageEventArgs.playerId);
            EditorConnection.instance.DisconnectAll();
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
