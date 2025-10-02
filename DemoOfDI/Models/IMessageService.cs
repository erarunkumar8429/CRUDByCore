namespace DemoOfDI.Models
{
	public interface IMessageService
	{
		void SendMessage(string message);
		string SendMessage();
	}
}
