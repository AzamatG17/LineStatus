namespace LineStatus.Api.Models.Entities;

public class cds_ticket
{
    public int ticket_id { get; set; }
    public int ticket_service_id { get; set; }
    public int ticket_servicegr_id { get; set; }
    public int ticket_get_time { get; set; }
    public int ticket_year { get; set; }
    public int ticket_day { get; set; }
    public int ticket_hour { get; set; }
    public int ticket_minute { get; set; }
    public int ticket_number { get; set; }
    public string ticket_label { get; set; }
    public int ticket_finished { get; set; }
    public int ticket_syncroned { get; set; }
    public int ticket_tasks { get; set; }
    public int ticket_language { get; set; }
    public int ticket_changed { get; set; }
    public int ticket_booked { get; set; }
    public int ticket_error { get; set; }
    public int branch_id { get; set; }
    public int ticket_booking_id { get; set; }
    public DateTime ticket_date { get; set; }
}
