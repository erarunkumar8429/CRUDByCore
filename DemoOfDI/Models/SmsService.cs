namespace DemoOfDI.Models
{
	public class SmsService : IMessageService
	{
		public void SendMessage(string message)
		{
			Console.WriteLine("Sent SMS" + message);
		}

		public string SendMessage()
		{
			return ("Sent SMS");
		}
	}
}
