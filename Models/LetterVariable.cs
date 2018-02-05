namespace FriendLetter.Models
{
  public class LetterVariable
  {
    private string _recipient;
    private string _sender;
    private string _loc;
    private string _souv;

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

    public void SetSouv(string newSouv)
    {
      _souv = newSouv;
    }

    public string GetSouv()
    {
      return _souv;
    }

    public void SetLoc(string newLoc)
    {
      _loc = newLoc;
    }
    
    public string GetLoc()
    {
      return _loc;
    }

  }
}
