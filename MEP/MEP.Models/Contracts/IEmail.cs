namespace MEP.Models.Contracts
{
    public interface IEmail
    {
        string From { get; set; }

        string[] To { get; set; }

        string Subject { get; set; }

        string Body { get; set; }
    }
}