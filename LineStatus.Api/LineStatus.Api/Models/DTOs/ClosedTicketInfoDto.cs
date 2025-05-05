namespace LineStatus.Api.Models.DTOs;

public class ClosedTicketInfoDto
{
    public string AdminTime { get; set; }
    public int CallsCount { get; set; }
    public string ClerkName { get; set; }
    public string CloseTime { get; set; }
    public string DeskNumber { get; set; }
    public string TicketStatus { get; set; }
    public string TimeFirstCall { get; set; }
    public string WaitingTime { get; set; }
}
