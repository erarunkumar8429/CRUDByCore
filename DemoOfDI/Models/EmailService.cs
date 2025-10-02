namespace DemoOfDI.Models
{
	public class EmailService : IMessageService
	{
		public string SendMessage()
		{
			return "Email sent";
		}
 
		void IMessageService.SendMessage(string message)
		{
			Console.WriteLine("Email sent" + message);
		}
	}

}
