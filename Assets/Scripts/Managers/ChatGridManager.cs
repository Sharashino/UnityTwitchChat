using UnityEngine;

namespace TwitchChat.Managers
{
    public class ChatGridManager : MonoBehaviour
    {
        [SerializeField] private Transform chatWindow;
        [SerializeField] private Transform chatMessageBox;
        [SerializeField] private GameObject chatMessageBoxObj;

        void Start()
        {
            //SpawnMessageBoxes();
        }

        private void SpawnMessageBoxes()
        {
            RectTransform chatWindowRect = chatWindow.GetComponent<RectTransform>();
            RectTransform chatMessageBoxRect = chatMessageBox.GetComponent<RectTransform>();

            int messageBoxesNum = (int)(chatWindowRect.rect.height / chatMessageBoxRect.rect.height);
            Debug.Log(chatWindowRect.rect.height + " / " + chatMessageBoxRect.rect.height);


            for (int i = 0; i <= messageBoxesNum; i++)
            {
                GameObject newChatBox = Instantiate(chatMessageBoxObj);
                newChatBox.transform.parent = chatWindow;
            }
        }

        public void SpawnMessageBox(string username, string message)
        {
            //TODO spawn message box with a given nick and message
        }
    }
}

