
namespace FriendLetter.Models
{
    public class LetterVariable
    {
        private string _recipient; //first property
        private string _sender; //second property

        public string GetRecipient()
        {
            return _recipient;
        }
        
        public void SetRecipient(string newRecipient)
        {
            _recipient = newRecipient;
        }

        public string GetSender()
        {
            return _sender;
        }

        public void SetSender(string newSender)
        {
            _sender = newSender;
        }
    }
}
